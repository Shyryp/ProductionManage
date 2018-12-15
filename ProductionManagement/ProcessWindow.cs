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
        Departament departament;
        User creator;

        public ProcessWindow()
        {
            InitializeComponent();
        }

        public ProcessWindow(User creator)
        {
            InitializeComponent();
            this.creator = creator;
        }

        private async void ProcessWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shyrik\source\repos\ProductionManagement\ProductionManagement\DatabasePM.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            string[] arr = { creator.IDUser.ToString(), creator.NameUser,
            creator.LoginUser, creator.Salary.ToString()};
            var itemDBUser = new ListViewItem(arr);
            lVUser.Items.Add(itemDBUser);




            //SqlDataReader sqlDataReader = null;
            //SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Departament] WHERE Id_company = ", sqlConnection);

            try
            {
                //sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                //string[] arr = { };
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
            this.WindowState = FormWindowState.Normal;
        }

        private void bCreateDepart_Click(object sender, EventArgs e)
        {

        }

        private void bChangeDepart_Click(object sender, EventArgs e)
        {

        }

        private void bDeleteDepart_Click(object sender, EventArgs e)
        {

        }

        private void bChangeRoleInDepart_Click(object sender, EventArgs e)
        {

        }

        private void bAddUser_Click(object sender, EventArgs e)
        {

        }

        private void bChangeUser_Click(object sender, EventArgs e)
        {

        }

        private void bDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void bChangeSalary_Click(object sender, EventArgs e)
        {

        }

        private void bCreateTask_Click(object sender, EventArgs e)
        {

        }

        private void bChangeTask_Click(object sender, EventArgs e)
        {

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

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
