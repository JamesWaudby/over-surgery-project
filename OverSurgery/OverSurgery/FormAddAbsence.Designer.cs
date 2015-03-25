namespace OverSurgeryForms
{
    partial class FormAddAbsence
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
            this.staffSelectedBrpBx = new System.Windows.Forms.GroupBox();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.sId = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.staffIdTxt = new System.Windows.Forms.TextBox();
            this.addAbsenceGrpBx = new System.Windows.Forms.GroupBox();
            this.addAbsenceBtn = new System.Windows.Forms.Button();
            this.saveAbsenceBtn = new System.Windows.Forms.Button();
            this.modifyAbsenceBtn = new System.Windows.Forms.Button();
            this.endDateTxt = new System.Windows.Forms.TextBox();
            this.startDateTxt = new System.Windows.Forms.TextBox();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.strDateLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.absenceTypeCmbBx = new System.Windows.Forms.ComboBox();
            this.absenceDataGrid = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.absenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffSelectedBrpBx.SuspendLayout();
            this.addAbsenceGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staffSelectedBrpBx
            // 
            this.staffSelectedBrpBx.Controls.Add(this.absenceDataGrid);
            this.staffSelectedBrpBx.Controls.Add(this.lNameLbl);
            this.staffSelectedBrpBx.Controls.Add(this.lastNameTxt);
            this.staffSelectedBrpBx.Controls.Add(this.fNameLbl);
            this.staffSelectedBrpBx.Controls.Add(this.sId);
            this.staffSelectedBrpBx.Controls.Add(this.firstNameTxt);
            this.staffSelectedBrpBx.Controls.Add(this.staffIdTxt);
            this.staffSelectedBrpBx.Location = new System.Drawing.Point(13, 13);
            this.staffSelectedBrpBx.Name = "staffSelectedBrpBx";
            this.staffSelectedBrpBx.Size = new System.Drawing.Size(411, 188);
            this.staffSelectedBrpBx.TabIndex = 0;
            this.staffSelectedBrpBx.TabStop = false;
            this.staffSelectedBrpBx.Text = "Selected Staff Absences";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Location = new System.Drawing.Point(203, 47);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lNameLbl.TabIndex = 5;
            this.lNameLbl.Text = "Last Name";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(267, 44);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.ReadOnly = true;
            this.lastNameTxt.Size = new System.Drawing.Size(114, 20);
            this.lastNameTxt.TabIndex = 4;
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(6, 47);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(57, 13);
            this.fNameLbl.TabIndex = 3;
            this.fNameLbl.Text = "First Name";
            // 
            // sId
            // 
            this.sId.AutoSize = true;
            this.sId.Location = new System.Drawing.Point(6, 22);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(43, 13);
            this.sId.TabIndex = 2;
            this.sId.Text = "Staff ID";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(72, 44);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.ReadOnly = true;
            this.firstNameTxt.Size = new System.Drawing.Size(114, 20);
            this.firstNameTxt.TabIndex = 1;
            // 
            // staffIdTxt
            // 
            this.staffIdTxt.Location = new System.Drawing.Point(72, 19);
            this.staffIdTxt.Name = "staffIdTxt";
            this.staffIdTxt.ReadOnly = true;
            this.staffIdTxt.Size = new System.Drawing.Size(114, 20);
            this.staffIdTxt.TabIndex = 0;
            // 
            // addAbsenceGrpBx
            // 
            this.addAbsenceGrpBx.Controls.Add(this.addAbsenceBtn);
            this.addAbsenceGrpBx.Controls.Add(this.saveAbsenceBtn);
            this.addAbsenceGrpBx.Controls.Add(this.modifyAbsenceBtn);
            this.addAbsenceGrpBx.Controls.Add(this.endDateTxt);
            this.addAbsenceGrpBx.Controls.Add(this.startDateTxt);
            this.addAbsenceGrpBx.Controls.Add(this.endDateLbl);
            this.addAbsenceGrpBx.Controls.Add(this.strDateLbl);
            this.addAbsenceGrpBx.Controls.Add(this.typeLbl);
            this.addAbsenceGrpBx.Controls.Add(this.absenceTypeCmbBx);
            this.addAbsenceGrpBx.Location = new System.Drawing.Point(13, 208);
            this.addAbsenceGrpBx.Name = "addAbsenceGrpBx";
            this.addAbsenceGrpBx.Size = new System.Drawing.Size(411, 105);
            this.addAbsenceGrpBx.TabIndex = 1;
            this.addAbsenceGrpBx.TabStop = false;
            this.addAbsenceGrpBx.Text = "Absence Tools";
            // 
            // addAbsenceBtn
            // 
            this.addAbsenceBtn.Enabled = false;
            this.addAbsenceBtn.Location = new System.Drawing.Point(255, 19);
            this.addAbsenceBtn.Name = "addAbsenceBtn";
            this.addAbsenceBtn.Size = new System.Drawing.Size(117, 23);
            this.addAbsenceBtn.TabIndex = 13;
            this.addAbsenceBtn.Text = "Add Absence";
            this.addAbsenceBtn.UseVisualStyleBackColor = true;
            this.addAbsenceBtn.Click += new System.EventHandler(this.addAbsenceBtn_Click);
            // 
            // saveAbsenceBtn
            // 
            this.saveAbsenceBtn.Enabled = false;
            this.saveAbsenceBtn.Location = new System.Drawing.Point(255, 46);
            this.saveAbsenceBtn.Name = "saveAbsenceBtn";
            this.saveAbsenceBtn.Size = new System.Drawing.Size(117, 23);
            this.saveAbsenceBtn.TabIndex = 12;
            this.saveAbsenceBtn.Text = "Save Absence";
            this.saveAbsenceBtn.UseVisualStyleBackColor = true;
            this.saveAbsenceBtn.Click += new System.EventHandler(this.saveAbsenceBtn_Click);
            // 
            // modifyAbsenceBtn
            // 
            this.modifyAbsenceBtn.Enabled = false;
            this.modifyAbsenceBtn.Location = new System.Drawing.Point(255, 72);
            this.modifyAbsenceBtn.Name = "modifyAbsenceBtn";
            this.modifyAbsenceBtn.Size = new System.Drawing.Size(117, 23);
            this.modifyAbsenceBtn.TabIndex = 9;
            this.modifyAbsenceBtn.Text = "Remove Absence";
            this.modifyAbsenceBtn.UseVisualStyleBackColor = true;
            this.modifyAbsenceBtn.Click += new System.EventHandler(this.modifyAbsenceBtn_Click);
            // 
            // endDateTxt
            // 
            this.endDateTxt.Location = new System.Drawing.Point(98, 74);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.ReadOnly = true;
            this.endDateTxt.Size = new System.Drawing.Size(114, 20);
            this.endDateTxt.TabIndex = 11;
            // 
            // startDateTxt
            // 
            this.startDateTxt.Location = new System.Drawing.Point(98, 48);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.ReadOnly = true;
            this.startDateTxt.Size = new System.Drawing.Size(114, 20);
            this.startDateTxt.TabIndex = 10;
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(9, 77);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(52, 13);
            this.endDateLbl.TabIndex = 9;
            this.endDateLbl.Text = "End Date";
            // 
            // strDateLbl
            // 
            this.strDateLbl.AutoSize = true;
            this.strDateLbl.Location = new System.Drawing.Point(9, 51);
            this.strDateLbl.Name = "strDateLbl";
            this.strDateLbl.Size = new System.Drawing.Size(55, 13);
            this.strDateLbl.TabIndex = 8;
            this.strDateLbl.Text = "Start Date";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(6, 24);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(76, 13);
            this.typeLbl.TabIndex = 7;
            this.typeLbl.Text = "Absence Type";
            // 
            // absenceTypeCmbBx
            // 
            this.absenceTypeCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.absenceTypeCmbBx.Enabled = false;
            this.absenceTypeCmbBx.FormattingEnabled = true;
            this.absenceTypeCmbBx.Items.AddRange(new object[] {
            "Holiday",
            "Illness",
            "In Surgery",
            "Off Site"});
            this.absenceTypeCmbBx.Location = new System.Drawing.Point(98, 21);
            this.absenceTypeCmbBx.Name = "absenceTypeCmbBx";
            this.absenceTypeCmbBx.Size = new System.Drawing.Size(114, 21);
            this.absenceTypeCmbBx.TabIndex = 0;
            // 
            // absenceDataGrid
            // 
            this.absenceDataGrid.AllowUserToAddRows = false;
            this.absenceDataGrid.AllowUserToDeleteRows = false;
            this.absenceDataGrid.AutoGenerateColumns = false;
            this.absenceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.absenceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.absenceTypeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.absenceDataGrid.DataSource = this.absenceBindingSource1;
            this.absenceDataGrid.Location = new System.Drawing.Point(9, 73);
            this.absenceDataGrid.Name = "absenceDataGrid";
            this.absenceDataGrid.ReadOnly = true;
            this.absenceDataGrid.RowHeadersVisible = false;
            this.absenceDataGrid.Size = new System.Drawing.Size(396, 109);
            this.absenceDataGrid.TabIndex = 6;
            this.absenceDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.absenceDataGrid_CellDoubleClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // absenceTypeDataGridViewTextBoxColumn
            // 
            this.absenceTypeDataGridViewTextBoxColumn.DataPropertyName = "AbsenceType";
            this.absenceTypeDataGridViewTextBoxColumn.HeaderText = "AbsenceType";
            this.absenceTypeDataGridViewTextBoxColumn.Name = "absenceTypeDataGridViewTextBoxColumn";
            this.absenceTypeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // absenceBindingSource1
            // 
            this.absenceBindingSource1.DataSource = typeof(OverSurgery.Absence);
            // 
            // absenceBindingSource
            // 
            this.absenceBindingSource.DataSource = typeof(OverSurgery.Absence);
            // 
            // FormAddAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 326);
            this.Controls.Add(this.addAbsenceGrpBx);
            this.Controls.Add(this.staffSelectedBrpBx);
            this.Name = "FormAddAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an Absence";
            this.staffSelectedBrpBx.ResumeLayout(false);
            this.staffSelectedBrpBx.PerformLayout();
            this.addAbsenceGrpBx.ResumeLayout(false);
            this.addAbsenceGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox staffSelectedBrpBx;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox staffIdTxt;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label sId;
        private System.Windows.Forms.GroupBox addAbsenceGrpBx;
        private System.Windows.Forms.TextBox endDateTxt;
        private System.Windows.Forms.TextBox startDateTxt;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label strDateLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox absenceTypeCmbBx;
        private System.Windows.Forms.Button addAbsenceBtn;
        private System.Windows.Forms.Button saveAbsenceBtn;
        private System.Windows.Forms.Button modifyAbsenceBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource absenceBindingSource;
        private System.Windows.Forms.DataGridView absenceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource absenceBindingSource1;
    }
}