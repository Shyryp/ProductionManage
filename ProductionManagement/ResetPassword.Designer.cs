namespace ProductionManagement
{
    partial class ResetPassword
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
            this.bEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbQeustion = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lQeustion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEnter
            // 
            this.bEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEnter.Location = new System.Drawing.Point(103, 244);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(102, 23);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "Продолжить";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответьте на вопрос:";
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.Location = new System.Drawing.Point(71, 62);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(171, 20);
            this.tbLogin.TabIndex = 3;
            // 
            // tbQeustion
            // 
            this.tbQeustion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQeustion.Enabled = false;
            this.tbQeustion.Location = new System.Drawing.Point(71, 147);
            this.tbQeustion.Name = "tbQeustion";
            this.tbQeustion.Size = new System.Drawing.Size(171, 20);
            this.tbQeustion.TabIndex = 4;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewPassword.Enabled = false;
            this.tbNewPassword.Location = new System.Drawing.Point(71, 204);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(171, 20);
            this.tbNewPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(71, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите новый пароль";
            // 
            // lQeustion
            // 
            this.lQeustion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lQeustion.AutoSize = true;
            this.lQeustion.Location = new System.Drawing.Point(12, 116);
            this.lQeustion.Name = "lQeustion";
            this.lQeustion.Size = new System.Drawing.Size(44, 13);
            this.lQeustion.TabIndex = 7;
            this.lQeustion.Text = "Вопрос";
            this.lQeustion.Visible = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.lQeustion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbQeustion);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEnter);
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "ResetPassword";
            this.Text = "Смена пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPassword_FormClosing);
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbQeustion;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lQeustion;
    }
}