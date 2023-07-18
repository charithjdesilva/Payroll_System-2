namespace PayrollSystem
{
    partial class FacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFacultyid = new System.Windows.Forms.TextBox();
            this.txtFacStartD = new System.Windows.Forms.TextBox();
            this.txtFacStartM = new System.Windows.Forms.TextBox();
            this.txtFacStartY = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtAllFaculties = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchFac = new System.Windows.Forms.Button();
            this.pnlDelUpd = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlDelUpd.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 145);
            this.panel1.TabIndex = 13;
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
            this.btnSettings.Location = new System.Drawing.Point(739, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            this.btnHome.TabIndex = 9;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "Faculty Started Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "Faculty Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Faculty Id";
            // 
            // txtFacultyid
            // 
            this.txtFacultyid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacultyid.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyid.ForeColor = System.Drawing.Color.White;
            this.txtFacultyid.Location = new System.Drawing.Point(286, 167);
            this.txtFacultyid.MaxLength = 20;
            this.txtFacultyid.Name = "txtFacultyid";
            this.txtFacultyid.Size = new System.Drawing.Size(138, 34);
            this.txtFacultyid.TabIndex = 0;
            // 
            // txtFacStartD
            // 
            this.txtFacStartD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacStartD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacStartD.ForeColor = System.Drawing.Color.White;
            this.txtFacStartD.Location = new System.Drawing.Point(286, 306);
            this.txtFacStartD.MaxLength = 20;
            this.txtFacStartD.Name = "txtFacStartD";
            this.txtFacStartD.Size = new System.Drawing.Size(41, 34);
            this.txtFacStartD.TabIndex = 4;
            // 
            // txtFacStartM
            // 
            this.txtFacStartM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacStartM.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacStartM.ForeColor = System.Drawing.Color.White;
            this.txtFacStartM.Location = new System.Drawing.Point(333, 306);
            this.txtFacStartM.MaxLength = 20;
            this.txtFacStartM.Name = "txtFacStartM";
            this.txtFacStartM.Size = new System.Drawing.Size(41, 34);
            this.txtFacStartM.TabIndex = 5;
            // 
            // txtFacStartY
            // 
            this.txtFacStartY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacStartY.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacStartY.ForeColor = System.Drawing.Color.White;
            this.txtFacStartY.Location = new System.Drawing.Point(380, 306);
            this.txtFacStartY.MaxLength = 20;
            this.txtFacStartY.Name = "txtFacStartY";
            this.txtFacStartY.Size = new System.Drawing.Size(83, 34);
            this.txtFacStartY.TabIndex = 6;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtFacultyName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyName.ForeColor = System.Drawing.Color.White;
            this.txtFacultyName.Location = new System.Drawing.Point(286, 236);
            this.txtFacultyName.MaxLength = 100;
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(177, 34);
            this.txtFacultyName.TabIndex = 0;
            // 
            // txtAllFaculties
            // 
            this.txtAllFaculties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtAllFaculties.Enabled = false;
            this.txtAllFaculties.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllFaculties.ForeColor = System.Drawing.Color.White;
            this.txtAllFaculties.Location = new System.Drawing.Point(513, 199);
            this.txtAllFaculties.MaxLength = 200;
            this.txtAllFaculties.Multiline = true;
            this.txtAllFaculties.Name = "txtAllFaculties";
            this.txtAllFaculties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllFaculties.Size = new System.Drawing.Size(258, 212);
            this.txtAllFaculties.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(508, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "All Faculties";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(488, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 416);
            this.panel2.TabIndex = 27;
            // 
            // btnSearchFac
            // 
            this.btnSearchFac.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnSearchFac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSearchFac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFac.ForeColor = System.Drawing.Color.White;
            this.btnSearchFac.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFac.Image")));
            this.btnSearchFac.Location = new System.Drawing.Point(429, 166);
            this.btnSearchFac.Margin = new System.Windows.Forms.Padding(8);
            this.btnSearchFac.Name = "btnSearchFac";
            this.btnSearchFac.Padding = new System.Windows.Forms.Padding(8);
            this.btnSearchFac.Size = new System.Drawing.Size(34, 35);
            this.btnSearchFac.TabIndex = 28;
            this.btnSearchFac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchFac.UseVisualStyleBackColor = false;
            this.btnSearchFac.Click += new System.EventHandler(this.btnSearchFac_Click);
            // 
            // pnlDelUpd
            // 
            this.pnlDelUpd.BackColor = System.Drawing.Color.Transparent;
            this.pnlDelUpd.Controls.Add(this.btnDelete);
            this.pnlDelUpd.Controls.Add(this.btnUpdate);
            this.pnlDelUpd.Location = new System.Drawing.Point(257, 360);
            this.pnlDelUpd.Name = "pnlDelUpd";
            this.pnlDelUpd.Size = new System.Drawing.Size(206, 65);
            this.pnlDelUpd.TabIndex = 30;
            this.pnlDelUpd.Visible = false;
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(367, 375);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 37);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::PayrollSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearchFac);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtAllFaculties);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFacStartY);
            this.Controls.Add(this.txtFacStartM);
            this.Controls.Add(this.txtFacStartD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFacultyName);
            this.Controls.Add(this.txtFacultyid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDelUpd);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyForm";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFacultyid;
        private System.Windows.Forms.TextBox txtFacStartD;
        private System.Windows.Forms.TextBox txtFacStartM;
        private System.Windows.Forms.TextBox txtFacStartY;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtAllFaculties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchFac;
        private System.Windows.Forms.Panel pnlDelUpd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnSettings;
    }
}