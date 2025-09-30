A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:
CREATE DATABASE maratonvalto
DEFAULT CHARSET utf8
COLLATE utf8_hungarian_ci;

3. feladat:
INSERT INTO eredmenyek (futo, kor, ido) VALUES
(1044, 4, 15765);

4. feladat:
SELECT futok.fnev AS futo, futok.szulev FROM futok
WHERE futok.ffi=0
ORDER BY futok.fnev ASC

5. feladat:
SELECT futok.fnev AS futo, (2016-futok.szulev) AS kor FROM futok
WHERE (2016-futok.szulev)>=42
ORDER BY kor, futok.szulho DESC

6. feladat:
SELECT futok.fnev AS futo, eredmenyek.ido FROM futok,eredmenyek
WHERE eredmenyek.futo = futok.fid
GROUP BY futok.fnev
ORDER BY ido ASC
LIMIT 10

7. feladat:
SELECT futok.csapat AS csapat, SUM(eredmenyek.ido) AS csapatido FROM futok, eredmenyek
WHERE futok.fid = eredmenyek.futo
GROUP BY futok.csapat
ORDER BY csapatido ASC
