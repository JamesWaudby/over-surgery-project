using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverSurgery
{
    public class MedicalController : Controller
    {
        public MedicalController()
        {
        }

        // Add a new test for a patient based on user entered data
        public bool AddTest(int patientID, int staffID, string testDate, int testType, string testResults)
        {
            DateTime date;

            // Validate the entered date
            if (DateTime.TryParse(testDate, out date))
            {
                Test test = new Test();
                test.PatientID = patientID;
                test.StaffID = staffID;
                test.TestDate = date;
                test.TestType = (TestType)testType;
                test.TestResult = EncodeMySql(testResults);
                return BusinessMetaLayer.AddTest(test);
            }
            return false;            
        }

        /* Remove a test - not used
        public bool RemoveTest(Test test)
        {
            return BusinessMetaLayer.RemoveTest(test);
        }*/

        // Add a new prescription for a patient based on user entered data
        public bool AddPrescription(int patientID, int staffID, string startDate, string endDate, List<Medicine> medicines)
        {
            DateTime start, end;

            if (DateTime.TryParse(startDate, out start) && DateTime.TryParse(endDate, out end))
            {
                Prescription prescription = new Prescription();
                prescription.PatientID = patientID;
                prescription.StaffID = staffID;
                prescription.StartDate = start;
                prescription.EndDate = end;
                prescription.Medicines = medicines;
                prescription.Extended = false;

                return BusinessMetaLayer.AddPrescription(prescription);
            }
            return false;
        }

        public bool SaveAppointmentNotes(Appointment appointment, string notes)
        {
            return BusinessMetaLayer.SaveAppointmentNotes(appointment, EncodeMySql(notes));
        }
    }
}
