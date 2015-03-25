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

namespace OverSurgeryForms
{
    public partial class FormFindPatient : Form
    {
        private int _selectedIndex;
        private Patient _foundPatient;
        private List<Patient> _patients;
        private AdminController _adminController;

        public FormFindPatient()
        {
            InitializeComponent();

            _patients = new List<Patient>();
            _adminController = new AdminController();

            // Add the event handler for the find patient control
            patientSearch.PatientSelected += SelectPatient;
            // Pass the controller through
            patientSearch.AdminController = _adminController;
        }

        // Update all of the controls on the form
        private void RefreshForm()
        {
            // Fill in the select patient's details
            if (_foundPatient != null)
            {
                patientIDTxt.Text = _foundPatient.PatientID.ToString();
                firstNameTxt.Text = _foundPatient.FirstName;
                lastNameTxt.Text = _foundPatient.LastName;
                genderCmb.SelectedIndex = (int)_foundPatient.Gender;
                dobTxt.Text = _foundPatient.DateOfBirth.ToShortDateString();
                statusTxt.Text = _foundPatient.MaritalStatus;
                address1Txt.Text = _foundPatient.AddressLine1;
                address2Txt.Text = _foundPatient.AddressLine2;
                cityTxt.Text = _foundPatient.City;
                countyTxt.Text = _foundPatient.County;
                postCodeTxt.Text = _foundPatient.PostCode;
                emailTxt.Text = _foundPatient.EmailAddress;
                telTxt.Text = _foundPatient.TelephoneNumber;

                _foundPatient.Appointments = _adminController.GetPatientAppointments(_foundPatient.PatientID);

                foreach (Appointment a in _foundPatient.Appointments)
                {
                    a.Staff = BusinessMetaLayer.GetStaffDetails(a.StaffID);
                    a.Patient = _foundPatient;
                }

                // Add the list to the data source
                BindingSource test = appointmentBindingSource;
                test.DataSource = _foundPatient.Appointments;

                //bind datagridview to binding source
                dataGridView1.DataSource = test;
                dataGridView1.Refresh();
            }
        }

        private void SelectPatient(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure it's a row and not a column header
            if (e.RowIndex > -1)
            {
                // Set the patient to the select one
                _selectedIndex = e.RowIndex;
                _foundPatient = patientSearch.Patients[_selectedIndex];
                _foundPatient.Appointments = _adminController.GetPatientAppointments(_foundPatient.PatientID);

                // Load all of the patient's appointments
                foreach (Appointment a in _foundPatient.Appointments)
                {
                    a.Staff = BusinessMetaLayer.GetStaffDetails(a.StaffID);
                    a.Patient = _foundPatient;
                }

                // Add the list to the data source
                BindingSource test = appointmentBindingSource;
                test.DataSource = _foundPatient.Appointments;

                //bind datagridview to binding source
                dataGridView1.DataSource = test;
                dataGridView1.Refresh();

                saveBtn.Enabled = false;
                viewPrescriptionsBtn.Enabled = true;
                viewResultsBtn.Enabled = true;

                firstNameTxt.ReadOnly = true;
                lastNameTxt.ReadOnly = true;
                genderCmb.Enabled = false;
                dobTxt.ReadOnly = true;
                statusTxt.ReadOnly = true;
                telTxt.ReadOnly = true;
                address1Txt.ReadOnly = true;
                address2Txt.ReadOnly = true;
                cityTxt.ReadOnly = true;
                countyTxt.ReadOnly = true;
                postCodeTxt.ReadOnly = true;
                emailTxt.ReadOnly = true;

                modifyBtn.Enabled = true;
            }

            RefreshForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure it's not a column header
            if (e.RowIndex > -1)
            {
                DialogResult result;

                // Open the appointment details form
                using (var appForm = new FormAppointmentDetails(_foundPatient.Appointments[e.RowIndex]))
                {
                    result = appForm.ShowDialog();
                }
                if (result == DialogResult.OK)
                {
                    RefreshForm();
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;

            firstNameTxt.ReadOnly = false;
            lastNameTxt.ReadOnly = false;
            genderCmb.Enabled = true;
            dobTxt.ReadOnly = false;
            statusTxt.ReadOnly = false;
            telTxt.ReadOnly = false;
            address1Txt.ReadOnly = false;
            address2Txt.ReadOnly = false;
            cityTxt.ReadOnly = false;
            countyTxt.ReadOnly = false;
            postCodeTxt.ReadOnly = false;
            emailTxt.ReadOnly = false;

            modifyBtn.Enabled = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { firstNameTxt, lastNameTxt, dobTxt, statusTxt, 
                                      telTxt, address1Txt, address2Txt, cityTxt, countyTxt, postCodeTxt, emailTxt };

            // Validate the user entered data
            if(Validator.ValidateTextFields(textBoxes))
            {
                if (_adminController.ModifyPatient(_foundPatient, Int32.Parse(patientIDTxt.Text), firstNameTxt.Text, lastNameTxt.Text, genderCmb.SelectedIndex, dobTxt.Text, statusTxt.Text,
                                                    telTxt.Text, address1Txt.Text, address2Txt.Text, cityTxt.Text, countyTxt.Text, postCodeTxt.Text, emailTxt.Text))
                {
                    PersonGender gender;
                    Enum.TryParse<PersonGender>(genderCmb.SelectedIndex.ToString(), out gender);
                    DateTime dateOfBirth;

                    // Validate the date of birth
                    if (DateTime.TryParse(dobTxt.Text, out dateOfBirth))
                    {
                        _foundPatient.FirstName = firstNameTxt.Text;
                        _foundPatient.LastName = lastNameTxt.Text;
                        _foundPatient.Gender = gender;
                        _foundPatient.DateOfBirth = dateOfBirth;
                        _foundPatient.MaritalStatus = statusTxt.Text;
                        _foundPatient.TelephoneNumber = telTxt.Text;
                        _foundPatient.AddressLine1 = address1Txt.Text;
                        _foundPatient.AddressLine2 = address2Txt.Text;
                        _foundPatient.City = cityTxt.Text;
                        _foundPatient.County = countyTxt.Text;
                        _foundPatient.PostCode = postCodeTxt.Text;
                        _foundPatient.EmailAddress = emailTxt.Text;

                        patientSearch.Patients[_selectedIndex] = _foundPatient;
                        patientSearch.RefreshGridView();

                        MessageBox.Show("Patient Details Updated!");

                        firstNameTxt.ReadOnly = true;
                        lastNameTxt.ReadOnly = true;
                        genderCmb.Enabled = false;
                        dobTxt.ReadOnly = true;
                        statusTxt.ReadOnly = true;
                        telTxt.ReadOnly = true;
                        address1Txt.ReadOnly = true;
                        address2Txt.ReadOnly = true;
                        cityTxt.ReadOnly = true;
                        countyTxt.ReadOnly = true;
                        postCodeTxt.ReadOnly = true;
                        emailTxt.ReadOnly = true;

                        modifyBtn.Enabled = true;
                        saveBtn.Enabled = false;
                    }

                }

                RefreshForm();
            }
        }

        // Open the prescription form
        private void viewPrescriptionsBtn_Click(object sender, EventArgs e)
        {
            using (var prescriptionForm = new FormPrescriptionDetails(_foundPatient))
            {
                prescriptionForm.ShowDialog();
            }
        }

        // Open the test form
        private void viewResultsBtn_Click(object sender, EventArgs e)
        {
            using (var testForm = new FormTestDetails(_foundPatient))
            {
                testForm.ShowDialog();
            }
        }
    }
}
