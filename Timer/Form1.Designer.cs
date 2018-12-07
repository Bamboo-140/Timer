namespace Timer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.exchange = new System.Windows.Forms.CheckBox();
            this.displayFun = new System.Windows.Forms.CheckBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.setPanel = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AMLabel = new System.Windows.Forms.Label();
            this.PMLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.stopwatchFunc = new System.Windows.Forms.RadioButton();
            this.AlarmFunc = new System.Windows.Forms.RadioButton();
            this.functions = new System.Windows.Forms.GroupBox();
            this.chk_Shutdown = new System.Windows.Forms.CheckBox();
            this.moreSet = new System.Windows.Forms.Button();
            this.noteText = new System.Windows.Forms.TextBox();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timer_Hour = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ManualInput = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelInput = new System.Windows.Forms.ToolStripMenuItem();
            this.MinValue = new System.Windows.Forms.ToolStripMenuItem();
            this.MaxValue = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_Min = new System.Windows.Forms.NumericUpDown();
            this.Timer_Sec = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hourO = new System.Windows.Forms.NumericUpDown();
            this.minO = new System.Windows.Forms.NumericUpDown();
            this.TimerFunc = new System.Windows.Forms.RadioButton();
            this.recoderButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopwatch = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_ShutDownOption = new System.Windows.Forms.ComboBox();
            this.setPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.functions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Hour)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Sec)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minO)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(249, 89);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(49, 23);
            this.start.TabIndex = 0;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // exchange
            // 
            this.exchange.AutoSize = true;
            this.exchange.Location = new System.Drawing.Point(26, 20);
            this.exchange.Name = "exchange";
            this.exchange.Size = new System.Drawing.Size(72, 16);
            this.exchange.TabIndex = 1;
            this.exchange.Text = "24小时制";
            this.exchange.UseVisualStyleBackColor = true;
            this.exchange.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // displayFun
            // 
            this.displayFun.AutoSize = true;
            this.displayFun.Location = new System.Drawing.Point(104, 20);
            this.displayFun.Name = "displayFun";
            this.displayFun.Size = new System.Drawing.Size(96, 16);
            this.displayFun.TabIndex = 2;
            this.displayFun.Text = "显示拓展功能";
            this.displayFun.UseVisualStyleBackColor = true;
            this.displayFun.CheckedChanged += new System.EventHandler(this.displayFun_CheckedChanged);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(305, 80);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "00:00:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setPanel
            // 
            this.setPanel.Controls.Add(this.checkBox1);
            this.setPanel.Controls.Add(this.exchange);
            this.setPanel.Controls.Add(this.displayFun);
            this.setPanel.Location = new System.Drawing.Point(12, 98);
            this.setPanel.Name = "setPanel";
            this.setPanel.Size = new System.Drawing.Size(305, 54);
            this.setPanel.TabIndex = 14;
            this.setPanel.TabStop = false;
            this.setPanel.Text = "设置";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(206, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "前端显示";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // AMLabel
            // 
            this.AMLabel.AutoSize = true;
            this.AMLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AMLabel.Location = new System.Drawing.Point(283, 32);
            this.AMLabel.Name = "AMLabel";
            this.AMLabel.Size = new System.Drawing.Size(28, 17);
            this.AMLabel.TabIndex = 15;
            this.AMLabel.Text = "AM";
            // 
            // PMLabel
            // 
            this.PMLabel.AutoSize = true;
            this.PMLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PMLabel.Location = new System.Drawing.Point(283, 53);
            this.PMLabel.Name = "PMLabel";
            this.PMLabel.Size = new System.Drawing.Size(27, 17);
            this.PMLabel.TabIndex = 16;
            this.PMLabel.Text = "PM";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "计时器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show,
            this.close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 48);
            this.contextMenuStrip1.Text = "File";
            // 
            // show
            // 
            this.show.Name = "show";
            this.show.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.show.Size = new System.Drawing.Size(140, 22);
            this.show.Text = "显示";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.close.Size = new System.Drawing.Size(140, 22);
            this.close.Text = "关闭";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // stopwatchFunc
            // 
            this.stopwatchFunc.AutoSize = true;
            this.stopwatchFunc.Location = new System.Drawing.Point(69, 15);
            this.stopwatchFunc.Name = "stopwatchFunc";
            this.stopwatchFunc.Size = new System.Drawing.Size(47, 16);
            this.stopwatchFunc.TabIndex = 3;
            this.stopwatchFunc.Text = "停表";
            this.stopwatchFunc.UseVisualStyleBackColor = true;
            this.stopwatchFunc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AlarmFunc
            // 
            this.AlarmFunc.AutoSize = true;
            this.AlarmFunc.Location = new System.Drawing.Point(16, 15);
            this.AlarmFunc.Name = "AlarmFunc";
            this.AlarmFunc.Size = new System.Drawing.Size(47, 16);
            this.AlarmFunc.TabIndex = 4;
            this.AlarmFunc.Text = "闹表";
            this.AlarmFunc.UseVisualStyleBackColor = true;
            this.AlarmFunc.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // functions
            // 
            this.functions.Controls.Add(this.cmb_ShutDownOption);
            this.functions.Controls.Add(this.chk_Shutdown);
            this.functions.Controls.Add(this.moreSet);
            this.functions.Controls.Add(this.noteText);
            this.functions.Controls.Add(this.tipsLabel);
            this.functions.Controls.Add(this.panel1);
            this.functions.Controls.Add(this.panel2);
            this.functions.Controls.Add(this.start);
            this.functions.Controls.Add(this.TimerFunc);
            this.functions.Controls.Add(this.AlarmFunc);
            this.functions.Controls.Add(this.stopwatchFunc);
            this.functions.Controls.Add(this.recoderButton);
            this.functions.Controls.Add(this.pauseButton);
            this.functions.Location = new System.Drawing.Point(12, 164);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(305, 117);
            this.functions.TabIndex = 3;
            this.functions.TabStop = false;
            this.functions.Text = "功能";
            // 
            // chk_Shutdown
            // 
            this.chk_Shutdown.AutoSize = true;
            this.chk_Shutdown.Location = new System.Drawing.Point(173, 81);
            this.chk_Shutdown.Name = "chk_Shutdown";
            this.chk_Shutdown.Size = new System.Drawing.Size(15, 14);
            this.chk_Shutdown.TabIndex = 23;
            this.chk_Shutdown.UseVisualStyleBackColor = true;
            this.chk_Shutdown.CheckedChanged += new System.EventHandler(this.chk_Shutdown_CheckedChanged);
            // 
            // moreSet
            // 
            this.moreSet.Location = new System.Drawing.Point(187, 11);
            this.moreSet.Name = "moreSet";
            this.moreSet.Size = new System.Drawing.Size(46, 20);
            this.moreSet.TabIndex = 22;
            this.moreSet.Text = "展开";
            this.moreSet.UseVisualStyleBackColor = true;
            this.moreSet.Visible = false;
            this.moreSet.Click += new System.EventHandler(this.moreSet_Click);
            // 
            // noteText
            // 
            this.noteText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noteText.Location = new System.Drawing.Point(69, 78);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(98, 21);
            this.noteText.TabIndex = 21;
            this.noteText.Visible = false;
            // 
            // tipsLabel
            // 
            this.tipsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Location = new System.Drawing.Point(10, 83);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(53, 12);
            this.tipsLabel.TabIndex = 20;
            this.tipsLabel.Text = "设定提醒";
            this.tipsLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Timer_Hour);
            this.panel1.Controls.Add(this.Timer_Min);
            this.panel1.Controls.Add(this.Timer_Sec);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 35);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "时";
            // 
            // Timer_Hour
            // 
            this.Timer_Hour.ContextMenuStrip = this.contextMenuStrip2;
            this.Timer_Hour.Location = new System.Drawing.Point(14, 8);
            this.Timer_Hour.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Timer_Hour.Name = "Timer_Hour";
            this.Timer_Hour.ReadOnly = true;
            this.Timer_Hour.Size = new System.Drawing.Size(43, 21);
            this.Timer_Hour.TabIndex = 2;
            this.Timer_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timer_Hour.Leave += new System.EventHandler(this.Timer_Hour_Leave);
            this.Timer_Hour.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Timer_Hour_MouseDoubleClick);
            this.Timer_Hour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer_Hour_MouseDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualInput,
            this.CancelInput,
            this.MinValue,
            this.MaxValue});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(125, 92);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // ManualInput
            // 
            this.ManualInput.Name = "ManualInput";
            this.ManualInput.Size = new System.Drawing.Size(124, 22);
            this.ManualInput.Text = "手动输入";
            this.ManualInput.Click += new System.EventHandler(this.ManualInput_Click);
            // 
            // CancelInput
            // 
            this.CancelInput.Enabled = false;
            this.CancelInput.Name = "CancelInput";
            this.CancelInput.Size = new System.Drawing.Size(124, 22);
            this.CancelInput.Text = "取消输入";
            this.CancelInput.Click += new System.EventHandler(this.CancelInput_Click);
            // 
            // MinValue
            // 
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(124, 22);
            this.MinValue.Text = "最小值";
            // 
            // MaxValue
            // 
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(124, 22);
            this.MaxValue.Text = "最大值";
            // 
            // Timer_Min
            // 
            this.Timer_Min.ContextMenuStrip = this.contextMenuStrip2;
            this.Timer_Min.Location = new System.Drawing.Point(81, 8);
            this.Timer_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Timer_Min.Name = "Timer_Min";
            this.Timer_Min.ReadOnly = true;
            this.Timer_Min.Size = new System.Drawing.Size(43, 21);
            this.Timer_Min.TabIndex = 1;
            this.Timer_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timer_Min.Leave += new System.EventHandler(this.Timer_Min_Leave);
            this.Timer_Min.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Timer_Min_MouseDoubleClick);
            this.Timer_Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer_Min_MouseDown);
            // 
            // Timer_Sec
            // 
            this.Timer_Sec.ContextMenuStrip = this.contextMenuStrip2;
            this.Timer_Sec.Location = new System.Drawing.Point(148, 8);
            this.Timer_Sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Timer_Sec.Name = "Timer_Sec";
            this.Timer_Sec.ReadOnly = true;
            this.Timer_Sec.Size = new System.Drawing.Size(43, 21);
            this.Timer_Sec.TabIndex = 0;
            this.Timer_Sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timer_Sec.Leave += new System.EventHandler(this.Timer_Sec_Leave);
            this.Timer_Sec.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Timer_Sec_MouseDoubleClick);
            this.Timer_Sec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer_Sec_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.hourO);
            this.panel2.Controls.Add(this.minO);
            this.panel2.Location = new System.Drawing.Point(6, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 35);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "时";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "请设定时间:";
            // 
            // hourO
            // 
            this.hourO.ContextMenuStrip = this.contextMenuStrip2;
            this.hourO.Location = new System.Drawing.Point(85, 8);
            this.hourO.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.hourO.Name = "hourO";
            this.hourO.ReadOnly = true;
            this.hourO.Size = new System.Drawing.Size(39, 21);
            this.hourO.TabIndex = 14;
            this.hourO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hourO.Leave += new System.EventHandler(this.hourO_Leave);
            this.hourO.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.hourO_MouseDoubleClick);
            this.hourO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hourO_MouseDown);
            // 
            // minO
            // 
            this.minO.ContextMenuStrip = this.contextMenuStrip2;
            this.minO.Location = new System.Drawing.Point(155, 8);
            this.minO.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.minO.Name = "minO";
            this.minO.ReadOnly = true;
            this.minO.Size = new System.Drawing.Size(39, 21);
            this.minO.TabIndex = 15;
            this.minO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minO.Leave += new System.EventHandler(this.minO_Leave);
            this.minO.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.minO_MouseDoubleClick);
            this.minO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minO_MouseDown);
            // 
            // TimerFunc
            // 
            this.TimerFunc.AutoSize = true;
            this.TimerFunc.Location = new System.Drawing.Point(122, 15);
            this.TimerFunc.Name = "TimerFunc";
            this.TimerFunc.Size = new System.Drawing.Size(59, 16);
            this.TimerFunc.TabIndex = 14;
            this.TimerFunc.Text = "倒计时";
            this.TimerFunc.UseVisualStyleBackColor = true;
            this.TimerFunc.CheckedChanged += new System.EventHandler(this.TimerFunc_CheckedChanged);
            // 
            // recoderButton
            // 
            this.recoderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recoderButton.Location = new System.Drawing.Point(250, 89);
            this.recoderButton.Name = "recoderButton";
            this.recoderButton.Size = new System.Drawing.Size(49, 23);
            this.recoderButton.TabIndex = 16;
            this.recoderButton.Text = "记录";
            this.recoderButton.UseVisualStyleBackColor = true;
            this.recoderButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseButton.Location = new System.Drawing.Point(249, 89);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(49, 23);
            this.pauseButton.TabIndex = 17;
            this.pauseButton.Text = "暂停";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopList
            // 
            this.stopList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopList.FormattingEnabled = true;
            this.stopList.ItemHeight = 12;
            this.stopList.Location = new System.Drawing.Point(3, 17);
            this.stopList.Name = "stopList";
            this.stopList.Size = new System.Drawing.Size(161, 208);
            this.stopList.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopList);
            this.groupBox1.Location = new System.Drawing.Point(331, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 228);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "停表记录";
            // 
            // stopwatch
            // 
            this.stopwatch.Interval = 1;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label7
            // 
            this.label7.Image = global::Timer.MyResource.Clock_icon__2_;
            this.label7.Location = new System.Drawing.Point(17, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = " ";
            this.label7.Visible = false;
            // 
            // cmb_ShutDownOption
            // 
            this.cmb_ShutDownOption.FormattingEnabled = true;
            this.cmb_ShutDownOption.Items.AddRange(new object[] {
            "关机",
            "休眠",
            "重启"});
            this.cmb_ShutDownOption.Location = new System.Drawing.Point(187, 79);
            this.cmb_ShutDownOption.Name = "cmb_ShutDownOption";
            this.cmb_ShutDownOption.Size = new System.Drawing.Size(46, 20);
            this.cmb_ShutDownOption.TabIndex = 24;
            this.cmb_ShutDownOption.Text = "关机";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 293);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.PMLabel);
            this.Controls.Add(this.AMLabel);
            this.Controls.Add(this.setPanel);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "计时器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.setPanel.ResumeLayout(false);
            this.setPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.functions.ResumeLayout(false);
            this.functions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Hour)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Sec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minO)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox exchange;
        private System.Windows.Forms.CheckBox displayFun;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.GroupBox setPanel;
        private System.Windows.Forms.Label AMLabel;
        private System.Windows.Forms.Label PMLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton stopwatchFunc;
        private System.Windows.Forms.GroupBox functions;
        private System.Windows.Forms.RadioButton AlarmFunc;
        private System.Windows.Forms.RadioButton TimerFunc;
        private System.Windows.Forms.ListBox stopList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer stopwatch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown hourO;
        private System.Windows.Forms.NumericUpDown minO;
        private System.Windows.Forms.Button recoderButton;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown Timer_Hour;
        private System.Windows.Forms.NumericUpDown Timer_Min;
        private System.Windows.Forms.NumericUpDown Timer_Sec;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem show;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Button moreSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ManualInput;
        private System.Windows.Forms.ToolStripMenuItem CancelInput;
        private System.Windows.Forms.ToolStripMenuItem MinValue;
        private System.Windows.Forms.ToolStripMenuItem MaxValue;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chk_Shutdown;
        private System.Windows.Forms.ComboBox cmb_ShutDownOption;
    }
}

