using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm(string name)
        {
            InitializeComponent();
            lblName.Text = name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm(lblName.Text);
            this.Hide();
            frm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm frm = new EmployeeForm(lblName.Text);
            this.Hide();
            frm.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SalaryForm frm = new SalaryForm(lblName.Text);
            this.Hide();
            frm.Show();
        }
    }
}
