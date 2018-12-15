using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagement
{
    public class User
    {
        public int IDUser { get; set; } = 0;
        public string NameUser { get; set; } = "None";
        public string LoginUser { get; set; } = "None";
        public string Password { get; set; } = "None";
        public int IDRole { get; set; } = 0;
        public int IDCompany { get; set; } = 0;
        public string SecretQeustion { get; set; } = "None";
        public string SecretAnswer { get; set; } = "None";
        public int Salary { get; set; } = 0;
        public User()
        {

        }

        
    }
}
