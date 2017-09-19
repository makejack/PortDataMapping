using System.IO;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using NPlot;
using System.Reflection;

namespace PortDataMapping
{
    public partial class Home_Form : Form
    {
        private string PARAMFILENAME = "Param.xml";
        private SystemParam _systemParam;
        private SerialPortEx _mPort;
        private SearchSerialPort _mSearchPort;
        private int _splitLenght = 50;
        private int _currentLenght;
        private Pen _backgroundPen;

        private LinePlot _currentLine;
        private PointPlot _currentPoint;

        List<LinePlot> _lines;
        List<PointPlot> _points;

        DateTime _recordTime = DateTime.MinValue;

        public Home_Form()
        {
            InitializeComponent();

            this.Load += Home_Form_Load;
            this.Shown += Home_Form_Shown;
            this.FormClosing += Home_Form_FormClosing;

            cb_IsDeviation.CheckedChanged += Cb_IsDeviation_CheckedChanged;
            cb_IsSplit.CheckedChanged += Cb_IsSplite_CheckedChanged;
            cb_IsAutoClear.CheckedChanged += Cb_IsAutoClear_CheckedChanged;
            p_Right.Paint += P_right_Paint;
            btn_Port.Click += Btn_Port_Click;
            ud_SpliteData.ValueChanged += Ud_Data_ValueChanged;
            btn_Clear.Click += Btn_Clear_Click;
        }
 
        private void Cb_IsDeviation_CheckedChanged(object sender, EventArgs e)
        {
            ud_Deviation.Enabled = !cb_IsDeviation.Checked;
            ud_StartRow.Enabled = !cb_IsDeviation.Checked;
        }

        private void Cb_IsSplite_CheckedChanged(object sender, EventArgs e)
        {
            ud_SpliteData.Enabled = !cb_IsSplit.Checked;
        }

        private void Home_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _systemParam = new SystemParam()
            {
                PortName = cb_PortNames.SelectedItem.ToString(),
                BaudRateIndex = cb_BaudRate.SelectedIndex,
                DataBitIndex = cb_DataBit.SelectedIndex,
                DelayTime = (int)ud_DelayMilliseconds.Value,
                XInterval = (int)ud_Xinterval.Value,
                YInterval = (int)ud_Yinterval.Value,
                ParityIndex = cb_Parity.SelectedIndex,
                SplitLenght = (int)ud_SpliteData.Value,
                StopBitIndex = cb_StopBit.SelectedIndex,
                DeviationStartRow = (int)ud_StartRow.Value,
                DeviationValue = (int)ud_Deviation.Value,
                StartUpDelay = cb_IsAutoClear.Checked,
                StartUpDeviation = cb_IsDeviation.Checked,
                StartUpSplit = cb_IsSplit.Checked
            };

            string path = Application.StartupPath + "\\" + PARAMFILENAME;
            if (!File.Exists(path))
            {
                CreateXml(path);
            }
            else
            {
                UpdateElement(path);
            }
        }

        private void Cb_IsAutoClear_CheckedChanged(object sender, EventArgs e)
        {
            ud_DelayMilliseconds.Enabled = !cb_IsAutoClear.Checked;
        }

