using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestAddAppointment : TestSetup
    {
        [TestMethod]
        public void TestAddAppointmentDoesntExist()
        {
            // Arrange
            AdminController adminController = new AdminController();

            // Create basic a staff
            Staff staff = new Staff();
            staff.StaffID = 1;

            // Create a basic patient
            Patient patient = new Patient();
            patient.PatientID = 1;

            // Expected result 
            bool expected = true;

            // Need to clear the appointments table


            // Act
            bool actual = adminController.AddAppointment(new DateTime(2002, 1, 1, 9, 0, 0), new DateTime(2002, 1, 1, 9, 15, 0), staff, patient);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddAppointmentExists()
        {
            // Arrange
            AdminController adminController = new AdminController();
            bool expected = false;

            Staff staff = new Staff();
            staff.StaffID = 1;

            Patient patient = new Patient();
            patient.PatientID = 1;

            // Act
            bool actual = adminController.AddAppointment(new DateTime(2000, 1, 1, 9, 0, 0), new DateTime(2000, 1, 1, 9, 15, 0), staff, patient);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
