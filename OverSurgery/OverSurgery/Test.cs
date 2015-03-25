using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public enum TestType { BloodTest = 0, UrineTest, BloodPressure }

    public class Test
    {
        private DateTime _testDate;
        private TestType _testType;
        private String _testResult;
        private int _patientID;
        private int _staffID;

        public DateTime TestDate
        {
            get { return _testDate; }
            set { _testDate = value; }
        }

        public TestType TestType
        {
            get { return _testType; }
            set { _testType = value; }
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

        public String TestResult
        {
            get { return _testResult; }
            set { _testResult = value; }
        }

    }
}
