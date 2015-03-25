using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OverSurgery;

namespace OverSurgeryForms
{
    public partial class StaffSearch : UserControl
    {
        // A list of patients populated by the search
        private List<Staff> _staff;
        private AdminController _adminController;

        public List<Staff> Staff
        {
            get { return _staff; }
        }

        public AdminController AdminController
        {
            set { _adminController = value; }
        }

        public StaffSearch()
        {
            InitializeComponent();

            _staff = new List<Staff>();
        }

        // Based on the entered fields, search for a user
        private void findPatientBtn_Click(object sender, EventArgs e)
        {
            // Clear the list of patients
            _staff.Clear();

            // Clear the dataview to avoid row issues
            dataGridView1.DataSource = null;



            TextBox[] textBoxes = { staffSearchIDTxt, firstNameSearchTxt, lastNameSearchTxt };

            if (textBoxes[0].Text == string.Empty && textBoxes[1].Text == string.Empty && textBoxes[2].Text == string.Empty)
            {
                MessageBox.Show("Please enter search terms!");
            }
            else
            {
                int id;
                bool valid = true;

                if (staffSearchIDTxt.Text != string.Empty && !Int32.TryParse(staffSearchIDTxt.Text, out id))
                {   
                    valid = false;
                }

                if (valid)
                {
                    // Pass the search values through
                    _staff = _adminController.GetStaffDetails(staffSearchIDTxt.Text, firstNameSearchTxt.Text, lastNameSearchTxt.Text);

                    // Add the list to the data source
                    BindingSource test = patientBindingSource;
                    test.DataSource = _staff;

                    //bind datagridview to binding source
                    dataGridView1.DataSource = test;
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Invalid fields! Please correct and try again!");
                }
            }
        }

        public void RefreshDataGrid()
        {
            dataGridView1.Refresh();
        }

        // Create new event handler
        public event DataGridViewCellEventHandler StaffSelected;

        // Handle the clicks on the grid row
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check it's a row and not the column header
            if (e.RowIndex > -1)
            {
                if(this.StaffSelected != null)
                    this.StaffSelected(new object(), e);
            }
        }
    }
}
