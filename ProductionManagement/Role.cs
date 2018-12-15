using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagement
{
    
    class Role
    {
        public int IDRole { get; set; } = 0;
        public string NameRole { get; set; } = "None";
        public bool Access_EUser { get; set; } = false;
        public bool Access_ETask { get; set; } = false;
        public bool Access_ESalary { get; set; } = false;
        public bool Access_Creator { get; set; } = false;
        public int IDCompany { get; set; } = 0;
        public int Salary { get; set; } = 0;
        public int IDDepartament { get; set; } = 0;

    }
}
