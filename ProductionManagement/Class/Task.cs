using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagement
{
    public class Task
    {
        public int IDTask { get; set; } = 0;
        public string NameTask { get; set; } = "None";
        public string Deadline { get; set; } = "None";
        public int Cost { get; set; } = 0;
        public string Description { get; set; } = "None";
        public int IDUserCreator { get; set; } = 0;
        public int IDUserWorker { get; set; } = 0;
        public int IDCompany { get; set; } = 0;

    }
}
