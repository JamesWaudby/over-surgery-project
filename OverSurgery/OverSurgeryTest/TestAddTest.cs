using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestAddTest : TestSetup
    {
        [TestMethod]
        public void TestAddTestSuccess()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            bool expected = true;

            // Act
            bool actual = _controller.AddTest(1, 1, "13/12/2013", 0, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddTestFail()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            bool expected = false;

            // Act
            bool actual = _controller.AddTest(1, 1, "12-12-2013", 0, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddTestDateFail()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            bool expected = false;

            // Act
            bool actual = _controller.AddTest(1, 1, "test", 0, "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
