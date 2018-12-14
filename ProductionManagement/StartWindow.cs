using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProductionManagement
{
    public partial class StartWindow : Form
    {
        SqlConnection sqlConnection;
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

        private async void bEnter_Click(object sender, EventArgs e)
        {
            //Проверка логина и пароля по базе
            

            proc.Login = tbLogin.Text;
            this.Close();
        }

        private void lErrorPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Run(new ResetPassword());
        }

        private async void StartWindow_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
