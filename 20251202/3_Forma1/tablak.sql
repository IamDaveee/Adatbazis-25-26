CREATE TABLE csapatok (
  csazon int,
  csnev varchar(20),
  CONSTRAINT pk_csapatok PRIMARY KEY (csazon)
);


CREATE TABLE pilotak (
  pazon int,
  pnev varchar(16),
  szev int,
  csapat int,
  CONSTRAINT pk_pilotak PRIMARY KEY (pazon)
);

CREATE TABLE versenyek (
  vkod varchar(3),
  datum date,
  vnev varchar(18),
  hely varchar(14),
  kor int,
  hossz int,
  CONSTRAINT pk_versenyek PRIMARY KEY (vkod)
);

CREATE TABLE eredmenyek (
  pilota int,
  nagydij varchar(3),
  startpoz int,
  celpoz int,
  CONSTRAINT pk_eredmenyek PRIMARY KEY (pilota, nagydij)
);

