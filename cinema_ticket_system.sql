-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 28, 2019 at 05:22 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cinema_ticket_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `movie_id` int(11) NOT NULL,
  `movie_name` text COLLATE utf8_unicode_ci NOT NULL,
  `movie_genre` text COLLATE utf8_unicode_ci NOT NULL,
  `theater_name` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`movie_id`, `movie_name`, `movie_genre`, `theater_name`) VALUES
(1, 'Movie1', 'Category1', 'Theater1'),
(2, 'Movie2', 'Category2', 'Theater2'),
(3, 'Movie3', 'Category3', 'Theater3');

-- --------------------------------------------------------

--
-- Table structure for table `sale`
--

CREATE TABLE `sale` (
  `sale_id` int(11) NOT NULL,
  `voucher_id` int(11) NOT NULL,
  `seat_id` char(11) COLLATE utf8_unicode_ci NOT NULL,
  `seat_no` text COLLATE utf8_unicode_ci NOT NULL,
  `movie_name` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sale`
--

INSERT INTO `sale` (`sale_id`, `voucher_id`, `seat_id`, `seat_no`, `movie_name`) VALUES
(1, 1, 'A', 'A1', 'Movie2'),
(2, 1, 'A', 'A2', 'Movie2'),
(3, 1, 'A', 'A3', 'Movie2'),
(4, 2, 'A', 'A1', 'Movie2'),
(5, 2, 'A', 'A2', 'Movie2'),
(6, 5, 'A', 'A2', 'Movie2'),
(7, 5, 'A', 'A1', 'Movie2'),
(8, 6, 'A', 'A1', 'Movie1'),
(9, 6, 'A', 'A2', 'Movie1'),
(10, 7, 'A', 'A1', 'Movie2'),
(11, 7, 'A', 'A2', 'Movie2'),
(12, 8, 'A', 'A1', 'Movie2'),
(13, 8, 'A', 'A2', 'Movie2'),
(14, 8, 'A', 'A3', 'Movie2'),
(15, 9, 'A', 'A1', 'Movie1'),
(16, 9, 'A', 'A2', 'Movie1'),
(17, 10, 'A', 'A1', 'Movie2'),
(18, 10, 'A', 'A2', 'Movie2'),
(19, 11, 'A', 'A1', 'Movie2'),
(20, 11, 'A', 'A2', 'Movie2'),
(21, 12, 'A', 'A1', 'Movie2'),
(22, 12, 'A', 'A2', 'Movie2'),
(23, 13, 'A', 'A2', 'Movie2'),
(24, 13, 'A', 'A1', 'Movie2'),
(25, 14, 'A', 'A2', 'Movie1'),
(26, 14, 'A', 'A1', 'Movie1'),
(27, 15, 'A', 'A1', 'Movie2'),
(28, 15, 'A', 'A2', 'Movie2'),
(29, 16, 'A', 'A1', 'Movie2'),
(30, 16, 'A', 'A2', 'Movie2'),
(31, 17, 'A', 'A1', 'Movie2'),
(32, 17, 'A', 'A2', 'Movie2'),
(33, 18, 'A', 'A1', 'Movie1'),
(34, 18, 'A', 'A2', 'Movie1'),
(35, 19, 'A', 'A1', 'Movie2'),
(36, 19, 'A', 'A2', 'Movie2'),
(37, 20, 'A', 'A1', 'Movie2'),
(38, 20, 'A', 'A2', 'Movie2');

-- --------------------------------------------------------

--
-- Table structure for table `seat`
--

CREATE TABLE `seat` (
  `id` int(11) NOT NULL,
  `seat_id` char(1) COLLATE utf8_unicode_ci NOT NULL,
  `price` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `seat`
--

INSERT INTO `seat` (`id`, `seat_id`, `price`) VALUES
(1, 'A', '3000'),
(2, 'B', '4000'),
(3, 'C', '5000');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staff_id` int(11) NOT NULL,
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `email` text COLLATE utf8_unicode_ci NOT NULL,
  `password` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `name`, `email`, `password`) VALUES
(1, 'Kaung', 'kaung@gmail.com', 'kaung');

-- --------------------------------------------------------

--
-- Table structure for table `voucher`
--

CREATE TABLE `voucher` (
  `voucher_id` int(11) NOT NULL,
  `movie_name` text COLLATE utf8_unicode_ci NOT NULL,
  `show_time` text COLLATE utf8_unicode_ci NOT NULL,
  `seat_no` text COLLATE utf8_unicode_ci NOT NULL,
  `total_seats` int(11) NOT NULL,
  `total_amount` int(11) NOT NULL,
  `paid_amount` int(11) NOT NULL,
  `change_amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `voucher`
--

INSERT INTO `voucher` (`voucher_id`, `movie_name`, `show_time`, `seat_no`, `total_seats`, `total_amount`, `paid_amount`, `change_amount`) VALUES
(1, 'Movie2', '9:30 AM', '', 0, 0, 0, 0),
(2, 'Movie2', '9:30 AM', '', 0, 0, 0, 0),
(3, 'Movie3', '6:30PM', '', 0, 0, 0, 0),
(4, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(5, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(6, 'Movie1', '6:30PM', '', 0, 0, 0, 0),
(7, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(8, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(9, 'Movie1', '12:30 PM', '', 0, 0, 0, 0),
(10, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(11, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(12, 'Movie2', '6:30PM', '', 0, 0, 0, 0),
(13, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(14, 'Movie1', '6:30PM', '', 0, 0, 0, 0),
(15, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(16, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(17, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(18, 'Movie1', '12:30 PM', '', 0, 0, 0, 0),
(19, 'Movie2', '12:30 PM', '', 0, 0, 0, 0),
(20, 'Movie2', '6:30PM', '', 0, 0, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`movie_id`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`sale_id`);

--
-- Indexes for table `seat`
--
ALTER TABLE `seat`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `voucher`
--
ALTER TABLE `voucher`
  ADD PRIMARY KEY (`voucher_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movie`
--
ALTER TABLE `movie`
  MODIFY `movie_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `sale`
--
ALTER TABLE `sale`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `seat`
--
ALTER TABLE `seat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `staff_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `voucher`
--
ALTER TABLE `voucher`
  MODIFY `voucher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
