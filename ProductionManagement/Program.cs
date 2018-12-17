using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionManagement
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User worker = new User();
            Company company = new Company();
            Role role = new Role();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow(worker, company, role));
            if (worker.LoginUser != "None" && worker.LoginUser != " "
                && worker.LoginUser != "")
            {
                if (company.NameCompany == "None")
                {
                    Application.Run(new StartNewCompany(company));
                }

                if (!(company.NameCompany == "None"))
                {
                    Application.Run(new ProcessWindow(worker, company, role));
                }
            }
        }
    }
}
