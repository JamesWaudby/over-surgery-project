using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestCancelAppointment : TestSetup
    {
        [TestMethod]
        public void TestCancelAppointmentSuccess()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = true;

            Appointment app = new Appointment();
            app.AppointmentID = 1;
            app.PatientID = 1;
            app.StaffID = 1;
            app.StartDate = new DateTime(2000, 1, 1, 9, 0, 0);
            app.EndDate = new DateTime(2000, 1, 1, 9, 15, 0);

            // Act
            bool actual = ac.CancelAppointment(app);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCancelAppointmentFail()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = false;

            Appointment app = new Appointment();
            app.AppointmentID = 1;
            app.PatientID = 1;
            app.StaffID = 1;
            app.StartDate = new DateTime(2001, 1, 1, 9, 0, 0);
            app.EndDate = new DateTime(2001, 1, 1, 9, 15, 0);

            // Act
            bool actual = ac.CancelAppointment(app);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
