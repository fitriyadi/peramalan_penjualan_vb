-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 09 Jul 2018 pada 08.58
-- Versi server: 10.1.31-MariaDB
-- Versi PHP: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_peramalan_penjualan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_barang`
--

CREATE TABLE `tb_barang` (
  `id_barang` varchar(4) NOT NULL,
  `nama_barang` varchar(255) NOT NULL,
  `tipe` varchar(100) NOT NULL,
  `harga` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_barang`
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
('B011', 'SHAMPO SHASET', 'SHAMPO', 500),
('B012', 'RINSO CAIR SAHSET', 'Detergent', 1000),
('B013', 'INDOMIE SOTO', 'MIE INSTAN', 2500),
('B014', 'INDOMIE GORENG', 'MIE INSTAN', 3000),
('B015', 'MOLTO ULTRA SHASET', 'PEWANGI', 500),
('B016', 'KAPAL API', 'COFFIE SHASET', 1000),
('B017', 'AQUA', 'MINUMAN', 3000),
('B018', 'CLUB 1000 ML', 'MINUMAN', 2500);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_hasil`
--

CREATE TABLE `tb_hasil` (
  `id_hasil` int(11) NOT NULL,
  `id_penjualan` int(11) NOT NULL,
  `id_barang` varchar(4) NOT NULL,
  `hasil` int(11) NOT NULL,
  `bulan` int(11) NOT NULL,
  `tahun` int(11) NOT NULL,
  `hsl_ramal` varchar(11) NOT NULL,
  `catatan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_hasil_cetak`
--

CREATE TABLE `tb_hasil_cetak` (
  `id_barang` varchar(4) DEFAULT NULL,
  `kategori` varchar(20) NOT NULL,
  `hasil` varchar(255) DEFAULT NULL,
  `bulan` varchar(255) DEFAULT NULL,
  `tahun` varchar(255) DEFAULT NULL,
  `catatan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_hasil_cetak`
--

INSERT INTO `tb_hasil_cetak` (`id_barang`, `kategori`, `hasil`, `bulan`, `tahun`, `catatan`) VALUES
('B015', 'MOLTO ULTRA SHASET', '', 'Memenuhi Target', '2015', 'memenuhi target penjualan untuk barang MOLTO ULTRA SHASET  ');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kategori`
--

