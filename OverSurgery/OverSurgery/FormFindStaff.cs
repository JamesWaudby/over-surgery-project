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
    public partial class FormFindStaff : Form
    {
        private Staff _foundStaff;
        private List<Staff> _staff;
        private AdminController _adminController;
        private ManagementController _managementController;
        private int _selectedIndex;

        public FormFindStaff()
        {
            InitializeComponent();

            _staff = new List<Staff>();

            _adminController = new AdminController();
            _managementController = new ManagementController();

            // Add event handler to the staff search
            staffSearch.StaffSelected += SelectStaff;
            staffSearch.AdminController = _adminController;
        }

        private void RefreshForm()
        {
            if (_foundStaff != null)
            {
                staffIDTxt.Text = _foundStaff.StaffID.ToString();
                firstNameTxt.Text = _foundStaff.FirstName;
                lastNameTxt.Text = _foundStaff.LastName;
                genderCmb.SelectedIndex = (int)_foundStaff.Gender;
                dobTxt.Text = _foundStaff.DateOfBirth.ToShortDateString();
                statusTxt.Text = _foundStaff.MaritalStatus;
                address1Txt.Text = _foundStaff.AddressLine1;
                address2Txt.Text = _foundStaff.AddressLine2;
                cityTxt.Text = _foundStaff.City;
                countyTxt.Text = _foundStaff.County;
                postCodeTxt.Text = _foundStaff.PostCode;
                emailTxt.Text = _foundStaff.EmailAddress;
                telTxt.Text = _foundStaff.TelephoneNumber;

                viewAbsenceBtn.Enabled = true;

                switch (_foundStaff.Permissions)
                {
                    case PermissionsFlag.Admin:
                        adminRBtn.Checked = true;
                        break;
                    case PermissionsFlag.Doctor:
                    case PermissionsFlag.Nurse:
                        medicalRBtn.Checked = true;
                        break;
                    case PermissionsFlag.Management:
                        managementRBtn.Checked = true;
                        break;
                }

                if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Management)
                {
                    modifyBtn.Enabled = true;
                    resetPasswordBtn.Enabled = true;
                }
            }
        }

        private void SelectStaff(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _selectedIndex = e.RowIndex;
                _foundStaff = staffSearch.Staff[_selectedIndex];
                _foundStaff.Appointments = _adminController.GetStaffAppointments(_foundStaff.StaffID);


                foreach (Appointment a in _foundStaff.Appointments)
                {
                    a.Patient = BusinessMetaLayer.GetPatientDetails(a.PatientID);
                    a.Staff = _foundStaff;
                }

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
                saveBtn.Enabled = false;

                BindingSource appointmentBinding = appointmentBindingSource;
                appointmentBinding.DataSource = _foundStaff.Appointments;

                dataGridView1.DataSource = appointmentBinding;
                dataGridView1.Refresh();
            }

            RefreshForm();
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

            // Check for empty fields
            if (Validator.ValidateTextFields(textBoxes))
            {
                DateTime dateOfBirth;

                // Validate user entered date
                if (DateTime.TryParse(dobTxt.Text, out dateOfBirth))
                {
                    // Attempt to modify staff details based on user input
                    if (_managementController.ModifyStaff(_foundStaff, Int32.Parse(staffIDTxt.Text), firstNameTxt.Text, lastNameTxt.Text, genderCmb.SelectedIndex, dobTxt.Text, statusTxt.Text,
                                                        telTxt.Text, address1Txt.Text, address2Txt.Text, cityTxt.Text, countyTxt.Text, postCodeTxt.Text, emailTxt.Text))
                    {
                        PersonGender gender;
                        Enum.TryParse<PersonGender>(genderCmb.SelectedIndex.ToString(), out gender);

                        _foundStaff.FirstName = firstNameTxt.Text;
                        _foundStaff.LastName = lastNameTxt.Text;
                        _foundStaff.Gender = gender;
                        _foundStaff.DateOfBirth = dateOfBirth;
                        _foundStaff.MaritalStatus = statusTxt.Text;
                        _foundStaff.TelephoneNumber = telTxt.Text;
                        _foundStaff.AddressLine1 = address1Txt.Text;
                        _foundStaff.AddressLine2 = address2Txt.Text;
                        _foundStaff.City = cityTxt.Text;
                        _foundStaff.County = countyTxt.Text;
                        _foundStaff.PostCode = postCodeTxt.Text;
                        _foundStaff.EmailAddress = emailTxt.Text;

                        staffSearch.Staff[_selectedIndex] = _foundStaff;
                        staffSearch.RefreshDataGrid();

                        MessageBox.Show("Staff Details Updated!");
                    }
                }

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

                RefreshForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Open the add appointment form with the data from the form
            using (var addForm = new FormAddAbsence(_foundStaff))
            {
                result = addForm.ShowDialog();
            }

            // Refresh the admin form once the appointment has been added
            if (result == DialogResult.OK)
            {
                MessageBox.Show("New Staff Member Added");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if row is not column header
            if(e.RowIndex > -1)
            {
                // Show appointment details form
                using(var appForm = new FormAppointmentDetails(_foundStaff.Appointments[e.RowIndex]))
                {
                    appForm.ShowDialog();
                }
            }
        }

        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = RandomString(7);

            // Flag user for password reset
            if (_managementController.ResetPassword(_foundStaff.StaffID, newPassword))
            {
                _managementController.SavePasswordFile(_foundStaff, newPassword);
                MessageBox.Show("Staff flagged for password reset.\nTemporary Password is:\n" + newPassword);
            }
        }

        // Generate a random string for a password
        // Details found at:
        // http://stackoverflow.com/questions/1122483/c-sharp-random-string-generator
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = (char)random.Next('A', 'Z' + 1);
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
