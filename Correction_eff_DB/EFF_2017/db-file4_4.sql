create database EFF2017_TP_V3_1_DB
--remarque ses question et le meme pour EFF2017_TP_V3_2 
--just la base de donne et different
use EFF2017_TP_V3_1_DB
use master
drop database EFF2017_TP_V3_1_DB
create table Specialite (
    idS int primary key,
    nomS varchar(30),
    niveau varchar(30)
)
create table Classe(
    idC int primary key,
    nomC varchar(30),
    annee int,
    idS int foreign key references Specialite(idS)
)
create table Matiere(
    idMat int primary key,
    nomMat varchar(30),
    objectMat varchar(30),
    MH int,
    idS int foreign key references Specialite(idS)
) 
create table EnseignantVacataire(
    idEV int primary key,
    nomEV varchar(30),
    prenEV varchar(30),
    nHeure int,
    prixHeure float,
    mPasse varchar(30)
)
create table Affectation(
    idAff int primary key identity,
    dateAff date,
    NbreHeure int,
    idEV int foreign key references EnseignantVacataire(idEV),
    idMat int foreign key references Matiere(idMat),
    idC int foreign key references Classe(idC),
)

insert into Specialite values(1,'nomS1','niveau1')
insert into Specialite values(2,'nomS2','niveau2')
insert into Specialite values(3,'nomS3','niveau3')

insert into Classe values(1,'nomC1',2020,1)
insert into Classe values(2,'nomC2',2018,2)
insert into Classe values(3,'nomC3',2019,3)

insert into Matiere values(1,'nomMat1','objectMat1',12,1)
insert into Matiere values(2,'nomMat2','objectMat2',10,2)
insert into Matiere values(3,'nomMat3','objectMat3',8,3)

insert EnseignantVacataire values(1,'nomEV1','prenEV1',10,100,'mPasse1')
insert EnseignantVacataire values(2,'nomEV2','prenEV2',20,100,'mPasse2')
insert EnseignantVacataire values(3,'nomEV3','prenEV3',30,100,'mPasse3')

insert into Affectation values('2020-10-10',10,1,1,1)
insert into Affectation values('2020-08-10',20,2,2,2)
insert into Affectation values('2020-12-10',30,3,3,3)

select*from Specialite
select*from Classe
select*from Matiere
select*from EnseignantVacataire
select*from Affectation




