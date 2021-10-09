CREATE TABLE PREDMET
(
	ID_PREDMETA NUMBER(20) PRIMARY KEY,
	NAZIV_PREDMETA VARCHAR2(30) NOT NULL
);

CREATE TABLE SMER
(
	ID_SMERA NUMBER(20) PRIMARY KEY,
	NAZIV_SMERA VARCHAR2(20) NOT NULL,
	BROJ_UCENIKA NUMBER(10)
	
);

CREATE TABLE UCENIK
(
	ID_UCENIKA NUMBER(20) PRIMARY KEY,
	IME VARCHAR2(20) NOT NULL,
	PREZIME VARCHAR2(28) NOT NULL,
	RAZRED NUMBER(3) NOT NULL,
	ULICA VARCHAR2(30),
	BROJ NUMBER(12),
	ID_SMERA NUMBER(20) NOT NULL,
	DATUM_UPISA DATE NOT NULL,
	CONSTRAINT SMER_FK FOREIGN KEY (ID_SMERA)
	REFERENCES SMER(ID_SMERA)
);
CREATE TABLE OCENA
(
	ID_OCENA NUMBER(20) PRIMARY KEY,
	VREDNOST NUMBER(3) CONSTRAINT OCE_CK CHECK (VREDNOST BETWEEN 1 AND 5),
	OPIS VARCHAR2(9),
	ID_UCENIKA NUMBER(20) NOT NULL,
	DATUM_DOBIJANJA DATE NOT NULL ,
	ID_PREDMETA NUMBER(20) NOT NULL,
	CONSTRAINT UCENIK1_FK FOREIGN KEY (ID_UCENIKA)
	REFERENCES UCENIK(ID_UCENIKA),
	CONSTRAINT PREDMET1_FK FOREIGN KEY (ID_PREDMETA)
	REFERENCES PREDMET(ID_PREDMETA)
);

CREATE TABLE RODITELJI
(
	ID_RODITELJA NUMBER(20) PRIMARY KEY,
	IME_ROD VARCHAR2(26) NOT NULL,
	PREZIME_ROD VARCHAR(30) NOT NULL
);

CREATE TABLE ZAPOSLEN
(
	JMBG NUMBER(14) PRIMARY KEY,
	L_IME VARCHAR2(12) NOT NULL,
	IME_RODITELJA VARCHAR2(12) NOT NULL,
	PREZIME VARCHAR2(18) NOT NULL,
	DATUM_RODJENJA DATE,
	ULICA VARCHAR2(18),
	BROJ NUMBER(9),
	TIP_OSOBLJA VARCHAR2(20) NOT NULL,
	STRUCNA_SPREMA VARCHAR2(20),
	NAZIV_SEKTORA VARCHAR2(20),
	TIP_NORME VARCHAR2(10),
	BROJ_CASOVA_NEDELJNO NUMBER(2),
	NAZIV_SKOLE VARCHAR2(20)
);

CREATE TABLE ANGAZOVAN_NA
(
	ID_ANGAZOVAN NUMBER(20) PRIMARY KEY,
	JMBG_NASTAVNIKA NUMBER(14) NOT NULL,
	ID_PREDMETA NUMBER(20) NOT NULL,
	DATUM_ANGAZOVANJA DATE,
	CONSTRAINT ZAPOSLEN_FK FOREIGN KEY(JMBG_NASTAVNIKA)
	REFERENCES ZAPOSLEN(JMBG),
	CONSTRAINT PREDMET_FK FOREIGN KEY(ID_PREDMETA)
	REFERENCES PREDMET(ID_PREDMETA)
);

CREATE TABLE UCI_NA
(
	ID_UCI_NA NUMBER(20) PRIMARY KEY,
	ID_SMERA NUMBER(20) NOT NULL,
	ID_PREDMETA NUMBER(20) NOT NULL,
	CONSTRAINT SMERR_FK FOREIGN KEY(ID_SMERA)
	REFERENCES SMER(ID_SMERA),
	CONSTRAINT PREDMETT_FK FOREIGN KEY(ID_PREDMETA)
	REFERENCES PREDMET(ID_PREDMETA)
);

CREATE TABLE IMA_CLANOVE_VECA
(
	ID_IMA_CLANOVE_VECA NUMBER(20) PRIMARY KEY,
	ID_UCENIKA NUMBER(20) NOT NULL,
	ID_RODITELJA NUMBER(20) NOT NULL,
	CONSTRAINT UCENIK2_FK FOREIGN KEY(ID_UCENIKA)
	REFERENCES UCENIK(ID_UCENIKA),
	CONSTRAINT RODITELJI1_FK FOREIGN KEY(ID_RODITELJA)
	REFERENCES RODITELJI(ID_RODITELJA)
);
CREATE TABLE TELEFON
(
	ID_TELEFONA NUMBER(20) PRIMARY KEY,
	ID_RODITELJA NUMBER(20) NOT NULL,
	TELEFON NUMBER(18) NOT NULL,
	CONSTRAINT RODITELJI_FK FOREIGN KEY(ID_RODITELJA)
	REFERENCES RODITELJI(ID_RODITELJA)
);

CREATE TABLE GODINE
(
	ID_GODINE NUMBER(20) PRIMARY KEY,
	ID_PREDMETA NUMBER(20) NOT NULL,
	GODINA NUMBER(3) CONSTRAINT GOD_CK CHECK (GODINA BETWEEN 1 AND 8),
	CONSTRAINT PREDMET111_FK FOREIGN KEY(ID_PREDMETA)
	REFERENCES PREDMET(ID_PREDMETA)
	
);