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
    public partial class FormLogin : Form
    {
        public LoginController loginController;

        public FormLogin()
        {
            InitializeComponent();

            // Instatiate the login controller
            loginController = new LoginController();

            // Set the accept button
            this.AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Create a textbox for validation
            TextBox[] textBoxes = { staffIDTextBox, passwordTextBox };

            if (Validator.ValidateTextFields(textBoxes))
            {
                // Attempt to login to the server.
                int staffID;

                // Check that the staff ID entered is numeric
                if (Int32.TryParse(staffIDTextBox.Text, out staffID))
                {
                    // Attempt to login with user entered values
                    if (loginController.Login(staffID, passwordTextBox.Text))
                    {
                        // Check if the user is flagged for password reset
                        if (UserSession.Instance().CurrentUser.ResetPasswordFlag)
                        {
                            // Show the reset password form
                            using (var resetPassword = new FormResetPassword())
                            {
                                resetPassword.ShowDialog();
                            }
                        }
                        // Return that the login was successful.
                        DialogResult = DialogResult.OK;
                    }

                    // If the login was unsuccessful, try again.
                    else
                    {
                        MessageBox.Show("Login unsuccesful. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Staff ID must be numeric.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be completed.");
            }
        }

        // Check the colour of textboxes back to white on text changed
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

            base.Dispose(disposing);
        }
    }
}
