-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2016 at 07:46 AM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_peramalan_penjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_barang`
--

CREATE TABLE IF NOT EXISTS `tb_barang` (
  `id_barang` varchar(4) NOT NULL,
  `nama_barang` varchar(255) NOT NULL,
  `tipe` varchar(100) NOT NULL,
  `harga` double NOT NULL,
  PRIMARY KEY (`id_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_barang`
--

INSERT INTO `tb_barang` (`id_barang`, `nama_barang`, `tipe`, `harga`) VALUES
('B001', 'BUKU TULIS SIDU 58', 'BUKU', 2300),
('B002', 'BUKU TULIS SIDU 38', 'BUKU', 2000),
('B003', 'BUKU TULIS SIDU 32', 'BUKU', 2000),
('B004', 'BALPOIN PILOT BPT-P MERAH', 'BALPOIN', 1200),
('B005', 'BALPOIN SNOWMAN BP-7 BLUE', 'BALPOIN', 1500),
('B006', 'PENSIL 2B HANDY', 'PENSIL', 700),
('B007', 'PENSIL JOYKO HANDY', 'PENSIL', 1200),
('B008', 'BALPOIN PILOT HITAM', 'BALPOIN', 1300),
('B009', 'PENSIL LOVE FOREVER', 'PENSIL', 2000),
('B010', 'FOLIO ISI 50', 'BUKU', 2500),
('B011', 'BUKU SIDU 50', 'BUKU', 2000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_hasil`
--

