using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OverSurgery;
using OverSurgery.Properties;
using System.Drawing.Printing;

namespace OverSurgeryForms
{
    public partial class FormMedical : Form
    {
        private MedicalController _medicalController;
        private Staff _staff;
        private Patient _patient;
        private Appointment _appointment;
        private Test _test;
        private Prescription _prescription;
        private List<Medicine> _medicines;

        public FormMedical()
        {
            InitializeComponent();

            _medicalController = new MedicalController();
            _staff = UserSession.Instance().CurrentUser;
            _medicines = new List<Medicine>();

            FormRefreshCalendar();

            // Shows the currently logged in user's name in the status bar.
            loggedInLabel.Text = "Logged In As: " + UserSession.Instance().CurrentUser.ToString();
            testTypeCmb.DataSource = Enum.GetValues(typeof(TestType));
        }

        public void FormRefreshCalendar()
        {
            this.ActiveControl = appPanel;
            appPanel.Controls.Clear();
            appPanel.SuspendLayout();

            // Only for days that aren't sunday
            if (monthCalendar1.SelectionRange.Start.DayOfWeek != DayOfWeek.Sunday)
            {
                // Get each staff member's appointments
                _staff.Appointments = _medicalController.GetStaffAvailability(_staff, monthCalendar1.SelectionRange.Start);

                // Get the Patient's details to display patient name etc
                foreach (Appointment a in _staff.Appointments)
                {
                    a.Patient = _medicalController.GetPatientDetails(a.PatientID);
                }

                // Create a new flow panel for each of the doctors
                AppointmentFlowPanel newFlowPanel = new AppointmentFlowPanel(_staff, monthCalendar1.SelectionRange.Start, this);

                // Add event handlers to the labels
                newFlowPanel.LabelDoubleClicked += AppointmentClicked;
                appPanel.Controls.Add(newFlowPanel);
            }

            appPanel.ResumeLayout();
        }

        public void FormRefresh()
        {
            if (_patient != null)
            {
                // Retrieve Patient Information
                _patient.Tests = _medicalController.GetPatientTests(_patient.PatientID);

                // Load Prescriptions
                _patient.Prescriptions = _medicalController.GetPatientPrescriptions(_patient.PatientID);

                // Tests datagridview
                BindingSource bindingSource = testBindingSource;
                bindingSource.DataSource = _patient.Tests;
                testGridView.DataSource = bindingSource;

                // Prescription Datagridview
                BindingSource bindingSourcePrescriptions = prescriptionBindingSource;
                bindingSourcePrescriptions.DataSource = _patient.Prescriptions;
                prescriptionGridView.DataSource = bindingSourcePrescriptions;

                // Allow doctors to add new prescriptions
                if (_staff.Permissions == PermissionsFlag.Doctor)
                {
                    addPrescriptionBtn.Enabled = true;
                }

                // Refresh the grid
                testGridView.Refresh();
                prescriptionGridView.Refresh();
            }
        }

        public void AppointmentClicked(AppointmentLabel sender, EventArgs e)
        {
            AppointmentLabel ap = sender;
            _appointment = ap.Appointment;

            if (ap.Appointment != null)
            {
                _patient = ap.Appointment.Patient;

                // Fill in form details
                patientNameTxt.Text = _patient.ToString();
                dateOfBirthTxt.Text = _patient.DateOfBirth.ToShortDateString();
                startTxt.Text = _appointment.StartDate.ToShortTimeString();
                endTxt.Text = _appointment.EndDate.ToShortTimeString();
                appNotesTxt.Text = _appointment.AppointmentNotes;
                appNotesTxt.ReadOnly = true;

                // Change form fields
                addTestBtn.Enabled = true;

                if (_appointment.StartDate >= DateTime.Now)
                {
                    addPrescriptionBtn.Enabled = true;
                    appNotesTxt.ReadOnly = false;
                    saveAppointmentBtn.Enabled = true;
                }

                FormRefresh();
            }
            else
            {
                patientNameTxt.Text = "";
                startTxt.Text = "";
                endTxt.Text = "";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            FormRefreshCalendar();
        }

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            printBtn.Enabled = false;

            testDateTxt.Text = "";
            testDateTxt.ReadOnly = false;

            testResultTxt.Text = "";
            testResultTxt.ReadOnly = false;

            testDateTxt.BackColor = Color.White;
            testResultTxt.BackColor = Color.White;

            testTypeCmb.Enabled = true;

            saveTestBtn.Enabled = true;
        }

        private void testGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check it's a row and not column header
            if (e.RowIndex > -1)
            {
                // Set tests to patient test
                _test = _patient.Tests[e.RowIndex];

                testDateTxt.Text = _test.TestDate.ToShortDateString();
                testTypeCmb.SelectedIndex = (int)_test.TestType;
                testResultTxt.Text = _test.TestResult;

                testDateTxt.ReadOnly = true;
                testResultTxt.ReadOnly = true;
                testTypeCmb.Enabled = false;
                saveTestBtn.Enabled = false;
                testResultTxt.BackColor = SystemColors.Control;
                testDateTxt.BackColor = SystemColors.Control;

                printBtn.Enabled = true;
            }

            
        }

        /*private void removeResultBtn_Click(object sender, EventArgs e)
        //{
        //    if (_medicalController.RemoveTest(_test))
        //    {
        //        MessageBox.Show("Test Removed");
        //        FormRefresh();
        //    }
        //}*/

