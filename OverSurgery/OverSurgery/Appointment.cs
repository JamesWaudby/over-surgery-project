using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class Appointment
    {
        private int _appointmentID;
        private int _patientID;
        private int _staffID;
        private String _appointmentNotes;

        private DateTime _startDate, _endDate;

        private Patient _patient;
        private Staff _staff;

        public Appointment()
        {
        }

        // Unique Appointment Identifier
        public int AppointmentID 
        {
            get { return _appointmentID; } 
            set { _appointmentID = value; } 
        }

        // Who is the Appointment for
        public int PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        // Who is it with
        public int StaffID
        {
            get { return _staffID; }
            set { _staffID = value; }
        }

        // When does the appointment start
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        // When does the appointment end
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public Patient Patient
        {
            get { return _patient; }
            set { _patient = value; }
        }

        public Staff Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }

        public String AppointmentNotes
        {
            get { return _appointmentNotes; }
            set { _appointmentNotes = value; }
        }

        public String AppointmentTime
        {
            get { return _startDate.ToShortTimeString() + " - " + _endDate.ToShortTimeString(); }
        }

        public override bool Equals(object obj)
        {
            if((obj == null || ! this.GetType().Equals(obj.GetType())))
            {
                return false;
            }
            
            Appointment a = (Appointment) obj;
            return ( (this._appointmentID == a._appointmentID) &&
                      (this._startDate.Equals(a._startDate)) &&
                      (this._endDate.Equals(a._endDate)) &&
                      (this._patientID == a._patientID) &&
                      (this._staffID == a._staffID));
        }
    }
}
