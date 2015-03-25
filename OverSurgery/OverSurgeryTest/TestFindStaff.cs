using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using System.Collections.Generic;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestFindStaff : TestSetup
    {
        [TestMethod]
        public void TestFindStaffOnID()
        {
            // Arrange
            AdminController adminController = new AdminController();

            Staff expectedStaff = new Staff();
            expectedStaff.StaffID = 1;
            expectedStaff.FirstName = "test";
            expectedStaff.LastName = "test";
            expectedStaff.DateOfBirth = new DateTime(2013, 2, 5);
            expectedStaff.Gender = PersonGender.Male;
            expectedStaff.TelephoneNumber = "00000000000";
            expectedStaff.EmailAddress = "test";
            expectedStaff.AddressLine1 = "test";
            expectedStaff.AddressLine2 = "test";
            expectedStaff.City = "test";
            expectedStaff.County = "test";
            expectedStaff.PostCode = "test";
            expectedStaff.MaritalStatus = "single";
            expectedStaff.Permissions = PermissionsFlag.Doctor;

            // Act
            Staff actualStaff = adminController.GetStaffDetails(1);

            // Assert
            Assert.AreEqual(expectedStaff, actualStaff);
        }

        [TestMethod]
        public void TestFindStaffOnSearch()
        {
            // Arrange
            AdminController adminController = new AdminController();
            List<Staff> expectedStaff = new List<Staff>();
            expectedStaff.Add(new Staff());
            expectedStaff[0].StaffID = 1;
            expectedStaff[0].FirstName = "test";
            expectedStaff[0].LastName = "test";
            expectedStaff[0].DateOfBirth = new DateTime(2013, 2, 5);
            expectedStaff[0].Gender = PersonGender.Male;
            expectedStaff[0].TelephoneNumber = "00000000000";
            expectedStaff[0].EmailAddress = "test";
            expectedStaff[0].AddressLine1 = "test";
            expectedStaff[0].AddressLine2 = "test";
            expectedStaff[0].City = "test";
            expectedStaff[0].County = "test";
            expectedStaff[0].PostCode = "test";
            expectedStaff[0].MaritalStatus = "single";
            expectedStaff[0].Permissions = PermissionsFlag.Doctor;

            // Act
            List<Staff> actualStaff = adminController.GetStaffDetails("1", "test", "test");

            // Assert
            CollectionAssert.AreEqual(expectedStaff, actualStaff);
        }

        [TestMethod]
        public void TestGetStaffAbsences()
        {
            // Arrange
            ManagementController controller = new ManagementController();
            Staff expectedStaff = new Staff();
            expectedStaff.Absences = new List<Absence>();
            expectedStaff.Absences.Add(new Absence());
            expectedStaff.Absences[0].StaffID = 1;
            expectedStaff.Absences[0].AbsenceType = AbsenceType.Holiday;
            expectedStaff.Absences[0].StartDate = new DateTime(2013, 12, 25);
            expectedStaff.Absences[0].EndDate = new DateTime(2013, 12, 26);

            // Act
            Staff actualPatient = new Staff();
            actualPatient.Absences = controller.GetStaffAbsences(1);

            // Assert
            CollectionAssert.AreEqual(expectedStaff.Absences, actualPatient.Absences);
        }

        [TestMethod]
        public void TestGetStaffAppointmentsSuccess()
        {
            // Arrange
            AdminController adminController = new AdminController();
            Staff staff = new Staff();
            staff.Appointments = new List<Appointment>();
            staff.Appointments.Add(new Appointment());
            staff.Appointments[0].AppointmentID = 1;
            staff.Appointments[0].PatientID = 1;
            staff.Appointments[0].StaffID = 1;
            staff.Appointments[0].StartDate = new DateTime(2000, 01, 01, 9, 0, 0);
            staff.Appointments[0].EndDate = new DateTime(2000, 01, 01, 9, 15, 0);

            Staff actualStaff = new Staff();

            // Act
            actualStaff.Appointments = adminController.GetStaffAppointments(1);

            // Assert
            CollectionAssert.AreEqual(staff.Appointments, actualStaff.Appointments);
        }

        [TestMethod]
        public void TestFindNextStaffIDSuccess()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            int expected = 4;

            // Act
            int actual = mc.GetNextStaffID();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
