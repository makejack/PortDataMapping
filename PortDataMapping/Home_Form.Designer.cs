namespace PortDataMapping
{
    partial class Home_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            this.p_Left = new System.Windows.Forms.Panel();
            this.l_PortNameTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_PortNames = new System.Windows.Forms.ComboBox();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.p_Right = new System.Windows.Forms.Panel();
            this.cb_Parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_StopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_DataBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ud_Data = new System.Windows.Forms.NumericUpDown();
            this.ud_Interval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Port = new System.Windows.Forms.Button();
            this.hsb_Scroll = new System.Windows.Forms.HScrollBar();
            this.vsb_Scroll = new System.Windows.Forms.VScrollBar();
            this.p_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Left
            // 
            this.p_Left.AutoScroll = true;
            this.p_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Left.Location = new System.Drawing.Point(0, 0);
            this.p_Left.Name = "p_Left";
            this.p_Left.Size = new System.Drawing.Size(784, 324);
            this.p_Left.TabIndex = 0;
            // 
            // l_PortNameTitle
            // 
            this.l_PortNameTitle.AutoSize = true;
            this.l_PortNameTitle.Location = new System.Drawing.Point(13, 19);
            this.l_PortNameTitle.Name = "l_PortNameTitle";
            this.l_PortNameTitle.Size = new System.Drawing.Size(47, 12);
            this.l_PortNameTitle.TabIndex = 0;
            this.l_PortNameTitle.Text = "端口号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "波特率:";
            // 
            // cb_PortNames
            // 
            this.cb_PortNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PortNames.FormattingEnabled = true;
            this.cb_PortNames.Location = new System.Drawing.Point(66, 15);
            this.cb_PortNames.Name = "cb_PortNames";
            this.cb_PortNames.Size = new System.Drawing.Size(121, 20);
            this.cb_PortNames.TabIndex = 2;
            // 
            // cb_BaudRate
            // 
            this.cb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BaudRate.FormattingEnabled = true;
            this.cb_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400"});
            this.cb_BaudRate.Location = new System.Drawing.Point(66, 44);
            this.cb_BaudRate.Name = "cb_BaudRate";
            this.cb_BaudRate.Size = new System.Drawing.Size(121, 20);
            this.cb_BaudRate.TabIndex = 3;
            // 
            // p_Right
            // 
            this.p_Right.Controls.Add(this.cb_Parity);
            this.p_Right.Controls.Add(this.label6);
            this.p_Right.Controls.Add(this.cb_StopBit);
            this.p_Right.Controls.Add(this.label5);
            this.p_Right.Controls.Add(this.cb_DataBit);
            this.p_Right.Controls.Add(this.label4);
            this.p_Right.Controls.Add(this.ud_Data);
            this.p_Right.Controls.Add(this.ud_Interval);
            this.p_Right.Controls.Add(this.label3);
            this.p_Right.Controls.Add(this.label2);
            this.p_Right.Controls.Add(this.btn_Clear);
            this.p_Right.Controls.Add(this.btn_Port);
            this.p_Right.Controls.Add(this.cb_BaudRate);
            this.p_Right.Controls.Add(this.cb_PortNames);
            this.p_Right.Controls.Add(this.label1);
            this.p_Right.Controls.Add(this.l_PortNameTitle);
            this.p_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_Right.Location = new System.Drawing.Point(801, 0);
            this.p_Right.Name = "p_Right";
            this.p_Right.Size = new System.Drawing.Size(200, 341);
            this.p_Right.TabIndex = 1;
            // 
            // cb_Parity
            // 
            this.cb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Parity.FormattingEnabled = true;
            this.cb_Parity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "SPC",
            "MRK",
            "EVEN"});
            this.cb_Parity.Location = new System.Drawing.Point(66, 131);
            this.cb_Parity.Name = "cb_Parity";
            this.cb_Parity.Size = new System.Drawing.Size(121, 20);
            this.cb_Parity.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "校验位:";
            // 
            // cb_StopBit
            // 
            this.cb_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_StopBit.FormattingEnabled = true;
            this.cb_StopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_StopBit.Location = new System.Drawing.Point(66, 102);
            this.cb_StopBit.Name = "cb_StopBit";
            this.cb_StopBit.Size = new System.Drawing.Size(121, 20);
            this.cb_StopBit.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "停止位:";
            // 
            // cb_DataBit
            // 
            this.cb_DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DataBit.FormattingEnabled = true;
            this.cb_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cb_DataBit.Location = new System.Drawing.Point(66, 73);
            this.cb_DataBit.Name = "cb_DataBit";
            this.cb_DataBit.Size = new System.Drawing.Size(121, 20);
            this.cb_DataBit.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据位:";
            // 
            // ud_Data
            // 
            this.ud_Data.Location = new System.Drawing.Point(84, 220);
            this.ud_Data.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ud_Data.Name = "ud_Data";
            this.ud_Data.Size = new System.Drawing.Size(103, 21);
            this.ud_Data.TabIndex = 11;
            this.ud_Data.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ud_Interval
            // 
            this.ud_Interval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ud_Interval.Location = new System.Drawing.Point(84, 258);
            this.ud_Interval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_Interval.Name = "ud_Interval";
            this.ud_Interval.Size = new System.Drawing.Size(103, 21);
            this.ud_Interval.TabIndex = 10;
            this.ud_Interval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "表格间隔:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "高位数据:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(14, 291);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(172, 30);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "清 除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Port
            // 
            this.btn_Port.Location = new System.Drawing.Point(15, 157);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Size = new System.Drawing.Size(172, 30);
            this.btn_Port.TabIndex = 4;
            this.btn_Port.Text = "打 开";
            this.btn_Port.UseVisualStyleBackColor = true;
            // 
            // hsb_Scroll
            // 
            this.hsb_Scroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsb_Scroll.Enabled = false;
            this.hsb_Scroll.LargeChange = 1;
            this.hsb_Scroll.Location = new System.Drawing.Point(0, 324);
            this.hsb_Scroll.Maximum = 0;
            this.hsb_Scroll.Name = "hsb_Scroll";
            this.hsb_Scroll.Size = new System.Drawing.Size(784, 17);
            this.hsb_Scroll.TabIndex = 0;
            // 
            // vsb_Scroll
            // 
            this.vsb_Scroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsb_Scroll.LargeChange = 1;
            this.vsb_Scroll.Location = new System.Drawing.Point(784, 0);
            this.vsb_Scroll.Maximum = 0;
            this.vsb_Scroll.Name = "vsb_Scroll";
            this.vsb_Scroll.Size = new System.Drawing.Size(17, 341);
            this.vsb_Scroll.TabIndex = 0;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 341);
            this.Controls.Add(this.p_Left);
            this.Controls.Add(this.hsb_Scroll);
            this.Controls.Add(this.vsb_Scroll);
            this.Controls.Add(this.p_Right);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home_Form";
            this.Text = "端口数据绘表软件";
            this.p_Right.ResumeLayout(false);
            this.p_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Interval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Left;
        private System.Windows.Forms.Label l_PortNameTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PortNames;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.Panel p_Right;
        private System.Windows.Forms.Button btn_Port;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ud_Interval;
        private System.Windows.Forms.NumericUpDown ud_Data;
        private System.Windows.Forms.ComboBox cb_Parity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_StopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_DataBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hsb_Scroll;
        private System.Windows.Forms.VScrollBar vsb_Scroll;
    }
}

