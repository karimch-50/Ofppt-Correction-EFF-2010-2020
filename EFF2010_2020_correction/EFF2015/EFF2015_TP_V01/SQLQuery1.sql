create database EFF2015_TP_V01_DB
use EFF2015_TP_V01_DB
create table Syndic(
code_syndic int primary key,
nom_syndic varchar(30),
prenom_syndic varchar(30),
telephone_syndic varchar(30),
mot_depasse varchar(30)
)
create table Region(
code_region int primary key,
nom_region varchar(30),
population_region int,
total_region money
)
create table Ville(
code_ville int primary key,
nom_ville varchar(30),
code_region int foreign key references Region(code_region),
total_ville money
)
create table Quartier(
code_quartier int primary key,
nom_quartier varchar(30),
population_quartier int,
code_ville int foreign key references Ville(code_ville),
total_quartier money
)
create table Bien_immobilier(
code_bien int primary key,
adresse_bien varchar(30),
num_enregistremen int,
superficie int,
typee varchar(30),
code_Quartier int foreign key references Quartier(code_Quartier),
date_construction date
)
create table Contrat(
numcontrat int primary key,
datecontrat date,
prix_mensuel money,
code_bien int foreign key references Bien_immobilier(code_bien),
code_syndic int foreign key references Syndic(code_syndic),
etat varchar(30)
)

insert into Syndic values(1,'nom_syndic1','prenom_syndic1','0600000000','mot_depasse1')
insert into Syndic values(2,'nom_syndic2','prenom_syndic2','0600000001','mot_depasse2')
insert into Syndic values(3,'nom_syndic3','prenom_syndic3','0600000002','mot_depasse3')

insert into Region values(1,'nom_region1',2000,100)
insert into Region values(2,'nom_region2',3000,200)
insert into Region values(3,'nom_region3',4000,300)

insert into Ville values(1,'nom_ville1',1,10)
insert into Ville values(2,'nom_ville2',2,20)
insert into Ville values(3,'nom_ville3',3,30)

insert into Quartier values(1,'nom_quartier1',1,1,1000)
insert into Quartier values(2,'nom_quartier2',2,2,2000)
insert into Quartier values(3,'nom_quartier3',3,3,3000)

insert into Bien_immobilier values(1,'adresse_bien1',1,1,'typee1',1,'2020-10-10')
insert into Bien_immobilier values(2,'adresse_bien2',2,2,'typee2',2,'2020-11-10')
insert into Bien_immobilier values(3,'adresse_bien3',3,3,'typee3',3,'2020-12-10')

insert into Contrat values(1,'2020-11-10',100,1,1,'etat1')
insert into Contrat values(2,'2020-12-10',200,2,2,'etat2')
insert into Contrat values(3,'2021-01-10',300,3,3,'etat3')

select*from Syndic
select*from Region
select*from Ville
select*from Quartier
select*from Bien_immobilier
select*from Contrat

