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
    public partial class StartNewCompany : Form
    {
        Company company;
        SqlConnection sqlConnection;

        public StartNewCompany()
        {
            InitializeComponent();
        }

        public StartNewCompany(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private async void bEnter_Click(object sender, EventArgs e)
        {
            company.NameCompany = tbNameCompany.Text;
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Company] SET [NameCompany]=@NameCompany WHERE [Id]=@Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("Id", Convert.ToInt32(company.IDCompany));
            sqlCommand.Parameters.AddWithValue("NameCompany", tbNameCompany.Text);
            await sqlCommand.ExecuteNonQueryAsync();
            this.Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void StartNewCompany_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            this.WindowState = FormWindowState.Normal;
        }

        private void StartNewCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
