create database EFF2013_TP_V1_1_DB
--remarque ses question et le meme pour EFF2013_TP_V1_2 aussi pour EFF2013_TP_V1_3 
--just la base de donne et different
use EFF2013_TP_V1_1_DB
CREATE TABLE Entreprise(
    codeentreprise INT PRIMARY KEY,
    nomentreprise VARCHAR(30),
    adresseentreprise VARCHAR(30)
)
CREATE TABLE Participant(
    numeroparticipant INT PRIMARY KEY,
    nomparticipant VARCHAR(30),
    prenomparticipant VARCHAR(30),
    datedenaissanceparticipant DATE,
    codeentreprise INT FOREIGN KEY REFERENCES Entreprise(codeentreprise)
)
CREATE TABLE Stage(
    numerostage INT PRIMARY KEY,
    intitulestage VARCHAR(30)
)
CREATE TABLE Session(
    numerodesession INT PRIMARY KEY,
    datedebutsessionstage DATE,
    datefinsessionstage DATE,
    numerostage INT FOREIGN KEY REFERENCES Stage(numerostage)
)
CREATE TABLE Inscrit(
    numeroparticipant INT FOREIGN KEY REFERENCES Participant(numeroparticipant),
    numerosession INT FOREIGN KEY REFERENCES Session(numerodesession),
    dateinscription DATE,
    PRIMARY KEY(numeroparticipant, numerosession)
)
CREATE TABLE Professeur(
    codeprofesseur INT PRIMARY KEY,
    nomprofesseur VARCHAR(30),
    prenomprofesseur VARCHAR(30),
    adresseprofesseur VARCHAR(30),
    Datedenaissanceprofesseur DATE
)
CREATE TABLE Module(
    numeroModule INT PRIMARY KEY,
    Nommodule VARCHAR(30),
    codeprofesseur INT FOREIGN KEY REFERENCES Professeur(codeprofesseur)
)
CREATE TABLE Composition(
    numerostage INT FOREIGN KEY REFERENCES Stage(numerostage),
    codemodule INT FOREIGN KEY REFERENCES Module(numeroModule),
    PRIMARY KEY (numerostage, codemodule)
)
CREATE TABLE Enseigne(
    codemodule INT FOREIGN KEY REFERENCES Module(numeroModule),
    codeprofesseur INT FOREIGN KEY REFERENCES Professeur(codeprofesseur),
    numerodesession INT FOREIGN KEY REFERENCES Session(numerodesession)
    PRIMARY KEY (codemodule, codeprofesseur, numerodesession)
)

INSERT INTO Entreprise VALUES (1,'NE1','AE1')
INSERT INTO Entreprise VALUES (2,'NE2','AE2')
INSERT INTO Entreprise VALUES (3,'NE3','AE3')

INSERT INTO Participant VALUES (1,'NP1','PE1','2000-01-01',1)
INSERT INTO Participant VALUES (2,'NP2','PE2','2000-01-02',2)
INSERT INTO Participant VALUES (3,'NP3','PE3','2000-01-02',3)

INSERT INTO Stage VALUES (1,'I1')
INSERT INTO Stage VALUES (2,'I2')
INSERT INTO Stage VALUES (3,'I3')

INSERT INTO Session VALUES (1,'2012-09-11','2012-10-11',1)
INSERT INTO Session VALUES (2,'2018-09-11','2018-10-11',2)
INSERT INTO Session VALUES (3,'2020-09-11','2020-10-11',3)

INSERT INTO Inscrit VALUES (1,1,'2016-10-11')
INSERT INTO Inscrit VALUES (2,2,'2016-10-11')
INSERT INTO Inscrit VALUES (3,3,'2016-10-11')

INSERT INTO Professeur VALUES (1,'NP1','PP1','AP1','1986-11-09')
INSERT INTO Professeur VALUES (2,'NP2','PP2','AP2','1969-11-09')
INSERT INTO Professeur VALUES (3,'NP3','PP3','AP3','1991-11-09')

INSERT INTO Module VALUES (1,'NM1',1)
INSERT INTO Module VALUES (2,'NM2',2)
INSERT INTO Module VALUES (3,'NM3',3)

INSERT INTO Composition VALUES (1,1)
INSERT INTO Composition VALUES (2,2)
INSERT INTO Composition VALUES (3,3)

INSERT INTO Enseigne VALUES (1,1,1)
INSERT INTO Enseigne VALUES (2,2,2)
INSERT INTO Enseigne VALUES (3,3,3)

SELECT * FROM Entreprise
SELECT * FROM Participant
SELECT * FROM Stage
SELECT * FROM Session
SELECT * FROM Inscrit
SELECT * FROM Professeur
SELECT * FROM Module
SELECT * FROM Composition
SELECT * FROM Enseigne