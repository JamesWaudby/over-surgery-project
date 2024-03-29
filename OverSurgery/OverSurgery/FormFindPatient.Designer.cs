﻿namespace OverSurgeryForms
{
    partial class FormFindPatient
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
            this.components = new System.ComponentModel.Container();
            this.patientDetailsGrpBx = new System.Windows.Forms.GroupBox();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.postCodeTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.countyTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.address2Txt = new System.Windows.Forms.TextBox();
            this.address1Txt = new System.Windows.Forms.TextBox();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.dobTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.patientIDTxt = new System.Windows.Forms.TextBox();
            this.patientToolsGrpBx = new System.Windows.Forms.GroupBox();
            this.viewPrescriptionsBtn = new System.Windows.Forms.Button();
            this.viewResultsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.patientSearch = new OverSurgeryForms.PatientSearch();
            this.patientDetailsGrpBx.SuspendLayout();
            this.patientToolsGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDetailsGrpBx
            // 
            this.patientDetailsGrpBx.Controls.Add(this.genderCmb);
            this.patientDetailsGrpBx.Controls.Add(this.label13);
            this.patientDetailsGrpBx.Controls.Add(this.label12);
            this.patientDetailsGrpBx.Controls.Add(this.label11);
            this.patientDetailsGrpBx.Controls.Add(this.label10);
            this.patientDetailsGrpBx.Controls.Add(this.label9);
            this.patientDetailsGrpBx.Controls.Add(this.label8);
            this.patientDetailsGrpBx.Controls.Add(this.label7);
            this.patientDetailsGrpBx.Controls.Add(this.label6);
            this.patientDetailsGrpBx.Controls.Add(this.label5);
            this.patientDetailsGrpBx.Controls.Add(this.label4);
            this.patientDetailsGrpBx.Controls.Add(this.label3);
            this.patientDetailsGrpBx.Controls.Add(this.label2);
            this.patientDetailsGrpBx.Controls.Add(this.label1);
            this.patientDetailsGrpBx.Controls.Add(this.postCodeTxt);
            this.patientDetailsGrpBx.Controls.Add(this.emailTxt);
            this.patientDetailsGrpBx.Controls.Add(this.countyTxt);
            this.patientDetailsGrpBx.Controls.Add(this.cityTxt);
            this.patientDetailsGrpBx.Controls.Add(this.address2Txt);
            this.patientDetailsGrpBx.Controls.Add(this.address1Txt);
            this.patientDetailsGrpBx.Controls.Add(this.statusTxt);
            this.patientDetailsGrpBx.Controls.Add(this.telTxt);
            this.patientDetailsGrpBx.Controls.Add(this.dobTxt);
            this.patientDetailsGrpBx.Controls.Add(this.lastNameTxt);
            this.patientDetailsGrpBx.Controls.Add(this.firstNameTxt);
            this.patientDetailsGrpBx.Controls.Add(this.patientIDTxt);
            this.patientDetailsGrpBx.Location = new System.Drawing.Point(16, 236);
            this.patientDetailsGrpBx.Name = "patientDetailsGrpBx";
            this.patientDetailsGrpBx.Size = new System.Drawing.Size(499, 222);
            this.patientDetailsGrpBx.TabIndex = 2;
            this.patientDetailsGrpBx.TabStop = false;
            this.patientDetailsGrpBx.Text = "Patient Details";
            // 
            // genderCmb
            // 
            this.genderCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCmb.Enabled = false;
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCmb.Location = new System.Drawing.Point(105, 107);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(140, 21);
            this.genderCmb.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Email Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(263, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Post Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "County";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Address Line 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Address Line 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Telephone No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Marital Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Patient ID";
            // 
            // postCodeTxt
            // 
            this.postCodeTxt.Location = new System.Drawing.Point(346, 134);
            this.postCodeTxt.Name = "postCodeTxt";
            this.postCodeTxt.ReadOnly = true;
            this.postCodeTxt.Size = new System.Drawing.Size(135, 20);
            this.postCodeTxt.TabIndex = 17;
            this.postCodeTxt.TabStop = false;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(346, 160);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.ReadOnly = true;
            this.emailTxt.Size = new System.Drawing.Size(135, 20);
            this.emailTxt.TabIndex = 18;
            this.emailTxt.TabStop = false;
            // 
            // countyTxt
            // 
            this.countyTxt.Location = new System.Drawing.Point(346, 108);
            this.countyTxt.Name = "countyTxt";
            this.countyTxt.ReadOnly = true;
            this.countyTxt.Size = new System.Drawing.Size(135, 20);
            this.countyTxt.TabIndex = 16;
            this.countyTxt.TabStop = false;
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(346, 82);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.ReadOnly = true;
            this.cityTxt.Size = new System.Drawing.Size(135, 20);
            this.cityTxt.TabIndex = 15;
            this.cityTxt.TabStop = false;
            // 
            // address2Txt
            // 
            this.address2Txt.Location = new System.Drawing.Point(346, 56);
            this.address2Txt.Name = "address2Txt";
            this.address2Txt.ReadOnly = true;
            this.address2Txt.Size = new System.Drawing.Size(135, 20);
            this.address2Txt.TabIndex = 14;
            this.address2Txt.TabStop = false;
            // 
            // address1Txt
            // 
            this.address1Txt.Location = new System.Drawing.Point(346, 30);
            this.address1Txt.Name = "address1Txt";
            this.address1Txt.ReadOnly = true;
            this.address1Txt.Size = new System.Drawing.Size(135, 20);
            this.address1Txt.TabIndex = 13;
            this.address1Txt.TabStop = false;
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(105, 160);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(140, 20);
            this.statusTxt.TabIndex = 11;
            this.statusTxt.TabStop = false;
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(105, 186);
            this.telTxt.Name = "telTxt";
            this.telTxt.ReadOnly = true;
            this.telTxt.Size = new System.Drawing.Size(140, 20);
            this.telTxt.TabIndex = 12;
            this.telTxt.TabStop = false;
            // 
            // dobTxt
            // 
            this.dobTxt.Location = new System.Drawing.Point(105, 134);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.ReadOnly = true;
            this.dobTxt.Size = new System.Drawing.Size(140, 20);
            this.dobTxt.TabIndex = 10;
            this.dobTxt.TabStop = false;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(105, 82);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.ReadOnly = true;
            this.lastNameTxt.Size = new System.Drawing.Size(140, 20);
            this.lastNameTxt.TabIndex = 8;
            this.lastNameTxt.TabStop = false;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(105, 56);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.ReadOnly = true;
            this.firstNameTxt.Size = new System.Drawing.Size(140, 20);
            this.firstNameTxt.TabIndex = 7;
            this.firstNameTxt.TabStop = false;
            // 
            // patientIDTxt
            // 
            this.patientIDTxt.Location = new System.Drawing.Point(105, 30);
            this.patientIDTxt.Name = "patientIDTxt";
            this.patientIDTxt.ReadOnly = true;
            this.patientIDTxt.Size = new System.Drawing.Size(140, 20);
            this.patientIDTxt.TabIndex = 6;
            this.patientIDTxt.TabStop = false;
            // 
            // patientToolsGrpBx
            // 
            this.patientToolsGrpBx.Controls.Add(this.viewPrescriptionsBtn);
            this.patientToolsGrpBx.Controls.Add(this.viewResultsBtn);
            this.patientToolsGrpBx.Controls.Add(this.dataGridView1);
            this.patientToolsGrpBx.Location = new System.Drawing.Point(16, 465);
            this.patientToolsGrpBx.Name = "patientToolsGrpBx";
            this.patientToolsGrpBx.Size = new System.Drawing.Size(499, 139);
            this.patientToolsGrpBx.TabIndex = 3;
            this.patientToolsGrpBx.TabStop = false;
            this.patientToolsGrpBx.Text = "Patient Tools";
            // 
            // viewPrescriptionsBtn
            // 
            this.viewPrescriptionsBtn.Enabled = false;
            this.viewPrescriptionsBtn.Location = new System.Drawing.Point(322, 48);
            this.viewPrescriptionsBtn.Name = "viewPrescriptionsBtn";
            this.viewPrescriptionsBtn.Size = new System.Drawing.Size(171, 23);
            this.viewPrescriptionsBtn.TabIndex = 5;
            this.viewPrescriptionsBtn.Text = "View Prescriptions";
            this.viewPrescriptionsBtn.UseVisualStyleBackColor = true;
            this.viewPrescriptionsBtn.Click += new System.EventHandler(this.viewPrescriptionsBtn_Click);
            // 
            // viewResultsBtn
            // 
            this.viewResultsBtn.Enabled = false;
            this.viewResultsBtn.Location = new System.Drawing.Point(322, 19);
            this.viewResultsBtn.Name = "viewResultsBtn";
            this.viewResultsBtn.Size = new System.Drawing.Size(171, 23);
            this.viewResultsBtn.TabIndex = 2;
            this.viewResultsBtn.Text = "View Test Results";
            this.viewResultsBtn.UseVisualStyleBackColor = true;
            this.viewResultsBtn.Click += new System.EventHandler(this.viewResultsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(303, 110);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // staffDataGridViewTextBoxColumn
            // 
            this.staffDataGridViewTextBoxColumn.DataPropertyName = "Staff";
            this.staffDataGridViewTextBoxColumn.HeaderText = "Staff";
            this.staffDataGridViewTextBoxColumn.Name = "staffDataGridViewTextBoxColumn";
            this.staffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(OverSurgery.Appointment);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(396, 621);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(117, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(273, 621);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Patient";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Enabled = false;
            this.modifyBtn.Location = new System.Drawing.Point(150, 621);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(117, 23);
            this.modifyBtn.TabIndex = 6;
            this.modifyBtn.Text = "Modify Patient";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // patientSearch
            // 
            this.patientSearch.AutoSize = true;
            this.patientSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.patientSearch.Location = new System.Drawing.Point(13, 13);
            this.patientSearch.Name = "patientSearch";
            this.patientSearch.Size = new System.Drawing.Size(502, 217);
            this.patientSearch.TabIndex = 0;
            // 
            // FormFindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(524, 656);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.patientToolsGrpBx);
            this.Controls.Add(this.patientDetailsGrpBx);
            this.Controls.Add(this.patientSearch);
            this.Name = "FormFindPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFindPatient";
            this.patientDetailsGrpBx.ResumeLayout(false);
            this.patientDetailsGrpBx.PerformLayout();
            this.patientToolsGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OverSurgeryForms.PatientSearch patientSearch;
        private System.Windows.Forms.GroupBox patientDetailsGrpBx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox postCodeTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox countyTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox address2Txt;
        private System.Windows.Forms.TextBox address1Txt;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.TextBox dobTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox patientIDTxt;
        private System.Windows.Forms.GroupBox patientToolsGrpBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewResultsBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.Button viewPrescriptionsBtn;

    }
}