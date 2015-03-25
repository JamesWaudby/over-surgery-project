using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestLogin : TestSetup
    {
        [TestMethod]
        public void TestSuccessfulLogin()
        {
            // Arrange
            LoginController lc = new LoginController();
            UserSession.Instance().CurrentUser = null;
            bool expected = true;

            // Act
            bool actual = lc.Login(1, "test");

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(UserSession.Instance().CurrentUser);
        }

        [TestMethod]
        public void TestUnsuccessfulLogin()
        {
            // Arrange
            LoginController lc = new LoginController();
            UserSession.Instance().CurrentUser = null;
            bool expected = false;

            // Act
            bool actual = lc.Login(100, "test");

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.IsNull(UserSession.Instance().CurrentUser);
        }

        [TestMethod]
        public void TestLoggedInDetails()
        {
            // Arrange
            LoginController lc = new LoginController();
            UserSession.Instance().CurrentUser = null;

            String expectedName = "test subject 12 test";

            // Act
            lc.Login(1, "test");

            // Assert
            StringAssert.Equals(expectedName, UserSession.Instance().CurrentUser.ToString());
        }

        [TestMethod]
        public void TestLogout()
        {
            // Arrange
            LoginController lc = new LoginController();
            UserSession.Instance().CurrentUser = null;
            lc.Login(1, "test");
            

            // Act
            lc.Logout();

            // Assert
            Assert.IsNull(UserSession.Instance().CurrentUser);
        }

        [TestMethod]
        public void TestSetPasswordSuccess()
        {
            // Arrange
            LoginController lc = new LoginController();
            bool expected = true;
            lc.Login(1, "test");

            // Act
            bool actual = lc.SetStaffPassword(UserSession.Instance().CurrentUser, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSetPasswordFail()
        {
            // Arrange
            LoginController lc = new LoginController();
            bool expected = false;

            Staff expectedStaff = new Staff();
            expectedStaff.StaffID = 100;
            expectedStaff.FirstName = "test staff";
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
            bool actual = lc.SetStaffPassword(expectedStaff, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
