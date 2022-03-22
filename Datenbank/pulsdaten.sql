-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 22. Mrz 2022 um 08:57
-- Server-Version: 10.4.21-MariaDB
-- PHP-Version: 7.3.31

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
(1, 'Bruce', 'Banner', '1962-07-30', 1, '1.88', 106, 1, 165, 'I have a password', '', b'0'),
(2, 'Bruce', 'Wayne', '2002-06-14', 1, '1.76', 90, 3, 221, '', '', b'0'),
(3, 'Peter', 'Parker', '2002-06-14', 1, '1.64', 74, 2, 50, '', '', b'0'),
(4, 'Harley', 'Quinn', '1998-09-15', 2, '1.75', 70, 2, 198, '', '', b'0'),
(5, 'Wilson', 'Fisk', '1974-01-29', 1, '1.96', 168, 3, 171, '', '', b'0'),
(12, '1', '2', '2022-03-21', 1, '1.00', 1, 1, 1, '7b0393befdc28ff2a7c5e08fa8a38a4c845da5c600476eb01ae7b865fa344f18', 'abc', b'0'),
(13, 'Joe', 'biden', '2022-03-21', 1, '1.00', 1, 1, 1, '4a7be16e899415871ce71ca030cb4d6b16b2857ea0292828373d48d2bebf9171', 'gP�*�Y�\\��ۢ^��\Z,ˮBpo�j�/����G�', b'0'),
(14, 'Longus', 'Schlongus', '2022-03-21', 1, '1.00', 1, 1, 1, '50e4d30a6a1f828fe5fc2e391bc6384cfb7b5ff41cf98f7474baa3655e2bdcaf', '�TF�Å�S#�Rg-l�K����ܣ��כ(', b'0'),
(15, 'yo', 'yo', '2022-03-21', 1, '1.00', 1, 1, 1, '07957a71bd3eb84afd1af7814a5062a4436d08f34715984f1586b5beb8b74da5', '�0�\n���)A���GG\'\'��_5s����U', b'0');

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
(3, 1, 65, '2022-03-01 08:40:58'),
(3, 2, 100, '2022-03-01 08:41:41'),
(3, 4, 102, '2022-03-01 08:42:06'),
(3, 4, 105, '2022-03-01 08:57:06'),
(3, 4, 135, '2022-03-01 09:12:06'),
(3, 4, 154, '2022-03-01 09:27:06'),
(3, 4, 168, '2022-03-01 09:42:06'),
(3, 4, 181, '2022-03-01 09:57:06'),
(3, 4, 160, '2022-03-01 10:12:06'),
(5, 1, 81, '2022-02-11 13:41:20'),
(5, 2, 153, '2022-02-11 13:41:58'),
(5, 3, 155, '2022-02-11 13:45:48'),
(5, 3, 162, '2022-02-11 14:02:12'),
(5, 3, 166, '2022-02-11 14:09:58'),
(5, 3, 169, '2022-02-11 14:22:00'),
(5, 3, 168, '2022-02-11 14:29:36'),
(15, 1, 70, '2022-02-11 13:40:51'),
(15, 2, 146, '2022-02-11 13:41:15'),
(15, 3, 140, '2022-02-11 13:45:08'),
(15, 3, 145, '2022-02-11 14:01:15'),
(15, 3, 151, '2022-02-11 14:09:22'),
(15, 3, 149, '2022-02-11 14:22:01'),
(15, 3, 142, '2022-02-11 14:30:04'),
(15, 1, 75, '2022-02-14 10:00:03'),
(15, 2, 129, '2022-02-14 10:01:01'),
(15, 4, 114, '2022-02-14 10:06:15'),
(15, 4, 120, '2022-02-14 10:12:15'),
(15, 4, 128, '2022-02-14 10:18:15'),
(15, 4, 129, '2022-02-14 10:24:15'),
(15, 4, 130, '2022-02-14 10:30:15'),
(15, 4, 131, '2022-02-14 10:36:15'),
(15, 4, 128, '2022-02-14 10:42:15');

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
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

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
  ADD CONSTRAINT `pulsdata_ibfk_2` FOREIGN KEY (`activity`) REFERENCES `activity` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
