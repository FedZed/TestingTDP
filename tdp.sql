-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 03-08-2023 a las 13:30:18
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tdp`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `distribuidor`
--

DROP TABLE IF EXISTS `distribuidor`;
CREATE TABLE IF NOT EXISTS `distribuidor` (
  `Nombre` text NOT NULL,
  `Rut` int NOT NULL,
  `Telefono` text NOT NULL,
  `Direccion` text NOT NULL,
  PRIMARY KEY (`Rut`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `distribuidor`
--

INSERT INTO `distribuidor` (`Nombre`, `Rut`, `Telefono`, `Direccion`) VALUES
('[Jorge]', 1, '[325623]', '[lasopf]'),
('ocho', 2, '5532523', 'Valca2412');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

DROP TABLE IF EXISTS `factura`;
CREATE TABLE IF NOT EXISTS `factura` (
  `Fecha` date NOT NULL,
  `idP` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia_prima`
--

DROP TABLE IF EXISTS `materia_prima`;
CREATE TABLE IF NOT EXISTS `materia_prima` (
  `Nombre` text NOT NULL,
  `IdM` int NOT NULL AUTO_INCREMENT,
  `tipo` text NOT NULL,
  `idD` int DEFAULT NULL,
  `Cantidad` int DEFAULT NULL,
  PRIMARY KEY (`IdM`),
  KEY `idD` (`idD`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `materia_prima`
--

INSERT INTO `materia_prima` (`Nombre`, `IdM`, `tipo`, `idD`, `Cantidad`) VALUES
('Harina', 1, 'gOku', 1, 342),
('sd', 2, 'Levadura', 1, 2444),
('fsa', 3, 'Azucar', 2, 123),
('1', 5, 'Azucar', 1, 23);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `Nombre` text NOT NULL,
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `tipo` text NOT NULL,
  `precio2` int NOT NULL,
  `Precio` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cantidad` int NOT NULL,
  `id_Distribuidores` int DEFAULT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `id_Distribuidores` (`id_Distribuidores`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`Nombre`, `id_producto`, `tipo`, `precio2`, `Precio`, `cantidad`, `id_Distribuidores`) VALUES
('azul', 1, 'comida', 244, '$244', 300, 1),
('ds', 2, 'boutique', 333, '$333', 423, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `Nombre` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Contraseña` text NOT NULL,
  `Cedula` varchar(8) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Cargo` text NOT NULL,
  PRIMARY KEY (`Cedula`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`Nombre`, `Contraseña`, `Cedula`, `Cargo`) VALUES
('Admin', '1234', '1', 'Administrador'),
('jorge', 'poro23', '53513785', 'Panadero'),
('Chuga', '5535', '535311', 'Caja'),
('Nombre', '5f1ffe8cbb63c2fd6de7402875afaeabd2e4935a', '5325235', 'Panadero'),
('jorgenitales', '02c5b105b828b6ec9d25903aeb4cf0c95b41490c', '53252352', 'Panadero');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
