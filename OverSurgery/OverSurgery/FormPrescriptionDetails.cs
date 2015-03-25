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
    public partial class FormPrescriptionDetails : Form
    {
        Patient _patient;
        Prescription _prescription;
        AdminController _adminController = new AdminController();

        public FormPrescriptionDetails(Patient patient)
        {
            InitializeComponent();
            _patient = patient;

            RefreshForm();
        }

        private void RefreshForm()
        {
            _patient.Prescriptions = _adminController.GetPatientPrescriptions(_patient.PatientID);

            if (_prescription != null)
            {
                startDateTxt.Text = _prescription.StartDate.ToShortDateString();
                endDateTxt.Text = _prescription.EndDate.ToShortDateString();

                BindingSource medSource = new BindingSource();
                medSource.DataSource = _prescription.Medicines;

                medicineLstBx.DisplayMember = "MedicineDetails";
                medicineLstBx.DataSource = medSource;

                bool extendable = true;

                foreach (Medicine m in _prescription.Medicines)
                {
                    if (!m.Extendable)
                    {
                        extendable = false;
                    }
                }

                if (extendable && !_prescription.Extended)
                {
                    extendPrescriptionBtn.Enabled = true;
                }
            }

            BindingSource bindingSource = prescriptionBindingSource;
            bindingSource.DataSource = _patient.Prescriptions;

            dataGridView1.DataSource = bindingSource;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _prescription = _patient.Prescriptions[e.RowIndex];
                RefreshForm();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void extendPrescriptionBtn_Click(object sender, EventArgs e)
        {
            if (_prescription.Extended)
            {
                MessageBox.Show("Prescription has already been extended. Unable to extend any further!");
            }
            else
            {
                if (_adminController.ExtendPrescription(_prescription))
                {
                    _prescription.EndDate = _prescription.EndDate.AddDays(30);
                    _prescription.Extended = true;
                    MessageBox.Show("Prescription Extended");
                    RefreshForm();
                }
            }
        }
    }
}
