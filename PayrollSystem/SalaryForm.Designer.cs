namespace PayrollSystem
{
    partial class SalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSalEndY = new System.Windows.Forms.TextBox();
            this.txtSalBeginY = new System.Windows.Forms.TextBox();
            this.txtSalEndM = new System.Windows.Forms.TextBox();
            this.txtSalBeginM = new System.Windows.Forms.TextBox();
            this.txtSalEndD = new System.Windows.Forms.TextBox();
            this.txtSalBeginD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoOfAbsents = new System.Windows.Forms.TextBox();
            this.txtDateRange = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHolidays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLeaves = new System.Windows.Forms.GroupBox();
            this.txtOTHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultNoPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultBasePay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResultGrossPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.btnInsertToDB = new System.Windows.Forms.Button();
            this.txtGovtRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpLeaves.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(770, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grifindo Toys";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Location = new System.Drawing.Point(739, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 145);
            this.panel1.TabIndex = 13;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::PayrollSystem.Properties.Resources.back1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 37);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(261, 87);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(273, 36);
            this.lblName.TabIndex = 11;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalEndY
            // 
            this.txtSalEndY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSalEndY.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtSalEndY.ForeColor = System.Drawing.Color.White;
            this.txtSalEndY.Location = new System.Drawing.Point(364, 297);
            this.txtSalEndY.MaxLength = 20;
            this.txtSalEndY.Name = "txtSalEndY";
            this.txtSalEndY.Size = new System.Drawing.Size(83, 34);
            this.txtSalEndY.TabIndex = 6;
            // 
            // txtSalBeginY
            // 
            this.txtSalBeginY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSalBeginY.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtSalBeginY.ForeColor = System.Drawing.Color.White;
            this.txtSalBeginY.Location = new System.Drawing.Point(364, 228);
            this.txtSalBeginY.MaxLength = 20;
            this.txtSalBeginY.Name = "txtSalBeginY";
            this.txtSalBeginY.Size = new System.Drawing.Size(83, 34);
            this.txtSalBeginY.TabIndex = 3;
            // 
            // txtSalEndM
            // 
            this.txtSalEndM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSalEndM.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtSalEndM.ForeColor = System.Drawing.Color.White;
            this.txtSalEndM.Location = new System.Drawing.Point(317, 297);
            this.txtSalEndM.MaxLength = 20;
            this.txtSalEndM.Name = "txtSalEndM";
            this.txtSalEndM.Size = new System.Drawing.Size(41, 34);
            this.txtSalEndM.TabIndex = 5;
            // 
            // txtSalBeginM
            // 
            this.txtSalBeginM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSalBeginM.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtSalBeginM.ForeColor = System.Drawing.Color.White;
            this.txtSalBeginM.Location = new System.Drawing.Point(317, 228);
            this.txtSalBeginM.MaxLength = 20;
            this.txtSalBeginM.Name = "txtSalBeginM";
            this.txtSalBeginM.Size = new System.Drawing.Size(41, 34);
            this.txtSalBeginM.TabIndex = 2;
            // 
            // txtSalEndD
            // 
            this.txtSalEndD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSalEndD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtSalEndD.ForeColor = System.Drawing.Color.White;
            this.txtSalEndD.Location = new System.Drawing.Point(270, 297);
            this.txtSalEndD.MaxLength = 20;
            this.txtSalEndD.Name = "txtSalEndD";
            this.txtSalEndD.Size = new System.Drawing.Size(41, 34);
            this.txtSalEndD.TabIndex = 4;
            // 
            // txtSalBeginD
            // 
            this.txtSalBeginD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtSalBeginD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtSalBeginD.ForeColor = System.Drawing.Color.White;
            this.txtSalBeginD.Location = new System.Drawing.Point(270, 228);
            this.txtSalBeginD.MaxLength = 20;
            this.txtSalBeginD.Name = "txtSalBeginD";
            this.txtSalBeginD.Size = new System.Drawing.Size(41, 34);
            this.txtSalBeginD.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 26);
            this.label10.TabIndex = 31;
            this.label10.Text = "Salary Cycle End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Salary Cycle Begin Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "No. of Absent Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date Range";
            // 
            // txtNoOfAbsents
            // 
            this.txtNoOfAbsents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtNoOfAbsents.Enabled = false;
            this.txtNoOfAbsents.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtNoOfAbsents.ForeColor = System.Drawing.Color.White;
            this.txtNoOfAbsents.Location = new System.Drawing.Point(253, 46);
            this.txtNoOfAbsents.MaxLength = 20;
            this.txtNoOfAbsents.Name = "txtNoOfAbsents";
            this.txtNoOfAbsents.Size = new System.Drawing.Size(177, 34);
            this.txtNoOfAbsents.TabIndex = 9;
            // 
            // txtDateRange
            // 
            this.txtDateRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtDateRange.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtDateRange.ForeColor = System.Drawing.Color.White;
            this.txtDateRange.Location = new System.Drawing.Point(270, 158);
            this.txtDateRange.MaxLength = 20;
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.Size = new System.Drawing.Size(177, 34);
            this.txtDateRange.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(665, 542);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 37);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(472, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 430);
            this.panel2.TabIndex = 41;
            // 
            // txtHolidays
            // 
            this.txtHolidays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtHolidays.Enabled = false;
            this.txtHolidays.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtHolidays.ForeColor = System.Drawing.Color.White;
            this.txtHolidays.Location = new System.Drawing.Point(253, 111);
            this.txtHolidays.MaxLength = 20;
            this.txtHolidays.Name = "txtHolidays";
            this.txtHolidays.Size = new System.Drawing.Size(177, 34);
            this.txtHolidays.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "No. of Holidays";
            // 
            // grpLeaves
            // 
            this.grpLeaves.BackColor = System.Drawing.Color.Transparent;
            this.grpLeaves.Controls.Add(this.label3);
            this.grpLeaves.Controls.Add(this.label2);
            this.grpLeaves.Controls.Add(this.txtHolidays);
            this.grpLeaves.Controls.Add(this.txtNoOfAbsents);
            this.grpLeaves.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.grpLeaves.ForeColor = System.Drawing.Color.White;
            this.grpLeaves.Location = new System.Drawing.Point(12, 409);
            this.grpLeaves.Name = "grpLeaves";
            this.grpLeaves.Size = new System.Drawing.Size(439, 179);
            this.grpLeaves.TabIndex = 42;
            this.grpLeaves.TabStop = false;
            this.grpLeaves.Text = "No. of Leaves";
            // 
            // txtOTHours
            // 
            this.txtOTHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtOTHours.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtOTHours.ForeColor = System.Drawing.Color.White;
            this.txtOTHours.Location = new System.Drawing.Point(611, 158);
            this.txtOTHours.MaxLength = 20;
            this.txtOTHours.Name = "txtOTHours";
            this.txtOTHours.Size = new System.Drawing.Size(177, 34);
            this.txtOTHours.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(491, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Over Time";
            // 
            // txtResultNoPay
            // 
            this.txtResultNoPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtResultNoPay.Enabled = false;
            this.txtResultNoPay.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtResultNoPay.ForeColor = System.Drawing.Color.White;
            this.txtResultNoPay.Location = new System.Drawing.Point(611, 296);
            this.txtResultNoPay.MaxLength = 20;
            this.txtResultNoPay.Name = "txtResultNoPay";
            this.txtResultNoPay.Size = new System.Drawing.Size(177, 34);
            this.txtResultNoPay.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(494, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "No Pay";
            // 
            // txtResultBasePay
            // 
            this.txtResultBasePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtResultBasePay.Enabled = false;
            this.txtResultBasePay.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtResultBasePay.ForeColor = System.Drawing.Color.White;
            this.txtResultBasePay.Location = new System.Drawing.Point(611, 365);
            this.txtResultBasePay.MaxLength = 20;
            this.txtResultBasePay.Name = "txtResultBasePay";
            this.txtResultBasePay.Size = new System.Drawing.Size(177, 34);
            this.txtResultBasePay.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(494, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Base Pay";
            // 
            // txtResultGrossPay
            // 
            this.txtResultGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtResultGrossPay.Enabled = false;
            this.txtResultGrossPay.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtResultGrossPay.ForeColor = System.Drawing.Color.White;
            this.txtResultGrossPay.Location = new System.Drawing.Point(611, 434);
            this.txtResultGrossPay.MaxLength = 20;
            this.txtResultGrossPay.Name = "txtResultGrossPay";
            this.txtResultGrossPay.Size = new System.Drawing.Size(177, 34);
            this.txtResultGrossPay.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(494, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "Gross Pay";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtEmployeeId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtEmployeeId.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeId.Location = new System.Drawing.Point(270, 365);
            this.txtEmployeeId.MaxLength = 20;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(141, 34);
            this.txtEmployeeId.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 26);
            this.label11.TabIndex = 34;
            this.label11.Text = "Employee ID";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnSearchEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSearchEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmp.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEmp.Image")));
            this.btnSearchEmp.Location = new System.Drawing.Point(412, 365);
            this.btnSearchEmp.Margin = new System.Windows.Forms.Padding(8);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Padding = new System.Windows.Forms.Padding(8);
            this.btnSearchEmp.Size = new System.Drawing.Size(35, 35);
            this.btnSearchEmp.TabIndex = 8;
            this.btnSearchEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // btnInsertToDB
            // 
            this.btnInsertToDB.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertToDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertToDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnInsertToDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInsertToDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnInsertToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToDB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.btnInsertToDB.ForeColor = System.Drawing.Color.White;
            this.btnInsertToDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertToDB.Location = new System.Drawing.Point(496, 542);
            this.btnInsertToDB.Name = "btnInsertToDB";
            this.btnInsertToDB.Size = new System.Drawing.Size(120, 37);
            this.btnInsertToDB.TabIndex = 28;
            this.btnInsertToDB.Text = "Insert";
            this.btnInsertToDB.UseVisualStyleBackColor = false;
            this.btnInsertToDB.Visible = false;
            this.btnInsertToDB.Click += new System.EventHandler(this.btnInsertToDB_Click);
            // 
            // txtGovtRate
            // 
            this.txtGovtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtGovtRate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtGovtRate.ForeColor = System.Drawing.Color.White;
            this.txtGovtRate.Location = new System.Drawing.Point(614, 228);
            this.txtGovtRate.MaxLength = 20;
            this.txtGovtRate.Name = "txtGovtRate";
            this.txtGovtRate.Size = new System.Drawing.Size(177, 34);
            this.txtGovtRate.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(494, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 26);
            this.label12.TabIndex = 34;
            this.label12.Text = "Gvt Tax R.";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::PayrollSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.grpLeaves);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSalEndY);
            this.Controls.Add(this.txtSalBeginY);
            this.Controls.Add(this.txtSalEndM);
            this.Controls.Add(this.txtSalBeginM);
            this.Controls.Add(this.txtSalEndD);
            this.Controls.Add(this.txtSalBeginD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResultGrossPay);
            this.Controls.Add(this.txtResultBasePay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultNoPay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGovtRate);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.txtOTHours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDateRange);
            this.Controls.Add(this.btnInsertToDB);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpLeaves.ResumeLayout(false);
            this.grpLeaves.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSalEndY;
        private System.Windows.Forms.TextBox txtSalBeginY;
        private System.Windows.Forms.TextBox txtSalEndM;
        private System.Windows.Forms.TextBox txtSalBeginM;
        private System.Windows.Forms.TextBox txtSalEndD;
        private System.Windows.Forms.TextBox txtSalBeginD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoOfAbsents;
        private System.Windows.Forms.TextBox txtDateRange;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHolidays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpLeaves;
        private System.Windows.Forms.TextBox txtOTHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultNoPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultBasePay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultGrossPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.Button btnInsertToDB;
        private System.Windows.Forms.TextBox txtGovtRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHome;
    }
}