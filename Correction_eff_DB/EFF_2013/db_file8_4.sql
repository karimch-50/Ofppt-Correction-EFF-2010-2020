create database EFF2013_TP_V3_1_DB
--remarque ses question et le meme pour EFF2013_TP_V3_2 est EFF2013_TP_V3_3 
--just la base de donne et different
use EFF2013_TP_V3_1_DB
CREATE TABLE Agence(
    CODEAGENCE INT PRIMARY KEY,
    NOMAGENCE VARCHAR(50),
    EMAILAGENCE VARCHAR(50),
    TELAGENCE VARCHAR(14),
    ADRESSEAGENCE VARCHAR(255),
    NOMRESPONSABLE VARCHAR(60),
    TELRESPONSABLE VARCHAR(14)
)
CREATE TABLE CLIENT(
    CIN VARCHAR(14) PRIMARY KEY,
    NOM VARCHAR(50),
    PRENOM VARCHAR(50),
    TELFIX VARCHAR(14),
    GSM VARCHAR(14),
    EMAIL VARCHAR(50),
    ADRESSE VARCHAR(255),
    AURESINFOS VARCHAR(255),
    COMPTE VARCHAR(50),
    MOTDEPASSE VARCHAR(50)
)
CREATE TABLE COMPTE(
    NCOMPTE INT PRIMARY KEY,
    CODEAGENCE INT FOREIGN KEY REFERENCES AGENCE(CODEAGENCE),
    CIN VARCHAR(14) FOREIGN KEY REFERENCES CLIENT(CIN),
    DATEOUV DATETIME,
    MONTANT MONEY
)
CREATE TABLE TRANSFER(
    CODETRANSFER CHAR(12) PRIMARY KEY,
    CINMETTEUR VARCHAR(14) FOREIGN KEY REFERENCES CLIENT(CIN),
    DATETRANSFER DATETIME,
    MONTANTTRANS MONEY,
    NCOMPTE INT FOREIGN KEY REFERENCES COMPTE(NCOMPTE),
    ALERTSMS CHAR(3),
    FRAISTRANSF MONEY,
    AUTRESFRAIS MONEY,
    CINRECP VARCHAR(14),
    NOM_PRENOMRECP VARCHAR(50),
    PAYS VARCHAR(50),
    VILLE VARCHAR(50)
)
CREATE TABLE DESTINATAIRE(
    IDDEST INT PRIMARY KEY,
    CODETRANSFER CHAR(12) FOREIGN KEY REFERENCES TRANSFER(CODETRANSFER),
    CODEAGENCE INT FOREIGN KEY REFERENCES AGENCE(CODEAGENCE),
    DATERECP DATETIME,
    MONTANT MONEY
)
CREATE TABLE ESPACECLIENT(
    NCOMMENTAIRE INT PRIMARY KEY,
    CIN VARCHAR(14) FOREIGN KEY REFERENCES CLIENT(CIN),
    DATEHEUREPOSTULATION DATETIME,
    TYPEMSG VARCHAR(20),
    OBJETMSG VARCHAR(255),
    TEXTMSG VARCHAR(255),
    VALIDER VARCHAR(3)
)
CREATE TABLE BAREME(
    CODEBAREME INT PRIMARY KEY,
    PAYS VARCHAR(50),
    PRIX MONEY
)
CREATE TABLE NOTIFICATIONMSGVOCAL(
    IDNOTI INT PRIMARY KEY,
    CODETRANSFER CHAR(12) FOREIGN KEY REFERENCES TRANSFER(CODETRANSFER),
    CODEBAREME INT FOREIGN KEY REFERENCES BAREME(CODEBAREME),
    DATEENVO DATETIME,
    NOM VARCHAR(50),
    GSM VARCHAR(14),
    TEXTEENV VARCHAR(255)
)


insert into Agence values(1,'NOMAGENCE1','EMAILAGENCE1','0600000000','ADRESSEAGENCE1','NOMRESPONSABLE1','TELRESPO1')
insert into Agence values(2,'NOMAGENCE2','EMAILAGENCE2','0600000001','ADRESSEAGENCE2','NOMRESPONSABLE2','TELRESPO2')
insert into Agence values(3,'NOMAGENCE3','EMAILAGENCE3','0600000002','ADRESSEAGENCE3','NOMRESPONSABLE3','TELRESPO3')

insert into CLIENT values('CIN1','NOM1','PRENOM1','0500000000','GSM1','EMAIL1','ADRESSE1','AURESINFOS1','COMPTE1','MOTDEPASSE1')
insert into CLIENT values('CIN2','NOM2','PRENOM2','0500000001','GSM2','EMAIL2','ADRESSE2','AURESINFOS2','COMPTE2','MOTDEPASSE2')
insert into CLIENT values('CIN3','NOM3','PRENOM3','0500000002','GSM3','EMAIL3','ADRESSE3','AURESINFOS3','COMPTE3','MOTDEPASSE3')

insert into COMPTE values(1,1,'CIN1','2020-10-10',100.00)
insert into COMPTE values(2,2,'CIN2','2020-11-11',200.00)
insert into COMPTE values(3,3,'CIN3','2020-12-12',300.00)

insert into TRANSFER values('CODTRANSFER1','CIN1','2020-10-10',100.00,1,'OUI',10.00,10.00,'CINRECP1','NOM_PRENOMRECP1','PAYS1','VILLE1')
insert into TRANSFER values('CODTRANSFER2','CIN2','2020-11-11',200.00,2,'NON',20.00,20.00,'CINRECP2','NOM_PRENOMRECP2','PAYS2','VILLE2')
insert into TRANSFER values('CODTRANSFER3','CIN3','2020-12-12',300.00,3,'OUI',30.00,30.00,'CINRECP3','NOM_PRENOMRECP3','PAYS3','VILLE3')

insert into DESTINATAIRE values(1,'CODTRANSFER1',1,'2020-01-01',100.00)
insert into DESTINATAIRE values(2,'CODTRANSFER2',2,'2020-02-02',200.00)
insert into DESTINATAIRE values(3,'CODTRANSFER3',3,'2020-03-03',300.00)

insert into ESPACECLIENT values(1,'CIN1','2020-04-04','TYPEMSG1','OBJETMSG1','TEXTMSG1','OUI')
insert into ESPACECLIENT values(2,'CIN2','2020-05-05','TYPEMSG2','OBJETMSG2','TEXTMSG2','NON')
insert into ESPACECLIENT values(3,'CIN3','2020-06-06','TYPEMSG3','OBJETMSG3','TEXTMSG3','OUI')

insert into BAREME values(1,'PAYS1',100.00)
insert into BAREME values(2,'PAYS2',200.00)
insert into BAREME values(3,'PAYS3',300.00)

insert into NOTIFICATIONMSGVOCAL values(1,'CODTRANSFER1',1,'2020-06-06','NOM1','GSM1','TEXTEENV1')
insert into NOTIFICATIONMSGVOCAL values(2,'CODTRANSFER2',2,'2020-07-07','NOM2','GSM2','TEXTEENV2')
insert into NOTIFICATIONMSGVOCAL values(3,'CODTRANSFER3',3,'2020-08-08','NOM3','GSM3','TEXTEENV3')


select*from Agence
select*from CLIENT
select*from COMPTE
select*from TRANSFER
select*from DESTINATAIRE
select*from ESPACECLIENT
select*from BAREME
select*from NOTIFICATIONMSGVOCAL

