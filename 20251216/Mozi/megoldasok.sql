/* 1. feladat:  */
create database filmszinhaz
default charset utf8
collate utf8_hungarian_ci

/* 3. feladat:  */
SELECT COUNT(id) AS "vetitesek_szama" FROM vetites
WHERE kezdes = "20:00:00"

/* 4. feladat:  */
SELECT vendeg.nev AS "vendeg_nev", COUNT(jegy.id) AS "jegy_db" FROM vendeg, jegy
WHERE vendeg.id=jegy.vendegId
GROUP BY vendeg.nev
ORDER BY COUNT(jegy.id) DESC
LIMIT 5

/* 5. feladat:  */
UPDATE film
SET cim = "Csillagok között"
WHERE cim="Interstellar"

/* 6. feladat:  */
INSERT INTO filmtipus (nev) VALUES ("Animációs")

/* 7. feladat:  */
SELECT vendeg.nev AS "nev", COUNT(jegy.id) AS "teljes_aru_jegy_db" FROM vendeg, jegy
WHERE nev="Fodor András" AND jegy.kedvezmeny=0 AND vendeg.id=jegy.vendegId

/* 8. feladat:  */
DELETE jegy FROM jegy JOIN vendeg ON vendeg.id = jegy.vendegId
WHERE vendeg.nev = 'Oláh Áron';

DELETE FROM vendeg
WHERE nev = 'Oláh Áron';

/* 9. feladat:  */
SELECT film.cim AS "Film címe", filmtipus.nev AS "Film típusa" FROM film, filmtipus, vetites
WHERE filmtipus.id=film.filmtipusId AND vetites.filmId=film.id AND vetites.datum AND vetites.datum BETWEEN "2021-03-01" AND "2021-03-31"
GROUP BY film.cim
ORDER BY film.cim

/* 10. feladat:  */
SELECT film.cim FROM film,filmtipus
WHERE film.filmtipusId=filmtipus.id AND filmtipus.nev = (SELECT filmtipus.nev FROM filmtipus, film
WHERE film.filmtipusId=filmtipus.id AND film.cim="Az ötödik elem") AND film.cim <> "Az ötödik elem"

/* 11. feladat:  */
SELECT film.cim AS "film_neve", COUNT(jegy.id) AS "jegy_darabszam", SUM(890-(890*jegy.kedvezmeny/100)) AS "Teljes bevétel" FROM film,jegy, vetites
WHERE film.id=vetites.filmId AND vetites.id=jegy.vetitesId
GROUP BY film.cim
ORDER BY "Teljes bevétel" DESC
LIMIT 1