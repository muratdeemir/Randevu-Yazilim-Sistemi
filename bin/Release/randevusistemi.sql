-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2019 at 11:45 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `randevusistemi`
--

-- --------------------------------------------------------

--
-- Table structure for table `brans`
--

CREATE TABLE `brans` (
  `id_brans` int(3) NOT NULL,
  `brans_ad` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `brans`
--

INSERT INTO `brans` (`id_brans`, `brans_ad`) VALUES
(1, 'ALGOLOJİ'),
(2, 'BESLENME VE DİYET'),
(3, 'BEYİN VE SİNİR CERRAHİSİ'),
(4, 'ÇOCUK ALERJİSİ'),
(5, 'ÇOCUK CERRAHİSİ'),
(6, 'ÇOCUK ENDOKRİNOLOJİSİ'),
(7, 'ÇOCUK ENFEKSİYON'),
(8, 'ÇOCUK GÖĞÜS HASTALIKLARI'),
(9, 'ÇOCUK HEMATOLOJİSİ'),
(10, 'ÇOCUK KARDİYOLOJİSİ'),
(11, 'ÇOCUK METABOLİZMA'),
(12, 'ÇOCUK NEFROLOJİSİ'),
(13, 'ÇOCUK NÖROLOJİSİ'),
(14, 'ÇOCUK PSİKİYATRİSİ'),
(15, 'ÇOCUK SAĞLIĞI VE HASTALIKLARI'),
(16, 'ÇOCUK ÜROLOJİSİ'),
(17, 'DERMATOLOJİ (CİLDİYE)'),
(18, 'ENDOKRİNOLOJİ VE METABOLİZMA'),
(19, 'ENFEKSİYON HASTALIKLARI'),
(20, 'FİZİKSEL TIP VE REHABİLİTASYON'),
(21, 'GASTROENTEROLOJİ'),
(22, 'GELENEKSEL VE TAMAMLAYICI TIP(GETAMER)'),
(23, 'GENEL CERRAHİ'),
(24, 'GERİATRİ'),
(25, 'GÖĞÜS CERRAHİSİ'),
(26, 'GÖĞÜS HASTALIKLARI'),
(27, 'GÖZ HASTALIKLARI'),
(28, 'HEMATOLOJİ'),
(29, 'İÇ HASTALIKLARI'),
(30, 'KADIN HASTALIKLARI VE DOĞUM'),
(31, 'KALP VE DAMAR CERRAHİSİ'),
(32, 'KARDİYOLOJİ'),
(33, 'KEMİK YOĞUNLUĞU ÖLÇÜMÜ'),
(34, 'KULAK-BURUN-BOĞAZ HASTALIKLARI'),
(35, 'NEFROLOJİ'),
(36, 'NÖROLOJİ'),
(37, 'ORTOPEDİ VE TRAVMATOLOJİ'),
(38, 'PLASTİK REKONSTRÜKTİF VE ESTETİK CERRAHİ');

-- --------------------------------------------------------

--
-- Table structure for table `doktor`
--

CREATE TABLE `doktor` (
  `id_doktor` int(3) NOT NULL,
  `doktor_ad` varchar(50) NOT NULL,
  `fk_brans` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `doktor`
--

INSERT INTO `doktor` (`id_doktor`, `doktor_ad`, `fk_brans`) VALUES
(1, 'MURAT KARA', 27),
(2, 'MUSTAFA ASLAN', 31),
(3, 'OSMAN YILDIRIM', 1),
(4, 'KERİM KILIÇ', 2),
(5, 'MUSTAFA YILDIRIM', 3),
(6, 'TUĞÇE BAKIR', 4),
(7, 'ESRA YILDIRIM', 5),
(8, 'YILMAZ KURT', 6),
(9, 'ATİLLA KİTAP', 7),
(10, 'EMRE KIR', 8),
(11, 'FERHAN ERENEL', 9),
(12, 'GÜLBİN DEMİRKAPI', 10),
(13, 'EMİNE DEVECİ', 11),
(14, 'ERDİ SÜRÜM', 12),
(15, 'BAHAR ÖZDEN', 13),
(16, 'FATİH RIFAT KAÇER', 14),
(17, 'TUBA HANIM FİRİK', 15),
(18, 'DUYGU GÜMÜRDÜ', 16),
(19, 'MUSTAFA ERSAGUN ÇİĞDEM', 17),
(20, 'ZÜHAL TAŞDEMİR', 18),
(21, 'HALUK KANSU', 19),
(22, 'CEREN BUĞLEM TÜFENK', 20),
(23, 'TAHACAN UYLUKÇU', 21),
(24, 'NESLİHAN LOĞOĞLU', 22),
(25, 'HİKMET ÖRENÇ', 23),
(26, 'MELİHCAN KURŞUN', 24),
(27, 'İLKNUR YAVUZER', 25),
(28, 'NURİ KELEŞ', 26),
(29, 'ÇİLE TUNÇ', 27),
(30, 'ZEKİYE SEVAL GÜNALAN', 28),
(31, 'ÖVÜNÇ DOĞRU', 29),
(32, 'TÜLAY ORAL', 30),
(33, 'FATİH AVNİ KOCACIKLI', 31),
(34, 'SARP KORKMAZOĞLU', 32),
(35, 'SANER GÜNGÖR UZUNOĞLU', 33),
(36, 'FURKAN ÖZKURT PÜRCÜ', 34),
(37, 'MÜRSELİN GÜNDÜZ', 35),
(38, 'ASLIHAN ESRA KARLI', 36),
(39, 'MAHMUT SAMİ TUNÇER', 37),
(40, 'AYBİKE NAR', 38),
(41, 'TUĞBA AK', 1);

-- --------------------------------------------------------

--
-- Table structure for table `hastalar`
--

CREATE TABLE `hastalar` (
  `tc` bigint(11) NOT NULL,
  `password` varchar(25) NOT NULL,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(25) NOT NULL,
  `cinsiyet` varchar(6) NOT NULL,
  `dogum_yeri` varchar(25) NOT NULL,
  `dogum_yili` varchar(25) NOT NULL,
  `anne_adi` varchar(25) NOT NULL,
  `baba_adi` varchar(25) NOT NULL,
  `cep_telefonu` varchar(11) DEFAULT NULL,
  `sabit_telefon` varchar(25) DEFAULT NULL,
  `e_posta` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hastalar`
--

INSERT INTO `hastalar` (`tc`, `password`, `ad`, `soyad`, `cinsiyet`, `dogum_yeri`, `dogum_yili`, `anne_adi`, `baba_adi`, `cep_telefonu`, `sabit_telefon`, `e_posta`) VALUES
(12345678900, '123456', 'Ali', 'Yaz', 'Erkek', 'Samsun', '1998', 'Ayşe', 'Ali', '05554443322', '012', 'ali@gmail.com'),
(12345678911, '1234567', 'ad', 'soyad', 'Erkek', 'Bingöl', '2010-36-02', 'anne', 'baba', '05556667788', '000', 'eposta@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `randevu`
--

CREATE TABLE `randevu` (
  `id_randevu` int(3) NOT NULL,
  `tc` bigint(11) NOT NULL,
  `fk_doktor` varchar(50) NOT NULL,
  `brans` varchar(50) NOT NULL,
  `randevu_saat` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `randevu`
--

INSERT INTO `randevu` (`id_randevu`, `tc`, `fk_doktor`, `brans`, `randevu_saat`) VALUES
(2, 12345678900, 'OSMAN YILDIRIM', 'ALGOLOJİ', '10:00'),
(3, 12345678900, 'MUSTAFA ERSAGUN ÇİĞDEM', 'DERMATOLOJİ (CİLDİYE)', '15:00'),
(10, 12345678900, 'test', 'test', '20:00'),
(30, 12345678900, 'KERİM KILIÇ', 'BESLENME VE DİYET', '14:00'),
(31, 12345678911, 'TUĞBA AK', 'ALGOLOJİ', '09:00'),
(32, 12345678911, 'MUSTAFA YILDIRIM', 'BEYİN VE SİNİR CERRAHİSİ', '12:00'),
(33, 12345678911, 'TUĞÇE BAKIR', 'ÇOCUK ALERJİSİ', '15:00'),
(34, 12345678911, 'EMRE KIR', 'ÇOCUK GÖĞÜS HASTALIKLARI', '11:00'),
(35, 12345678900, 'MUSTAFA YILDIRIM', 'BEYİN VE SİNİR CERRAHİSİ', '13:00'),
(36, 12345678900, 'KERİM KILIÇ', 'BESLENME VE DİYET', '09:00'),
(38, 12345678900, 'ERDİ SÜRÜM', 'ÇOCUK NEFROLOJİSİ', '16:00');

-- --------------------------------------------------------

--
-- Table structure for table `unvan`
--

CREATE TABLE `unvan` (
  `id_unvan` int(25) NOT NULL,
  `unvan_ad` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `brans`
--
ALTER TABLE `brans`
  ADD PRIMARY KEY (`id_brans`);

--
-- Indexes for table `doktor`
--
ALTER TABLE `doktor`
  ADD PRIMARY KEY (`id_doktor`),
  ADD KEY `id_brans` (`fk_brans`);

--
-- Indexes for table `hastalar`
--
ALTER TABLE `hastalar`
  ADD PRIMARY KEY (`tc`);

--
-- Indexes for table `randevu`
--
ALTER TABLE `randevu`
  ADD PRIMARY KEY (`id_randevu`),
  ADD KEY `tc` (`tc`);

--
-- Indexes for table `unvan`
--
ALTER TABLE `unvan`
  ADD PRIMARY KEY (`id_unvan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `brans`
--
ALTER TABLE `brans`
  MODIFY `id_brans` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `doktor`
--
ALTER TABLE `doktor`
  MODIFY `id_doktor` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `randevu`
--
ALTER TABLE `randevu`
  MODIFY `id_randevu` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT for table `unvan`
--
ALTER TABLE `unvan`
  MODIFY `id_unvan` int(25) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doktor`
--
ALTER TABLE `doktor`
  ADD CONSTRAINT `doktor_ibfk_1` FOREIGN KEY (`fk_brans`) REFERENCES `brans` (`id_brans`);

--
-- Constraints for table `randevu`
--
ALTER TABLE `randevu`
  ADD CONSTRAINT `randevu_ibfk_1` FOREIGN KEY (`tc`) REFERENCES `hastalar` (`tc`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
