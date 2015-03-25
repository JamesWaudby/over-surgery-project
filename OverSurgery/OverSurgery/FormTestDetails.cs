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
using System.Drawing.Printing;
using OverSurgery.Properties;

namespace OverSurgeryForms
{
    public partial class FormTestDetails : Form
    {
        Patient _patient;
        Staff _staff;
        Test _test;
        AdminController _adminController = new AdminController();
        MedicalController _medicalController = new MedicalController();

        public FormTestDetails(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            _patient.Tests = _adminController.GetPatientTests(_patient.PatientID);

            _staff = UserSession.Instance().CurrentUser;

            testTypeCmb.DataSource = Enum.GetValues(typeof(TestType));

            RefreshForm();
        }

        private void RefreshForm()
        {
            if (_test != null)
            {
                testDateTxt.Text = _test.TestDate.ToShortDateString();
                testTypeCmb.SelectedIndex = (int)_test.TestType;
                testResultTxt.Text = _test.TestResult;

                printBtn.Enabled = true;
            }

            if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Nurse ||
                    UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Doctor)
            {
                addTestBtn.Enabled = true;
            }

            BindingSource bindingSource = testBindingSource;
            bindingSource.DataSource = _patient.Tests;

            testGridView.DataSource = bindingSource;
            testGridView.Refresh();
        }

        private void testGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _test = _patient.Tests[e.RowIndex];
                RefreshForm();
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            using(var printForm = new PrintDialog())
            {
                printForm.Document = printDocument1;

                DialogResult result = printForm.ShowDialog();

                if(result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Patient patient = _adminController.GetPatientDetails(_test.PatientID);
            Staff staff = _adminController.GetStaffDetails(_test.StaffID);

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

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            printBtn.Enabled = false;

            testDateTxt.Text = DateTime.Now.ToShortDateString();

            testResultTxt.Text = "";
            testResultTxt.ReadOnly = false;
            testTypeCmb.Enabled = true;

            saveTestBtn.Enabled = true;
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
                        _test.PatientID = _patient.PatientID;
                        _test.StaffID = _staff.StaffID;
                        _test.TestDate = testDate;
                        _test.TestType = (TestType)testTypeCmb.SelectedIndex;
                        _test.TestResult = testResultTxt.Text;

                        testResultTxt.ReadOnly = true;
                        testTypeCmb.Enabled = false;
                        saveTestBtn.Enabled = false;
                        printBtn.Enabled = true;

                        RefreshForm();
                    }
                }
            }
        }
    }
}
