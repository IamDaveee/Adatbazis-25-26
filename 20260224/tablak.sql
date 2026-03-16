CREATE TABLE konyvek (
    id INT PRIMARY KEY,
    cim VARCHAR(255) NOT NULL,
    szerzo VARCHAR(255),
    kategoria VARCHAR(50),
    alapar DECIMAL(10, 2)
);

CREATE TABLE tagok (
    id INT PRIMARY KEY,
    nev VARCHAR(100) NOT NULL,
    szuletesi_ev INT,
    lakhely VARCHAR(100)
);

CREATE TABLE kolcsonzesek (
    id INT PRIMARY KEY,
    tagid INT,
    datum DATE,
    hatarido DATE
);

CREATE TABLE tetelek (
    id INT PRIMARY KEY,
    kolcsonzesid INT,
    konyvid INT,
    napok_szama INT,
    kesedelmi_dij DECIMAL(10, 2)
);