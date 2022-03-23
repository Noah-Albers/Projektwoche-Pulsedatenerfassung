-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 23. Mrz 2022 um 10:51
-- Server-Version: 10.4.22-MariaDB
-- PHP-Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `pulsdaten`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `activity`
--

CREATE TABLE `activity` (
  `Id` int(5) NOT NULL,
  `Name` varchar(25) NOT NULL,
  `Factor` decimal(2,1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `activity`
--

INSERT INTO `activity` (`Id`, `Name`, `Factor`) VALUES
(1, 'Ruhepuls', NULL),
(2, 'Trainingspuls', NULL),
(3, 'Intervallmethode', '0.8'),
(4, 'Dauermethode', '0.6');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `person`
--

CREATE TABLE `person` (
  `ID` int(5) NOT NULL,
  `Firstname` varchar(25) NOT NULL,
  `Lastname` varchar(25) NOT NULL,
  `Birthday` date NOT NULL,
  `Gender` int(1) NOT NULL,
  `Bodysize` decimal(3,2) NOT NULL,
  `Weight` int(3) NOT NULL,
  `TrainingCondition` int(1) NOT NULL,
  `HFmax` int(3) NOT NULL,
  `Passwd` varchar(64) NOT NULL,
  `PassSalt` varchar(32) NOT NULL,
  `IsSuperuser` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `person`
--

INSERT INTO `person` (`ID`, `Firstname`, `Lastname`, `Birthday`, `Gender`, `Bodysize`, `Weight`, `TrainingCondition`, `HFmax`, `Passwd`, `PassSalt`, `IsSuperuser`) VALUES
(18, 'Florian', 'Keller', '2009-02-02', 1, '1.00', 3, 1, 205, '1f43869ca28ccd3cefc957eac3e43900c731b9ac8151b7d05f8faeda37183fcf', '�\'�����rtv`VIJ��*����f�SOg	}�\0�+', b'0');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pulsdata`
--

CREATE TABLE `pulsdata` (
  `Person` int(5) NOT NULL,
  `Activity` int(5) NOT NULL,
  `Value` int(3) NOT NULL,
  `RecordTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `pulsdata`
--

INSERT INTO `pulsdata` (`Person`, `Activity`, `Value`, `RecordTime`) VALUES
(18, 1, 81, '2022-02-11 13:41:20'),
(18, 2, 153, '2022-02-11 13:41:58'),
(18, 3, 155, '2022-02-11 13:45:48'),
(18, 3, 162, '2022-02-11 14:02:12'),
(18, 3, 166, '2022-02-11 14:09:58'),
(18, 3, 169, '2022-02-11 14:22:00'),
(18, 3, 168, '2022-02-11 14:29:36'),
(18, 1, 65, '2022-03-01 08:40:58'),
(18, 2, 100, '2022-03-01 08:41:41'),
(18, 4, 102, '2022-03-01 08:42:06'),
(18, 4, 105, '2022-03-01 08:57:06'),
(18, 4, 135, '2022-03-01 09:12:06'),
(18, 4, 154, '2022-03-01 09:27:06'),
(18, 4, 168, '2022-03-01 09:42:06'),
(18, 4, 181, '2022-03-01 09:57:06'),
(18, 4, 160, '2022-03-01 10:12:06');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `trainingcondition`
--

CREATE TABLE `trainingcondition` (
  `ID` int(1) NOT NULL,
  `Name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `trainingcondition`
--

INSERT INTO `trainingcondition` (`ID`, `Name`) VALUES
(1, 'Trainiert'),
(2, 'Untrainiert'),
(3, 'Übergewichtig');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `activity`
--
ALTER TABLE `activity`
  ADD PRIMARY KEY (`Id`);

--
-- Indizes für die Tabelle `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Vorname` (`Firstname`,`Lastname`),
  ADD KEY `Koerpertyp` (`TrainingCondition`),
  ADD KEY `Geschlecht` (`Gender`);

--
-- Indizes für die Tabelle `pulsdata`
--
ALTER TABLE `pulsdata`
  ADD PRIMARY KEY (`Person`,`RecordTime`),
  ADD KEY `pulserfassung_ibfk_2` (`Activity`);

--
-- Indizes für die Tabelle `trainingcondition`
--
ALTER TABLE `trainingcondition`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `activity`
--
ALTER TABLE `activity`
  MODIFY `Id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT für Tabelle `person`
--
ALTER TABLE `person`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT für Tabelle `trainingcondition`
--
ALTER TABLE `trainingcondition`
  MODIFY `ID` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `person`
--
ALTER TABLE `person`
  ADD CONSTRAINT `person_ibfk_1` FOREIGN KEY (`TrainingCondition`) REFERENCES `trainingcondition` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints der Tabelle `pulsdata`
--
ALTER TABLE `pulsdata`
  ADD CONSTRAINT `pulsdata_ibfk_1` FOREIGN KEY (`Person`) REFERENCES `person` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `pulsdata_ibfk_2` FOREIGN KEY (`Activity`) REFERENCES `activity` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
