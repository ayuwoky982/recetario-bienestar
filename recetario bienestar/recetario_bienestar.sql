-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 13, 2025 at 03:48 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `recetario_bienestar`
--

-- --------------------------------------------------------

--
-- Table structure for table `favoritos`
--

CREATE TABLE `favoritos` (
  `id_favorito` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_receta` int(11) NOT NULL,
  `tipo_comida` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `favoritos`
--

INSERT INTO `favoritos` (`id_favorito`, `id_usuario`, `id_receta`, `tipo_comida`) VALUES
(70, 2, 1, 'desayuno'),
(56, 2, 7, 'comida'),
(59, 2, 11, 'cena'),
(68, 2, 13, 'cena'),
(58, 2, 15, 'cena');

-- --------------------------------------------------------

--
-- Table structure for table `imc`
--

CREATE TABLE `imc` (
  `usuario` text NOT NULL,
  `IMC` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `recetas`
--

CREATE TABLE `recetas` (
  `num` int(11) NOT NULL,
  `desayuno` mediumtext NOT NULL,
  `comida` mediumtext NOT NULL,
  `cena` mediumtext NOT NULL,
  `carbohidratos` int(11) NOT NULL,
  `proteinas` int(11) NOT NULL,
  `calorias` int(11) NOT NULL,
  `azucares` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `recetas`
--

INSERT INTO `recetas` (`num`, `desayuno`, `comida`, `cena`, `carbohidratos`, `proteinas`, `calorias`, `azucares`) VALUES
(1, 'Avena con frutas\r\nIngredientes: avena, leche o agua, plátano o manzana, miel o canela.\r\nPreparación: cocina la avena y agrega la fruta y miel.\r\n Consejo: añade semillas o yogur para más proteína y energía duradera.\r\n', '', '', 0, 0, 0, 0),
(2, 'Huevos revueltos con espinaca\r\nIngredientes: 2 huevos, espinaca, cebolla, aceite y sal.\r\nPreparación: sofríe la espinaca y mezcla con los huevos batidos.\r\nConsejo: acompaña con pan integral o una tortilla para balancear carbohidratos y proteína.\r\n', '', '', 0, 0, 0, 0),
(3, 'Sándwich integral de pollo o jamón\r\nIngredientes: pan integral, jamón o pollo, lechuga, tomate y aguacate.\r\nPreparación: arma el sándwich con los ingredientes frescos.\r\n Consejo: evita mayonesa; usa aguacate o mostaza para hacerlo más saludable\r\n', '', '', 0, 0, 0, 0),
(4, 'Ingredientes: plátano, avena, leche y miel.\r\nPreparación: licúa todo hasta obtener una mezcla cremosa.\r\nConsejo: perfecto si no tienes tiempo; puedes agregar proteína o cacahuate.\r\n', '', '', 0, 0, 0, 0),
(5, 'Tostadas de aguacate y huevo\r\nIngredientes: pan o tostadas integrales, aguacate, huevo cocido o frito.\r\nPreparación: aplasta el aguacate, colócalo sobre el pan y añade el huevo.\r\nConsejo: agrega unas gotas de limón y semillas para mejorar el sabor y la nutrición.\r\n', '', '', 0, 0, 0, 0),
(6, '', 'Pollo a la plancha con arroz y verduras\r\nIngredientes: pechuga de pollo, arroz cocido, brócoli o zanahoria.\r\nPreparación: cocina el pollo y acompaña con arroz y verduras al vapor.\r\nConsejo: usa aceite de oliva y evita freír para reducir grasa.\r\n', '', 0, 0, 0, 0),
(7, '', 'Tacos de frijoles y aguacate\r\nIngredientes: tortillas de maíz, frijoles, aguacate, jitomate, lechuga.\r\nPreparación: rellena las tortillas y calienta al comal.\r\nConsejo: excelente opción vegetariana y económica.\r\n', '', 0, 0, 0, 0),
(8, '', 'Pasta integral con verduras\r\nIngredientes: pasta integral, zanahoria, calabaza, brócoli, aceite y queso.\r\nPreparación: cocina la pasta y mezcla con verduras salteadas.\r\nConsejo: usa salsa natural de tomate, no industrial.\r\n', '', 0, 0, 0, 0),
(9, '', 'Ensalada de atún\r\nIngredientes: atún, lechuga, tomate, pepino, maíz, limón.\r\nPreparación: mezcla todos los ingredientes y añade jugo de limón.\r\nConsejo: agrega huevo cocido o garbanzos para más proteína.\r\n', '', 0, 0, 0, 0),
(10, '', 'Guisado de lentejas\r\nIngredientes: lentejas, cebolla, ajo, jitomate, zanahoria.\r\nPreparación: cuece las lentejas y guisa con verduras.\r\nConsejo: ideal para comer sin carne y obtener hierro y fibra.\r\n', '', 0, 0, 0, 0),
(11, '', '', 'Plátano con mantequilla de maní\r\nPreparación: corta el plátano y úntalo con un poco de mantequilla de maní.\r\nConsejo: excelente para recuperar energía después de clases o ejercicio\r\n', 0, 0, 0, 0),
(12, '', '', 'Yogur con avena y fruta\r\nPreparación: mezcla yogur natural, avena y trozos de fruta. \r\nConsejo: elige yogur sin azúcar y endulza con miel o canela.\r\n', 0, 0, 0, 0),
(13, '', '', 'Manzana con cacahuates o nueces\r\nPreparación: corta la manzana y acompaña con un puñado de frutos secos.\r\nConsejo: fuente de fibra y grasa saludable, ayuda a calmar el hambre.\r\n', 0, 0, 0, 0),
(14, '', '', 'Galletas integrales con queso panela\r\nPreparación: combina 2–3 galletas integrales con rebanadas de queso.\r\nConsejo: colación balanceada con carbohidratos y proteína ligera.\r\n', 0, 0, 0, 0),
(15, '', '', 'Batido de yogur y fresas\r\nPreparación: licúa yogur, fresas y un poco de leche.\r\nConsejo: refrescante y nutritivo, ideal a media tarde.\r\n', 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `recycon2`
--

CREATE TABLE `recycon2` (
  `num` int(100) NOT NULL,
  `consejos` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `recycon2`
--

INSERT INTO `recycon2` (`num`, `consejos`) VALUES
(1, 'Mantén una alimentación equilibrada: controla el consumo de azúcares y carbohidratos simples, y prioriza frutas, verduras, proteínas magras y granos integrales. Comer en horarios regulares ayuda a estabilizar los niveles de glucosa.'),
(2, 'Evita los jugos industrializados o muy azucarados.\r\n→ Mejor toma agua, té o jugo natural sin azúcar\r\n'),
(3, 'No desayunes pan dulce ni pastelitos todos los días.\r\n→ Cámbialos por pan integral, avena o frutas.\r\n'),
(4, 'No tomes café con mucha azúcar o crema.\r\n→ Usa poca azúcar o sustitúyela por canela o miel natural.\r\n'),
(5, 'Incluye siempre proteína (huevo, yogur, leche o avena).\r\n→ Te mantiene lleno más tiempo y mejora la concentración\r\n\r\n'),
(6, 'No te saltes el desayuno.\r\n→ Si no tienes tiempo, toma un licuado con fruta y avena.\r\n'),
(7, 'Evita frituras y comidas muy grasosas (hamburguesas, papas fritas, empanizados).\r\n→ Prefiere asado, al vapor o al horno'),
(8, 'Reduce la sal.\r\n→ Usa limón, ajo o hierbas para dar sabor sin abusar de la sal\r\n'),
(9, 'No acompañes la comida con refrescos.\r\n→ Mejor agua natural o agua con limón sin azúcar.\r\n\r\n'),
(10, 'Come más verduras que arroz o pasta.\r\n→ Llena la mitad del plato con verduras para más fibra y menos calorías.\r\n\r\n'),
(11, 'Equilibra tu plato:\r\no	½ verduras\r\no	¼ proteína (pollo, pescado, huevo, legumbres)\r\no	¼ carbohidratos (arroz, papa, tortilla)\r\n\r\n'),
(12, 'Evita dulces, panecillos o galletas con chocolate.\r\n→ Mejor frutas frescas, frutos secos o yogur natural\r\n'),
(13, 'No tomes bebidas con azúcar escondida (jugos, té embotellado, bebidas “light”).\r\n→ Revisa las etiquetas o prepara tus bebidas tú mismo\r\n\r\n'),
(14, 'Si comes botanas, elige versiones naturales.\r\n→ Palomitas sin mantequilla, pepino con limón o zanahoria rallada.\r\n'),
(15, 'Elige snacks que combinen fruta con proteína.\r\n→ Ejemplo: manzana con cacahuate, plátano con yogur\r\n'),
(16, 'No comas por aburrimiento.\r\n→ Toma agua primero; muchas veces no es hambre, sino sed.\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(40) NOT NULL,
  `contraseña` varchar(20) NOT NULL,
  `historial` varchar(10000) NOT NULL,
  `peso` varchar(10) NOT NULL,
  `edad` int(50) NOT NULL,
  `diabetes` varchar(50) NOT NULL,
  `tipodiabetes` varchar(40) NOT NULL,
  `ID` int(11) NOT NULL,
  `altura` int(16) NOT NULL,
  `sexo` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `contraseña`, `historial`, `peso`, `edad`, `diabetes`, `tipodiabetes`, `ID`, `altura`, `sexo`) VALUES
('b', '1', '', '66', 23, 'SI', 'tipo 1', 1, 0, ''),
('vegetta', '777', '', '100', 18, 'NO', '', 2, 0, ''),
('Juan', 'juanito1234', '', '91', 21, 'NO', '', 3, 0, ''),
('carlos', '54321', '', '77', 42, 'NO', '', 4, 0, '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `favoritos`
--
ALTER TABLE `favoritos`
  ADD PRIMARY KEY (`id_favorito`),
  ADD UNIQUE KEY `id_usuario` (`id_usuario`,`id_receta`,`tipo_comida`),
  ADD KEY `id_receta` (`id_receta`);

--
-- Indexes for table `imc`
--
ALTER TABLE `imc`
  ADD UNIQUE KEY `usuario` (`usuario`) USING HASH;

--
-- Indexes for table `recetas`
--
ALTER TABLE `recetas`
  ADD PRIMARY KEY (`num`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `favoritos`
--
ALTER TABLE `favoritos`
  MODIFY `id_favorito` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `recetas`
--
ALTER TABLE `recetas`
  MODIFY `num` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `favoritos`
--
ALTER TABLE `favoritos`
  ADD CONSTRAINT `favoritos_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`ID`) ON DELETE CASCADE,
  ADD CONSTRAINT `favoritos_ibfk_2` FOREIGN KEY (`id_receta`) REFERENCES `recetas` (`num`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
