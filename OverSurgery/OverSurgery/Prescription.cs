using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class Prescription
    {
        private int _prescriptionID;
        private int _patientID;
        private int _staffID;
        private DateTime _startDate;
        private DateTime _endDate;
        private bool _extended;
        private List<Medicine> _medicines;

        public int PrescriptionID
        {
            get { return _prescriptionID; }
            set { _prescriptionID = value; }
        }

        public int PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }               
        }

        public int StaffID
        {
            get { return _staffID; }
            set { _staffID = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }                
        }

        public bool Extended
        {
            get { return _extended; }
            set { _extended = value; }
        }

        public List<Medicine> Medicines
        {
            get { return _medicines; }
            set { _medicines = value; }
        }

        public Prescription()
        {
            _medicines = new List<Medicine>();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null || !this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Prescription a = (Prescription)obj;
            return (this._prescriptionID == a._prescriptionID)
               && (this._patientID == a._patientID)
               && (this._staffID == a._staffID)
               && (this._startDate == a._startDate)
               && (this._endDate == a._endDate)
               && (this._medicines.SequenceEqual(a._medicines))
               && (this._extended == a._extended);
        }
    }
}
