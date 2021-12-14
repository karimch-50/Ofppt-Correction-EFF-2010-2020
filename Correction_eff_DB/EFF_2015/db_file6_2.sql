create database EFF2015_TP_V1_1_DB
--remarque ses question et le meme pour EFF2015_TP_V1_2 aussi pour EFF2015_TP_V1_3 
--just la base de donne et different
use EFF2015_TP_V1_1_DB
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
create table Quartie(
    code_quartier int primary key,
    nom_quartier varchar(30), 
    population_quartier int, 
    code_ville int foreign key references Ville(code_ville),
    total_quartier money
)
create table Bien_immobilie(
    code_bien int primary key,
    adresse_bien varchar(30),
    num_enregistremen int,
    superficie int,
    typee varchar(30), 
    code_Quartier int foreign key references Quartie(code_quartier),
    date_construction date
)
create table syndic(
    code_syndic int primary key,
    nom_syndic varchar(30),
    prenom_syndic varchar(30),
    telephone_syndic varchar(30),
    mot_depasse varchar(30)
)
create table Contrat (
    numcontrat int primary key,
    datecontrat date,
    prix_mensuel money,
    code_bien int foreign key references Bien_immobilie(code_bien),
    code_syndic int foreign key references syndic(code_syndic),
    Etat varchar(30)
)

insert into Region values(1,'nom_region1',1000,10)
insert into Region values(2,'nom_region2',2000,20)
insert into Region values(3,'nom_region3',3000,30)

insert into Ville values(1,'nom_ville1',1,10)
insert into Ville values(2,'nom_ville2',2,20)
insert into Ville values(3,'nom_ville3',3,30)

insert into Quartie values(1,'nom_quartier1',100,1,10)
insert into Quartie values(2,'nom_quartier2',200,2,20)
insert into Quartie values(3,'nom_quartier3',300,3,30)

insert into Bien_immobilie values(1,'adresse_bien1',1,100,'typee1',1,'2020-10-10')
insert into Bien_immobilie values(2,'adresse_bien2',2,200,'typee2',2,'2020-11-11')
insert into Bien_immobilie values(3,'adresse_bien3',3,300,'typee3',3,'2020-12-12')

insert into syndic values(1,'nom_syndic1','prenom_syndic1','0600000000','mot_depasse1')
insert into syndic values(2,'nom_syndic2','prenom_syndic2','0600000001','mot_depasse2')
insert into syndic values(3,'nom_syndic3','prenom_syndic3','0600000002','mot_depasse3')

insert into Contrat values(1,'2020-10-10',10,1,1,'Etat1')
insert into Contrat values(2,'2020-11-11',20,2,2,'Etat2')
insert into Contrat values(3,'2020-12-12',30,3,3,'Etat3')


select*from Region
select*from Ville
select*from Quartie
select*from Bien_immobilie
select*from syndic
select*from Contrat





