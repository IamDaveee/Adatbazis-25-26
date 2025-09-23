CREATE TABLE mozdony (
  sorozat varchar (25) NOT NULL,
  psz int NOT NULL,
  gyart_ev int NOT NULL,
  gyarto varchar(50) NOT NULL,
  tipus varchar(30),
  allagba date DEFAULT '1900-01-01',
  tulaj varchar(30) NOT NULL,
  CONSTRAINT pk_sorozat_psz PRIMARY KEY (sorozat, psz)
);


