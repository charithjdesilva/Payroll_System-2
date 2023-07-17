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

                                //txtNoOfLeaves.Text = reader["noOfLeaves"].ToString();
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

        // retreive employee details
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
            int date_range = int.Parse(txtDateRange.Text);
            int salery_begin_day = int.Parse(txtSalBeginD.Text);
            int salery_begin_month = int.Parse(txtSalBeginM.Text);
            int salery_begin_year = int.Parse(txtSalBeginY.Text);
            int salary_end_day = int.Parse(txtSalEndD.Text);
            int salary_end_month = int.Parse(txtSalEndM.Text);
            int salary_end_year = int.Parse(txtSalEndY.Text);
            int number_of_absent_days = int.Parse(txtNoOfAbsents.Text);
            int number_of_holidays = int.Parse(txtHolidays.Text);
            double ot_hours = double.Parse(txtOTHours.Text);
            double gvt_tax_rate = double.Parse(txtGovtRate.Text);
            double month_salary = empl1.MonthlySalary;
            double allowances = empl1.Allowances;
            double ot_rate = empl1.Ot_hourly;

            // Calculate the salary cycle duration
            DateTime salBeginDate = new DateTime(salery_begin_year, salery_begin_month, salery_begin_day);
            DateTime salEndDate = new DateTime(salary_end_year, salary_end_month, salary_end_day);
            TimeSpan salary_cycle_duration = salEndDate - salBeginDate;
            int salary_cycle_date_range = salary_cycle_duration.Days + 1;

            // Validate the entered salary cycle dates
            if (salary_cycle_date_range != date_range)
            {
                MessageBox.Show("Error in salary cycle dates when comparing differences of the dates and the date range. Please enter valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the no-pay value
            double no_pay_value = (month_salary / salary_cycle_date_range) * number_of_absent_days;

            // Calculate the base pay value
            double base_pay_value = month_salary + allowances + (ot_rate * ot_hours);

            // Calculate the gross pay value
            double gross_pay_value = base_pay_value - (no_pay_value + (base_pay_value * gvt_tax_rate));

            // Display the calculated values in the result text boxes
            txtResultNoPay.Text = no_pay_value.ToString("#.##");
            txtResultBasePay.Text = base_pay_value.ToString("#.##");
            txtResultGrossPay.Text = gross_pay_value.ToString("#.##");
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
                Console.WriteLine(ex);
                throw;
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
    }
}
