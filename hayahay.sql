-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 16, 2016 at 11:05 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hayahay`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE IF NOT EXISTS `books` (
  `bookid` int(11) NOT NULL AUTO_INCREMENT,
  `bookname` varchar(255) NOT NULL,
  `bookauthor` varchar(255) NOT NULL,
  `bookyear` varchar(255) NOT NULL,
  `bookcat` varchar(255) NOT NULL,
  `av` int(11) NOT NULL,
  `holder` varchar(255) NOT NULL,
  `dueday` varchar(255) NOT NULL,
  `duemonth` varchar(255) NOT NULL,
  PRIMARY KEY (`bookid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`bookid`, `bookname`, `bookauthor`, `bookyear`, `bookcat`, `av`, `holder`, `dueday`, `duemonth`) VALUES
(1, 'A Walk To Remember', 'Lennon Jansuy', '1994', 'Mystic', 0, 'admin', '16', 'May');

-- --------------------------------------------------------

--
-- Table structure for table `user_info`
--

CREATE TABLE IF NOT EXISTS `user_info` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `mname` varchar(255) NOT NULL,
  `stud_id` varchar(255) NOT NULL,
  `section` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `contactnumber` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `sex` varchar(255) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `user_info`
--

INSERT INTO `user_info` (`uid`, `fname`, `lname`, `mname`, `stud_id`, `section`, `email`, `contactnumber`, `status`, `address`, `sex`) VALUES
(1, 'Lennon Benedict', 'Jansuy', 'D', '201510560', 'ACT A', 'mystic.guardian.13@gmail.com', '09752904353', 'Admin', 'Poblacion IV, Tanza Cavite', 'Male'),
(2, 'Nicole', 'Joya', 'G', '201610042', 'ACT 101 - A', 'joya_dota_24@gmail.com', '09752186743', 'User', 'Julugan IV, Felepe San Diego  California', 'Male'),
(3, 'Janelle', 'Abad', 'H', '201510533', 'ACT 102 - B', 'janelle_abad@gmail.com', '09214417686', 'User', 'Los Angeles California City of Lights', 'Female'),
(4, 'Ervin Wesley', 'Muega', 'L', '201510932', 'ACT 101 - A', 'ervzxc_julie@gmail.com', '09081232134', 'User', 'Santol Pogi IV Cavite', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `user_login`
--

CREATE TABLE IF NOT EXISTS `user_login` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `user_login`
--

INSERT INTO `user_login` (`uid`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'nicole', 'joya'),
(3, 'janelle', 'abad'),
(4, 'ervin', 'wesley');

-- --------------------------------------------------------

--
-- Table structure for table `user_section`
--

CREATE TABLE IF NOT EXISTS `user_section` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `course` varchar(255) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=97 ;

--
-- Dumping data for table `user_section`
--

INSERT INTO `user_section` (`uid`, `course`) VALUES
(1, 'ACT 101 - A'),
(2, 'ACT 102 - A'),
(3, 'ACT 201 - A'),
(4, 'ACT 202 - A'),
(5, 'ACT 101 - B'),
(6, 'ACT 102 - B'),
(7, 'ACT 201 - B'),
(8, 'ACT 202 - B'),
(9, 'ACT 101 - C'),
(10, 'ACT 102 - C'),
(11, 'ACT 201 - C'),
(12, 'ACT 202 - C'),
(13, 'ACT 101 - D'),
(14, 'ACT 102 - D'),
(15, 'ACT 201 - D'),
(16, 'ACT 202 - D'),
(17, 'BS InfoTech 101 - A'),
(18, 'BS InfoTech 102 - A'),
(19, 'BS InfoTech 201 - A'),
(20, 'BS InfoTech 202 - A'),
(21, 'BS InfoTech 301 - A'),
(22, 'BS InfoTech 302 - A'),
(23, 'BS InfoTech 401 - A'),
(24, 'BS InfoTech 402 - A'),
(25, 'BS InfoTech 101 - B'),
(26, 'BS InfoTech 102 - B'),
(27, 'BS InfoTech 201 - B'),
(28, 'BS InfoTech 202 - B'),
(29, 'BS InfoTech 301 - B'),
(30, 'BS InfoTech 302 - B'),
(31, 'BS InfoTech 401 - B'),
(32, 'BS InfoTech 402 - B'),
(33, 'BS InfoTech 101 - C'),
(34, 'BS InfoTech 102 - C'),
(35, 'BS InfoTech 201 - C'),
(36, 'BS InfoTech 202 - C'),
(37, 'BS InfoTech 301 - C'),
(38, 'BS InfoTech 302 - C'),
(39, 'BS InfoTech 401 - C'),
(40, 'BS InfoTech 402 - C'),
(41, 'BS InfoTech 101 - D'),
(42, 'BS InfoTech 102 - D'),
(43, 'BS InfoTech 201 - D'),
(44, 'BS InfoTech 202 - D'),
(45, 'BS InfoTech 301 - D'),
(46, 'BS InfoTech 302 - D'),
(47, 'BS InfoTech 401 - D'),
(48, 'BS InfoTech 402 - D'),
(49, 'BS Computer Engineer 101 - A'),
(50, 'BS Computer Engineer 102 - A'),
(51, 'BS Computer Engineer 201 - A'),
(52, 'BS Computer Engineer 202 - A'),
(53, 'BS Computer Engineer 301 - A'),
(54, 'BS Computer Engineer 302 - A'),
(55, 'BS Computer Engineer 401 - A'),
(56, 'BS Computer Engineer 402 - A'),
(57, 'BS Computer Engineer 101 - B'),
(58, 'BS Computer Engineer 102 - B'),
(59, 'BS Computer Engineer 201 - B'),
(60, 'BS Computer Engineer 202 - B'),
(61, 'BS Computer Engineer 301 - B'),
(62, 'BS Computer Engineer 302 - B'),
(63, 'BS Computer Engineer 401 - B'),
(64, 'BS Computer Engineer 402 - B'),
(65, 'BSE 101 - A'),
(66, 'BSE 102 - A'),
(67, 'BSE 201 - A'),
(68, 'BSE 202 - A'),
(69, 'BSE 301 - A'),
(70, 'BSE 302 - A'),
(71, 'BSE 401 - A'),
(72, 'BSE 402 - A'),
(73, 'BSE 101 - B'),
(74, 'BSE 102 - B'),
(75, 'BSE 201 - B'),
(76, 'BSE 202 - B'),
(77, 'BSE 301 - B'),
(78, 'BSE 302 - B'),
(79, 'BSE 401 - B'),
(80, 'BSE 402 - B'),
(81, 'BSE 101 - C'),
(82, 'BSE 102 - C'),
(83, 'BSE 201 - C'),
(84, 'BSE 202 - C'),
(85, 'BSE 301 - C'),
(86, 'BSE 302 - C'),
(87, 'BSE 401 - C'),
(88, 'BSE 402 - C'),
(89, 'BSE 101 - D'),
(90, 'BSE 102 - D'),
(91, 'BSE 201 - D'),
(92, 'BSE 202 - D'),
(93, 'BSE 301 - D'),
(94, 'BSE 302 - D'),
(95, 'BSE 401 - D'),
(96, 'BSE 402 - D');