        private void P_right_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                g.DrawLine(_backgroundPen, 0, 0, 0, p_Right.Height);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            _lines.Clear();
            _points.Clear();
            Home_Form_Shown(null, null);
            rtbTxt.Clear();
            _currentLenght = 0;
        }

        private void Ud_Data_ValueChanged(object sender, EventArgs e)
        {
            if (ud_SpliteData.Value != _splitLenght)
            {
                _splitLenght = (int)ud_SpliteData.Value;
            }
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}

        private void Home_Form_Shown(object sender, EventArgs e)
        {
            InitializationNplot();
        }

        private void InitializationNplot()
        {
            plot.Clear();//清空
            Grid mygrid = new Grid(); //加入网格 
            mygrid.MajorGridPen = new Pen(Brushes.Silver);
            plot.Add(mygrid);

            CreateLine();

            plot.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.HorizontalDrag());
            plot.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.VerticalDrag());
            plot.AddInteraction(new NPlot.Windows.PlotSurface2D.Interactions.AxisDrag(true));

            plot.XAxis1.IncreaseRange((int)ud_Xinterval.Value);
            plot.XAxis1.WorldMin = -1;
            plot.YAxis1.IncreaseRange((int)ud_Yinterval.Value); //缩小到合适大小

            plot.Refresh();

        }

        private void CreateLine()
        {
            string[] strColors = Enum.GetNames(typeof(CustomColors));
            Color c = Color.FromName(strColors[_lines.Count]);

            _currentLine = new LinePlot();
            _currentLine.Pen.Width = 1;
            _currentLine.Pen.Color = c;
            _currentLine.Label = "Line" + _lines.Count;
            plot.Add(_currentLine);

            _currentPoint = new PointPlot(new Marker(Marker.MarkerType.FilledCircle, 4, new Pen(c, 2.0f)));
            _currentPoint.Label = "Point" + _points.Count;
            plot.Add(_currentPoint);

            _lines.Add(_currentLine);
            _points.Add(_currentPoint);
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            //this.MaximizeBox = false;

            _lines = new List<LinePlot>();
            _points = new List<PointPlot>();

            _backgroundPen = new Pen(Color.FromArgb(221, 221, 221), 1);

            LoadParam();
            if (_systemParam == null)
            {
                cb_BaudRate.SelectedIndex = 1;
                cb_StopBit.SelectedIndex = 0;
                cb_DataBit.SelectedIndex = 3;
                cb_Parity.SelectedIndex = 0;
            }
            else
            {
                cb_BaudRate.SelectedIndex = _systemParam.BaudRateIndex;
                cb_StopBit.SelectedIndex = _systemParam.StopBitIndex;
                cb_DataBit.SelectedIndex = _systemParam.DataBitIndex;
                cb_Parity.SelectedIndex = _systemParam.ParityIndex;

                ud_SpliteData.Value = _systemParam.SplitLenght;
                cb_IsSplit.Checked = _systemParam.StartUpSplit;
                if (_systemParam.XInterval > 0)
                    ud_Xinterval.Value = _systemParam.XInterval;
                if (_systemParam.YInterval > 0)
                    ud_Yinterval.Value = _systemParam.YInterval;
                ud_DelayMilliseconds.Value = _systemParam.DelayTime;
                cb_IsAutoClear.Checked = _systemParam.StartUpDelay;
                ud_StartRow.Value = _systemParam.DeviationStartRow;
                ud_Deviation.Value = _systemParam.DeviationValue;
                cb_IsDeviation.Checked = _systemParam.StartUpDeviation;
            }

            _mPort = new SerialPortEx();
            _mPort.PortChange += _mPort_PortChange;
            _mPort.DataReceived += _mPort_DataReceived;
            _mSearchPort = new SearchSerialPort(100);
            _mSearchPort.SerialPortCountChanged += SerialPortCountChange;
            _mSearchPort.Start();
        }

        private void SerialPortCountChange(string[] PortNames)
        {
            if (_mPort.IsOpen)
            {
                if (!_mSearchPort.SerialPortNames.Contains(_mPort.PortName))
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
                if (PortNames.Length > 0)
                {
                    cb_PortNames.Items.AddRange(PortNames);
                    if (_mPort.IsOpen)
                    {
                        int index = cb_PortNames.Items.IndexOf(_mPort.PortName);
                        cb_PortNames.SelectedIndex = index;
                    }
                    else
                    {
                        if (cb_PortNames.Items.Count > 0)
                        {
                            if (!string.IsNullOrEmpty(_systemParam.PortName))
                            {
                                int index = cb_PortNames.Items.IndexOf(_systemParam.PortName);
                                cb_PortNames.SelectedIndex = index > 0 ? index : 0;
                            }
                            else
                            {
                                cb_PortNames.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }));
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

        private void _mPort_DataReceived(int port)
        {
            Thread.Sleep(1);
            try
            {
                int len = _mPort.GetIqueue;
                if (len <= 0) return;
                byte[] by = _mPort.Read(len);

                DateTime now = DateTime.Now;

                if (cb_IsAutoClear.Checked && _recordTime != DateTime.MinValue)
                {
                    TimeSpan ts = now - _recordTime;
                    if (ts.TotalMilliseconds > (int)ud_DelayMilliseconds.Value)
                    {
                        Btn_Clear_Click(null, null);
                    }
                }

                _recordTime = now;
                StringBuilder sb = new StringBuilder();
                foreach (byte item in by)
                {
                    if (cb_IsSplit.Checked)
                    {
                        _currentLenght++;
                        if (_currentLenght > _splitLenght)
                        {
                            sb.Append("\n");
                            CreateLine();
                            _currentLenght = 1;
                        }
                    }

                    List<int> yPoint = _currentLine.OrdinateData as List<int>;
                    List<int> xPoint = _currentLine.AbscissaData as List<int>;
                    if (xPoint == null)
                    {
                        xPoint = new List<int>();
                    }
                    if (yPoint == null)
                    {
                        yPoint = new List<int>();
                    }
                    int y = item;
                    int x = xPoint.Count;

                    if (item >= 128)
                    {
                        y = -(256 - item);
                    }

                    if (cb_IsDeviation.Checked)
                    {
                        if (_lines.Count > ud_StartRow.Value)
                        {
                            y -= (int)ud_Deviation.Value;
                        }
                        else
                        {
                            y += (int)ud_Deviation.Value;
                        }
                    }

                    TextItem txt = new TextItem(new PointD(x, y), string.Format("{0:X2}", item));
                    plot.Add(txt);
                    yPoint.Add(y);
                    xPoint.Add(x);
                    sb.AppendFormat("{0:X2} ", item);
                    _currentLine.OrdinateData = yPoint;
                    _currentLine.AbscissaData = xPoint;
                    if (xPoint.Count > plot.XAxis1.WorldMax)
                    {
                        plot.XAxis1.WorldMax = xPoint.Count;
                    }
                    _currentPoint.OrdinateData = yPoint;
                    _currentPoint.AbscissaData = xPoint;
                }
                this.BeginInvoke(new EventHandler(delegate
                {
                    rtbTxt.AppendText(sb.ToString());
                    plot.Refresh();
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

        private void LoadParam()
        {
            string path = Application.StartupPath + "\\" + PARAMFILENAME;
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
            {
                doc.Load(path);
                XmlElement element = doc.DocumentElement;
                PropertyInfo[] pinfos = typeof(SystemParam).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                _systemParam = new SystemParam();
                foreach (PropertyInfo item in pinfos)
                {
                    XmlNode node = element.SelectSingleNode(item.Name);
                    if (node != null)
                    {
                        item.SetValue(_systemParam, GetDataType(item, node.InnerText), null);
                    }
                }
            }
        }

        private object GetDataType(PropertyInfo info, string value)
        {
            if (info.PropertyType == typeof(int))
            {
                return Convert.ToInt32(value);
            }
            else if (info.PropertyType == typeof(bool))
            {
                return Convert.ToBoolean(value);
            }
            return value;
        }

        private void CreateXml(string path)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "Utf-8", null);
            doc.AppendChild(dec);
            XmlElement element = doc.CreateElement("Params");
            PropertyInfo[] pinfos = typeof(SystemParam).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (PropertyInfo item in pinfos)
            {
                XmlElement nodeele = doc.CreateElement(item.Name);
                nodeele.InnerText = item.GetValue(_systemParam, null).ToString();
                element.AppendChild(nodeele);
            }
            doc.AppendChild(element);
            doc.Save(path);
        }

        private void UpdateElement(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement element = doc.DocumentElement;
            PropertyInfo[] pinfos = typeof(SystemParam).GetProperties(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            foreach (PropertyInfo item in pinfos)
            {
                XmlNode node = element.SelectSingleNode(item.Name);
                if (node != null)
                {
                    node.InnerText = item.GetValue(_systemParam, null).ToString();
                }
                else
                {
                    XmlElement nodeelement = doc.CreateElement(item.Name);
                    nodeelement.InnerText = item.GetValue(_systemParam, null).ToString();
                    element.AppendChild(nodeelement);
                }
            }
            doc.Save(path);
        }
    }

    public class SystemParam
    {
        public string PortName { get; set; }

        public int BaudRateIndex { get; set; }

        public int DataBitIndex { get; set; }

        public int StopBitIndex { get; set; }

        public int ParityIndex { get; set; }

        public bool StartUpSplit { get; set; }

        public int SplitLenght { get; set; }

        public int YInterval { get; set; }

        public int XInterval { get; set; }

        public bool StartUpDelay { get; set; }

        public int DelayTime { get; set; }

        public bool StartUpDeviation { get; set; }

        public int DeviationStartRow { get; set; }

        public int DeviationValue { get; set; }
    }

    public enum CustomColors
    {
        Black,
        Blue,
        Red,
        Yellow,
        Green,
        Magenta,
        LightGreen,
        LightPink,
        Teal,
        Sienna,
        CadetBlue,
        Olive,
        Purple,
        GreenYellow,
        DarkGoldenrod,
    }

}
