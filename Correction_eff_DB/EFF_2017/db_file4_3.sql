create database EFF2017_TP_V2_1_DB
--remarque ses question et le meme pour EFF2017_TP_V2_2 
--just la base de donne et different
use EFF2017_TP_V2_1_DB
create table Domaine(
    num_domaine int primary key,
    nom_domaine varchar(30),
    motedepasse varchar(30)
)
create table Invention(
    num_invention int primary key,
    descriptif varchar(30),
    resumee varchar(30),
    num_domaine int foreign key references Domaine(num_domaine)
)
create table Etreprise(
    num_entreprise int primary key,
    nom_entreprise varchar(30),
    activite varchar(30),
    CA int,
    adresse varchar(30),
)
create table Inventeur(
    num_Inventeur int primary key,
    nom varchar(30),
    prenom varchar(30),
    adresse varchar(30),
    date_naiss date,
    age int,
    num_entreprise int foreign key references Etreprise(num_entreprise)
)
create table Brevet(
    num_Brevet int primary key,
    descriptionn varchar(30),
    date_depot date,
    date_validation date,
    Num_inventeur int foreign key references Inventeur(num_Inventeur),
    Num_invention int foreign key references Invention(num_invention)
)

insert into Domaine values(1,'nom_domaine1','motedepasse1')
insert into Domaine values(2,'nom_domaine2','motedepasse2')
insert into Domaine values(3,'nom_domaine3','motedepasse3')

insert into Invention values(1,'descriptif1','resumee1',1)
insert into Invention values(2,'descriptif2','resumee2',2)
insert into Invention values(3,'descriptif3','resumee3',3)

insert into Etreprise values(1,'nom_entreprise1','activite1',1,'adresse1')
insert into Etreprise values(2,'nom_entreprise2','activite2',2,'adresse2')
insert into Etreprise values(3,'nom_entreprise3','activite3',3,'adresse3')

insert into Inventeur values(1,'nom1','prenom1','adresse1','2020-10-10',36,1)
insert into Inventeur values(2,'nom2','prenom2','adresse2','2020-08-10',40,2)
insert into Inventeur values(3,'nom3','prenom3','adresse3','2020-12-10',42,3)

insert into Brevet values(1,'descriptionn1','2020-08-10','2020-10-12',1,1)
insert into Brevet values(2,'descriptionn2','2020-10-10','2020-11-12',2,3)
insert into Brevet values(3,'descriptionn3','2020-12-10','2020-12-22',3,3)


select*from Domaine
select*from Invention
select*from Etreprise
select*from Inventeur
select*from Brevet

