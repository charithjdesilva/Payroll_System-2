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
    public partial class AllEmployeesForm : Form
    {
        string connectionString = "Data Source=CHARITH\\SQLEXPRESS;" +
                                   "Initial Catalog=GryfindoSystemV2;" +
                                   "Integrated Security=SSPI;";

        public AllEmployeesForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;

            // Set the desired color and font for the DataGridView
            SetDataGridViewStyle();

            // Load all employee details into the DataGridView
            LoadEmployeeDetails();
        }

        private void SetDataGridViewStyle()
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(25, 25, 25),
                ForeColor = Color.White
            };

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(25, 25, 25),
                ForeColor = Color.White
            };

            dgwEmployees.DefaultCellStyle = cellStyle;
            dgwEmployees.ColumnHeadersDefaultCellStyle = headerStyle;
            dgwEmployees.RowHeadersDefaultCellStyle = headerStyle;

            // Set the background color of the column and row headers
            dgwEmployees.EnableHeadersVisualStyles = false;
            dgwEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
            dgwEmployees.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void LoadEmployeeDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgwEmployees.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            EmployeeForm hf = new EmployeeForm(lblName.Text);
            hf.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(lblName.Text);
            this.Hide();
            frm.Show();
        }
    }
}
