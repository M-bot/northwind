CREATE DATABASE  IF NOT EXISTS `northwind` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `northwind`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: northwind
-- ------------------------------------------------------
-- Server version	5.6.12-log

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
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `category` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'None');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `customer list`
--

DROP TABLE IF EXISTS `customer list`;
/*!50001 DROP VIEW IF EXISTS `customer list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `customer list` (
  `ID` tinyint NOT NULL,
  `Company` tinyint NOT NULL,
  `First Name` tinyint NOT NULL,
  `Last Name` tinyint NOT NULL,
  `Email Address` tinyint NOT NULL,
  `Business Phone` tinyint NOT NULL,
  `Job Title` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `customers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Company` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `EmailAddress` varchar(50) DEFAULT NULL,
  `JobTitle` varchar(50) DEFAULT NULL,
  `BusinessPhone` varchar(25) DEFAULT NULL,
  `HomePhone` varchar(25) DEFAULT NULL,
  `MobilePhone` varchar(25) DEFAULT NULL,
  `Address` mediumtext,
  `FaxNumber` varchar(25) DEFAULT NULL,
  `City` varchar(50) DEFAULT NULL,
  `State_Province` int(11) DEFAULT '0',
  `ZIP_PostalCode` varchar(15) DEFAULT NULL,
  `Country_Region` int(11) DEFAULT '1',
  `WebPage` mediumtext,
  `Notes` mediumtext,
  `Attachments` mediumtext,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Company A','Bedecs','Anna','anna.bedecs@aol.com','Owner','(123)555-0100','(713)111-1111','(321)231-2331','123 1st Street','(123)555-0101','Seattle',1,'99999',1,NULL,NULL,NULL),(2,'Company B','Gratacos Solsona','Antonio','gratocs.solsona@aol.com','Owner','(123)555-0100','(294)342-1832','(320)213-2421','123 2nd Street','(123)555-0101','Boston',2,'99999',1,NULL,NULL,NULL),(3,'Company C','Axen','Thomas',NULL,'Purchasing Representative','(123)555-0100',NULL,NULL,'123 3rd Street','(123)555-0101','Los Angelas',3,'99999',1,NULL,NULL,NULL),(4,'Company D','Lee','Christina',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'123 4th Street','(123)555-0101','New York',4,'99999',1,NULL,NULL,NULL),(5,'Company E','O’Donnell','Martin',NULL,'Owner','(123)555-0100',NULL,NULL,'123 5th Street','(123)555-0101','Minneapolis',5,'99999',1,NULL,NULL,NULL),(6,'Company F','Pérez-Olaeta','Francisco',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'123 6th Street','(123)555-0101','Milwaukee',6,'99999',1,NULL,NULL,NULL),(7,'Company G','Xie','Ming-Yang',NULL,'Owner','(123)555-0100',NULL,NULL,'123 7th Street','(123)555-0101','Boise',7,'99999',1,NULL,NULL,NULL),(8,'Company H','Andersen','Elizabeth','','Purchasing Representative','(123)555-0101',NULL,'','123 8th Street','(123)555-0101','Portland',8,'99999',1,'','',NULL),(9,'Company I','Mortensen','Sven',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'123 9th Street','(123)555-0101','Salt Lake City',9,'99999',1,NULL,NULL,NULL),(10,'Company J','Wacker','Roland',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'123 10th Street','(123)555-0101','Chicago',10,'99999',1,NULL,NULL,NULL),(11,'Company K','Krschne','Peter',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'123 11th Street','(123)555-0101','Miami',11,'99999',1,NULL,NULL,NULL),(12,'Company L','Edwards','John',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'123 12th Street','(123)555-0101','Las Vegas',12,'99999',1,NULL,NULL,NULL),(13,'Company M','Ludick','Andre',NULL,'Purchasing Representative','(123)555-0100',NULL,NULL,'456 13th Street','(123)555-0101','Memphis',13,'99999',1,NULL,NULL,NULL),(14,'Company N','Grilo','Carlos',NULL,'Purchasing Representative','(123)555-0100',NULL,NULL,'456 14th Street','(123)555-0101','Denver',14,'99999',1,NULL,NULL,NULL),(15,'Company O','Kupkova','Helena',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'456 15th Street','(123)555-0101','Honolulu',15,'99999',1,NULL,NULL,NULL),(16,'Company P','Goldschmidt','Daniel',NULL,'Purchasing Representative','(123)555-0100',NULL,NULL,'456 16th Street','(123)555-0101','San Francisco',16,'99999',1,NULL,NULL,NULL),(17,'Company Q','Bagel','Jean Philippe',NULL,'Owner','(123)555-0100',NULL,NULL,'456 17th Street','(123)555-0101','Seattle',17,'99999',1,NULL,NULL,NULL),(18,'Company R','Autier Miconi','Catherine',NULL,'Purchasing Representative','(123)555-0100',NULL,NULL,'456 18th Street','(123)555-0101','Boston',18,'99999',1,NULL,NULL,NULL),(19,'Company S','Eggerer','Alexander',NULL,'Accounting Assistant','(123)555-0100',NULL,NULL,'789 19th Street','(123)555-0101','Los Angelas',19,'99999',1,NULL,NULL,NULL),(20,'Company T','Li','George',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'789 20th Street','(123)555-0101','New York',20,'99999',1,NULL,NULL,NULL),(21,'Company U','Tham','Bernard',NULL,'Accounting Manager','(123)555-0100',NULL,NULL,'789 21th Street','(123)555-0101','Minneapolis',21,'99999',1,NULL,NULL,NULL),(22,'Company V','Ramos','Luciana',NULL,'Purchasing Assistant','(123)555-0100',NULL,NULL,'789 22th Street','(123)555-0101','Milwaukee',22,'99999',1,NULL,NULL,NULL),(23,'Company W','Entin','Michael',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'789 23th Street','(123)555-0101','Portland',23,'99999',1,NULL,NULL,NULL),(24,'Company X','Hasselberg','Jonas',NULL,'Owner','(123)555-0100',NULL,NULL,'789 24th Street','(123)555-0101','Salt Lake City',24,'99999',1,NULL,NULL,NULL),(25,'Company Y','Rodman','John',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'789 25th Street','(123)555-0101','Chicago',25,'99999',1,NULL,NULL,NULL),(26,'Company Z','Liu','Run',NULL,'Accounting Assistant','(123)555-0100',NULL,NULL,'789 26th Street','(123)555-0101','Miami',26,'99999',1,NULL,NULL,NULL),(27,'Company AA','Toh','Karen',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'789 27th Street','(123)555-0101','Las Vegas',27,'99999',1,NULL,NULL,NULL),(28,'Company BB','Raghav','Amritansh',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'789 28th Street','(123)555-0101','Memphis',28,'99999',1,NULL,NULL,NULL),(29,'Company CC','Lee','Soo Jung',NULL,'Purchasing Manager','(123)555-0100',NULL,NULL,'789 29th Street','(123)555-0101','Denver',29,'99999',1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `customers extended`
--

DROP TABLE IF EXISTS `customers extended`;
/*!50001 DROP VIEW IF EXISTS `customers extended`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `customers extended` (
  `FileAs` tinyint NOT NULL,
  `ContactName` tinyint NOT NULL,
  `ID` tinyint NOT NULL,
  `Company` tinyint NOT NULL,
  `LastName` tinyint NOT NULL,
  `FirstName` tinyint NOT NULL,
  `EmailAddress` tinyint NOT NULL,
  `JobTitle` tinyint NOT NULL,
  `BusinessPhone` tinyint NOT NULL,
  `HomePhone` tinyint NOT NULL,
  `MobilePhone` tinyint NOT NULL,
  `Address` tinyint NOT NULL,
  `FaxNumber` tinyint NOT NULL,
  `City` tinyint NOT NULL,
  `State_Province` tinyint NOT NULL,
  `ZIP_PostalCode` tinyint NOT NULL,
  `Country_Region` tinyint NOT NULL,
  `WebPage` tinyint NOT NULL,
  `Notes` tinyint NOT NULL,
  `Attachments` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `employee list`
--

DROP TABLE IF EXISTS `employee list`;
/*!50001 DROP VIEW IF EXISTS `employee list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `employee list` (
  `ID` tinyint NOT NULL,
  `First Name` tinyint NOT NULL,
  `Last Name` tinyint NOT NULL,
  `Email Address` tinyint NOT NULL,
  `Business Phone` tinyint NOT NULL,
  `Job Title` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `employee privileges`
--

DROP TABLE IF EXISTS `employee privileges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee privileges` (
  `EmployeeID` int(11) NOT NULL,
  `PrivilegeID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee privileges`
--

LOCK TABLES `employee privileges` WRITE;
/*!40000 ALTER TABLE `employee privileges` DISABLE KEYS */;
INSERT INTO `employee privileges` VALUES (2,2);
/*!40000 ALTER TABLE `employee privileges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employees` (
  `ID` int(11) NOT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `EmailAddress` varchar(50) DEFAULT NULL,
  `JobTitle` varchar(50) DEFAULT NULL,
  `BusinessPhone` varchar(25) DEFAULT NULL,
  `HomePhone` varchar(25) DEFAULT NULL,
  `MobilePhone` varchar(25) DEFAULT NULL,
  `FaxNumber` varchar(25) DEFAULT NULL,
  `Address` mediumtext,
  `City` varchar(50) DEFAULT NULL,
  `State_Province` int(11) DEFAULT '0',
  `ZIP_PostalCode` varchar(15) DEFAULT NULL,
  `Country_Region` int(11) DEFAULT '1',
  `WebPage` mediumtext,
  `Notes` mediumtext,
  `Attachments` mediumtext,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Freehafer','Nancy','nancy@northwindtraders.com','Sales Representative','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 1st Avenue','Seattle',47,'99999',1,'#http://northwindtraders.com#',NULL,NULL),(2,'Cencini','Andrew','andrew@northwindtraders.com','Vice President, Sales','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 2nd Avenue','Bellevue',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#','Joined the company as a sales representative, was promoted to sales manager and was then named vice president of sales.',NULL),(3,'Kotas','Jane','jan@northwindtraders.com','Sales Representative','(123)555-0100','(123)555-0102','','(123)555-0103','123 3rd Avenue','Redmond',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#','Was hired as a sales associate and was promoted to sales representative.',NULL),(4,'Sergienko','Mariya','mariya@northwindtraders.com','Sales Representative','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 4th Avenue','Kirkland',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#',NULL,NULL),(5,'Thorpe','Steven','steven@northwindtraders.com','Sales Manager','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 5th Avenue','Seattle',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#','Joined the company as a sales representative and was promoted to sales manager.  Fluent in French.',NULL),(6,'Neipper','Michael','michael@northwindtraders.com','Sales Representative','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 6th Avenue','Redmond',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#','Fluent in Japanese and can read and write French, Portuguese, and Spanish.',NULL),(7,'Zare','Robert','robert@northwindtraders.com','Sales Representative','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 7th Avenue','Seattle',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#',NULL,NULL),(8,'Giussani','Laura','laura@northwindtraders.com','Sales Coordinator','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 8th Avenue','Redmond',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#','Reads and writes French.',NULL),(9,'Hellung-Larsen','Anne','anne@northwindtraders.com','Sales Representative','(123)555-0100','(123)555-0102',NULL,'(123)555-0103','123 9th Avenue','Seattle',47,'99999',1,'http://northwindtraders.com#http://northwindtraders.com/#','Fluent in French and German.',NULL);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `employees extended`
--

DROP TABLE IF EXISTS `employees extended`;
/*!50001 DROP VIEW IF EXISTS `employees extended`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `employees extended` (
  `FileAs` tinyint NOT NULL,
  `EmployeeName` tinyint NOT NULL,
  `ID` tinyint NOT NULL,
  `LastName` tinyint NOT NULL,
  `FirstName` tinyint NOT NULL,
  `EmailAddress` tinyint NOT NULL,
  `JobTitle` tinyint NOT NULL,
  `BusinessPhone` tinyint NOT NULL,
  `HomePhone` tinyint NOT NULL,
  `MobilePhone` tinyint NOT NULL,
  `FaxNumber` tinyint NOT NULL,
  `Address` tinyint NOT NULL,
  `City` tinyint NOT NULL,
  `State_Province` tinyint NOT NULL,
  `ZIP_PostalCode` tinyint NOT NULL,
  `Country_Region` tinyint NOT NULL,
  `WebPage` tinyint NOT NULL,
  `Notes` tinyint NOT NULL,
  `Attachments` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!50001 DROP VIEW IF EXISTS `inventory`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory` (
  `Product ID` tinyint NOT NULL,
  `Product Name` tinyint NOT NULL,
  `Product Code` tinyint NOT NULL,
  `Qty Purchased` tinyint NOT NULL,
  `Qty Sold` tinyint NOT NULL,
  `Qty On Hold` tinyint NOT NULL,
  `Qty On Hand` tinyint NOT NULL,
  `Qty Available` tinyint NOT NULL,
  `Qty On Order` tinyint NOT NULL,
  `Qty On Back Order` tinyint NOT NULL,
  `Reorder Level` tinyint NOT NULL,
  `Target Level` tinyint NOT NULL,
  `Qty Below Target Level` tinyint NOT NULL,
  `Current Level` tinyint NOT NULL,
  `Qty To Reorder` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory list`
--

DROP TABLE IF EXISTS `inventory list`;
/*!50001 DROP VIEW IF EXISTS `inventory list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory list` (
  `#` tinyint NOT NULL,
  `Product Name` tinyint NOT NULL,
  `Qty On Hand` tinyint NOT NULL,
  `Qty On Hold` tinyint NOT NULL,
  `Qty Available` tinyint NOT NULL,
  `Qty On Order` tinyint NOT NULL,
  `Combined Total` tinyint NOT NULL,
  `Target Level` tinyint NOT NULL,
  `Qty To Reorder` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory on hold`
--

DROP TABLE IF EXISTS `inventory on hold`;
/*!50001 DROP VIEW IF EXISTS `inventory on hold`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory on hold` (
  `ID` tinyint NOT NULL,
  `Product` tinyint NOT NULL,
  `Quantity On Hold` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory on order`
--

DROP TABLE IF EXISTS `inventory on order`;
/*!50001 DROP VIEW IF EXISTS `inventory on order`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory on order` (
  `ID` tinyint NOT NULL,
  `Product` tinyint NOT NULL,
  `Quantity on Order` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory purchased`
--

DROP TABLE IF EXISTS `inventory purchased`;
/*!50001 DROP VIEW IF EXISTS `inventory purchased`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory purchased` (
  `ID` tinyint NOT NULL,
  `Product` tinyint NOT NULL,
  `Quantity Purchased` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory sold`
--

DROP TABLE IF EXISTS `inventory sold`;
/*!50001 DROP VIEW IF EXISTS `inventory sold`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory sold` (
  `ID` tinyint NOT NULL,
  `Product` tinyint NOT NULL,
  `Quantity Sold` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory to reorder`
--

DROP TABLE IF EXISTS `inventory to reorder`;
/*!50001 DROP VIEW IF EXISTS `inventory to reorder`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory to reorder` (
  `#` tinyint NOT NULL,
  `Product` tinyint NOT NULL,
  `Qty Available` tinyint NOT NULL,
  `Reorder Level` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `inventory transaction types`
--

DROP TABLE IF EXISTS `inventory transaction types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory transaction types` (
  `ID` tinyint(4) NOT NULL AUTO_INCREMENT,
  `TypeName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory transaction types`
--

LOCK TABLES `inventory transaction types` WRITE;
/*!40000 ALTER TABLE `inventory transaction types` DISABLE KEYS */;
INSERT INTO `inventory transaction types` VALUES (1,'Purchased'),(2,'Sold'),(3,'On Hold'),(4,'Waste');
/*!40000 ALTER TABLE `inventory transaction types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory transactions`
--

DROP TABLE IF EXISTS `inventory transactions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory transactions` (
  `TransactionID` int(11) NOT NULL AUTO_INCREMENT,
  `TransactionType` tinyint(4) DEFAULT NULL,
  `TransactionCreatedDate` datetime DEFAULT NULL,
  `TransactionModifiedDate` datetime DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `PurchaseOrderID` int(11) DEFAULT NULL,
  `CustomerOrderID` int(11) DEFAULT NULL,
  `Comments` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TransactionID`),
  UNIQUE KEY `Transaction ID` (`TransactionID`)
) ENGINE=InnoDB AUTO_INCREMENT=137 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory transactions`
--

LOCK TABLES `inventory transactions` WRITE;
/*!40000 ALTER TABLE `inventory transactions` DISABLE KEYS */;
INSERT INTO `inventory transactions` VALUES (35,1,'2006-03-22 16:02:28','2006-03-22 16:02:28',80,75,NULL,NULL,NULL),(36,1,'2006-03-22 16:02:48','2006-03-22 16:02:48',72,40,NULL,NULL,NULL),(37,1,'2006-03-22 16:03:04','2006-03-22 16:03:04',52,100,NULL,NULL,NULL),(38,1,'2006-03-22 16:03:09','2006-03-22 16:03:09',56,120,NULL,NULL,NULL),(39,1,'2006-03-22 16:03:14','2006-03-22 16:03:14',57,80,NULL,NULL,NULL),(40,1,'2006-03-22 16:03:40','2006-03-22 16:03:40',6,100,NULL,NULL,NULL),(41,1,'2006-03-22 16:03:47','2006-03-22 16:03:47',7,40,NULL,NULL,NULL),(42,1,'2006-03-22 16:03:54','2006-03-22 16:03:54',8,40,NULL,NULL,NULL),(43,1,'2006-03-22 16:04:02','2006-03-22 16:04:02',14,40,NULL,NULL,NULL),(44,1,'2006-03-22 16:04:07','2006-03-22 16:04:07',17,40,NULL,NULL,NULL),(45,1,'2006-03-22 16:04:12','2006-03-22 16:04:12',19,20,NULL,NULL,NULL),(46,1,'2006-03-22 16:04:17','2006-03-22 16:04:17',20,40,NULL,NULL,NULL),(47,1,'2006-03-22 16:04:20','2006-03-22 16:04:20',21,20,NULL,NULL,NULL),(48,1,'2006-03-22 16:04:24','2006-03-22 16:04:24',40,120,NULL,NULL,NULL),(49,1,'2006-03-22 16:04:28','2006-03-22 16:04:28',41,40,NULL,NULL,NULL),(50,1,'2006-03-22 16:04:31','2006-03-22 16:04:31',48,100,NULL,NULL,NULL),(51,1,'2006-03-22 16:04:38','2006-03-22 16:04:38',51,40,NULL,NULL,NULL),(52,1,'2006-03-22 16:04:41','2006-03-22 16:04:41',74,20,NULL,NULL,NULL),(53,1,'2006-03-22 16:04:45','2006-03-22 16:04:45',77,60,NULL,NULL,NULL),(54,1,'2006-03-22 16:05:07','2006-03-22 16:05:07',3,100,NULL,NULL,NULL),(55,1,'2006-03-22 16:05:11','2006-03-22 16:05:11',4,40,NULL,NULL,NULL),(56,1,'2006-03-22 16:05:14','2006-03-22 16:05:14',5,40,NULL,NULL,NULL),(57,1,'2006-03-22 16:05:26','2006-03-22 16:05:26',65,40,NULL,NULL,NULL),(58,1,'2006-03-22 16:05:32','2006-03-22 16:05:32',66,80,NULL,NULL,NULL),(59,1,'2006-03-22 16:05:47','2006-03-22 16:05:47',1,40,NULL,NULL,NULL),(60,1,'2006-03-22 16:05:51','2006-03-22 16:05:51',34,60,NULL,NULL,NULL),(61,1,'2006-03-22 16:06:00','2006-03-22 16:06:00',43,100,NULL,NULL,NULL),(62,1,'2006-03-22 16:06:03','2006-03-22 16:06:03',81,125,NULL,NULL,NULL),(63,2,'2006-03-22 16:07:56','2006-03-24 11:03:00',80,30,NULL,NULL,NULL),(64,2,'2006-03-22 16:08:19','2006-03-22 16:08:59',7,10,NULL,NULL,NULL),(65,2,'2006-03-22 16:08:29','2006-03-22 16:08:59',51,10,NULL,NULL,NULL),(66,2,'2006-03-22 16:08:37','2006-03-22 16:08:59',80,10,NULL,NULL,NULL),(67,2,'2006-03-22 16:09:46','2006-03-22 16:10:27',1,15,NULL,NULL,NULL),(68,2,'2006-03-22 16:10:06','2006-03-22 16:10:27',43,20,NULL,NULL,NULL),(69,2,'2006-03-22 16:11:39','2006-03-24 11:00:55',19,20,NULL,NULL,NULL),(70,2,'2006-03-22 16:11:56','2006-03-24 10:59:41',48,10,NULL,NULL,NULL),(71,2,'2006-03-22 16:12:29','2006-03-24 10:57:38',8,17,NULL,NULL,NULL),(72,1,'2006-03-24 10:41:30','2006-03-24 10:41:30',81,200,NULL,NULL,NULL),(73,2,'2006-03-24 10:41:33','2006-03-24 10:41:42',81,200,NULL,NULL,'Fill Back Ordered product, Order #40'),(74,1,'2006-03-24 10:53:13','2006-03-24 10:53:13',48,100,NULL,NULL,NULL),(75,2,'2006-03-24 10:53:16','2006-03-24 10:55:46',48,100,NULL,NULL,'Fill Back Ordered product, Order #39'),(76,1,'2006-03-24 10:53:36','2006-03-24 10:53:36',43,300,NULL,NULL,NULL),(77,2,'2006-03-24 10:53:39','2006-03-24 10:56:57',43,300,NULL,NULL,'Fill Back Ordered product, Order #38'),(78,1,'2006-03-24 10:54:04','2006-03-24 10:54:04',41,200,NULL,NULL,NULL),(79,2,'2006-03-24 10:54:07','2006-03-24 10:58:40',41,200,NULL,NULL,'Fill Back Ordered product, Order #36'),(80,1,'2006-03-24 10:54:33','2006-03-24 10:54:33',19,30,NULL,NULL,NULL),(81,2,'2006-03-24 10:54:35','2006-03-24 11:02:02',19,30,NULL,NULL,'Fill Back Ordered product, Order #33'),(82,1,'2006-03-24 10:54:58','2006-03-24 10:54:58',34,100,NULL,NULL,NULL),(83,2,'2006-03-24 10:55:02','2006-03-24 11:03:00',34,100,NULL,NULL,'Fill Back Ordered product, Order #30'),(84,2,'2006-03-24 14:48:15','2006-04-04 11:41:14',6,10,NULL,NULL,NULL),(85,2,'2006-03-24 14:48:23','2006-04-04 11:41:14',4,10,NULL,NULL,NULL),(86,3,'2006-03-24 14:49:16','2006-03-24 14:49:16',80,20,NULL,NULL,NULL),(87,3,'2006-03-24 14:49:20','2006-03-24 14:49:20',81,50,NULL,NULL,NULL),(88,3,'2006-03-24 14:50:09','2006-03-24 14:50:09',1,25,NULL,NULL,NULL),(89,3,'2006-03-24 14:50:14','2006-03-24 14:50:14',43,25,NULL,NULL,NULL),(90,3,'2006-03-24 14:50:18','2006-03-24 14:50:18',81,25,NULL,NULL,NULL),(91,2,'2006-03-24 14:51:03','2006-04-04 11:09:24',40,50,NULL,NULL,NULL),(92,2,'2006-03-24 14:55:03','2006-04-04 11:06:56',21,20,NULL,NULL,NULL),(93,2,'2006-03-24 14:55:39','2006-04-04 11:06:13',5,25,NULL,NULL,NULL),(94,2,'2006-03-24 14:55:52','2006-04-04 11:06:13',41,30,NULL,NULL,NULL),(95,2,'2006-03-24 14:56:09','2006-04-04 11:06:13',40,30,NULL,NULL,NULL),(96,3,'2006-03-30 16:46:34','2006-03-30 16:46:34',34,12,NULL,NULL,NULL),(97,3,'2006-03-30 17:23:27','2006-03-30 17:23:27',34,10,NULL,NULL,NULL),(98,3,'2006-03-30 17:24:33','2006-03-30 17:24:33',34,1,NULL,NULL,NULL),(99,2,'2006-04-03 13:50:08','2006-04-03 13:50:15',48,10,NULL,NULL,NULL),(100,1,'2006-04-04 11:00:54','2006-04-04 11:00:54',57,100,NULL,NULL,NULL),(101,2,'2006-04-04 11:00:56','2006-04-04 11:08:49',57,100,NULL,NULL,'Fill Back Ordered product, Order #46'),(102,1,'2006-04-04 11:01:14','2006-04-04 11:01:14',34,50,NULL,NULL,NULL),(103,1,'2006-04-04 11:01:35','2006-04-04 11:01:35',43,250,NULL,NULL,NULL),(104,3,'2006-04-04 11:01:37','2006-04-04 11:01:37',43,300,NULL,NULL,'Fill Back Ordered product, Order #41'),(105,1,'2006-04-04 11:01:55','2006-04-04 11:01:55',8,25,NULL,NULL,NULL),(106,2,'2006-04-04 11:01:58','2006-04-04 11:07:37',8,25,NULL,NULL,'Fill Back Ordered product, Order #48'),(107,1,'2006-04-04 11:02:17','2006-04-04 11:02:17',34,300,NULL,NULL,NULL),(108,2,'2006-04-04 11:02:19','2006-04-04 11:08:14',34,300,NULL,NULL,'Fill Back Ordered product, Order #47'),(109,1,'2006-04-04 11:02:37','2006-04-04 11:02:37',19,25,NULL,NULL,NULL),(110,2,'2006-04-04 11:02:39','2006-04-04 11:41:14',19,10,NULL,NULL,'Fill Back Ordered product, Order #42'),(111,1,'2006-04-04 11:02:56','2006-04-04 11:02:56',19,10,NULL,NULL,NULL),(112,2,'2006-04-04 11:02:58','2006-04-04 11:07:37',19,25,NULL,NULL,'Fill Back Ordered product, Order #48'),(113,1,'2006-04-04 11:03:12','2006-04-04 11:03:12',72,50,NULL,NULL,NULL),(114,2,'2006-04-04 11:03:14','2006-04-04 11:08:49',72,50,NULL,NULL,'Fill Back Ordered product, Order #46'),(115,1,'2006-04-04 11:03:38','2006-04-04 11:03:38',41,50,NULL,NULL,NULL),(116,2,'2006-04-04 11:03:39','2006-04-04 11:09:24',41,50,NULL,NULL,'Fill Back Ordered product, Order #45'),(117,2,'2006-04-04 11:04:55','2006-04-04 11:05:04',34,87,NULL,NULL,NULL),(118,2,'2006-04-04 11:35:50','2006-04-04 11:35:54',51,30,NULL,NULL,NULL),(119,2,'2006-04-04 11:35:51','2006-04-04 11:35:54',7,30,NULL,NULL,NULL),(120,2,'2006-04-04 11:36:15','2006-04-04 11:36:21',17,40,NULL,NULL,NULL),(121,2,'2006-04-04 11:36:39','2006-04-04 11:36:47',6,90,NULL,NULL,NULL),(122,2,'2006-04-04 11:37:06','2006-04-04 11:37:09',4,30,NULL,NULL,NULL),(123,2,'2006-04-04 11:37:45','2006-04-04 11:37:49',48,40,NULL,NULL,NULL),(124,2,'2006-04-04 11:38:07','2006-04-04 11:38:11',48,40,NULL,NULL,NULL),(125,2,'2006-04-04 11:38:27','2006-04-04 11:38:32',41,10,NULL,NULL,NULL),(126,2,'2006-04-04 11:38:48','2006-04-04 11:38:53',43,5,NULL,NULL,NULL),(127,2,'2006-04-04 11:39:12','2006-04-04 11:39:29',40,40,NULL,NULL,NULL),(128,2,'2006-04-04 11:39:50','2006-04-04 11:39:53',8,20,NULL,NULL,NULL),(129,2,'2006-04-04 11:40:13','2006-04-04 11:40:16',80,15,NULL,NULL,NULL),(130,2,'2006-04-04 11:40:32','2006-04-04 11:40:38',74,20,NULL,NULL,NULL),(131,2,'2006-04-04 11:41:39','2006-04-04 11:41:45',72,40,NULL,NULL,NULL),(132,2,'2006-04-04 11:42:17','2006-04-04 11:42:26',3,50,NULL,NULL,NULL),(133,2,'2006-04-04 11:42:24','2006-04-04 11:42:26',8,3,NULL,NULL,NULL),(134,2,'2006-04-04 11:42:48','2006-04-04 11:43:08',20,40,NULL,NULL,NULL),(135,2,'2006-04-04 11:43:05','2006-04-04 11:43:08',52,40,NULL,NULL,NULL),(136,3,'2006-04-25 17:04:05','2006-04-25 17:04:57',56,110,NULL,NULL,NULL);
/*!40000 ALTER TABLE `inventory transactions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `inventory_inner1`
--

DROP TABLE IF EXISTS `inventory_inner1`;
/*!50001 DROP VIEW IF EXISTS `inventory_inner1`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory_inner1` (
  `Product ID` tinyint NOT NULL,
  `Product Name` tinyint NOT NULL,
  `Product Code` tinyint NOT NULL,
  `ReorderLevel` tinyint NOT NULL,
  `TargetLevel` tinyint NOT NULL,
  `Minimum Reorder Quantity` tinyint NOT NULL,
  `Qty Purchased` tinyint NOT NULL,
  `Qty Sold` tinyint NOT NULL,
  `Qty On Hold` tinyint NOT NULL,
  `Qty On Order` tinyint NOT NULL,
  `Qty On Back Order` tinyint NOT NULL,
  `Qty Available` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `inventory_inner2`
--

DROP TABLE IF EXISTS `inventory_inner2`;
/*!50001 DROP VIEW IF EXISTS `inventory_inner2`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `inventory_inner2` (
  `Product ID` tinyint NOT NULL,
  `Product Name` tinyint NOT NULL,
  `Product Code` tinyint NOT NULL,
  `Reorder Level` tinyint NOT NULL,
  `Target Level` tinyint NOT NULL,
  `Minimum Reorder Quantity` tinyint NOT NULL,
  `Qty Purchased` tinyint NOT NULL,
  `Qty Sold` tinyint NOT NULL,
  `Qty On Hold` tinyint NOT NULL,
  `Qty On Order` tinyint NOT NULL,
  `Qty On Back Order` tinyint NOT NULL,
  `Qty Available` tinyint NOT NULL,
  `Current Level` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invoices` (
  `InvoiceID` int(11) NOT NULL AUTO_INCREMENT,
  `OrderID` int(11) DEFAULT NULL,
  `InvoiceDate` datetime DEFAULT NULL,
  `DueDate` datetime DEFAULT NULL,
  `Tax` double DEFAULT NULL,
  `Shipping` double DEFAULT NULL,
  `AmountDue` double DEFAULT NULL,
  PRIMARY KEY (`InvoiceID`),
  UNIQUE KEY `Invoice ID` (`InvoiceID`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
INSERT INTO `invoices` VALUES (5,31,'2006-03-22 16:08:59','2006-03-22 16:08:59',0,0,0),(6,32,'2006-03-22 16:10:27','2006-03-24 10:57:38',0,0,0),(7,40,'2006-03-24 10:41:41','2006-03-24 10:57:38',0,0,0),(8,39,'2006-03-24 10:55:46','2006-03-24 10:57:38',0,0,0),(9,38,'2006-03-24 10:56:57',NULL,0,0,0),(10,37,'2006-03-24 10:57:38',NULL,0,0,0),(11,36,'2006-03-24 10:58:40',NULL,0,0,0),(12,35,'2006-03-24 10:59:41',NULL,0,0,0),(13,34,'2006-03-24 11:00:55',NULL,0,0,0),(14,33,'2006-03-24 11:02:02',NULL,0,0,0),(15,30,'2006-03-24 11:03:00',NULL,0,0,0),(16,56,'2006-04-03 13:50:15',NULL,0,0,0),(17,55,'2006-04-04 11:05:04',NULL,0,0,0),(18,51,'2006-04-04 11:06:13',NULL,0,0,0),(19,50,'2006-04-04 11:06:56',NULL,0,0,0),(20,48,'2006-04-04 11:07:37',NULL,0,0,0),(21,47,'2006-04-04 11:08:14',NULL,0,0,0),(22,46,'2006-04-04 11:08:49',NULL,0,0,0),(23,45,'2006-04-04 11:09:24',NULL,0,0,0),(24,79,'2006-04-04 11:35:54',NULL,0,0,0),(25,78,'2006-04-04 11:36:21',NULL,0,0,0),(26,77,'2006-04-04 11:36:47',NULL,0,0,0),(27,76,'2006-04-04 11:37:09',NULL,0,0,0),(28,75,'2006-04-04 11:37:49',NULL,0,0,0),(29,74,'2006-04-04 11:38:11',NULL,0,0,0),(30,73,'2006-04-04 11:38:32',NULL,0,0,0),(31,72,'2006-04-04 11:38:53',NULL,0,0,0),(32,71,'2006-04-04 11:39:29',NULL,0,0,0),(33,70,'2006-04-04 11:39:53',NULL,0,0,0),(34,69,'2006-04-04 11:40:16',NULL,0,0,0),(35,67,'2006-04-04 11:40:38',NULL,0,0,0),(36,42,'2006-04-04 11:41:14',NULL,0,0,0),(37,60,'2006-04-04 11:41:45',NULL,0,0,0),(38,63,'2006-04-04 11:42:26',NULL,0,0,0),(39,58,'2006-04-04 11:43:08',NULL,0,0,0);
/*!40000 ALTER TABLE `invoices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order details`
--

DROP TABLE IF EXISTS `order details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order details` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OrderID` int(11) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Quantity` decimal(18,4) DEFAULT NULL,
  `UnitPrice` double DEFAULT NULL,
  `Discount` double DEFAULT NULL,
  `StatusID` int(11) DEFAULT NULL,
  `DateAllocated` datetime DEFAULT NULL,
  `PurchaseOrderID` int(11) DEFAULT NULL,
  `InventoryID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order details`
--

LOCK TABLES `order details` WRITE;
/*!40000 ALTER TABLE `order details` DISABLE KEYS */;
INSERT INTO `order details` VALUES (27,30,34,100.0000,14,0,2,NULL,96,83),(28,30,80,30.0000,3.5,0,2,NULL,NULL,63),(29,31,7,10.0000,30,0,2,NULL,NULL,64),(30,31,51,10.0000,53,0,2,NULL,NULL,65),(31,31,80,10.0000,3.5,0,2,NULL,NULL,66),(32,32,1,15.0000,18,0,2,NULL,NULL,67),(33,32,43,20.0000,46,0,2,NULL,NULL,68),(34,33,19,30.0000,9.2,0,2,NULL,97,81),(35,34,19,20.0000,9.2,0,2,NULL,NULL,69),(36,35,48,10.0000,12.75,0,2,NULL,NULL,70),(37,36,41,200.0000,9.65,0,2,NULL,98,79),(38,37,8,17.0000,40,0,2,NULL,NULL,71),(39,38,43,300.0000,46,0,2,NULL,99,77),(40,39,48,100.0000,12.75,0,2,NULL,100,75),(41,40,81,200.0000,2.99,0,2,NULL,101,73),(42,41,43,300.0000,46,0,1,NULL,102,104),(43,42,6,10.0000,25,0,2,NULL,NULL,84),(44,42,4,10.0000,22,0,2,NULL,NULL,85),(45,42,19,10.0000,9.2,0,2,NULL,103,110),(46,43,80,20.0000,3.5,0,1,NULL,NULL,86),(47,43,81,50.0000,2.99,0,1,NULL,NULL,87),(48,44,1,25.0000,18,0,1,NULL,NULL,88),(49,44,43,25.0000,46,0,1,NULL,NULL,89),(50,44,81,25.0000,2.99,0,1,NULL,NULL,90),(51,45,41,50.0000,9.65,0,2,NULL,104,116),(52,45,40,50.0000,18.4,0,2,NULL,NULL,91),(53,46,57,100.0000,19.5,0,2,NULL,105,101),(54,46,72,50.0000,34.8,0,2,NULL,106,114),(55,47,34,300.0000,14,0,2,NULL,107,108),(56,48,8,25.0000,40,0,2,NULL,108,106),(57,48,19,25.0000,9.2,0,2,NULL,109,112),(59,50,21,20.0000,10,0,2,NULL,NULL,92),(60,51,5,25.0000,21.35,0,2,NULL,NULL,93),(61,51,41,30.0000,9.65,0,2,NULL,NULL,94),(62,51,40,30.0000,18.4,0,2,NULL,NULL,95),(66,56,48,10.0000,12.75,0,2,NULL,111,99),(67,55,34,87.0000,14,0,2,NULL,NULL,117),(68,79,7,30.0000,30,0,2,NULL,NULL,119),(69,79,51,30.0000,53,0,2,NULL,NULL,118),(70,78,17,40.0000,39,0,2,NULL,NULL,120),(71,77,6,90.0000,25,0,2,NULL,NULL,121),(72,76,4,30.0000,22,0,2,NULL,NULL,122),(73,75,48,40.0000,12.75,0,2,NULL,NULL,123),(74,74,48,40.0000,12.75,0,2,NULL,NULL,124),(75,73,41,10.0000,9.65,0,2,NULL,NULL,125),(76,72,43,5.0000,46,0,2,NULL,NULL,126),(77,71,40,40.0000,18.4,0,2,NULL,NULL,127),(78,70,8,20.0000,40,0,2,NULL,NULL,128),(79,69,80,15.0000,3.5,0,2,NULL,NULL,129),(80,67,74,20.0000,10,0,2,NULL,NULL,130),(81,60,72,40.0000,34.8,0,2,NULL,NULL,131),(82,63,3,50.0000,10,0,2,NULL,NULL,132),(83,63,8,3.0000,40,0,2,NULL,NULL,133),(84,58,20,40.0000,81,0,2,NULL,NULL,134),(85,58,52,40.0000,7,0,2,NULL,NULL,135),(86,80,56,10.0000,38,0,1,NULL,NULL,136);
/*!40000 ALTER TABLE `order details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `order details extended`
--

DROP TABLE IF EXISTS `order details extended`;
/*!50001 DROP VIEW IF EXISTS `order details extended`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `order details extended` (
  `ID` tinyint NOT NULL,
  `Order ID` tinyint NOT NULL,
  `Product ID` tinyint NOT NULL,
  `Quantity` tinyint NOT NULL,
  `Unit Price` tinyint NOT NULL,
  `Discount` tinyint NOT NULL,
  `Status ID` tinyint NOT NULL,
  `Date Allocated` tinyint NOT NULL,
  `Purchase Order ID` tinyint NOT NULL,
  `Inventory ID` tinyint NOT NULL,
  `Extended Price` tinyint NOT NULL,
  `Status Name` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `order details status`
--

DROP TABLE IF EXISTS `order details status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order details status` (
  `StatusID` int(11) NOT NULL,
  `StatusName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`StatusID`),
  UNIQUE KEY `Status ID` (`StatusID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order details status`
--

LOCK TABLES `order details status` WRITE;
/*!40000 ALTER TABLE `order details status` DISABLE KEYS */;
INSERT INTO `order details status` VALUES (0,'None'),(1,'Allocated'),(2,'Invoiced'),(3,'Shipped'),(4,'On Order'),(5,'No Stock');
/*!40000 ALTER TABLE `order details status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `order list`
--

DROP TABLE IF EXISTS `order list`;
/*!50001 DROP VIEW IF EXISTS `order list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `order list` (
  `#` tinyint NOT NULL,
  `Order Date` tinyint NOT NULL,
  `Status` tinyint NOT NULL,
  `Salesperson` tinyint NOT NULL,
  `Customer` tinyint NOT NULL,
  `Ship Date` tinyint NOT NULL,
  `Shipping` tinyint NOT NULL,
  `Taxes` tinyint NOT NULL,
  `Total` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `order list_inner`
--

DROP TABLE IF EXISTS `order list_inner`;
/*!50001 DROP VIEW IF EXISTS `order list_inner`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `order list_inner` (
  `OrderID` tinyint NOT NULL,
  `EmployeeID` tinyint NOT NULL,
  `CustomerID` tinyint NOT NULL,
  `OrderDate` tinyint NOT NULL,
  `ShippedDate` tinyint NOT NULL,
  `Sub Total` tinyint NOT NULL,
  `ShippingFee` tinyint NOT NULL,
  `Taxes` tinyint NOT NULL,
  `Order Total` tinyint NOT NULL,
  `ShipName` tinyint NOT NULL,
  `ShipAddress` tinyint NOT NULL,
  `PaidDate` tinyint NOT NULL,
  `Status` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `order price totals`
--

DROP TABLE IF EXISTS `order price totals`;
/*!50001 DROP VIEW IF EXISTS `order price totals`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `order price totals` (
  `Order ID` tinyint NOT NULL,
  `Price Total` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `EmployeeID` int(11) DEFAULT NULL,
  `CustomerID` int(11) DEFAULT NULL,
  `OrderDate` datetime DEFAULT NULL,
  `ShippedDate` datetime DEFAULT NULL,
  `ShipperID` int(11) DEFAULT NULL,
  `ShipName` varchar(50) DEFAULT NULL,
  `ShipAddress` mediumtext,
  `ShipCity` varchar(50) DEFAULT NULL,
  `ShipState_Province` int(11) DEFAULT NULL,
  `ShipZIP_PostalCode` varchar(50) DEFAULT NULL,
  `ShipCountry_Region` int(11) DEFAULT '1',
  `ShippingFee` double DEFAULT NULL,
  `Taxes` double DEFAULT NULL,
  `PaymentType` varchar(50) DEFAULT NULL,
  `PaidDate` datetime DEFAULT NULL,
  `Notes` mediumtext,
  `TaxRate` double DEFAULT NULL,
  `TaxStatus` tinyint(4) DEFAULT NULL,
  `StatusID` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  UNIQUE KEY `Order ID` (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=82 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (30,9,27,'2006-01-15 00:00:00','2006-01-22 00:00:00',2,'Karen Toh','789 27th Street','Las Vegas',NULL,'99999',1,200,0,'Check','2006-01-15 00:00:00',NULL,0,NULL,3),(31,3,4,'2006-01-20 00:00:00','2006-01-22 00:00:00',1,'Christina Lee','123 4th Street','New York',NULL,'99999',1,5,0,'Credit Card','2006-01-20 00:00:00',NULL,0,NULL,3),(32,4,12,'2006-01-22 00:00:00','2006-01-22 00:00:00',2,'John Edwards','123 12th Street','Las Vegas',NULL,'99999',1,5,0,'Credit Card','2006-01-22 00:00:00',NULL,0,NULL,3),(33,6,8,'2006-01-30 00:00:00','2006-01-31 00:00:00',3,'Elizabeth Andersen','123 8th Street','Portland',NULL,'99999',1,50,0,'Credit Card','2006-01-30 00:00:00',NULL,0,NULL,3),(34,9,4,'2006-02-06 00:00:00','2006-02-07 00:00:00',3,'Christina Lee','123 4th Street','New York',NULL,'99999',1,4,0,'Check','2006-02-06 00:00:00',NULL,0,NULL,3),(35,3,29,'2006-02-10 00:00:00','2006-02-12 00:00:00',2,'Soo Jung Lee','789 29th Street','Denver',NULL,'99999',1,7,0,'Check','2006-02-10 00:00:00',NULL,0,NULL,3),(36,4,3,'2006-02-23 00:00:00','2006-02-25 00:00:00',2,'Thomas Axen','123 3rd Street','Los Angelas',NULL,'99999',1,7,0,'Cash','2006-02-23 00:00:00',NULL,0,NULL,3),(37,8,6,'2006-03-06 00:00:00','2006-03-09 00:00:00',2,'Francisco Pérez-Olaeta','123 6th Street','Milwaukee',NULL,'99999',1,12,0,'Credit Card','2006-03-06 00:00:00',NULL,0,NULL,3),(38,9,28,'2006-03-10 00:00:00','2006-03-11 00:00:00',3,'Amritansh Raghav','789 28th Street','Memphis',NULL,'99999',1,10,0,'Check','2006-03-10 00:00:00',NULL,0,NULL,3),(39,3,8,'2006-03-22 00:00:00','2006-03-24 00:00:00',3,'Elizabeth Andersen','123 8th Street','Portland',NULL,'99999',1,5,0,'Check','2006-03-22 00:00:00',NULL,0,NULL,3),(40,4,10,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,'Roland Wacker','123 10th Street','Chicago',NULL,'99999',1,9,0,'Credit Card','2006-03-24 00:00:00',NULL,0,NULL,3),(41,1,7,'2006-03-24 00:00:00',NULL,NULL,'Ming-Yang Xie','123 7th Street','Boise',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(42,1,10,'2006-03-24 00:00:00','2006-04-07 00:00:00',1,'Roland Wacker','123 10th Street','Chicago',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,2),(43,1,11,'2006-03-24 00:00:00',NULL,3,'Peter Krschne','123 11th Street','Miami',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(44,1,1,'2006-03-24 00:00:00',NULL,NULL,'Anna Bedecs','123 1st Street','Seattle',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(45,1,28,'2006-04-07 00:00:00','2006-04-07 00:00:00',3,'Amritansh Raghav','789 28th Street','Memphis',NULL,'99999',1,40,0,'Credit Card','2006-04-07 00:00:00',NULL,0,NULL,3),(46,7,9,'2006-04-05 00:00:00','2006-04-05 00:00:00',1,'Sven Mortensen','123 9th Street','Salt Lake City',NULL,'99999',1,100,0,'Check','2006-04-05 00:00:00',NULL,0,NULL,3),(47,6,6,'2006-04-08 00:00:00','2006-04-08 00:00:00',2,'Francisco Pérez-Olaeta','123 6th Street','Milwaukee',NULL,'99999',1,300,0,'Credit Card','2006-04-08 00:00:00',NULL,0,NULL,3),(48,4,8,'2006-04-05 00:00:00','2006-04-05 00:00:00',2,'Elizabeth Andersen','123 8th Street','Portland',NULL,'99999',1,50,0,'Check','2006-04-05 00:00:00',NULL,0,NULL,3),(50,9,25,'2006-04-05 00:00:00','2006-04-05 00:00:00',1,'John Rodman','789 25th Street','Chicago',NULL,'99999',1,5,0,'Cash','2006-04-05 00:00:00',NULL,0,NULL,3),(51,9,26,'2006-04-05 00:00:00','2006-04-05 00:00:00',3,'Run Liu','789 26th Street','Miami',NULL,'99999',1,60,0,'Credit Card','2006-04-05 00:00:00',NULL,0,NULL,3),(55,1,29,'2006-04-05 00:00:00','2006-04-05 00:00:00',2,'Soo Jung Lee','789 29th Street','Denver',NULL,'99999',1,200,0,'Check','2006-04-05 00:00:00',NULL,0,NULL,3),(56,2,6,'2006-04-03 00:00:00','2006-04-03 00:00:00',3,'Francisco Pérez-Olaeta','123 6th Street','Milwaukee',NULL,'99999',1,0,0,'Check','2006-04-03 00:00:00',NULL,0,NULL,3),(57,9,27,'2006-04-22 00:00:00','2006-04-22 00:00:00',2,'Karen Toh','789 27th Street','Las Vegas',NULL,'99999',1,200,0,'Check','2006-04-22 00:00:00',NULL,0,NULL,0),(58,3,4,'2006-04-22 00:00:00','2006-04-22 00:00:00',1,'Christina Lee','123 4th Street','New York',NULL,'99999',1,5,0,'Credit Card','2006-04-22 00:00:00',NULL,0,NULL,3),(59,4,12,'2006-04-22 00:00:00','2006-04-22 00:00:00',2,'John Edwards','123 12th Street','Las Vegas',NULL,'99999',1,5,0,'Credit Card','2006-04-22 00:00:00',NULL,0,NULL,0),(60,6,8,'2006-04-30 00:00:00','2006-04-30 00:00:00',3,'Elizabeth Andersen','123 8th Street','Portland',NULL,'99999',1,50,0,'Credit Card','2006-04-30 00:00:00',NULL,0,NULL,3),(61,9,4,'2006-04-07 00:00:00','2006-04-07 00:00:00',3,'Christina Lee','123 4th Street','New York',NULL,'99999',1,4,0,'Check','2006-04-07 00:00:00',NULL,0,NULL,0),(62,3,29,'2006-04-12 00:00:00','2006-04-12 00:00:00',2,'Soo Jung Lee','789 29th Street','Denver',NULL,'99999',1,7,0,'Check','2006-04-12 00:00:00',NULL,0,NULL,0),(63,4,3,'2006-04-25 00:00:00','2006-04-25 00:00:00',2,'Thomas Axen','123 3rd Street','Los Angelas',NULL,'99999',1,7,0,'Cash','2006-04-25 00:00:00',NULL,0,NULL,3),(64,8,6,'2006-05-09 00:00:00','2006-05-09 00:00:00',2,'Francisco Pérez-Olaeta','123 6th Street','Milwaukee',NULL,'99999',1,12,0,'Credit Card','2006-05-09 00:00:00',NULL,0,NULL,0),(65,9,28,'2006-05-11 00:00:00','2006-05-11 00:00:00',3,'Amritansh Raghav','789 28th Street','Memphis',NULL,'99999',1,10,0,'Check','2006-05-11 00:00:00',NULL,0,NULL,0),(66,3,8,'2006-05-24 00:00:00','2006-05-24 00:00:00',3,'Elizabeth Andersen','123 8th Street','Portland',NULL,'99999',1,5,0,'Check','2006-05-24 00:00:00',NULL,0,NULL,0),(67,4,10,'2006-05-24 00:00:00','2006-05-24 00:00:00',2,'Roland Wacker','123 10th Street','Chicago',NULL,'99999',1,9,0,'Credit Card','2006-05-24 00:00:00',NULL,0,NULL,3),(68,1,7,'2006-05-24 00:00:00',NULL,NULL,'Ming-Yang Xie','123 7th Street','Boise',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(69,1,10,'2006-05-24 00:00:00',NULL,1,'Roland Wacker','123 10th Street','Chicago',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(70,1,11,'2006-05-24 00:00:00',NULL,3,'Peter Krschne','123 11th Street','Miami',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(71,1,1,'2006-05-24 00:00:00',NULL,3,'Anna Bedecs','123 1st Street','Seattle',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0),(72,1,28,'2006-06-07 00:00:00','2006-06-07 00:00:00',3,'Amritansh Raghav','789 28th Street','Memphis',NULL,'99999',1,40,0,'Credit Card','2006-06-07 00:00:00',NULL,0,NULL,3),(73,7,9,'2006-06-05 00:00:00','2006-06-05 00:00:00',1,'Sven Mortensen','123 9th Street','Salt Lake City',NULL,'99999',1,100,0,'Check','2006-06-05 00:00:00',NULL,0,NULL,3),(74,6,6,'2006-06-08 00:00:00','2006-06-08 00:00:00',2,'Francisco Pérez-Olaeta','123 6th Street','Milwaukee',NULL,'99999',1,300,0,'Credit Card','2006-06-08 00:00:00',NULL,0,NULL,3),(75,4,8,'2006-06-05 00:00:00','2006-06-05 00:00:00',2,'Elizabeth Andersen','123 8th Street','Portland',NULL,'99999',1,50,0,'Check','2006-06-05 00:00:00',NULL,0,NULL,3),(76,9,25,'2006-06-05 00:00:00','2006-06-05 00:00:00',1,'John Rodman','789 25th Street','Chicago',NULL,'99999',1,5,0,'Cash','2006-06-05 00:00:00',NULL,0,NULL,3),(77,9,26,'2006-06-05 00:00:00','2006-06-05 00:00:00',3,'Run Liu','789 26th Street','Miami',NULL,'99999',1,60,0,'Credit Card','2006-06-05 00:00:00',NULL,0,NULL,3),(78,1,29,'2006-06-05 00:00:00','2006-06-05 00:00:00',2,'Soo Jung Lee','789 29th Street','Denver',NULL,'99999',1,200,0,'Check','2006-06-05 00:00:00',NULL,0,NULL,3),(79,2,6,'2006-06-23 00:00:00','2006-06-23 00:00:00',3,'Francisco Pérez-Olaeta','123 6th Street','Milwaukee',NULL,'99999',1,0,0,'Check','2006-06-23 00:00:00',NULL,0,NULL,3),(80,2,4,'0001-01-01 00:00:00','0001-01-01 00:00:00',0,'Christina Lee','123 4th Street','New York',NULL,'99999',1,0,0,'','0001-01-01 00:00:00','',0,0,0),(81,2,3,'2006-04-25 17:26:53',NULL,NULL,'Thomas Axen','123 3rd Street','Los Angelas',NULL,'99999',1,0,0,NULL,NULL,NULL,0,NULL,0);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders status`
--

DROP TABLE IF EXISTS `orders status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders status` (
  `StatusID` tinyint(4) NOT NULL,
  `StatusName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`StatusID`),
  UNIQUE KEY `Status ID` (`StatusID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders status`
--

LOCK TABLES `orders status` WRITE;
/*!40000 ALTER TABLE `orders status` DISABLE KEYS */;
INSERT INTO `orders status` VALUES (0,'New'),(1,'Invoiced'),(2,'Shipped'),(3,'Closed');
/*!40000 ALTER TABLE `orders status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders tax status`
--

DROP TABLE IF EXISTS `orders tax status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders tax status` (
  `ID` tinyint(4) NOT NULL,
  `TaxStatusName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders tax status`
--

LOCK TABLES `orders tax status` WRITE;
/*!40000 ALTER TABLE `orders tax status` DISABLE KEYS */;
INSERT INTO `orders tax status` VALUES (0,'Tax Exempt'),(1,'Taxable');
/*!40000 ALTER TABLE `orders tax status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `privileges`
--

DROP TABLE IF EXISTS `privileges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `privileges` (
  `PrivilegeID` int(11) NOT NULL AUTO_INCREMENT,
  `PrivilegeName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PrivilegeID`),
  UNIQUE KEY `Privilege ID` (`PrivilegeID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `privileges`
--

LOCK TABLES `privileges` WRITE;
/*!40000 ALTER TABLE `privileges` DISABLE KEYS */;
INSERT INTO `privileges` VALUES (2,'Purchase Approvals');
/*!40000 ALTER TABLE `privileges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `product orders`
--

DROP TABLE IF EXISTS `product orders`;
/*!50001 DROP VIEW IF EXISTS `product orders`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `product orders` (
  `Product ID` tinyint NOT NULL,
  `Order ID` tinyint NOT NULL,
  `Order Date` tinyint NOT NULL,
  `Shipped Date` tinyint NOT NULL,
  `Customer ID` tinyint NOT NULL,
  `Quantity` tinyint NOT NULL,
  `Unit Price` tinyint NOT NULL,
  `Discount` tinyint NOT NULL,
  `Transaction` tinyint NOT NULL,
  `Company Name` tinyint NOT NULL,
  `Status ID` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `product purchases`
--

DROP TABLE IF EXISTS `product purchases`;
/*!50001 DROP VIEW IF EXISTS `product purchases`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `product purchases` (
  `Product ID` tinyint NOT NULL,
  `Purchase Order ID` tinyint NOT NULL,
  `Creation Date` tinyint NOT NULL,
  `Quantity` tinyint NOT NULL,
  `Unit Cost` tinyint NOT NULL,
  `Transaction` tinyint NOT NULL,
  `Company Name` tinyint NOT NULL,
  `Posted To Inventory` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `product transactions`
--

DROP TABLE IF EXISTS `product transactions`;
/*!50001 DROP VIEW IF EXISTS `product transactions`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `product transactions` (
  `Product ID` tinyint NOT NULL,
  `Order Date` tinyint NOT NULL,
  `Company Name` tinyint NOT NULL,
  `Transaction` tinyint NOT NULL,
  `Quantity` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `SupplierIDs` mediumtext,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ProductCode` varchar(25) DEFAULT NULL,
  `ProductName` varchar(50) DEFAULT NULL,
  `Description` mediumtext,
  `StandardCost` double DEFAULT NULL,
  `ListPrice` double DEFAULT NULL,
  `ReorderLevel` smallint(6) DEFAULT NULL,
  `TargetLevel` int(11) DEFAULT NULL,
  `QuantityPerUnit` varchar(50) DEFAULT NULL,
  `Discontinued` bit(1) DEFAULT NULL,
  `MinimumReorderQuantity` smallint(6) DEFAULT NULL,
  `Category` int(11) DEFAULT NULL,
  `Attachments` mediumtext,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES ('4',1,'NWTB-1','Northwind Traders Chai',NULL,13.5,18,10,40,'10 boxes x 20 bags','\0',10,NULL,NULL),('10',3,'NWTCO-3','Northwind Traders Syrup',NULL,7.5,10,25,100,'12 - 550 ml bottles','\0',25,NULL,NULL),('10',4,'NWTCO-4','Northwind Traders Cajun Seasoning',NULL,16.5,22,10,40,'48 - 6 oz jars','\0',10,NULL,NULL),('10',5,'NWTO-5','Northwind Traders Olive Oil','',16.01,21.35,10,30,'36 boxes','\0',10,NULL,NULL),('2;6',6,'NWTJP-6','Northwind Traders Boysenberry Spread','',0,0,25,100,'12 - 8 oz jars','\0',25,NULL,NULL),('2',7,'NWTDFN-7','Northwind Traders Dried Pears',NULL,22.5,30,10,40,'12 - 1 lb pkgs.','\0',10,NULL,NULL),('8',8,'NWTS-8','Northwind Traders Curry Sauce',NULL,30,40,10,40,'12 - 12 oz jars','\0',10,NULL,NULL),('2;6',14,'NWTDFN-14','Northwind Traders Walnuts',NULL,17.4375,23.25,10,40,'40 - 100 g pkgs.','\0',10,NULL,NULL),('6',17,'NWTCFV-17','Northwind Traders Fruit Cocktail','',29.25,39,10,40,'15.25 OZ','\0',10,NULL,NULL),('1',19,'NWTBGM-19','Northwind Traders Chocolate Biscuits Mix',NULL,6.9,9.2,5,20,'10 boxes x 12 pieces','\0',5,NULL,NULL),('2;6',20,'NWTJP-6','Northwind Traders Marmalade',NULL,60.75,81,10,40,'30 gift boxes','\0',10,NULL,NULL),('1',21,'NWTBGM-21','Northwind Traders Scone','',7.5,10,5,20,'24 pkgs. x 4 pieces','\0',5,NULL,NULL),('4',34,'NWTB-34','Northwind Traders Beer',NULL,10.5,14,15,60,'24 - 12 oz bottles','\0',15,NULL,NULL),('7',40,'NWTCM-40','Northwind Traders Crab Meat',NULL,13.8,18.4,30,120,'24 - 4 oz tins','\0',30,NULL,NULL),('6',41,'NWTSO-41','Northwind Traders Clam Chowder',NULL,7.2375,9.65,10,40,'12 - 12 oz cans','\0',10,NULL,NULL),('3;4',43,'NWTB-43','Northwind Traders Coffee',NULL,34.5,46,25,100,'16 - 500 g tins','\0',25,NULL,NULL),('10',48,'NWTCA-48','Northwind Traders Chocolate',NULL,9.5625,12.75,25,100,'10 pkgs','\0',25,NULL,NULL),('2',51,'NWTDFN-51','Northwind Traders Dried Apples',NULL,39.75,53,10,40,'50 - 300 g pkgs.','\0',10,NULL,NULL),('1',52,'NWTG-52','Northwind Traders Long Grain Rice',NULL,5.25,7,25,100,'16 - 2 kg boxes','\0',25,NULL,NULL),('1',56,'NWTP-56','Northwind Traders Gnocchi',NULL,28.5,38,30,120,'24 - 250 g pkgs.','\0',30,NULL,NULL),('1',57,'NWTP-57','Northwind Traders Ravioli',NULL,14.625,19.5,20,80,'24 - 250 g pkgs.','\0',20,NULL,NULL),('8',65,'NWTS-65','Northwind Traders Hot Pepper Sauce',NULL,15.7875,21.05,10,40,'32 - 8 oz bottles','\0',10,NULL,NULL),('8',66,'NWTS-66','Northwind Traders Tomato Sauce',NULL,12.75,17,20,80,'24 - 8 oz jars','\0',20,NULL,NULL),('5',72,'NWTD-72','Northwind Traders Mozzarella',NULL,26.1,34.8,10,40,'24 - 200 g pkgs.','\0',10,NULL,NULL),('2;6',74,'NWTDFN-74','Northwind Traders Almonds',NULL,7.5,10,5,20,'5 kg pkg.','\0',5,NULL,NULL),('10',77,'NWTCO-77','Northwind Traders Mustard',NULL,9.75,13,15,60,'12 boxes','\0',15,NULL,NULL),('2',80,'NWTDFN-80','Northwind Traders Dried Plums',NULL,3,3.5,50,75,'1 lb bag','\0',25,NULL,NULL),('3',81,'NWTB-81','Northwind Traders Green Tea',NULL,2,2.99,100,125,'20 bags per box','\0',25,NULL,NULL),('1',82,'NWTC-82','Northwind Traders Granola',NULL,2,4,20,100,NULL,'\0',NULL,NULL,NULL),('9',83,'NWTCS-83','Northwind Traders Potato Chips',NULL,0.5,1.8,30,200,NULL,'\0',NULL,NULL,NULL),('1',85,'NWTBGM-85','Northwind Traders Brownie Mix',NULL,9,12.49,10,20,'3 boxes','\0',5,NULL,NULL),('1',86,'NWTBGM-86','Northwind Traders Cake Mix',NULL,10.5,15.99,10,20,'4 boxes','\0',5,NULL,NULL),('7',87,'NWTB-87','Northwind Traders Tea',NULL,2,4,20,50,'100 count per box','\0',NULL,NULL,NULL),('6',88,'NWTCFV-88','Northwind Traders Pears',NULL,1,1.3,10,40,'15.25 OZ','\0',NULL,NULL,NULL),('6',89,'NWTCFV-89','Northwind Traders Peaches',NULL,1,1.5,10,40,'15.25 OZ','\0',NULL,NULL,NULL),('6',90,'NWTCFV-90','Northwind Traders Pineapple',NULL,1,1.8,10,40,'15.25 OZ','\0',NULL,NULL,NULL),('6',91,'NWTCFV-91','Northwind Traders Cherry Pie Filling',NULL,1,2,10,40,'15.25 OZ','\0',NULL,NULL,NULL),('6',92,'NWTCFV-92','Northwind Traders Green Beans',NULL,1,1.2,10,40,'14.5 OZ','\0',NULL,NULL,NULL),('6',93,'NWTCFV-93','Northwind Traders Corn',NULL,1,1.2,10,40,'14.5 OZ','\0',NULL,NULL,NULL),('6',94,'NWTCFV-94','Northwind Traders Peas',NULL,1,1.5,10,40,'14.5 OZ','\0',NULL,NULL,NULL),('7',95,'NWTCM-95','Northwind Traders Tuna Fish',NULL,0.5,2,30,50,'5 oz','\0',NULL,NULL,NULL),('7',96,'NWTCM-96','Northwind Traders Smoked Salmon',NULL,2,4,30,50,'5 oz','\0',NULL,NULL,NULL),('1',97,'NWTC-82','Northwind Traders Hot Cereal',NULL,3,5,50,200,NULL,'\0',NULL,NULL,NULL),('6',98,'NWTSO-98','Northwind Traders Vegetable Soup',NULL,1,1.89,100,200,NULL,'\0',NULL,NULL,NULL),('6',99,'NWTSO-99','Northwind Traders Chicken Soup',NULL,1,1.95,100,200,NULL,'\0',NULL,NULL,NULL);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `products on back order`
--

DROP TABLE IF EXISTS `products on back order`;
/*!50001 DROP VIEW IF EXISTS `products on back order`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `products on back order` (
  `ID` tinyint NOT NULL,
  `Quantity On Back Order` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `purchase details extended`
--

DROP TABLE IF EXISTS `purchase details extended`;
/*!50001 DROP VIEW IF EXISTS `purchase details extended`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `purchase details extended` (
  `ID` tinyint NOT NULL,
  `PurchaseOrderID` tinyint NOT NULL,
  `ProductID` tinyint NOT NULL,
  `Quantity` tinyint NOT NULL,
  `UnitCost` tinyint NOT NULL,
  `DateReceived` tinyint NOT NULL,
  `PostedToInventory` tinyint NOT NULL,
  `InventoryID` tinyint NOT NULL,
  `Extended Price` tinyint NOT NULL,
  `ProductName` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `purchase order details`
--

DROP TABLE IF EXISTS `purchase order details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase order details` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `PurchaseOrderID` int(11) DEFAULT NULL,
  `ProductID` int(11) DEFAULT NULL,
  `Quantity` decimal(18,4) DEFAULT NULL,
  `UnitCost` double DEFAULT NULL,
  `DateReceived` datetime DEFAULT NULL,
  `PostedToInventory` bit(1) DEFAULT NULL,
  `InventoryID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=296 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase order details`
--

LOCK TABLES `purchase order details` WRITE;
/*!40000 ALTER TABLE `purchase order details` DISABLE KEYS */;
INSERT INTO `purchase order details` VALUES (238,90,1,40.0000,14,'2006-01-22 00:00:00','',59),(239,91,3,100.0000,8,'2006-01-22 00:00:00','',54),(240,91,4,40.0000,16,'2006-01-22 00:00:00','',55),(241,91,5,40.0000,16,'2006-01-22 00:00:00','',56),(242,92,6,100.0000,19,'2006-01-22 00:00:00','',40),(243,92,7,40.0000,22,'2006-01-22 00:00:00','',41),(244,92,8,40.0000,30,'2006-01-22 00:00:00','',42),(245,92,14,40.0000,17,'2006-01-22 00:00:00','',43),(246,92,17,40.0000,29,'2006-01-22 00:00:00','',44),(247,92,19,20.0000,7,'2006-01-22 00:00:00','',45),(248,92,20,40.0000,61,'2006-01-22 00:00:00','',46),(249,92,21,20.0000,8,'2006-01-22 00:00:00','',47),(250,90,34,60.0000,10,'2006-01-22 00:00:00','',60),(251,92,40,120.0000,14,'2006-01-22 00:00:00','',48),(252,92,41,40.0000,7,'2006-01-22 00:00:00','',49),(253,90,43,100.0000,34,'2006-01-22 00:00:00','',61),(254,92,48,100.0000,10,'2006-01-22 00:00:00','',50),(255,92,51,40.0000,40,'2006-01-22 00:00:00','',51),(256,93,52,100.0000,5,'2006-01-22 00:00:00','',37),(257,93,56,120.0000,28,'2006-01-22 00:00:00','',38),(258,93,57,80.0000,15,'2006-01-22 00:00:00','',39),(259,91,65,40.0000,16,'2006-01-22 00:00:00','',57),(260,91,66,80.0000,13,'2006-01-22 00:00:00','',58),(261,94,72,40.0000,26,'2006-01-22 00:00:00','',36),(262,92,74,20.0000,8,'2006-01-22 00:00:00','',52),(263,92,77,60.0000,10,'2006-01-22 00:00:00','',53),(264,95,80,75.0000,3,'2006-01-22 00:00:00','',35),(265,90,81,125.0000,2,'2006-01-22 00:00:00','',62),(266,96,34,100.0000,10,'2006-01-22 00:00:00','',82),(267,97,19,30.0000,7,'2006-01-22 00:00:00','',80),(268,98,41,200.0000,7,'2006-01-22 00:00:00','',78),(269,99,43,300.0000,34,'2006-01-22 00:00:00','',76),(270,100,48,100.0000,10,'2006-01-22 00:00:00','',74),(271,101,81,200.0000,2,'2006-01-22 00:00:00','',72),(272,102,43,300.0000,34,NULL,'\0',NULL),(273,103,19,10.0000,7,'2006-04-17 00:00:00','',111),(274,104,41,50.0000,7,'2006-04-06 00:00:00','',115),(275,105,57,100.0000,15,'2006-04-05 00:00:00','',100),(276,106,72,50.0000,26,'2006-04-05 00:00:00','',113),(277,107,34,300.0000,10,'2006-04-05 00:00:00','',107),(278,108,8,25.0000,30,'2006-04-05 00:00:00','',105),(279,109,19,25.0000,7,'2006-04-05 00:00:00','',109),(280,110,43,250.0000,34,'2006-04-10 00:00:00','',103),(281,90,1,40.0000,14,NULL,'\0',NULL),(282,92,19,20.0000,7,NULL,'\0',NULL),(283,111,34,50.0000,10,'2006-04-04 00:00:00','',102),(285,91,3,50.0000,8,NULL,'\0',NULL),(286,91,4,40.0000,16,NULL,'\0',NULL),(288,140,85,10.0000,9,NULL,'\0',NULL),(289,141,6,10.0000,18.75,NULL,'\0',NULL),(290,142,1,1.0000,13.5,NULL,'\0',NULL),(292,146,20,40.0000,60,NULL,'\0',NULL),(293,146,51,40.0000,39,NULL,'\0',NULL),(294,147,40,120.0000,13,NULL,'\0',NULL),(295,148,72,40.0000,26,NULL,'\0',NULL);
/*!40000 ALTER TABLE `purchase order details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase order status`
--

DROP TABLE IF EXISTS `purchase order status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase order status` (
  `StatusID` int(11) NOT NULL,
  `Status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`StatusID`),
  UNIQUE KEY `Status ID` (`StatusID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase order status`
--

LOCK TABLES `purchase order status` WRITE;
/*!40000 ALTER TABLE `purchase order status` DISABLE KEYS */;
INSERT INTO `purchase order status` VALUES (0,'New'),(1,'Submitted'),(2,'Approved'),(3,'Closed');
/*!40000 ALTER TABLE `purchase order status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase orders`
--

DROP TABLE IF EXISTS `purchase orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase orders` (
  `PurchaseOrderID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) DEFAULT NULL,
  `CreatedBy` int(11) DEFAULT NULL,
  `SubmittedDate` datetime DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `StatusID` int(11) DEFAULT NULL,
  `ExpectedDate` datetime DEFAULT NULL,
  `ShippingFee` double DEFAULT NULL,
  `Taxes` double DEFAULT NULL,
  `PaymentDate` datetime DEFAULT NULL,
  `PaymentAmount` double DEFAULT NULL,
  `PaymentMethod` varchar(50) DEFAULT NULL,
  `Notes` mediumtext,
  `ApprovedBy` int(11) DEFAULT NULL,
  `ApprovedDate` datetime DEFAULT NULL,
  `SubmittedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`PurchaseOrderID`),
  UNIQUE KEY `Purchase Order ID` (`PurchaseOrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=149 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase orders`
--

LOCK TABLES `purchase orders` WRITE;
/*!40000 ALTER TABLE `purchase orders` DISABLE KEYS */;
INSERT INTO `purchase orders` VALUES (90,1,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-01-22 00:00:00',2),(91,3,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-01-22 00:00:00',2),(92,2,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-01-22 00:00:00',2),(93,5,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-01-22 00:00:00',2),(94,6,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-01-22 00:00:00',2),(95,4,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-01-22 00:00:00',2),(96,1,5,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #30',2,'2006-01-22 00:00:00',5),(97,2,7,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #33',2,'2006-01-22 00:00:00',7),(98,2,4,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #36',2,'2006-01-22 00:00:00',4),(99,1,3,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #38',2,'2006-01-22 00:00:00',3),(100,2,9,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #39',2,'2006-01-22 00:00:00',9),(101,1,2,'2006-01-14 00:00:00','2006-01-22 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #40',2,'2006-01-22 00:00:00',2),(102,1,1,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #41',2,'2006-04-04 00:00:00',1),(103,2,1,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #42',2,'2006-04-04 00:00:00',1),(104,2,1,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #45',2,'2006-04-04 00:00:00',1),(105,5,7,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,'Check','Purchase generated based on Order #46',2,'2006-04-04 00:00:00',7),(106,6,7,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #46',2,'2006-04-04 00:00:00',7),(107,1,6,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #47',2,'2006-04-04 00:00:00',6),(108,2,4,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #48',2,'2006-04-04 00:00:00',4),(109,2,4,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #48',2,'2006-04-04 00:00:00',4),(110,1,3,'2006-03-24 00:00:00','2006-03-24 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #49',2,'2006-04-04 00:00:00',3),(111,1,2,'2006-03-31 00:00:00','2006-03-31 00:00:00',2,NULL,0,0,NULL,0,NULL,'Purchase generated based on Order #56',2,'2006-04-04 00:00:00',2),(140,6,NULL,'2006-04-25 00:00:00','2006-04-25 16:40:51',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-04-25 16:41:33',2),(141,8,NULL,'2006-04-25 00:00:00','2006-04-25 17:10:35',2,NULL,0,0,NULL,0,NULL,NULL,2,'2006-04-25 17:10:55',2),(142,8,NULL,'2006-04-25 00:00:00','2006-04-25 17:18:29',2,NULL,0,0,NULL,0,'Check',NULL,2,'2006-04-25 17:18:51',2),(146,2,2,'2006-04-26 18:26:37','2006-04-26 18:26:37',1,NULL,0,0,NULL,0,NULL,NULL,NULL,NULL,2),(147,7,2,'2006-04-26 18:33:28','2006-04-26 18:33:28',1,NULL,0,0,NULL,0,NULL,NULL,NULL,NULL,2),(148,5,2,'2006-04-26 18:33:52','2006-04-26 18:33:52',1,NULL,0,0,NULL,0,NULL,NULL,NULL,NULL,2);
/*!40000 ALTER TABLE `purchase orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `purchase orders list`
--

DROP TABLE IF EXISTS `purchase orders list`;
/*!50001 DROP VIEW IF EXISTS `purchase orders list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `purchase orders list` (
  `#` tinyint NOT NULL,
  `Status` tinyint NOT NULL,
  `Company` tinyint NOT NULL,
  `Total` tinyint NOT NULL,
  `Submitted By` tinyint NOT NULL,
  `Submitted` tinyint NOT NULL,
  `Approved By` tinyint NOT NULL,
  `Approved` tinyint NOT NULL,
  `Date Paid` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `purchase price totals`
--

DROP TABLE IF EXISTS `purchase price totals`;
/*!50001 DROP VIEW IF EXISTS `purchase price totals`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `purchase price totals` (
  `Purchase ID` tinyint NOT NULL,
  `Price Total` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `purchase summary`
--

DROP TABLE IF EXISTS `purchase summary`;
/*!50001 DROP VIEW IF EXISTS `purchase summary`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `purchase summary` (
  `CreationDate` tinyint NOT NULL,
  `Status` tinyint NOT NULL,
  `SupplierID` tinyint NOT NULL,
  `ShippingFee` tinyint NOT NULL,
  `Taxes` tinyint NOT NULL,
  `Order Total` tinyint NOT NULL,
  `Sub Total` tinyint NOT NULL,
  `PaymentDate` tinyint NOT NULL,
  `ApprovedBy` tinyint NOT NULL,
  `ApprovedDate` tinyint NOT NULL,
  `SubmittedBy` tinyint NOT NULL,
  `SubmittedDate` tinyint NOT NULL,
  `StatusID` tinyint NOT NULL,
  `PurchaseOrderID` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `region`
--

DROP TABLE IF EXISTS `region`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `region` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `idregion_UNIQUE` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `region`
--

LOCK TABLES `region` WRITE;
/*!40000 ALTER TABLE `region` DISABLE KEYS */;
INSERT INTO `region` VALUES (1,'United States');
/*!40000 ALTER TABLE `region` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `shipper list`
--

DROP TABLE IF EXISTS `shipper list`;
/*!50001 DROP VIEW IF EXISTS `shipper list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `shipper list` (
  `ID` tinyint NOT NULL,
  `Company` tinyint NOT NULL,
  `First Name` tinyint NOT NULL,
  `Last Name` tinyint NOT NULL,
  `Email Address` tinyint NOT NULL,
  `Business Phone` tinyint NOT NULL,
  `Job Title` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `shippers`
--

DROP TABLE IF EXISTS `shippers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `shippers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Company` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `EmailAddress` varchar(50) DEFAULT NULL,
  `JobTitle` varchar(50) DEFAULT NULL,
  `BusinessPhone` varchar(25) DEFAULT NULL,
  `HomePhone` varchar(25) DEFAULT NULL,
  `MobilePhone` varchar(25) DEFAULT NULL,
  `FaxNumber` varchar(25) DEFAULT NULL,
  `Address` mediumtext,
  `City` varchar(50) DEFAULT NULL,
  `State_Province` int(11) DEFAULT NULL,
  `ZIP_PostalCode` varchar(15) DEFAULT NULL,
  `Country_Region` int(11) DEFAULT '1',
  `WebPage` mediumtext,
  `Notes` mediumtext,
  `Attachments` mediumtext,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shippers`
--

LOCK TABLES `shippers` WRITE;
/*!40000 ALTER TABLE `shippers` DISABLE KEYS */;
INSERT INTO `shippers` VALUES (1,'Shipping Company A',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'123 Any Street','Memphis',NULL,'99999',1,NULL,NULL,NULL),(2,'Shipping Company B',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'123 Any Street','Memphis',NULL,'99999',1,NULL,NULL,NULL),(3,'Shipping Company C',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'123 Any Street','Memphis',NULL,'99999',1,NULL,NULL,NULL);
/*!40000 ALTER TABLE `shippers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subregion`
--

DROP TABLE IF EXISTS `subregion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subregion` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RegionID` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `idsubregion_UNIQUE` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subregion`
--

LOCK TABLES `subregion` WRITE;
/*!40000 ALTER TABLE `subregion` DISABLE KEYS */;
INSERT INTO `subregion` VALUES (1,1,'Alabama'),(2,1,'Alaska'),(3,1,'Arizona'),(4,1,'Arkansas'),(5,1,'California'),(6,1,'Colorado'),(7,1,'Connecticut'),(8,1,'Delaware'),(9,1,'Florida'),(10,1,'Georgia'),(11,1,'Hawaii'),(12,1,'Idaho'),(13,1,'Illinois'),(14,1,'Indiana'),(15,1,'Iowa'),(16,1,'Kansas'),(17,1,'Kentucky'),(18,1,'Louisiana'),(19,1,'Maine'),(20,1,'Maryland'),(21,1,'Massachusetts'),(22,1,'Michigan'),(23,1,'Minnesota'),(24,1,'Mississippi'),(25,1,'Missouri'),(26,1,'Montana'),(27,1,'Nebraska'),(28,1,'Nevada'),(29,1,'New Hampshire'),(30,1,'New Jersey'),(31,1,'New Mexico'),(32,1,'New York'),(33,1,'North Carolina'),(34,1,'North Dakota'),(35,1,'Ohio'),(36,1,'Oklahoma'),(37,1,'Oregon'),(38,1,'Pennsylvania'),(39,1,'Rhode Island'),(40,1,'South Carolina'),(41,1,'South Dakota'),(42,1,'Tennessee'),(43,1,'Texas'),(44,1,'Utah'),(45,1,'Vermont'),(46,1,'Virginia'),(47,1,'Washington'),(48,1,'West Virginia'),(49,1,'Wisconsin'),(50,1,'Wyoming'),(51,1,'District of Columbia');
/*!40000 ALTER TABLE `subregion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `supplier list`
--

DROP TABLE IF EXISTS `supplier list`;
/*!50001 DROP VIEW IF EXISTS `supplier list`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `supplier list` (
  `ID` tinyint NOT NULL,
  `Company` tinyint NOT NULL,
  `First Name` tinyint NOT NULL,
  `Last Name` tinyint NOT NULL,
  `Email Address` tinyint NOT NULL,
  `Business Phone` tinyint NOT NULL,
  `Job Title` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suppliers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Company` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `EmailAddress` varchar(50) DEFAULT NULL,
  `JobTitle` varchar(50) DEFAULT NULL,
  `BusinessPhone` varchar(25) DEFAULT NULL,
  `HomePhone` varchar(25) DEFAULT NULL,
  `MobilePhone` varchar(25) DEFAULT NULL,
  `FaxNumber` varchar(25) DEFAULT NULL,
  `Address` mediumtext,
  `City` varchar(50) DEFAULT NULL,
  `State_Province` int(11) DEFAULT NULL,
  `ZIP_PostalCode` varchar(15) DEFAULT NULL,
  `Country_Region` int(11) DEFAULT '1',
  `WebPage` mediumtext,
  `Notes` mediumtext,
  `Attachments` mediumtext,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Supplier A','Andersen','Elizabeth A.',NULL,'Sales Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'Supplier B','Weiler','Cornelia',NULL,'Sales Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3,'Supplier C','Kelley','Madeleine',NULL,'Sales Representative',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,'Supplier D','Sato','Naoki',NULL,'Marketing Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,'Supplier E','Hernandez-Echevarria','Amaya',NULL,'Sales Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,'Supplier F','Hayakawa','Satomi',NULL,'Marketing Assistant',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,'Supplier G','Glasson','Stuart',NULL,'Marketing Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,'Supplier H','Dunton','Bryn Paul',NULL,'Sales Representative',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,'Supplier I','Sandberg','Mikael',NULL,'Sales Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,'Supplier J','Sousa','Luis',NULL,'Sales Manager',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'northwind'
--

--
-- Dumping routines for database 'northwind'
--
/*!50003 DROP PROCEDURE IF EXISTS `Active Orders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Active Orders`(IN emp int(11))
BEGIN
SELECT 
    `OrderID` AS '#',
    `StatusName` AS 'Status',
    `OrderDate` AS 'Date',
    `Company`
FROM
    orders
        JOIN
    customers ON orders.`CustomerID` = customers.`ID`
        JOIN
    `Orders Status` ON orders.`StatusID` = `Orders Status`.`StatusID`
WHERE
    orders.`StatusID` = 0 AND orders.`EmployeeID` = emp;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `order details for #` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `order details for #`(IN id int(11))
BEGIN
SELECT 
	`ProductName` AS `Product`,
	round(`Quantity`,0) AS `Qty`,
	concat('$',cast(round(`UnitPrice`,2) as char)) AS `Unit Price`,
	concat(cast(round(`Discount`,2) as char),'%') AS `Discount`,
	concat('$',cast(round(`Quantity` * `UnitPrice`,2) as char)) AS `Total Price`,
	`StatusName` AS `Status`
FROM 
	`order details` 
LEFT JOIN 
	products ON products.`ID` = `order details`.`ProductID` 
LEFT JOIN
	`order details status` ON `order details`.`StatusID` = `order details status`.`StatusID`
WHERE 
	`order details`.`OrderID` = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `customer list`
--

/*!50001 DROP TABLE IF EXISTS `customer list`*/;
/*!50001 DROP VIEW IF EXISTS `customer list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customer list` AS select `customers extended`.`ID` AS `ID`,`customers extended`.`Company` AS `Company`,`customers extended`.`FirstName` AS `First Name`,`customers extended`.`LastName` AS `Last Name`,`customers extended`.`EmailAddress` AS `Email Address`,`customers extended`.`BusinessPhone` AS `Business Phone`,`customers extended`.`JobTitle` AS `Job Title` from `customers extended` order by `customers extended`.`LastName` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `customers extended`
--

/*!50001 DROP TABLE IF EXISTS `customers extended`*/;
/*!50001 DROP VIEW IF EXISTS `customers extended`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `customers extended` AS select if(isnull(`customers`.`LastName`),if(isnull(`customers`.`FirstName`),`customers`.`Company`,`customers`.`FirstName`),if(isnull(`customers`.`FirstName`),`customers`.`LastName`,concat(`customers`.`LastName`,', ',`customers`.`FirstName`))) AS `FileAs`,if(isnull(`customers`.`LastName`),if(isnull(`customers`.`FirstName`),`customers`.`Company`,`customers`.`FirstName`),if(isnull(`customers`.`FirstName`),`customers`.`LastName`,concat(`customers`.`FirstName`,' ',`customers`.`LastName`))) AS `ContactName`,`customers`.`ID` AS `ID`,`customers`.`Company` AS `Company`,`customers`.`LastName` AS `LastName`,`customers`.`FirstName` AS `FirstName`,`customers`.`EmailAddress` AS `EmailAddress`,`customers`.`JobTitle` AS `JobTitle`,`customers`.`BusinessPhone` AS `BusinessPhone`,`customers`.`HomePhone` AS `HomePhone`,`customers`.`MobilePhone` AS `MobilePhone`,`customers`.`Address` AS `Address`,`customers`.`FaxNumber` AS `FaxNumber`,`customers`.`City` AS `City`,`customers`.`State_Province` AS `State_Province`,`customers`.`ZIP_PostalCode` AS `ZIP_PostalCode`,`customers`.`Country_Region` AS `Country_Region`,`customers`.`WebPage` AS `WebPage`,`customers`.`Notes` AS `Notes`,`customers`.`Attachments` AS `Attachments` from `customers` order by if(isnull(`customers`.`LastName`),if(isnull(`customers`.`FirstName`),`customers`.`Company`,`customers`.`FirstName`),if(isnull(`customers`.`FirstName`),`customers`.`LastName`,((`customers`.`LastName` & ', ') & `customers`.`FirstName`))),if(isnull(`customers`.`LastName`),if(isnull(`customers`.`FirstName`),`customers`.`Company`,`customers`.`FirstName`),if(isnull(`customers`.`FirstName`),`customers`.`LastName`,((`customers`.`FirstName` & ' ') & `customers`.`LastName`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `employee list`
--

/*!50001 DROP TABLE IF EXISTS `employee list`*/;
/*!50001 DROP VIEW IF EXISTS `employee list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `employee list` AS select `employees extended`.`ID` AS `ID`,`employees extended`.`FirstName` AS `First Name`,`employees extended`.`LastName` AS `Last Name`,`employees extended`.`EmailAddress` AS `Email Address`,`employees extended`.`BusinessPhone` AS `Business Phone`,`employees extended`.`JobTitle` AS `Job Title` from `employees extended` order by `employees extended`.`LastName` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `employees extended`
--

/*!50001 DROP TABLE IF EXISTS `employees extended`*/;
/*!50001 DROP VIEW IF EXISTS `employees extended`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `employees extended` AS select if(isnull(`employees`.`LastName`),`employees`.`FirstName`,if(isnull(`employees`.`FirstName`),`employees`.`LastName`,concat(`employees`.`LastName`,', ',`employees`.`FirstName`))) AS `FileAs`,if(isnull(`employees`.`LastName`),`employees`.`FirstName`,if(isnull(`employees`.`FirstName`),`employees`.`LastName`,concat(`employees`.`FirstName`,' ',`employees`.`LastName`))) AS `EmployeeName`,`employees`.`ID` AS `ID`,`employees`.`LastName` AS `LastName`,`employees`.`FirstName` AS `FirstName`,`employees`.`EmailAddress` AS `EmailAddress`,`employees`.`JobTitle` AS `JobTitle`,`employees`.`BusinessPhone` AS `BusinessPhone`,`employees`.`HomePhone` AS `HomePhone`,`employees`.`MobilePhone` AS `MobilePhone`,`employees`.`FaxNumber` AS `FaxNumber`,`employees`.`Address` AS `Address`,`employees`.`City` AS `City`,`employees`.`State_Province` AS `State_Province`,`employees`.`ZIP_PostalCode` AS `ZIP_PostalCode`,`employees`.`Country_Region` AS `Country_Region`,`employees`.`WebPage` AS `WebPage`,`employees`.`Notes` AS `Notes`,`employees`.`Attachments` AS `Attachments` from `employees` order by if(isnull(`employees`.`LastName`),`employees`.`FirstName`,if(isnull(`employees`.`FirstName`),`employees`.`LastName`,concat(`employees`.`LastName`,', ',`employees`.`FirstName`))),if(isnull(`employees`.`LastName`),`employees`.`FirstName`,if(isnull(`employees`.`FirstName`),`employees`.`LastName`,concat(`employees`.`FirstName`,' ',`employees`.`LastName`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory`
--

/*!50001 DROP TABLE IF EXISTS `inventory`*/;
/*!50001 DROP VIEW IF EXISTS `inventory`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory` AS select `inventory_inner2`.`Product ID` AS `Product ID`,`inventory_inner2`.`Product Name` AS `Product Name`,`inventory_inner2`.`Product Code` AS `Product Code`,`inventory_inner2`.`Qty Purchased` AS `Qty Purchased`,`inventory_inner2`.`Qty Sold` AS `Qty Sold`,`inventory_inner2`.`Qty On Hold` AS `Qty On Hold`,(`inventory_inner2`.`Qty Purchased` - `inventory_inner2`.`Qty Sold`) AS `Qty On Hand`,`inventory_inner2`.`Qty Available` AS `Qty Available`,`inventory_inner2`.`Qty On Order` AS `Qty On Order`,round(`inventory_inner2`.`Qty On Back Order`,0) AS `Qty On Back Order`,`inventory_inner2`.`Reorder Level` AS `Reorder Level`,`inventory_inner2`.`Target Level` AS `Target Level`,round((`inventory_inner2`.`Target Level` - `inventory_inner2`.`Current Level`),0) AS `Qty Below Target Level`,round(`inventory_inner2`.`Current Level`,0) AS `Current Level`,round(if(((`inventory_inner2`.`Target Level` - `inventory_inner2`.`Current Level`) > 0),if(((`inventory_inner2`.`Target Level` - `inventory_inner2`.`Current Level`) < `inventory_inner2`.`Minimum Reorder Quantity`),`inventory_inner2`.`Minimum Reorder Quantity`,(`inventory_inner2`.`Target Level` - `inventory_inner2`.`Current Level`)),0),0) AS `Qty To Reorder` from `inventory_inner2` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory list`
--

/*!50001 DROP TABLE IF EXISTS `inventory list`*/;
/*!50001 DROP VIEW IF EXISTS `inventory list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory list` AS select `inventory`.`Product ID` AS `#`,`inventory`.`Product Name` AS `Product Name`,`inventory`.`Qty On Hand` AS `Qty On Hand`,`inventory`.`Qty On Hold` AS `Qty On Hold`,`inventory`.`Qty Available` AS `Qty Available`,`inventory`.`Qty On Order` AS `Qty On Order`,`inventory`.`Current Level` AS `Combined Total`,`inventory`.`Target Level` AS `Target Level`,`inventory`.`Qty To Reorder` AS `Qty To Reorder` from `inventory` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory on hold`
--

/*!50001 DROP TABLE IF EXISTS `inventory on hold`*/;
/*!50001 DROP VIEW IF EXISTS `inventory on hold`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory on hold` AS select `products`.`ID` AS `ID`,`products`.`ProductName` AS `Product`,sum(`inventory transactions`.`Quantity`) AS `Quantity On Hold` from (`inventory transactions` join `products` on((`inventory transactions`.`ProductID` = `products`.`ID`))) where (`inventory transactions`.`TransactionType` = 3) group by `inventory transactions`.`ProductID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory on order`
--

/*!50001 DROP TABLE IF EXISTS `inventory on order`*/;
/*!50001 DROP VIEW IF EXISTS `inventory on order`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory on order` AS select `products`.`ID` AS `ID`,`products`.`ProductName` AS `Product`,truncate(sum(`purchase order details`.`Quantity`),0) AS `Quantity on Order` from (`purchase order details` join `products` on((`purchase order details`.`ProductID` = `products`.`ID`))) where (`purchase order details`.`PostedToInventory` = 0) group by `purchase order details`.`ProductID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory purchased`
--

/*!50001 DROP TABLE IF EXISTS `inventory purchased`*/;
/*!50001 DROP VIEW IF EXISTS `inventory purchased`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory purchased` AS select `products`.`ID` AS `ID`,`products`.`ProductName` AS `Product`,sum(`inventory transactions`.`Quantity`) AS `Quantity Purchased` from (`inventory transactions` join `products` on((`inventory transactions`.`ProductID` = `products`.`ID`))) where (`inventory transactions`.`TransactionType` = 1) group by `inventory transactions`.`ProductID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory sold`
--

/*!50001 DROP TABLE IF EXISTS `inventory sold`*/;
/*!50001 DROP VIEW IF EXISTS `inventory sold`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory sold` AS select `products`.`ID` AS `ID`,`products`.`ProductName` AS `Product`,sum(`inventory transactions`.`Quantity`) AS `Quantity Sold` from (`inventory transactions` join `products` on((`inventory transactions`.`ProductID` = `products`.`ID`))) where (`inventory transactions`.`TransactionType` = 2) group by `inventory transactions`.`ProductID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory to reorder`
--

/*!50001 DROP TABLE IF EXISTS `inventory to reorder`*/;
/*!50001 DROP VIEW IF EXISTS `inventory to reorder`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory to reorder` AS select `inventory`.`Product ID` AS `#`,`inventory`.`Product Name` AS `Product`,`inventory`.`Qty Available` AS `Qty Available`,`inventory`.`Reorder Level` AS `Reorder Level` from `inventory` where (`inventory`.`Current Level` <= `inventory`.`Reorder Level`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory_inner1`
--

/*!50001 DROP TABLE IF EXISTS `inventory_inner1`*/;
/*!50001 DROP VIEW IF EXISTS `inventory_inner1`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory_inner1` AS (select `products`.`ID` AS `Product ID`,`products`.`ProductName` AS `Product Name`,`products`.`ProductCode` AS `Product Code`,`products`.`ReorderLevel` AS `ReorderLevel`,`products`.`TargetLevel` AS `TargetLevel`,`products`.`MinimumReorderQuantity` AS `Minimum Reorder Quantity`,coalesce(`inventory purchased`.`Quantity Purchased`,0) AS `Qty Purchased`,coalesce(`inventory sold`.`Quantity Sold`,0) AS `Qty Sold`,coalesce(`inventory on hold`.`Quantity On Hold`,0) AS `Qty On Hold`,coalesce(`inventory on order`.`Quantity on Order`,0) AS `Qty On Order`,coalesce(`products on back order`.`Quantity On Back Order`,0) AS `Qty On Back Order`,((coalesce(`inventory purchased`.`Quantity Purchased`,0) - coalesce(`inventory sold`.`Quantity Sold`,0)) - coalesce(`inventory on hold`.`Quantity On Hold`,0)) AS `Qty Available` from (((((`products` left join `inventory sold` on((`products`.`ID` = `inventory sold`.`ID`))) left join `inventory purchased` on((`products`.`ID` = `inventory purchased`.`ID`))) left join `inventory on hold` on((`products`.`ID` = `inventory on hold`.`ID`))) left join `inventory on order` on((`products`.`ID` = `inventory on order`.`ID`))) left join `products on back order` on((`products`.`ID` = `products on back order`.`ID`)))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `inventory_inner2`
--

/*!50001 DROP TABLE IF EXISTS `inventory_inner2`*/;
/*!50001 DROP VIEW IF EXISTS `inventory_inner2`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `inventory_inner2` AS select `inventory_inner1`.`Product ID` AS `Product ID`,`inventory_inner1`.`Product Name` AS `Product Name`,`inventory_inner1`.`Product Code` AS `Product Code`,`inventory_inner1`.`ReorderLevel` AS `Reorder Level`,`inventory_inner1`.`TargetLevel` AS `Target Level`,`inventory_inner1`.`Minimum Reorder Quantity` AS `Minimum Reorder Quantity`,`inventory_inner1`.`Qty Purchased` AS `Qty Purchased`,`inventory_inner1`.`Qty Sold` AS `Qty Sold`,`inventory_inner1`.`Qty On Hold` AS `Qty On Hold`,`inventory_inner1`.`Qty On Order` AS `Qty On Order`,`inventory_inner1`.`Qty On Back Order` AS `Qty On Back Order`,`inventory_inner1`.`Qty Available` AS `Qty Available`,((`inventory_inner1`.`Qty Available` + `inventory_inner1`.`Qty On Order`) - `inventory_inner1`.`Qty On Back Order`) AS `Current Level` from `inventory_inner1` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `order details extended`
--

/*!50001 DROP TABLE IF EXISTS `order details extended`*/;
/*!50001 DROP VIEW IF EXISTS `order details extended`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `order details extended` AS select `order details`.`ID` AS `ID`,`order details`.`OrderID` AS `Order ID`,`order details`.`ProductID` AS `Product ID`,`order details`.`Quantity` AS `Quantity`,`order details`.`UnitPrice` AS `Unit Price`,`order details`.`Discount` AS `Discount`,`order details`.`StatusID` AS `Status ID`,coalesce(`order details`.`DateAllocated`,'') AS `Date Allocated`,coalesce(`order details`.`PurchaseOrderID`,0) AS `Purchase Order ID`,coalesce(`order details`.`InventoryID`,0) AS `Inventory ID`,((`order details`.`Quantity` * `order details`.`UnitPrice`) * (1 - `order details`.`Discount`)) AS `Extended Price`,`order details status`.`StatusName` AS `Status Name` from (`order details` left join `order details status` on((`order details`.`StatusID` = `order details status`.`StatusID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `order list`
--

/*!50001 DROP TABLE IF EXISTS `order list`*/;
/*!50001 DROP VIEW IF EXISTS `order list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `order list` AS select `order list_inner`.`OrderID` AS `#`,`order list_inner`.`OrderDate` AS `Order Date`,`order list_inner`.`Status` AS `Status`,concat(`employees`.`FirstName`,' ',`employees`.`LastName`) AS `Salesperson`,`customers`.`Company` AS `Customer`,coalesce(date_format(`order list_inner`.`ShippedDate`,'%c/%d/%Y'),'') AS `Ship Date`,concat('$',format(`order list_inner`.`ShippingFee`,2)) AS `Shipping`,concat('$',format(`order list_inner`.`Taxes`,2)) AS `Taxes`,coalesce(concat('$',format(`order list_inner`.`Order Total`,2)),'') AS `Total` from ((`order list_inner` join `employees` on((`order list_inner`.`EmployeeID` = `employees`.`ID`))) join `customers` on((`order list_inner`.`CustomerID` = `customers`.`ID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `order list_inner`
--

/*!50001 DROP TABLE IF EXISTS `order list_inner`*/;
/*!50001 DROP VIEW IF EXISTS `order list_inner`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `order list_inner` AS select `orders`.`OrderID` AS `OrderID`,`orders`.`EmployeeID` AS `EmployeeID`,`orders`.`CustomerID` AS `CustomerID`,`orders`.`OrderDate` AS `OrderDate`,`orders`.`ShippedDate` AS `ShippedDate`,`order price totals`.`Price Total` AS `Sub Total`,`orders`.`ShippingFee` AS `ShippingFee`,`orders`.`Taxes` AS `Taxes`,((`order price totals`.`Price Total` + `orders`.`ShippingFee`) + `orders`.`Taxes`) AS `Order Total`,`orders`.`ShipName` AS `ShipName`,`orders`.`ShipAddress` AS `ShipAddress`,`orders`.`PaidDate` AS `PaidDate`,`orders status`.`StatusName` AS `Status` from ((`orders` left join `order price totals` on((`orders`.`OrderID` = `order price totals`.`Order ID`))) left join `orders status` on((`orders status`.`StatusID` = `orders`.`StatusID`))) order by `orders`.`OrderID` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `order price totals`
--

/*!50001 DROP TABLE IF EXISTS `order price totals`*/;
/*!50001 DROP VIEW IF EXISTS `order price totals`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `order price totals` AS select `order details extended`.`Order ID` AS `Order ID`,sum(`order details extended`.`Extended Price`) AS `Price Total` from `order details extended` group by `order details extended`.`Order ID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product orders`
--

/*!50001 DROP TABLE IF EXISTS `product orders`*/;
/*!50001 DROP VIEW IF EXISTS `product orders`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product orders` AS select `order details`.`ProductID` AS `Product ID`,`orders`.`OrderID` AS `Order ID`,`orders`.`OrderDate` AS `Order Date`,`orders`.`ShippedDate` AS `Shipped Date`,`orders`.`CustomerID` AS `Customer ID`,`order details`.`Quantity` AS `Quantity`,`order details`.`UnitPrice` AS `Unit Price`,`order details`.`Discount` AS `Discount`,'Sale' AS `Transaction`,`customers extended`.`Company` AS `Company Name`,`order details`.`StatusID` AS `Status ID` from ((`customers extended` join `orders` on((`customers extended`.`ID` = `orders`.`CustomerID`))) join `order details` on((`orders`.`OrderID` = `order details`.`OrderID`))) order by `orders`.`OrderDate` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product purchases`
--

/*!50001 DROP TABLE IF EXISTS `product purchases`*/;
/*!50001 DROP VIEW IF EXISTS `product purchases`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product purchases` AS select `purchase order details`.`ProductID` AS `Product ID`,`purchase orders`.`PurchaseOrderID` AS `Purchase Order ID`,`purchase orders`.`CreationDate` AS `Creation Date`,`purchase order details`.`Quantity` AS `Quantity`,`purchase order details`.`UnitCost` AS `Unit Cost`,'Purchase' AS `Transaction`,`suppliers`.`Company` AS `Company Name`,`purchase order details`.`PostedToInventory` AS `Posted To Inventory` from (`suppliers` join (`purchase orders` join `purchase order details` on((`purchase orders`.`PurchaseOrderID` = `purchase order details`.`PurchaseOrderID`))) on((`suppliers`.`ID` = `purchase orders`.`SupplierID`))) where (`purchase order details`.`PostedToInventory` = 1) order by `purchase orders`.`CreationDate` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `product transactions`
--

/*!50001 DROP TABLE IF EXISTS `product transactions`*/;
/*!50001 DROP VIEW IF EXISTS `product transactions`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `product transactions` AS select `product orders`.`Product ID` AS `Product ID`,`product orders`.`Order Date` AS `Order Date`,`product orders`.`Company Name` AS `Company Name`,`product orders`.`Transaction` AS `Transaction`,`product orders`.`Quantity` AS `Quantity` from `product orders` union select `product purchases`.`Product ID` AS `Product ID`,`product purchases`.`Creation Date` AS `Creation Date`,`product purchases`.`Company Name` AS `Company Name`,`product purchases`.`Transaction` AS `Transaction`,`product purchases`.`Quantity` AS `Quantity` from `product purchases` order by `Order Date` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `products on back order`
--

/*!50001 DROP TABLE IF EXISTS `products on back order`*/;
/*!50001 DROP VIEW IF EXISTS `products on back order`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `products on back order` AS select `order details`.`ProductID` AS `ID`,sum(`order details`.`Quantity`) AS `Quantity On Back Order` from `order details` where (`order details`.`StatusID` = 4) group by `order details`.`ProductID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `purchase details extended`
--

/*!50001 DROP TABLE IF EXISTS `purchase details extended`*/;
/*!50001 DROP VIEW IF EXISTS `purchase details extended`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `purchase details extended` AS select `purchase order details`.`ID` AS `ID`,`purchase order details`.`PurchaseOrderID` AS `PurchaseOrderID`,`purchase order details`.`ProductID` AS `ProductID`,`purchase order details`.`Quantity` AS `Quantity`,`purchase order details`.`UnitCost` AS `UnitCost`,`purchase order details`.`DateReceived` AS `DateReceived`,`purchase order details`.`PostedToInventory` AS `PostedToInventory`,`purchase order details`.`InventoryID` AS `InventoryID`,(`purchase order details`.`Quantity` * `purchase order details`.`UnitCost`) AS `Extended Price`,`products`.`ProductName` AS `ProductName` from (`products` join `purchase order details` on((`products`.`ID` = `purchase order details`.`ProductID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `purchase orders list`
--

/*!50001 DROP TABLE IF EXISTS `purchase orders list`*/;
/*!50001 DROP VIEW IF EXISTS `purchase orders list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `purchase orders list` AS select `purchase summary`.`PurchaseOrderID` AS `#`,`purchase summary`.`Status` AS `Status`,`suppliers`.`Company` AS `Company`,`purchase summary`.`Order Total` AS `Total`,concat(`employees`.`FirstName`,' ',`employees`.`LastName`) AS `Submitted By`,`purchase summary`.`SubmittedDate` AS `Submitted`,concat(`employees2`.`FirstName`,' ',`employees2`.`LastName`) AS `Approved By`,`purchase summary`.`ApprovedDate` AS `Approved`,`purchase summary`.`PaymentDate` AS `Date Paid` from (((`purchase summary` join `suppliers` on((`suppliers`.`ID` = `purchase summary`.`SupplierID`))) left join `employees` on((`employees`.`ID` = `purchase summary`.`SubmittedBy`))) left join `employees` `employees2` on((`employees2`.`ID` = `purchase summary`.`ApprovedBy`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `purchase price totals`
--

/*!50001 DROP TABLE IF EXISTS `purchase price totals`*/;
/*!50001 DROP VIEW IF EXISTS `purchase price totals`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `purchase price totals` AS select `purchase details extended`.`PurchaseOrderID` AS `Purchase ID`,sum(`purchase details extended`.`Extended Price`) AS `Price Total` from `purchase details extended` group by `purchase details extended`.`PurchaseOrderID` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `purchase summary`
--

/*!50001 DROP TABLE IF EXISTS `purchase summary`*/;
/*!50001 DROP VIEW IF EXISTS `purchase summary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `purchase summary` AS select `purchase orders`.`CreationDate` AS `CreationDate`,`purchase order status`.`Status` AS `Status`,`purchase orders`.`SupplierID` AS `SupplierID`,`purchase orders`.`ShippingFee` AS `ShippingFee`,`purchase orders`.`Taxes` AS `Taxes`,((`purchase price totals`.`Price Total` + `purchase orders`.`ShippingFee`) + `purchase orders`.`Taxes`) AS `Order Total`,`purchase price totals`.`Price Total` AS `Sub Total`,`purchase orders`.`PaymentDate` AS `PaymentDate`,`purchase orders`.`ApprovedBy` AS `ApprovedBy`,`purchase orders`.`ApprovedDate` AS `ApprovedDate`,`purchase orders`.`SubmittedBy` AS `SubmittedBy`,`purchase orders`.`SubmittedDate` AS `SubmittedDate`,`purchase orders`.`StatusID` AS `StatusID`,`purchase orders`.`PurchaseOrderID` AS `PurchaseOrderID` from (`purchase order status` join (`purchase orders` join `purchase price totals` on((`purchase orders`.`PurchaseOrderID` = `purchase price totals`.`Purchase ID`))) on((`purchase order status`.`StatusID` = `purchase orders`.`StatusID`))) order by `purchase orders`.`StatusID`,`purchase orders`.`PurchaseOrderID` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `shipper list`
--

/*!50001 DROP TABLE IF EXISTS `shipper list`*/;
/*!50001 DROP VIEW IF EXISTS `shipper list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `shipper list` AS select `shippers`.`ID` AS `ID`,`shippers`.`Company` AS `Company`,`shippers`.`FirstName` AS `First Name`,`shippers`.`LastName` AS `Last Name`,`shippers`.`EmailAddress` AS `Email Address`,`shippers`.`BusinessPhone` AS `Business Phone`,`shippers`.`JobTitle` AS `Job Title` from `shippers` order by `shippers`.`LastName` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `supplier list`
--

/*!50001 DROP TABLE IF EXISTS `supplier list`*/;
/*!50001 DROP VIEW IF EXISTS `supplier list`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `supplier list` AS select `suppliers`.`ID` AS `ID`,`suppliers`.`Company` AS `Company`,`suppliers`.`FirstName` AS `First Name`,`suppliers`.`LastName` AS `Last Name`,`suppliers`.`EmailAddress` AS `Email Address`,`suppliers`.`BusinessPhone` AS `Business Phone`,`suppliers`.`JobTitle` AS `Job Title` from `suppliers` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-05-06 11:47:18
