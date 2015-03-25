using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{

    //Role is used to flag user permissions
    public enum PermissionsFlag { Admin = 0, Doctor, Nurse, Management }

    public class Staff : Person
    {
        private List<Absence> _absences;
        private List<Appointment> _appointments;
        private PermissionsFlag _permissions;
        private int _staffID;
        private bool _resetPasswordFlag;

        public List<Absence> Absences
        {
            set { _absences = value; }
            get { return _absences; }
        }
        
        public List<Appointment> Appointments
        {
            set { _appointments = value; }
            get { return _appointments; }
        }

        public PermissionsFlag Permissions
        {
            set { _permissions = value; }
            get { return _permissions; }
        }

        public int StaffID
        {
            set { _staffID = value; }
            get { return _staffID; }
        }

        public bool ResetPasswordFlag
        {
            get { return _resetPasswordFlag; }
            set { _resetPasswordFlag = value;  }
        }

        public Staff() : base()
        {
            _absences = new List<Absence>();
            _appointments = new List<Appointment>();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null || !this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Staff a = (Staff) obj;
            return ((this._absences.SequenceEqual(a._absences))
                && (this._appointments.SequenceEqual(a._appointments))
                && (this._permissions == a._permissions)
                && (this._staffID == a._staffID)
                && (base.Equals(obj))); 

        }
    }
}
