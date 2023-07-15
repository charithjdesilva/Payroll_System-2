using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Employee
    {
        int id;
        string name;
        DateTime dob;
        string gender;
        string phone;
        string address;
        double monthlySalary;
        double ot_hourly;
        double allowances;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public double MonthlySalary
        {
            get
            {
                return monthlySalary;
            }

            set
            {
                monthlySalary = value;
            }
        }

        public double Ot_hourly
        {
            get
            {
                return ot_hourly;
            }

            set
            {
                ot_hourly = value;
            }
        }

        public double Allowances
        {
            get
            {
                return allowances;
            }

            set
            {
                allowances = value;
            }
        }
    }
}
