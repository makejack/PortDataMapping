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
            this.l_PortNameTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_PortNames = new System.Windows.Forms.ComboBox();
            this.cb_BaudRate = new System.Windows.Forms.ComboBox();
            this.p_Right = new System.Windows.Forms.Panel();
            this.ud_Yinterval = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ud_StartRow = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ud_Deviation = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_IsDeviation = new System.Windows.Forms.CheckBox();
            this.cb_IsSplit = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_IsAutoClear = new System.Windows.Forms.CheckBox();
            this.ud_DelayMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ud_Xinterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_StopBit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_DataBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ud_SpliteData = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Port = new System.Windows.Forms.Button();
            this.plot = new NPlot.Windows.PlotSurface2D();
            this.rtbTxt = new System.Windows.Forms.RichTextBox();
            this.p_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Yinterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_StartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Deviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_DelayMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Xinterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_SpliteData)).BeginInit();
            this.SuspendLayout();
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
            this.cb_PortNames.TabIndex = 0;
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
            this.cb_BaudRate.TabIndex = 1;
            // 
            // p_Right
            // 
            this.p_Right.Controls.Add(this.ud_Yinterval);
            this.p_Right.Controls.Add(this.label11);
            this.p_Right.Controls.Add(this.ud_StartRow);
            this.p_Right.Controls.Add(this.label10);
            this.p_Right.Controls.Add(this.ud_Deviation);
            this.p_Right.Controls.Add(this.label9);
            this.p_Right.Controls.Add(this.cb_IsDeviation);
            this.p_Right.Controls.Add(this.cb_IsSplit);
            this.p_Right.Controls.Add(this.label8);
            this.p_Right.Controls.Add(this.cb_IsAutoClear);
            this.p_Right.Controls.Add(this.ud_DelayMilliseconds);
            this.p_Right.Controls.Add(this.label7);
            this.p_Right.Controls.Add(this.ud_Xinterval);
            this.p_Right.Controls.Add(this.label3);
            this.p_Right.Controls.Add(this.cb_Parity);
            this.p_Right.Controls.Add(this.label6);
            this.p_Right.Controls.Add(this.cb_StopBit);
            this.p_Right.Controls.Add(this.label5);
            this.p_Right.Controls.Add(this.cb_DataBit);
            this.p_Right.Controls.Add(this.label4);
            this.p_Right.Controls.Add(this.ud_SpliteData);
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
            this.p_Right.Size = new System.Drawing.Size(200, 511);
            this.p_Right.TabIndex = 1;
            // 
            // ud_Yinterval
            // 
            this.ud_Yinterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_Yinterval.Location = new System.Drawing.Point(86, 206);
            this.ud_Yinterval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ud_Yinterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_Yinterval.Name = "ud_Yinterval";
            this.ud_Yinterval.Size = new System.Drawing.Size(103, 21);
            this.ud_Yinterval.TabIndex = 28;
            this.ud_Yinterval.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "Y轴最大值:";
            // 
            // ud_StartRow
            // 
            this.ud_StartRow.Location = new System.Drawing.Point(85, 349);
            this.ud_StartRow.Name = "ud_StartRow";
            this.ud_StartRow.Size = new System.Drawing.Size(103, 21);
            this.ud_StartRow.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "开始偏移行:";
            // 
            // ud_Deviation
            // 
            this.ud_Deviation.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_Deviation.Location = new System.Drawing.Point(85, 376);
            this.ud_Deviation.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ud_Deviation.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.ud_Deviation.Name = "ud_Deviation";
            this.ud_Deviation.Size = new System.Drawing.Size(103, 21);
            this.ud_Deviation.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "偏移值:";
            // 
            // cb_IsDeviation
            // 
            this.cb_IsDeviation.AutoSize = true;
            this.cb_IsDeviation.Location = new System.Drawing.Point(25, 325);
            this.cb_IsDeviation.Name = "cb_IsDeviation";
            this.cb_IsDeviation.Size = new System.Drawing.Size(96, 16);
            this.cb_IsDeviation.TabIndex = 11;
            this.cb_IsDeviation.Text = "启用数据偏移";
            this.cb_IsDeviation.UseVisualStyleBackColor = true;
            // 
            // cb_IsSplit
            // 
            this.cb_IsSplit.AutoSize = true;
            this.cb_IsSplit.Location = new System.Drawing.Point(25, 267);
            this.cb_IsSplit.Name = "cb_IsSplit";
            this.cb_IsSplit.Size = new System.Drawing.Size(96, 16);
            this.cb_IsSplit.TabIndex = 7;
            this.cb_IsSplit.Text = "启用长度分割";
            this.cb_IsSplit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "毫秒";
            // 
            // cb_IsAutoClear
            // 
            this.cb_IsAutoClear.AutoSize = true;
            this.cb_IsAutoClear.Location = new System.Drawing.Point(25, 410);
            this.cb_IsAutoClear.Name = "cb_IsAutoClear";
            this.cb_IsAutoClear.Size = new System.Drawing.Size(96, 16);
            this.cb_IsAutoClear.TabIndex = 9;
            this.cb_IsAutoClear.Text = "启用自动清除";
            this.cb_IsAutoClear.UseVisualStyleBackColor = true;
            // 
            // ud_DelayMilliseconds
            // 
            this.ud_DelayMilliseconds.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ud_DelayMilliseconds.Location = new System.Drawing.Point(86, 436);
            this.ud_DelayMilliseconds.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ud_DelayMilliseconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_DelayMilliseconds.Name = "ud_DelayMilliseconds";
            this.ud_DelayMilliseconds.Size = new System.Drawing.Size(67, 21);
            this.ud_DelayMilliseconds.TabIndex = 10;
            this.ud_DelayMilliseconds.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "清除延迟:";
            // 
            // ud_Xinterval
            // 
            this.ud_Xinterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ud_Xinterval.Location = new System.Drawing.Point(86, 233);
            this.ud_Xinterval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ud_Xinterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_Xinterval.Name = "ud_Xinterval";
            this.ud_Xinterval.Size = new System.Drawing.Size(103, 21);
            this.ud_Xinterval.TabIndex = 6;
            this.ud_Xinterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "X轴最大值:";
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
            this.cb_Parity.TabIndex = 4;
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
            this.cb_StopBit.TabIndex = 3;
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
            this.cb_DataBit.TabIndex = 2;
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
            // ud_SpliteData
            // 
            this.ud_SpliteData.Location = new System.Drawing.Point(86, 294);
            this.ud_SpliteData.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ud_SpliteData.Name = "ud_SpliteData";
            this.ud_SpliteData.Size = new System.Drawing.Size(103, 21);
            this.ud_SpliteData.TabIndex = 8;
            this.ud_SpliteData.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "长度分割:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(14, 463);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(172, 30);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "清 除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Port
            // 
            this.btn_Port.Location = new System.Drawing.Point(15, 157);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Size = new System.Drawing.Size(172, 30);
            this.btn_Port.TabIndex = 5;
            this.btn_Port.Text = "打 开";
            this.btn_Port.UseVisualStyleBackColor = true;
            // 
            // plot
            // 
            this.plot.AutoScaleAutoGeneratedAxes = false;
            this.plot.AutoScaleTitle = false;
            this.plot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plot.DateTimeToolTip = false;
            this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot.Legend = null;
            this.plot.LegendZOrder = -1;
            this.plot.Location = new System.Drawing.Point(0, 0);
            this.plot.Name = "plot";
            this.plot.RightMenu = null;
            this.plot.ShowCoordinates = false;
            this.plot.Size = new System.Drawing.Size(801, 415);
            this.plot.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plot.TabIndex = 2;
            this.plot.Title = "";
            this.plot.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plot.XAxis1 = null;
            this.plot.XAxis2 = null;
            this.plot.YAxis1 = null;
            this.plot.YAxis2 = null;
            // 
            // rtbTxt
            // 
            this.rtbTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbTxt.Location = new System.Drawing.Point(0, 415);
            this.rtbTxt.Name = "rtbTxt";
            this.rtbTxt.Size = new System.Drawing.Size(801, 96);
            this.rtbTxt.TabIndex = 3;
            this.rtbTxt.Text = "";
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 511);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.rtbTxt);
            this.Controls.Add(this.p_Right);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home_Form";
            this.Text = "端口数据绘表软件";
            this.p_Right.ResumeLayout(false);
            this.p_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Yinterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_StartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Deviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_DelayMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Xinterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_SpliteData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label l_PortNameTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PortNames;
        private System.Windows.Forms.ComboBox cb_BaudRate;
        private System.Windows.Forms.Panel p_Right;
        private System.Windows.Forms.Button btn_Port;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cb_Parity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_StopBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_DataBit;
        private System.Windows.Forms.Label label4;
        private NPlot.Windows.PlotSurface2D plot;
        private System.Windows.Forms.RichTextBox rtbTxt;
        private System.Windows.Forms.NumericUpDown ud_SpliteData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ud_Xinterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ud_DelayMilliseconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_IsAutoClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_IsSplit;
        private System.Windows.Forms.CheckBox cb_IsDeviation;
        private System.Windows.Forms.NumericUpDown ud_Deviation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ud_StartRow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown ud_Yinterval;
        private System.Windows.Forms.Label label11;
    }
}

