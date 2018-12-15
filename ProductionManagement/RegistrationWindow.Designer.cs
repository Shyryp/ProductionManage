namespace ProductionManagement
{
    partial class RegistrationWindow
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
            this.bEnterReg = new System.Windows.Forms.Button();
            this.tbNewLogin = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.lNewLogin = new System.Windows.Forms.Label();
            this.lCNewPassword = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lNewName = new System.Windows.Forms.Label();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.lNewQeustion = new System.Windows.Forms.Label();
            this.tbNewSecretQeustion = new System.Windows.Forms.TextBox();
            this.lNewAnswer = new System.Windows.Forms.Label();
            this.tbNewSecretAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bEnterReg
            // 
            this.bEnterReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEnterReg.Location = new System.Drawing.Point(68, 319);
            this.bEnterReg.Name = "bEnterReg";
            this.bEnterReg.Size = new System.Drawing.Size(140, 23);
            this.bEnterReg.TabIndex = 6;
            this.bEnterReg.Text = "Зарегистрироваться";
            this.bEnterReg.UseVisualStyleBackColor = true;
            this.bEnterReg.Click += new System.EventHandler(this.bEnterReg_Click);
            // 
            // tbNewLogin
            // 
            this.tbNewLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewLogin.Location = new System.Drawing.Point(34, 93);
            this.tbNewLogin.Name = "tbNewLogin";
            this.tbNewLogin.Size = new System.Drawing.Size(205, 20);
            this.tbNewLogin.TabIndex = 7;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewPassword.Location = new System.Drawing.Point(34, 141);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(205, 20);
            this.tbNewPassword.TabIndex = 8;
            // 
            // lNewPassword
            // 
            this.lNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Location = new System.Drawing.Point(34, 125);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(48, 13);
            this.lNewPassword.TabIndex = 9;
            this.lNewPassword.Text = "Пароль:";
            // 
            // lNewLogin
            // 
            this.lNewLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewLogin.AutoSize = true;
            this.lNewLogin.Location = new System.Drawing.Point(34, 74);
            this.lNewLogin.Name = "lNewLogin";
            this.lNewLogin.Size = new System.Drawing.Size(97, 13);
            this.lNewLogin.TabIndex = 10;
            this.lNewLogin.Text = "Логин или емаил:";
            // 
            // lCNewPassword
            // 
            this.lCNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCNewPassword.AutoSize = true;
            this.lCNewPassword.Location = new System.Drawing.Point(34, 168);
            this.lCNewPassword.Name = "lCNewPassword";
            this.lCNewPassword.Size = new System.Drawing.Size(103, 13);
            this.lCNewPassword.TabIndex = 12;
            this.lCNewPassword.Text = "Повторите пароль:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfirmPassword.Location = new System.Drawing.Point(34, 184);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(205, 20);
            this.tbConfirmPassword.TabIndex = 11;
            // 
            // lNewName
            // 
            this.lNewName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewName.AutoSize = true;
            this.lNewName.Location = new System.Drawing.Point(34, 24);
            this.lNewName.Name = "lNewName";
            this.lNewName.Size = new System.Drawing.Size(32, 13);
            this.lNewName.TabIndex = 14;
            this.lNewName.Text = "Имя:";
            // 
            // tbNewName
            // 
            this.tbNewName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewName.Location = new System.Drawing.Point(34, 43);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(205, 20);
            this.tbNewName.TabIndex = 13;
            // 
            // lNewQeustion
            // 
            this.lNewQeustion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewQeustion.AutoSize = true;
            this.lNewQeustion.Location = new System.Drawing.Point(34, 219);
            this.lNewQeustion.Name = "lNewQeustion";
            this.lNewQeustion.Size = new System.Drawing.Size(149, 13);
            this.lNewQeustion.TabIndex = 16;
            this.lNewQeustion.Text = "Введите секретный вопрос:";
            // 
            // tbNewSecretQeustion
            // 
            this.tbNewSecretQeustion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewSecretQeustion.Location = new System.Drawing.Point(34, 235);
            this.tbNewSecretQeustion.Name = "tbNewSecretQeustion";
            this.tbNewSecretQeustion.Size = new System.Drawing.Size(205, 20);
            this.tbNewSecretQeustion.TabIndex = 15;
            // 
            // lNewAnswer
            // 
            this.lNewAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewAnswer.AutoSize = true;
            this.lNewAnswer.Location = new System.Drawing.Point(34, 264);
            this.lNewAnswer.Name = "lNewAnswer";
            this.lNewAnswer.Size = new System.Drawing.Size(83, 13);
            this.lNewAnswer.TabIndex = 18;
            this.lNewAnswer.Text = "Введите ответ:";
            // 
            // tbNewSecretAnswer
            // 
            this.tbNewSecretAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewSecretAnswer.Location = new System.Drawing.Point(34, 280);
            this.tbNewSecretAnswer.Name = "tbNewSecretAnswer";
            this.tbNewSecretAnswer.Size = new System.Drawing.Size(205, 20);
            this.tbNewSecretAnswer.TabIndex = 17;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 364);
            this.Controls.Add(this.lNewAnswer);
            this.Controls.Add(this.tbNewSecretAnswer);
            this.Controls.Add(this.lNewQeustion);
            this.Controls.Add(this.tbNewSecretQeustion);
            this.Controls.Add(this.lNewName);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.lCNewPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lNewLogin);
            this.Controls.Add(this.lNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbNewLogin);
            this.Controls.Add(this.bEnterReg);
            this.Name = "RegistrationWindow";
            this.Text = "RegistrationWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationWindow_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnterReg;
        private System.Windows.Forms.TextBox tbNewLogin;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.Label lNewLogin;
        private System.Windows.Forms.Label lCNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lNewName;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label lNewQeustion;
        private System.Windows.Forms.TextBox tbNewSecretQeustion;
        private System.Windows.Forms.Label lNewAnswer;
        private System.Windows.Forms.TextBox tbNewSecretAnswer;
    }
}