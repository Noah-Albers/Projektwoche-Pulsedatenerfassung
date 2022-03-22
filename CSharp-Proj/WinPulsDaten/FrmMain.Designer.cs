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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControll = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.regLbBirth = new System.Windows.Forms.Label();
            this.regLbTraincondition = new System.Windows.Forms.Label();
            this.regCbTrainingCondition = new System.Windows.Forms.ComboBox();
            this.regTbFirstname = new System.Windows.Forms.TextBox();
            this.regDpBirth = new System.Windows.Forms.DateTimePicker();
            this.regPanHp = new System.Windows.Forms.Panel();
            this.regNudHpMax = new System.Windows.Forms.NumericUpDown();
            this.regRadHPAuto = new System.Windows.Forms.RadioButton();
            this.regRadHFManual = new System.Windows.Forms.RadioButton();
            this.regLbMaxHp = new System.Windows.Forms.Label();
            this.regLbSize = new System.Windows.Forms.Label();
            this.regLbWight = new System.Windows.Forms.Label();
            this.regLbM = new System.Windows.Forms.Label();
            this.regLbKG = new System.Windows.Forms.Label();
            this.regNutSize = new System.Windows.Forms.NumericUpDown();
            this.regNudWight = new System.Windows.Forms.NumericUpDown();
            this.regLbGender = new System.Windows.Forms.Label();
            this.regCbGender = new System.Windows.Forms.ComboBox();
            this.regLbConfrimPassword = new System.Windows.Forms.Label();
            this.regLbPassword = new System.Windows.Forms.Label();
            this.regTbLastname = new System.Windows.Forms.TextBox();
            this.regLbLastname = new System.Windows.Forms.Label();
            this.regLbFirstname = new System.Windows.Forms.Label();
            this.regTbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.regTbPassword = new System.Windows.Forms.TextBox();
            this.regBtnLogin = new System.Windows.Forms.Button();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.logLbPassword = new System.Windows.Forms.Label();
            this.logTbLastname = new System.Windows.Forms.TextBox();
            this.logLbLastname = new System.Windows.Forms.Label();
            this.logLbFirstname = new System.Windows.Forms.Label();
            this.logTbFirstname = new System.Windows.Forms.TextBox();
            this.logTbPassword = new System.Windows.Forms.TextBox();
            this.logBtnLogin = new System.Windows.Forms.Button();
            this.tabStatsAll = new System.Windows.Forms.TabPage();
            this.staLbMode = new System.Windows.Forms.Label();
            this.staCbMode = new System.Windows.Forms.ComboBox();
            this.staChartDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.setChbDeleteSuperUser = new System.Windows.Forms.CheckBox();
            this.setBtnDelte = new System.Windows.Forms.Button();
            this.tabAnalysisMe = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.anmeCbActivity = new System.Windows.Forms.ComboBox();
            this.anmeChartDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.perLbTrainingHeartRade = new System.Windows.Forms.Label();
            this.perNudTrainingHeartRade = new System.Windows.Forms.NumericUpDown();
            this.perLbRestingPulse = new System.Windows.Forms.Label();
            this.perLbActivity = new System.Windows.Forms.Label();
            this.perNudRestingPulse = new System.Windows.Forms.NumericUpDown();
            this.perCbActivity = new System.Windows.Forms.ComboBox();
            this.tabControll.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.regPanHp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regNudHpMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNutSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNudWight)).BeginInit();
            this.tabLogin.SuspendLayout();
            this.tabStatsAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staChartDisplay)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabAnalysisMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmeChartDisplay)).BeginInit();
            this.tabPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perNudTrainingHeartRade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perNudRestingPulse)).BeginInit();
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
            this.tabControll.Size = new System.Drawing.Size(776, 572);
            this.tabControll.TabIndex = 0;
            this.tabControll.SelectedIndexChanged += new System.EventHandler(this.tabControll_TabIndexChanged);
            // 
            // tabWelcome
            // 
            this.tabWelcome.Location = new System.Drawing.Point(4, 22);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Size = new System.Drawing.Size(768, 546);
            this.tabWelcome.TabIndex = 6;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.regLbBirth);
            this.tabRegister.Controls.Add(this.regLbTraincondition);
            this.tabRegister.Controls.Add(this.regCbTrainingCondition);
            this.tabRegister.Controls.Add(this.regTbFirstname);
            this.tabRegister.Controls.Add(this.regDpBirth);
            this.tabRegister.Controls.Add(this.regPanHp);
            this.tabRegister.Controls.Add(this.regLbMaxHp);
            this.tabRegister.Controls.Add(this.regLbSize);
            this.tabRegister.Controls.Add(this.regLbWight);
            this.tabRegister.Controls.Add(this.regLbM);
            this.tabRegister.Controls.Add(this.regLbKG);
            this.tabRegister.Controls.Add(this.regNutSize);
            this.tabRegister.Controls.Add(this.regNudWight);
            this.tabRegister.Controls.Add(this.regLbGender);
            this.tabRegister.Controls.Add(this.regCbGender);
            this.tabRegister.Controls.Add(this.regLbConfrimPassword);
            this.tabRegister.Controls.Add(this.regLbPassword);
            this.tabRegister.Controls.Add(this.regTbLastname);
            this.tabRegister.Controls.Add(this.regLbLastname);
            this.tabRegister.Controls.Add(this.regLbFirstname);
            this.tabRegister.Controls.Add(this.regTbPasswordConfirm);
            this.tabRegister.Controls.Add(this.regTbPassword);
            this.tabRegister.Controls.Add(this.regBtnLogin);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(768, 546);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // regLbBirth
            // 
            this.regLbBirth.AutoSize = true;
            this.regLbBirth.Location = new System.Drawing.Point(100, 366);
            this.regLbBirth.Name = "regLbBirth";
            this.regLbBirth.Size = new System.Drawing.Size(45, 13);
            this.regLbBirth.TabIndex = 27;
            this.regLbBirth.Text = "Birthday";
            // 
            // regLbTraincondition
            // 
            this.regLbTraincondition.AutoSize = true;
            this.regLbTraincondition.Location = new System.Drawing.Point(103, 315);
            this.regLbTraincondition.Name = "regLbTraincondition";
            this.regLbTraincondition.Size = new System.Drawing.Size(92, 13);
            this.regLbTraincondition.TabIndex = 26;
            this.regLbTraincondition.Text = "Training Condition";
            // 
            // regCbTrainingCondition
            // 
            this.regCbTrainingCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regCbTrainingCondition.FormattingEnabled = true;
            this.regCbTrainingCondition.Location = new System.Drawing.Point(103, 331);
            this.regCbTrainingCondition.Name = "regCbTrainingCondition";
            this.regCbTrainingCondition.Size = new System.Drawing.Size(168, 21);
            this.regCbTrainingCondition.TabIndex = 25;
            this.regCbTrainingCondition.SelectedIndexChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // regTbFirstname
            // 
            this.regTbFirstname.Location = new System.Drawing.Point(109, 75);
            this.regTbFirstname.Name = "regTbFirstname";
            this.regTbFirstname.Size = new System.Drawing.Size(168, 20);
            this.regTbFirstname.TabIndex = 1;
            // 
            // regDpBirth
            // 
            this.regDpBirth.Location = new System.Drawing.Point(103, 382);
            this.regDpBirth.Name = "regDpBirth";
            this.regDpBirth.Size = new System.Drawing.Size(330, 20);
            this.regDpBirth.TabIndex = 11;
            // 
            // regPanHp
            // 
            this.regPanHp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.regPanHp.Controls.Add(this.regNudHpMax);
            this.regPanHp.Controls.Add(this.regRadHPAuto);
            this.regPanHp.Controls.Add(this.regRadHFManual);
            this.regPanHp.Location = new System.Drawing.Point(285, 280);
            this.regPanHp.Name = "regPanHp";
            this.regPanHp.Size = new System.Drawing.Size(148, 79);
            this.regPanHp.TabIndex = 24;
            // 
            // regNudHpMax
            // 
            this.regNudHpMax.DecimalPlaces = 2;
            this.regNudHpMax.Location = new System.Drawing.Point(4, 50);
            this.regNudHpMax.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.regNudHpMax.Name = "regNudHpMax";
            this.regNudHpMax.Size = new System.Drawing.Size(137, 20);
            this.regNudHpMax.TabIndex = 9;
            // 
            // regRadHPAuto
            // 
            this.regRadHPAuto.AutoSize = true;
            this.regRadHPAuto.Location = new System.Drawing.Point(3, 27);
            this.regRadHPAuto.Name = "regRadHPAuto";
            this.regRadHPAuto.Size = new System.Drawing.Size(69, 17);
            this.regRadHPAuto.TabIndex = 8;
            this.regRadHPAuto.TabStop = true;
            this.regRadHPAuto.Text = "Calculate";
            this.regRadHPAuto.UseVisualStyleBackColor = true;
            this.regRadHPAuto.CheckedChanged += new System.EventHandler(this.regRadHPAuto_CheckedChanged);
            // 
            // regRadHFManual
            // 
            this.regRadHFManual.AutoSize = true;
            this.regRadHFManual.Location = new System.Drawing.Point(3, 4);
            this.regRadHFManual.Name = "regRadHFManual";
            this.regRadHFManual.Size = new System.Drawing.Size(95, 17);
            this.regRadHFManual.TabIndex = 7;
            this.regRadHFManual.TabStop = true;
            this.regRadHFManual.Text = "Assign yourself";
            this.regRadHFManual.UseVisualStyleBackColor = true;
            this.regRadHFManual.CheckedChanged += new System.EventHandler(this.OnRegSelectMangualHF);
            // 
            // regLbMaxHp
            // 
            this.regLbMaxHp.AutoSize = true;
            this.regLbMaxHp.Location = new System.Drawing.Point(282, 264);
            this.regLbMaxHp.Name = "regLbMaxHp";
            this.regLbMaxHp.Size = new System.Drawing.Size(75, 13);
            this.regLbMaxHp.TabIndex = 22;
            this.regLbMaxHp.Text = "Max HP-Value";
            // 
            // regLbSize
            // 
            this.regLbSize.AutoSize = true;
            this.regLbSize.Location = new System.Drawing.Point(282, 209);
            this.regLbSize.Name = "regLbSize";
            this.regLbSize.Size = new System.Drawing.Size(27, 13);
            this.regLbSize.TabIndex = 20;
            this.regLbSize.Text = "Size";
            // 
            // regLbWight
            // 
            this.regLbWight.AutoSize = true;
            this.regLbWight.Location = new System.Drawing.Point(103, 209);
            this.regLbWight.Name = "regLbWight";
            this.regLbWight.Size = new System.Drawing.Size(41, 13);
            this.regLbWight.TabIndex = 19;
            this.regLbWight.Text = "Weight";
            // 
            // regLbM
            // 
            this.regLbM.AutoSize = true;
            this.regLbM.Location = new System.Drawing.Point(430, 231);
            this.regLbM.Name = "regLbM";
            this.regLbM.Size = new System.Drawing.Size(15, 13);
            this.regLbM.TabIndex = 18;
            this.regLbM.Text = "m";
            // 
            // regLbKG
            // 
            this.regLbKG.AutoSize = true;
            this.regLbKG.Location = new System.Drawing.Point(254, 230);
            this.regLbKG.Name = "regLbKG";
            this.regLbKG.Size = new System.Drawing.Size(19, 13);
            this.regLbKG.TabIndex = 17;
            this.regLbKG.Text = "kg";
            // 
            // regNutSize
            // 
            this.regNutSize.DecimalPlaces = 2;
            this.regNutSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.regNutSize.Location = new System.Drawing.Point(282, 227);
            this.regNutSize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.regNutSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regNutSize.Name = "regNutSize";
            this.regNutSize.Size = new System.Drawing.Size(148, 20);
            this.regNutSize.TabIndex = 6;
            this.regNutSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.regNutSize.ValueChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // regNudWight
            // 
            this.regNudWight.Location = new System.Drawing.Point(103, 227);
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
            // regLbGender
            // 
            this.regLbGender.AutoSize = true;
            this.regLbGender.Location = new System.Drawing.Point(103, 264);
            this.regLbGender.Name = "regLbGender";
            this.regLbGender.Size = new System.Drawing.Size(42, 13);
            this.regLbGender.TabIndex = 12;
            this.regLbGender.Text = "Gender";
            // 
            // regCbGender
            // 
            this.regCbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regCbGender.FormattingEnabled = true;
            this.regCbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.regCbGender.Location = new System.Drawing.Point(103, 280);
            this.regCbGender.Name = "regCbGender";
            this.regCbGender.Size = new System.Drawing.Size(168, 21);
            this.regCbGender.TabIndex = 10;
            this.regCbGender.SelectedIndexChanged += new System.EventHandler(this.OnRegHFValueChange);
            // 
            // regLbConfrimPassword
            // 
            this.regLbConfrimPassword.AutoSize = true;
            this.regLbConfrimPassword.Location = new System.Drawing.Point(106, 159);
            this.regLbConfrimPassword.Name = "regLbConfrimPassword";
            this.regLbConfrimPassword.Size = new System.Drawing.Size(91, 13);
            this.regLbConfrimPassword.TabIndex = 10;
            this.regLbConfrimPassword.Text = "Confrim Password";
            // 
            // regLbPassword
            // 
            this.regLbPassword.AutoSize = true;
            this.regLbPassword.Location = new System.Drawing.Point(106, 109);
            this.regLbPassword.Name = "regLbPassword";
            this.regLbPassword.Size = new System.Drawing.Size(53, 13);
            this.regLbPassword.TabIndex = 9;
            this.regLbPassword.Text = "Password";
            // 
            // regTbLastname
            // 
            this.regTbLastname.Location = new System.Drawing.Point(285, 75);
            this.regTbLastname.Name = "regTbLastname";
            this.regTbLastname.Size = new System.Drawing.Size(168, 20);
            this.regTbLastname.TabIndex = 2;
            // 
            // regLbLastname
            // 
            this.regLbLastname.AutoSize = true;
            this.regLbLastname.Location = new System.Drawing.Point(282, 56);
            this.regLbLastname.Name = "regLbLastname";
            this.regLbLastname.Size = new System.Drawing.Size(53, 13);
            this.regLbLastname.TabIndex = 7;
            this.regLbLastname.Text = "Lastname";
            // 
            // regLbFirstname
            // 
            this.regLbFirstname.AutoSize = true;
            this.regLbFirstname.Location = new System.Drawing.Point(106, 56);
            this.regLbFirstname.Name = "regLbFirstname";
            this.regLbFirstname.Size = new System.Drawing.Size(52, 13);
            this.regLbFirstname.TabIndex = 6;
            this.regLbFirstname.Text = "Firstname";
            // 
            // regTbPasswordConfirm
            // 
            this.regTbPasswordConfirm.Location = new System.Drawing.Point(106, 175);
            this.regTbPasswordConfirm.Name = "regTbPasswordConfirm";
            this.regTbPasswordConfirm.Size = new System.Drawing.Size(347, 20);
            this.regTbPasswordConfirm.TabIndex = 4;
            // 
            // regTbPassword
            // 
            this.regTbPassword.Location = new System.Drawing.Point(106, 125);
            this.regTbPassword.Name = "regTbPassword";
            this.regTbPassword.Size = new System.Drawing.Size(347, 20);
            this.regTbPassword.TabIndex = 3;
            // 
            // regBtnLogin
            // 
            this.regBtnLogin.Location = new System.Drawing.Point(200, 453);
            this.regBtnLogin.Name = "regBtnLogin";
            this.regBtnLogin.Size = new System.Drawing.Size(135, 23);
            this.regBtnLogin.TabIndex = 12;
            this.regBtnLogin.Text = "Register";
            this.regBtnLogin.UseVisualStyleBackColor = true;
            this.regBtnLogin.Click += new System.EventHandler(this.OnRegRegisterClicked);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.logLbPassword);
            this.tabLogin.Controls.Add(this.logTbLastname);
            this.tabLogin.Controls.Add(this.logLbLastname);
            this.tabLogin.Controls.Add(this.logLbFirstname);
            this.tabLogin.Controls.Add(this.logTbFirstname);
            this.tabLogin.Controls.Add(this.logTbPassword);
            this.tabLogin.Controls.Add(this.logBtnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(768, 546);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // logLbPassword
            // 
            this.logLbPassword.AutoSize = true;
            this.logLbPassword.Location = new System.Drawing.Point(64, 103);
            this.logLbPassword.Name = "logLbPassword";
            this.logLbPassword.Size = new System.Drawing.Size(53, 13);
            this.logLbPassword.TabIndex = 14;
            this.logLbPassword.Text = "Password";
            // 
            // logTbLastname
            // 
            this.logTbLastname.Location = new System.Drawing.Point(243, 69);
            this.logTbLastname.Name = "logTbLastname";
            this.logTbLastname.Size = new System.Drawing.Size(168, 20);
            this.logTbLastname.TabIndex = 14;
            // 
            // logLbLastname
            // 
            this.logLbLastname.AutoSize = true;
            this.logLbLastname.Location = new System.Drawing.Point(240, 50);
            this.logLbLastname.Name = "logLbLastname";
            this.logLbLastname.Size = new System.Drawing.Size(53, 13);
            this.logLbLastname.TabIndex = 12;
            this.logLbLastname.Text = "Lastname";
            // 
            // logLbFirstname
            // 
            this.logLbFirstname.AutoSize = true;
            this.logLbFirstname.Location = new System.Drawing.Point(64, 50);
            this.logLbFirstname.Name = "logLbFirstname";
            this.logLbFirstname.Size = new System.Drawing.Size(52, 13);
            this.logLbFirstname.TabIndex = 11;
            this.logLbFirstname.Text = "Firstname";
            // 
            // logTbFirstname
            // 
            this.logTbFirstname.Location = new System.Drawing.Point(64, 69);
            this.logTbFirstname.Name = "logTbFirstname";
            this.logTbFirstname.Size = new System.Drawing.Size(168, 20);
            this.logTbFirstname.TabIndex = 13;
            // 
            // logTbPassword
            // 
            this.logTbPassword.Location = new System.Drawing.Point(65, 127);
            this.logTbPassword.Name = "logTbPassword";
            this.logTbPassword.Size = new System.Drawing.Size(167, 20);
            this.logTbPassword.TabIndex = 15;
            // 
            // logBtnLogin
            // 
            this.logBtnLogin.Location = new System.Drawing.Point(64, 164);
            this.logBtnLogin.Name = "logBtnLogin";
            this.logBtnLogin.Size = new System.Drawing.Size(105, 23);
            this.logBtnLogin.TabIndex = 16;
            this.logBtnLogin.Text = "button1";
            this.logBtnLogin.UseVisualStyleBackColor = true;
            this.logBtnLogin.Click += new System.EventHandler(this.OnLogLoginClicked);
            // 
            // tabStatsAll
            // 
            this.tabStatsAll.Controls.Add(this.staLbMode);
            this.tabStatsAll.Controls.Add(this.staCbMode);
            this.tabStatsAll.Controls.Add(this.staChartDisplay);
            this.tabStatsAll.Location = new System.Drawing.Point(4, 22);
            this.tabStatsAll.Name = "tabStatsAll";
            this.tabStatsAll.Size = new System.Drawing.Size(768, 546);
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
            "MaxHP over Age",
            "Restpulse over Weight"});
            this.staCbMode.Location = new System.Drawing.Point(13, 23);
            this.staCbMode.Name = "staCbMode";
            this.staCbMode.Size = new System.Drawing.Size(121, 21);
            this.staCbMode.TabIndex = 17;
            this.staCbMode.SelectedIndexChanged += new System.EventHandler(this.staCbMode_SelectedIndexChanged);
            // 
            // staChartDisplay
            // 
            chartArea1.Name = "ChartArea1";
            this.staChartDisplay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.staChartDisplay.Legends.Add(legend1);
            this.staChartDisplay.Location = new System.Drawing.Point(3, 50);
            this.staChartDisplay.Name = "staChartDisplay";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.staChartDisplay.Series.Add(series1);
            this.staChartDisplay.Size = new System.Drawing.Size(762, 493);
            this.staChartDisplay.TabIndex = 0;
            this.staChartDisplay.Text = "chart";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.setChbDeleteSuperUser);
            this.tabSettings.Controls.Add(this.setBtnDelte);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(768, 546);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // setChbDeleteSuperUser
            // 
            this.setChbDeleteSuperUser.AutoSize = true;
            this.setChbDeleteSuperUser.Location = new System.Drawing.Point(138, 146);
            this.setChbDeleteSuperUser.Name = "setChbDeleteSuperUser";
            this.setChbDeleteSuperUser.Size = new System.Drawing.Size(115, 17);
            this.setChbDeleteSuperUser.TabIndex = 1;
            this.setChbDeleteSuperUser.Text = "Delete super user?";
            this.setChbDeleteSuperUser.UseVisualStyleBackColor = true;
            // 
            // setBtnDelte
            // 
            this.setBtnDelte.Location = new System.Drawing.Point(138, 169);
            this.setBtnDelte.Name = "setBtnDelte";
            this.setBtnDelte.Size = new System.Drawing.Size(147, 23);
            this.setBtnDelte.TabIndex = 0;
            this.setBtnDelte.Text = "Delete all data";
            this.setBtnDelte.UseVisualStyleBackColor = true;
            this.setBtnDelte.Click += new System.EventHandler(this.setBtnDelte_Click);
            // 
            // tabAnalysisMe
            // 
            this.tabAnalysisMe.Controls.Add(this.label1);
            this.tabAnalysisMe.Controls.Add(this.anmeCbActivity);
            this.tabAnalysisMe.Controls.Add(this.anmeChartDisplay);
            this.tabAnalysisMe.Location = new System.Drawing.Point(4, 22);
            this.tabAnalysisMe.Name = "tabAnalysisMe";
            this.tabAnalysisMe.Size = new System.Drawing.Size(768, 546);
            this.tabAnalysisMe.TabIndex = 4;
            this.tabAnalysisMe.Text = "Analysis (Me)";
            this.tabAnalysisMe.UseVisualStyleBackColor = true;
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
            "MaxHP over Age",
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
            this.anmeChartDisplay.Size = new System.Drawing.Size(762, 492);
            this.anmeChartDisplay.TabIndex = 1;
            this.anmeChartDisplay.Text = "chart2";
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Controls.Add(this.perLbTrainingHeartRade);
            this.tabPersonalData.Controls.Add(this.perNudTrainingHeartRade);
            this.tabPersonalData.Controls.Add(this.perLbRestingPulse);
            this.tabPersonalData.Controls.Add(this.perLbActivity);
            this.tabPersonalData.Controls.Add(this.perNudRestingPulse);
            this.tabPersonalData.Controls.Add(this.perCbActivity);
            this.tabPersonalData.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Size = new System.Drawing.Size(768, 546);
            this.tabPersonalData.TabIndex = 5;
            this.tabPersonalData.Text = "Personsal data";
            this.tabPersonalData.UseVisualStyleBackColor = true;
            // 
            // perLbTrainingHeartRade
            // 
            this.perLbTrainingHeartRade.AutoSize = true;
            this.perLbTrainingHeartRade.Location = new System.Drawing.Point(279, 223);
            this.perLbTrainingHeartRade.Name = "perLbTrainingHeartRade";
            this.perLbTrainingHeartRade.Size = new System.Drawing.Size(100, 13);
            this.perLbTrainingHeartRade.TabIndex = 6;
            this.perLbTrainingHeartRade.Text = "Training Heart Rate";
            // 
            // perNudTrainingHeartRade
            // 
            this.perNudTrainingHeartRade.Location = new System.Drawing.Point(279, 239);
            this.perNudTrainingHeartRade.Name = "perNudTrainingHeartRade";
            this.perNudTrainingHeartRade.Size = new System.Drawing.Size(192, 20);
            this.perNudTrainingHeartRade.TabIndex = 5;
            // 
            // perLbRestingPulse
            // 
            this.perLbRestingPulse.AutoSize = true;
            this.perLbRestingPulse.Location = new System.Drawing.Point(279, 169);
            this.perLbRestingPulse.Name = "perLbRestingPulse";
            this.perLbRestingPulse.Size = new System.Drawing.Size(72, 13);
            this.perLbRestingPulse.TabIndex = 4;
            this.perLbRestingPulse.Text = "Resting Pulse";
            // 
            // perLbActivity
            // 
            this.perLbActivity.AutoSize = true;
            this.perLbActivity.Location = new System.Drawing.Point(279, 120);
            this.perLbActivity.Name = "perLbActivity";
            this.perLbActivity.Size = new System.Drawing.Size(41, 13);
            this.perLbActivity.TabIndex = 3;
            this.perLbActivity.Text = "Activity";
            // 
            // perNudRestingPulse
            // 
            this.perNudRestingPulse.Location = new System.Drawing.Point(279, 185);
            this.perNudRestingPulse.Name = "perNudRestingPulse";
            this.perNudRestingPulse.Size = new System.Drawing.Size(192, 20);
            this.perNudRestingPulse.TabIndex = 2;
            // 
            // perCbActivity
            // 
            this.perCbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perCbActivity.FormattingEnabled = true;
            this.perCbActivity.Location = new System.Drawing.Point(279, 136);
            this.perCbActivity.Name = "perCbActivity";
            this.perCbActivity.Size = new System.Drawing.Size(192, 21);
            this.perCbActivity.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.tabControll);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.tabControll.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.regPanHp.ResumeLayout(false);
            this.regPanHp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regNudHpMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNutSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNudWight)).EndInit();
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabStatsAll.ResumeLayout(false);
            this.tabStatsAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staChartDisplay)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAnalysisMe.ResumeLayout(false);
            this.tabAnalysisMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anmeChartDisplay)).EndInit();
            this.tabPersonalData.ResumeLayout(false);
            this.tabPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perNudTrainingHeartRade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perNudRestingPulse)).EndInit();
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
        private System.Windows.Forms.NumericUpDown regNutSize;
        private System.Windows.Forms.NumericUpDown regNudWight;
        private System.Windows.Forms.Label regLbSize;
        private System.Windows.Forms.Label regLbWight;
        private System.Windows.Forms.Panel regPanHp;
        private System.Windows.Forms.NumericUpDown regNudHpMax;
        private System.Windows.Forms.RadioButton regRadHPAuto;
        private System.Windows.Forms.Label regLbMaxHp;
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
    }
}
