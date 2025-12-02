A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:
CREATE DATABASE nyelviskola
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci

3. feladat:
alter TABLE vizsgak
ADD FOREIGN KEY (nyelvid) REFERENCES nyelvek(id)

4. feladat:
UPDATE jelentkezesek
SET mobil = 30784613
WHERE sorsz=9

5. feladat:
INSERT INTO nyelvek
VALUES (8, 'holland');

6. feladat:
SELECT MIN(jelentkezesek.szulev) AS "legidősebb", MAX(jelentkezesek.szulev) AS "legfiatalabb" FROM jelentkezesek

7. feladat:
SELECT COUNT(jelentkezesek.vizsga) as "darab", vizsgak.idopont FROM jelentkezesek, vizsgak
WHERE jelentkezesek.vizsga=vizsgak.sorsz AND "darab" = 25
GROUP BY vizsgak.idopont
ORDER BY vizsgak.idopont ASC;

8. feladat:
SELECT nyelvek.nyelv, vizsgak.szint, COUNT(jelentkezesek.vizsga) AS "vizsgazo" FROM nyelvek, vizsgak, jelentkezesek
WHERE vizsgak.nyelvid=nyelvek.id AND vizsgak.sorsz=jelentkezesek.vizsga
GROUP BY nyelvek.nyelv
ORDER BY "vizsgazo"