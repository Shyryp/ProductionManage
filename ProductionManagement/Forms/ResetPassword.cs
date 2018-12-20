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
    public partial class ResetPassword : Form
    {
        private SqlConnection sqlConnection;
        private StartWindow startwin;
        private int step = 0;
        public ResetPassword()
        {
            InitializeComponent();
        }

        public ResetPassword(StartWindow startwind,string Login)
        {
            InitializeComponent();
            this.tbLogin.Text = Login;
            this.startwin = startwind;
            startwind.Visible = false;
        }

        private async void bEnter_Click(object sender, EventArgs e)
        {
            if (step == 0)
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User]", sqlConnection);

                try
                {
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                    while (await sqlDataReader.ReadAsync())
                    {
                        if (Convert.ToString(sqlDataReader["Login"]) == tbLogin.Text)
                        {
                            tbQeustion.Enabled = true;
                            tbNewPassword.Enabled = true;
                            lQeustion.Text = Convert.ToString(sqlDataReader["SecretQeustion"]);
                            lQeustion.Visible = true;
                            label3.Enabled = true;
                            label2.Enabled = true;
                            step++;
                            sqlDataReader.Close();
                            return;
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
            else if (step == 1)
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [User]", sqlConnection);

                try
                {
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                    while (await sqlDataReader.ReadAsync())
                    {
                        if (Convert.ToString(sqlDataReader["Login"]) == tbLogin.Text)
                        {
                            
                            if (Convert.ToString(sqlDataReader["SecretAnswer"]) == tbQeustion.Text)
                            {
                                if (!string.IsNullOrEmpty(tbNewPassword.Text) &&
                                    !string.IsNullOrWhiteSpace(tbNewPassword.Text))
                                {
                                    int i = Convert.ToInt32( sqlDataReader["Id"]);
                                    sqlDataReader.Close();
                                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
                                    SqlConnection sqlConnection2 = new SqlConnection(connectionString);
                                    await sqlConnection2.OpenAsync();

                                    SqlCommand sqlCommand2 = new SqlCommand("UPDATE [User] SET [Password]=@Password WHERE [Id]=@Id", sqlConnection2);
                                    sqlCommand2.Parameters.AddWithValue("Id", i);
                                    sqlCommand2.Parameters.AddWithValue("Password", tbNewPassword.Text);
                                    await sqlCommand2.ExecuteNonQueryAsync();
                                    if (sqlConnection2 != null && sqlConnection2.State != ConnectionState.Closed)
                                    {
                                        sqlConnection2.Close();
                                    }
                                    MessageBox.Show("Пароль успешно изменён!");
                                    
                                    
                                    this.Close();
                                    return;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Неверный ответ!");
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
                    if (!sqlDataReader.IsClosed)
                    {
                        sqlDataReader.Close();
                    }
                }
                MessageBox.Show("Вы ввели неверный логин \r\n или не ввели новый пароль!");
            }
        }

        private async void ResetPassword_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            startwin.Visible = true;
        }
    }
}
