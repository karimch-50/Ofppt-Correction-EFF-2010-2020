create database EFF2010_TP_V1_1_DB
--remarque ses question et le meme pour EFF2010_TP_V1_2 aussi pour EFF2010_TP_V1_3 
--just la base de donne et different
use EFF2010_TP_V1_1_DB
create table Specialite(
    IdSpecialite int primary key,
    libelle varchar(30)
)
create table Hopital(
    IdHopital int primary key,
    Nom varchar(30),
    Adresse varchar(30),
    Ville varchar(30)
)
create table Service(
    IdService int primary key,
    IdHopital int foreign key references Hopital(IdHopital),
    NbLits int
)
create table Medecin(
    IdMedecin int primary key,
    Nom varchar(30),
    Prenom varchar(30),
    DdN varchar(30),
    Sexe char(1),
    IdSpecialite int foreign key references Specialite(IdSpecialite),
    IdService int foreign key references Service(IdService),
)
create table Patient(
    IdPatient int primary key,
    Nom varchar(30),
    Prenom varchar(30),
    DdN varchar(30),
    Sexe char(1),
    Adresse varchar(30)
)
create table Sejourne(
    IdSejour int primary key,
    IdService int foreign key references Service(IdService),
    IdPatient int foreign key references Patient(IdPatient),
    DateEntree date,
    DateSortie date
)
create table Soigne(
    IdSoin int primary key,
    IdMedecin int foreign key references Medecin(IdMedecin),
    IdPatient int foreign key references Patient(IdPatient),
    nommaladie varchar(30),
    Commentaire varchar(30),
    Date_soigne date
)


insert into Specialite values(1,'libelle1')
insert into Specialite values(2,'libelle2')
insert into Specialite values(3,'libelle3')

insert into Hopital values(1,'Nom1','Adresse1','Ville1')
insert into Hopital values(2,'Nom2','Adresse2','Ville2')
insert into Hopital values(3,'Nom3','Adresse3','Ville3')

insert into Service values(1,1,10)
insert into Service values(2,2,20)
insert into Service values(3,3,30)

insert into Medecin values(1,'Nom1','Prenom1','DdN1','M',1,1)
insert into Medecin values(2,'Nom2','Prenom2','DdN2','F',2,2)
insert into Medecin values(3,'Nom3','Prenom3','DdN3','M',3,3)

insert into Patient values(1,'Nom1','Prenom1','DdN1','M','Adresse1')
insert into Patient values(2,'Nom2','Prenom2','DdN2','F','Adresse2')
insert into Patient values(3,'Nom3','Prenom3','DdN3','M','Adresse3')

insert into Sejourne values(1,1,1,'2020-10-10','2020-10-15')
insert into Sejourne values(2,2,2,'2020-10-15','2020-10-20')
insert into Sejourne values(3,3,3,'2020-10-20','2020-10-25')

insert into Soigne values(1,1,1,'nommaladie1','Commentaire1','2020-11-10')
insert into Soigne values(2,2,2,'nommaladie2','Commentaire2','2020-11-30')
insert into Soigne values(3,3,3,'nommaladie3','Commentaire3','2020-12-10')


select*from Specialite
select*from Hopital
select*from Service
select*from Medecin
select*from Patient
select*from Sejourne
select*from Soigne




