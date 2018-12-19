namespace ProductionManagement
{
    partial class StartWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.bEnter = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lErrorPassword = new System.Windows.Forms.LinkLabel();
            this.bRegestration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEnter
            // 
            this.bEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bEnter.Location = new System.Drawing.Point(69, 147);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(140, 23);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "Войти";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.Location = new System.Drawing.Point(44, 40);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(205, 20);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Shyryp";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(44, 105);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(205, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "12345";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин или емаил:";
            // 
            // lErrorPassword
            // 
            this.lErrorPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lErrorPassword.AutoSize = true;
            this.lErrorPassword.Location = new System.Drawing.Point(158, 128);
            this.lErrorPassword.Name = "lErrorPassword";
            this.lErrorPassword.Size = new System.Drawing.Size(91, 13);
            this.lErrorPassword.TabIndex = 5;
            this.lErrorPassword.TabStop = true;
            this.lErrorPassword.Text = "Забыли пароль?";
            this.lErrorPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lErrorPassword_LinkClicked);
            // 
            // bRegestration
            // 
            this.bRegestration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRegestration.Location = new System.Drawing.Point(69, 176);
            this.bRegestration.Name = "bRegestration";
            this.bRegestration.Size = new System.Drawing.Size(140, 23);
            this.bRegestration.TabIndex = 6;
            this.bRegestration.Text = "Зарегистрироваться";
            this.bRegestration.UseVisualStyleBackColor = true;
            this.bRegestration.Click += new System.EventHandler(this.bRegestration_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "ClearDB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bRegestration);
            this.Controls.Add(this.lErrorPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "StartWindow";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWindow_FormClosing);
            this.Load += new System.EventHandler(this.StartWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lErrorPassword;
        private System.Windows.Forms.Button bRegestration;
        private System.Windows.Forms.Button button1;
    }
}

