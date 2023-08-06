-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 06, 2023 at 01:46 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `onlineshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `Id` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Subtotal` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`Id`, `UserID`, `ItemID`, `Quantity`, `Subtotal`) VALUES
(20, 4, 1, 1, '9500.00');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`Id`, `Name`) VALUES
(5, 'Clothing'),
(3, 'Cosmetics'),
(9, 'Drinks'),
(2, 'Electronics'),
(1, 'Furnitures'),
(6, 'Kitchen Equipments'),
(7, 'Shoes'),
(8, 'Skin Care'),
(10, 'Snacks'),
(4, 'Sports Equipment');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `Id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `SellingPrice` decimal(9,2) NOT NULL,
  `Size` varchar(255) DEFAULT NULL,
  `Color` varchar(255) DEFAULT NULL,
  `Visible` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`Id`, `Name`, `CategoryId`, `SellingPrice`, `Size`, `Color`, `Visible`) VALUES
(1, 'Sofa Set', 1, '9500.00', '35x36x80 in', 'Gray', 'Yes'),
(2, 'Cabinet', 1, '2200.00', '12x30x36 in', 'Black', 'Yes'),
(3, 'LED TV', 2, '5900.00', '24 in', 'Silver', 'Yes'),
(4, 'Laptop Keyboard', 2, '250.00', '430x123x38 mm', 'Black', 'No'),
(5, 'Lip Tint', 3, '180.00', '12 ml', 'Red', 'Yes'),
(6, 'Eyebrow Soap', 3, '100.00', '15 g', 'Black', 'Yes'),
(7, 'Skipping Mat', 4, '390.00', '1270x630x8 mm', 'Gray', 'No'),
(8, 'Basketball', 4, '100.00', '27.5 in', 'Dark Orange', 'Yes'),
(9, 'Cargo Shorts', 5, '90.00', 'Waist: 37 in', 'Navy Blue', 'Yes'),
(10, 'Square Pants', 5, '130.00', 'Waist: 26-36 in', 'Beige', 'Yes'),
(11, 'Bed Table', 1, '760.00', '40x30 in', 'Blue', 'Yes'),
(12, 'Kojic Soap', 8, '100.00', '150 grams', 'Orange', 'Yes'),
(13, 'Royal', 9, '70.00', '1.5 L', 'Orange', 'Yes'),
(15, 'Coffee Table', 1, '2200.00', '12x30x36 in', 'Black', 'Yes');

-- --------------------------------------------------------

--
-- Table structure for table `orderline`
--

CREATE TABLE `orderline` (
  `Id` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Subtotal` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderline`
--

INSERT INTO `orderline` (`Id`, `OrderID`, `ItemID`, `Quantity`, `Subtotal`) VALUES
(1, 1, 1, 1, '9500.00'),
(2, 1, 2, 2, '4400.00'),
(3, 1, 3, 1, '5900.00'),
(4, 2, 5, 3, '540.00'),
(5, 3, 10, 5, '650.00'),
(6, 3, 9, 5, '450.00'),
(7, 3, 7, 3, '1170.00'),
(8, 3, 8, 3, '300.00'),
(9, 4, 4, 1, '250.00'),
(10, 4, 8, 1, '100.00'),
(11, 5, 6, 6, '600.00'),
(12, 6, 4, 1, '250.00'),
(23, 9, 1, 1, '9500.00'),
(24, 9, 2, 1, '2200.00'),
(25, 9, 3, 1, '5900.00'),
(26, 9, 5, 1, '180.00'),
(27, 9, 6, 1, '100.00'),
(28, 10, 1, 1, '9500.00'),
(29, 11, 9, 3, '270.00'),
(30, 11, 10, 3, '390.00');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `Id` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `GrandTotal` decimal(9,2) NOT NULL,
  `PaymentOption` varchar(255) NOT NULL,
  `CheckoutDate` date NOT NULL,
  `Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`Id`, `UserID`, `GrandTotal`, `PaymentOption`, `CheckoutDate`, `Status`) VALUES
(1, 5, '19800.00', 'COD', '2021-10-01', 'Placed'),
(2, 4, '540.00', 'COD', '2021-10-01', 'Packed'),
(3, 4, '2570.00', 'COD', '2021-10-05', 'Shipped'),
(4, 4, '350.00', 'GCash', '2021-10-09', 'Shipped'),
(5, 4, '600.00', 'GCash', '2021-10-15', 'Delivered'),
(6, 4, '250.00', 'COD', '2021-10-17', 'Delivered'),
(9, 4, '17880.00', 'COD', '2023-08-02', 'Placed'),
(10, 4, '9500.00', 'GCash', '2023-08-02', 'Placed'),
(11, 5, '660.00', 'COD', '2023-08-06', 'Packed');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `ContactNumber` varchar(20) NOT NULL,
  `Barangay` varchar(255) NOT NULL,
  `Municipality` varchar(255) NOT NULL,
  `Province` varchar(255) NOT NULL,
  `Type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `Email`, `Password`, `FirstName`, `LastName`, `ContactNumber`, `Barangay`, `Municipality`, `Province`, `Type`) VALUES
(1, 'admin@gmail.com', 'admin123', 'Nica Mae', 'Zurbano', '09987654321', 'Sta. Maria Village', 'Calapan City', 'Oriental Mindoro', 'Owner'),
(4, 'juan@gmail.com', 'juan123', 'Juan', 'Dela Cruz', '0998654321', 'Camilmil', 'Calapan City', 'Oriental Mindoro', 'Customer'),
(5, 'maria@gmail.com', 'maria123', 'Maria', 'Clara', '099864322', 'Liwayway', 'San Pedro', 'Laguna', 'Customer');

-- --------------------------------------------------------

--
-- Table structure for table `wishlist`
--

CREATE TABLE `wishlist` (
  `Id` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `wishlist`
--

INSERT INTO `wishlist` (`Id`, `UserID`, `ItemID`) VALUES
(1, 4, 3),
(5, 4, 2),
(13, 4, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Name` (`Name`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Name` (`Name`),
  ADD KEY `CategoryId` (`CategoryId`);

--
-- Indexes for table `orderline`
--
ALTER TABLE `orderline`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `OrderID` (`OrderID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `UserID` (`UserID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `wishlist`
--
ALTER TABLE `wishlist`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `ItemID` (`ItemID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `orderline`
--
ALTER TABLE `orderline`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `wishlist`
--
ALTER TABLE `wishlist`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`ID`),
  ADD CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`Id`);

--
-- Constraints for table `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `item_ibfk_1` FOREIGN KEY (`CategoryId`) REFERENCES `category` (`Id`);

--
-- Constraints for table `orderline`
--
ALTER TABLE `orderline`
  ADD CONSTRAINT `orderline_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`Id`),
  ADD CONSTRAINT `orderline_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`Id`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`ID`);

--
-- Constraints for table `wishlist`
--
ALTER TABLE `wishlist`
  ADD CONSTRAINT `wishlist_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `user` (`ID`),
  ADD CONSTRAINT `wishlist_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
