using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OverSurgeryForms;

namespace OverSurgery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
           
            // Information Found at:
            // http://stackoverflow.com/questions/3507855/c-sharp-login-examples

            DialogResult result;

            do
            {
                // Display the login form before anything else.
                using (var loginForm = new FormLogin())
                {
                    // Return that the login was successful
                    result = loginForm.ShowDialog();
                }

                // Open the correct form as necessary
                if (result == DialogResult.OK)
                {
                    // Open certain forms depending on the user permissions
                    switch (UserSession.Instance().CurrentUser.Permissions)
                    {
                        case PermissionsFlag.Admin:
                            Application.Run(new FormAdmin());
                            break;
                        case PermissionsFlag.Doctor:
                        case PermissionsFlag.Nurse:
                            Application.Run(new FormMedical());
                            break;
                        case PermissionsFlag.Management:
                            Application.Run(new FormAdmin());
                            break;
                    }
                }
                // Keep looping through until the user cancels
            } while (result != DialogResult.Cancel);          
        }
    }
}
