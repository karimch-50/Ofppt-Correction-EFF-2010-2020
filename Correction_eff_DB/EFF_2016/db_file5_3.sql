create database EFF2016_TP_V2_1_DB
--remarque ses question et le meme pour EFF2016_TP_V2_2 
--just la base de donne et different
use EFF2016_TP_V2_1_DB
create table Type_app(
    num_type int primary key,
    nom_type varchar(30),
    nb_appareils int,
    motdepasse varchar(30)
)
create table Appareil(
    num_apparaeil int primary key,
    nom_apparaeil varchar(30),
    date_achat date,
    prix_achat float,
    nb_contrat int,
    num_type int foreign key references Type_app(num_type),
)
create table contrat(
    num_police int primary key,
    date_contrat date,
    date_fin_contrat date,
    montant_contrat float,
    num_appareil int foreign key references Appareil(num_apparaeil),
    nb_rubriques int
)
create table Rubrique(
    num_rubrique int primary key,
    nom_rubrique varchar(30),
    prix_rubrique float,
    num_contrat  int foreign key references contrat(num_police)
)
create table Societe(
    num_societe int primary key,
    num_registrecommerce int,
    nom_societe varchar(30),
    adresse varchar(30),
    telephone_societe bigint,
)
create table Client(
    num_client int primary key,
    nom varchar(30),
    prenom varchar(30),
    email varchar(30),
    adresse varchar(30),
    telephone bigint,
    nb_contrats int,
    num_societe int foreign key references Societe(num_societe),
)

insert into Type_app values(1,'nom_type1',10,'motdepasse1')
insert into Type_app values(2,'nom_type2',20,'motdepasse2')
insert into Type_app values(3,'nom_type3',30,'motdepasse3')

insert into Appareil values(1,'nom_apparaeil1','2020-10-10',200.00,100,1)
insert into Appareil values(2,'nom_apparaeil2','2020-11-11',400.00,200,2)
insert into Appareil values(3,'nom_apparaeil3','2020-12-12',600.00,300,3)

insert into contrat values(1,'2020-10-10','2021-10-10',100.00,1,10)
insert into contrat values(2,'2020-11-11','2021-11-11',200.00,2,20)
insert into contrat values(3,'2020-12-12','2021-12-12',300.00,3,30)

insert into Rubrique values(1,'nom_rubrique1',100.00,1)
insert into Rubrique values(2,'nom_rubrique2',200.00,2)
insert into Rubrique values(3,'nom_rubrique3',300.00,3)

insert into Societe values(1,1,'nom_societe1','adresse1',0600000000)
insert into Societe values(2,2,'nom_societe2','adresse2',0600000001)
insert into Societe values(3,3,'nom_societe3','adresse3',0600000002)

insert into Client values(1,'nom1','prenom1','email1','adresse1',060000000,100,1)
insert into Client values(2,'nom2','prenom2','email2','adresse2',060000001,200,1)
insert into Client values(3,'nom3','prenom3','email3','adresse3',060000002,300,2)


select*from Type_app
select*from Appareil
select*from contrat
select*from Rubrique
select*from Societe
select*from Client


