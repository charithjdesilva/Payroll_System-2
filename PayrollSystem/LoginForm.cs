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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string name = "";

        void setName(string name) {
            this.name = name;
        }

        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                   "Initial Catalog=GrifindoToys;" +
                                  "Integrated Security=SSPI;";

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        bool ValidatePassword(string username, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SysAdmin WHERE username = '" + username + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        string RetrieveAdminPassword(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM SysAdmin WHERE username='" + txtUsername.Text +"'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Retrieve admin data
                            string password = (string)reader["password"];
                            string name = (string)reader["name"];

                            setName(name);

                            return password;
                        }
                        return null;
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {

            }
            
            else if(ValidatePassword(txtUsername.Text, connectionString))
            {
                if (RetrieveAdminPassword(connectionString) == txtPassword.Text)
                {
                    HomeForm hf = new HomeForm(name);
                    hf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
