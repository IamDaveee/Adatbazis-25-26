
-- Felhasznalok
INSERT INTO Felhasznalok (FelhasznaloID, Nev, Email, Szerep, RegisztracioDatuma) VALUES
(1, 'Kovács Anna', 'anna.kovacs@example.com', 'tanár', '2023-01-15'),
(2, 'Nagy Péter', 'peter.nagy@example.com', 'diák', '2023-02-10'),
(3, 'Szabó Márta', 'marta.szabo@example.com', 'diák', '2023-02-12'),
(4, 'Tóth Gábor', 'gabor.toth@example.com', 'tanár', '2023-01-20'),
(5, 'Kiss Júlia', 'julia.kiss@example.com', 'admin', '2023-01-01');

-- Kurzusok
INSERT INTO Kurzusok (KurzusID, Cim, Leiras, TanarID, Letrehozva) VALUES
(1, 'Bevezetés a Pythonba', 'Alapvető programozási ismeretek Python nyelven.', 1, '2023-03-01'),
(2, 'SQL alapok', 'Adatbázis-kezelés és SQL lekérdezések.', 4, '2023-03-05'),
(3, 'Webfejlesztés HTML/CSS', 'Weboldalak készítése HTML és CSS segítségével.', 1, '2023-03-10');

-- Leckek
INSERT INTO Leckek (LeckeID, KurzusID, Cim, Tartalom, Sorszam) VALUES
(1, 1, 'Változók és típusok', 'A Python alapvető adattípusai.', 1),
(2, 1, 'Elágazások', 'Feltételes szerkezetek használata.', 2),
(3, 2, 'SELECT lekérdezések', 'Adatok lekérdezése SQL-ben.', 1),
(4, 2, 'JOIN műveletek', 'Táblák összekapcsolása.', 2),
(5, 3, 'HTML alapok', 'HTML elemek és szerkezet.', 1),
(6, 3, 'CSS bevezetés', 'Stíluslapok használata.', 2);

-- Beiratkozasok
INSERT INTO Beiratkozasok (BeiratkozasID, FelhasznaloID, KurzusID, Beiratkozva) VALUES
(1, 2, 1, '2023-03-02'),
(2, 3, 1, '2023-03-03'),
(3, 2, 2, '2023-03-06'),
(4, 3, 2, '2023-03-07'),
(5, 2, 3, '2023-03-11'),
(6, 3, 3, '2023-03-12');

-- Feladatok
INSERT INTO Feladatok (FeladatID, LeckeID, Cim, MaxPont, Hatarido) VALUES
(1, 1, 'Változók gyakorlása', 10, '2023-03-10'),
(2, 2, 'Elágazások feladat', 15, '2023-03-15'),
(3, 3, 'SELECT gyakorlás', 10, '2023-03-12'),
(4, 4, 'JOIN feladat', 15, '2023-03-18'),
(5, 5, 'HTML oldal készítése', 20, '2023-03-20'),
(6, 6, 'CSS stíluslap', 20, '2023-03-25');

-- Beadasok
INSERT INTO Beadasok (BeadasID, FeladatID, FelhasznaloID, Beadva, Pont, UtolsoModositas) VALUES
(1, 1, 2, '2023-03-09', 9, '2023-03-09'),
(2, 1, 3, '2023-03-09', 10, '2023-03-09'),
(3, 2, 2, '2023-03-14', 14, '2023-03-14'),
(4, 2, 3, '2023-03-14', 13, '2023-03-14'),
(5, 3, 2, '2023-03-11', 10, '2023-03-11'),
(6, 4, 3, '2023-03-17', 15, '2023-03-17'),
(7, 5, 2, '2023-03-19', 18, '2023-03-19'),
(8, 6, 3, '2023-03-24', 20, '2023-03-24');

-- ForumTemak
INSERT INTO ForumTemak (TemaID, KurzusID, FelhasznaloID, Letrehozva) VALUES
(1, 1, 2, '2023-03-05'),
(2, 2, 3, '2023-03-08'),
(3, 3, 2, '2023-03-12');

-- ForumHozzaszolasok
INSERT INTO ForumHozzaszolasok (HozzaszolasID, TemaID, FelhasznaloID, Tartalom, Letrehozva) VALUES
(1, 1, 1, 'Üdvözlök mindenkit a kurzusban!', '2023-03-05'),
(2, 1, 2, 'Köszönöm, várom az órákat!', '2023-03-06'),
(3, 2, 4, 'Kérdésed van a JOIN műveletekről?', '2023-03-08'),
(4, 2, 3, 'Igen, nem értem a LEFT JOIN-t.', '2023-03-09'),
(5, 3, 1, 'HTML-ben a <div> mire való?', '2023-03-12'),
(6, 3, 2, 'Tartalmi blokkok elrendezésére.', '2023-03-13');
