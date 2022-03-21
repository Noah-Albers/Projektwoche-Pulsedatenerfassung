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
            this.tabControll = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.regBtnLogin = new System.Windows.Forms.Button();
            this.regTbUsername = new System.Windows.Forms.TextBox();
            this.regTbPassword = new System.Windows.Forms.TextBox();
            this.regTbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.logTbPassword = new System.Windows.Forms.TextBox();
            this.logTbUsername = new System.Windows.Forms.TextBox();
            this.logBtnLogin = new System.Windows.Forms.Button();
            this.tabControll.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControll
            // 
            this.tabControll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControll.Controls.Add(this.tabRegister);
            this.tabControll.Controls.Add(this.tabLogin);
            this.tabControll.Location = new System.Drawing.Point(12, 12);
            this.tabControll.Name = "tabControll";
            this.tabControll.SelectedIndex = 0;
            this.tabControll.Size = new System.Drawing.Size(776, 426);
            this.tabControll.TabIndex = 0;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.regTbPasswordConfirm);
            this.tabRegister.Controls.Add(this.regTbPassword);
            this.tabRegister.Controls.Add(this.regTbUsername);
            this.tabRegister.Controls.Add(this.regBtnLogin);
            this.tabRegister.Location = new System.Drawing.Point(4, 22);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(768, 400);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.logTbPassword);
            this.tabLogin.Controls.Add(this.logTbUsername);
            this.tabLogin.Controls.Add(this.logBtnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(768, 400);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // regBtnLogin
            // 
            this.regBtnLogin.Location = new System.Drawing.Point(205, 201);
            this.regBtnLogin.Name = "regBtnLogin";
            this.regBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.regBtnLogin.TabIndex = 0;
            this.regBtnLogin.Text = "button1";
            this.regBtnLogin.UseVisualStyleBackColor = true;
            // 
            // regTbUsername
            // 
            this.regTbUsername.Location = new System.Drawing.Point(205, 83);
            this.regTbUsername.Name = "regTbUsername";
            this.regTbUsername.Size = new System.Drawing.Size(277, 20);
            this.regTbUsername.TabIndex = 1;
            // 
            // regTbPassword
            // 
            this.regTbPassword.Location = new System.Drawing.Point(205, 136);
            this.regTbPassword.Name = "regTbPassword";
            this.regTbPassword.Size = new System.Drawing.Size(277, 20);
            this.regTbPassword.TabIndex = 2;
            // 
            // regTbPasswordConfirm
            // 
            this.regTbPasswordConfirm.Location = new System.Drawing.Point(205, 163);
            this.regTbPasswordConfirm.Name = "regTbPasswordConfirm";
            this.regTbPasswordConfirm.Size = new System.Drawing.Size(277, 20);
            this.regTbPasswordConfirm.TabIndex = 3;
            // 
            // logTbPassword
            // 
            this.logTbPassword.Location = new System.Drawing.Point(246, 183);
            this.logTbPassword.Name = "logTbPassword";
            this.logTbPassword.Size = new System.Drawing.Size(277, 20);
            this.logTbPassword.TabIndex = 6;
            // 
            // logTbUsername
            // 
            this.logTbUsername.Location = new System.Drawing.Point(246, 130);
            this.logTbUsername.Name = "logTbUsername";
            this.logTbUsername.Size = new System.Drawing.Size(277, 20);
            this.logTbUsername.TabIndex = 5;
            // 
            // logBtnLogin
            // 
            this.logBtnLogin.Location = new System.Drawing.Point(246, 248);
            this.logBtnLogin.Name = "logBtnLogin";
            this.logBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.logBtnLogin.TabIndex = 4;
            this.logBtnLogin.Text = "button1";
            this.logBtnLogin.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControll);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.tabControll.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControll;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TextBox regTbPasswordConfirm;
        private System.Windows.Forms.TextBox regTbPassword;
        private System.Windows.Forms.TextBox regTbUsername;
        private System.Windows.Forms.Button regBtnLogin;
        private System.Windows.Forms.TextBox logTbPassword;
        private System.Windows.Forms.TextBox logTbUsername;
        private System.Windows.Forms.Button logBtnLogin;
    }
}