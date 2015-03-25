using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryTest
{
    /// <summary>
    /// Summary description for AddPatient
    /// </summary>
    [TestClass]
    public class TestAddPatient : TestSetup
    {
        [TestMethod]
        public void TestAddPatientDoesntExist()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = true;

            // Act
            bool actual = ac.AddPatient("test", "test", "test", "test", "test", "test", "test", new DateTime(1991, 02, 05), "test", 0, "single", "00000000000");

            // Assert
            Assert.AreEqual(expected, actual);

        }



        [TestMethod]
        public void TestAddPatientDoesExist()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = false;

            // Act
            bool actual = ac.AddPatient("test", "test", "test", "test", "test", "test", "test", new DateTime(1991, 02, 05), "test", 0, "married", "00000000000");

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
