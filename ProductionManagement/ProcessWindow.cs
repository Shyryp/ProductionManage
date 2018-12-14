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
    public partial class ProcessWindow : Form
    {
        public ProcessWindow()
        {
            InitializeComponent();
        }

        private void ProcessWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasePMDataSet.Departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.databasePMDataSet.Departament);

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

        }
    }
}
