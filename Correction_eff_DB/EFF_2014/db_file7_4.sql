create database EFF2014_TP_V3_1_DB
--remarque ses question et le meme pour EFF2014_TP_V3_2 est EFF2014_TP_V3_3 
--just la base de donne et different
use EFF2014_TP_V3_1_DB
create table Entreprise(
    num_entreprise int primary key,
    nom_entreprise varchar(30),
    adresse varchar(30),
    telephone varchar(30),
    nombre_employé int,
    email varchar(30)
)
create table Assure(
    matricule varchar(30) primary key,
    nom_ass varchar(30),
    prenom_ass varchar(30),
    date_naissance date, 
    nb_enfant int,
    sitrration_familiale varchar(30),
    num_entreprise int foreign key references Entreprise(num_entreprise),
    total_remb int,
    date_deces date,
    mot_depasse varchar(30)
)
create table Maladie(
    num_maladie int primary key, 
    designation_maladie varchar(30)
)
create table Dossier(
    numdossier int primary key, 
    datedepot date, 
    montant_remboursement float,
    date_traitement date,
    lien_malade varchar(30), 
    matricule varchar(30) foreign key references Assure(matricule),
    num_maladie int foreign key references Dossier(numdossier),
    total_dossier varchar(30)
)
create table Rubrique(
    numrubrique int primary key,
    nom_rubrique varchar(30),
    numdossier int foreign key references Dossier(numdossier),
    montant_rubrique float
)

insert into Entreprise values(1,'nom_entreprise1','adresse1','0600000001',1,'email1')
insert into Entreprise values(2,'nom_entreprise2','adresse2','0600000002',2,'email2')
insert into Entreprise values(3,'nom_entreprise3','adresse3','0600000003',3,'email3')

insert into Assure values('matricule1','nom_ass1','prenom_ass1','2020-10-10',1,'sitrration_familiale1',1,1,'2020-12-01','mot_depasse1')
insert into Assure values('matricule2','nom_ass2','prenom_ass2','2020-10-11',2,'sitrration_familiale2',2,2,'2020-12-10','mot_depasse2')
insert into Assure values('matricule3','nom_ass3','prenom_ass3','2020-10-12',3,'sitrration_familiale3',3,3,'2020-12-21','mot_depasse3')

insert into Maladie values(1,'designation_maladie1')
insert into Maladie values(2,'designation_maladie2')
insert into Maladie values(3,'designation_maladie3')

insert into Dossier values(1,'2020-10-10',10.00,'2020-10-11','lien_malade1','matricule1',1,'total_dossier1')
insert into Dossier values(2,'2020-10-11',20.00,'2020-10-12','lien_malade2','matricule2',2,'total_dossier2')
insert into Dossier values(3,'2020-10-12',30.00,'2020-10-13','lien_malade3','matricule3',3,'total_dossier3')

insert into Rubrique values(1,'nom_rubrique1',1,100.00)
insert into Rubrique values(2,'nom_rubrique2',2,200.00)
insert into Rubrique values(3,'nom_rubrique3',3,300.00)



select*from Entreprise
select*from Assure
select*from Maladie
select*from Dossier
select*from Rubrique


