-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2024 at 08:51 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `honeypot`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
                          `id` int(11) NOT NULL,
                          `name` varchar(50) DEFAULT NULL,
                          `email` varchar(50) DEFAULT NULL,
                          `company_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`id`, `name`, `email`, `company_name`) VALUES
                                                                 (1, 'Randolf', 'rspirit0@google.com', 'Ainyx'),
                                                                 (2, 'Lincoln', 'lcowerd1@google.ru', 'Pixonyx'),
                                                                 (3, 'Ab', 'arase2@nationalgeographic.com', 'Kwilith'),
                                                                 (4, 'Lelia', 'lduplock3@alibaba.com', 'Realcube'),
                                                                 (5, 'Elnora', 'ehunnaball4@histats.com', 'Vidoo'),
                                                                 (6, 'asdf', 'asdf', 'asdf'),
                                                                 (12, 'sadf', 'asdf', 'sadf'),
                                                                 (13, 'sdaf', 'sdaf', 'sadf');

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

CREATE TABLE `invoices` (
                            `ID` int(11) NOT NULL,
                            `JobID` int(11) DEFAULT NULL,
                            `CustomerName` varchar(50) DEFAULT NULL,
                            `AmountDue` decimal(10,2) DEFAULT NULL,
                            `PaymentStatus` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoices`
--

INSERT INTO `invoices` (`ID`, `JobID`, `CustomerName`, `AmountDue`, `PaymentStatus`) VALUES
                                                                                         (1, 42235, 'John Doe', 350.00, 'Pending'),
                                                                                         (2, 42442, 'Jennifer Smith', 220.00, 'Succeeded'),
                                                                                         (3, 42257, 'John Smith', 341.00, 'Pending'),
                                                                                         (4, 42311, 'John Carpenter', 115.00, 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
                          `ID` int(11) NOT NULL,
                          `OrderReference` varchar(10) DEFAULT NULL,
                          `CompanyName` varchar(50) DEFAULT NULL,
                          `Status` varchar(20) DEFAULT NULL,
                          `Total` decimal(10,2) DEFAULT NULL,
                          `Created` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`ID`, `OrderReference`, `CompanyName`, `Status`, `Total`, `Created`) VALUES
                                                                                               (1, '#SO-13487', 'Gasper Antunes', 'Fulfilled', 2674.00, '2024-05-30'),
                                                                                               (2, '#SO-13453', 'Aartsen van', 'Confirmed', 3454.00, '2024-05-29'),
                                                                                               (3, '#SO-13498', 'Trashes Habard', 'Partially shipped', 6274.00, '2024-05-12'),
                                                                                               (4, '#SO-16499', 'Samban Hubart', 'Fulfilled', 6375.00, '2024-05-11');

-- --------------------------------------------------------

--
-- Table structure for table `quotes`
--

CREATE TABLE `quotes` (
                          `ID` int(11) NOT NULL,
                          `CustomerName` varchar(50) DEFAULT NULL,
                          `QuoteSum` decimal(10,2) DEFAULT NULL,
                          `PaymentStatus` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `quotes`
--

INSERT INTO `quotes` (`ID`, `CustomerName`, `QuoteSum`, `PaymentStatus`) VALUES
                                                                             (42235, 'John Smith', 879.00, 'Pending'),
                                                                             (42257, 'Joe van Rest', 3541.00, 'Pending'),
                                                                             (42311, 'John Zambrano', 4364.00, 'In Review'),
                                                                             (42442, 'Jennifer Smith', 226.00, 'Succeeded');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
                        `id` int(11) NOT NULL,
                        `name` varchar(255) NOT NULL,
                        `email` varchar(255) NOT NULL,
                        `role` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `name`, `email`, `role`) VALUES
                                                       (2, 'Liesa', 'lbrandenberg1@dailymotion.com', 'Subcontractor'),
                                                       (3, 'Alicia', 'aobradane2@storify.com', 'Engineer'),
                                                       (4, 'Gearalt', 'gdametti3@canalblog.com', 'Architect'),
                                                       (5, 'Trix', 'tmaycock4@github.io', 'Architect'),
                                                       (6, 'asdf', 'asd@asdf', 'asdf'),
                                                       (7, 'asdf', 'asdf', 'asdf'),
                                                       (8, 'asdf', 'asdf', 'asaaaaa'),
                                                       (9, 'asd', 'asd', 'asd'),
                                                       (10, 'asdf', 'asdf', 'asaaaaa'),
                                                       (11, 'asdf', 'asdf', 'asaaaaa'),
                                                       (12, 'asdf', 'asdf', 'asaaaaa'),
                                                       (13, 'asdf', 'asdf', 'asaaaaa'),
                                                       (15, 'asdf', 'sdafasd', 'sadfasdf');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
    ADD PRIMARY KEY (`id`);

--
-- Indexes for table `invoices`
--
ALTER TABLE `invoices`
    ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
    ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `quotes`
--
ALTER TABLE `quotes`
    ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
    ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `invoices`
--
ALTER TABLE `invoices`
    MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
    MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
    MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;