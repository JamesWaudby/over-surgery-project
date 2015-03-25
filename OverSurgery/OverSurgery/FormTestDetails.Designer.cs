using OverSurgery;

namespace OverSurgeryForms
{
    partial class FormTestDetails
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.testTypeCmb = new System.Windows.Forms.ComboBox();
            this.testResultTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.testDateTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testGridView = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printBtn = new System.Windows.Forms.Button();
            this.saveTestBtn = new System.Windows.Forms.Button();
            this.addTestBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.testTypeCmb);
            this.groupBox2.Controls.Add(this.testResultTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.testDateTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.testGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 267);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Test Type";
            // 
            // testTypeCmb
            // 
            this.testTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testTypeCmb.Enabled = false;
            this.testTypeCmb.FormattingEnabled = true;
            this.testTypeCmb.Location = new System.Drawing.Point(239, 131);
            this.testTypeCmb.Name = "testTypeCmb";
            this.testTypeCmb.Size = new System.Drawing.Size(91, 21);
            this.testTypeCmb.TabIndex = 14;
            // 
            // testResultTxt
            // 
            this.testResultTxt.Location = new System.Drawing.Point(75, 167);
            this.testResultTxt.Multiline = true;
            this.testResultTxt.Name = "testResultTxt";
            this.testResultTxt.ReadOnly = true;
            this.testResultTxt.Size = new System.Drawing.Size(255, 86);
            this.testResultTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Test Result";
            // 
            // testDateTxt
            // 
            this.testDateTxt.Location = new System.Drawing.Point(75, 131);
            this.testDateTxt.Name = "testDateTxt";
            this.testDateTxt.ReadOnly = true;
            this.testDateTxt.Size = new System.Drawing.Size(91, 20);
            this.testDateTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Test Date";
            // 
            // testGridView
            // 
            this.testGridView.AllowUserToAddRows = false;
            this.testGridView.AllowUserToDeleteRows = false;
            this.testGridView.AutoGenerateColumns = false;
            this.testGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.testDateDataGridViewTextBoxColumn,
            this.testTypeDataGridViewTextBoxColumn});
            this.testGridView.DataSource = this.testBindingSource;
            this.testGridView.Location = new System.Drawing.Point(20, 19);
            this.testGridView.Name = "testGridView";
            this.testGridView.ReadOnly = true;
            this.testGridView.RowHeadersVisible = false;
            this.testGridView.Size = new System.Drawing.Size(310, 93);
            this.testGridView.TabIndex = 9;
            this.testGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testGridView_CellDoubleClick);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testDateDataGridViewTextBoxColumn
            // 
            this.testDateDataGridViewTextBoxColumn.DataPropertyName = "TestDate";
            this.testDateDataGridViewTextBoxColumn.HeaderText = "TestDate";
            this.testDateDataGridViewTextBoxColumn.Name = "testDateDataGridViewTextBoxColumn";
            this.testDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testTypeDataGridViewTextBoxColumn
            // 
            this.testTypeDataGridViewTextBoxColumn.DataPropertyName = "TestType";
            this.testTypeDataGridViewTextBoxColumn.HeaderText = "TestType";
            this.testTypeDataGridViewTextBoxColumn.Name = "testTypeDataGridViewTextBoxColumn";
            this.testTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(OverSurgery.Test);
            // 
            // printBtn
            // 
            this.printBtn.Enabled = false;
            this.printBtn.Location = new System.Drawing.Point(15, 285);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(109, 23);
            this.printBtn.TabIndex = 17;
            this.printBtn.Text = "Print Test";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // saveTestBtn
            // 
            this.saveTestBtn.Enabled = false;
            this.saveTestBtn.Location = new System.Drawing.Point(245, 285);
            this.saveTestBtn.Name = "saveTestBtn";
            this.saveTestBtn.Size = new System.Drawing.Size(109, 23);
            this.saveTestBtn.TabIndex = 16;
            this.saveTestBtn.Text = "Save Test Result";
            this.saveTestBtn.UseVisualStyleBackColor = true;
            this.saveTestBtn.Click += new System.EventHandler(this.saveTestBtn_Click);
            // 
            // addTestBtn
            // 
            this.addTestBtn.Enabled = false;
            this.addTestBtn.Location = new System.Drawing.Point(130, 285);
            this.addTestBtn.Name = "addTestBtn";
            this.addTestBtn.Size = new System.Drawing.Size(109, 23);
            this.addTestBtn.TabIndex = 8;
            this.addTestBtn.Text = "Add Test Result";
            this.addTestBtn.UseVisualStyleBackColor = true;
            this.addTestBtn.Click += new System.EventHandler(this.addTestBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormTestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 317);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.saveTestBtn);
            this.Controls.Add(this.addTestBtn);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormTestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTestDetails";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox testTypeCmb;
        private System.Windows.Forms.TextBox testResultTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testDateTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView testGridView;
        private System.Windows.Forms.Button saveTestBtn;
        private System.Windows.Forms.Button addTestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}