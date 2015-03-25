using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using System.Collections.Generic;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestFindPatient : TestSetup
    {
        [TestMethod]
        public void TestFindPatientOnID()
        {
            // Arrange
            AdminController adminController = new AdminController();
            Patient expectedPatient = new Patient();
            expectedPatient.PatientID = 1;
            expectedPatient.FirstName = "test";
            expectedPatient.LastName = "test";
            expectedPatient.DateOfBirth = new DateTime(1991, 2, 5);
            expectedPatient.Gender = PersonGender.Male;
            expectedPatient.TelephoneNumber = "00000000000";
            expectedPatient.EmailAddress = "test";
            expectedPatient.AddressLine1 = "test";
            expectedPatient.AddressLine2 = "test";
            expectedPatient.City = "test";
            expectedPatient.County = "test";
            expectedPatient.PostCode = "test";
            expectedPatient.MaritalStatus = "married";

            // Act
            Patient actualPatient = adminController.GetPatientDetails(1);

            // Assert
            Assert.AreEqual(expectedPatient, actualPatient);
        }

        [TestMethod]
        public void TestFindPatientOnSearch()
        {
            // Arrange
            AdminController adminController = new AdminController();
            List<Patient> expectedPatient = new List<Patient>();
            expectedPatient.Add(new Patient());
            expectedPatient[0].PatientID = 1;
            expectedPatient[0].FirstName = "test";
            expectedPatient[0].LastName = "test";
            expectedPatient[0].DateOfBirth = new DateTime(1991, 2, 5);
            expectedPatient[0].Gender = PersonGender.Male;
            expectedPatient[0].TelephoneNumber = "00000000000";
            expectedPatient[0].EmailAddress = "test";
            expectedPatient[0].AddressLine1 = "test";
            expectedPatient[0].AddressLine2 = "test";
            expectedPatient[0].City = "test";
            expectedPatient[0].County = "test";
            expectedPatient[0].PostCode = "test";
            expectedPatient[0].MaritalStatus = "married";

            // Act
            List<Patient> actualPatient = adminController.GetPatientDetails("1", "test", "test", "05/02/1991", "test");

            // Assert
            CollectionAssert.AreEqual(expectedPatient, actualPatient);
        }

        [TestMethod]
        public void TestGetPatientAppointments()
        {
            // Arrange
            AdminController adminController = new AdminController();
            Patient patient = new Patient();
            patient.Appointments = new List<Appointment>();
            patient.Appointments.Add(new Appointment());
            patient.Appointments[0].AppointmentID = 1;
            patient.Appointments[0].PatientID = 1;
            patient.Appointments[0].StaffID = 1;
            patient.Appointments[0].StartDate = new DateTime(2000, 01, 01, 9, 0, 0);
            patient.Appointments[0].EndDate = new DateTime(2000, 01, 01, 9, 15, 0);

            Patient expectedPatient = new Patient();

            // Act
            expectedPatient.Appointments = adminController.GetPatientAppointments(1);

            // Assert
            CollectionAssert.AreEqual(patient.Appointments, expectedPatient.Appointments);
        }

        [TestMethod]
        public void TestGetPatientPrescriptions()
        {
            // Arrange
            MedicalController controller = new MedicalController();
            Patient patient = new Patient();
            patient.Prescriptions = new List<Prescription>();
            patient.Prescriptions.Add(new Prescription());
            patient.Prescriptions[0].PrescriptionID = 1;
            patient.Prescriptions[0].PatientID = 1;
            patient.Prescriptions[0].StaffID = 1;
            patient.Prescriptions[0].StartDate = new DateTime(2013, 10, 12);
            patient.Prescriptions[0].EndDate = new DateTime(2014, 1, 1);
            patient.Prescriptions[0].Extended = false;
            patient.Prescriptions[0].Medicines.Add(new Medicine());
            patient.Prescriptions[0].Medicines[0].MedicineID = 1;
            patient.Prescriptions[0].Medicines[0].MedicineName = "Thyroxine";
            patient.Prescriptions[0].Medicines[0].Dosage = "125mg";
            patient.Prescriptions[0].Medicines[0].Extendable = false;

            patient.Prescriptions.Add(new Prescription());
            patient.Prescriptions[1].PrescriptionID = 2;
            patient.Prescriptions[1].PatientID = 1;
            patient.Prescriptions[1].StaffID = 1;
            patient.Prescriptions[1].StartDate = new DateTime(2013, 01, 01);
            patient.Prescriptions[1].EndDate = new DateTime(2013, 02, 01);
            patient.Prescriptions[1].Extended = false;
            patient.Prescriptions[1].Medicines.Add(new Medicine());
            patient.Prescriptions[1].Medicines[0].MedicineID = 2;
            patient.Prescriptions[1].Medicines[0].MedicineName = "Thyroxine";
            patient.Prescriptions[1].Medicines[0].Dosage = "50mg";
            patient.Prescriptions[1].Medicines[0].Extendable = true;

            // Act
            Patient expectedPatient = new Patient();
            expectedPatient.Prescriptions = controller.GetPatientPrescriptions(1);

            // Assert
            CollectionAssert.AreEqual(patient.Prescriptions, expectedPatient.Prescriptions);
        }

        [TestMethod]
        public void TestGetPatientTests()
        {
            // Arrange
            MedicalController controller = new MedicalController();
            Patient patient = new Patient();
            patient.Tests = new List<Test>();
            patient.Tests.Add(new Test());
            patient.Tests[0].StaffID = 1;
            patient.Tests[0].PatientID = 1;
            patient.Tests[0].TestDate = new DateTime(2013,12,12);
            patient.Tests[0].TestType = TestType.BloodTest;
            patient.Tests[0].TestResult = "test";

            // Act
            Patient actualPatient = new Patient();
            actualPatient.Tests = controller.GetPatientTests(1);

            // Assert
            CollectionAssert.AreEqual(patient.Prescriptions, actualPatient.Prescriptions);
        }

        [TestMethod]
        public void TestGetAllMedicineSuccess()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            List<Medicine> expected = new List<Medicine>();
            expected.Add(new Medicine());
            expected[0].MedicineID = 1;
            expected[0].MedicineName = "Thyroxine";
            expected[0].Dosage = "125mg";
            expected[0].Extendable = false;
            expected.Add(new Medicine());
            expected[1].MedicineID = 2;
            expected[1].MedicineName = "Thyroxine";
            expected[1].Dosage = "50mg";
            expected[1].Extendable = true;

            // Act
            List<Medicine> actual = mc.GetAllMedicines();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
