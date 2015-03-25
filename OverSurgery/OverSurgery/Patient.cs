using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class Patient : Person
    {
        private int _patientID;
        private List<Appointment> _appointments;
        private List<Test> _tests;
        private List<Prescription> _prescriptions;

        public int PatientID
        {
            set { _patientID = value; }
            get { return _patientID; }
        }

        public List<Appointment> Appointments
        {
            set { _appointments = value; }
            get { return _appointments; }
        }

        public List<Test> Tests
        {
            get { return _tests; }
            set { _tests = value; }
        }

        public List<Prescription> Prescriptions
        {
            get { return _prescriptions; }
            set { _prescriptions = value; }
        }

    }
}
