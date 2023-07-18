using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class SalaryForm : Form
    {
        Employee empl1 = new Employee();
        private int noOfLeaves;

        public SalaryForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;
            LoadSettings();
        }

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                  "Initial Catalog=GryfindoSystemV2;" +
                                  "Integrated Security=SSPI;";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadSettings()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Settings";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDateRange.Text = reader["dateRange"].ToString();

                                // Parse and split the salCycleBeginDate value
                                DateTime salCycleBeginDate = (DateTime)reader["salCycleBeginDate"];
                                txtSalBeginD.Text = salCycleBeginDate.Day.ToString();
                                txtSalBeginM.Text = salCycleBeginDate.Month.ToString();
                                txtSalBeginY.Text = salCycleBeginDate.Year.ToString();

                                // Parse and split the salCycleEndDate value
                                DateTime salCycleEndDate = (DateTime)reader["salCycleEndDate"];
                                txtSalEndD.Text = salCycleEndDate.Day.ToString();
                                txtSalEndM.Text = salCycleEndDate.Month.ToString();
                                txtSalEndY.Text = salCycleEndDate.Year.ToString();

                                // Read the value of noOfLeaves and store it in the variable
                                noOfLeaves = Convert.ToInt32(reader["noOfLeaves"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        // retrieve employee details
        bool RetrieveEmployee(string connectionString, string employeeId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee WHERE EmployeeID='" + employeeId + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve employee data
                                empl1.Id = Convert.ToInt32(reader["EmployeeID"]);
                                empl1.Name = (string)reader["Emp_name"];
                                empl1.Dob = (DateTime)(reader["Emp_dob"]);
                                empl1.Gender = (string)reader["Emp_gender"];
                                empl1.Phone = (string)reader["Emp_phone"];
                                empl1.Address = (string)reader["Emp_address"];
                                empl1.MonthlySalary = Convert.ToDouble(reader["monthlySalary"]);
                                empl1.Ot_hourly = Convert.ToDouble(reader["otRates_hourly"]);
                                empl1.Allowances = Convert.ToDouble(reader["allowances"]);

                                return true;
                            }
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void CalculateSalary()
        {
            // Get the user inputs from the text boxes
            int salaryBeginDay;
            if (!int.TryParse(txtSalBeginD.Text, out salaryBeginDay))
            {
                MessageBox.Show("Invalid salary cycle begin day. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int salaryBeginMonth;
            if (!int.TryParse(txtSalBeginM.Text, out salaryBeginMonth))
            {
                MessageBox.Show("Invalid salary cycle begin month. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int salaryBeginYear;
            if (!int.TryParse(txtSalBeginY.Text, out salaryBeginYear))
            {
                MessageBox.Show("Invalid salary cycle begin year. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int salaryEndDay;
            if (!int.TryParse(txtSalEndD.Text, out salaryEndDay))
            {
                MessageBox.Show("Invalid salary cycle end day. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int salaryEndMonth;
            if (!int.TryParse(txtSalEndM.Text, out salaryEndMonth))
            {
                MessageBox.Show("Invalid salary cycle end month. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int salaryEndYear;
            if (!int.TryParse(txtSalEndY.Text, out salaryEndYear))
            {
                MessageBox.Show("Invalid salary cycle end year. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numberOfAbsentDays;
            if (!int.TryParse(txtNoOfAbsents.Text, out numberOfAbsentDays))
            {
                MessageBox.Show("Invalid number of absent days. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numberOfHolidays;
            if (!int.TryParse(txtHolidays.Text, out numberOfHolidays))
            {
                MessageBox.Show("Invalid number of holidays. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double otHours;
            if (!double.TryParse(txtOTHours.Text, out otHours))
            {
                MessageBox.Show("Invalid OT hours. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double govtTaxRate;
            if (!double.TryParse(txtGovtRate.Text, out govtTaxRate))
            {
                MessageBox.Show("Invalid government tax rate. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double monthlySalary = empl1.MonthlySalary;
            double allowances = empl1.Allowances;
            double otRate = empl1.Ot_hourly;

            // Calculate the salary cycle duration
            DateTime salaryBeginDate;
            try
            {
                salaryBeginDate = new DateTime(salaryBeginYear, salaryBeginMonth, salaryBeginDay);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid salary cycle begin date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime salaryEndDate;
            try
            {
                salaryEndDate = new DateTime(salaryEndYear, salaryEndMonth, salaryEndDay);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid salary cycle end date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan salaryCycleDuration = salaryEndDate - salaryBeginDate;
            int salaryCycleDateRange = salaryCycleDuration.Days + 1;

            // Calculate the total number of working days within the salary cycle date range
            int totalWorkingDays = CalculateTotalWorkingDays(salaryBeginDate, salaryEndDate);

            // Calculate the total number of leaves taken by the employee within the salary cycle date range
            int totalAbsentDays = CalculateTotalAbsentDaysForEmployee(empl1.Id, salaryBeginDate, salaryEndDate);

            // Calculate the no-pay value, considering the allowed absent days (noOfLeaves)
            int noPayDays = Math.Max(totalAbsentDays - noOfLeaves, 0);
            // Calculate the no-pay value
            double noPayValue = (monthlySalary / totalWorkingDays) * totalAbsentDays;

            Console.WriteLine($"totalAbsentDays: {totalAbsentDays}");
            Console.WriteLine($"noOfLeaves: {noOfLeaves}");
            Console.WriteLine($"monthlySalary: {monthlySalary}");
            Console.WriteLine($"totalWorkingDays: {totalWorkingDays}");
            Console.WriteLine($"noPayDays: {noPayDays}");
            Console.WriteLine($"noPayValue: {noPayValue}");

            // Calculate the base pay value
            double basePayValue = monthlySalary + allowances + (otRate * otHours);

            // Calculate the gross pay value
            double grossPayValue = basePayValue - (noPayValue + (basePayValue * govtTaxRate));


            //Console.WriteLine(noPayValue);
            // Display the calculated values in the result text boxes
            txtResultNoPay.Text = noPayValue.ToString("#.##");
            txtResultBasePay.Text = basePayValue.ToString("#.##");
            txtResultGrossPay.Text = grossPayValue.ToString("#.##");
        }


        bool search = false;

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (search)
            {
                btnSearchEmp.Image = Properties.Resources.search;
                btnCalculate.Visible = false;
                search = false;
                txtEmployeeId.Enabled = true;
                clearValues();

                // enable date input fields to the user
                txtSalBeginD.Enabled = true;
                txtSalBeginM.Enabled = true;
                txtSalBeginY.Enabled = true;

                txtSalEndD.Enabled = true;
                txtSalEndM.Enabled = true;
                txtSalEndY.Enabled = true;
            }
            else
            {
                if ((RetrieveEmployee(connectionString, txtEmployeeId.Text)))
                {
                    Console.WriteLine(empl1.Id);
                    txtEmployeeId.Text = empl1.Id.ToString();
                    btnCalculate.Visible = true;
                    btnSearchEmp.Image = Properties.Resources.refresh;
                    txtEmployeeId.Enabled = false;


                    // disable date input fields to the user
                    txtSalBeginD.Enabled = false;
                    txtSalBeginM.Enabled = false;
                    txtSalBeginY.Enabled = false;

                    txtSalEndD.Enabled = false;
                    txtSalEndM.Enabled = false;
                    txtSalEndY.Enabled = false;

                    // salaryBeginDate, salaryEndDate
                    DateTime salaryBeginDate;
                    try
                    {
                        salaryBeginDate = new DateTime(Convert.ToInt32(txtSalBeginY.Text), Convert.ToInt32(txtSalBeginM.Text), Convert.ToInt32(txtSalBeginD.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid salary cycle begin date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DateTime salaryEndDate;
                    try
                    {
                        salaryEndDate = new DateTime(Convert.ToInt32(txtSalEndY.Text), Convert.ToInt32(txtSalEndM.Text), Convert.ToInt32(txtSalEndD.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid salary cycle end date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    txtNoOfAbsents.Text = CalculateTotalAbsentDaysForEmployee(Convert.ToInt32(txtEmployeeId.Text), salaryBeginDate, salaryEndDate).ToString();
                    txtHolidays.Text = (CalculateTotalHolidays(salaryBeginDate, salaryEndDate)).ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found in the Database.", "Search Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                search = true; // Update the search variable after performing the search
            }
        }

        void clearValues()
        {
            empl1.Allowances = 0;
            empl1.Ot_hourly = 0;
            empl1.MonthlySalary = 0;
            empl1.Id = 0;
            txtEmployeeId.Enabled = true;
            txtNoOfAbsents.Text = "";
            txtHolidays.Text = "";

            btnCalculate.Visible = false;
            btnInsertToDB.Visible = false;
            btnSearchEmp.Image = Properties.Resources.search;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateSalary();
                btnInsertToDB.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during salary calculation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertToDB_Click(object sender, EventArgs e)
        {
            InsertSalaryRecord();
        }

        private void InsertSalaryRecord()
        {
            // Get the input values from the text boxes
            int employeeId;
            if (!int.TryParse(txtEmployeeId.Text, out employeeId))
            {
                MessageBox.Show("Invalid employee ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal basePay;
            if (!decimal.TryParse(txtResultBasePay.Text, out basePay))
            {
                MessageBox.Show("Invalid base pay value. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal noPay;
            if (!decimal.TryParse(txtResultNoPay.Text, out noPay))
            {
                MessageBox.Show("Invalid no-pay value. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal grossPay;
            if (!decimal.TryParse(txtResultGrossPay.Text, out grossPay))
            {
                MessageBox.Show("Invalid gross pay value. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the SQL insert query
                    string query = "INSERT INTO Salary (EmployeeID, BasePay, NoPay, GrossPay) VALUES (@EmployeeID, @BasePay, @NoPay, @GrossPay)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@BasePay", basePay);
                        command.Parameters.AddWithValue("@NoPay", noPay);
                        command.Parameters.AddWithValue("@GrossPay", grossPay);

                        // Execute the insert query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Salary record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting the salary record. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextFields()
        {
            txtEmployeeId.Text = string.Empty;
            txtResultNoPay.Text = string.Empty;
            txtResultBasePay.Text = string.Empty;
            txtResultGrossPay.Text = string.Empty;
            btnCalculate.Visible = false;
            btnInsertToDB.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm(lblName.Text);
            this.Hide();
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(lblName.Text);
            this.Hide();
            frm.Show();
        }

        private int CalculateTotalWorkingDays(DateTime startDate, DateTime endDate)
        {
            int totalWorkingDays = 0;

            // Create a list to store holiday dates
            List<DateTime> holidays = new List<DateTime>();

            try
            {
                // Retrieve holidays from the "Holiday" table and add them to the list
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT HolidayStartDate, No_of_days FROM Holiday";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime holidayStartDate = (DateTime)reader["HolidayStartDate"];
                                int noOfDays = (int)reader["No_of_days"];
                                for (int i = 0; i < noOfDays; i++)
                                {
                                    holidays.Add(holidayStartDate.AddDays(i));
                                }
                            }
                        }
                    }
                }

                // Calculate the total working days between startDate and endDate (inclusive)
                for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
                {
                    if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(currentDate))
                    {
                        totalWorkingDays++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return totalWorkingDays;
        }

        private int CalculateTotalAbsentDaysForEmployee(int employeeID, DateTime startDate, DateTime endDate)
        {
            int totalAbsentDays = 0;

            try
            {
                // Retrieve leaves from the "Leave" table for the specified employee and date range
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT LeaveStartDate, No_of_days FROM Leave WHERE EmployeeID=@EmployeeID AND LeaveStartDate BETWEEN @StartDate AND @EndDate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime leaveStartDate = (DateTime)reader["LeaveStartDate"];
                                int noOfDays = (int)reader["No_of_days"];
                                totalAbsentDays += noOfDays;
                            }
                        }
                    }
                }
                txtNoOfAbsents.Text = totalAbsentDays.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return totalAbsentDays;
        }

        private int CalculateTotalHolidays(DateTime startDate, DateTime endDate)
        {
            int totalHolidays = 0;

            // Create a list to store holiday dates
            List<DateTime> holidays = new List<DateTime>();

            try
            {
                // Retrieve holidays from the "Holiday" table and add them to the list
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT HolidayStartDate, No_of_days FROM Holiday";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime holidayStartDate = (DateTime)reader["HolidayStartDate"];
                                int noOfDays = (int)reader["No_of_days"];
                                for (int i = 0; i < noOfDays; i++)
                                {
                                    holidays.Add(holidayStartDate.AddDays(i));
                                }
                            }
                        }
                    }
                }

                // Calculate the total holidays between startDate and endDate (inclusive)
                for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
                {
                    if (holidays.Contains(currentDate))
                    {
                        totalHolidays++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return totalHolidays;
        }

    }
}
