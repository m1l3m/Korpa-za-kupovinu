-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 01, 2021 at 12:08 PM
-- Server version: 5.7.23
-- PHP Version: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tmp`
--
CREATE DATABASE IF NOT EXISTS `tmp` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `tmp`;

-- --------------------------------------------------------

--
-- Table structure for table `artikli`
--

DROP TABLE IF EXISTS `artikli`;
CREATE TABLE IF NOT EXISTS `artikli` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_korisnika` int(11) NOT NULL,
  `naziv` varchar(30) NOT NULL,
  `opis` varchar(300) NOT NULL,
  `kolicina` int(11) NOT NULL,
  `jedinicna_cijena` double NOT NULL,
  `slika` varchar(255) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_korisnik_artkal` (`id_korisnika`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `artikli`
--

INSERT INTO `artikli` (`id`, `id_korisnika`, `naziv`, `opis`, `kolicina`, `jedinicna_cijena`, `slika`) VALUES
(1, 1, 'CocaCola', 'Piće', 11, 1, 'cola.jpg'),
(2, 1, 'Fanta', 'Piće', 5, 1, 'fanta.jpg'),
(3, 1, 'Hljeb', 'Bijeli, rezani', 2, 1.5, 'hljeb.jpg'),
(4, 2, 'Sladoled - kornet', 'Ledo', 5, 1.2, 'kornet.jpg'),
(5, 2, 'Maramice', 'pakovanje 10kom', 1, 1.8, 'maramice.jpg'),
(6, 2, 'Salvete', 'Pakovanje 100kom, bijele', 4, 0.9, 'salvete.jpg'),
(9, 1, 'Kifla', 'Mala kifla', 10, 0.1, '');

-- --------------------------------------------------------

--
-- Table structure for table `korisnici`
--

DROP TABLE IF EXISTS `korisnici`;
CREATE TABLE IF NOT EXISTS `korisnici` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(32) NOT NULL,
  `password` varchar(128) NOT NULL,
  `ime` varchar(32) DEFAULT NULL,
  `prezime` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `korisnici`
--

INSERT INTO `korisnici` (`id`, `username`, `password`, `ime`, `prezime`) VALUES
(1, 'tmp1', '*23AE809DDACAF96AF0FD78ED04B6A265E05AA257', 'Petar', 'Petrović'),
(2, 'tmp2', '*531E182E2F72080AB0740FE2F2D689DBE0146E04', 'Ivana', 'Ivanović'),
(3, 'tmp3', '*846AEC788124A4D732D51692E35E9DE488607F86', 'Marko', 'Marković');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
