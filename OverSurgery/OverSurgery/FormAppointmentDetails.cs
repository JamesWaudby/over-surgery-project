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
    public partial class FormAppointmentDetails : Form
    {
        Appointment _appointment;
        AdminController _adminController;

        public FormAppointmentDetails(Appointment appointment)
        {
            InitializeComponent();
            _adminController = new AdminController();
            _appointment = appointment;

            // Start times of the day
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(9, 15, 0);

            // Populate form fields
            PopulateFields();
            PopulateComboBox(startTimeCmb,  startTime, _appointment.StartDate);
            PopulateComboBox(endTimeCmb, endTime, _appointment.EndDate);

            // Allow editing if the appointment is in the future
            if (_appointment.StartDate > DateTime.Now)
            {
                //modifyAppointmentBtn.Enabled = true;
                cancelAppointmentBtn.Enabled = true;
            }
        }

        private void PopulateFields()
        {
            // Populate the form controls
            staffNameTxt.Text = _appointment.Staff.ToString();
            dateTxt.Text = _appointment.StartDate.ToShortDateString();
            appointmentDetailsTxt.Text = _appointment.AppointmentNotes;

            patientIDTxt.Text = _appointment.Patient.PatientID.ToString();
            firstNameTxt.Text = _appointment.Patient.FirstName;
            lastNameTxt.Text = _appointment.Patient.LastName;
            genderTxt.Text = _appointment.Patient.Gender.ToString();
            dobTxt.Text = _appointment.Patient.DateOfBirth.ToShortDateString();
            statusTxt.Text = _appointment.Patient.MaritalStatus;
            address1Txt.Text = _appointment.Patient.AddressLine1;
            address2Txt.Text = _appointment.Patient.AddressLine2;
            cityTxt.Text = _appointment.Patient.City;
            countyTxt.Text = _appointment.Patient.County;
            postCodeTxt.Text = _appointment.Patient.PostCode;
            emailTxt.Text = _appointment.Patient.EmailAddress;
            telTxt.Text = _appointment.Patient.TelephoneNumber;
        }

        // Add the necessary values to the combo boxes
        private void PopulateComboBox(ComboBox cmb, TimeSpan time,  DateTime date)
        {
            for (int i = 0; i < 36; ++i)
            {
                cmb.Items.Add(time);

                // Increase the time for the next time
                time = time.Add(new TimeSpan(0, 15, 0));
            }

            foreach (TimeSpan o in cmb.Items)
            {
                if (o == date.TimeOfDay)
                {
                    cmb.SelectedItem = o;
                }
            }
        }

        private void modifyAppointmentBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (_adminController.CancelAppointment(_appointment))
            {
                MessageBox.Show("Appointment Deleted");
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
