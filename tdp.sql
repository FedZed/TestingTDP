-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generaciÃ³n: 19-11-2023 a las 20:32:33
-- VersiÃ³n del servidor: 8.0.31
-- VersiÃ³n de PHP: 8.0.26

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
  `visible` int NOT NULL,
  PRIMARY KEY (`Rut`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `distribuidor`
--

INSERT INTO `distribuidor` (`Nombre`, `Rut`, `Telefono`, `Direccion`, `visible`) VALUES
('Jorge   Rodriguez', 1, '092341871', 'Beltran 532', 1),
('Mario CastaÃ±eda', 2, '098834637', 'Julio delgado 230', 1),
('Raul Martinez', 3, '098834617', 'Belen 230', 1),
('Laura Bentancour', 4, '098834617', 'Michelini 250', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

DROP TABLE IF EXISTS `factura`;
CREATE TABLE IF NOT EXISTS `factura` (
  `Cantidad` int NOT NULL,
  `Nombre_Producto` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Precio` int NOT NULL,
  `Precio_Total` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IdF` int NOT NULL,
  `Factura` text NOT NULL,
  `Fecha` date NOT NULL,
  `visible` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`Cantidad`, `Nombre_Producto`, `Precio`, `Precio_Total`, `IdF`, `Factura`, `Fecha`, `visible`) VALUES
(1, 's', 2, '3', 0, '', '0000-00-00', 1);

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
  `visible` int NOT NULL,
  PRIMARY KEY (`IdM`),
  KEY `idD` (`idD`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `materia_prima`
--

INSERT INTO `materia_prima` (`Nombre`, `IdM`, `tipo`, `idD`, `Cantidad`, `visible`) VALUES
('LaBert', 1, 'Grasa', 1, 32, 0),
('Royal King ', 2, 'Levadura', 1, 2444, 0),
('Florentina', 3, 'Florentina', 2, 100, 1),
('Lafa 2kg', 4, 'Azucar', 1, 23, 1),
('La Granja', 5, 'Dulce de Batata', 1, 230, 0),
('Tuku Tuku', 6, 'Dulce de leche', 1, 580, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `Nombre` text NOT NULL,
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `tipo` text NOT NULL,
  `Precio` int NOT NULL,
  `cantidad` int NOT NULL,
  `id_Distribuidores` int DEFAULT NULL,
  `Integrado` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_producto`),
  KEY `id_Distribuidores` (`id_Distribuidores`)
) ENGINE=MyISAM AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`Nombre`, `id_producto`, `tipo`, `Precio`, `cantidad`, `id_Distribuidores`, `Integrado`) VALUES
('Alfajor Chocolate Portezuelo', 27, 'Comestible', 30, 120, 2, 'I'),
('Coca cola light', 14, 'Bebible', 55, 40, 2, 'X'),
('Coca cola', 3, 'Bebible', 55, 32, 2, 'I'),
('Pepsi', 16, 'Comestible', 50, 41, 2, 'I'),
('Manteca 500gr', 26, 'Comestible', 120, 60, 1, 'I'),
('Rexona desodorante', 17, 'Otro', 150, 40, 2, 'I'),
('Limol', 18, 'Bebible', 60, 39, 2, 'I'),
('Pan de Ajo', 22, 'Panaderia', 150, 39, 1, 'I'),
('Media Luna', 23, 'Panaderia', 45, 19, 2, 'I'),
(' Alfajor Chocolate Blanco Portezuelo', 24, 'Comestible', 30, 43, 2, 'I'),
('Chicle', 25, 'Comestible', 3, 60, 2, 'I'),
('Caramelo', 28, 'Comestible', 2, 40, 2, 'I');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `Nombre` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ContraseÃ±a` text NOT NULL,
  `Email` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Cargo` text NOT NULL,
  `Visible` int NOT NULL,
  PRIMARY KEY (`Email`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`Nombre`, `ContraseÃ±a`, `Email`, `Cargo`, `Visible`) VALUES
('Admin', '0030AC0670420160F30E105C07601E0E10A50E20550F00670950360230C80B30880B404509E0130F90780D70C80460F4', 'harrypotato62@gmail.com', 'Administrador', 1),
('por', '0980F10F107F09A0730CC0FE03E02509400A0DD08D09C0E90BF0050510310040CA0CB0840F20F101805B0F508806A084', 'DiosDado234@gmail.com', 'Panadero', 0),
('g', '05909404701A0BB00101102A0FC0C10810590F60CC0740B40F50110B90980060DA0590B30CA0F50A90C10730CA0CF0C5', 'Devongoncalvez46@gmail.com', 'Administrador', 1),
('red', '06B0860B20730FF0340FC0E109D06B08004E0FF05A03F0570470AD0A40EA0A202F01D0490C001E0520DD0B708705B04B', 'Ed249lo@gmail.com', 'Caja', 1),
('redw', '05305F0A300D07E0250DD08A0490F105306707907304E0C80280610080D10150DA0500450D707F03B0410850D80F7090', 'JuanJose30i905@gmail.com', 'Caja', 0),
('Dream', '0030AC0670420160F30E105C07601E0E10A50E20550F00670950360230C80B30880B404509E0130F90780D70C80460F4', 'Fedecampeon2010@gmail.com', 'Caja', 1),
('Mariano', '08D09609E0EF06E0CA0D30C209A03A0620920800E60860CF00C03F05D05A0860AF0F30CA01200200C09203A0DC06C092', 'pieceoffailure@gmail.com', 'Caja', 1),
('Nahu', '0120D70A20F409F02B01909D0E00E10520CA0290B000C0C50480A40020C70B806F0000A405C0B80A20AF0B300A0760EF', 'nahuelemmenegger543@gmail.com', 'Caja', 1);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
