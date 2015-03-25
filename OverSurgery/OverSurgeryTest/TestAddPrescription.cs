using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using System.Collections.Generic;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestAddPrescription : TestSetup
    {
        [TestMethod]
        public void TestAddPrescriptionSuccess()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            List<Medicine> _medicines = new List<Medicine>();
            _medicines.Add(new Medicine());
            _medicines[0].MedicineID = 1;
            _medicines[0].MedicineName = "Thyroxine";
            _medicines[0].Dosage = "125mg";
            bool expected = true;

            // Act
            bool actual = _controller.AddPrescription(1, 1, "10-10-2013", "04-01-2014", _medicines);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddPrescriptionFail()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            List<Medicine> _medicines = new List<Medicine>();
            _medicines.Add(new Medicine());
            _medicines[0].MedicineID = 1;
            _medicines[0].MedicineName = "Thyroxine";
            _medicines[0].Dosage = "125mg";
            bool expected = false;

            // Act
            bool actual = _controller.AddPrescription(1, 1, "12-10-2013", "01-01-2014", _medicines);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddPrescriptionStartDateFail()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            List<Medicine> _medicines = new List<Medicine>();
            _medicines.Add(new Medicine());
            _medicines[0].MedicineID = 1;
            _medicines[0].MedicineName = "Thyroxine";
            _medicines[0].Dosage = "125mg";
            bool expected = false;

            // Act
            bool actual = _controller.AddPrescription(1, 1, "test", "01-01-2014", _medicines);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddPrescriptionEndDateFail()
        {
            // Arrange
            MedicalController _controller = new MedicalController();
            List<Medicine> _medicines = new List<Medicine>();
            _medicines.Add(new Medicine());
            _medicines[0].MedicineID = 1;
            _medicines[0].MedicineName = "Thyroxine";
            _medicines[0].Dosage = "125mg";
            bool expected = false;

            // Act
            bool actual = _controller.AddPrescription(1, 1, "12-10-2013", "test", _medicines);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
