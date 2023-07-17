﻿using System;
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
        public FacultyForm(string name)
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
                                txtFacultyid.Text = reader["dateRange"].ToString();

                                // Parse and split the FacultyStarted Date value
                                DateTime salCycleEndDate = (DateTime)reader["salCycleEndDate"];
                                txtFacEndD.Text = salCycleEndDate.Day.ToString();
                                txtFacEndM.Text = salCycleEndDate.Month.ToString();
                                txtFacEndY.Text = salCycleEndDate.Year.ToString();

                                txtNoOfLeaves.Text = reader["noOfLeaves"].ToString();
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

        private void UpdateSettings()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Settings " +
                                   "SET dateRange = @dateRange, " +
                                   "    salCycleBeginDate = @salCycleBeginDate, " +
                                   "    salCycleEndDate = @salCycleEndDate, " +
                                   "    noOfLeaves = @noOfLeaves";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values from the text boxes
                        command.Parameters.AddWithValue("@dateRange", Convert.ToDecimal(txtFacultyid.Text));
                        command.Parameters.AddWithValue("@salCycleEndDate", new DateTime(Convert.ToInt32(txtFacEndY.Text), Convert.ToInt32(txtFacEndM.Text), Convert.ToInt32(txtFacEndD.Text)));
                        command.Parameters.AddWithValue("@noOfLeaves", Convert.ToDecimal(txtNoOfLeaves.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Settings updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update settings.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSettings();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm(lblName.Text);
            this.Hide();
            frm.Show();
        }
    }
}
