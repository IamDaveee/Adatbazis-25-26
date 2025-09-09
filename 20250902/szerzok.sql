--
-- Adatbázis: `konyvek`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet: `szerzok`
--

CREATE TABLE IF NOT EXISTS `szerzok` (
  `id` int(2) NOT NULL DEFAULT '0' ,
  `vezeteknev` varchar(20) DEFAULT NULL,
  `keresztnev` varchar(20) DEFAULT NULL,
  `szulido` date DEFAULT '1000-01-01',
  `irszam` varchar(4) DEFAULT NULL,
  `varos` varchar(20) DEFAULT NULL,
  `cim` varchar(20)
  CHARACTER SET utf8 COLLATE utf8_hungarian_ci DEFAULT NULL,
  
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `szerzok`
--

INSERT INTO `szerzok` (`id`, `vezeteknev`, `keresztnev`, `szulido`, `irszam`, `varos`, `cim`) VALUES
(1, 'Tóth', 'Ödön', '1999-01-02', '1235', 'Budapest', 'Keleti utca 45.'),
(2, 'Sebes', 'Olga', '1979-11-22', '1268', 'Budapest', 'Festö utca 3/b.'),
(3, 'Sipos', 'Helga', '1960-10-02', '8000', 'Budapest', 'Nagyvámos tér 34.'),
(4, 'Weress', 'Adrienn', '1973-08-13', '8000', 'Budapest', 'Retek utca 44..'),
(5, 'Zoltay', 'Aliz', '1990-09-12', '3000', 'Budapest', 'Petőfi tér 20.'),
(6, 'Belga', 'Ottó', '1980-12-02', '7030', 'Paks', 'Kakas út 9.'),
(7, 'Ruth', 'Katalin', '1965-09-01', '6000', 'Kecskemét', 'Arany jános utca 11.'),
(8, 'Papp', 'Lajos', '1989-01-02', '4033', 'Debrecen', 'Abel utca 45.');

-- --------------------------------------------------------
-- Tábla szerkezet: `boltok`
--

CREATE TABLE IF NOT EXISTS `boltok` (
  `id` int(2) NOT NULL DEFAULT '0' ,
  `boltnev` varchar(40) DEFAULT NULL,
  `igazgato` varchar(20) DEFAULT NULL,
  `varos` varchar(20) DEFAULT NULL, 
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
--
INSERT INTO `boltok` (`id`, `boltnev`, `igazgato`, `varos`) VALUES
(1, 'Könyvsátor', 'Lakatos Éva', 'Szombathely.'),
(2, 'Arany János Könyvesbolt',  'Martonyi István', 'Székesfehérvár'),
(3, '211. számú KÖnyvértékesítö Kft.', 'Abonyi Noémi', 'Budapest'),
(4, 'Lingva Könyvesbolt', 'Lazarits Sámuel', 'Budapest'),
(5, 'Művelt Nép Könyvesbolt', 'Kovács Izabella', 'Dombóvár'),
(6, 'Anonymus Antikvárium', 'Hornyák Árpád', 'Tarján'),
(7, 'Jókai Könyvesbolt', 'Kelemen Gábor', 'Budapest'),
(8, 'Alex Könyvesbolt', 'Kiss Elemér','Budapest');


-- Tábla szerkezet forgalom

CREATE TABLE IF NOT EXISTS `forgalom` (
  `konyvazon` int(2) NOT NULL DEFAULT '0' ,
  `boltazon` int(2) DEFAULT NULL,
  `mennyiseg` int (4) 
  
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


INSERT INTO `forgalom` (`konyvazon`, `boltazon`, `mennyiseg`) VALUES
(1,1,210),
(1,2,30),
(1,6,110),
(2,2,38),
(2,4,234),
(2,6,120),
(3,2,444),
(3,4,412),
(3,6,153),
(4,3,120),
(4,4,102),
(4,6,77),
(5,1,580),
(5,3,123),
(5,6,82),
(6,2,78),
(6,5,231),
(6,7,120),
(7,1,234),
(7,5,111),
(7,7,59),
(8,1,245),
(8,5,200),
(8,7,355),
(9,3,100),
(9,4,120),
(9,7,273),
(10,2,10),
(10,4,20),
(10,7,161),
(11,1,571),
(11,5,217),
(11,7,104),
(12,3,12),
(12,5,290),
(12,7,524),
(13,2,671),
(13,4,82),
(13,7,220),
(14,1,202),
(14,5,221),
(14,7,22),
(15,3,3),
(15,5,56),
(15,6,69),
(16,2,230),
(16,4,89),
(16,6,550),
(17,3,	261),
(17,4,160),
(17,5,78),
(17,6,156),
(18,3,2),
(18,6,252),
(19,2,312),
(19,4,100),
(19,6,168),
(20,2,210),
(20,4,12),
(20,6,76),
(21,2,602),
(21,4,67),
(21,6,55),
(22,1,322),
(22,5,87),
(22,6,99),
(23,3,700),
(23,5,89),
(23,7,67),
(24,3,100),
(24,5,230),
(25,8,54),
(26,1,213),
(26,9,61),
(27,8,298),
(28,9,32);

-- Tábla szerkezet könyvek

CREATE TABLE IF NOT EXISTS `konyvek` (
  `konyvazon` int(2) NOT NULL DEFAULT '0' ,
  `szerzoazon` int(2) DEFAULT '0',
  `kategoria` varchar(20) DEFAULT NULL,
  `konyvcim` varchar(50) DEFAULT NULL,
   `ar` int(4),  
  PRIMARY KEY (`konyvazon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


INSERT INTO konyvek (`konyvazon`, `szerzoazon`, `kategoria`, `konyvcim`, `ar`) VALUES
(1,1,'Vers','Lélekharang',520),
(2,1,'Vers','Akácméz',710),
(3,2,'Ismeretterjesztö','Így jutunk el a csillagokig',1350),
(4,2,'Szépirodalom','Hódítás',1240),
(5,2,'Ismeretterjesztö','A napfoltok "tevékenysége"',1200),
(6,3,'Mesekönyv','A mackó bánata',1500),
(7,3,'Mesekönyv','Karcsi iskolája',500),
(8,3,'Szépirodalom','Tatárország',810),
(9,3,'Mesekönyv','Karcsi színre lép',1360),
(10,4,'Szépirodalom','Túl a falu tornyán',1150),
(11,5,'Szépirodalom','Pusztába kiáltott szó',1560),
(12,5,'Vers','Ébredés',980),
(13,6,'Ismeretterjesztö','Mexikóban jártam',2350),
(14,6,'Ismeretterjesztö','Kalaptörténelem',2100),
(15,6,'Ismeretterjesztö','Fűszerlexikon',1170),
(16,7,'Mesekönyv','Miért okos a nyúl?',1230),
(17,7,'Mesekönyv','Állatok farsangja',1410),
(18,7,'Mesekönyv','Történetek az óperenciás tengeren túlról',1190),
(19,7,'Szépirodalom','Kalandos nyár',910),
(20,8,'Szépirodalom','Teremtö elme',1330),
(21,8,'Vers','Sóhajok hídja',650),
(22,8,'Vers','Határok között',710),
(23,8,'Vers','Fogságban',950),
(24,9,'Ismeretterjesztö','Forradalom 1956',1900),
(25,10,'Ismeretterjesztö','A DNS világa',1295),
(26,11,'Vers','Bársonyos illatok',940),
(27,11,'Szépirodalom','Hajtűkanyar',450),
(28,12,'Ismeretterjesztö','Társadalmi kommunikáció',2600);
