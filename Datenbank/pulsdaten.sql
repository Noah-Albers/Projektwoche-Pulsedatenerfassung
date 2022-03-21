-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 21. Mrz 2022 um 10:02
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
-- Tabellenstruktur für Tabelle `aktivitaet`
--

CREATE TABLE `aktivitaet` (
  `Id` int(5) NOT NULL,
  `Art` varchar(25) NOT NULL,
  `faktor` decimal(2,1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `aktivitaet`
--

INSERT INTO `aktivitaet` (`Id`, `Art`, `faktor`) VALUES
(1, 'Ruhepuls', NULL),
(2, 'Trainingspuls', NULL),
(3, 'Intervallmethode', '0.8'),
(4, 'Dauermethode', '0.6');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `geschlecht`
--

CREATE TABLE `geschlecht` (
  `ID` int(1) NOT NULL,
  `Geschlecht` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `geschlecht`
--

INSERT INTO `geschlecht` (`ID`, `Geschlecht`) VALUES
(1, 'm'),
(2, 'w');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `person`
--

CREATE TABLE `person` (
  `ID` int(5) NOT NULL,
  `Vorname` varchar(25) NOT NULL,
  `Nachname` varchar(25) NOT NULL,
  `Geburtsdatum` date NOT NULL,
  `Geschlecht` int(1) NOT NULL,
  `Koerpergroesse` decimal(3,2) NOT NULL,
  `Gewicht` int(3) NOT NULL,
  `trainingszustand` int(1) NOT NULL,
  `HFmax` int(3) NOT NULL,
  `passwd` varchar(32) NOT NULL,
  `passHash` varchar(32) NOT NULL,
  `isSuperuser` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `person`
--

INSERT INTO `person` (`ID`, `Vorname`, `Nachname`, `Geburtsdatum`, `Geschlecht`, `Koerpergroesse`, `Gewicht`, `trainingszustand`, `HFmax`, `passwd`, `passHash`, `isSuperuser`) VALUES
(1, 'Bruce', 'Banner', '1962-07-30', 1, '1.88', 106, 1, 165, '', '', b'0'),
(2, 'Bruce', 'Wayne', '1982-03-19', 1, '1.76', 90, 3, 221, '', '', b'0'),
(3, 'Peter', 'Parker', '2002-06-14', 1, '1.64', 74, 2, 204, '', '', b'0'),
(4, 'Harley', 'Quinn', '1998-09-15', 2, '1.75', 70, 2, 198, '', '', b'0'),
(5, 'Wilson', 'Fisk', '1974-01-29', 1, '1.96', 168, 3, 171, '', '', b'0');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `pulsdaten`
--

CREATE TABLE `pulsdaten` (
  `person` int(5) NOT NULL,
  `aktivitaet` int(5) NOT NULL,
  `wert` int(3) NOT NULL,
  `erfassungszeit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `pulsdaten`
--

INSERT INTO `pulsdaten` (`person`, `aktivitaet`, `wert`, `erfassungszeit`) VALUES
(1, 1, 70, '2022-02-11 13:40:51'),
(1, 2, 146, '2022-02-11 13:41:15'),
(1, 3, 140, '2022-02-11 13:45:08'),
(1, 3, 145, '2022-02-11 14:01:15'),
(1, 3, 151, '2022-02-11 14:09:22'),
(1, 3, 149, '2022-02-11 14:22:01'),
(1, 3, 142, '2022-02-11 14:30:04'),
(1, 1, 75, '2022-02-14 10:00:03'),
(1, 2, 129, '2022-02-14 10:01:01'),
(1, 4, 114, '2022-02-14 10:06:15'),
(1, 4, 120, '2022-02-14 10:12:15'),
(1, 4, 128, '2022-02-14 10:18:15'),
(1, 4, 129, '2022-02-14 10:24:15'),
(1, 4, 130, '2022-02-14 10:30:15'),
(1, 4, 131, '2022-02-14 10:36:15'),
(1, 4, 128, '2022-02-14 10:42:15'),
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
(5, 3, 168, '2022-02-11 14:29:36');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `trainingszustand`
--

CREATE TABLE `trainingszustand` (
  `ID` int(1) NOT NULL,
  `Typ` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `trainingszustand`
--

INSERT INTO `trainingszustand` (`ID`, `Typ`) VALUES
(1, 'Trainiert'),
(2, 'Untrainiert'),
(3, 'Übergewichtig');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `aktivitaet`
--
ALTER TABLE `aktivitaet`
  ADD PRIMARY KEY (`Id`);

--
-- Indizes für die Tabelle `geschlecht`
--
ALTER TABLE `geschlecht`
  ADD PRIMARY KEY (`ID`);

--
-- Indizes für die Tabelle `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Vorname` (`Vorname`,`Nachname`),
  ADD KEY `Koerpertyp` (`trainingszustand`),
  ADD KEY `Geschlecht` (`Geschlecht`);

--
-- Indizes für die Tabelle `pulsdaten`
--
ALTER TABLE `pulsdaten`
  ADD PRIMARY KEY (`person`,`erfassungszeit`),
  ADD KEY `pulserfassung_ibfk_2` (`aktivitaet`);

--
-- Indizes für die Tabelle `trainingszustand`
--
ALTER TABLE `trainingszustand`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `aktivitaet`
--
ALTER TABLE `aktivitaet`
  MODIFY `Id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT für Tabelle `person`
--
ALTER TABLE `person`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT für Tabelle `trainingszustand`
--
ALTER TABLE `trainingszustand`
  MODIFY `ID` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `person`
--
ALTER TABLE `person`
  ADD CONSTRAINT `person_ibfk_1` FOREIGN KEY (`trainingszustand`) REFERENCES `trainingszustand` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `person_ibfk_2` FOREIGN KEY (`Geschlecht`) REFERENCES `geschlecht` (`ID`);

--
-- Constraints der Tabelle `pulsdaten`
--
ALTER TABLE `pulsdaten`
  ADD CONSTRAINT `pulsdaten_ibfk_1` FOREIGN KEY (`person`) REFERENCES `person` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `pulsdaten_ibfk_2` FOREIGN KEY (`aktivitaet`) REFERENCES `aktivitaet` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
