CREATE DATABASE EFF_PRATIQUE_2015_V2_1
go
USE EFF_PRATIQUE_2015_V2_1

--CREATION DES TABLES :

--Table Abonne
CREATE TABLE Abonne
(
	idAbonne int primary key,
	nomAb varchar(50),
	adresseAb varchar(100),
	TelAb char(12),
	pass  varchar(50)
)
--Table Usage
CREATE TABLE Usage
(
	idUsage int primary key,
	nomUsage varchar(50),
	montantUsage float
)

--Table Abonnement
CREATE TABLE Abonnement
(
	idAbonnement int primary key,
	dateAb date,
	idUsage int references Usage(idUsage),
	idAbonne int references Abonne(idAbonne)
)
--Table Consommation
CREATE TABLE Consommation
(
	idConsommation int primary key identity,
	periode date,
	Qte int,
	idAbonnement int references Abonnement(idAbonnement)
)
--Table Tranches
CREATE TABLE Tranches
(
	NumTranche int primary key identity,
	ValMin int,
	ValMax int,
	PU float
)
--INSERTION DES TRANCHES 
INSERT INTO Tranches(ValMin,ValMax,PU) VALUES(0,100,0.9010)
INSERT INTO Tranches(ValMin,ValMax,PU) VALUES(101,150,0.9689)
INSERT INTO Tranches(ValMin,ValMax,PU) VALUES(151,200,0.9689)
INSERT INTO Tranches(ValMin,ValMax,PU) VALUES(201,300,1.0541)
INSERT INTO Tranches(ValMin,ValMax,PU) VALUES(301,500,1.2474)
INSERT INTO Tranches(ValMin,ValMax,PU) VALUES(501,NULL,1.4407)

--REQUETES TOTAL DE CONSAMMATIONS
--2
SELECT Abonnement.idAbonnement,Abonne.nomAb,SUM(Consommation.Qte)
FROM Abonnement,Abonne,Consommation
WHERE
(
Abonnement.idAbonne=Abonne.idAbonne AND Consommation.idAbonnement=Abonnement.idAbonnement
)
GROUP BY Abonnement.idAbonnement,Abonne.nomAb
--3

CREATE FUNCTION GRANDE_CONSOMMATION(@idAbonnement int)
RETURNS VARCHAR(100)
AS
BEGIN
	declare @RESULTAT varchar(100)
	SET @RESULTAT=
	(
		SELECT YEAR(Consommation.periode)+'  '+MONTH(Consommation.periode)
		FROM Consommation
		WHERE(Consommation.idAbonnement=@idAbonnement)
		GROUP BY Consommation.idAbonnement,Consommation.periode
		having SUM(Consommation.Qte)>=all(select SUM(Consommation.Qte) FROM Consommation WHERE(Consommation.idAbonnement=@idAbonnement) )
		)
	RETURN @RESULTAT
END
-----EXECUTION DU FONCTION
--declare @res varchar(100)
--EXEC @res = dbo.GRANDE_CONSOMMATION 1 
--PRINT @res

--4
CREATE FUNCTION GRANDE_TRANCHE(@idconsommation int)
RETURNS int
AS
BEGIN
RETURN(SELECT CASE 
WHEN Consommation.Qte between TRANCHES.ValMin AND TRANCHES.ValMax
THEN TRANCHES.Numtranche
ELSE
5
END
 FROM TRANCHES,Consommation
 WHERE Consommation.idConsommation=@idconsommation
)

END
--5
CREATE PROCEDURE CONSOMATION_ABONNEE(@idabonne int)
AS
BEGIN
	
SELECT 	*From Consommation
END
SELECT Tranches.NumTranche,Consommation.periode,Consommation.Qte FROM Consommation,Tranches

--6
CREATE TRIGGER QUESTION_6 ON Consommation FOR insert
AS
BEGIN
	declare @mois int
	declare @annee int
	declare @idabonnement int
	SET @mois=(select MONTH(periode) from inserted)
	SET @annee=(select YEAR(periode) from inserted)
	SET @idabonnement=(select idAbonnement from inserted)
	if(EXISTS(SELECT * FROM Consommation WHERE MONTH(Consommation.periode)=@mois AND MONTH(Consommation.periode)=@annee AND idAbonnement=@idabonnement))
	ROLLBACK	
END
