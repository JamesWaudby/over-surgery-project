using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestAddAbsence : TestSetup
    {

        [TestMethod]
        public void TestAddAbsenceSuccess()
        {
            // Arrange
            ManagementController _controller = new ManagementController();
            bool expected = true;

            // Act
            bool actual = _controller.AddAbsence(1, 0, "26-12-2014", "26-12-2014");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddAbsenceFail()
        {
            // Arrange
            ManagementController _controller = new ManagementController();
            bool expected = false;

            // Act
            bool actual = _controller.AddAbsence(1, 0, "25-12-2013", "26-12-2013");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
