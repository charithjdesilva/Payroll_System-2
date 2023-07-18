namespace PayrollSystem
{
    partial class LeaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearchDepenedent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeaveId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLeaveName = new System.Windows.Forms.TextBox();
            this.txtLeaveDateD = new System.Windows.Forms.TextBox();
            this.txtLeaveDateY = new System.Windows.Forms.TextBox();
            this.txtLeaveDateM = new System.Windows.Forms.TextBox();
            this.txtNoOfDays = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlDelUpd = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlDelUpd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.label1.Location = new System.Drawing.Point(292, 50);
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
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(740, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 145);
            this.panel1.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(261, 87);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(273, 34);
            this.lblName.TabIndex = 11;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::PayrollSystem.Properties.Resources.back1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(86, 37);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearchDepenedent
            // 
            this.btnSearchDepenedent.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchDepenedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepenedent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnSearchDepenedent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSearchDepenedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchDepenedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDepenedent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDepenedent.ForeColor = System.Drawing.Color.White;
            this.btnSearchDepenedent.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDepenedent.Image")));
            this.btnSearchDepenedent.Location = new System.Drawing.Point(342, 172);
            this.btnSearchDepenedent.Margin = new System.Windows.Forms.Padding(8);
            this.btnSearchDepenedent.Name = "btnSearchDepenedent";
            this.btnSearchDepenedent.Padding = new System.Windows.Forms.Padding(8);
            this.btnSearchDepenedent.Size = new System.Drawing.Size(34, 35);
            this.btnSearchDepenedent.TabIndex = 1;
            this.btnSearchDepenedent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchDepenedent.UseVisualStyleBackColor = false;
            this.btnSearchDepenedent.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Leave ID";
            // 
            // txtLeaveId
            // 
            this.txtLeaveId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtLeaveId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtLeaveId.ForeColor = System.Drawing.Color.White;
            this.txtLeaveId.Location = new System.Drawing.Point(200, 172);
            this.txtLeaveId.MaxLength = 20;
            this.txtLeaveId.Name = "txtLeaveId";
            this.txtLeaveId.Size = new System.Drawing.Size(132, 34);
            this.txtLeaveId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Leave Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Leave Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "No. of Days";
            // 
            // txtLeaveName
            // 
            this.txtLeaveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtLeaveName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveName.ForeColor = System.Drawing.Color.White;
            this.txtLeaveName.Location = new System.Drawing.Point(200, 242);
            this.txtLeaveName.MaxLength = 100;
            this.txtLeaveName.Name = "txtLeaveName";
            this.txtLeaveName.Size = new System.Drawing.Size(176, 30);
            this.txtLeaveName.TabIndex = 2;
            // 
            // txtLeaveDateD
            // 
            this.txtLeaveDateD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtLeaveDateD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtLeaveDateD.ForeColor = System.Drawing.Color.White;
            this.txtLeaveDateD.Location = new System.Drawing.Point(200, 311);
            this.txtLeaveDateD.MaxLength = 20;
            this.txtLeaveDateD.Name = "txtLeaveDateD";
            this.txtLeaveDateD.Size = new System.Drawing.Size(42, 34);
            this.txtLeaveDateD.TabIndex = 3;
            // 
            // txtLeaveDateY
            // 
            this.txtLeaveDateY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtLeaveDateY.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtLeaveDateY.ForeColor = System.Drawing.Color.White;
            this.txtLeaveDateY.Location = new System.Drawing.Point(294, 311);
            this.txtLeaveDateY.MaxLength = 20;
            this.txtLeaveDateY.Name = "txtLeaveDateY";
            this.txtLeaveDateY.Size = new System.Drawing.Size(84, 34);
            this.txtLeaveDateY.TabIndex = 5;
            // 
            // txtLeaveDateM
            // 
            this.txtLeaveDateM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtLeaveDateM.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtLeaveDateM.ForeColor = System.Drawing.Color.White;
            this.txtLeaveDateM.Location = new System.Drawing.Point(248, 311);
            this.txtLeaveDateM.MaxLength = 20;
            this.txtLeaveDateM.Name = "txtLeaveDateM";
            this.txtLeaveDateM.Size = new System.Drawing.Size(42, 34);
            this.txtLeaveDateM.TabIndex = 4;
            // 
            // txtNoOfDays
            // 
            this.txtNoOfDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtNoOfDays.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtNoOfDays.ForeColor = System.Drawing.Color.White;
            this.txtNoOfDays.Location = new System.Drawing.Point(200, 449);
            this.txtNoOfDays.MaxLength = 20;
            this.txtNoOfDays.Name = "txtNoOfDays";
            this.txtNoOfDays.Size = new System.Drawing.Size(176, 34);
            this.txtNoOfDays.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(404, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 416);
            this.panel2.TabIndex = 19;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(681, 237);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 37);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(110, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(20, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlDelUpd
            // 
            this.pnlDelUpd.BackColor = System.Drawing.Color.Transparent;
            this.pnlDelUpd.Controls.Add(this.btnDelete);
            this.pnlDelUpd.Controls.Add(this.btnUpdate);
            this.pnlDelUpd.Location = new System.Drawing.Point(571, 222);
            this.pnlDelUpd.Name = "pnlDelUpd";
            this.pnlDelUpd.Size = new System.Drawing.Size(206, 65);
            this.pnlDelUpd.TabIndex = 20;
            this.pnlDelUpd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Empoyee ID";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtEmployeeName.Enabled = false;
            this.txtEmployeeName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeName.Location = new System.Drawing.Point(590, 172);
            this.txtEmployeeName.MaxLength = 20;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 30);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(428, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Employee Name";
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
            this.btnSearchEmp.Location = new System.Drawing.Point(342, 517);
            this.btnSearchEmp.Margin = new System.Windows.Forms.Padding(8);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Padding = new System.Windows.Forms.Padding(8);
            this.btnSearchEmp.Size = new System.Drawing.Size(35, 35);
            this.btnSearchEmp.TabIndex = 23;
            this.btnSearchEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click_1);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtEmployeeId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txtEmployeeId.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeId.Location = new System.Drawing.Point(200, 517);
            this.txtEmployeeId.MaxLength = 20;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(132, 34);
            this.txtEmployeeId.TabIndex = 22;
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmbLeaveType.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.cmbLeaveType.ForeColor = System.Drawing.Color.White;
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "Personal Leave",
            "Medical Leave",
            "Special Leave"});
            this.cmbLeaveType.Location = new System.Drawing.Point(200, 381);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(178, 31);
            this.cmbLeaveType.TabIndex = 24;
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::PayrollSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.pnlDelUpd);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearchDepenedent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLeaveDateY);
            this.Controls.Add(this.txtLeaveDateM);
            this.Controls.Add(this.txtLeaveDateD);
            this.Controls.Add(this.txtNoOfDays);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtLeaveName);
            this.Controls.Add(this.txtLeaveId);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDelUpd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeaveId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLeaveName;
        private System.Windows.Forms.TextBox txtLeaveDateD;
        private System.Windows.Forms.TextBox txtLeaveDateY;
        private System.Windows.Forms.TextBox txtLeaveDateM;
        private System.Windows.Forms.TextBox txtNoOfDays;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchDepenedent;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDelUpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.ComboBox cmbLeaveType;
    }
}