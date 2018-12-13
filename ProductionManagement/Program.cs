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
            Process process = new Process();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow(process));
            if (process.Login != "None" && process.Login != " "
                && process.Login != "")
            {
                MessageBox.Show("Ошибки нет");
                Application.Run(new ProcessWindow());
            }
            else {
                MessageBox.Show("Ошибка!");
                return;
            }

        }
    }
}
