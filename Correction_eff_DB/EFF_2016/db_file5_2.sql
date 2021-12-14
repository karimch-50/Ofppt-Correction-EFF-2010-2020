create database EFF2016_TP_V1_1_DB
--remarque ses question et le meme pour EFF2016_TP_V1_2 
--just la base de donne et different
use EFF2016_TP_V1_1_DB
create table Categorie(
    idCategorie int primary key,
    nomCategorie varchar(30)
)
create table Organisateur(
    idOrg int primary key,
    nomOrm varchar(30),
    prenomOrg varchar(30),
    emailOrg varchar(30),
    passOrg varchar(30)
)
create table Campagne(
    idCamp int primary key,
    nomCamp varchar(30),
    descriptionn varchar(30),
    dateCreation date,
    dateFin date,
    montantCamp float,
    nomBeneficiare varchar(30),
    prenBeneficiare varchar(30),
    dateDernierPart date,
    idCategorie int foreign key references Categorie(idCategorie),
    idOrg int foreign key references Organisateur(idOrg)
)
create table Participant(
    idP int primary key,
    nomP varchar(30),
    prenomP varchar(30),
    emailP varchar(30),
    passP varchar(30)
)
create table Participation(
    idPart int primary key,
    datePartt date,
    montantPart float,
    idCamp int foreign key references Campagne(idCamp),
    idP int foreign key references Participant(idP)
)

insert into Categorie values(1,'nomCategorie1')
insert into Categorie values(2,'nomCategorie2')
insert into Categorie values(3,'nomCategorie3')

insert into Organisateur values(1,'nomOrm1','prenomOrg1','emailOrg1','passOrg1')
insert into Organisateur values(2,'nomOrm2','prenomOrg2','emailOrg2','passOrg2')
insert into Organisateur values(3,'nomOrm3','prenomOrg3','emailOrg3','passOrg3')

insert into Campagne values(1,'nomCamp1','descriptionn1','2020-10-10','2020-10-12',100.00,'nomBeneficiare1','prenBeneficiare1','2020-10-14',1,1)
insert into Campagne values(2,'nomCamp2','descriptionn2','2020-11-10','2020-12-12',200.00,'nomBeneficiare2','prenBeneficiare2','2020-11-14',2,2)
insert into Campagne values(3,'nomCamp3','descriptionn3','2020-12-10','2020-12-13',300.00,'nomBeneficiare3','prenBeneficiare3','2020-12-14',3,3)

insert into Participant values(1,'nomP1','prenomP1','emailP1','passP1')
insert into Participant values(2,'nomP2','prenomP2','emailP2','passP2')
insert into Participant values(3,'nomP3','prenomP3','emailP3','passP3')

insert into Participation values(1,'2020-10-10',10.50,1,1)
insert into Participation values(2,'2020-11-12',20.75,2,2)
insert into Participation values(3,'2020-12-13',30.25,3,3)


select*from Categorie
select*from Organisateur
select*from Campagne
select*from Participant
select*from Participation






