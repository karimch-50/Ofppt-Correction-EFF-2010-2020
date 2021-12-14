create database EFF2013_TP_V2_1_DB
--remarque ses question et le meme pour EFF2013_TP_V2_2 aussi pour EFF2013_TP_V2_3 
--just la base de donne et different
use EFF2013_TP_V2_1_DB
CREATE TABLE Table_Compte(
    Compte VARCHAR(50) PRIMARY KEY,
    Nom VARCHAR(50) NOT NULL,
    Prenom VARCHAR(50) NOT NULL,
    MotPasse VARCHAR(50) NOT NULL,
    DateCreation DATE DEFAULT GETDATE(),
    Tailleinitialle INT,
    Tailledisponible INT,
    QuestionSecurite VARCHAR(50) NOT NULL,
    ReponseSecurite VARCHAR(50) NOT NULL,
    Etatcompte CHAR(3) DEFAULT 'Non' CHECK(Etatcompte = 'Oui' OR Etatcompte = 'Non')
)
CREATE TABLE Table_TypeCourrier(
    CodeType INT PRIMARY KEY,
    LibTypeCourrier VARCHAR(50) NOT NULL
)
CREATE TABLE Table_Courrier(
    NCourrier INT PRIMARY KEY IDENTITY,
    DateArriv DATETIME,
    CompteExpediteur VARCHAR(50) FOREIGN KEY REFERENCES Table_Compte(Compte),
    Sujet VARCHAR(50),
    Contenu VARCHAR(255),
    EtatCourrier CHAR(3) DEFAULT 'Non' CHECK(EtatCourrier = 'Oui' OR EtatCourrier = 'Non'),
    TypeCourrier INT FOREIGN KEY REFERENCES Table_TypeCourrier(CodeType)
)
CREATE TABLE Table_FichierAttache(
    CodeFichier INT PRIMARY KEY,
    Lib_Fichier VARCHAR(50),
    Format VARCHAR(5) CHECK(Format != '.exe' OR Format != '.msi' OR Format != '.reg' OR Format != '.vbs'),
    Taille INT CHECK(Taille > 0),
    NCourrier INT FOREIGN KEY REFERENCES Table_Courrier(NCourrier)
)
CREATE TABLE Table_BoiteReception(
    CompteRecepteur VARCHAR(50) FOREIGN KEY REFERENCES Table_Compte(Compte),
    NCourrier INT FOREIGN KEY REFERENCES Table_Courrier(NCourrier),
    DateReception DATETIME,
    EtatRecp  CHAR(3) CHECK(EtatRecp = 'Oui' OR EtatRecp = 'Non')
    PRIMARY KEY (CompteRecepteur,NCourrier)
)
CREATE TABLE Table_Archive(
    CodeArchive INT PRIMARY KEY,
    NomArchive VARCHAR(50) NOT NULL,
    NCourrier INT FOREIGN KEY REFERENCES Table_Courrier(NCourrier),
    Compte VARCHAR(50) FOREIGN KEY REFERENCES Table_Compte(Compte),
    DateArchive DATETIME,
    TailleArchivage INT CHECK(TailleArchivage > 0),
    TypeArchivage VARCHAR(20) CHECK(TypeArchivage != 'Normal' OR TypeArchivage != 'Optimal' OR TypeArchivage != 'Special')
)


INSERT INTO Table_Compte VALUES ('C1','N1','P1','MDP1','2014-10-10',10,9,'Q1','R1','Oui')
INSERT INTO Table_Compte VALUES ('C2','N2','P2','MDP2','2014-11-11',20,10,'Q2','R2','Non')
INSERT INTO Table_Compte VALUES ('C3','N3','P3','MDP3','2014-12-12',30,11,'Q3','R3','Oui')

INSERT INTO Table_TypeCourrier VALUES (1,'LTC1')
INSERT INTO Table_TypeCourrier VALUES (2,'LTC2')
INSERT INTO Table_TypeCourrier VALUES (3,'LTC3')

INSERT INTO Table_Courrier VALUES ('2019-10-10','C1','S1','Ct1','Oui',1)
INSERT INTO Table_Courrier VALUES ('2019-11-11','C2','S2','Ct2','Non',2)
INSERT INTO Table_Courrier VALUES ('2019-12-12','C3','S3','Ct3','Oui',3)

INSERT INTO Table_FichierAttache VALUES (1,'LF1','.txt',10,2)
INSERT INTO Table_FichierAttache VALUES (2,'LF2','.txt',11,3)
INSERT INTO Table_FichierAttache VALUES (3,'LF3','.txt',12,1)

INSERT INTO Table_BoiteReception VALUES ('C1',2,'2019-11-11','Oui')
INSERT INTO Table_BoiteReception VALUES ('C2',3,'2019-12-12','Non')
INSERT INTO Table_BoiteReception VALUES ('C3',1,'2019-12-20','Oui')


INSERT INTO Table_Archive VALUES (1,'NM1',2,'C1','2010-10-10',10,'Normal')
INSERT INTO Table_Archive VALUES (2,'NM2',1,'C2','2010-11-11',11,'Normal')
INSERT INTO Table_Archive VALUES (3,'NM3',3,'C3','2010-12-12',12,'Normal')


SELECT * FROM Table_Compte
SELECT * FROM Table_TypeCourrier
SELECT * FROM Table_Courrier
SELECT * FROM Table_FichierAttache
SELECT * FROM Table_BoiteReception
SELECT * FROM Table_Archive