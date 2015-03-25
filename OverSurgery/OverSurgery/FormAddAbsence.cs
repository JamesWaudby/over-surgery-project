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
    public partial class FormAddAbsence : Form
    {
        Staff _staff;
        AdminController _adminController;
        ManagementController _managementController;
        Absence _selectedAbsence;
        int _selectedRow;

        public FormAddAbsence(Staff staff)
        {
            InitializeComponent();

            _adminController = new AdminController();
            _staff = staff;

            // Create the management controls if the current user can use them
            if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Management)
            {
                _managementController = new ManagementController();
            }

            RefreshForm();
        }

        // Updates all fields and controls on the form
        public void RefreshForm()
        {
            // Populate the staff absences list
            _staff.Absences = _adminController.GetStaffAbsences(_staff.StaffID);

            // Fill in text fields
            staffIdTxt.Text = _staff.StaffID.ToString();
            firstNameTxt.Text = _staff.FirstName;
            lastNameTxt.Text = _staff.LastName;

            // Fill in absence details if the user has selected an absence
            if (_selectedAbsence != null)
            {
                absenceTypeCmbBx.SelectedIndex = (int)_selectedAbsence.AbsenceType;
                startDateTxt.Text = _selectedAbsence.StartDate.ToShortDateString();
                endDateTxt.Text = _selectedAbsence.EndDate.ToShortDateString();

                // Allow deletion of an absence if the user if manangement 
                if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Management)
                {
                    modifyAbsenceBtn.Enabled = true;
                }
            }
            else
            {
                // Set default values for these controls
                absenceTypeCmbBx.SelectedIndex = 0;
                startDateTxt.Text = "";
                endDateTxt.Text = "";
            }

            // Allow the user to add new absences if the permissions are correct
            if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Management)
            {
                addAbsenceBtn.Enabled = true;
            }

            // Add the list to the data source
            BindingSource test = absenceBindingSource;
            test.DataSource = _staff.Absences;

            //bind datagridview to binding source
            absenceDataGrid.DataSource = test;
            absenceDataGrid.Refresh();
        }

        // Handle the user double clicking a row in the grid
        private void absenceDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check that the click row isn't a column header
            if (e.RowIndex > -1)
            {
                // Set the selected absence
                _selectedRow = e.RowIndex;
                _selectedAbsence = _staff.Absences[_selectedRow];
            }

            // Update controls
            absenceTypeCmbBx.Enabled = false;
            startDateTxt.ReadOnly = true;
            endDateTxt.ReadOnly = true;

            if (UserSession.Instance().CurrentUser.Permissions == PermissionsFlag.Management)
            {
                addAbsenceBtn.Enabled = true;
                saveAbsenceBtn.Enabled = false;
            }

            // Update fields on the form
            RefreshForm();
        }

        // Enables controls for a new absence to be added
        private void addAbsenceBtn_Click(object sender, EventArgs e)
        {
            // Update the form controls
            modifyAbsenceBtn.Enabled = false;
            saveAbsenceBtn.Enabled = true;

            absenceTypeCmbBx.SelectedIndex = 0;
            absenceTypeCmbBx.Enabled = true;

            startDateTxt.Text = "";
            startDateTxt.ReadOnly = false;

            endDateTxt.Text = "";
            endDateTxt.ReadOnly = false;
        }

        // Remove an absence
        private void modifyAbsenceBtn_Click(object sender, EventArgs e)
        {
            if (_managementController.RemoveAbsence(_selectedAbsence))
            {
                _selectedAbsence = null;
                MessageBox.Show("Absence Deleted");
            }

            RefreshForm();
        }

        // Store the entered details in the database if valid
        private void saveAbsenceBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { startDateTxt, endDateTxt };

            // Check for blank fields
            if (Validator.ValidateTextFields(textBoxes))
            {
                // Attempt to add the absence
                bool added = _managementController.AddAbsence(_staff.StaffID, absenceTypeCmbBx.SelectedIndex, startDateTxt.Text, endDateTxt.Text);

                // If it was successful
                if (added)
                {
                    MessageBox.Show("Absence Added");
                }

                // Update form controls
                absenceTypeCmbBx.Enabled = false;
                startDateTxt.ReadOnly = true;
                endDateTxt.ReadOnly = true;

                addAbsenceBtn.Enabled = true;
                saveAbsenceBtn.Enabled = false;

                RefreshForm();
            }
        }

    }
}
