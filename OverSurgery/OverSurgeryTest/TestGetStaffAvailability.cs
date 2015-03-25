using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using System.Collections.Generic;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestGetStaffAvailability : TestSetup
    {
        [TestMethod]
        public void TestStaffAvailability()
        {
            // Arrange
            ManagementController managerController = new ManagementController();
            Staff newStaff = new Staff();
            newStaff.StaffID = 1;

            List<Appointment> expected = new List<Appointment>();
            expected.Add(new Appointment());
            expected[0].AppointmentID = 1;
            expected[0].PatientID = 1;
            expected[0].StaffID = 1;
            expected[0].StartDate = new DateTime(2000, 1, 1, 9, 0, 0);
            expected[0].EndDate = new DateTime(2000, 1, 1, 9, 15, 0);

            // Act
            newStaff.Appointments = managerController.GetStaffAvailability(newStaff, new DateTime(2000, 1, 1));

            // Assert
            CollectionAssert.AreEqual(expected, newStaff.Appointments);
        }

    }
}
