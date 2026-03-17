CREATE TABLE kiado (
  kod int,
  nev varchar(57) NOT NULL,
  szekhely varchar(60) NOT NULL,
  CONSTRAINT pk_kiado PRIMARY KEY (kod)
);

CREATE TABLE konyv (
  azon int,
  szerzo varchar(50)  default NULL,
  cim varchar(80)   default NULL,
  ev int,
  kiadokod int,
  oldal int,
  tema varchar(25) default null,
  CONSTRAINT pk_konyv PRIMARY KEY (azon),
  CONSTRAINT fk_konyvkiado FOREIGN KEY (kiadokod) REFERENCES kiado(kod)
);
