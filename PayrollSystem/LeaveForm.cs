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
    public partial class LeaveForm : Form
    {
        private int leaveID;
        private SqlConnection connection;

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                           "Initial Catalog=GryfindoSystemV2;" +
                                           "Integrated Security=SSPI;";

        public LeaveForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                leaveID = GenerateUniqueLeaveId(connection);
                txtLeaveId.Text = leaveID.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw; // Rethrow the exception to be handled by the caller
            }
        }

        Employee emp = new Employee();
        Leave leave = new Leave();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        void clearValues()
        {
            txtLeaveDateD.Text = "";
            txtLeaveDateM.Text = "";
            txtLeaveDateY.Text = "";
            txtLeaveName.Text = "";
            txtNoOfDays.Text = "";
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtLeaveId.Enabled = true;
            txtEmployeeId.Enabled = true;
            txtEmployeeName.Enabled = true;
            btnSearchEmp.Visible = true;
            btnSearchEmp.Image = Properties.Resources.search;
            cmbLeaveType.SelectedIndex = 0;

            btnRegister.Visible = true;
            pnlDelUpd.Visible = false;
            btnSearchDepenedent.Image = Properties.Resources.search;
            btnRegister.Enabled = false;

            try
            {
                leaveID = GenerateUniqueLeaveId(connection);
                txtLeaveId.Text = leaveID.ToString();
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
                if (int.TryParse(txtLeaveId.Text, out leaveID))
                {
                    if (RetrieveLeave(connectionString, leaveID))
                    {
                        Console.WriteLine(leave.LeaveID);
                        txtLeaveId.Text = leave.LeaveID.ToString();
                        txtLeaveName.Text = leave.Name;
                        txtNoOfDays.Text = leave.No_of_days.ToString();
                        txtEmployeeId.Text = leave.EmployeeID.ToString();
                        cmbLeaveType.Text = leave.LeaveType.ToString();

                        RetrieveEmployee(connectionString, leave.EmployeeID.ToString());

                        txtEmployeeName.Text = emp.Name;

                        txtLeaveDateD.Text = leave.LeaveStartDate.ToString("dd");
                        txtLeaveDateM.Text = leave.LeaveStartDate.ToString("MM");
                        txtLeaveDateY.Text = leave.LeaveStartDate.ToString("yyyy");

                        btnRegister.Visible = false;
                        pnlDelUpd.Visible = true;
                        btnSearchEmp.Image = Properties.Resources.refresh;
                        txtLeaveId.Enabled = false;
                        txtEmployeeId.Enabled = false;
                        txtEmployeeName.Enabled = false;
                        btnSearchEmp.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Searched Leave not found in the database.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Leave ID. Please enter a valid Leave ID.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                clearValues();
            }
        }

        // Retrieve leave details
        bool RetrieveLeave(string connectionString, int leaveID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Leave WHERE LeaveID = @LeaveID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveID", leaveID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve leave data
                                leave.LeaveID = Convert.ToInt32(reader["LeaveID"]);
                                leave.No_of_days = Convert.ToInt32(reader["No_of_days"]);
                                leave.Name = (string)reader["Name"];
                                leave.LeaveStartDate = (DateTime)(reader["LeaveStartDate"]);
                                leave.LeaveType = (string)reader["LeaveType"];
                                leave.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                                connection.Close();
                                return true;
                            }
                            connection.Close();
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


        // Retrieve employee details
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
            if (string.IsNullOrWhiteSpace(txtLeaveId.Text) ||
                string.IsNullOrWhiteSpace(txtLeaveName.Text) ||
                string.IsNullOrWhiteSpace(txtNoOfDays.Text) ||
                string.IsNullOrWhiteSpace(txtLeaveDateD.Text) ||
                string.IsNullOrWhiteSpace(txtLeaveDateM.Text) ||
                string.IsNullOrWhiteSpace(txtLeaveDateY.Text))
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
                int leaveID = Convert.ToInt32(txtLeaveId.Text);
                int noOfDays = Convert.ToInt32(txtNoOfDays.Text);
                string name = txtLeaveName.Text;
                DateTime leaveStartDate = new DateTime(Convert.ToInt32(txtLeaveDateY.Text),
                                                        Convert.ToInt32(txtLeaveDateM.Text),
                                                        Convert.ToInt32(txtLeaveDateD.Text));
                string leaveType = cmbLeaveType.Text;
                int employeeID = Convert.ToInt32(txtEmployeeId.Text);

                if (string.IsNullOrEmpty(leaveType))
                {
                    MessageBox.Show("Please select a valid Leave Type.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the existing Leave record
                UpdateLeave(leaveID, noOfDays, name, leaveStartDate, leaveType, employeeID);
            }
            else
            {
                MessageBox.Show("Check and Please fill in all the required fields.", "Input Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                // Retrieve and validate input values
                int leaveID = Convert.ToInt32(txtLeaveId.Text);
                int noOfDays = Convert.ToInt32(txtNoOfDays.Text);
                string name = txtLeaveName.Text;
                DateTime leaveStartDate = new DateTime(Convert.ToInt32(txtLeaveDateY.Text),
                                                        Convert.ToInt32(txtLeaveDateM.Text),
                                                        Convert.ToInt32(txtLeaveDateD.Text));
                string leaveType = cmbLeaveType.Text;
                int employeeID = Convert.ToInt32(txtEmployeeId.Text);

                if (string.IsNullOrEmpty(leaveType))
                {
                    MessageBox.Show("Please select a valid Leave Type.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert the new Leave record
                InsertLeave(leaveID, noOfDays, name, leaveStartDate, leaveType, employeeID);
            }
            else
            {
                MessageBox.Show("Check and Please fill in all the required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to generate a unique LeaveID
        private int GenerateUniqueLeaveId(SqlConnection connection)
        {
            string query = "SELECT MAX(LeaveID) FROM Leave";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                return maxId + 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int leaveID = Convert.ToInt32(txtLeaveId.Text);
            int employeeID = Convert.ToInt32(txtEmployeeId.Text);

            // Delete the Leave record
            DeleteLeave(leaveID, employeeID);
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

        bool search = false;

        private void btnSearchEmp_Click_1(object sender, EventArgs e)
        {
            if (search)
            {
                btnSearchEmp.Image = Properties.Resources.search;
                search = false;
                txtEmployeeId.Enabled = true;
                txtEmployeeId.Text = "";
                txtEmployeeName.Text = "";
                txtEmployeeName.Enabled = true;
                btnRegister.Enabled = false;
            }
            else
            {
                if ((RetrieveEmployee(connectionString, txtEmployeeId.Text)))
                {
                    Console.WriteLine(emp.Id);
                    txtEmployeeId.Text = emp.Id.ToString();
                    txtEmployeeName.Text = emp.Name;
                    btnSearchEmp.Image = Properties.Resources.refresh;
                    txtEmployeeId.Enabled = false;
                    txtEmployeeName.Enabled = false;
                    btnRegister.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Employee not found in the Database.", "Search Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                search = true;
            }
        }

        // Method to insert a new Leave record
        private void InsertLeave(int leaveID, int noOfDays, string name, DateTime leaveStartDate, string leaveType, int employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Leave (LeaveID, No_of_days, Name, LeaveStartDate, LeaveType, EmployeeID) " +
                                   "VALUES (@LeaveID, @No_of_days, @Name, @LeaveStartDate, @LeaveType, @EmployeeID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveID", leaveID);
                        command.Parameters.AddWithValue("@No_of_days", noOfDays);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@LeaveStartDate", leaveStartDate);
                        command.Parameters.AddWithValue("@LeaveType", leaveType);
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave record inserted successfully.", "Insertion to the Database Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearValues();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Leave record.", "Database Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Method to update an existing Leave record
        private void UpdateLeave(int leaveID, int noOfDays, string name, DateTime leaveStartDate, string leaveType, int employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Leave SET " +
                                   "No_of_days = @No_of_days, " +
                                   "Name = @Name, " +
                                   "LeaveStartDate = @LeaveStartDate, " +
                                   "LeaveType = @LeaveType " +
                                   "WHERE LeaveID = @LeaveID AND EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@No_of_days", noOfDays);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@LeaveStartDate", leaveStartDate);
                        command.Parameters.AddWithValue("@LeaveType", leaveType);
                        command.Parameters.AddWithValue("@LeaveID", leaveID);
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave record updated successfully.", "Update Database Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearValues();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Leave record.", "Update Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Method to delete a Leave record
        private void DeleteLeave(int leaveID, int employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Leave WHERE LeaveID = @LeaveID AND EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LeaveID", leaveID);
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave record deleted successfully from the database.", "Record Deletion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearValues();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, No Leave record found with the inputted LeaveID and EmployeeID.", "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
