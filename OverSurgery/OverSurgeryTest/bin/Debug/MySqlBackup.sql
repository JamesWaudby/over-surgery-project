-- MySQL dump 10.13  Distrib 5.6.15, for Win64 (x86_64)
--
-- Host: localhost    Database: oversurgerytest
-- ------------------------------------------------------
-- Server version	5.6.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `absence`
--

DROP TABLE IF EXISTS `absence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `absence` (
  `absenceId` int(11) NOT NULL AUTO_INCREMENT,
  `staffID` int(11) NOT NULL,
  `absenceType` int(11) DEFAULT NULL,
  `startDate` datetime DEFAULT NULL,
  `endDate` datetime DEFAULT NULL,
  PRIMARY KEY (`absenceId`,`staffID`),
  KEY `fk_Absence_Staff1_idx` (`staffID`),
  CONSTRAINT `fk_Absence_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `absence`
--

LOCK TABLES `absence` WRITE;
/*!40000 ALTER TABLE `absence` DISABLE KEYS */;
INSERT INTO `absence` VALUES (2,1,0,'2013-12-25 00:00:00','2013-12-26 00:00:00');
/*!40000 ALTER TABLE `absence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `appointments` (
  `appointmentID` int(11) NOT NULL AUTO_INCREMENT,
  `patientID` int(11) NOT NULL,
  `staffID` int(11) NOT NULL,
  `date` datetime DEFAULT NULL,
  `endDate` datetime DEFAULT NULL,
  `appointmentNotes` text,
  PRIMARY KEY (`appointmentID`,`patientID`,`staffID`),
  KEY `fk_Appointments_Staff1_idx` (`staffID`),
  KEY `fk_Appointments_Staff_copy11_idx` (`patientID`),
  CONSTRAINT `fk_Appointments_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Appointments_Staff_copy11` FOREIGN KEY (`patientID`) REFERENCES `patients` (`patientID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1,1,1,'2000-01-01 09:00:00','2000-01-01 09:15:00',NULL);
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicine`
--

DROP TABLE IF EXISTS `medicine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medicine` (
  `medicineID` int(11) NOT NULL AUTO_INCREMENT,
  `medicineName` varchar(45) NOT NULL,
  `dosage` varchar(10) NOT NULL,
  `extendable` tinyint(4) NOT NULL DEFAULT '0',
  PRIMARY KEY (`medicineID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicine`
--

LOCK TABLES `medicine` WRITE;
/*!40000 ALTER TABLE `medicine` DISABLE KEYS */;
INSERT INTO `medicine` VALUES (1,'Thyroxine','125mg',0),(2,'Thyroxine','50mg',1);
/*!40000 ALTER TABLE `medicine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patients`
--

DROP TABLE IF EXISTS `patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patients` (
  `patientID` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(45) NOT NULL,
  `lastName` varchar(45) NOT NULL,
  `DoB` datetime NOT NULL,
  `gender` int(11) NOT NULL,
  `telNo` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `addressLine1` varchar(60) NOT NULL,
  `addressLine2` varchar(60) DEFAULT NULL,
  `city` varchar(45) NOT NULL,
  `county` varchar(45) NOT NULL,
  `postCode` varchar(10) NOT NULL,
  `maritalStatus` varchar(15) NOT NULL,
  PRIMARY KEY (`patientID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (1,'test','test','1991-02-05 00:00:00',0,'00000000000','test','test','test','test','test','test','married'),(4,'test','test','2013-02-05 00:00:00',0,'00000000000','test','test','test','test','test','test','single');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescriptions`
--

DROP TABLE IF EXISTS `prescriptions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescriptions` (
  `prescriptionID` int(11) NOT NULL AUTO_INCREMENT,
  `patientID` int(11) NOT NULL,
  `staffID` int(11) NOT NULL,
  `startDate` datetime NOT NULL,
  `endDate` datetime NOT NULL,
  `extended` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`prescriptionID`,`patientID`,`staffID`),
  KEY `fk_Prescriptions_Patients1_idx` (`patientID`),
  KEY `fk_Prescriptions_Staff1_idx` (`staffID`),
  CONSTRAINT `fk_Prescriptions_Patients1` FOREIGN KEY (`patientID`) REFERENCES `patients` (`patientID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Prescriptions_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescriptions`
--

LOCK TABLES `prescriptions` WRITE;
/*!40000 ALTER TABLE `prescriptions` DISABLE KEYS */;
INSERT INTO `prescriptions` VALUES (1,1,1,'2013-10-12 00:00:00','2014-01-01 00:00:00',0),(2,1,1,'2013-01-01 00:00:00','2013-02-01 00:00:00',0);
/*!40000 ALTER TABLE `prescriptions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescriptions_medicine`
--

DROP TABLE IF EXISTS `prescriptions_medicine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescriptions_medicine` (
  `prescriptionMedicationID` int(11) NOT NULL AUTO_INCREMENT,
  `prescriptionID` int(11) NOT NULL,
  `medicineID` int(11) NOT NULL,
  PRIMARY KEY (`prescriptionMedicationID`),
  KEY `fk_PrescriptionMedication_Prescriptions1_idx` (`prescriptionID`),
  KEY `fk_PrescriptionMedication_Medicine1_idx` (`medicineID`),
  CONSTRAINT `fk_PrescriptionMedication_Medicine1` FOREIGN KEY (`medicineID`) REFERENCES `medicine` (`medicineID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PrescriptionMedication_Prescriptions1` FOREIGN KEY (`prescriptionID`) REFERENCES `prescriptions` (`prescriptionID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescriptions_medicine`
--

LOCK TABLES `prescriptions_medicine` WRITE;
/*!40000 ALTER TABLE `prescriptions_medicine` DISABLE KEYS */;
INSERT INTO `prescriptions_medicine` VALUES (1,1,1),(2,2,2);
/*!40000 ALTER TABLE `prescriptions_medicine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `staffID` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(45) NOT NULL,
  `lastName` varchar(45) NOT NULL,
  `DoB` datetime NOT NULL,
  `gender` int(11) NOT NULL,
  `telNo` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `addressLine1` varchar(60) NOT NULL,
  `addressLine2` varchar(60) DEFAULT NULL,
  `city` varchar(45) NOT NULL,
  `county` varchar(45) NOT NULL,
  `postCode` varchar(10) NOT NULL,
  `maritalStatus` varchar(15) NOT NULL,
  `role` int(11) NOT NULL,
  PRIMARY KEY (`staffID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'test','test','2013-02-05 00:00:00',0,'00000000000','test','test','test','test','test','test','single',1);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staffLogin`
--

DROP TABLE IF EXISTS `staffLogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staffLogin` (
  `staffID` int(11) NOT NULL,
  `password` varchar(100) NOT NULL,
  `resetFlag` tinyint(1) NOT NULL,
  PRIMARY KEY (`staffID`),
  KEY `fk_StaffLogin_Staff1_idx` (`staffID`),
  CONSTRAINT `fk_StaffLogin_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffLogin`
--

LOCK TABLES `staffLogin` WRITE;
/*!40000 ALTER TABLE `staffLogin` DISABLE KEYS */;
INSERT INTO `staffLogin` VALUES (1,'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08',0);
/*!40000 ALTER TABLE `staffLogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testresults`
--

DROP TABLE IF EXISTS `testresults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `testresults` (
  `testID` int(11) NOT NULL AUTO_INCREMENT,
  `patientID` int(11) NOT NULL,
  `staffID` int(11) NOT NULL,
  `testDate` datetime NOT NULL,
  `testType` int(11) NOT NULL,
  `testResult` text NOT NULL,
  PRIMARY KEY (`testID`,`patientID`,`staffID`),
  KEY `fk_TestResults_Staff1_idx` (`staffID`),
  KEY `fk_TestResults_Patients1_idx` (`patientID`),
  CONSTRAINT `fk_TestResults_Patients1` FOREIGN KEY (`patientID`) REFERENCES `patients` (`patientID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TestResults_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `testresults`
--

LOCK TABLES `testresults` WRITE;
/*!40000 ALTER TABLE `testresults` DISABLE KEYS */;
INSERT INTO `testresults` VALUES (1,1,1,'2013-12-12 00:00:00',0,'test');
/*!40000 ALTER TABLE `testresults` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-12-23  9:48:35

