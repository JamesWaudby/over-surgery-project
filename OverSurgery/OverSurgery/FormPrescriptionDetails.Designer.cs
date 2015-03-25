using OverSurgery;

namespace OverSurgeryForms
{
    partial class FormPrescriptionDetails
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.endDateTxt = new System.Windows.Forms.TextBox();
            this.startDateTxt = new System.Windows.Forms.TextBox();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.medicineLstBx = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extendPrescriptionBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.endDateTxt);
            this.groupBox3.Controls.Add(this.startDateTxt);
            this.groupBox3.Controls.Add(this.endDateLbl);
            this.groupBox3.Controls.Add(this.startDateLbl);
            this.groupBox3.Controls.Add(this.medicineLstBx);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 259);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescriptions";
            // 
            // endDateTxt
            // 
            this.endDateTxt.Location = new System.Drawing.Point(266, 122);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.ReadOnly = true;
            this.endDateTxt.Size = new System.Drawing.Size(117, 20);
            this.endDateTxt.TabIndex = 14;
            // 
            // startDateTxt
            // 
            this.startDateTxt.Location = new System.Drawing.Point(78, 122);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.ReadOnly = true;
            this.startDateTxt.Size = new System.Drawing.Size(98, 20);
            this.startDateTxt.TabIndex = 13;
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(192, 125);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(52, 13);
            this.endDateLbl.TabIndex = 12;
            this.endDateLbl.Text = "End Date";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(17, 125);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(55, 13);
            this.startDateLbl.TabIndex = 11;
            this.startDateLbl.Text = "Start Date";
            // 
            // medicineLstBx
            // 
            this.medicineLstBx.DisplayMember = "MedicineDetails";
            this.medicineLstBx.FormattingEnabled = true;
            this.medicineLstBx.Location = new System.Drawing.Point(20, 159);
            this.medicineLstBx.Name = "medicineLstBx";
            this.medicineLstBx.Size = new System.Drawing.Size(363, 82);
            this.medicineLstBx.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.extendedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.prescriptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(363, 93);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // extendedDataGridViewCheckBoxColumn
            // 
            this.extendedDataGridViewCheckBoxColumn.DataPropertyName = "Extended";
            this.extendedDataGridViewCheckBoxColumn.HeaderText = "Extended";
            this.extendedDataGridViewCheckBoxColumn.Name = "extendedDataGridViewCheckBoxColumn";
            this.extendedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataSource = typeof(OverSurgery.Prescription);
            // 
            // extendPrescriptionBtn
            // 
            this.extendPrescriptionBtn.Enabled = false;
            this.extendPrescriptionBtn.Location = new System.Drawing.Point(175, 277);
            this.extendPrescriptionBtn.Name = "extendPrescriptionBtn";
            this.extendPrescriptionBtn.Size = new System.Drawing.Size(117, 23);
            this.extendPrescriptionBtn.TabIndex = 14;
            this.extendPrescriptionBtn.Text = "Extend Prescription";
            this.extendPrescriptionBtn.UseVisualStyleBackColor = true;
            this.extendPrescriptionBtn.Click += new System.EventHandler(this.extendPrescriptionBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(298, 277);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(117, 23);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FormPrescriptionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(426, 310);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.extendPrescriptionBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormPrescriptionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrescriptionDetails";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox endDateTxt;
        private System.Windows.Forms.TextBox startDateTxt;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.ListBox medicineLstBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button extendPrescriptionBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn extendedDataGridViewCheckBoxColumn;
    }
}