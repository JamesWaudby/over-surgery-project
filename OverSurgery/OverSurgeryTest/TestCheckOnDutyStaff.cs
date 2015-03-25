using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using System.Collections.Generic;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestCheckOnDutyStaff : TestSetup
    {
        [TestMethod]
        public void TestStaffOnDuty()
        {
            // Arrange
            AdminController adminController = new AdminController();
            List<Staff> expectedResults = new List<Staff>();
            expectedResults.Add(new Staff());
            expectedResults[0].StaffID = 1;
            expectedResults[0].FirstName = "test";
            expectedResults[0].LastName = "test";
            expectedResults[0].DateOfBirth = new DateTime(2013, 2, 5);
            expectedResults[0].Gender = PersonGender.Male;
            expectedResults[0].TelephoneNumber = "00000000000";
            expectedResults[0].EmailAddress = "test";
            expectedResults[0].AddressLine1 = "test";
            expectedResults[0].AddressLine2 = "test";
            expectedResults[0].City = "test";
            expectedResults[0].County = "test";
            expectedResults[0].PostCode = "test";
            expectedResults[0].MaritalStatus = "single";
            expectedResults[0].Permissions = PermissionsFlag.Doctor;

            // Act
            List<Staff> actualResults = adminController.GetOnDutyStaff(new DateTime(2013, 11, 20));

            // Assert
            CollectionAssert.AreEqual(expectedResults, actualResults);
        }
    }
}
