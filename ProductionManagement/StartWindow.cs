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
        User creator;
        public StartWindow()
        {
            InitializeComponent();
        }

        public StartWindow(User creator)
        {
            InitializeComponent();
            this.creator = creator;
        }

        private async void bEnter_Click(object sender, EventArgs e)
        {

            //Проверка логина и пароля по базе
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User]", sqlConnection);

            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                while (await sqlDataReader.ReadAsync())
                {
                    if (Convert.ToString(sqlDataReader["Login"]) == tbLogin.Text)
                    {
                        if (Convert.ToString(sqlDataReader["Password"]) == tbPassword.Text)
                        {
                            creator.IDUser = Convert.ToInt32(sqlDataReader["Id"]);
                            creator.NameUser = Convert.ToString(sqlDataReader["NameUser"]);
                            creator.LoginUser = Convert.ToString(sqlDataReader["Login"]);
                            creator.Password = Convert.ToString(sqlDataReader["Password"]);
                            creator.IDRole = Convert.ToInt32(sqlDataReader["id_role"]);
                            creator.IDCompany = Convert.ToInt32(sqlDataReader["id_company"]);
                            creator.SecretQeustion = Convert.ToString(sqlDataReader["SecretQeustion"]);
                            creator.SecretAnswer = Convert.ToString(sqlDataReader["SecretAnswer"]);
                            creator.Salary = Convert.ToInt32(sqlDataReader["Salary"]);
                            this.Close();
                        }
                        else {
                            MessageBox.Show("Не верный пароль!");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
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
