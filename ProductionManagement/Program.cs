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
            User creator = new User();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow(creator));
            if (creator.LoginUser != "None" && creator.LoginUser != " "
                && creator.LoginUser != "")
            {
                //MessageBox.Show("Ошибки нет");
                Application.Run(new ProcessWindow(creator));
            }
            else {
                //MessageBox.Show("Ошибка!");
                return;
            }

        }
    }
}
