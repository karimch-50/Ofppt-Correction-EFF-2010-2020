create database EFF2014_TP_V1_1_DB
--remarque ses question et le meme pour EFF2014_TP_V1_2 aussi pour EFF2014_TP_V1_3 
--just la base de donne et different
use EFF2014_TP_V1_1_DB
create table Region (
    idRegion int primary key,
    nomRegion varchar(30)
) 

create table Academie (
    idAcademie int primary key,
    nomAcademie varchar(30),
    idRegion int foreign key references Region(idRegion)
)
create table Lycee (
    idLycee int primary key, 
    nomLycee varchar(30), 
    ville varchar(30), 
    idAcademie int foreign key references Academie(idAcademie)
)
create table Professeur (
    idProfesseur int primary key, 
    nom varchar(30), 
    prenom varchar(30), 
    dateN date, 
    email varchar(30), 
    pass varchar(30), 
    dateAffLycee date, 
    etatcivil varchar(30),
    nEnfants int,
    idLycee int foreign key references Lycee(idLycee)
)
create table Demande (
    idDemande int primary key, 
    dateDem varchar(30), 
    idprofesseur int foreign key references Professeur(idProfesseur)
)
create table Detail_Demande(
    idDemende int ,
    idLycee int foreign key references Lycee(idLycee),
    numOrdre int,
    primary key(idDemende,idLycee)
)

insert into Region values(1,'nomRegion1')
insert into Region values(2,'nomRegion2')
insert into Region values(3,'nomRegion3')

insert into Academie values(1,'nomAcademie1',1)
insert into Academie values(2,'nomAcademie2',2)
insert into Academie values(3,'nomAcademie3',3)

insert into Lycee values(1,'nomLycee1','ville1',1)
insert into Lycee values(2,'nomLycee2','ville2',2)
insert into Lycee values(3,'nomLycee3','ville3',3)

insert into Professeur values(1,'nom1','prenom1','2020-10-10','email1','pass1','2020-01-01','etatcivil1',1,1)
insert into Professeur values(2,'nom2','prenom2','2020-11-11','email2','pass2','2020-01-10','etatcivil2',2,2)
insert into Professeur values(3,'nom3','prenom3','2020-12-12','email3','pass3','2020-01-20','etatcivil3',3,3)

insert into Demande values(1,'2020-05-01',1)
insert into Demande values(2,'2020-05-05',2)
insert into Demande values(3,'2020-05-10',3)

insert into Detail_Demande values(1,1,10)
insert into Detail_Demande values(2,2,20)
insert into Detail_Demande values(3,3,30)



select*from Region
select*from Academie
select*from Lycee
select*from Professeur
select*from Demande
select*from Detail_Demande




