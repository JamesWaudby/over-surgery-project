namespace OverSurgeryForms
{
    partial class FormMedical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loggedInLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appPanel = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.medicineAddBtn = new System.Windows.Forms.Button();
            this.medicineLbl = new System.Windows.Forms.Label();
            this.medicineCmbBx = new System.Windows.Forms.ComboBox();
            this.endDateTxt = new System.Windows.Forms.TextBox();
            this.startDateTxt = new System.Windows.Forms.TextBox();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.medicineLstBx = new System.Windows.Forms.ListBox();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.savePrescriptionBtn = new System.Windows.Forms.Button();
            this.prescriptionGridView = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPrescriptionBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.saveTestBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addTestBtn = new System.Windows.Forms.Button();
            this.testTypeCmb = new System.Windows.Forms.ComboBox();
            this.testResultTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.testDateTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testGridView = new System.Windows.Forms.DataGridView();
            this.testDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfBirthTxt = new System.Windows.Forms.TextBox();
            this.saveAppointmentBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.appNotesTxt = new System.Windows.Forms.TextBox();
            this.patientLbl = new System.Windows.Forms.Label();
            this.endTxt = new System.Windows.Forms.TextBox();
            this.patientNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loggedInLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(118, 17);
            this.loggedInLabel.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appPanel);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(238, 550);
            this.panel1.TabIndex = 7;
            // 
            // appPanel
            // 
            this.appPanel.AutoScroll = true;
            this.appPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appPanel.Location = new System.Drawing.Point(5, 167);
            this.appPanel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.appPanel.MaximumSize = new System.Drawing.Size(227, 0);
            this.appPanel.Name = "appPanel";
            this.appPanel.Padding = new System.Windows.Forms.Padding(5);
            this.appPanel.Size = new System.Drawing.Size(227, 378);
            this.appPanel.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendar1.Location = new System.Drawing.Point(5, 5);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(238, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 550);
            this.panel2.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.medicineAddBtn);
            this.groupBox3.Controls.Add(this.medicineLbl);
            this.groupBox3.Controls.Add(this.medicineCmbBx);
            this.groupBox3.Controls.Add(this.endDateTxt);
            this.groupBox3.Controls.Add(this.startDateTxt);
            this.groupBox3.Controls.Add(this.endDateLbl);
            this.groupBox3.Controls.Add(this.startDateLbl);
            this.groupBox3.Controls.Add(this.medicineLstBx);
            this.groupBox3.Controls.Add(this.savePrescriptionBtn);
            this.groupBox3.Controls.Add(this.prescriptionGridView);
            this.groupBox3.Controls.Add(this.addPrescriptionBtn);
            this.groupBox3.Location = new System.Drawing.Point(366, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 282);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescriptions";
            // 
            // medicineAddBtn
            // 
            this.medicineAddBtn.Enabled = false;
            this.medicineAddBtn.Location = new System.Drawing.Point(124, 188);
            this.medicineAddBtn.Name = "medicineAddBtn";
            this.medicineAddBtn.Size = new System.Drawing.Size(81, 23);
            this.medicineAddBtn.TabIndex = 17;
            this.medicineAddBtn.Text = "Add Medicine";
            this.medicineAddBtn.UseVisualStyleBackColor = true;
            this.medicineAddBtn.Click += new System.EventHandler(this.medicineAddBtn_Click);
            // 
            // medicineLbl
            // 
            this.medicineLbl.AutoSize = true;
            this.medicineLbl.Location = new System.Drawing.Point(11, 164);
            this.medicineLbl.Name = "medicineLbl";
            this.medicineLbl.Size = new System.Drawing.Size(50, 13);
            this.medicineLbl.TabIndex = 16;
            this.medicineLbl.Text = "Medicine";
            // 
            // medicineCmbBx
            // 
            this.medicineCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicineCmbBx.Enabled = false;
            this.medicineCmbBx.FormattingEnabled = true;
            this.medicineCmbBx.Location = new System.Drawing.Point(67, 161);
            this.medicineCmbBx.Name = "medicineCmbBx";
            this.medicineCmbBx.Size = new System.Drawing.Size(138, 21);
            this.medicineCmbBx.TabIndex = 15;
            this.medicineCmbBx.SelectedIndexChanged += new System.EventHandler(this.medicineCmbBx_SelectedIndexChanged);
            // 
            // endDateTxt
            // 
            this.endDateTxt.Location = new System.Drawing.Point(254, 125);
            this.endDateTxt.Name = "endDateTxt";
            this.endDateTxt.ReadOnly = true;
            this.endDateTxt.Size = new System.Drawing.Size(100, 20);
            this.endDateTxt.TabIndex = 14;
            this.endDateTxt.TextChanged += new System.EventHandler(this.TxtChanged);
            // 
            // startDateTxt
            // 
            this.startDateTxt.Location = new System.Drawing.Point(67, 124);
            this.startDateTxt.Name = "startDateTxt";
            this.startDateTxt.ReadOnly = true;
            this.startDateTxt.Size = new System.Drawing.Size(100, 20);
            this.startDateTxt.TabIndex = 13;
            this.startDateTxt.TextChanged += new System.EventHandler(this.TxtChanged);
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Location = new System.Drawing.Point(196, 127);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(52, 13);
            this.endDateLbl.TabIndex = 12;
            this.endDateLbl.Text = "End Date";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Location = new System.Drawing.Point(6, 128);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(55, 13);
            this.startDateLbl.TabIndex = 11;
            this.startDateLbl.Text = "Start Date";
            // 
            // medicineLstBx
            // 
            this.medicineLstBx.DataSource = this.medicineBindingSource;
            this.medicineLstBx.DisplayMember = "MedicineDetails";
            this.medicineLstBx.Enabled = false;
            this.medicineLstBx.FormattingEnabled = true;
            this.medicineLstBx.Location = new System.Drawing.Point(211, 161);
            this.medicineLstBx.Name = "medicineLstBx";
            this.medicineLstBx.Size = new System.Drawing.Size(143, 82);
            this.medicineLstBx.TabIndex = 10;
            this.medicineLstBx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.medicineLstBx_MouseDoubleClick);
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(OverSurgery.Medicine);
            // 
            // savePrescriptionBtn
            // 
            this.savePrescriptionBtn.Enabled = false;
            this.savePrescriptionBtn.Location = new System.Drawing.Point(230, 250);
            this.savePrescriptionBtn.Name = "savePrescriptionBtn";
            this.savePrescriptionBtn.Size = new System.Drawing.Size(124, 23);
            this.savePrescriptionBtn.TabIndex = 9;
            this.savePrescriptionBtn.Text = "Save Prescription";
            this.savePrescriptionBtn.UseVisualStyleBackColor = true;
            this.savePrescriptionBtn.Click += new System.EventHandler(this.savePrescriptionBtn_Click);
            // 
            // prescriptionGridView
            // 
            this.prescriptionGridView.AllowUserToAddRows = false;
            this.prescriptionGridView.AllowUserToDeleteRows = false;
            this.prescriptionGridView.AutoGenerateColumns = false;
            this.prescriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.prescriptionGridView.DataSource = this.prescriptionBindingSource;
            this.prescriptionGridView.Location = new System.Drawing.Point(6, 19);
            this.prescriptionGridView.Name = "prescriptionGridView";
            this.prescriptionGridView.ReadOnly = true;
            this.prescriptionGridView.RowHeadersVisible = false;
            this.prescriptionGridView.Size = new System.Drawing.Size(348, 93);
            this.prescriptionGridView.TabIndex = 8;
            this.prescriptionGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prescriptionGridView_CellDoubleClick);
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            this.staffIDDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataSource = typeof(OverSurgery.Prescription);
            // 
            // addPrescriptionBtn
            // 
            this.addPrescriptionBtn.Enabled = false;
            this.addPrescriptionBtn.Location = new System.Drawing.Point(100, 250);
            this.addPrescriptionBtn.Name = "addPrescriptionBtn";
            this.addPrescriptionBtn.Size = new System.Drawing.Size(124, 23);
            this.addPrescriptionBtn.TabIndex = 7;
            this.addPrescriptionBtn.Text = "Add Prescription";
            this.addPrescriptionBtn.UseVisualStyleBackColor = true;
            this.addPrescriptionBtn.Click += new System.EventHandler(this.addPrescriptionBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.printBtn);
            this.groupBox2.Controls.Add(this.saveTestBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.addTestBtn);
            this.groupBox2.Controls.Add(this.testTypeCmb);
            this.groupBox2.Controls.Add(this.testResultTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.testDateTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.testGridView);
            this.groupBox2.Location = new System.Drawing.Point(2, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 282);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Results";
            // 
            // printBtn
            // 
            this.printBtn.Enabled = false;
            this.printBtn.Location = new System.Drawing.Point(11, 250);
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
            this.saveTestBtn.Location = new System.Drawing.Point(241, 250);
            this.saveTestBtn.Name = "saveTestBtn";
            this.saveTestBtn.Size = new System.Drawing.Size(109, 23);
            this.saveTestBtn.TabIndex = 16;
            this.saveTestBtn.Text = "Save Test Result";
            this.saveTestBtn.UseVisualStyleBackColor = true;
            this.saveTestBtn.Click += new System.EventHandler(this.saveTestBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Test Type";
            // 
            // addTestBtn
            // 
            this.addTestBtn.Enabled = false;
            this.addTestBtn.Location = new System.Drawing.Point(126, 250);
            this.addTestBtn.Name = "addTestBtn";
            this.addTestBtn.Size = new System.Drawing.Size(109, 23);
            this.addTestBtn.TabIndex = 8;
            this.addTestBtn.Text = "Add Test Result";
            this.addTestBtn.UseVisualStyleBackColor = true;
            this.addTestBtn.Click += new System.EventHandler(this.addTestBtn_Click);
            // 
            // testTypeCmb
            // 
            this.testTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testTypeCmb.Enabled = false;
            this.testTypeCmb.FormattingEnabled = true;
            this.testTypeCmb.Location = new System.Drawing.Point(241, 124);
            this.testTypeCmb.Name = "testTypeCmb";
            this.testTypeCmb.Size = new System.Drawing.Size(109, 21);
            this.testTypeCmb.TabIndex = 14;
            // 
            // testResultTxt
            // 
            this.testResultTxt.Location = new System.Drawing.Point(65, 158);
            this.testResultTxt.Multiline = true;
            this.testResultTxt.Name = "testResultTxt";
            this.testResultTxt.ReadOnly = true;
            this.testResultTxt.Size = new System.Drawing.Size(285, 86);
            this.testResultTxt.TabIndex = 13;
            this.testResultTxt.TextChanged += new System.EventHandler(this.TxtChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Test Result";
            // 
            // testDateTxt
            // 
            this.testDateTxt.Location = new System.Drawing.Point(65, 125);
            this.testDateTxt.Name = "testDateTxt";
            this.testDateTxt.ReadOnly = true;
            this.testDateTxt.Size = new System.Drawing.Size(109, 20);
            this.testDateTxt.TabIndex = 11;
            this.testDateTxt.TextChanged += new System.EventHandler(this.TxtChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 128);
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
            this.testDateDataGridViewTextBoxColumn,
            this.testTypeDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn});
            this.testGridView.DataSource = this.testBindingSource;
            this.testGridView.Location = new System.Drawing.Point(6, 19);
            this.testGridView.Name = "testGridView";
            this.testGridView.ReadOnly = true;
            this.testGridView.RowHeadersVisible = false;
            this.testGridView.Size = new System.Drawing.Size(344, 93);
            this.testGridView.TabIndex = 9;
            this.testGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testGridView_CellDoubleClick);
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
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(OverSurgery.Test);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateOfBirthTxt);
            this.groupBox1.Controls.Add(this.saveAppointmentBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.appNotesTxt);
            this.groupBox1.Controls.Add(this.patientLbl);
            this.groupBox1.Controls.Add(this.endTxt);
            this.groupBox1.Controls.Add(this.patientNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.startTxt);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 251);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date Of Birth";
            // 
            // dateOfBirthTxt
            // 
            this.dateOfBirthTxt.Location = new System.Drawing.Point(277, 22);
            this.dateOfBirthTxt.Name = "dateOfBirthTxt";
            this.dateOfBirthTxt.ReadOnly = true;
            this.dateOfBirthTxt.Size = new System.Drawing.Size(124, 20);
            this.dateOfBirthTxt.TabIndex = 19;
            // 
            // saveAppointmentBtn
            // 
            this.saveAppointmentBtn.Enabled = false;
            this.saveAppointmentBtn.Location = new System.Drawing.Point(590, 222);
            this.saveAppointmentBtn.Name = "saveAppointmentBtn";
            this.saveAppointmentBtn.Size = new System.Drawing.Size(124, 23);
            this.saveAppointmentBtn.TabIndex = 10;
            this.saveAppointmentBtn.Text = "Save Appointment";
            this.saveAppointmentBtn.UseVisualStyleBackColor = true;
            this.saveAppointmentBtn.Click += new System.EventHandler(this.saveAppointmentBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Appointment Information";
            // 
            // appNotesTxt
            // 
            this.appNotesTxt.Location = new System.Drawing.Point(9, 104);
            this.appNotesTxt.Multiline = true;
            this.appNotesTxt.Name = "appNotesTxt";
            this.appNotesTxt.ReadOnly = true;
            this.appNotesTxt.Size = new System.Drawing.Size(705, 112);
            this.appNotesTxt.TabIndex = 17;
            // 
            // patientLbl
            // 
            this.patientLbl.AutoSize = true;
            this.patientLbl.Location = new System.Drawing.Point(6, 25);
            this.patientLbl.Name = "patientLbl";
            this.patientLbl.Size = new System.Drawing.Size(35, 13);
            this.patientLbl.TabIndex = 0;
            this.patientLbl.Text = "Name";
            // 
            // endTxt
            // 
            this.endTxt.Location = new System.Drawing.Point(277, 54);
            this.endTxt.Name = "endTxt";
            this.endTxt.ReadOnly = true;
            this.endTxt.Size = new System.Drawing.Size(124, 20);
            this.endTxt.TabIndex = 5;
            // 
            // patientNameTxt
            // 
            this.patientNameTxt.Location = new System.Drawing.Point(65, 22);
            this.patientNameTxt.Name = "patientNameTxt";
            this.patientNameTxt.ReadOnly = true;
            this.patientNameTxt.Size = new System.Drawing.Size(124, 20);
            this.patientNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time";
            // 
            // startTxt
            // 
            this.startTxt.Location = new System.Drawing.Point(65, 54);
            this.startTxt.Name = "startTxt";
            this.startTxt.ReadOnly = true;
            this.startTxt.Size = new System.Drawing.Size(124, 20);
            this.startTxt.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findPatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // findPatientToolStripMenuItem
            // 
            this.findPatientToolStripMenuItem.Name = "findPatientToolStripMenuItem";
            this.findPatientToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.findPatientToolStripMenuItem.Text = "Find Patient";
            this.findPatientToolStripMenuItem.Click += new System.EventHandler(this.findPatientToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormMedical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMedical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over Surgery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMedical_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripStatusLabel loggedInLabel;
        private System.Windows.Forms.Panel appPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox patientNameTxt;
        private System.Windows.Forms.Label patientLbl;
        private System.Windows.Forms.TextBox endTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addTestBtn;
        private System.Windows.Forms.Button addPrescriptionBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView prescriptionGridView;
        private System.Windows.Forms.DataGridView testGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox testTypeCmb;
        private System.Windows.Forms.TextBox testResultTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testDateTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox appNotesTxt;
        private System.Windows.Forms.Button savePrescriptionBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateOfBirthTxt;
        private System.Windows.Forms.Button saveAppointmentBtn;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveTestBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button medicineAddBtn;
        private System.Windows.Forms.Label medicineLbl;
        private System.Windows.Forms.ComboBox medicineCmbBx;
        private System.Windows.Forms.TextBox endDateTxt;
        private System.Windows.Forms.TextBox startDateTxt;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.ListBox medicineLstBx;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPatientToolStripMenuItem;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}