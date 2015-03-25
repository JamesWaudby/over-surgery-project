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
    public partial class FormAddAppointment : Form
    {
        // Add Mode attributes
        private DateTime _startDate, _endDate;

        // The select staff for the appointment
        private Staff _staff;

        // The selected patient for the appointment
        private Patient _patient;

        private AdminController _adminController;

        public FormAddAppointment(DateTime date, TimeSpan startTime, TimeSpan endTime, Staff staff)
        {
            InitializeComponent();

            _adminController = new AdminController();

            // Set the appointment details
            _staff = staff;
            _startDate = date.Add(startTime);
            _endDate = date.Add(endTime);

            // Add the event handle for the find patient control
            patientSearch.PatientSelected += SelectPatient;

            // Pass the admin controller to the patient search
            patientSearch.AdminController = _adminController;

            RefreshForm();
        }

        // Setup all of the fields on the form
        private void RefreshForm()
        {
            // Update form controls
            staffNameTxt.Text = _staff.ToString();
            startTimeTxt.Text = _startDate.ToShortTimeString();
            dateTxt.Text = _startDate.ToShortDateString();
            endTimeTxt.Text = _endDate.ToShortTimeString();

            if (_patient != null)
            {
                patientIDTxt.Text = _patient.PatientID.ToString();
                firstNameTxt.Text = _patient.FirstName;
                lastNameTxt.Text = _patient.LastName;
                genderTxt.Text = _patient.Gender.ToString();
                dobTxt.Text = _patient.DateOfBirth.ToShortDateString();
                statusTxt.Text = _patient.MaritalStatus;
                address1Txt.Text = _patient.AddressLine1;
                address2Txt.Text = _patient.AddressLine2;
                cityTxt.Text = _patient.City;
                countyTxt.Text = _patient.County;
                postCodeTxt.Text = _patient.PostCode;
                emailTxt.Text = _patient.EmailAddress;
                telTxt.Text = _patient.TelephoneNumber;
            }
        }

        // Return a string from a timespan
        public string GetTimeSpanAsString(TimeSpan input)
        {
            return input.ToString(@"hh\:mm");
        }

        // Close the dialog window
        private void cancelBtn_Click(object sender, EventArgs e)
        {
             DialogResult = DialogResult.Cancel;
        }

        // Confirm the add appointment function
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (_adminController.AddAppointment(_startDate, _endDate, _staff, _patient))
            {
                MessageBox.Show("Appointment Added");
                DialogResult = DialogResult.OK;
            }
        }

        // Set the patients details from the patientSearch Control
        private void SelectPatient(object sender, DataGridViewCellEventArgs e)
        {
            // Check the selected row isn't a column header
            if (e.RowIndex > -1)
            {
                // Set the patient to the selected option
                _patient = patientSearch.Patients[e.RowIndex];
                addBtn.Enabled = true;
            }

            RefreshForm();
        }
    }
}
