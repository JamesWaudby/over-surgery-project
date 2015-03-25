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
    public partial class FormAddPatient : Form
    {
        private AdminController adminController;
        private TextBox[] textBoxes;

        public FormAddPatient()
        {
            InitializeComponent();

            // Escape closes the dialog window
            this.CancelButton = cancelBtn;

            adminController = new AdminController();

            // Validate all of the user entered values
            textBoxes = new TextBox[] { firstNameTxt, lastNameTxt, address1Txt, cityTxt, countyTxt, postCodeTxt, dateOfBirthTxt, emailTxt, telNoTxt };

            // Add event handlers for each of the textboxes
            foreach (TextBox t in textBoxes)
            {
                t.TextChanged += TxtChanged;
            }

            // Populate the combo box based on the gender enum
            genderCmb.DataSource = Enum.GetValues(typeof(PersonGender));
        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            // Validate the text fields
            if (Validator.ValidateTextFields(textBoxes))
            {
                // Parse the enum type
                PersonGender gender;
                Enum.TryParse<PersonGender>(genderCmb.SelectedItem.ToString(), out gender);

                DateTime dateOfBirth;

                // Validate the date of birth field
                if (DateTime.TryParse(dateOfBirthTxt.Text, out dateOfBirth))
                {
                    int telNo;
                    if (Int32.TryParse(telNoTxt.Text, out telNo))
                    {
                        // Attempt to add the patient to the database
                        if (adminController.AddPatient(firstNameTxt.Text,
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
                            telNoTxt.Text))
                        {
                            MessageBox.Show("Patient Details Added");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("An error occured, please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telephone Number must be numeric!");
                    }
                }
                else
                {
                    MessageBox.Show("Date format not valid!");
                }            }
            // If not all fields are valid
            else
            {
                MessageBox.Show("Invalid Fields!");
            }
        }

        // Reset the background colour of text fields upon entry
        private void TxtChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (TextBox)sender;
                tb.BackColor = Color.White;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
