using System.Windows.Forms.DataVisualization.Charting;

namespace WinPulsDaten
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControll = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.welLbBkrlogo = new System.Windows.Forms.Label();
            this.welLbWelcome = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.regPnlCenter = new System.Windows.Forms.Panel();
            this.regTbPassword = new System.Windows.Forms.TextBox();
            this.regBtnLogin = new System.Windows.Forms.Button();
            this.regLbBirth = new System.Windows.Forms.Label();
            this.regLbFirstname = new System.Windows.Forms.Label();
            this.regLbTraincondition = new System.Windows.Forms.Label();
            this.regLbLastname = new System.Windows.Forms.Label();
            this.regCbTrainingCondition = new System.Windows.Forms.ComboBox();
            this.regTbLastname = new System.Windows.Forms.TextBox();
            this.regDpBirth = new System.Windows.Forms.DateTimePicker();
            this.regPanHf = new System.Windows.Forms.Panel();
            this.regBtnInfo = new System.Windows.Forms.Button();
            this.regNudHfMax = new System.Windows.Forms.NumericUpDown();
            this.regRadHfAuto = new System.Windows.Forms.RadioButton();
            this.regRadHFManual = new System.Windows.Forms.RadioButton();
            this.regTbFirstname = new System.Windows.Forms.TextBox();
            this.regLbMaxHf = new System.Windows.Forms.Label();
            this.regLbPassword = new System.Windows.Forms.Label();
            this.regLbSize = new System.Windows.Forms.Label();
            this.regTbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.regLbWight = new System.Windows.Forms.Label();
            this.regLbConfrimPassword = new System.Windows.Forms.Label();
            this.regLbM = new System.Windows.Forms.Label();
            this.regCbGender = new System.Windows.Forms.ComboBox();
            this.regLbKG = new System.Windows.Forms.Label();
            this.regLbGender = new System.Windows.Forms.Label();
            this.regNudSize = new System.Windows.Forms.NumericUpDown();
            this.regNudWight = new System.Windows.Forms.NumericUpDown();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.logPnlDisplay = new System.Windows.Forms.Panel();
            this.logTbPassword = new System.Windows.Forms.TextBox();
            this.logBtnLogin = new System.Windows.Forms.Button();
            this.logLbPassword = new System.Windows.Forms.Label();
            this.logTbFirstname = new System.Windows.Forms.TextBox();
            this.logTbLastname = new System.Windows.Forms.TextBox();
            this.logLbFirstname = new System.Windows.Forms.Label();
            this.logLbLastname = new System.Windows.Forms.Label();
            this.tabStatsAll = new System.Windows.Forms.TabPage();
            this.staLbMode = new System.Windows.Forms.Label();
            this.staCbMode = new System.Windows.Forms.ComboBox();
            this.staChartDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.setChbDeleteSuperUser = new System.Windows.Forms.CheckBox();
            this.setBtnDelte = new System.Windows.Forms.Button();
            this.tabAnalysisMe = new System.Windows.Forms.TabPage();
            this.anmeLbCriticalValues = new System.Windows.Forms.Label();
            this.anmeGDVCriticalViews = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.anmeCbActivity = new System.Windows.Forms.ComboBox();
            this.anmeChartDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.perLbCalculateTrainingRate = new System.Windows.Forms.Label();
            this.perLbInfos = new System.Windows.Forms.Label();
            this.perPnlActivity = new System.Windows.Forms.Panel();
            this.perNudTrainingHeartRade = new System.Windows.Forms.NumericUpDown();
            this.perCbActivity = new System.Windows.Forms.ComboBox();
            this.perLbTrainingHeartRade = new System.Windows.Forms.Label();
            this.perNudRestingPulse = new System.Windows.Forms.NumericUpDown();
            this.perLbActivity = new System.Windows.Forms.Label();
            this.perLbRestingPulse = new System.Windows.Forms.Label();
            this.perPnlDisplay = new System.Windows.Forms.Panel();
            this.pdLbWeight = new System.Windows.Forms.Label();
            this.pdLbWeightTitle = new System.Windows.Forms.Label();
            this.pdLbFirstname = new System.Windows.Forms.Label();
            this.pdLbSizeTitle = new System.Windows.Forms.Label();
            this.pdLbLastname = new System.Windows.Forms.Label();
            this.pdLbLastnameTitle = new System.Windows.Forms.Label();
            this.pdLbSize = new System.Windows.Forms.Label();
            this.pdLbFirstnameTitle = new System.Windows.Forms.Label();
            this.tabControll.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.regPnlCenter.SuspendLayout();
            this.regPanHf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regNudHfMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNudWight)).BeginInit();
            this.tabLogin.SuspendLayout();
            this.logPnlDisplay.SuspendLayout();
            this.tabStatsAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staChartDisplay)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabAnalysisMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmeGDVCriticalViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmeChartDisplay)).BeginInit();
            this.tabPersonalData.SuspendLayout();
            this.perPnlActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perNudTrainingHeartRade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perNudRestingPulse)).BeginInit();
            this.perPnlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControll
            // 
            this.tabControll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControll.Controls.Add(this.tabWelcome);
            this.tabControll.Controls.Add(this.tabRegister);
            this.tabControll.Controls.Add(this.tabLogin);
            this.tabControll.Controls.Add(this.tabStatsAll);
            this.tabControll.Controls.Add(this.tabSettings);
            this.tabControll.Controls.Add(this.tabAnalysisMe);
            this.tabControll.Controls.Add(this.tabPersonalData);
            this.tabControll.Location = new System.Drawing.Point(12, 12);
            this.tabControll.Name = "tabControll";
            this.tabControll.SelectedIndex = 0;
            this.tabControll.Size = new System.Drawing.Size(786, 475);
            this.tabControll.TabIndex = 0;
            this.tabControll.SelectedIndexChanged += new System.EventHandler(this.OnTabControllChangeView);
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.welLbBkrlogo);
            this.tabWelcome.Controls.Add(this.welLbWelcome);
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Size = new System.Drawing.Size(778, 449);
            this.tabWelcome.TabIndex = 6;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // welLbBkrlogo
            // 
            this.welLbBkrlogo.Image = ((System.Drawing.Image)(resources.GetObject("welLbBkrlogo.Image")));
            this.welLbBkrlogo.Location = new System.Drawing.Point(3, 306);
            this.welLbBkrlogo.Name = "welLbBkrlogo";
            this.welLbBkrlogo.Size = new System.Drawing.Size(279, 143);
            this.welLbBkrlogo.TabIndex = 1;
            // 
            // welLbWelcome
            // 
            this.welLbWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welLbWelcome.AutoSize = true;
            this.welLbWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welLbWelcome.Location = new System.Drawing.Point(121, 34);
            this.welLbWelcome.Name = "welLbWelcome";
            this.welLbWelcome.Size = new System.Drawing.Size(542, 27);
            this.welLbWelcome.TabIndex = 0;
            this.welLbWelcome.Text = "Hello and welcome to the puls-analyser (Professional)";
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.regPnlCenter);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(778, 449);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // regPnlCenter
            // 
            this.regPnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regPnlCenter.Controls.Add(this.regTbPassword);
            this.regPnlCenter.Controls.Add(this.regBtnLogin);
            this.regPnlCenter.Controls.Add(this.regLbBirth);
            this.regPnlCenter.Controls.Add(this.regLbFirstname);
            this.regPnlCenter.Controls.Add(this.regLbTraincondition);
            this.regPnlCenter.Controls.Add(this.regLbLastname);
            this.regPnlCenter.Controls.Add(this.regCbTrainingCondition);
            this.regPnlCenter.Controls.Add(this.regTbLastname);
            this.regPnlCenter.Controls.Add(this.regDpBirth);
            this.regPnlCenter.Controls.Add(this.regPanHf);
            this.regPnlCenter.Controls.Add(this.regTbFirstname);
            this.regPnlCenter.Controls.Add(this.regLbMaxHf);
            this.regPnlCenter.Controls.Add(this.regLbPassword);
            this.regPnlCenter.Controls.Add(this.regLbSize);
            this.regPnlCenter.Controls.Add(this.regTbPasswordConfirm);
            this.regPnlCenter.Controls.Add(this.regLbWight);
            this.regPnlCenter.Controls.Add(this.regLbConfrimPassword);
            this.regPnlCenter.Controls.Add(this.regLbM);
            this.regPnlCenter.Controls.Add(this.regCbGender);
            this.regPnlCenter.Controls.Add(this.regLbKG);
            this.regPnlCenter.Controls.Add(this.regLbGender);
            this.regPnlCenter.Controls.Add(this.regNudSize);
            this.regPnlCenter.Controls.Add(this.regNudWight);
            this.regPnlCenter.Location = new System.Drawing.Point(225, 23);
            this.regPnlCenter.Name = "regPnlCenter";
            this.regPnlCenter.Size = new System.Drawing.Size(360, 399);
            this.regPnlCenter.TabIndex = 28;
            // 
            // regTbPassword
            // 
            this.regTbPassword.Location = new System.Drawing.Point(7, 73);
            this.regTbPassword.Name = "regTbPassword";
            this.regTbPassword.Size = new System.Drawing.Size(347, 20);
            this.regTbPassword.TabIndex = 3;
            // 
            // regBtnLogin
            // 
            this.regBtnLogin.Location = new System.Drawing.Point(119, 365);
            this.regBtnLogin.Name = "regBtnLogin";
            this.regBtnLogin.Size = new System.Drawing.Size(135, 23);
            this.regBtnLogin.TabIndex = 13;
            this.regBtnLogin.Text = "Register";
            this.regBtnLogin.UseVisualStyleBackColor = true;
            this.regBtnLogin.Click += new System.EventHandler(this.OnRegRegisterClicked);
            // 
            // regLbBirth
            // 
            this.regLbBirth.AutoSize = true;
            this.regLbBirth.Location = new System.Drawing.Point(4, 298);
            this.regLbBirth.Name = "regLbBirth";
            this.regLbBirth.Size = new System.Drawing.Size(45, 13);
            this.regLbBirth.TabIndex = 27;
            this.regLbBirth.Text = "Birthday";
            // 
            // regLbFirstname
            // 
            this.regLbFirstname.AutoSize = true;
            this.regLbFirstname.Location = new System.Drawing.Point(4, 4);
            this.regLbFirstname.Name = "regLbFirstname";
            this.regLbFirstname.Size = new System.Drawing.Size(52, 13);
            this.regLbFirstname.TabIndex = 6;
            this.regLbFirstname.Text = "Firstname";
            // 
            // regLbTraincondition
            // 
            this.regLbTraincondition.AutoSize = true;
            this.regLbTraincondition.Location = new System.Drawing.Point(4, 247);
            this.regLbTraincondition.Name = "regLbTraincondition";
            this.regLbTraincondition.Size = new System.Drawing.Size(92, 13);
            this.regLbTraincondition.TabIndex = 26;
            this.regLbTraincondition.Text = "Training Condition";
            // 
            // regLbLastname
            // 
            this.regLbLastname.AutoSize = true;
            this.regLbLastname.Location = new System.Drawing.Point(180, 4);
            this.regLbLastname.Name = "regLbLastname";
            this.regLbLastname.Size = new System.Drawing.Size(53, 13);
            this.regLbLastname.TabIndex = 7;
            this.regLbLastname.Text = "Lastname";
            // 
            // regCbTrainingCondition
            // 
            this.regCbTrainingCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regCbTrainingCondition.FormattingEnabled = true;
            this.regCbTrainingCondition.Location = new System.Drawing.Point(7, 263);
            this.regCbTrainingCondition.Name = "regCbTrainingCondition";
            this.regCbTrainingCondition.Size = new System.Drawing.Size(168, 21);
            this.regCbTrainingCondition.TabIndex = 8;
            this.regCbTrainingCondition.SelectedIndexChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // regTbLastname
            // 
            this.regTbLastname.Location = new System.Drawing.Point(183, 23);
            this.regTbLastname.Name = "regTbLastname";
            this.regTbLastname.Size = new System.Drawing.Size(171, 20);
            this.regTbLastname.TabIndex = 2;
            // 
            // regDpBirth
            // 
            this.regDpBirth.Location = new System.Drawing.Point(7, 314);
            this.regDpBirth.Name = "regDpBirth";
            this.regDpBirth.Size = new System.Drawing.Size(347, 20);
            this.regDpBirth.TabIndex = 12;
            // 
            // regPanHf
            // 
            this.regPanHf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.regPanHf.Controls.Add(this.regBtnInfo);
            this.regPanHf.Controls.Add(this.regNudHfMax);
            this.regPanHf.Controls.Add(this.regRadHfAuto);
            this.regPanHf.Controls.Add(this.regRadHFManual);
            this.regPanHf.Location = new System.Drawing.Point(183, 212);
            this.regPanHf.Name = "regPanHf";
            this.regPanHf.Size = new System.Drawing.Size(171, 79);
            this.regPanHf.TabIndex = 24;
            // 
            // regBtnInfo
            // 
            this.regBtnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regBtnInfo.BackgroundImage")));
            this.regBtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regBtnInfo.Location = new System.Drawing.Point(144, 4);
            this.regBtnInfo.Name = "regBtnInfo";
            this.regBtnInfo.Size = new System.Drawing.Size(20, 20);
            this.regBtnInfo.TabIndex = 28;
            this.regBtnInfo.UseVisualStyleBackColor = true;
            this.regBtnInfo.Click += new System.EventHandler(this.OnRegInfoButtonClicked);
            // 
            // regNudHfMax
            // 
            this.regNudHfMax.DecimalPlaces = 2;
            this.regNudHfMax.Location = new System.Drawing.Point(4, 50);
            this.regNudHfMax.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.regNudHfMax.Name = "regNudHfMax";
            this.regNudHfMax.Size = new System.Drawing.Size(160, 20);
            this.regNudHfMax.TabIndex = 11;
            // 
            // regRadHfAuto
            // 
            this.regRadHfAuto.AutoSize = true;
            this.regRadHfAuto.Location = new System.Drawing.Point(3, 27);
            this.regRadHfAuto.Name = "regRadHfAuto";
            this.regRadHfAuto.Size = new System.Drawing.Size(69, 17);
            this.regRadHfAuto.TabIndex = 10;
            this.regRadHfAuto.TabStop = true;
            this.regRadHfAuto.Text = "Calculate";
            this.regRadHfAuto.UseVisualStyleBackColor = true;
            this.regRadHfAuto.CheckedChanged += new System.EventHandler(this.OnRegSelectAutoHF);
            // 
            // regRadHFManual
            // 
            this.regRadHFManual.AutoSize = true;
            this.regRadHFManual.Location = new System.Drawing.Point(3, 4);
            this.regRadHFManual.Name = "regRadHFManual";
            this.regRadHFManual.Size = new System.Drawing.Size(95, 17);
            this.regRadHFManual.TabIndex = 9;
            this.regRadHFManual.TabStop = true;
            this.regRadHFManual.Text = "Assign yourself";
            this.regRadHFManual.UseVisualStyleBackColor = true;
            this.regRadHFManual.CheckedChanged += new System.EventHandler(this.OnRegSelectMangualHF);
            // 
            // regTbFirstname
            // 
            this.regTbFirstname.Location = new System.Drawing.Point(7, 23);
            this.regTbFirstname.Name = "regTbFirstname";
            this.regTbFirstname.Size = new System.Drawing.Size(168, 20);
            this.regTbFirstname.TabIndex = 1;
            // 
            // regLbMaxHf
            // 
            this.regLbMaxHf.AutoSize = true;
            this.regLbMaxHf.Location = new System.Drawing.Point(180, 196);
            this.regLbMaxHf.Name = "regLbMaxHf";
            this.regLbMaxHf.Size = new System.Drawing.Size(74, 13);
            this.regLbMaxHf.TabIndex = 22;
            this.regLbMaxHf.Text = "Max HF-Value";
            // 
            // regLbPassword
            // 
            this.regLbPassword.AutoSize = true;
            this.regLbPassword.Location = new System.Drawing.Point(4, 57);
            this.regLbPassword.Name = "regLbPassword";
            this.regLbPassword.Size = new System.Drawing.Size(53, 13);
            this.regLbPassword.TabIndex = 9;
            this.regLbPassword.Text = "Password";
            // 
            // regLbSize
            // 
            this.regLbSize.AutoSize = true;
            this.regLbSize.Location = new System.Drawing.Point(180, 143);
            this.regLbSize.Name = "regLbSize";
            this.regLbSize.Size = new System.Drawing.Size(27, 13);
            this.regLbSize.TabIndex = 20;
            this.regLbSize.Text = "Size";
            // 
            // regTbPasswordConfirm
            // 
            this.regTbPasswordConfirm.Location = new System.Drawing.Point(7, 115);
            this.regTbPasswordConfirm.Name = "regTbPasswordConfirm";
            this.regTbPasswordConfirm.Size = new System.Drawing.Size(347, 20);
            this.regTbPasswordConfirm.TabIndex = 4;
            // 
            // regLbWight
            // 
            this.regLbWight.AutoSize = true;
            this.regLbWight.Location = new System.Drawing.Point(4, 143);
            this.regLbWight.Name = "regLbWight";
            this.regLbWight.Size = new System.Drawing.Size(41, 13);
            this.regLbWight.TabIndex = 19;
            this.regLbWight.Text = "Weight";
            // 
            // regLbConfrimPassword
            // 
            this.regLbConfrimPassword.AutoSize = true;
            this.regLbConfrimPassword.Location = new System.Drawing.Point(4, 99);
            this.regLbConfrimPassword.Name = "regLbConfrimPassword";
            this.regLbConfrimPassword.Size = new System.Drawing.Size(91, 13);
            this.regLbConfrimPassword.TabIndex = 10;
            this.regLbConfrimPassword.Text = "Confrim Password";
            // 
            // regLbM
            // 
            this.regLbM.AutoSize = true;
            this.regLbM.Location = new System.Drawing.Point(334, 163);
            this.regLbM.Name = "regLbM";
            this.regLbM.Size = new System.Drawing.Size(15, 13);
            this.regLbM.TabIndex = 18;
            this.regLbM.Text = "m";
            // 
            // regCbGender
            // 
            this.regCbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regCbGender.FormattingEnabled = true;
            this.regCbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.regCbGender.Location = new System.Drawing.Point(7, 212);
            this.regCbGender.Name = "regCbGender";
            this.regCbGender.Size = new System.Drawing.Size(168, 21);
            this.regCbGender.TabIndex = 7;
            this.regCbGender.SelectedIndexChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // regLbKG
            // 
            this.regLbKG.AutoSize = true;
            this.regLbKG.Location = new System.Drawing.Point(158, 162);
            this.regLbKG.Name = "regLbKG";
            this.regLbKG.Size = new System.Drawing.Size(19, 13);
            this.regLbKG.TabIndex = 17;
            this.regLbKG.Text = "kg";
            // 
            // regLbGender
            // 
            this.regLbGender.AutoSize = true;
            this.regLbGender.Location = new System.Drawing.Point(4, 196);
            this.regLbGender.Name = "regLbGender";
            this.regLbGender.Size = new System.Drawing.Size(42, 13);
            this.regLbGender.TabIndex = 12;
            this.regLbGender.Text = "Gender";
            // 
            // regNudSize
            // 
            this.regNudSize.DecimalPlaces = 2;
            this.regNudSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.regNudSize.Location = new System.Drawing.Point(183, 159);
            this.regNudSize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.regNudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regNudSize.Name = "regNudSize";
            this.regNudSize.Size = new System.Drawing.Size(148, 20);
            this.regNudSize.TabIndex = 6;
            this.regNudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regNudSize.ValueChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // regNudWight
            // 
            this.regNudWight.Location = new System.Drawing.Point(7, 159);
            this.regNudWight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.regNudWight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regNudWight.Name = "regNudWight";
            this.regNudWight.Size = new System.Drawing.Size(151, 20);
            this.regNudWight.TabIndex = 5;
            this.regNudWight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regNudWight.ValueChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.logPnlDisplay);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(778, 449);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // logPnlDisplay
            // 
            this.logPnlDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logPnlDisplay.Controls.Add(this.logTbPassword);
            this.logPnlDisplay.Controls.Add(this.logBtnLogin);
            this.logPnlDisplay.Controls.Add(this.logLbPassword);
            this.logPnlDisplay.Controls.Add(this.logTbFirstname);
            this.logPnlDisplay.Controls.Add(this.logTbLastname);
            this.logPnlDisplay.Controls.Add(this.logLbFirstname);
            this.logPnlDisplay.Controls.Add(this.logLbLastname);
            this.logPnlDisplay.Location = new System.Drawing.Point(229, 158);
            this.logPnlDisplay.Name = "logPnlDisplay";
            this.logPnlDisplay.Size = new System.Drawing.Size(356, 142);
            this.logPnlDisplay.TabIndex = 17;
            // 
            // logTbPassword
            // 
            this.logTbPassword.Location = new System.Drawing.Point(3, 73);
            this.logTbPassword.Name = "logTbPassword";
            this.logTbPassword.Size = new System.Drawing.Size(346, 20);
            this.logTbPassword.TabIndex = 15;
            // 
            // logBtnLogin
            // 
            this.logBtnLogin.Location = new System.Drawing.Point(122, 110);
            this.logBtnLogin.Name = "logBtnLogin";
            this.logBtnLogin.Size = new System.Drawing.Size(105, 23);
            this.logBtnLogin.TabIndex = 16;
            this.logBtnLogin.Text = "Login";
            this.logBtnLogin.UseVisualStyleBackColor = true;
            this.logBtnLogin.Click += new System.EventHandler(this.OnLogLoginClicked);
            // 
            // logLbPassword
            // 
            this.logLbPassword.AutoSize = true;
            this.logLbPassword.Location = new System.Drawing.Point(0, 57);
            this.logLbPassword.Name = "logLbPassword";
            this.logLbPassword.Size = new System.Drawing.Size(53, 13);
            this.logLbPassword.TabIndex = 14;
            this.logLbPassword.Text = "Password";
            // 
            // logTbFirstname
            // 
            this.logTbFirstname.Location = new System.Drawing.Point(3, 23);
            this.logTbFirstname.Name = "logTbFirstname";
            this.logTbFirstname.Size = new System.Drawing.Size(168, 20);
            this.logTbFirstname.TabIndex = 13;
            // 
            // logTbLastname
            // 
            this.logTbLastname.Location = new System.Drawing.Point(182, 23);
            this.logTbLastname.Name = "logTbLastname";
            this.logTbLastname.Size = new System.Drawing.Size(168, 20);
            this.logTbLastname.TabIndex = 14;
            // 
            // logLbFirstname
            // 
            this.logLbFirstname.AutoSize = true;
            this.logLbFirstname.Location = new System.Drawing.Point(0, 7);
            this.logLbFirstname.Name = "logLbFirstname";
            this.logLbFirstname.Size = new System.Drawing.Size(52, 13);
            this.logLbFirstname.TabIndex = 11;
            this.logLbFirstname.Text = "Firstname";
            // 
            // logLbLastname
            // 
            this.logLbLastname.AutoSize = true;
            this.logLbLastname.Location = new System.Drawing.Point(179, 7);
            this.logLbLastname.Name = "logLbLastname";
            this.logLbLastname.Size = new System.Drawing.Size(53, 13);
            this.logLbLastname.TabIndex = 12;
            this.logLbLastname.Text = "Lastname";
            // 
            // tabStatsAll
            // 
            this.tabStatsAll.Controls.Add(this.staLbMode);
            this.tabStatsAll.Controls.Add(this.staCbMode);
            this.tabStatsAll.Controls.Add(this.staChartDisplay);
            this.tabStatsAll.Location = new System.Drawing.Point(4, 22);
            this.tabStatsAll.Name = "tabStatsAll";
            this.tabStatsAll.Size = new System.Drawing.Size(778, 449);
            this.tabStatsAll.TabIndex = 2;
            this.tabStatsAll.Text = "Analysis (All)";
            this.tabStatsAll.UseVisualStyleBackColor = true;
            // 
            // staLbMode
            // 
            this.staLbMode.AutoSize = true;
            this.staLbMode.Location = new System.Drawing.Point(13, 7);
            this.staLbMode.Name = "staLbMode";
            this.staLbMode.Size = new System.Drawing.Size(75, 13);
            this.staLbMode.TabIndex = 2;
            this.staLbMode.Text = "Analysis-Mode";
            // 
            // staCbMode
            // 
            this.staCbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staCbMode.FormattingEnabled = true;
            this.staCbMode.Items.AddRange(new object[] {
            "MaxHF over Age",
            "Restpulse over Weight"});
            this.staCbMode.Location = new System.Drawing.Point(13, 23);
            this.staCbMode.Name = "staCbMode";
            this.staCbMode.Size = new System.Drawing.Size(121, 21);
            this.staCbMode.TabIndex = 17;
            this.staCbMode.SelectedIndexChanged += new System.EventHandler(this.OnStaModeChanged);
            // 
            // staChartDisplay
            // 
            this.staChartDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.staChartDisplay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.staChartDisplay.Legends.Add(legend1);
            this.staChartDisplay.Location = new System.Drawing.Point(1, 50);
            this.staChartDisplay.Name = "staChartDisplay";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.staChartDisplay.Series.Add(series1);
            this.staChartDisplay.Size = new System.Drawing.Size(809, 396);
            this.staChartDisplay.TabIndex = 0;
            this.staChartDisplay.Text = "chart";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.setChbDeleteSuperUser);
            this.tabSettings.Controls.Add(this.setBtnDelte);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(778, 449);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // setChbDeleteSuperUser
            // 
            this.setChbDeleteSuperUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setChbDeleteSuperUser.AutoSize = true;
            this.setChbDeleteSuperUser.Location = new System.Drawing.Point(331, 196);
            this.setChbDeleteSuperUser.Name = "setChbDeleteSuperUser";
            this.setChbDeleteSuperUser.Size = new System.Drawing.Size(115, 17);
            this.setChbDeleteSuperUser.TabIndex = 1;
            this.setChbDeleteSuperUser.Text = "Delete super user?";
            this.setChbDeleteSuperUser.UseVisualStyleBackColor = true;
            // 
            // setBtnDelte
            // 
            this.setBtnDelte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setBtnDelte.Location = new System.Drawing.Point(331, 219);
            this.setBtnDelte.Name = "setBtnDelte";
            this.setBtnDelte.Size = new System.Drawing.Size(147, 23);
            this.setBtnDelte.TabIndex = 0;
            this.setBtnDelte.Text = "Delete all data";
            this.setBtnDelte.UseVisualStyleBackColor = true;
            this.setBtnDelte.Click += new System.EventHandler(this.OnSetButtonDelteClicked);
            // 
            // tabAnalysisMe
            // 
            this.tabAnalysisMe.Controls.Add(this.anmeLbCriticalValues);
            this.tabAnalysisMe.Controls.Add(this.anmeGDVCriticalViews);
            this.tabAnalysisMe.Controls.Add(this.label1);
            this.tabAnalysisMe.Controls.Add(this.anmeCbActivity);
            this.tabAnalysisMe.Controls.Add(this.anmeChartDisplay);
            this.tabAnalysisMe.Location = new System.Drawing.Point(4, 22);
            this.tabAnalysisMe.Name = "tabAnalysisMe";
            this.tabAnalysisMe.Size = new System.Drawing.Size(778, 449);
            this.tabAnalysisMe.TabIndex = 4;
            this.tabAnalysisMe.Text = "Analysis (Me)";
            this.tabAnalysisMe.UseVisualStyleBackColor = true;
            // 
            // anmeLbCriticalValues
            // 
            this.anmeLbCriticalValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anmeLbCriticalValues.AutoSize = true;
            this.anmeLbCriticalValues.Location = new System.Drawing.Point(616, 63);
            this.anmeLbCriticalValues.Name = "anmeLbCriticalValues";
            this.anmeLbCriticalValues.Size = new System.Drawing.Size(72, 13);
            this.anmeLbCriticalValues.TabIndex = 20;
            this.anmeLbCriticalValues.Text = "Critical values";
            // 
            // anmeGDVCriticalViews
            // 
            this.anmeGDVCriticalViews.AllowUserToAddRows = false;
            this.anmeGDVCriticalViews.AllowUserToDeleteRows = false;
            this.anmeGDVCriticalViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anmeGDVCriticalViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.anmeGDVCriticalViews.DefaultCellStyle = dataGridViewCellStyle1;
            this.anmeGDVCriticalViews.Location = new System.Drawing.Point(490, 79);
            this.anmeGDVCriticalViews.Name = "anmeGDVCriticalViews";
            this.anmeGDVCriticalViews.ReadOnly = true;
            this.anmeGDVCriticalViews.Size = new System.Drawing.Size(320, 367);
            this.anmeGDVCriticalViews.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Analysis-Mode";
            // 
            // anmeCbActivity
            // 
            this.anmeCbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anmeCbActivity.FormattingEnabled = true;
            this.anmeCbActivity.Items.AddRange(new object[] {
            "MaxHF over Age",
            "Restpulse over Weight"});
            this.anmeCbActivity.Location = new System.Drawing.Point(9, 24);
            this.anmeCbActivity.Name = "anmeCbActivity";
            this.anmeCbActivity.Size = new System.Drawing.Size(121, 21);
            this.anmeCbActivity.TabIndex = 18;
            this.anmeCbActivity.SelectedIndexChanged += new System.EventHandler(this.OnAnmeActivityChanged);
            // 
            // anmeChartDisplay
            // 
            this.anmeChartDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.anmeChartDisplay.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.anmeChartDisplay.Legends.Add(legend2);
            this.anmeChartDisplay.Location = new System.Drawing.Point(3, 51);
            this.anmeChartDisplay.Name = "anmeChartDisplay";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.anmeChartDisplay.Series.Add(series2);
            this.anmeChartDisplay.Size = new System.Drawing.Size(481, 395);
            this.anmeChartDisplay.TabIndex = 1;
            this.anmeChartDisplay.Text = "chart2";
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Controls.Add(this.perLbCalculateTrainingRate);
            this.tabPersonalData.Controls.Add(this.perLbInfos);
            this.tabPersonalData.Controls.Add(this.perPnlActivity);
            this.tabPersonalData.Controls.Add(this.perPnlDisplay);
            this.tabPersonalData.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Size = new System.Drawing.Size(778, 449);
            this.tabPersonalData.TabIndex = 5;
            this.tabPersonalData.Text = "Personsal data";
            this.tabPersonalData.UseVisualStyleBackColor = true;
            // 
            // perLbCalculateTrainingRate
            // 
            this.perLbCalculateTrainingRate.AutoSize = true;
            this.perLbCalculateTrainingRate.Location = new System.Drawing.Point(13, 162);
            this.perLbCalculateTrainingRate.Name = "perLbCalculateTrainingRate";
            this.perLbCalculateTrainingRate.Size = new System.Drawing.Size(133, 13);
            this.perLbCalculateTrainingRate.TabIndex = 18;
            this.perLbCalculateTrainingRate.Text = "Calculate Training-Hartrate";
            // 
            // perLbInfos
            // 
            this.perLbInfos.AutoSize = true;
            this.perLbInfos.Location = new System.Drawing.Point(13, 16);
            this.perLbInfos.Name = "perLbInfos";
            this.perLbInfos.Size = new System.Drawing.Size(103, 13);
            this.perLbInfos.TabIndex = 17;
            this.perLbInfos.Text = "Personal Information";
            // 
            // perPnlActivity
            // 
            this.perPnlActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.perPnlActivity.Controls.Add(this.perNudTrainingHeartRade);
            this.perPnlActivity.Controls.Add(this.perCbActivity);
            this.perPnlActivity.Controls.Add(this.perLbTrainingHeartRade);
            this.perPnlActivity.Controls.Add(this.perNudRestingPulse);
            this.perPnlActivity.Controls.Add(this.perLbActivity);
            this.perPnlActivity.Controls.Add(this.perLbRestingPulse);
            this.perPnlActivity.Location = new System.Drawing.Point(16, 178);
            this.perPnlActivity.Name = "perPnlActivity";
            this.perPnlActivity.Size = new System.Drawing.Size(203, 148);
            this.perPnlActivity.TabIndex = 16;
            // 
            // perNudTrainingHeartRade
            // 
            this.perNudTrainingHeartRade.Enabled = false;
            this.perNudTrainingHeartRade.Location = new System.Drawing.Point(3, 122);
            this.perNudTrainingHeartRade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.perNudTrainingHeartRade.Name = "perNudTrainingHeartRade";
            this.perNudTrainingHeartRade.Size = new System.Drawing.Size(192, 20);
            this.perNudTrainingHeartRade.TabIndex = 5;
            // 
            // perCbActivity
            // 
            this.perCbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perCbActivity.FormattingEnabled = true;
            this.perCbActivity.Location = new System.Drawing.Point(3, 19);
            this.perCbActivity.Name = "perCbActivity";
            this.perCbActivity.Size = new System.Drawing.Size(192, 21);
            this.perCbActivity.TabIndex = 1;
            this.perCbActivity.TextChanged += new System.EventHandler(this.OnPerActivityChanged);
            // 
            // perLbTrainingHeartRade
            // 
            this.perLbTrainingHeartRade.AutoSize = true;
            this.perLbTrainingHeartRade.Location = new System.Drawing.Point(3, 106);
            this.perLbTrainingHeartRade.Name = "perLbTrainingHeartRade";
            this.perLbTrainingHeartRade.Size = new System.Drawing.Size(100, 13);
            this.perLbTrainingHeartRade.TabIndex = 6;
            this.perLbTrainingHeartRade.Text = "Training Heart Rate";
            // 
            // perNudRestingPulse
            // 
            this.perNudRestingPulse.Location = new System.Drawing.Point(3, 68);
            this.perNudRestingPulse.Name = "perNudRestingPulse";
            this.perNudRestingPulse.Size = new System.Drawing.Size(192, 20);
            this.perNudRestingPulse.TabIndex = 2;
            this.perNudRestingPulse.ValueChanged += new System.EventHandler(this.OnePerRestingPulsChange);
            // 
            // perLbActivity
            // 
            this.perLbActivity.AutoSize = true;
            this.perLbActivity.Location = new System.Drawing.Point(3, 3);
            this.perLbActivity.Name = "perLbActivity";
            this.perLbActivity.Size = new System.Drawing.Size(41, 13);
            this.perLbActivity.TabIndex = 3;
            this.perLbActivity.Text = "Activity";
            // 
            // perLbRestingPulse
            // 
            this.perLbRestingPulse.AutoSize = true;
            this.perLbRestingPulse.Location = new System.Drawing.Point(3, 52);
            this.perLbRestingPulse.Name = "perLbRestingPulse";
            this.perLbRestingPulse.Size = new System.Drawing.Size(72, 13);
            this.perLbRestingPulse.TabIndex = 4;
            this.perLbRestingPulse.Text = "Resting Pulse";
            // 
            // perPnlDisplay
            // 
            this.perPnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.perPnlDisplay.Controls.Add(this.pdLbWeight);
            this.perPnlDisplay.Controls.Add(this.pdLbWeightTitle);
            this.perPnlDisplay.Controls.Add(this.pdLbFirstname);
            this.perPnlDisplay.Controls.Add(this.pdLbSizeTitle);
            this.perPnlDisplay.Controls.Add(this.pdLbLastname);
            this.perPnlDisplay.Controls.Add(this.pdLbLastnameTitle);
            this.perPnlDisplay.Controls.Add(this.pdLbSize);
            this.perPnlDisplay.Controls.Add(this.pdLbFirstnameTitle);
            this.perPnlDisplay.Location = new System.Drawing.Point(16, 32);
            this.perPnlDisplay.Name = "perPnlDisplay";
            this.perPnlDisplay.Size = new System.Drawing.Size(176, 99);
            this.perPnlDisplay.TabIndex = 15;
            // 
            // pdLbWeight
            // 
            this.pdLbWeight.AutoSize = true;
            this.pdLbWeight.Location = new System.Drawing.Point(73, 78);
            this.pdLbWeight.Name = "pdLbWeight";
            this.pdLbWeight.Size = new System.Drawing.Size(41, 13);
            this.pdLbWeight.TabIndex = 10;
            this.pdLbWeight.Text = "Weight";
            // 
            // pdLbWeightTitle
            // 
            this.pdLbWeightTitle.AutoSize = true;
            this.pdLbWeightTitle.Location = new System.Drawing.Point(5, 78);
            this.pdLbWeightTitle.Name = "pdLbWeightTitle";
            this.pdLbWeightTitle.Size = new System.Drawing.Size(41, 13);
            this.pdLbWeightTitle.TabIndex = 14;
            this.pdLbWeightTitle.Text = "Weight";
            // 
            // pdLbFirstname
            // 
            this.pdLbFirstname.AutoSize = true;
            this.pdLbFirstname.Location = new System.Drawing.Point(73, 5);
            this.pdLbFirstname.Name = "pdLbFirstname";
            this.pdLbFirstname.Size = new System.Drawing.Size(52, 13);
            this.pdLbFirstname.TabIndex = 7;
            this.pdLbFirstname.Text = "Firstname";
            // 
            // pdLbSizeTitle
            // 
            this.pdLbSizeTitle.AutoSize = true;
            this.pdLbSizeTitle.Location = new System.Drawing.Point(5, 55);
            this.pdLbSizeTitle.Name = "pdLbSizeTitle";
            this.pdLbSizeTitle.Size = new System.Drawing.Size(27, 13);
            this.pdLbSizeTitle.TabIndex = 13;
            this.pdLbSizeTitle.Text = "Size";
            // 
            // pdLbLastname
            // 
            this.pdLbLastname.AutoSize = true;
            this.pdLbLastname.Location = new System.Drawing.Point(73, 30);
            this.pdLbLastname.Name = "pdLbLastname";
            this.pdLbLastname.Size = new System.Drawing.Size(53, 13);
            this.pdLbLastname.TabIndex = 8;
            this.pdLbLastname.Text = "Lastname";
            // 
            // pdLbLastnameTitle
            // 
            this.pdLbLastnameTitle.AutoSize = true;
            this.pdLbLastnameTitle.Location = new System.Drawing.Point(5, 30);
            this.pdLbLastnameTitle.Name = "pdLbLastnameTitle";
            this.pdLbLastnameTitle.Size = new System.Drawing.Size(53, 13);
            this.pdLbLastnameTitle.TabIndex = 12;
            this.pdLbLastnameTitle.Text = "Lastname";
            // 
            // pdLbSize
            // 
            this.pdLbSize.AutoSize = true;
            this.pdLbSize.Location = new System.Drawing.Point(73, 55);
            this.pdLbSize.Name = "pdLbSize";
            this.pdLbSize.Size = new System.Drawing.Size(27, 13);
            this.pdLbSize.TabIndex = 9;
            this.pdLbSize.Text = "Size";
            // 
            // pdLbFirstnameTitle
            // 
            this.pdLbFirstnameTitle.AutoSize = true;
            this.pdLbFirstnameTitle.Location = new System.Drawing.Point(5, 5);
            this.pdLbFirstnameTitle.Name = "pdLbFirstnameTitle";
            this.pdLbFirstnameTitle.Size = new System.Drawing.Size(52, 13);
            this.pdLbFirstnameTitle.TabIndex = 11;
            this.pdLbFirstnameTitle.Text = "Firstname";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 499);
            this.Controls.Add(this.tabControll);
            this.Name = "FrmMain";
            this.Text = "Puls-analyser (Professional)";
            this.tabControll.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.regPnlCenter.ResumeLayout(false);
            this.regPnlCenter.PerformLayout();
            this.regPanHf.ResumeLayout(false);
            this.regPanHf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regNudHfMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNudWight)).EndInit();
            this.tabLogin.ResumeLayout(false);
            this.logPnlDisplay.ResumeLayout(false);
            this.logPnlDisplay.PerformLayout();
            this.tabStatsAll.ResumeLayout(false);
            this.tabStatsAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staChartDisplay)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAnalysisMe.ResumeLayout(false);
            this.tabAnalysisMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmeGDVCriticalViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anmeChartDisplay)).EndInit();
            this.tabPersonalData.ResumeLayout(false);
            this.tabPersonalData.PerformLayout();
            this.perPnlActivity.ResumeLayout(false);
            this.perPnlActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perNudTrainingHeartRade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perNudRestingPulse)).EndInit();
            this.perPnlDisplay.ResumeLayout(false);
            this.perPnlDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControll;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TextBox regTbPasswordConfirm;
        private System.Windows.Forms.TextBox regTbPassword;
        private System.Windows.Forms.Button regBtnLogin;
        private System.Windows.Forms.TextBox logTbPassword;
        private System.Windows.Forms.Button logBtnLogin;
        private System.Windows.Forms.Label regLbConfrimPassword;
        private System.Windows.Forms.Label regLbPassword;
        private System.Windows.Forms.TextBox regTbLastname;
        private System.Windows.Forms.Label regLbLastname;
        private System.Windows.Forms.Label regLbFirstname;
        private System.Windows.Forms.RadioButton regRadHFManual;
        private System.Windows.Forms.Label regLbGender;
        private System.Windows.Forms.Label regLbM;
        private System.Windows.Forms.Label regLbKG;
        private System.Windows.Forms.NumericUpDown regNudSize;
        private System.Windows.Forms.NumericUpDown regNudWight;
        private System.Windows.Forms.Label regLbSize;
        private System.Windows.Forms.Label regLbWight;
        private System.Windows.Forms.Panel regPanHf;
        private System.Windows.Forms.NumericUpDown regNudHfMax;
        private System.Windows.Forms.RadioButton regRadHfAuto;
        private System.Windows.Forms.Label regLbMaxHf;
        private System.Windows.Forms.Label logLbPassword;
        private System.Windows.Forms.TextBox logTbLastname;
        private System.Windows.Forms.Label logLbLastname;
        private System.Windows.Forms.Label logLbFirstname;
        private System.Windows.Forms.TextBox logTbFirstname;
        private System.Windows.Forms.TabPage tabStatsAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart staChartDisplay;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button setBtnDelte;
        private System.Windows.Forms.TabPage tabAnalysisMe;
        private System.Windows.Forms.TabPage tabPersonalData;
        private System.Windows.Forms.Label perLbTrainingHeartRade;
        private System.Windows.Forms.NumericUpDown perNudTrainingHeartRade;
        private System.Windows.Forms.Label perLbRestingPulse;
        private System.Windows.Forms.Label perLbActivity;
        private System.Windows.Forms.NumericUpDown perNudRestingPulse;
        private System.Windows.Forms.ComboBox perCbActivity;
        private System.Windows.Forms.DataVisualization.Charting.Chart anmeChartDisplay;
        private System.Windows.Forms.Label staLbMode;
        private System.Windows.Forms.ComboBox staCbMode;
        private System.Windows.Forms.DateTimePicker regDpBirth;
        private System.Windows.Forms.TextBox regTbFirstname;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox anmeCbActivity;
        private System.Windows.Forms.Label regLbBirth;
        private System.Windows.Forms.Label regLbTraincondition;
        private System.Windows.Forms.ComboBox regCbTrainingCondition;
        private System.Windows.Forms.CheckBox setChbDeleteSuperUser;
        private System.Windows.Forms.ComboBox regCbGender;
        private System.Windows.Forms.Label pdLbLastname;
        private System.Windows.Forms.Label pdLbFirstname;
        private System.Windows.Forms.Label pdLbWeight;
        private System.Windows.Forms.Label pdLbSize;
        private System.Windows.Forms.DataGridView anmeGDVCriticalViews;
        private System.Windows.Forms.Label anmeLbCriticalValues;
        private System.Windows.Forms.Button regBtnInfo;
        private System.Windows.Forms.Label pdLbWeightTitle;
        private System.Windows.Forms.Label pdLbSizeTitle;
        private System.Windows.Forms.Label pdLbLastnameTitle;
        private System.Windows.Forms.Label pdLbFirstnameTitle;
        private System.Windows.Forms.Panel regPnlCenter;
        private System.Windows.Forms.Panel logPnlDisplay;
        private System.Windows.Forms.Label perLbCalculateTrainingRate;
        private System.Windows.Forms.Label perLbInfos;
        private System.Windows.Forms.Panel perPnlActivity;
        private System.Windows.Forms.Panel perPnlDisplay;
        private System.Windows.Forms.Label welLbWelcome;
        private System.Windows.Forms.Label welLbBkrlogo;
    }
}
