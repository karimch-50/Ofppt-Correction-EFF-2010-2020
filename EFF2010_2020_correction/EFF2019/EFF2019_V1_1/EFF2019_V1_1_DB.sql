create database EFF2019_V1_1
use EFF2019_V1_1
create table Ville(
Id_Ville int primary key,
Nom_Ville varchar(30),
Pays varchar(30)
)
create table Volontaire(
Id_Vlt int primary key,
Nom_Vlt varchar(30),
Prenom_Vlt varchar(30),
Mail varchar(30),
Mot_Passe varchar(30),
Id_Ville int foreign key references Ville(Id_Ville),
Actif bit,
)

update Association set Nom_Ass='',RaisonSocial='',Adresse='',Telephone='',Id_Ville= where Id_Ass=
create table Association(
Id_Ass int primary key,
Nom_Ass varchar(30),
RaisonSocial varchar(30),
Adresse varchar(30),
Telephone varchar(10),
Id_Ville int foreign key references Ville(Id_Ville),
)
create table Stage(
Id_Stage int primary key,
Date_Debut date,
date_Fin date,
Id_Association int foreign key references Association(Id_Ass),
)
create table Demende_Inscription(
Id_Inscription int primary key,
date_Demende date,
Id_Volentaire int foreign key references Volontaire(Id_Vlt),
Id_Stage int foreign key references Stage(Id_Stage),
Etat varchar(30),
)

insert into Ville values(1,'V1','P1')
insert into Ville values(2,'V2','P2')
insert into Ville values(3,'V3','P3')

insert into Volontaire values(1,'NV1','PV1','Mail1','Password1',1,0)
insert into Volontaire values(2,'NV2','PV2','Mail2','Password2',2,1)
insert into Volontaire values(3,'NV3','PV3','Mail3','Password3',3,0)

insert into Association values(1,'NA1','RaisonSocial1','Adresse1','0600000000',1)
insert into Association values(2,'NA2','RaisonSocial2','Adresse2','0600000001',2)
insert into Association values(3,'NA3','RaisonSocial3','Adresse3','0600000002',3)

insert into Stage values(1,'2020-12-12','2021-01-12',1)
insert into Stage values(2,'2021-02-19','2021-03-19',2)
insert into Stage values(3,'2021-03-01','2021-04-01',3)

insert into Demende_Inscription values(1,'2020-10-10',1,1,'Etat1')
insert into Demende_Inscription values(2,'2020-12-22',2,2,'Etat2')
insert into Demende_Inscription values(3,'2021-01-01',3,3,'Etat3')

select*from Ville
select*from Volontaire
select*from Association
select*from Stage
select*from Demende_Inscription