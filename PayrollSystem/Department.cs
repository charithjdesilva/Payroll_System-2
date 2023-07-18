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
    public partial class DepartmentForm : Form
    {
        private int departementId;
        public DepartmentForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            try
            {
                // Generate a unique Faculty during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    departementId = GenerateUniqueEdepartementId(connection);
                    txtDepartmentId.Text = departementId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            LoadDepartment();
        }

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                   "Initial Catalog=GryfindoSystemV2;" +
                                   "Integrated Security=SSPI;";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool LoadDepartment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Department WHERE DepartmentID='" + txtDepartmentId.Text + "'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDepartmentId.Text = reader["DepartmentID"].ToString();
                                int facultyId = Convert.ToInt32(reader["FacultyID"]);
                                txtFacultyId.Text = facultyId.ToString();
                                retreiveFacultyName(facultyId);
                                LoadAllDepartments(facultyId);
                                txtDepartmentName.Text = reader["Name"].ToString();

                                // Parse and split the FacultyStarted Date value
                                DateTime salCycleEndDate = (DateTime)reader["DepartmentStartedDate"];
                                txtDepartmentStartD.Text = salCycleEndDate.Day.ToString();
                                txtDepartmentStartM.Text = salCycleEndDate.Month.ToString();
                                txtDepartmentStartY.Text = salCycleEndDate.Year.ToString();

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

        private void retreiveFacultyName(int facultyID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Name FROM Faculty WHERE FacultyID='" + facultyID + "'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFacultyName.Text = reader["Name"].ToString();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm(lblName.Text);
            this.Hide();
            frm.Show();
        }


        // Method to generate a unique departementId
        private int GenerateUniqueEdepartementId(SqlConnection connection)
        {
            string query = "SELECT MAX(DepartmentID) FROM Department";
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
                if ((LoadDepartment() == true))
                {
                    btnRegister.Visible = false;
                    pnlDelUpd.Visible = true;
                    btnSearchFac.Image = Properties.Resources.refresh;
                    txtDepartmentId.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Searched Department not found in the database.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // set for registering employee
            else
            {
                clearValues();
            }
        }

        bool LoadAllDepartments(int facultyId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Department WHERE FacultyID='" + facultyId.ToString() + "'";
                    string query2 = "SELECT * FROM Faculty WHERE FacultyID='" + facultyId.ToString() + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtAllDepartmentsOfFaculty.AppendText((string)reader["Name"]);
                                txtAllDepartmentsOfFaculty.AppendText(Environment.NewLine);
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtFacultyName.Text = (string)reader["Name"];
                                connection.Close();
                                return true;
                            }
                            txtFacultyId.Text = "";
                            txtFacultyName.Text = "";
                            MessageBox.Show("There is no faculty under FacultyId = '" + txtFacultyId.Text + "' Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnSearchEmp.Image = Properties.Resources.search;
                            txtFacultyId.Enabled = true;
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

        void clearValues()
        {
            txtAllDepartmentsOfFaculty.Text = "";
            txtDepartmentStartD.Text = "";
            txtDepartmentStartM.Text = "";
            txtDepartmentStartY.Text = "";
            txtDepartmentName.Text = "";

            btnRegister.Visible = true;
            pnlDelUpd.Visible = false;
            btnSearchFac.Image = Properties.Resources.search;
            txtDepartmentId.Enabled = true;

            try
            {
                // Generate a unique Faculty during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    departementId = GenerateUniqueEdepartementId(connection);
                    txtDepartmentId.Text = departementId.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private bool ValidateDepartmentInputs()
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentId.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentStartY.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentStartM.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentStartD.Text) ||
                string.IsNullOrWhiteSpace(txtFacultyId.Text) ||
                string.IsNullOrWhiteSpace(txtFacultyName.Text))
            {
                return false; // Validation failed
            }

            return true; // Validation passed
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateDepartmentInputs())
            {
                try
                {
                    int departementId = int.Parse(txtDepartmentId.Text);
                    int facultyId = int.Parse(txtFacultyId.Text);
                    string facultyName = txtDepartmentName.Text;
                    int startDay = int.Parse(txtDepartmentStartD.Text);
                    int startMonth = int.Parse(txtDepartmentStartM.Text);
                    int startYear = int.Parse(txtDepartmentStartY.Text);
                    DateTime startDate = new DateTime(startYear, startMonth, startDay);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO Department (DepartmentID, FacultyID, DepartmentStartedDate, Name) VALUES (@departementId, @facultyId, @StartDate, @FacultyName)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@departementId", departementId);
                            command.Parameters.AddWithValue("@facultyId", facultyId);
                            command.Parameters.AddWithValue("@StartDate", startDate);
                            command.Parameters.AddWithValue("@FacultyName", facultyName);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    // Clear the input fields after successful registration
                    txtDepartmentId.Text = string.Empty;
                    txtDepartmentName.Text = string.Empty;
                    txtDepartmentStartD.Text = string.Empty;
                    txtDepartmentStartM.Text = string.Empty;
                    txtDepartmentStartY.Text = string.Empty;

                    // Show a success message or perform any other actions
                    MessageBox.Show("Department registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearValues();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Handle any exceptions that occurred during the registration process
                    MessageBox.Show("An error occurred while registering the Department. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (ValidateDepartmentInputs())
            {
                try
                {
                    string departementId = txtDepartmentId.Text;
                    int facultyId = int.Parse(txtFacultyId.Text);
                    string departmentName = txtDepartmentName.Text;
                    int startDay = int.Parse(txtDepartmentStartD.Text);
                    int startMonth = int.Parse(txtDepartmentStartM.Text);
                    int startYear = int.Parse(txtDepartmentStartY.Text);
                    DateTime startDate = new DateTime(startYear, startMonth, startDay);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Department SET Name = @DepartmentName, FacultyID = @facultyId, DepartmentStartedDate = @StartDate WHERE DepartmentID = @departementId";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DepartmentName", departmentName);
                            command.Parameters.AddWithValue("@StartDate", startDate);
                            command.Parameters.AddWithValue("@facultyId", facultyId);
                            command.Parameters.AddWithValue("@departementId", departementId);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                    // Clear the input fields after successful update
                    txtDepartmentName.Text = string.Empty;
                    txtDepartmentStartD.Text = string.Empty;
                    txtDepartmentStartM.Text = string.Empty;
                    txtDepartmentStartY.Text = string.Empty;

                    // Show a success message or perform any other actions
                    MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearValues();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Handle any exceptions that occurred during the update process
                    MessageBox.Show("An error occurred while updating the Department. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string departementId = txtDepartmentId.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Department WHERE DepartmentID = @departementId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@departementId", departementId); // Add the departementId parameter
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    clearValues();
                }

                // Show a success message or perform any other actions
                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Handle any exceptions that occurred during the delete process
                MessageBox.Show("An error occurred while deleting the Department. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(lblName.Text);
            this.Hide();
            frm.Show();
        }

        bool searchFac = true;
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (searchFac == true)
            {
                searchFac = false;
                btnSearchEmp.Image = Properties.Resources.search;
                txtFacultyId.Enabled = true;
                txtAllDepartmentsOfFaculty.Text = "";
            }
            else
            {
                searchFac = true;
                btnSearchEmp.Image = Properties.Resources.refresh;
                txtFacultyId.Enabled = false;
                LoadAllDepartments(Convert.ToInt32(txtFacultyId.Text));
            }
        }
    }
}
