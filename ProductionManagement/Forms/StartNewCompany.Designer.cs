namespace ProductionManagement
{
    partial class StartNewCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameCompany = new System.Windows.Forms.TextBox();
            this.bEnter = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название компании:";
            // 
            // tbNameCompany
            // 
            this.tbNameCompany.Location = new System.Drawing.Point(27, 58);
            this.tbNameCompany.Name = "tbNameCompany";
            this.tbNameCompany.Size = new System.Drawing.Size(209, 20);
            this.tbNameCompany.TabIndex = 1;
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(27, 99);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(83, 23);
            this.bEnter.TabIndex = 2;
            this.bEnter.Text = "Подтвердить";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(155, 99);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(81, 23);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Выйти";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // StartNewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 134);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.tbNameCompany);
            this.Controls.Add(this.label1);
            this.Name = "StartNewCompany";
            this.Text = "Создание компании";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartNewCompany_FormClosing);
            this.Load += new System.EventHandler(this.StartNewCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameCompany;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bExit;
    }
}