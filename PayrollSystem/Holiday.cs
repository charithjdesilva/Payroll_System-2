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
    public partial class HolidayForm : Form
    {
        private int holidayID;
        private SqlConnection connection;

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                           "Initial Catalog=GryfindoSystemV2;" +
                                           "Integrated Security=SSPI;";

        public HolidayForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                holidayID = GenerateUniqueHolidayId(connection);
                txtHolidayId.Text = holidayID.ToString();
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
            txtHolidayDateD.Text = "";
            txtHolidayDateM.Text = "";
            txtHolidayDateY.Text = "";
            txtHolidayName.Text = "";
            txtNoOfDays.Text = "";
            txtHolidayId.Enabled = true;

            btnRegister.Visible = true;
            pnlDelUpd.Visible = false;
            btnSearchDepenedent.Image = Properties.Resources.search;
            btnRegister.Enabled = true;

            try
            {
                holidayID = GenerateUniqueHolidayId(connection);
                txtHolidayId.Text = holidayID.ToString();
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
                if (int.TryParse(txtHolidayId.Text, out holidayID))
                {
                    if (RetrieveHoliday(connectionString, holidayID))
                    {
                        Console.WriteLine(leave.LeaveID);
                        txtHolidayId.Text = leave.LeaveID.ToString();
                        txtHolidayName.Text = leave.Name;
                        txtNoOfDays.Text = leave.No_of_days.ToString();

                        txtHolidayDateD.Text = leave.LeaveStartDate.ToString("dd");
                        txtHolidayDateM.Text = leave.LeaveStartDate.ToString("MM");
                        txtHolidayDateY.Text = leave.LeaveStartDate.ToString("yyyy");

                        btnRegister.Visible = false;
                        pnlDelUpd.Visible = true;
                        txtHolidayId.Enabled = false;
                        btnSearchDepenedent.Image = Properties.Resources.refresh;
                    }
                    else
                    {
                        MessageBox.Show("Searched Holiday not found in the database.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Holiday ID. Please enter a valid Holiday ID.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                clearValues();
            }
        }

        // Retrieve leave details
        bool RetrieveHoliday(string connectionString, int holidayID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Holiday WHERE HolidayID = @HolidayID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HolidayID", holidayID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve leave data
                                leave.LeaveID = Convert.ToInt32(reader["HolidayID"]);
                                leave.No_of_days = Convert.ToInt32(reader["No_of_days"]);
                                leave.Name = (string)reader["Name"];
                                leave.LeaveStartDate = (DateTime)(reader["HolidayStartDate"]);
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

        // Validation method to check if all input fields are filled
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtHolidayId.Text) ||
                string.IsNullOrWhiteSpace(txtHolidayName.Text) ||
                string.IsNullOrWhiteSpace(txtNoOfDays.Text) ||
                string.IsNullOrWhiteSpace(txtHolidayDateD.Text) ||
                string.IsNullOrWhiteSpace(txtHolidayDateM.Text) ||
                string.IsNullOrWhiteSpace(txtHolidayDateY.Text))
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
                int holidayID = Convert.ToInt32(txtHolidayId.Text);
                int noOfDays = Convert.ToInt32(txtNoOfDays.Text);
                string name = txtHolidayName.Text;
                DateTime holidayStartDate = new DateTime(Convert.ToInt32(txtHolidayDateY.Text),
                                                        Convert.ToInt32(txtHolidayDateM.Text),
                                                        Convert.ToInt32(txtHolidayDateD.Text));

                // Update the existing Holiday record
                UpdateHoliday(holidayID, noOfDays, name, holidayStartDate);
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
                int holidayID = Convert.ToInt32(txtHolidayId.Text);
                int noOfDays = Convert.ToInt32(txtNoOfDays.Text);
                string name = txtHolidayName.Text;
                DateTime holidayStartDate = new DateTime(Convert.ToInt32(txtHolidayDateY.Text),
                                                        Convert.ToInt32(txtHolidayDateM.Text),
                                                        Convert.ToInt32(txtHolidayDateD.Text));

                // Insert the new Holiday record
                InsertHoliday(holidayID, noOfDays, name, holidayStartDate);
            }
            else
            {
                MessageBox.Show("Check and Please fill in all the required fields.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to generate a unique HolidayID
        private int GenerateUniqueHolidayId(SqlConnection connection)
        {
            string query = "SELECT MAX(HolidayID) FROM Holiday";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                return maxId + 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int holidayID = Convert.ToInt32(txtHolidayId.Text);

            // Delete the Holiday record
            DeleteHoliday(holidayID);
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

        // Method to insert a new Holiday record
        private void InsertHoliday(int holidayID, int noOfDays, string name, DateTime holidayStartDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Holiday (HolidayID, No_of_days, Name, HolidayStartDate) " +
                                   "VALUES (@HolidayID, @No_of_days, @Name, @HolidayStartDate)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HolidayID", holidayID);
                        command.Parameters.AddWithValue("@No_of_days", noOfDays);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@HolidayStartDate", holidayStartDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Holiday record inserted successfully.", "Insertion to the Database Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearValues();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert Holiday record.", "Database Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Method to update an existing Holiday record
        private void UpdateHoliday(int holidayID, int noOfDays, string name, DateTime holidayStartDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Holiday SET " +
                                   "No_of_days = @No_of_days, " +
                                   "Name = @Name, " +
                                   "HolidayStartDate = @HolidayStartDate " +
                                   "WHERE HolidayID = @HolidayID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@No_of_days", noOfDays);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@HolidayStartDate", holidayStartDate);
                        command.Parameters.AddWithValue("@HolidayID", holidayID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Holiday record updated successfully.", "Update Database Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearValues();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update Holiday record.", "Update Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Method to delete a Holiday record
        private void DeleteHoliday(int holidayID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Holiday WHERE HolidayID = @HolidayID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HolidayID", holidayID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Holiday record deleted successfully from the database.", "Record Deletion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearValues();
                        }
                        else
                        {
                            MessageBox.Show("Sorry, No Holiday record found with the inputted HolidayID.", "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
