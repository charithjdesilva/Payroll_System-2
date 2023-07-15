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
    public partial class EmployeeForm : Form
    {
        private int employeeId;
        public EmployeeForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            try
            {
                // Generate a unique EmployeeID during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    employeeId = GenerateUniqueEmployeeId(connection);
                    txtEmployeeId.Text = employeeId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                   "Initial Catalog=GrifindoToys;" +
                                  "Integrated Security=SSPI;";

        Employee emp = new Employee();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        void clearValues()
        {
            txtAddress.Text = "";
            txtAllowances.Text = "";
            txtAllowances.Text = "";
            txtEmployeeDobD.Text = "";
            txtEmployeeDobM.Text = "";
            txtEmployeeDobY.Text = "";
            txtEmployeeName.Text = "";
            txtMontlySal.Text = "";
            txtOTRate.Text = "";
            txtPhone.Text = "";
            txtEmployeeId.Enabled = true;

            rbGenderFemale.Checked = false;
            rbGenderMale.Checked = false;

            btnRegister.Visible = true;
            pnlDelUpd.Visible = false;
            btnSearchEmp.Image = Properties.Resources.search;

            try
            {
                // Generate a unique EmployeeID during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    employeeId = GenerateUniqueEmployeeId(connection);
                    txtEmployeeId.Text = employeeId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            // set for searching employee
            if (btnRegister.Visible == true)
            {
                if ((RetrieveEmployee(connectionString, txtEmployeeId.Text)))
                {
                    Console.WriteLine(emp.Id);
                    txtEmployeeId.Text = emp.Id.ToString();
                    txtEmployeeName.Text = emp.Name;
                    txtPhone.Text = emp.Phone;
                    txtAddress.Text = emp.Address;
                    txtEmployeeDobD.Text = emp.Dob.ToString("dd");
                    txtEmployeeDobM.Text = emp.Dob.ToString("MM");
                    txtEmployeeDobY.Text = emp.Dob.ToString("yyyy");
                    txtAllowances.Text = emp.Allowances.ToString("0.00");
                    txtMontlySal.Text = emp.MonthlySalary.ToString("0.00");
                    txtOTRate.Text = emp.Ot_hourly.ToString("0.00");
                    if (emp.Gender == "Male")
                    {
                        rbGenderMale.Checked = true;
                        rbGenderFemale.Checked = false;
                    }
                    else
                    {
                        rbGenderMale.Checked = false;
                        rbGenderFemale.Checked = true;
                    }
                    btnRegister.Visible = false;
                    pnlDelUpd.Visible = true;
                    btnSearchEmp.Image = Properties.Resources.refresh;
                    txtEmployeeId.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Searched Employee not found in the database.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // set for registering employee
            else
            {
                clearValues();
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
                                emp.Id = Convert.ToInt32(reader["EmployeeID"]);
                                emp.Name = (string)reader["Emp_name"];
                                emp.Dob = (DateTime)(reader["Emp_dob"]);
                                emp.Gender = (string)reader["Emp_gender"];
                                emp.Phone = (string)reader["Emp_phone"];
                                emp.Address = (string)reader["Emp_address"];
                                emp.MonthlySalary = Convert.ToDouble(reader["monthlySalary"]);
                                emp.Ot_hourly = Convert.ToDouble(reader["otRates_hourly"]);
                                emp.Allowances = Convert.ToDouble(reader["allowances"]);

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

        // Validation method to check if all input fields are filled
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeDobD.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeDobM.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeDobY.Text) ||
                string.IsNullOrWhiteSpace(txtMontlySal.Text) ||
                string.IsNullOrWhiteSpace(txtOTRate.Text) ||
                string.IsNullOrWhiteSpace(txtAllowances.Text))
            {
                return false; // Validation failed
            }

            return true; // Validation passed
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Retrieve and validate input values
                string employeeId = txtEmployeeId.Text;
                string employeeName = txtEmployeeName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime dob = new DateTime(Convert.ToInt32(txtEmployeeDobY.Text),
                                            Convert.ToInt32(txtEmployeeDobM.Text),
                                            Convert.ToInt32(txtEmployeeDobD.Text));
                double monthlySalary = Convert.ToDouble(txtMontlySal.Text);
                double otHourlyRate = Convert.ToDouble(txtOTRate.Text);
                double allowances = Convert.ToDouble(txtAllowances.Text);
                string gender = rbGenderMale.Checked ? "Male" : "Female";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Employee SET " +
                                       "Emp_name = @Name, " +
                                       "Emp_dob = @Dob, " +
                                       "Emp_gender = @Gender, " +
                                       "Emp_phone = @Phone, " +
                                       "Emp_address = @Address, " +
                                       "monthlySalary = @MonthlySalary, " +
                                       "otRates_hourly = @OtHourlyRate, " +
                                       "allowances = @Allowances " +
                                       "WHERE EmployeeID = @EmployeeId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", employeeName);
                            command.Parameters.AddWithValue("@Dob", dob);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@MonthlySalary", monthlySalary);
                            command.Parameters.AddWithValue("@OtHourlyRate", otHourlyRate);
                            command.Parameters.AddWithValue("@Allowances", allowances);
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Values you inputted for Employee record updated successfully to the database.", "Update Database Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearValues();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Values you inputted for the employee record.", "Update Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Check and Please fill in all the required fields.", "Input Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if all required input fields are filled
            if (ValidateInputs())
            {
                // Retrieve and validate input values
                string employeeName = txtEmployeeName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                DateTime dob = new DateTime(Convert.ToInt32(txtEmployeeDobY.Text),
                                            Convert.ToInt32(txtEmployeeDobM.Text),
                                            Convert.ToInt32(txtEmployeeDobD.Text));
                double monthlySalary = string.IsNullOrWhiteSpace(txtMontlySal.Text) ? 0 : Convert.ToDouble(txtMontlySal.Text);
                double otHourlyRate = string.IsNullOrWhiteSpace(txtOTRate.Text) ? 0 : Convert.ToDouble(txtOTRate.Text);
                double allowances = string.IsNullOrWhiteSpace(txtAllowances.Text) ? 0 : Convert.ToDouble(txtAllowances.Text);
                string gender = rbGenderMale.Checked ? "Male" : "Female";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Generate a unique EmployeeID
                        int employeeId = GenerateUniqueEmployeeId(connection);

                        string query = "INSERT INTO Employee (EmployeeID, Emp_name, Emp_dob, Emp_gender, Emp_phone, Emp_address, monthlySalary, otRates_hourly, allowances) " +
                                       "VALUES (@EmployeeId, @Name, @Dob, @Gender, @Phone, @Address, @MonthlySalary, @OtHourlyRate, @Allowances)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);
                            command.Parameters.AddWithValue("@Name", employeeName);
                            command.Parameters.AddWithValue("@Dob", dob);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@MonthlySalary", monthlySalary);
                            command.Parameters.AddWithValue("@OtHourlyRate", otHourlyRate);
                            command.Parameters.AddWithValue("@Allowances", allowances);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee record inserted successfully.", "Insertion to the Database Successesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearValues();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert employee record.", "Database Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Check and Please fill in all the required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to generate a unique EmployeeID
        private int GenerateUniqueEmployeeId(SqlConnection connection)
        {
            string query = "SELECT MAX(EmployeeID) FROM Employee";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                return maxId + 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeId.Text;

            if (!string.IsNullOrWhiteSpace(employeeId))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee record deleted successfully from the database.", "Record Deletetion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearValues();
                            }
                            else
                            {
                                MessageBox.Show("Sorry, No employee record found with the inputed EmployeeID.", "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Please input an EmployeeID to delete from the Database.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            AllEmployeesForm hf = new AllEmployeesForm(lblName.Text);
            hf.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(lblName.Text);
            this.Hide();
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm(lblName.Text);
            this.Hide();
            frm.Show();
        }
    }
}
