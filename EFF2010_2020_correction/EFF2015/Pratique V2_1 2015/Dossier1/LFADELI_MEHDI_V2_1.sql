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