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
    public partial class FormResetPassword : Form
    {
        private LoginController _loginController = new LoginController();

        public FormResetPassword()
        {
            InitializeComponent();

            this.ControlBox = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { passwordTxt, confirmTxt };

            if (Validator.ValidateTextFields(textBoxes))
            {
                if (passwordTxt.Text == confirmTxt.Text)
                {
                    if (_loginController.SetStaffPassword(UserSession.Instance().CurrentUser, confirmTxt.Text))
                    {
                        MessageBox.Show("Password successfully changed.");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                }
            }
        }
    }
}
