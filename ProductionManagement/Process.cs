using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagement
{
    public class Process
    {
        private string LoginUser = "None";
        public Process()
        {

        }

        public string Login
        {
            get
            {
                return LoginUser;
            }
            set
            {
                LoginUser = value;
            }
        }
    }
}
