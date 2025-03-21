-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-03-2025 a las 18:57:09
-- Versión del servidor: 10.4.22-MariaDB
-- Versión de PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pokemon_db`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pokemons`
--

CREATE TABLE `pokemons` (
  `Id` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Type` varchar(100) DEFAULT NULL,
  `Height` decimal(5,2) DEFAULT NULL,
  `Weight` decimal(5,2) DEFAULT NULL,
  `Abilities` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pokemons`
--

INSERT INTO `pokemons` (`Id`, `Name`, `Type`, `Height`, `Weight`, `Abilities`) VALUES
(1, 'Pikachu', 'Electric', '0.40', '6.00', 'Static, Lightning Rod'),
(2, 'Bulbasaur', 'Grass, Poison', '0.70', '6.90', 'Overgrow, Chlorophyll'),
(3, 'Charmander', 'Fire', '0.60', '8.50', 'Blaze, Solar Power'),
(4, 'Squirtle', 'Water', '0.50', '9.00', 'Torrent, Rain Dish'),
(5, 'Jigglypuff', 'Normal, Fairy', '0.50', '5.50', 'Cute Charm, Competitive'),
(6, 'Meowth', 'Normal', '0.40', '4.20', 'Pickup, Technician'),
(7, 'Pidgey', 'Normal, Flying', '0.30', '1.80', 'Keen Eye, Tangled Feet'),
(8, 'Eevee', 'Normal', '0.30', '6.50', 'Run Away, Adaptability'),
(9, 'Mankey', 'Fighting', '0.50', '28.00', 'Vital Spirit, Anger Point'),
(10, 'Snorlax', 'Normal', '2.10', '460.00', 'Immunity, Thick Fat');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `pokemons`
--
ALTER TABLE `pokemons`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `pokemons`
--
ALTER TABLE `pokemons`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
