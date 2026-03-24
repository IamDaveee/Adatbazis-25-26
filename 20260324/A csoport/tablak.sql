CREATE TABLE diakok (
  oktazon varchar(7),
  nev varchar(18) NOT NULL,
  hozott int NOT NULL,
  kpmagy int NOT NULL,
  kpmat int NOT NULL,
  CONSTRAINT pk_diakok PRIMARY KEY (oktazon)
);


CREATE TABLE tagozatok (
  akod int,
  agazat varchar(11) NOT NULL,
  nyek bit NOT NULL,
  CONSTRAINT pk_tagozatok PRIMARY KEY (akod)
);

CREATE TABLE jelentkezesek (
  diak varchar(7),
  tag int NOT NULL,
  hely int NOT NULL,
  CONSTRAINT pk_jel PRIMARY KEY (diak, tag),
  CONSTRAINT fk_diak FOREIGN KEY (diak) REFERENCES diakok(oktazon),
  CONSTRAINT fk_tag FOREIGN KEY (tag) REFERENCES tagozatok(akod)
);

