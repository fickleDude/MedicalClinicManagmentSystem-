﻿namespace Medical_Clinic
{
    partial class DoctorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dentalMedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clinicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WelcomeGB = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TODOGB = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminAppointments = new System.Windows.Forms.TextBox();
            this.STATISTICSGB = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AdminServices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdminDoctors = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminUsers = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.WelcomeGB.SuspendLayout();
            this.TODOGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.STATISTICSGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.dentalMedToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem1,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem});
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.myProfileToolStripMenuItem.Text = "Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem1
            // 
            this.myProfileToolStripMenuItem1.Name = "myProfileToolStripMenuItem1";
            this.myProfileToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.myProfileToolStripMenuItem1.Text = "My Profile";
            this.myProfileToolStripMenuItem1.Click += new System.EventHandler(this.myProfileToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dentalMedToolStripMenuItem
            // 
            this.dentalMedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clinicToolStripMenuItem});
            this.dentalMedToolStripMenuItem.Name = "dentalMedToolStripMenuItem";
            this.dentalMedToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dentalMedToolStripMenuItem.Text = "DentalMed";
            // 
            // clinicToolStripMenuItem
            // 
            this.clinicToolStripMenuItem.Name = "clinicToolStripMenuItem";
            this.clinicToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.clinicToolStripMenuItem.Text = "Clinic";
            this.clinicToolStripMenuItem.Click += new System.EventHandler(this.clinicToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // WelcomeGB
            // 
            this.WelcomeGB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.WelcomeGB.Controls.Add(this.label8);
            this.WelcomeGB.Location = new System.Drawing.Point(0, 27);
            this.WelcomeGB.Name = "WelcomeGB";
            this.WelcomeGB.Size = new System.Drawing.Size(800, 88);
            this.WelcomeGB.TabIndex = 6;
            this.WelcomeGB.TabStop = false;
            this.WelcomeGB.Text = "Welcome!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(148, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(478, 50);
            this.label8.TabIndex = 0;
            this.label8.Text = "WELCOME TO DENTALMED!";
            // 
            // TODOGB
            // 
            this.TODOGB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TODOGB.Controls.Add(this.groupBox2);
            this.TODOGB.Controls.Add(this.label1);
            this.TODOGB.Controls.Add(this.AdminAppointments);
            this.TODOGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TODOGB.Location = new System.Drawing.Point(24, 363);
            this.TODOGB.Name = "TODOGB";
            this.TODOGB.Size = new System.Drawing.Size(471, 75);
            this.TODOGB.TabIndex = 7;
            this.TODOGB.TabStop = false;
            this.TODOGB.Text = "TODAY YOU WILL COVER";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(496, -116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 246);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TODAY YOU WILL COVER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Orders";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 29);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Appointments";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 29);
            this.textBox4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Appointments";
            // 
            // AdminAppointments
            // 
            this.AdminAppointments.Location = new System.Drawing.Point(206, 29);
            this.AdminAppointments.Name = "AdminAppointments";
            this.AdminAppointments.ReadOnly = true;
            this.AdminAppointments.Size = new System.Drawing.Size(248, 29);
            this.AdminAppointments.TabIndex = 0;
            // 
            // STATISTICSGB
            // 
            this.STATISTICSGB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.STATISTICSGB.Controls.Add(this.label7);
            this.STATISTICSGB.Controls.Add(this.AdminServices);
            this.STATISTICSGB.Controls.Add(this.label6);
            this.STATISTICSGB.Controls.Add(this.AdminDoctors);
            this.STATISTICSGB.Controls.Add(this.label5);
            this.STATISTICSGB.Controls.Add(this.AdminUsers);
            this.STATISTICSGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.STATISTICSGB.Location = new System.Drawing.Point(526, 307);
            this.STATISTICSGB.Name = "STATISTICSGB";
            this.STATISTICSGB.Size = new System.Drawing.Size(255, 131);
            this.STATISTICSGB.TabIndex = 5;
            this.STATISTICSGB.TabStop = false;
            this.STATISTICSGB.Text = "STATISTICS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Our Services";
            // 
            // AdminServices
            // 
            this.AdminServices.Location = new System.Drawing.Point(111, 93);
            this.AdminServices.Name = "AdminServices";
            this.AdminServices.ReadOnly = true;
            this.AdminServices.Size = new System.Drawing.Size(123, 29);
            this.AdminServices.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Our Doctors";
            // 
            // AdminDoctors
            // 
            this.AdminDoctors.Location = new System.Drawing.Point(111, 58);
            this.AdminDoctors.Name = "AdminDoctors";
            this.AdminDoctors.ReadOnly = true;
            this.AdminDoctors.Size = new System.Drawing.Size(123, 29);
            this.AdminDoctors.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Our Users";
            // 
            // AdminUsers
            // 
            this.AdminUsers.Location = new System.Drawing.Point(111, 23);
            this.AdminUsers.Name = "AdminUsers";
            this.AdminUsers.ReadOnly = true;
            this.AdminUsers.Size = new System.Drawing.Size(123, 29);
            this.AdminUsers.TabIndex = 0;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medical_Clinic.Properties.Resources.dental_speed3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.STATISTICSGB);
            this.Controls.Add(this.TODOGB);
            this.Controls.Add(this.WelcomeGB);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.WelcomeGB.ResumeLayout(false);
            this.WelcomeGB.PerformLayout();
            this.TODOGB.ResumeLayout(false);
            this.TODOGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.STATISTICSGB.ResumeLayout(false);
            this.STATISTICSGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem myProfileToolStripMenuItem;
        private ToolStripMenuItem myProfileToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem dentalMedToolStripMenuItem;
        private ToolStripMenuItem clinicToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private GroupBox WelcomeGB;
        private Label label8;
        private GroupBox TODOGB;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label1;
        private TextBox AdminAppointments;
        private GroupBox STATISTICSGB;
        private Label label7;
        private TextBox AdminServices;
        private Label label6;
        private TextBox AdminDoctors;
        private Label label5;
        private TextBox AdminUsers;
    }
}