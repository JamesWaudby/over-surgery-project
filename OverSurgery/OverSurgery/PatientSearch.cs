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
    public partial class PatientSearch : UserControl
    {
        // A list of patients populated by the search
        private List<Patient> _patients;
        private AdminController _adminController;

        public List<Patient> Patients
        {
            get { return _patients; }
        }

        public AdminController AdminController
        {
            set { _adminController = value; }
        }

        public PatientSearch()
        {
            InitializeComponent();

            _patients = new List<Patient>();
        }

        // Based on the entered fields, search for a user
        private void findPatientBtn_Click(object sender, EventArgs e)
        {
            // Clear the list of patients
            _patients.Clear();

            // Clear the dataview to avoid row issues
            dataGridView1.DataSource = null;

            TextBox[] textBoxes = { patientSearchIDTxt, firstNameSearchTxt, lastNameSearchTxt, dateOfBirthSearchTxt, postCodeSearchTxt };

            if (textBoxes[0].Text == string.Empty && textBoxes[1].Text == string.Empty && textBoxes[2].Text == string.Empty
                    && textBoxes[3].Text == string.Empty && textBoxes[4].Text == string.Empty)
            {
                MessageBox.Show("Please enter search terms!");
            }
            else
            {
                int id;
                DateTime date;
                bool valid = true;

                if (patientSearchIDTxt.Text != string.Empty && !Int32.TryParse(patientSearchIDTxt.Text, out id))
                {
                    valid = false;
                }

                if (dateOfBirthSearchTxt.Text != string.Empty && !DateTime.TryParse(dateOfBirthSearchTxt.Text, out date))
                {
                    valid = false;
                }

                if (valid)
                {
                    // Pass the search values through
                    _patients = _adminController.GetPatientDetails(patientSearchIDTxt.Text, firstNameSearchTxt.Text,
                        lastNameSearchTxt.Text, dateOfBirthSearchTxt.Text, postCodeSearchTxt.Text);

                    // Add the list to the data source
                    BindingSource test = patientBindingSource;
                    test.DataSource = _patients;

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

        public void RefreshGridView()
        {
            dataGridView1.Refresh();
        }

        // Create new event handler
        public event DataGridViewCellEventHandler PatientSelected;

        // Handle the clicks on the grid row
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check it's a row and not the column header
            if (e.RowIndex > -1)
            {
                if(this.PatientSelected != null)
                    this.PatientSelected(new object(), e);
            }
        }
    }
}
