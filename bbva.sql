-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 08-06-2024 a las 03:21:43
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bbva`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clave`
--

CREATE TABLE `clave` (
  `id` int(11) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentas`
--

CREATE TABLE `cuentas` (
  `dni` int(11) NOT NULL,
  `estadob` int(11) NOT NULL,
  `PIN` varchar(60) NOT NULL,
  `numero_cuenta` bigint(15) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cuentas`
--

INSERT INTO `cuentas` (`dni`, `estadob`, `PIN`, `numero_cuenta`, `id_user`) VALUES
(74658429, 5000, 'bs0A/15ZFHY=', 78945612378, 4),
(75079362, 9000, 'UbrYpkCfDhg=', 65432198732, 5),
(76547557, 2000, 'anvynCGrIII=', 98765432198, 2),
(77321617, 3000, 'YFiebsY6JDY=', 45678912345, 3),
(78426954, 10500, 'kVuurNL3yUE=', 12345678912, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `datos_personales`
--

CREATE TABLE `datos_personales` (
  `dni` int(11) NOT NULL,
  `p_nombre` varchar(20) NOT NULL,
  `s_nombre` varchar(20) NOT NULL,
  `a_patt` varchar(20) NOT NULL,
  `a_matt` varchar(20) NOT NULL,
  `numero_telf` int(11) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `datos_personales`
--

INSERT INTO `datos_personales` (`dni`, `p_nombre`, `s_nombre`, `a_patt`, `a_matt`, `numero_telf`, `id_user`) VALUES
(76023173, 'Augusto', 'Martin', 'Calle', 'Montana', 902409258, 1),
(76547207, 'Julio', 'Ayrton', 'Quispe', 'Lopez', 970742004, 2),
(77080617, 'Daniel', 'Dino', 'Lozano', 'Silva', 926899715, 3),
(74656842, 'Denis', 'Rogelio', 'Pizarro', 'Valles', 930419553, 4),
(75084362, 'Ernesto', 'Efrain', 'Poma', 'Coronel', 932322885, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial_operaciones`
--

CREATE TABLE `historial_operaciones` (
  `id_operacion` int(11) NOT NULL,
  `dni` int(11) NOT NULL,
  `operacion` varchar(20) NOT NULL,
  `monto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clave`
--
ALTER TABLE `clave`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cuentas`
--
ALTER TABLE `cuentas`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `datos_personales`
--
ALTER TABLE `datos_personales`
  ADD PRIMARY KEY (`id_user`);

--
-- Indices de la tabla `historial_operaciones`
--
ALTER TABLE `historial_operaciones`
  ADD PRIMARY KEY (`id_operacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clave`
--
ALTER TABLE `clave`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `cuentas`
--
ALTER TABLE `cuentas`
  MODIFY `dni` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123456790;

--
-- AUTO_INCREMENT de la tabla `datos_personales`
--
ALTER TABLE `datos_personales`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `historial_operaciones`
--
ALTER TABLE `historial_operaciones`
  MODIFY `id_operacion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
