-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2024 at 07:17 PM
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
-- Database: `dbwisata`
--

-- --------------------------------------------------------

--
-- Table structure for table `detailpaket`
--

CREATE TABLE `detailpaket` (
  `id` int(11) NOT NULL,
  `id_paket` int(11) NOT NULL,
  `id_wahana` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `detailpaket`
--

INSERT INTO `detailpaket` (`id`, `id_paket`, `id_wahana`) VALUES
(1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `paket`
--

CREATE TABLE `paket` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `durasi` int(11) NOT NULL,
  `harga` double NOT NULL,
  `deskripsi` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `paket`
--

INSERT INTO `paket` (`id`, `nama`, `durasi`, `harga`, `deskripsi`) VALUES
(1, 'A', 20, 1000000, 'mndja');

-- --------------------------------------------------------

--
-- Table structure for table `tiket`
--

CREATE TABLE `tiket` (
  `id_pesanan` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `nomorhp` varchar(15) NOT NULL,
  `jumlah_tiket` varchar(255) NOT NULL,
  `kategori_tiket` varchar(255) NOT NULL,
  `tanggal` varchar(255) NOT NULL,
  `metode_pembayaran` varchar(255) NOT NULL,
  `tanggal_lahir` varchar(255) NOT NULL,
  `daerah_asal` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(20) NOT NULL,
  `tanggal_beli` varchar(255) NOT NULL,
  `total` double NOT NULL,
  `id_paket` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tiket`
--

INSERT INTO `tiket` (`id_pesanan`, `nama`, `email`, `nomorhp`, `jumlah_tiket`, `kategori_tiket`, `tanggal`, `metode_pembayaran`, `tanggal_lahir`, `daerah_asal`, `jenis_kelamin`, `tanggal_beli`, `total`, `id_paket`) VALUES
(1, 'Kelompok Satu', 'kelompok1@gmail.com', '081234567890', '4', 'A', '31 May 2024', 'QRIS', '2024-05-18 00:00:00 ', 'Samarinda', 'Perempuan', '2024/05/18 01:05:15', 4000000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `wahana`
--

CREATE TABLE `wahana` (
  `id` int(11) NOT NULL,
  `nama` text NOT NULL,
  `kapasitas` int(11) NOT NULL,
  `waktu` text NOT NULL,
  `kategori` text NOT NULL,
  `deskripsi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `wahana`
--

INSERT INTO `wahana` (`id`, `nama`, `kapasitas`, `waktu`, `kategori`, `deskripsi`) VALUES
(1, 'Halilintar', 20, '10', 'Dewasa', 'menyeramkan'),
(2, 'Kora-kora', 10, '5', 'Anak-anak', 'asyik');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `detailpaket`
--
ALTER TABLE `detailpaket`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `paket`
--
ALTER TABLE `paket`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tiket`
--
ALTER TABLE `tiket`
  ADD PRIMARY KEY (`id_pesanan`);

--
-- Indexes for table `wahana`
--
ALTER TABLE `wahana`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `detailpaket`
--
ALTER TABLE `detailpaket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `paket`
--
ALTER TABLE `paket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tiket`
--
ALTER TABLE `tiket`
  MODIFY `id_pesanan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `wahana`
--
ALTER TABLE `wahana`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
