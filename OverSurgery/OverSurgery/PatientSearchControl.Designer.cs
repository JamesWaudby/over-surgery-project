namespace OverSurgery
{
    partial class PatientSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patientSearchGrp = new System.Windows.Forms.GroupBox();
            this.findPatientBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfBirthSearchTxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.postCodeSearchTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lastNameSearchTxt = new System.Windows.Forms.TextBox();
            this.firstNameSearchTxt = new System.Windows.Forms.TextBox();
            this.patientSearchIDTxt = new System.Windows.Forms.TextBox();
            this.patientSearchGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientSearchGrp
            // 
            this.patientSearchGrp.Controls.Add(this.findPatientBtn);
            this.patientSearchGrp.Controls.Add(this.dataGridView1);
            this.patientSearchGrp.Controls.Add(this.dateOfBirthSearchTxt);
            this.patientSearchGrp.Controls.Add(this.label18);
            this.patientSearchGrp.Controls.Add(this.postCodeSearchTxt);
            this.patientSearchGrp.Controls.Add(this.label19);
            this.patientSearchGrp.Controls.Add(this.label20);
            this.patientSearchGrp.Controls.Add(this.label21);
            this.patientSearchGrp.Controls.Add(this.label22);
            this.patientSearchGrp.Controls.Add(this.lastNameSearchTxt);
            this.patientSearchGrp.Controls.Add(this.firstNameSearchTxt);
            this.patientSearchGrp.Controls.Add(this.patientSearchIDTxt);
            this.patientSearchGrp.Location = new System.Drawing.Point(3, 3);
            this.patientSearchGrp.Name = "patientSearchGrp";
            this.patientSearchGrp.Size = new System.Drawing.Size(499, 214);
            this.patientSearchGrp.TabIndex = 16;
            this.patientSearchGrp.TabStop = false;
            this.patientSearchGrp.Text = "Patient Search";
            // 
            // findPatientBtn
            // 
            this.findPatientBtn.Location = new System.Drawing.Point(346, 74);
            this.findPatientBtn.Name = "findPatientBtn";
            this.findPatientBtn.Size = new System.Drawing.Size(135, 23);
            this.findPatientBtn.TabIndex = 4;
            this.findPatientBtn.Text = "Find Patient";
            this.findPatientBtn.UseVisualStyleBackColor = true;
            //this.findPatientBtn.Click += new System.EventHandler(this.findPatientBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(11, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(470, 101);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // dateOfBirthSearchTxt
            // 
            this.dateOfBirthSearchTxt.Location = new System.Drawing.Point(346, 18);
            this.dateOfBirthSearchTxt.Name = "dateOfBirthSearchTxt";
            this.dateOfBirthSearchTxt.Size = new System.Drawing.Size(135, 20);
            this.dateOfBirthSearchTxt.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(263, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Post Code";
            // 
            // postCodeSearchTxt
            // 
            this.postCodeSearchTxt.Location = new System.Drawing.Point(346, 45);
            this.postCodeSearchTxt.Name = "postCodeSearchTxt";
            this.postCodeSearchTxt.Size = new System.Drawing.Size(135, 20);
            this.postCodeSearchTxt.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Last Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(263, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Date of Birth";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "First Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Patient ID";
            // 
            // lastNameSearchTxt
            // 
            this.lastNameSearchTxt.Location = new System.Drawing.Point(96, 71);
            this.lastNameSearchTxt.Name = "lastNameSearchTxt";
            this.lastNameSearchTxt.Size = new System.Drawing.Size(149, 20);
            this.lastNameSearchTxt.TabIndex = 14;
            // 
            // firstNameSearchTxt
            // 
            this.firstNameSearchTxt.Location = new System.Drawing.Point(96, 45);
            this.firstNameSearchTxt.Name = "firstNameSearchTxt";
            this.firstNameSearchTxt.Size = new System.Drawing.Size(149, 20);
            this.firstNameSearchTxt.TabIndex = 13;
            // 
            // patientSearchIDTxt
            // 
            this.patientSearchIDTxt.Location = new System.Drawing.Point(96, 22);
            this.patientSearchIDTxt.Name = "patientSearchIDTxt";
            this.patientSearchIDTxt.Size = new System.Drawing.Size(149, 20);
            this.patientSearchIDTxt.TabIndex = 12;
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientSearchGrp);
            this.Name = "PatientSearch";
            this.Size = new System.Drawing.Size(508, 223);
            this.patientSearchGrp.ResumeLayout(false);
            this.patientSearchGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patientSearchGrp;
        private System.Windows.Forms.Button findPatientBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dateOfBirthSearchTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox postCodeSearchTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox lastNameSearchTxt;
        private System.Windows.Forms.TextBox firstNameSearchTxt;
        private System.Windows.Forms.TextBox patientSearchIDTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;

    }
}
