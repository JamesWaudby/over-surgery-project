using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestModifyStaff : TestSetup
    {
        [TestMethod]
        public void TestModifyStaffSuccess()
        {
            // Arrange
            ManagementController managementController = new ManagementController();
            bool expected = true;

            Staff oldStaff = new Staff();
            oldStaff.StaffID = 1;
            oldStaff.FirstName = "test";
            oldStaff.LastName = "test";
            oldStaff.Gender = PersonGender.Male;
            oldStaff.DateOfBirth = new DateTime(2013, 02, 05);
            oldStaff.MaritalStatus = "single";
            oldStaff.TelephoneNumber = "00000000000";
            oldStaff.AddressLine1 = "test";
            oldStaff.AddressLine2 = "test";
            oldStaff.City = "test";
            oldStaff.County = "test";
            oldStaff.PostCode = "test";
            oldStaff.EmailAddress = "test";
            oldStaff.Permissions = PermissionsFlag.Doctor;

            // Act
            bool actual = managementController.ModifyStaff(oldStaff, 1, "test subject 12", "test", 0, "05/02/2013", "single", "00000000000", "test", "test", "test", "test", "test", "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestModifyStaffFail()
        {
            // Arrange
            ManagementController managementController = new ManagementController();
            bool expected = false;

            Staff oldStaff = new Staff();
            oldStaff.StaffID = 1000;
            oldStaff.FirstName = "test 2";
            oldStaff.LastName = "test";
            oldStaff.Gender = PersonGender.Male;
            oldStaff.DateOfBirth = new DateTime(2013, 02, 05);
            oldStaff.MaritalStatus = "single";
            oldStaff.TelephoneNumber = "00000000000";
            oldStaff.AddressLine1 = "test";
            oldStaff.AddressLine2 = "test";
            oldStaff.City = "test";
            oldStaff.County = "test";
            oldStaff.PostCode = "test";
            oldStaff.EmailAddress = "test";
            oldStaff.Permissions = PermissionsFlag.Doctor;

            // Act
            bool actual = managementController.ModifyStaff(oldStaff, 1000, "test", "test", 0, "05/02/2013", "single", "00000000000", "test", "test", "test", "test", "test", "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestResetPasswordSuccess()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            bool expected = true;            

            // Act
            bool actual = mc.ResetPassword(1, "password");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestResetPasswordFail()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            bool expected = true;

            // Act
            bool actual = mc.ResetPassword(1000, "password");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRemoveAbsenceSuccess()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            bool expected = true;

            Absence absence = new Absence();
            absence.StaffID = 1;
            absence.AbsenceType = AbsenceType.Holiday;
            absence.StartDate = new DateTime(2013, 12, 25);
            absence.EndDate = new DateTime(2013, 12, 26);

            // Act
            bool actual = mc.RemoveAbsence(absence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRemoveAbsenceFail()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            bool expected = false ;

            Absence absence = new Absence();
            absence.StaffID = 10;
            absence.AbsenceType = AbsenceType.Holiday;
            absence.StartDate = new DateTime(2013, 12, 25);
            absence.EndDate = new DateTime(2013, 12, 26);

            // Act
            bool actual = mc.RemoveAbsence(absence);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
