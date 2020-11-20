-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 26 okt 2020 om 09:12
-- Serverversie: 10.3.15-MariaDB
-- PHP-versie: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `geldautomaat`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `account`
--

CREATE TABLE `account` (
  `user_id` int(11) NOT NULL,
  `rekeningnummer` varchar(18) NOT NULL,
  `password` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `admin` tinyint(1) DEFAULT 0,
  `adres` varchar(40) NOT NULL,
  `woonplaats` varchar(20) NOT NULL,
  `email` varchar(40) NOT NULL,
  `birthday` varchar(255) NOT NULL,
  `blocked` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `account`
--

INSERT INTO `account` (`user_id`, `rekeningnummer`, `password`, `name`, `admin`, `adres`, `woonplaats`, `email`, `birthday`, `blocked`) VALUES
(3, 'NL30BUNQ3000', '-371810770', 'Sander', 1, '', '', '', '0000-00-00 00:00:00', 0),
(4, 'BE11RABO0000', '406113220', 'Test', 0, '', '', '', '0000-00-00 00:00:00', 0),
(5, 'NL00RABO1234', '-1152142086', 'Jelmer Mackay', 0, '', '', '', '0000-00-00 00:00:00', 0),
(6, 'NL22RABO1', '-1152142086', 'Pieter van der Hoef', 0, 'Computerweg 3', 'Amersfoort', 'P@gmail.com', '0000-00-00 00:00:00', 0),
(7, 'NL33INGB1234', '-1152142086', 'pieter', 0, 'Amersfoortsestraat 4', 'Barneveld', 'Pieter@outlook.com', '0000-00-00 00:00:00', 0),
(8, 'NL22C', '2222', 'Nielan', 0, 'Disketteweg 34', 'Ede', '', '0000-00-00 00:00:00', 0),
(9, 'NL20RABO', '2222', 'Peter', 0, 'Peterstraat 3', 'Amersfoort', 'nieland@gmail.com', '0000-00-00 00:00:00', 0),
(10, 'NL22B', '-1152142086', 'Peter', 0, 'Thor', 'Barneveld', 'peter@gmail.com', '0000-00-00 00:00:00', 0),
(11, 'NL20B', '-1152142086', 'test', 0, 'test', 'test', 'test', '0000-00-00 00:00:00', 1),
(12, 'test', '-1152142086', 'test', 1, 'test', 'test', 'test', '0000-00-00 00:00:00', 0),
(13, 'TEST3', '-1152142086', 'Test', 0, 'test', 'test', 'test', '0000-00-00 00:00:00', 1),
(14, 'TESTSTS', '-371810770', 'Test', 0, 'sdf', 'sdf', 'sdf', '0000-00-00 00:00:00', 1),
(15, 'sdf', '406113220', 'sdfsdf', 0, 'sdfsdf', 'dsf', 'sdf', '10/16/2020 12:00:00 AM', 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `balance`
--

CREATE TABLE `balance` (
  `balance_id` int(11) NOT NULL,
  `rekening_nummer` varchar(255) NOT NULL,
  `balance` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `balance`
--

INSERT INTO `balance` (`balance_id`, `rekening_nummer`, `balance`) VALUES
(1, 'NL22RABO1234', 100237.05),
(4, 'NL00RABO1234', 0.00),
(5, 'NL33INGB1234', 30.00),
(6, 'NL20B', 0.00),
(7, 'test', 0.00),
(8, 'TEST3', 0.00),
(9, 'TESTSTS', 0.00),
(10, 'sdf', 0.00);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `transaction`
--

CREATE TABLE `transaction` (
  `transaction_id` int(11) NOT NULL,
  `rekening_nummer` varchar(255) NOT NULL,
  `datetime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `description` varchar(255) NOT NULL,
  `quantity` double NOT NULL,
  `plus_min` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden geëxporteerd voor tabel `transaction`
--

INSERT INTO `transaction` (`transaction_id`, `rekening_nummer`, `datetime`, `description`, `quantity`, `plus_min`) VALUES
(1, '0', '2020-10-01 11:17:56', 'Geld gestort', 2, 1),
(2, '0', '2020-10-01 11:19:57', 'Geld gestort', 30.5, 1),
(3, 'NL22RABO1234', '2020-10-01 11:20:56', 'Geld gestort', 30.5, 1),
(6, 'NL22RABO1234', '2020-10-01 12:30:15', 'Geld gestort', 40, 1),
(9, 'NL22RABO1234', '2020-10-01 13:50:48', 'Geld opgenomen', 5, 0),
(10, 'NL22RABO1234', '2020-10-01 20:16:46', 'Geld gestort', 50, 1),
(11, 'NL22RABO1234', '2020-10-01 20:48:42', 'Geld gestort', 500, 1),
(13, 'NL22RABO1234', '2020-10-01 20:48:57', 'Geld opgenomen', 200, 0),
(15, 'NL22RABO1234', '2020-10-02 08:30:13', 'Geld gestort', 500, 1),
(16, 'NL22RABO1234', '2020-10-02 08:30:16', 'Geld opgenomen', 5, 0),
(17, 'NL22RABO1234', '2020-10-02 08:32:58', 'Geld opgenomen', 5, 0),
(18, 'NL22RABO1234', '2020-10-02 08:33:00', 'Geld opgenomen', 20, 0),
(19, 'NL22RABO1234', '2020-10-02 12:26:41', 'Geld gestort', 5, 1),
(20, 'NL22RABO1234', '2020-10-06 13:41:04', 'Geld gestort', 50, 1),
(22, 'NL22RABO1234', '2020-10-06 13:41:15', 'Geld opgenomen', 5, 0),
(23, 'NL22RABO1234', '2020-10-06 13:41:18', 'Geld opgenomen', 200, 0),
(24, 'NL22RABO1234', '2020-10-07 07:36:30', 'Geld opgenomen', 5, 0),
(25, 'NL22RABO1234', '2020-10-07 07:39:46', 'Geld gestort', 5, 1),
(26, 'NL22RABO1234', '2020-10-07 07:39:50', 'Geld opgenomen', 5, 0),
(27, 'NL22RABO1234', '2020-10-07 07:40:33', 'Geld gestort', 125, 1),
(28, 'NL33INGB1234', '2020-10-07 08:21:08', 'Geld gestort', 5, 1),
(29, 'NL33INGB1234', '2020-10-07 08:21:15', 'Geld gestort', 5, 1),
(30, 'NL33INGB1234', '2020-10-07 08:21:28', 'Geld gestort', 5, 1),
(31, 'NL33INGB1234', '2020-10-07 08:21:33', 'Geld gestort', 15, 1),
(32, 'NL22RABO1234', '2020-10-07 09:34:05', 'Geld opgenomen', 200, 0),
(33, 'NL22RABO1234', '2020-10-07 09:45:42', 'Geld gestort', 100000, 1);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexen voor tabel `balance`
--
ALTER TABLE `balance`
  ADD PRIMARY KEY (`balance_id`);

--
-- Indexen voor tabel `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`transaction_id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `account`
--
ALTER TABLE `account`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT voor een tabel `balance`
--
ALTER TABLE `balance`
  MODIFY `balance_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT voor een tabel `transaction`
--
ALTER TABLE `transaction`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
