using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionManagement
{
    public partial class StartWindow : Form
    {
        Process proc;
        public StartWindow()
        {
            InitializeComponent();
            
        }

        public StartWindow(Process p)
        {
            InitializeComponent();
            this.proc = p;
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            //Проверка логина и пароля по базе


            proc.Login = tbLogin.Text;
            this.Close();
        }

        private void lErrorPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Run(new ResetPassword());
        }
    }
}
