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
    public partial class RegistrationWindow : Form
    {
        SqlConnection sqlConnection;
        StartWindow startWindow;
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        public RegistrationWindow(StartWindow startWind)
        {
            InitializeComponent();
            this.startWindow = startWind;
        }

        private async void bEnterReg_Click(object sender, EventArgs e)
        {
            //Обработка регистрации
            SqlDataReader sqlDataReader = null;

            if (!string.IsNullOrEmpty(tbNewLogin.Text) && !string.IsNullOrWhiteSpace(tbNewLogin.Text) &&
                !string.IsNullOrEmpty(tbNewName.Text) && !string.IsNullOrWhiteSpace(tbNewName.Text) &&
                    !string.IsNullOrEmpty(tbNewPassword.Text) && !string.IsNullOrWhiteSpace(tbNewPassword.Text)
                    && !string.IsNullOrEmpty(tbConfirmPassword.Text) && !string.IsNullOrWhiteSpace(tbConfirmPassword.Text)
                    && !string.IsNullOrEmpty(tbNewSecretQeustion.Text) && !string.IsNullOrWhiteSpace(tbNewSecretQeustion.Text)
                    && !string.IsNullOrEmpty(tbNewSecretAnswer.Text) && !string.IsNullOrWhiteSpace(tbNewSecretAnswer.Text)
                    && (tbNewPassword.Text == tbConfirmPassword.Text))
            {
                SqlCommand sqlCommandSelect = new SqlCommand("SELECT COUNT(*) FROM [User]", sqlConnection);
                Int32 numUserCreator = (Int32)sqlCommandSelect.ExecuteScalar();
                numUserCreator++;
                SqlCommand sqlCommandInsert =
                    new SqlCommand("INSERT INTO [Company] (NameCompany,Id_user_creator_company)VALUES(@NameCompany,@Id_user_creator_company)",
                    sqlConnection);

                sqlCommandInsert.Parameters.AddWithValue("NameCompany", "None");
                sqlCommandInsert.Parameters.AddWithValue("Id_user_creator_company", numUserCreator);
                await sqlCommandInsert.ExecuteNonQueryAsync();

                sqlCommandSelect = new SqlCommand("SELECT COUNT(*) FROM Company", sqlConnection);
                Int32 count = (Int32)sqlCommandSelect.ExecuteScalar();

                sqlCommandInsert =
                    new SqlCommand("INSERT INTO [Role] (NameRole,Access_EUser,Access_ETask,Access_ESalary,Access_Creator,Id_company,Salary)VALUES(@NameRole,@Access_EUser,@Access_ETask,@Access_ESalary,@Access_Creator,@Id_company,@Salary)",
                    sqlConnection);
                sqlCommandInsert.Parameters.AddWithValue("NameRole", "Создатель");
                sqlCommandInsert.Parameters.AddWithValue("Access_EUser", true);
                sqlCommandInsert.Parameters.AddWithValue("Access_ETask", true);
                sqlCommandInsert.Parameters.AddWithValue("Access_ESalary", true);
                sqlCommandInsert.Parameters.AddWithValue("Access_Creator", true);
                sqlCommandInsert.Parameters.AddWithValue("Id_company", count);
                sqlCommandInsert.Parameters.AddWithValue("Salary", 0);
                await sqlCommandInsert.ExecuteNonQueryAsync();

                sqlCommandSelect = new SqlCommand("SELECT COUNT(*) FROM Role", sqlConnection);
                Int32 countRole = (Int32)sqlCommandSelect.ExecuteScalar();

                sqlCommandInsert = 
                    new SqlCommand("INSERT INTO [User] (NameUser,Login,Password,id_role,id_company,SecretQeustion,SecretAnswer)VALUES(@NameUser,@Login,@Password,@id_role,@id_company,@SecretQeustion,@SecretAnswer)", 
                    sqlConnection);
                sqlCommandInsert.Parameters.AddWithValue("NameUser", tbNewName.Text);
                sqlCommandInsert.Parameters.AddWithValue("Login", tbNewLogin.Text);
                sqlCommandInsert.Parameters.AddWithValue("Password", tbNewPassword.Text);
                sqlCommandInsert.Parameters.AddWithValue("id_role", countRole);
                sqlCommandInsert.Parameters.AddWithValue("id_company", count);
                sqlCommandInsert.Parameters.AddWithValue("SecretQeustion", tbNewSecretQeustion.Text);
                sqlCommandInsert.Parameters.AddWithValue("SecretAnswer", tbNewSecretAnswer.Text);
                await sqlCommandInsert.ExecuteNonQueryAsync();

                startWindow.Visible = true;
                this.Close();
            }
            else {
                MessageBox.Show("Не все поля заполнены или пароли не совпадают!");

            }
        }

        private async void RegistrationWindow_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        private void RegistrationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            startWindow.Visible = true;
        }
    }
}
