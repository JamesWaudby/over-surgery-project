using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestModifyPatient : TestSetup
    {
        [TestMethod]
        public void TestModifyPatientSuccess()
        {
            // Arrange
            AdminController adminController = new AdminController();
            bool expected = true;

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
            bool actual = adminController.ModifyPatient(expectedPatient, 1, "test", "test", 0, "05/02/1991", "married", "00000000000", "test", "test", "test", "test", "test", "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestModifyPatientFail()
        {
            // Arrange
            AdminController adminController = new AdminController();
            bool expected = false;

            Patient expectedPatient = new Patient();
            expectedPatient.PatientID = 100;
            expectedPatient.FirstName = "test test";
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
            bool actual = adminController.ModifyPatient(expectedPatient, 1000, "test", "test", 0, "05/02/2013", "single", "00000000000", "test", "test", "test", "test", "test", "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSaveAppointmentNotesSuccess()
        {
            // Arrange
            MedicalController mc = new MedicalController();
            bool expected = true;

            Appointment app = new Appointment();
            app.AppointmentID = 1;
            app.PatientID = 1;
            app.StaffID = 1;
            app.StartDate = new DateTime(2000, 1, 1, 9, 0, 0);
            app.EndDate = new DateTime(2000, 1, 1, 9, 15, 0);

            // Act
            bool actual = mc.SaveAppointmentNotes(app, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSaveAppointmentNotesFail()
        {
            // Arrange
            MedicalController mc = new MedicalController();
            bool expected = false;

            Appointment app = new Appointment();
            app.AppointmentID = 1;
            app.PatientID = 10;
            app.StaffID = 2;
            app.StartDate = new DateTime(2000, 1, 1, 9, 0, 0);
            app.EndDate = new DateTime(2000, 1, 1, 9, 15, 0);

            // Act
            bool actual = mc.SaveAppointmentNotes(app, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
