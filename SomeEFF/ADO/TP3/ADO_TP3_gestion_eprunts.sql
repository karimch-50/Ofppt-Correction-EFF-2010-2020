create database ADO_TP3_gestion_eprunts
use ADO_TP3_gestion_eprunts
create table emprunteur(
cin varchar(30) primary key,
tele int,
adresse varchar(30),
email varchar(30)
)
create table document(
numExemplaire int primary key,
numISBN int,
Nom_Auteur varchar(30),
DataAchat date
)
create table emprunt(
num int primary key,
cin varchar(30) foreign key references emprunteur(cin),
numExemplaire int foreign key references document(numExemplaire),
dateDebut date,
dateFin date,
retour varchar(30)
)

insert into emprunteur values ('AA000000',0600000000,'ADR1','email1@email.com')
insert into emprunteur values ('AA000001',0600000001,'ADR2','email2@email.com')
insert into emprunteur values ('AA000002',0600000002,'ADR3','email3@email.com')

insert into document values (1,1,1,'2021/01/01')
insert into document values (2,2,2,'2021/01/02')
insert into document values (3,3,3,'2021/01/03')

insert into emprunt values (1,'AA000000',1,'2021/01/01','2021/03/01')
insert into emprunt values (2,'AA000001',2,'2021/01/02','2021/03/02')
insert into emprunt values (3,'AA000002',3,'2021/01/03','2021/03/03')