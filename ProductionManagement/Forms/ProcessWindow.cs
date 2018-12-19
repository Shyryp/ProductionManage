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
    public partial class ProcessWindow : Form
    {
        SqlConnection sqlConnection;
        Company company;
        List<Departament> departament = new List<Departament>();
        List<User> workers = new List<User>();
        List<Role> roles = new List<Role>();
        public ProcessWindow()
        {
            InitializeComponent();
        }

        public ProcessWindow(User worker, Company company, Role role)
        {
            InitializeComponent();
            workers.Add(worker);
            this.company = company;
            roles.Add(role);
            if (!roles[0].Access_Creator)
            {
                tabControlForm.TabPages.RemoveByKey("tabPageDepart");
            }
            if (!roles[0].Access_ESalary)
            {
                //скрываем кнопки изменения сотрудников
                bAddUser.Visible = false;
                bChangeUser.Visible = false;
                bDeleteUser.Visible = false;
            }
            if (!roles[0].Access_ERole)
            {
                //скрываем кнопку изменения ролей
                tabControlForm.TabPages.RemoveByKey("tabPageRole");
            }
            if (!roles[0].Access_ETask)
            {
                //убрать кнопки с панели задач
                bCreateTask.Visible = false;
                bChangeTask.Visible = false;
                bDeleteTask.Visible = false;
            }
            if (!roles[0].Access_EUser)
            {
                //удаляем страницу пользователей
                tabControlForm.TabPages.RemoveByKey("tabPageUser");
            }
            
        }

        private async void ProcessWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Text = company.NameCompany;
            this.lNameUser.Text = workers[0].NameUser;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            if (workers[0].IDUser == company.IDUserCreatorCompany)
            {
                
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Departament] WHERE Id_company = @Id_company ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id_company", workers[0].IDCompany);

                try
                {
                    sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    Departament depBuf;

                    while (await sqlDataReader.ReadAsync())
                    {
                        depBuf = new Departament();
                        depBuf.IDCompany = Convert.ToInt32(sqlDataReader["Id_company"]);
                        depBuf.IDDepartament = Convert.ToInt32(sqlDataReader["Id"]);
                        depBuf.IDUser = Convert.ToInt32(sqlDataReader["Id_user"]);
                        depBuf.NameDepartament = Convert.ToString(sqlDataReader["NameDepartament"]);
                        departament.Add(depBuf);
                    }
                    sqlDataReader.Close();
                    lVDepartament.Items.Clear();
                    int i = 0;


                    foreach (Departament dep in departament)
                    {
                        i++;
                        sqlCommand = new SqlCommand("SELECT * FROM [User] WHERE Id = @Id", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("Id", dep.IDUser);
                        sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                        await sqlDataReader.ReadAsync();
                        if (Convert.ToInt32(sqlDataReader["Id"]) == dep.IDUser)
                        {
                            string[] arrDepartament = { i.ToString(),
                        dep.NameDepartament.ToString(), Convert.ToString( sqlDataReader["NameUser"]) };
                            var itemDBDepartament = new ListViewItem(arrDepartament);
                            lVDepartament.Items.Add(itemDBDepartament);
                        }
                        sqlDataReader.Close();
                    }

                    //lVUser.Items.Clear();
                    //string[] arr = { workers[0].IDUser.ToString(), workers[0].NameUser,
                    //workers[0].LoginUser, workers[0].Salary.ToString()};
                    //var itemDBUser = new ListViewItem(arr);
                    //lVUser.Items.Add(itemDBUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //if (sqlDataReader != null)
                    //{
                    //    sqlDataReader.Close();
                    //}
                }
            }
            this.WindowState = FormWindowState.Normal;
        }

        private void bCreateDepart_Click(object sender, EventArgs e)
        {
            AddDepartament addDepartament = new AddDepartament();
            addDepartament.Show();
        }

        private void bChangeDepart_Click(object sender, EventArgs e)
        {
            AddDepartament addDepartament = new AddDepartament();
            addDepartament.Show();
        }

        private void bDeleteDepart_Click(object sender, EventArgs e)
        {

        }

        private void bChangeRoleInDepart_Click(object sender, EventArgs e)
        {

        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void bChangeUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void bDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void bChangeSalary_Click(object sender, EventArgs e)
        {

        }

        private void bCreateTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
        }

        private void bChangeTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
        }

        private void bDeleteTask_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cVisibleBusyTask_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bMoreInfo_Click(object sender, EventArgs e)
        {

        }

        private void bToTakeTask_Click(object sender, EventArgs e)
        {

        }

        private void bBusyTaskFinish_Click(object sender, EventArgs e)
        {

        }

        private void bBusyTaskFail_Click(object sender, EventArgs e)
        {

        }

        private void bMoreInfoBusyTask_Click(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCreateRole_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole();
            addRole.Show();
        }

        private void bChangeRole_Click(object sender, EventArgs e)
        {
            AddRole addRole = new AddRole();
            addRole.Show();
        }

        private void bDeleteRole_Click(object sender, EventArgs e)
        {

        }

        private void lVDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            String textItem = lVDepartament.FocusedItem.SubItems[0].Text;
            Departament dep =  departament[Convert.ToInt32(textItem)-1];
            SqlDataReader sqlDataReader = null;

            //Проверяем, что доступно текущему пользователю
            //Если есть доступ к ролям
            //Загружаем Роли в лист // и отображаем на экран

            //Если есть доступ к редактированию поотображаем на экран

        }

        private void lVRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            String textItem = lVRole.FocusedItem.SubItems[0].Text;
            Role role = roles[Convert.ToInt32(textItem) - 1];
            SqlDataReader sqlDataReader = null;

            //Проверяем, что доступно текущему пользователю
            //Если есть доступ к пользователям
            //Загружаем пользователей в лист // и отображаем на экран

            //Загружаем задачи по текущей роли в лист задач // и отображаем на экране
        }
    }
}
