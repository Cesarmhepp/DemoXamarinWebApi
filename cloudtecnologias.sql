-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-02-2021 a las 23:48:34
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cloudtecnologias`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `testuser`
--

CREATE TABLE `testuser` (
  `CUSTOMER_ID` int(64) NOT NULL,
  `NAME` varchar(64) NOT NULL,
  `EMAIL` varchar(64) NOT NULL,
  `PASS` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `testuser`
--

INSERT INTO `testuser` (`CUSTOMER_ID`, `NAME`, `EMAIL`, `PASS`) VALUES
(26, 'Amelia Watson', 'Amelia@amelia.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5'),
(29, 'cesar', 'cesarmhepp@gmail.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5'),
(31, 'Marco Muñoz', 'marcomhepp@gmail.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5'),
(32, 'Katy Hepp', 'katy@gmail.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5'),
(33, 'Felipe Abello', 'felipe@gmail.com', 'd9ee9477471c864ade2fb79ebf429bdfbeedfde1afcc74ec01044109907385a4'),
(34, 'jose', 'jose@gmail.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5'),
(35, 'ale', 'ale@gmail.com', 'd9ee9477471c864ade2fb79ebf429bdfbeedfde1afcc74ec01044109907385a4'),
(36, 'pato', 'pato@gmail.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5'),
(37, 'pato', 'pato1@gmail.com', '5e633a6d5746e05265c5a3dbc4e89d7de8f91ad422ebe44093d6ec4a48ac82e5');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `testuser`
--
ALTER TABLE `testuser`
  ADD PRIMARY KEY (`CUSTOMER_ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `testuser`
--
ALTER TABLE `testuser`
  MODIFY `CUSTOMER_ID` int(64) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
