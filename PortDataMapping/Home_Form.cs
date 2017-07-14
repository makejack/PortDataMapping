using System.IO;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PortDataMapping
{
    public partial class Home_Form : Form
    {
        private SerialPortEx _mPort;

        private List<string> _portNames;

        private List<byte> _portDatas;

        private int _interval = 10;

        private int _heightValue = 1;

        private Pen _backgroundPen;

        private Pen _linePen;

        private int _ivScroll;


        public Home_Form()
        {
            InitializeComponent();

            this.Load += Home_Form_Load;
            this.Shown += Home_Form_Shown;
            this.Resize += Home_Form_Resize;

            p_Left.Paint += P_Left_Paint;
            p_Right.Paint += P_right_Paint;
            btn_Port.Click += Btn_Port_Click;
            ud_Interval.ValueChanged += Ud_Interval_ValueChanged;
            ud_Data.ValueChanged += Ud_Data_ValueChanged;
            hsb_Scroll.ValueChanged += Hsb_Scroll_ValueChanged;
            vsb_Scroll.ValueChanged += Vsb_Scoll_ValueChanged;
            btn_Clear.Click += Btn_Clear_Click;
        }

        private void P_right_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.DrawLine(_backgroundPen, 0, 0, 0, p_Right.Height);
            }
        }

        private void Vsb_Scoll_ValueChanged(object sender, EventArgs e)
        {
            int value = vsb_Scroll.Maximum - vsb_Scroll.Value;
            if (value != _ivScroll)
            {
                LineInvalidate();
                _ivScroll = value;
                //p_Left.Invalidate();
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            _portDatas.Clear();
            hsb_Scroll.Maximum = 0;
            hsb_Scroll.Enabled = false;
            p_Left.Invalidate();
        }

        private void Hsb_Scroll_ValueChanged(object sender, EventArgs e)
        {
            LineInvalidate();
        }

        private void Ud_Data_ValueChanged(object sender, EventArgs e)
        {
            if (ud_Data.Value != _heightValue)
            {
                _heightValue = (int)ud_Data.Value;
                _portDatas.Clear();
                p_Left.Invalidate();
            }
        }

        private void Home_Form_Resize(object sender, EventArgs e)
        {
            p_Left.Invalidate();
        }

        private void Ud_Interval_ValueChanged(object sender, EventArgs e)
        {
            if (ud_Interval.Value != _interval)
            {
                _interval = (int)ud_Interval.Value;
                int columncount = (int)(p_Left.Width / _interval);
                if (_portDatas.Count > columncount)
                {
                    hsb_Scroll.Maximum = _portDatas.Count - columncount;
                    hsb_Scroll.Enabled = true;
                }
                else
                {
                    hsb_Scroll.Enabled = false;
                    hsb_Scroll.Maximum = 0;
                }
                p_Left.Invalidate();
            }
        }

        private void LineInvalidate()
        {
            p_Left.Invalidate(new Rectangle(0, p_Left.Height - (_ivScroll * _interval) - _interval - _interval, p_Left.Width, _interval * 3));
        }

        private void P_Left_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                //绘制行
                int rowcount = p_Left.Height / _interval;
                for (int i = 0; i <= rowcount; i++)
                {
                    g.DrawLine(_backgroundPen, 0, p_Left.Height - i * _interval, p_Left.Width, p_Left.Height - i * _interval);
                }

                rowcount--;
                vsb_Scroll.Maximum = rowcount;
                if (_ivScroll > rowcount)
                {
                    _ivScroll = 1;
                }
                vsb_Scroll.Value = rowcount - _ivScroll;

                //绘制列
                int columncount = p_Left.Width / _interval;
                for (int i = 1; i <= columncount; i++)
                {
                    g.DrawLine(_backgroundPen, i * _interval, 0, i * _interval, p_Left.Height);
                }

                //绘制线
                int y = _ivScroll * _interval;
                bool isheight = false;
                for (int i = hsb_Scroll.Value, j = 0; i < _portDatas.Count && j < columncount; i++, j++)
                {
                    if (_portDatas[i] == _heightValue)
                    {
                        if (!isheight && j != 0)
                        {
                            g.DrawLine(_linePen, new Point(j * _interval, p_Left.Height - y - _interval), new Point(j * _interval, p_Left.Height - y));
                        }
                        g.DrawLine(_linePen, new Point(j * _interval, (p_Left.Height - y - _interval)), new Point(j * _interval + _interval, (p_Left.Height - y - _interval)));
                        isheight = true;
                    }
                    else
                    {
                        if (isheight)
                        {
                            g.DrawLine(_linePen, new Point(j * _interval, p_Left.Height - y - _interval), new Point(j * _interval, p_Left.Height - y - 1));
                        }
                        g.DrawLine(_linePen, new Point(j * _interval, (p_Left.Height - y - 1)), new Point(j * _interval + _interval, (p_Left.Height - y - 1)));
                        isheight = false;
                    }
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void Home_Form_Shown(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            _portDatas = new List<byte>();
            _backgroundPen = new Pen(Color.FromArgb(221, 221, 221), 1);
            _linePen = new Pen(Brushes.Blue, 1);

            cb_BaudRate.SelectedIndex = 1;
            cb_StopBit.SelectedIndex = 0;
            cb_DataBit.SelectedIndex = 3;
            cb_Parity.SelectedIndex = 0;
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            _mPort = new SerialPortEx();
            _mPort.PortChange += _mPort_PortChange;
            _mPort.DataReceived += _mPort_DataReceived;
            _mPort.SerialPortCountChange += _mPort_SerialPortCountChange;
            _mPort.Start();
        }

        private void Btn_Port_Click(object sender, EventArgs e)
        {
            if (_mPort.IsOpen)
            {
                try
                {
                    _mPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string portname = cb_PortNames.SelectedItem.ToString();
                int baudrate = 0x0C;
                switch (cb_BaudRate.SelectedIndex)
                {
                    case 1:
                        baudrate = 0x0D;
                        break;
                    case 2:
                        baudrate = 0x0E;
                        break;
                }
                int databit = 0x00;
                switch (cb_DataBit.SelectedIndex)
                {
                    case 1:
                        databit = 0x01;
                        break;
                    case 2:
                        databit = 0x02;
                        break;
                    case 3:
                        databit = 0x03;
                        break;
                }
                int stopbit = cb_StopBit.SelectedIndex == 0 ? 0x00 : 0x04;
                int parity = 0x00;
                switch (cb_Parity.SelectedIndex)
                {
                    case 1:
                        parity = 0x08;
                        break;
                    case 2:
                        parity = 0x38;
                        break;
                    case 3:
                        parity = 0x28;
                        break;
                    case 4:
                        parity = 0x18;
                        break;
                }
                _mPort.PortName = portname;
                _mPort.BaudRate = baudrate;
                _mPort.StopBit = stopbit;
                _mPort.DataBit = databit;
                _mPort.Parity = parity;
                try
                {
                    _mPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void _mPort_PortChange(bool flag)
        {
            if (flag)
            {
                btn_Port.Text = @"关 闭";
                cb_PortNames.Enabled = false;
                cb_BaudRate.Enabled = false;
                cb_StopBit.Enabled = false;
                cb_DataBit.Enabled = false;
                cb_Parity.Enabled = false;
            }
            else
            {
                btn_Port.Text = @"打 开";
                cb_PortNames.Enabled = true;
                cb_BaudRate.Enabled = true;
                cb_DataBit.Enabled = true;
                cb_StopBit.Enabled = true;
                cb_Parity.Enabled = true;
            }
        }

        private void _mPort_SerialPortCountChange(List<string> portnames)
        {
            _portNames = portnames;

            if (_mPort.IsOpen)
            {
                if (!portnames.Contains(_mPort.PortName))
                {
                    try
                    {
                        _mPort.Close();
                    }
                    catch
                    {
                    }
                }
            }

            this.Invoke(new EventHandler(delegate
            {
                cb_PortNames.Items.Clear();
                if (_portNames.Count > 0)
                {
                    cb_PortNames.Items.AddRange(_portNames.ToArray());
                    if (_mPort.IsOpen)
                    {

                        int index = cb_PortNames.Items.IndexOf(_mPort.PortName);
                        cb_PortNames.SelectedIndex = index;
                    }
                    else
                    {
                        cb_PortNames.SelectedIndex = 0;
                    }
                }
            }));
        }

        private void _mPort_DataReceived(int port)
        {
            Thread.Sleep(1);
            try
            {
                int len = _mPort.GetIqueue;
                if (len <= 0) return;
                byte[] by = _mPort.Read(len);
                _portDatas.AddRange(by);
                p_Left.BeginInvoke(new EventHandler(delegate
                {
                    int columncount = (int)(p_Left.Width / _interval);
                    if (_portDatas.Count > columncount)
                    {
                        hsb_Scroll.Maximum = _portDatas.Count - columncount;
                        hsb_Scroll.Value = hsb_Scroll.Maximum;
                        hsb_Scroll.Enabled = true;
                    }
                    if (!hsb_Scroll.Enabled)
                        LineInvalidate();
                }));
            }
            catch (Exception ex)
            {
                GetExceptionMessage(ex);
            }
        }

        private void GetExceptionMessage(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****************************异常文本****************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            sb.AppendLine("【异常类型】：" + ex.GetType().Name);
            sb.AppendLine("【异常信息】：" + ex.Message);
            sb.AppendLine("【堆栈调用】：" + ex.StackTrace);
            sb.AppendLine("【异常方法】：" + ex.TargetSite);
            sb.AppendLine("***************************************************************");
            MessageBox.Show(sb.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
