using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login());

            Application.Run(new DependentForm("user"));
            //Application.Run(new HomeForm("user"));
            //Application.Run(new EmployeeForm("user"));
            //Application.Run(new AllEmployeesForm("user"));
            //Application.Run(new SettingsForm("user"));
            //Application.Run(new SalaryForm("user"));
        }
    }
}
