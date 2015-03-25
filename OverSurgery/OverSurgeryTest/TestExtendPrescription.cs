using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;
using System.Collections.Generic;

namespace OverSurgeryTest
{
    [TestClass]
    public class TestExtendPrescription : TestSetup
    {
        [TestMethod]
        public void TestExtendSuccess()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = true;

            Prescription prescription = new Prescription();
            prescription.PrescriptionID = 2;
            prescription.PatientID = 1;
            prescription.StaffID = 1;
            prescription.StartDate = new DateTime(2013, 01, 01);
            prescription.EndDate = new DateTime(2013, 02, 01);
            prescription.Extended = false;
            prescription.Medicines = new List<Medicine>();
            prescription.Medicines.Add(new Medicine());
            prescription.Medicines[0].MedicineID = 2;
            prescription.Medicines[0].MedicineName = "Thyroxine";
            prescription.Medicines[0].Dosage = "50mg";
            prescription.Medicines[0].Extendable = true;

            // Act
            bool actual = ac.ExtendPrescription(prescription);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestExtendFail()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = false;

            Prescription prescription = new Prescription();
            prescription.PrescriptionID = 2;
            prescription.PatientID = 1;
            prescription.StaffID = 1;
            prescription.StartDate = new DateTime(2013, 01, 01);
            prescription.EndDate = new DateTime(2013, 02, 01);
            prescription.Extended = true;
            prescription.Medicines = new List<Medicine>();
            prescription.Medicines.Add(new Medicine());
            prescription.Medicines[0].MedicineID = 2;
            prescription.Medicines[0].MedicineName = "Thyroxine";
            prescription.Medicines[0].Dosage = "50mg";
            prescription.Medicines[0].Extendable = true;

            // Act
            bool actual = ac.ExtendPrescription(prescription);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestExtendFailDoesntExist()
        {
            // Arrange
            AdminController ac = new AdminController();
            bool expected = false;

            Prescription prescription = new Prescription();
            prescription.PrescriptionID = 5;
            prescription.PatientID = 10;
            prescription.StaffID = 1;
            prescription.StartDate = new DateTime(2014, 01, 01);
            prescription.EndDate = new DateTime(2014, 02, 01);
            prescription.Extended = false;
            prescription.Medicines = new List<Medicine>();
            prescription.Medicines.Add(new Medicine());
            prescription.Medicines[0].MedicineID = 2;
            prescription.Medicines[0].MedicineName = "Thyroxine";
            prescription.Medicines[0].Dosage = "50mg";
            prescription.Medicines[0].Extendable = true;

            // Act
            bool actual = ac.ExtendPrescription(prescription);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
