using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverSurgery
{
    public partial class PatientSearch : UserControl
    {
        //private List<Patient> _patients;

        public String PatientID
        {
            get { return patientSearchIDTxt.Text; }
            set { patientSearchIDTxt.Text = value; }
        }

        public String FirstName
        {
            get { return firstNameSearchTxt.Text; }
            set { firstNameSearchTxt.Text = value; }
        }

        public String LastName
        {
            get { return lastNameSearchTxt.Text; }
            set { lastNameSearchTxt.Text = value; }
        }

        public String DateOfBirth
        {
            get { return dateOfBirthSearchTxt.Text; }
            set { dateOfBirthSearchTxt.Text = value; }
        }

        public String PostCode
        {
            get { return postCodeSearchTxt.Text; }
            set { postCodeSearchTxt.Text = value; }
        }

        //public List<Patient> Patients
        //{
        //    get { return _patients; }
        //    set { _patients = value; }
        //}

        public PatientSearch()
        {
            InitializeComponent();

            //_patients = new List<Patient>();
        }

        //private void findPatientBtn_Click(object sender, EventArgs e)
        //{
        //    _patients.Clear();

        //    // Search based on the patient ID
        //    if (patientSearchIDTxt.Text != string.Empty)
        //    {
        //        _patients.Add(BusinessMetaLayer.GetPatientDetails(Int32.Parse(patientSearchIDTxt.Text)));
        //    }

        //    // Search based on the first name and last name and post code.
        //    else if (firstNameSearchTxt.Text != string.Empty && lastNameSearchTxt.Text != string.Empty && postCodeSearchTxt.Text != string.Empty)
        //    {
        //        _patients = (BusinessMetaLayer.GetPatientDetails(firstNameSearchTxt.Text, lastNameSearchTxt.Text, postCodeSearchTxt.Text));
        //    }

        //    // Search based on the first name, last name and date of birth
        //    else if (firstNameSearchTxt.Text != string.Empty && lastNameSearchTxt.Text != string.Empty && dateOfBirthSearchTxt.Text != string.Empty)
        //    {
        //        DateTime dateOfBirth = Convert.ToDateTime(dateOfBirthSearchTxt.Text);

        //        _patients = (BusinessMetaLayer.GetPatientDetails(firstNameSearchTxt.Text, lastNameSearchTxt.Text, dateOfBirth));
        //    }
        //    // Invalid combination of search terms
        //    else
        //    {
        //        MessageBox.Show("Search terms invalid.");
        //    }

        //    // Add the list to the data source
        //    //BindingSource test = patientBindingSource;
        //    //test.DataSource = _patients;

        //    //bind datagridview to binding source
        //    dataGridView1.DataSource = _patients;
        //    dataGridView1.Refresh();
        //}

        public event DataGridViewCellEventHandler PatientSelected;

        // Handle the clicks on the grid row
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check it's a row and not the column header
            if (e.RowIndex > -1)
            {
                //Null check makes sure the main page is attached to the event
                if (this.PatientSelected != null)
                    this.PatientSelected(new object(), e);
            }
        }
    }
}
