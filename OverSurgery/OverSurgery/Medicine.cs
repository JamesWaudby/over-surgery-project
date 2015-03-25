using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class Medicine
    {
        private int _medicineID;
        private String _medicineName;
        private string _dosage;
        private bool _extendable;

        public int MedicineID
        {
            get { return _medicineID; }
            set { _medicineID = value; }
        }

        public String MedicineName
        {
            get { return _medicineName; }
            set { _medicineName = value; }
        }

        public string Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }

        public bool Extendable
        {
            get { return _extendable; }
            set { _extendable = value; }
        }

        public String MedicineDetails
        {
            get { return _medicineName + " (" + _dosage + ")"; }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null || !this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Medicine a = (Medicine)obj;

            return (this._medicineID == a._medicineID)
                && (this._medicineName == a._medicineName)
                && (this._dosage == a._dosage);
        }
    }
}
