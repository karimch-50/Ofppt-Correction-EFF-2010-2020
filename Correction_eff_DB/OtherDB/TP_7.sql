create database TP_7
use TP_7
create table Personne (
nas int primary key,
nom varchar(30),
villeP varchar(30)
)
create table Voiture (
imma varchar(30) primary key,
modele varchar(30),
annee date,
nas int foreign key references Personne(nas)
)
create table Accident (
dateAc date,
nas int foreign key references Personne(nas),
imma varchar(30) foreign key references Voiture(imma),
dommages varchar(30),
villeAc varchar(30)
) 
insert into Personne values(1,'ahmed','casa')
insert into Personne values(2,'khalid','rabat')
insert into Voiture values('55e','modele1','22/3/2019',1)
insert into Voiture values('99f','modele2','27/4/2019',2)
insert into Accident values('10/7/2020',1,'55e','waiv','taza')
insert into Accident values('17/11/2020',2,'99f','eufw','tanger')
