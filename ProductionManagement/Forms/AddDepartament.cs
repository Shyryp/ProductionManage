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
    public partial class AddDepartament : Form
    {
        public AddDepartament()
        {
            InitializeComponent();
        }

        private void bSaveNameDep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
