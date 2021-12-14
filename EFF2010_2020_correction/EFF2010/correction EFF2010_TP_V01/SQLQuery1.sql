create database EFF2010_TP_V01
use EFF2010_TP_V01
create table Specialite(
IdSpecialite int primary key,
libelle varchar(30)
)
create table Patient(
IdPatient int primary key,
Nom varchar(30),
Prenom varchar(30),
DdN varchar(30),
Sexe varchar(30),
Adresse varchar(50)
)
create table Hopital(
IdHopital int primary key,
Nom varchar(30),
Adresse varchar(30),
Ville varchar(30)
)
create table Servicee(
IdService int primary key,
IdHospital int foreign key references Hopital(IdHopital),
NBLits varchar(30)
)
create table Sejourne(
IdSejour int primary key,
IdService int foreign key references Servicee(IdService),
IdPatient int foreign key references Patient(IdPatient),
DateEntree date,
DateSortie date
)
create table Medecin(
IdMedecin int primary key,
Nom varchar(30),
Prenom varchar(30),
DdN varchar(30),
Sexe varchar(30),
IdSpecialite int foreign key references Specialite(IdSpecialite),
IdService int foreign key references Servicee(IdService)
)
create table Soigne(
IdSoin int primary key,
IdMedecin int foreign key references Medecin(IdMedecin),
IdPatient int foreign key references Patient(IdPatient),
nommaladie varchar(30),
Commentare varchar(30),
Date_soigne date
)


SELECT * FROM Specialite
SELECT * FROM Patient
SELECT * FROM Hopital
SELECT * FROM Servicee
SELECT * FROM Sejourne
SELECT * FROM Medecin

SELECT * FROM Soigne

INSERT INTO Specialite VALUES (1,'L1')
INSERT INTO Specialite VALUES (2,'L2')

INSERT INTO Patient VALUES (1,'pN1','pP1','2011-06-01','M','pAdresse1')
INSERT INTO Patient VALUES (2,'pN2','pP2','2011-06-02','F','pAdresse2')

INSERT INTO Hopital VALUES (1,'hN1','hAdresse1','hV1')
INSERT INTO Hopital VALUES (2,'hN2','hAdresse2','hV2')

INSERT INTO Servicee VALUES (1,1,20)
INSERT INTO Servicee VALUES (2,2,40)

INSERT INTO Sejourne VALUES (1,1,1,'2018-02-17','2020-09-10')
INSERT INTO Sejourne VALUES (2,2,2,'2016-08-11','2017-01-16')

INSERT INTO Medecin VALUES (1,'mN1','mP1','1990-11-27','M',1,1)
INSERT INTO Medecin VALUES (2,'mN2','mP1','1989-03-17','F',2,2)

INSERT INTO Soigne VALUES (1,1,1,'sM1','sC1','2016-08-11')
INSERT INTO Soigne VALUES (2,2,2,'sM2','sC2','2018-10-01')

go
create procedure p1
as
begin
select count(p.IdPatient) from Patient P,Sejourne S where P.IdPatient=S.IdPatient
end

go
create procedure p2 @DateEntree date,@DateSortie date
as
begin
select M.Nom,P.Nom from Sejourne S1,Patient P,Medecin M ,Servicee S2 where S1.IdPatient=P.IdPatient and S1.IdService=S2.IdService and S2.IdService=M.IdService and S1.DateEntree=@DateEntree and S1.DateSortie=@DateSortie
end

go
create procedure p3 
as
begin
select P.Nom,P.Prenom,P.IdPatient 
from Specialite SP1,Specialite SP2,Patient P,Medecin M1,Sejourne S 
where P.IdPatient=S.IdPatient and SP1.IdSpecialite=M1.IdSpecialite 
end

go 
create trigger T1
on Medecin
for insert,update
as
begin
if exists( select*from inserted)
begin
update Medecin 
set DdN=replace(format((select DdN from inserted),'05 ##-##-##-##'),'-','.')
end
end


select H.Nom,count(S.NBLits),count(M.IdMedecin),S.IdService from Servicee S,Hopital H,Medecin M where S.IdService=M.IdService and H.IdHopital=M.IdService and H.Nom =(select Nom from Hopital where IdHopital=1) group by S.IdService,H.Nom
select P.* from Sejourne S,Patient p where S.IdPatient=P.IdPatient and DateSortie=