        // Allow the user to confirm logging out
        private void FormMedical_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you would like to logout?", "Confirm Logout",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    e.Cancel = true;
            }
        }

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

            _medicalController.Logout();
            base.Dispose(disposing);
        }

        private void saveTestBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { testDateTxt, testResultTxt };

            // Check for blank fields
            if (Validator.ValidateTextFields(textBoxes))
            {
                DateTime testDate;

                // Parse the date to a date time
                if (DateTime.TryParse(testDateTxt.Text, out testDate))
                {
                    // Attempt to add the test to the database
                    if (_medicalController.AddTest(_patient.PatientID, _staff.StaffID, testDateTxt.Text, testTypeCmb.SelectedIndex, testResultTxt.Text))
                    {
                        MessageBox.Show("Test Added");

                        testDateTxt.ReadOnly = true;
                        testResultTxt.ReadOnly = true;
                        testTypeCmb.Enabled = false;
                        saveTestBtn.Enabled = false;

                        printBtn.Enabled = true;

                        FormRefresh();
                    }
                }
                else
                {
                    MessageBox.Show("Date format is incorrect! Please try again!");
                }
            }
            else
            {
                MessageBox.Show("Fields must not be blank!");
            }
        }

        // Save the appointment notes to the database
        private void saveAppointmentBtn_Click(object sender, EventArgs e)
        {
            // Need to add functionality to save appointment details here...
            if (_medicalController.SaveAppointmentNotes(_appointment, appNotesTxt.Text))
            {
                MessageBox.Show("Appointment Details saved");
            }

            //appNotesTxt.ReadOnly = true;

        }

        private void TxtChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;
                if (!tb.ReadOnly)
                    tb.BackColor = Color.White;
                else
                {
                    tb.BackColor = SystemColors.Control;
                }
            }
        }

        private void medicineCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicineAddBtn.Enabled = true;
        }

        private void addPrescriptionBtn_Click(object sender, EventArgs e)
        {
            _medicines.Clear();

            startDateTxt.Text = DateTime.Now.ToShortDateString();
            endDateTxt.Text = DateTime.Now.AddMonths(1).ToShortDateString();

            medicineCmbBx.Enabled = true;
            medicineLstBx.Enabled = true;

            medicineCmbBx.DataSource = _medicalController.GetAllMedicines();
            savePrescriptionBtn.Enabled = true;
            medicineCmbBx.DisplayMember = "MedicineDetails";
            medicineLstBx.DataSource = _medicines;
            medicineLstBx.Refresh();
        }

        private void savePrescriptionBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { startDateTxt, endDateTxt };

            if(medicineLstBx.Items.Count > 0)
            {
                if (Validator.ValidateTextFields(textBoxes))
                {
                    if (_medicalController.AddPrescription(_patient.PatientID, _staff.StaffID, startDateTxt.Text, endDateTxt.Text, _medicines))
                    {
                        MessageBox.Show("Prescription Added");

                        startDateTxt.ReadOnly = true;
                        endDateTxt.ReadOnly = true;
                        medicineLstBx.Enabled = false;
                        medicineCmbBx.Enabled = false;
                        savePrescriptionBtn.Enabled = false;

                        FormRefresh();
                    }
                    else
                    {
                        MessageBox.Show("An Error has occured!");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Please enter at least one item of medication");
            }
        }

        private void medicineAddBtn_Click(object sender, EventArgs e)
        {
            List<Medicine> meds = _medicalController.GetAllMedicines();
            _medicines.Add(meds[medicineCmbBx.SelectedIndex]);

            BindingSource medSource = new BindingSource();
            medSource.DataSource = _medicines;

            medicineLstBx.DisplayMember = "MedicineDetails";
            medicineLstBx.DataSource = medSource;
        }

        private void medicineLstBx_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.medicineLstBx.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _medicines.RemoveAt(medicineLstBx.SelectedIndex);
                BindingSource medSource = new BindingSource();
                medSource.DataSource = _medicines;

                medicineLstBx.DisplayMember = "MedicineDetails";
                medicineLstBx.DataSource = medSource;
            }
        }

        private void prescriptionGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _prescription = _patient.Prescriptions[e.RowIndex];

                startDateTxt.Text = _prescription.StartDate.ToShortDateString();
                endDateTxt.Text = _prescription.EndDate.ToShortDateString();

                BindingSource medSource = new BindingSource();
                medSource.DataSource = _prescription.Medicines;

                medicineLstBx.DisplayMember = "MedicineDetails";
                medicineLstBx.DataSource = medSource;

            }
        }

        private void findPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Open the find patient form
            using (var addForm = new FormFindPatient())
            {
                result = addForm.ShowDialog();
            }

            if (result == DialogResult.OK)
            {

            }

            FormRefresh();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("user guide.pdf");
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            using (var printForm = new PrintDialog())
            {
                printForm.Document = printDocument1;

                DialogResult result = printForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Patient patient = _medicalController.GetPatientDetails(_test.PatientID);
            Staff staff = _medicalController.GetStaffDetails(_test.StaffID);

            string title = "Test Results for: " + patient.ToString() +
                            "\nTest Date: " + _test.TestDate.ToShortDateString() +
                            "\nPerformed By: " + staff.ToString() +
                            "\nTest Results: \n" + _test.TestResult;

            // Draw the content.
            Font printFont = new Font("Arial", 25, FontStyle.Regular);
            Image image = Resources.logo1;
            e.Graphics.DrawImage(image, 165, 10);
            e.Graphics.DrawString(title, printFont, Brushes.Black, 10, 250);
        }
    }
}