CREATE TABLE IF NOT EXISTS `tb_hasil` (
  `id_hasil` int(11) NOT NULL AUTO_INCREMENT,
  `id_penjualan` int(11) NOT NULL,
  `id_barang` varchar(4) NOT NULL,
  `hasil` int(11) NOT NULL,
  `bulan` int(11) NOT NULL,
  `tahun` int(11) NOT NULL,
  `hsl_ramal` varchar(11) NOT NULL,
  `catatan` text NOT NULL,
  PRIMARY KEY (`id_hasil`),
  KEY `id_barang` (`id_barang`),
  KEY `id_penjualan` (`id_penjualan`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2103 ;

--
-- Dumping data for table `tb_hasil`
--

INSERT INTO `tb_hasil` (`id_hasil`, `id_penjualan`, `id_barang`, `hasil`, `bulan`, `tahun`, `hsl_ramal`, `catatan`) VALUES
(2034, 0, 'B002', 5, 2, 2012, '2.125', '-'),
(2035, 0, 'B002', 2, 3, 2012, '2.125', '-'),
(2036, 0, 'B002', 3, 4, 2012, '2.125', '-'),
(2037, 0, 'B002', 3, 5, 2012, '2.125', '-'),
(2038, 0, 'B002', 5, 6, 2012, '2.125', '-'),
(2039, 0, 'B002', 3, 7, 2012, '2.125', '-'),
(2040, 0, 'B002', 2, 9, 2012, '2.125', '-'),
(2041, 0, 'B002', 3, 10, 2012, '2.125', '-'),
(2042, 0, 'B002', 5, 11, 2012, '2.125', '-'),
(2043, 0, 'B002', 1, 12, 2012, '2.125', '-'),
(2056, 0, 'B003', 30, 1, 2010, '4.083333333', '-'),
(2057, 0, 'B004', 3, 2, 2012, '3.2', '-'),
(2058, 0, 'B004', 3, 3, 2012, '3.2', '-'),
(2059, 0, 'B004', 7, 4, 2012, '3.2', '-'),
(2060, 0, 'B004', 3, 5, 2012, '1.25', '-'),
(2061, 0, 'B004', 7, 6, 2012, '3.2', '-'),
(2062, 0, 'B004', 3, 7, 2012, '1.25', '-'),
(2063, 0, 'B004', 1, 8, 2012, '3.2', '-'),
(2064, 0, 'B004', 2, 9, 2012, '3.25', '-'),
(2065, 0, 'B004', 3, 10, 2012, '3.25', '-'),
(2066, 0, 'B004', 7, 11, 2012, '3.2', '-'),
(2067, 0, 'B004', 3, 12, 2012, '1.25', '-'),
(2096, 0, 'B001', 250, 2, 2010, '119.25', '-'),
(2097, 0, 'B001', 100, 3, 2010, '0', '-'),
(2098, 0, 'B001', 4, 12, 2010, '0', '-'),
(2101, 0, 'B008', 10, 2, 2010, '14', '-'),
(2102, 0, 'B008', 150, 3, 2010, '14', '-');

-- --------------------------------------------------------

--
-- Table structure for table `tb_hasil_cetak`
--

CREATE TABLE IF NOT EXISTS `tb_hasil_cetak` (
  `id_barang` varchar(4) DEFAULT NULL,
  `kategori` varchar(20) NOT NULL,
  `hasil` varchar(255) DEFAULT NULL,
  `bulan` varchar(255) DEFAULT NULL,
  `tahun` varchar(255) DEFAULT NULL,
  `catatan` text NOT NULL,
  KEY `id_barang` (`id_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_hasil_cetak`
--

INSERT INTO `tb_hasil_cetak` (`id_barang`, `kategori`, `hasil`, `bulan`, `tahun`, `catatan`) VALUES
('B004', 'TRAFO 1250 KVA', '', 'Memenuhi Target', '2014', 'memenuhi target penjualan untuk barang TRAFO 1250 KVA  '),
('B005', 'TRAFO 1000 KVA', '2,5 \r\n2,5 \r\n', '4 \r\n12 \r\n', '2013', 'Pada bulan : 4 12  tidak memenuhi target penjualan untuk barang TRAFO 1000 KVA maka dapat dijual barang : TRAFO 630 KVA, CUBICLE CM, TRAFO 2500 KVA, CUBICLE IM, LVMDP,  dll. '),
('B005', 'TRAFO 1000 KVA', '', 'Memenuhi Target', '2014', 'memenuhi target penjualan untuk barang TRAFO 1000 KVA  '),
('B005', 'TRAFO 1000 KVA', '2,5 \r\n2,5 \r\n', '9 \r\n12 \r\n', '2015', 'Pada bulan : 9 12  tidak memenuhi target penjualan untuk barang TRAFO 1000 KVA maka dapat dijual barang : TRAFO 400 KVA, TRAFO 2500 KVA, PANEL LV, CUBICLE IM, TRAFO 1000 KVA,  dll. '),
('B004', 'TRAFO 1250 KVA', '5 \r\n5,5 \r\n5 \r\n5 \r\n5,5 \r\n5 \r\n5,5 \r\n5,5 \r\n5,5 \r\n5,5 \r\n5 \r\n5 \r\n', '1 \r\n2 \r\n3 \r\n4 \r\n5 \r\n6 \r\n7 \r\n8 \r\n9 \r\n10 \r\n11 \r\n12 \r\n', '2016', 'memenuhi target penjualan untuk barang TRAFO 1250 KVA  '),
('B001', 'TRAFO 2500 KVA', '1,5 \r\n4 \r\n1,5 \r\n', '1 \r\n2 \r\n3 \r\n', '2017', 'memenuhi target penjualan untuk barang TRAFO 2500 KVA  '),
('B001', 'TRAFO 2500 KVA', '1,5 \r\n1,5 \r\n', '4 \r\n11 \r\n', '2013', 'Pada bulan : 4 11  tidak memenuhi target penjualan untuk barang TRAFO 2500 KVA maka dapat dijual barang : CUBICLE IM, TRAFO 630 KVA, contoh12, TRAFO 800 KVA, LVMDP,  dll. '),
('B001', 'TRAFO 2500 KVA', '2,5 \r\n1,5 \r\n2,5 \r\n2,5 \r\n2,5 \r\n', '3 \r\n5 \r\n10 \r\n11 \r\n12 \r\n', '2015', 'Pada bulan : 3 5 10 11 12  tidak memenuhi target penjualan untuk barang TRAFO 2500 KVA maka dapat dijual barang : TRAFO 400 KVA, TRAFO 630 KVA, CUBICLE CM, TRAFO 1600 KVA, TRAFO 1250 KVA,  dll. '),
('B001', 'TRAFO 2500 KVA', '2,5 \r\n2,5 \r\n1,5 \r\n1,5 \r\n2,5 \r\n', '1 \r\n2 \r\n5 \r\n7 \r\n12 \r\n', '2016', 'Pada bulan : 1 2 5 7 12  tidak memenuhi target penjualan untuk barang TRAFO 2500 KVA maka dapat dijual barang : PANEL LV, CUBICLE CM, BOX PANEL, TRAFO 800 KVA, TRAFO 1250 KVA,  dll. '),
('B002', 'TRAFO 2000 KVA', '2,5 \r\n2,5 \r\n', '4 \r\n7 \r\n', '2016', 'Pada bulan : 4 7  tidak memenuhi target penjualan untuk barang TRAFO 2000 KVA maka dapat dijual barang : PANEL LV, CUBICLE CM, TRAFO 1600 KVA, contoh12, TRAVO 100 KVA,  dll. '),
('B003', 'TRAFO 1600 KVA', '1,5 \r\n2,83333333333333 \r\n1,5 \r\n2,83333333333333 \r\n1,5 \r\n2,83333333333333 \r\n1,5 \r\n', '2 \r\n4 \r\n5 \r\n7 \r\n8 \r\n10 \r\n11 \r\n', '2016', 'Pada bulan : 2 4 5 7 8 10 11  tidak memenuhi target penjualan untuk barang TRAFO 1600 KVA maka dapat dijual barang : TRAVO 100 KVA, BOX PANEL, TRAFO 1600 KVA, PANEL AVR, TRAFO 2000 KVA,  dll. '),
('B005', 'TRAFO 1000 KVA', '5,5 \r\n6 \r\n6 \r\n6 \r\n6 \r\n5,5 \r\n2 \r\n5,5 \r\n6 \r\n5,5 \r\n6 \r\n2 \r\n', '1 \r\n2 \r\n3 \r\n4 \r\n5 \r\n6 \r\n7 \r\n8 \r\n9 \r\n10 \r\n11 \r\n12 \r\n', '2016', 'memenuhi target penjualan untuk barang TRAFO 1000 KVA  '),
('B001', 'TRAFO 2500 KVA', '2.5 \r\n', '11 \r\n', '2014', 'Pada bulan : 11  tidak memenuhi target penjualan untuk barang TRAFO 2500 KVA maka dapat dijual barang : CUBICLE PGC, TRAFO 800 KVA, CUBICLE CM, TRAFO 1250 KVA, BOX PANEL,  dll. '),
('B002', 'BUKU TULIS SIDU 38', '', 'Memenuhi Target', '2013', 'memenuhi target penjualan untuk barang BUKU TULIS SIDU 38  '),
('B003', 'BUKU TULIS SIDU 32', '0 \r\n', '7 \r\n', '2014', 'Pada bulan : 7  tidak memenuhi target penjualan untuk barang BUKU TULIS SIDU 32 maka dapat dijual barang : BALPOIN PILOT HITAM, BUKU TULIS SIDU 38, PENSIL 2B HANDY, PENSIL LOVE FOREVER, BALPOIN PILOT BPT-P MERAH,  dll. '),
('B003', 'BUKU TULIS SIDU 32', '4.08333333333333 \r\n', '1 \r\n', '2011', 'memenuhi target penjualan untuk barang BUKU TULIS SIDU 32  '),
('B004', 'BALPOIN PILOT BPT-P ', '', 'Memenuhi Target', '2013', 'memenuhi target penjualan untuk barang BALPOIN PILOT BPT-P MERAH  '),
('B010', 'FOLIO ISI 50', '', 'Memenuhi Target', '2011', 'memenuhi target penjualan untuk barang FOLIO ISI 50  '),
('B009', 'PENSIL LOVE FOREVER', '', 'Memenuhi Target', '2011', 'memenuhi target penjualan untuk barang PENSIL LOVE FOREVER  '),
('B001', 'BUKU TULIS SIDU 58', '0 \r\n0 \r\n', '3 \r\n12 \r\n', '2011', 'Pada bulan : 3 12  tidak memenuhi target penjualan untuk barang BUKU TULIS SIDU 58 maka dapat dijual barang : FOLIO ISI 50, BALPOIN SNOWMAN BP-7 BLUE, PENSIL 2B HANDY, BALPOIN PILOT BPT-P MERAH, BUKU TULIS SIDU 32,  dll. '),
('B008', 'BALPOIN PILOT HITAM', '14 \r\n14 \r\n', '2 \r\n3 \r\n', '2011', 'memenuhi target penjualan untuk barang BALPOIN PILOT HITAM  ');

-- --------------------------------------------------------

--
-- Table structure for table `tb_kategori`
--

CREATE TABLE IF NOT EXISTS `tb_kategori` (
  `kategori` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_kategori`
--

INSERT INTO `tb_kategori` (`kategori`) VALUES
('PENSIL'),
('BUKU'),
('BALPOIN');

-- --------------------------------------------------------

--
-- Table structure for table `tb_penjualan`
--

CREATE TABLE IF NOT EXISTS `tb_penjualan` (
  `id_penjualan` int(11) NOT NULL AUTO_INCREMENT,
  `id_barang` varchar(4) NOT NULL,
  `jml_satuan` int(11) NOT NULL,
  `tanggal` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `bulan` int(11) NOT NULL,
  `tahun` int(11) NOT NULL,
  PRIMARY KEY (`id_penjualan`),
  KEY `id_barang` (`id_barang`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=743 ;

--
-- Dumping data for table `tb_penjualan`
--

INSERT INTO `tb_penjualan` (`id_penjualan`, `id_barang`, `jml_satuan`, `tanggal`, `bulan`, `tahun`) VALUES
(727, 'B001', 1, '2016-09-18 07:46:53', 1, 2010),
(728, 'B001', 3, '2016-09-18 07:47:23', 1, 2010),
(729, 'B002', 2, '2016-09-18 07:47:44', 1, 2010),
(730, 'B004', 100, '2016-09-18 07:51:47', 1, 2010),
(731, 'B005', 100, '2016-09-18 07:52:04', 2, 2010),
(732, 'B008', 150, '2016-09-18 07:52:21', 3, 2010),
(733, 'B001', 4, '2016-09-18 08:58:25', 12, 2010),
(734, 'B003', 30, '2016-09-18 08:58:48', 11, 2010),
(735, 'B002', 50, '2016-09-18 08:59:40', 11, 2010),
(736, 'B001', 100, '2016-09-20 05:35:51', 1, 2011),
(737, 'B001', 250, '2016-09-20 05:36:06', 2, 2010),
(738, 'B001', 100, '2016-09-20 05:37:43', 3, 2010),
(739, 'B001', 50, '2016-09-20 05:37:56', 1, 2010),
(740, 'B008', 15, '2016-09-20 05:38:10', 1, 2010),
(741, 'B008', 10, '2016-09-20 05:38:28', 2, 2010),
(742, 'B008', 0, '2016-09-20 05:38:48', 3, 2010);

-- --------------------------------------------------------

--
-- Table structure for table `tb_user`
--

CREATE TABLE IF NOT EXISTS `tb_user` (
  `id_user` varchar(20) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `passwd` varchar(255) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_user`
--

INSERT INTO `tb_user` (`id_user`, `nama`, `passwd`) VALUES
('admin', 'Admin', 'd033e22ae348aeb5660fc2140aec35850c4da997');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_hasil`
--
ALTER TABLE `tb_hasil`
  ADD CONSTRAINT `tb_hasil_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tb_hasil_cetak`
--
ALTER TABLE `tb_hasil_cetak`
  ADD CONSTRAINT `tb_hasil_cetak_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tb_penjualan`
--
ALTER TABLE `tb_penjualan`
  ADD CONSTRAINT `tb_penjualan_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