CREATE TABLE `tb_kategori` (
  `kategori` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_kategori`
--

INSERT INTO `tb_kategori` (`kategori`) VALUES
('PENSIL'),
('BUKU'),
('BALPOIN'),
('Detergent'),
('SHAMPO'),
('MIE INSTAN'),
('PEWANGI'),
('MINUMAN'),
('COFFIE SHASET');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_penjualan`
--

CREATE TABLE `tb_penjualan` (
  `id_penjualan` int(11) NOT NULL,
  `id_barang` varchar(4) NOT NULL,
  `jml_satuan` int(11) NOT NULL,
  `tanggal` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `bulan` int(11) NOT NULL,
  `tahun` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_penjualan`
--

INSERT INTO `tb_penjualan` (`id_penjualan`, `id_barang`, `jml_satuan`, `tanggal`, `bulan`, `tahun`) VALUES
(745, 'B013', 30, '2018-07-01 07:49:06', 3, 2015),
(746, 'B013', 24, '2018-07-01 07:49:47', 4, 2015),
(747, 'B013', 20, '2018-07-01 07:50:31', 5, 2015),
(748, 'B013', 40, '2018-07-01 07:51:05', 6, 2015),
(749, 'B013', 38, '2018-07-01 07:51:30', 7, 2015),
(751, 'B013', 30, '2018-07-01 07:52:40', 8, 2015),
(753, 'B013', 33, '2018-07-01 07:54:02', 9, 2015),
(754, 'B013', 40, '2018-07-01 07:54:31', 10, 2015),
(755, 'B013', 20, '2018-07-01 07:55:03', 11, 2015),
(756, 'B013', 24, '2018-07-01 07:55:34', 12, 2015),
(757, 'B013', 35, '2018-07-01 07:55:59', 1, 2016),
(758, 'B013', 29, '2018-07-01 07:56:21', 2, 2016),
(759, 'B016', 47, '2018-07-01 09:48:10', 1, 2015),
(760, 'B016', 30, '2018-07-01 09:48:48', 2, 2015),
(761, 'B016', 44, '2018-07-01 09:49:33', 3, 2015),
(762, 'B013', 31, '2018-07-01 12:42:45', 3, 2016),
(763, 'B012', 80, '2018-07-02 01:27:08', 1, 2015),
(764, 'B012', 89, '2018-07-02 01:27:36', 2, 2015),
(765, 'B012', 70, '2018-07-02 01:28:10', 3, 2015),
(766, 'B012', 55, '2018-07-02 01:35:35', 4, 2016),
(767, 'B012', 77, '2018-07-02 01:35:53', 5, 2016),
(768, 'B013', 87, '2018-07-02 01:36:12', 6, 2016),
(769, 'B012', 77, '2018-07-02 01:36:33', 7, 2016),
(770, 'B012', 77, '2018-07-02 01:37:18', 8, 2016),
(771, 'B013', 45, '2018-07-04 03:57:08', 1, 2015),
(772, 'B013', 55, '2018-07-04 03:57:40', 2, 2015),
(773, 'B013', 48, '2018-07-04 03:58:11', 3, 2015),
(774, 'B013', 33, '2018-07-04 03:58:35', 4, 2015),
(775, 'B016', 15, '2018-07-06 03:40:58', 1, 2015),
(776, 'B016', 54, '2018-07-06 03:41:17', 2, 2015),
(777, 'B016', 43, '2018-07-06 03:41:34', 3, 2015),
(778, 'B018', 45, '2018-07-06 06:28:43', 1, 2015),
(779, 'B018', 44, '2018-07-06 06:29:06', 2, 2015),
(780, 'B018', 54, '2018-07-06 06:29:30', 3, 2015),
(781, 'B015', 25, '2018-07-07 12:58:05', 1, 2015),
(782, 'B015', 33, '2018-07-07 12:58:30', 2, 2015),
(783, 'B015', 22, '2018-07-07 12:58:54', 3, 2015);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE `tb_user` (
  `id_user` varchar(20) NOT NULL,
  `nama` varchar(200) NOT NULL,
  `passwd` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_user`
--

INSERT INTO `tb_user` (`id_user`, `nama`, `passwd`) VALUES
('admin', 'Admin', 'd033e22ae348aeb5660fc2140aec35850c4da997');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indeks untuk tabel `tb_hasil`
--
ALTER TABLE `tb_hasil`
  ADD PRIMARY KEY (`id_hasil`),
  ADD KEY `id_barang` (`id_barang`),
  ADD KEY `id_penjualan` (`id_penjualan`);

--
-- Indeks untuk tabel `tb_hasil_cetak`
--
ALTER TABLE `tb_hasil_cetak`
  ADD KEY `id_barang` (`id_barang`);

--
-- Indeks untuk tabel `tb_penjualan`
--
ALTER TABLE `tb_penjualan`
  ADD PRIMARY KEY (`id_penjualan`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indeks untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_hasil`
--
ALTER TABLE `tb_hasil`
  MODIFY `id_hasil` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `tb_penjualan`
--
ALTER TABLE `tb_penjualan`
  MODIFY `id_penjualan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=784;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tb_hasil`
--
ALTER TABLE `tb_hasil`
  ADD CONSTRAINT `tb_hasil_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ketidakleluasaan untuk tabel `tb_hasil_cetak`
--
ALTER TABLE `tb_hasil_cetak`
  ADD CONSTRAINT `tb_hasil_cetak_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ketidakleluasaan untuk tabel `tb_penjualan`
--
ALTER TABLE `tb_penjualan`
  ADD CONSTRAINT `tb_penjualan_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tb_barang` (`id_barang`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
