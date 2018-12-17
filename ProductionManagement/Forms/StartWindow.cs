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
        User worker;
        Role role;
        Company company;
        public StartWindow()
        {
            InitializeComponent();
        }

        public StartWindow(User worker, Company company, Role role)
        {
            InitializeComponent();
            this.worker = worker;
            this.company = company;
            this.role = role;
        }

        private async void bEnter_Click(object sender, EventArgs e)
        {

            //Проверка логина и пароля по базе
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE [Login]=@Login", sqlConnection);

            sqlCommand.Parameters.AddWithValue("Login", tbLogin.Text);

            sqlDataReader = await sqlCommand.ExecuteReaderAsync();
            await sqlDataReader.ReadAsync();
            if (!sqlDataReader.IsClosed && sqlDataReader != null)
            {
                try
                {
                    if (Convert.ToString(sqlDataReader["Login"]) == tbLogin.Text)
                    {
                        if (Convert.ToString(sqlDataReader["Password"]) == tbPassword.Text)
                        {
                            worker.IDUser = Convert.ToInt32(sqlDataReader["Id"]);
                            worker.NameUser = Convert.ToString(sqlDataReader["NameUser"]);
                            worker.LoginUser = Convert.ToString(sqlDataReader["Login"]);
                            worker.Password = Convert.ToString(sqlDataReader["Password"]);
                            worker.IDRole = Convert.ToInt32(sqlDataReader["id_role"]);
                            worker.IDCompany = Convert.ToInt32(sqlDataReader["id_company"]);
                            worker.SecretQeustion = Convert.ToString(sqlDataReader["SecretQeustion"]);
                            worker.SecretAnswer = Convert.ToString(sqlDataReader["SecretAnswer"]);
                            worker.Salary = Convert.ToInt32(sqlDataReader["Salary"]);
                            company.IDCompany = Convert.ToInt32(sqlDataReader["id_company"]);
                            sqlDataReader.Close();

                            sqlCommand = new SqlCommand("SELECT * FROM [Role] WHERE [Id]=@Id", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("Id", worker.IDRole);
                            sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                            await sqlDataReader.ReadAsync();
                            role.IDRole = Convert.ToInt32(sqlDataReader["Id"]);
                            role.NameRole = Convert.ToString(sqlDataReader["NameRole"]);
                            role.Access_EUser = Convert.ToBoolean(sqlDataReader["Access_EUser"]);
                            role.Access_ETask = Convert.ToBoolean(sqlDataReader["Access_ETask"]);
                            role.Access_ERole = Convert.ToBoolean(sqlDataReader["Access_ERole"]);
                            role.Access_Creator = Convert.ToBoolean(sqlDataReader["Access_Creator"]);
                            role.IDCompany = Convert.ToInt32(sqlDataReader["Id_company"]);
                            role.IDDepartament = Convert.ToInt32(sqlDataReader["Id_departament"]);
                            role.Access_ESalary = Convert.ToBoolean(sqlDataReader["Access_ESalary"]);
                            sqlDataReader.Close();

                            sqlCommand = null;
                            sqlCommand = new SqlCommand("SELECT * FROM [Company] WHERE [Id]=@id", sqlConnection);
                            sqlCommand.Parameters.AddWithValue("Id", company.IDCompany);
                            sqlDataReader = null;
                            sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                            await sqlDataReader.ReadAsync();
                            company.NameCompany = Convert.ToString(sqlDataReader["NameCompany"]);
                            company.IDUserCreatorCompany = Convert.ToInt32(sqlDataReader["Id_user_creator_company"]);
                            sqlDataReader.Close();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль!");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {                }
            }
            if (sqlDataReader != null)
            {
                sqlDataReader.Close();
            }
       
            MessageBox.Show("Логин не найден!");

        }

        private void lErrorPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword(this,tbLogin.Text);
            resetPassword.Show();
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

        private void bRegestration_Click(object sender, EventArgs e)
        {
            RegistrationWindow regWindow = new RegistrationWindow(this);
            this.Visible = false;
            regWindow.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommandDelete = new SqlCommand("TRUNCATE TABLE [Company]", sqlConnection);
            await sqlCommandDelete.ExecuteNonQueryAsync();
            sqlCommandDelete = new SqlCommand("TRUNCATE TABLE [Departament]", sqlConnection);
            await sqlCommandDelete.ExecuteNonQueryAsync();
            sqlCommandDelete = new SqlCommand("TRUNCATE TABLE [Role]", sqlConnection);
            await sqlCommandDelete.ExecuteNonQueryAsync();
            sqlCommandDelete = new SqlCommand("TRUNCATE TABLE [Task]", sqlConnection);
            await sqlCommandDelete.ExecuteNonQueryAsync();
            sqlCommandDelete = new SqlCommand("TRUNCATE TABLE [User]", sqlConnection);
            await sqlCommandDelete.ExecuteNonQueryAsync();

        }
    }
}
