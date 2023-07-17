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
    public partial class DependentForm : Form
    {
        private int dependentID;
        public DependentForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            try
            {
                // Generate a unique DependentID during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    dependentID = GenerateUniqueDependentId(connection);
                    txtDependentId.Text = dependentID.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                   "Initial Catalog=GryfindoSystemV2;" +
                                  "Integrated Security=SSPI;";

        Dependent depend = new Dependent();
        Employee emp = new Employee();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        void clearValues()
        {
            txtDependentDobD.Text = "";
            txtDependentDobM.Text = "";
            txtDependentDobY.Text = "";
            txtDependentName.Text = "";
            txtPhone.Text = "";
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtDependentId.Enabled = true;
            txtEmployeeId.Enabled = true;
            txtEmployeeName.Enabled = true;
            btnSearchEmp.Visible = true;
            txtOtherDependents.Text = "";

            rbGenderFemale.Checked = false;
            rbGenderMale.Checked = false;

            btnRegister.Visible = true;
            pnlDelUpd.Visible = false;
            btnSearchDepenedent.Image = Properties.Resources.search;

            btnRegister.Enabled = false;

            try
            {
                // Generate a unique DependentID during form initialization
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    dependentID = GenerateUniqueDependentId(connection);
                    txtDependentId.Text = dependentID.ToString();
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
                if ((RetrieveDependent(connectionString, txtDependentId.Text)))
                {
                    Console.WriteLine(depend.Id);
                    txtDependentId.Text = depend.Id.ToString();
                    txtDependentName.Text = depend.Name;
                    txtPhone.Text = depend.Phone;
                    txtEmployeeId.Text = depend.EmpId.ToString();

                    RetrieveEmployee(connectionString, depend.EmpId.ToString());

                    txtEmployeeName.Text = emp.Name;

                    //get other dependents related to the employee
                    RetrieveEmployeeDependents(connectionString, depend.EmpId.ToString());


                    txtDependentDobD.Text = depend.Dob.ToString("dd");
                    txtDependentDobM.Text = depend.Dob.ToString("MM");
                    txtDependentDobY.Text = depend.Dob.ToString("yyyy");
                    if (depend.Gender == "Male")
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
                    btnSearchDepenedent.Image = Properties.Resources.refresh;
                    txtDependentId.Enabled = false;
                    txtEmployeeId.Enabled = false;
                    txtEmployeeName.Enabled = false;
                    btnSearchEmp.Visible = false;
                }
                else
                {
                    MessageBox.Show("Searched Dependent not found in the database.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // set for registering employee
            else
            {
                clearValues();
            }
        }

        // retreive Dependent details
        bool RetrieveDependent(string connectionString, string dependentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM EmpDependent WHERE DependentID='" + dependentID + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve Dependent data
                                depend.Id = Convert.ToInt32(reader["DependentID"]);
                                depend.EmpId = Convert.ToInt32(reader["EmployeeID"]);
                                depend.Name = (string)reader["Dep_Name"];
                                depend.Dob = (DateTime)(reader["Dep_dob"]);
                                depend.Gender = (string)reader["Dep_gender"];
                                depend.Phone = (string)reader["Dep_phone"];
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

        //get other dependents under the employee
        void RetrieveEmployeeDependents(string connectionString, string employeeId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM EmpDependent WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txtOtherDependents.AppendText((string)reader["Dep_Name"]);
                                txtOtherDependents.AppendText(Environment.NewLine);
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


        // Validation method to check if all input fields are filled
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtDependentId.Text) ||
                string.IsNullOrWhiteSpace(txtDependentName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtDependentDobD.Text) ||
                string.IsNullOrWhiteSpace(txtDependentDobM.Text) ||
                string.IsNullOrWhiteSpace(txtDependentDobY.Text))
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
                string dependentID = txtDependentId.Text;
                string dependentName = txtDependentName.Text;
                string phone = txtPhone.Text;
                DateTime dob = new DateTime(Convert.ToInt32(txtDependentDobY.Text),
                                            Convert.ToInt32(txtDependentDobM.Text),
                                            Convert.ToInt32(txtDependentDobD.Text));
                string gender = rbGenderMale.Checked ? "Male" : "Female";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE EmpDependent SET " +
                                       "Dep_Name = @Name, " +
                                       "Dep_dob = @Dob, " +
                                       "Dep_gender = @Gender, " +
                                       "Dep_phone = @Phone " +
                                       "WHERE DependentID = @DependentId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", dependentName);
                            command.Parameters.AddWithValue("@Dob", dob);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@DependentId", dependentID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Values you inputted for Dependent record updated successfully to the database.", "Update Database Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearValues();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update Values you inputted for the Dependent record.", "Update Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string dependentName = txtDependentName.Text;
                string phone = txtPhone.Text;
                DateTime dob = new DateTime(Convert.ToInt32(txtDependentDobY.Text),
                                            Convert.ToInt32(txtDependentDobM.Text),
                                            Convert.ToInt32(txtDependentDobD.Text));
                string gender = rbGenderMale.Checked ? "Male" : "Female";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Generate a unique DependentID
                        int dependentID = GenerateUniqueDependentId(connection);

                        string query = "INSERT INTO EmpDependent (DependentID, EmployeeID, Dep_Name, Dep_dob, Dep_gender, Dep_phone) " +
                                       "VALUES (@DependentId, @EmployeeId, @Name, @Dob, @Gender, @Phone)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DependentId", dependentID);
                            command.Parameters.AddWithValue("@EmployeeId", emp.Id);
                            command.Parameters.AddWithValue("@Name", dependentName);
                            command.Parameters.AddWithValue("@Dob", dob);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Phone", phone);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dependent record inserted successfully.", "Insertion to the Database Successesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearValues();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert Dependent record.", "Database Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Method to generate a unique DependentID
        private int GenerateUniqueDependentId(SqlConnection connection)
        {
            string query = "SELECT MAX(DependentID) FROM EmpDependent";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                int maxId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                return maxId + 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dependentID = txtDependentId.Text;

            if (!string.IsNullOrWhiteSpace(dependentID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM EmpDependent WHERE DependentID = @DependentId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DependentId", dependentID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Dependent record deleted successfully from the database.", "Record Deletetion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearValues();
                            }
                            else
                            {
                                MessageBox.Show("Sorry, No Dependent record found with the inputed DependentID.", "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please input an DependentID to delete from the Database.", "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                txtOtherDependents.Text = "";
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
                    //get other dependents related to the employee
                    RetrieveEmployeeDependents(connectionString, depend.EmpId.ToString());
                }
                else
                {
                    MessageBox.Show("Employee not found in the Database.", "Search Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                search = true; // Update the search variable after performing the search
            }
        }
    }
}
