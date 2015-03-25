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
    public partial class FormAddStaff : Form
    {
        ManagementController _managementController;

        public FormAddStaff()
        {
            InitializeComponent();

            _managementController = new ManagementController();

            // Create a random password for the new user
            passwordTxt.Text = RandomString(7);

            // Get the ID of the new user
            userIDTxt.Text = _managementController.GetNextStaffID().ToString();

            this.CancelButton = cancelBtn;
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            // Validate all of the user entered values
            TextBox[] textBoxes = { firstNameTxt, lastNameTxt, address1Txt, dateOfBirthTxt, 
                                      cityTxt, countyTxt, postCodeTxt, emailTxt, telNoTxt, passwordTxt };

            if (Validator.ValidateTextFields(textBoxes))
            {
                // Parse the enum type
                PersonGender gender;

                Enum.TryParse<PersonGender>(genderCmb.SelectedItem.ToString(), out gender);

                PermissionsFlag flag;
                
                // Find out which permissions radio button was pressed
                if (adminRB.Checked)
                {
                    flag = PermissionsFlag.Admin;
                }
                else if (doctorRB.Checked)
                {
                    flag = PermissionsFlag.Doctor;
                }
                else if (nurseRB.Checked)
                {
                    flag = PermissionsFlag.Nurse;
                }
                else
                {
                    flag = PermissionsFlag.Management;
                }

                DateTime dateOfBirth;

                if (DateTime.TryParse(dateOfBirthTxt.Text, out dateOfBirth))
                {
                    int telNo;
                    if (Int32.TryParse(telNoTxt.Text, out telNo))
                    {
                        // Attempt to add the staff to the database
                        if (_managementController.AddStaff(Int32.Parse(userIDTxt.Text),
                            firstNameTxt.Text,
                            lastNameTxt.Text,
                            address1Txt.Text,
                            address2Txt.Text,
                            cityTxt.Text,
                            countyTxt.Text,
                            postCodeTxt.Text,
                            dateOfBirth,
                            emailTxt.Text,
                            gender,
                            statusCmb.SelectedItem.ToString(),
                            telNoTxt.Text,
                            flag,
                            passwordTxt.Text))
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telephone Number must be numeric!");
                    }
                }
                else
                {
                    MessageBox.Show("Date format not valid");
                }
            }
            // If not all fields are valid
            else
            {
                MessageBox.Show("Invalid Fields!");
            }
        }

        private void TxtChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.White;
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

            _managementController.Logout();
            base.Dispose(disposing);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

