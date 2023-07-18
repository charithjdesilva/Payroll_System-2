using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class Leave
    {
        public int LeaveID { get; set; }
        public int No_of_days { get; set; }
        public string Name { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public string LeaveType { get; set; }
        public int EmployeeID { get; set; }
    }
}
