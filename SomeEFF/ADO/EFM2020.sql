create database BD_VISA_EFF2020
use BD_VISA_EFF2020
create table Demandeur(
    num_d int primary key,
    nom_d varchar(20),
    prenom_d varchar(20),
    nationalite varchar(20),
    pays_d varchar(20),
    adresse varchar(30),
    tel int,
    etat_civil varchar(20),
    sexe varchar(10)
    )
create table Document_voyage(
    id_document int primary key,
    DateExpiration date,
    dateDelivrance date,
    delivrePar varchar(20),
    lieu varchar(20),
    type_d varchar(30) 
    CHECK (type_d in ('Passeport diplomatique','passeport de service','passeport officiel','passeport special')),
    num_d int foreign key references Demandeur(num_d)
)
create table Demande_Visa(
    idDemande int primary key,
    dateDemande date,
    etat varchar(10)
    CHECK(etat in ('en cours','refuse','accorde')),
    motif varchar(20) CHECK (motif in ('Activite professionnelle','etude','stage/formation','mariage')),
    dateDebutPrevu date,
    dureePrevu int,
    dateTraitementDemande date
)
create table Agent(
    numAgent int primary key,
    nom varchar(20),
    prenom varchar(20),
    adresse varchar(20)
)
create table Traitement_demande(
    idDemande int FOREIGN key REFERENCES Demande_Visa(idDemande),
    idAgent int FOREIGN key references Agent (numAgent),
     PRIMARY key (idDemande,idAgent)
)

insert into Demandeur values (1,'N1','P1','NA1','P1','ADR1',0600000000,'EC1','S1')
insert into Demandeur values (2,'N2','P2','NA2','P2','ADR2',0600000001,'EC2','S2')
insert into Demandeur values (3,'N3','P3','NA3','P3','ADR3',0600000002,'EC3','S3')

select*from Demandeur

insert into Agent values(1,'N1','p1','adr1')
insert into Agent values(2,'N2','p2','adr2')
insert into Agent values(3,'N3','p3','adr3')
insert into Agent values(4,'N4','p4','adr4')

select*from Agent
select*from Agent where nom='N1'