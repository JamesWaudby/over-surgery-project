-- MySQL dump 10.13  Distrib 5.1.41, for Win32 (ia32)
--
-- Host: localhost    Database: oversurgerytest
-- ------------------------------------------------------
-- Server version	5.1.41

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
  `absenceId` int(11) NOT NULL,
  `staffID` int(11) NOT NULL,
  `absenceType` int(11) DEFAULT NULL,
  `startDate` datetime DEFAULT NULL,
  `endDate` datetime DEFAULT NULL,
  PRIMARY KEY (`absenceId`,`staffID`),
  KEY `fk_Absence_Staff1_idx` (`staffID`),
  CONSTRAINT `fk_Absence_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `absence`
--

LOCK TABLES `absence` WRITE;
/*!40000 ALTER TABLE `absence` DISABLE KEYS */;
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
  `date` datetime NOT NULL,
  `endDate` datetime NOT NULL,
  PRIMARY KEY (`appointmentID`,`patientID`,`staffID`),
  KEY `fk_Appointments_Staff1_idx` (`staffID`),
  KEY `fk_Appointments_Staff_copy11_idx` (`patientID`),
  CONSTRAINT `fk_Appointments_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Appointments_Staff_copy11` FOREIGN KEY (`patientID`) REFERENCES `patients` (`patientID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
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
  `medicineName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`medicineID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicine`
--

LOCK TABLES `medicine` WRITE;
/*!40000 ALTER TABLE `medicine` DISABLE KEYS */;
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
  `firstName` varchar(45) DEFAULT NULL,
  `lastName` varchar(45) DEFAULT NULL,
  `DoB` datetime DEFAULT NULL,
  `gender` int(11) DEFAULT NULL,
  `telNo` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `addressLine1` varchar(60) DEFAULT NULL,
  `addressLine2` varchar(60) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `county` varchar(45) DEFAULT NULL,
  `postCode` varchar(10) DEFAULT NULL,
  `maritalStatus` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`patientID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patients`
--

LOCK TABLES `patients` WRITE;
/*!40000 ALTER TABLE `patients` DISABLE KEYS */;
INSERT INTO `patients` VALUES (1,'test','test','2013-02-05 00:00:00',0,'00000000000','test','test','test','test','test','test','single');
/*!40000 ALTER TABLE `patients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescriptions`
--

DROP TABLE IF EXISTS `prescriptions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescriptions` (
  `prescriptionID` int(11) NOT NULL,
  `patientID` int(11) NOT NULL,
  `dosage(mg)` int(11) DEFAULT NULL,
  PRIMARY KEY (`prescriptionID`,`patientID`),
  KEY `fk_Prescriptions_Patients1_idx` (`patientID`),
  CONSTRAINT `fk_Prescriptions_Patients1` FOREIGN KEY (`patientID`) REFERENCES `patients` (`patientID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescriptions`
--

LOCK TABLES `prescriptions` WRITE;
/*!40000 ALTER TABLE `prescriptions` DISABLE KEYS */;
/*!40000 ALTER TABLE `prescriptions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescriptions_medicine`
--

DROP TABLE IF EXISTS `prescriptions_medicine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescriptions_medicine` (
  `Prescriptions_prescriptionID` int(11) NOT NULL,
  `Medicine_medicineID` int(11) NOT NULL,
  PRIMARY KEY (`Prescriptions_prescriptionID`,`Medicine_medicineID`),
  KEY `fk_Prescriptions_Medicine_Medicine1_idx` (`Medicine_medicineID`),
  CONSTRAINT `fk_Prescriptions_Medicine_Medicine1` FOREIGN KEY (`Medicine_medicineID`) REFERENCES `medicine` (`medicineID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Prescriptions_Medicine_Prescriptions1` FOREIGN KEY (`Prescriptions_prescriptionID`) REFERENCES `prescriptions` (`prescriptionID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescriptions_medicine`
--

LOCK TABLES `prescriptions_medicine` WRITE;
/*!40000 ALTER TABLE `prescriptions_medicine` DISABLE KEYS */;
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
  `addressLine2` varchar(60) NOT NULL,
  `city` varchar(45) NOT NULL,
  `county` varchar(45) NOT NULL,
  `postCode` varchar(10) NOT NULL,
  `maritalStatus` varchar(15) NOT NULL,
  `role` int(11) NOT NULL,
  PRIMARY KEY (`staffID`)
) ENGINE=InnoDB AUTO_INCREMENT=106 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (105,'Christopher','Walken','1962-06-17 00:00:00',0,'01588 648512','morecowbell@oversurgery.co.uk','1234 Badass Flatsville','Cool Place','Badassville','More Cowbell','CB31 1MC','Badass',0);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stafflogin`
--

DROP TABLE IF EXISTS `stafflogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stafflogin` (
  `staffID` int(11) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`staffID`),
  KEY `fk_StaffLogin_Staff1_idx` (`staffID`),
  CONSTRAINT `fk_StaffLogin_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stafflogin`
--

LOCK TABLES `stafflogin` WRITE;
/*!40000 ALTER TABLE `stafflogin` DISABLE KEYS */;
INSERT INTO `stafflogin` VALUES (105,'test');
/*!40000 ALTER TABLE `stafflogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testresults`
--

DROP TABLE IF EXISTS `testresults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `testresults` (
  `testID` int(11) NOT NULL AUTO_INCREMENT,
  `staffID` int(11) NOT NULL,
  `patientID` int(11) NOT NULL,
  `testResult` mediumtext,
  PRIMARY KEY (`testID`,`staffID`,`patientID`),
  KEY `fk_TestResults_Staff1_idx` (`staffID`),
  KEY `fk_TestResults_Patients1_idx` (`patientID`),
  CONSTRAINT `fk_TestResults_Patients1` FOREIGN KEY (`patientID`) REFERENCES `patients` (`patientID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_TestResults_Staff1` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `testresults`
--

LOCK TABLES `testresults` WRITE;
/*!40000 ALTER TABLE `testresults` DISABLE KEYS */;
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

-- Dump completed on 2013-12-06 14:49:43
