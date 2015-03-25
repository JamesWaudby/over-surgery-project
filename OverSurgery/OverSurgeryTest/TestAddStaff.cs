using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestAddStaff : TestSetup
    {

        [TestMethod]
        public void TestAddStaffDoesntExist()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            bool expected = true;

            // Act
            //int staffID = mc.GetNextStaffID();
            bool actual = mc.AddStaff(100, "test 2", "test", "test", "test", "test", "test", "test", new DateTime(2013, 02, 05), "test", 0, "single", "00000000000", 0, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddStaffExists()
        {
            // Arrange
            ManagementController mc = new ManagementController();
            bool expected = false;

            // Act
            bool actual = mc.AddStaff(1,"test", "test", "test", "test", "test", "test", "test", new DateTime(2013, 02, 05), "test", 0, "single", "00000000000", 0, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
