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
    public partial class FacultyForm : Form
    {
        private int facultyId;
        public FacultyForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            try
            {
                // Generate a unique Faculty during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    facultyId = GenerateUniqueEFacultyId(connection);
                    txtFacultyid.Text = facultyId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            LoadFaculty();
            LoadAllFaculties();
        }

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                   "Initial Catalog=GryfindoSystemV2;" +
                                   "Integrated Security=SSPI;";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool LoadFaculty()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Faculty WHERE FacultyID='" + txtFacultyid.Text + "'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFacultyid.Text = reader["FacultyID"].ToString();
                                txtFacultyName.Text = reader["Name"].ToString();

                                // Parse and split the FacultyStarted Date value
                                DateTime salCycleEndDate = (DateTime)reader["FacultyStartedDate"];
                                txtFacStartD.Text = salCycleEndDate.Day.ToString();
                                txtFacStartM.Text = salCycleEndDate.Month.ToString();
                                txtFacStartY.Text = salCycleEndDate.Year.ToString();

                                //txtNoOfLeaves.Text = reader["noOfLeaves"].ToString();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm(lblName.Text);
            this.Hide();
            frm.Show();
        }


        // Method to generate a unique FacultyID
        private int GenerateUniqueEFacultyId(SqlConnection connection)
        {
            string query = "SELECT MAX(FacultyID) FROM Faculty";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                return maxId + 1;
            }
        }

        private void btnSearchFac_Click(object sender, EventArgs e)
        {
            // set for searching employee
            if (btnRegister.Visible == true)
            {
                if ((LoadFaculty() == true))
                {
                    btnRegister.Visible = false;
                    pnlDelUpd.Visible = true;
                    btnSearchFac.Image = Properties.Resources.refresh;
                    txtFacultyid.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Searched Faculty not found in the database.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // set for registering employee
            else
            {
                clearValues();
            }
        }

        void LoadAllFaculties()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Faculty";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtAllFaculties.AppendText((string)reader["Name"]);
                                txtAllFaculties.AppendText(Environment.NewLine);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        void clearValues()
        {
            txtAllFaculties.Text = "";
            txtFacStartD.Text = "";
            txtFacStartM.Text = "";
            txtFacStartY.Text = "";
            txtFacultyName.Text = "";

            btnRegister.Visible = true;
            pnlDelUpd.Visible = false;
            btnSearchFac.Image = Properties.Resources.search;
            txtFacultyid.Enabled = true;

            try
            {
                // Generate a unique Faculty during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    facultyId = GenerateUniqueEFacultyId(connection);
                    txtFacultyid.Text = facultyId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            LoadAllFaculties();
        }

        private bool ValidateFacultyInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFacultyid.Text) ||
                string.IsNullOrWhiteSpace(txtFacultyName.Text) ||
                string.IsNullOrWhiteSpace(txtFacStartD.Text) ||
                string.IsNullOrWhiteSpace(txtFacStartM.Text) ||
                string.IsNullOrWhiteSpace(txtFacStartY.Text))
            {
                return false; // Validation failed
            }

            return true; // Validation passed
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateFacultyInputs())
            {
                try
                {
                    int facultyID = int.Parse(txtFacultyid.Text);
                    string facultyName = txtFacultyName.Text;
                    int startDay = int.Parse(txtFacStartD.Text);
                    int startMonth = int.Parse(txtFacStartM.Text);
                    int startYear = int.Parse(txtFacStartY.Text);
                    DateTime startDate = new DateTime(startYear, startMonth, startDay);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO Faculty (FacultyID, FacultyStartedDate, Name) VALUES (@FacultyID, @StartDate, @FacultyName)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FacultyID", facultyID);
                            command.Parameters.AddWithValue("@StartDate", startDate);
                            command.Parameters.AddWithValue("@FacultyName", facultyName);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    // Clear the input fields after successful registration
                    txtFacultyid.Text = string.Empty;
                    txtFacultyName.Text = string.Empty;
                    txtFacStartD.Text = string.Empty;
                    txtFacStartM.Text = string.Empty;
                    txtFacStartY.Text = string.Empty;

                    // Show a success message or perform any other actions
                    MessageBox.Show("Faculty registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearValues();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Handle any exceptions that occurred during the registration process
                    MessageBox.Show("An error occurred while registering the faculty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show an error message indicating that validation failed
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (ValidateFacultyInputs())
            {
                try
                {
                    string facultyID = txtFacultyid.Text;
                    string facultyName = txtFacultyName.Text;
                    int startDay = int.Parse(txtFacStartD.Text);
                    int startMonth = int.Parse(txtFacStartM.Text);
                    int startYear = int.Parse(txtFacStartY.Text);
                    DateTime startDate = new DateTime(startYear, startMonth, startDay);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Faculty SET Name = @FacultyName, FacultyStartedDate = @StartDate WHERE FacultyID = @FacultyID";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FacultyName", facultyName);
                            command.Parameters.AddWithValue("@StartDate", startDate);
                            command.Parameters.AddWithValue("@FacultyID", facultyID);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    // Clear the input fields after successful update
                    txtFacultyName.Text = string.Empty;
                    txtFacStartD.Text = string.Empty;
                    txtFacStartM.Text = string.Empty;
                    txtFacStartY.Text = string.Empty;

                    // Show a success message or perform any other actions
                    MessageBox.Show("Faculty updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearValues();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Handle any exceptions that occurred during the update process
                    MessageBox.Show("An error occurred while updating the faculty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show an error message indicating that validation failed
                MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string facultyID = txtFacultyid.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Faculty WHERE FacultyID = @FacultyID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FacultyID", facultyID); // Add the FacultyID parameter
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    clearValues();
                }

                // Show a success message or perform any other actions
                MessageBox.Show("Faculty deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Handle any exceptions that occurred during the delete process
                MessageBox.Show("An error occurred while deleting the faculty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(lblName.Text);
            this.Hide();
            frm.Show();
        }
    }
}
