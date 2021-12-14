create database EFF2012_TP_V2_1_DB
--remarque ses question et le meme pour EFF2012_TP_V2_2 aussi pour EFF2012_TP_V2_3 
--just la base de donne et different
use EFF2012_TP_V2_1_DB
create table Modele(
    Id_Modele int primary key,
    Libelle_Modele varchar(30)
)
create table Piece(
    ID_Piece int primary key,
    Libelle_Piece varchar(30),
    Id_modele int foreign key references Modele(Id_Modele),
)
create table Etat(
    ID_Etat int primary key,
    Libelle_Etat varchar(30)
)
create table Lot(
    Id_Lot int primary key,
    Libelle_Lot varchar(30),
    Date_Achat date,
    Prix_achat float,
)
create table Materiel(
    ID_Mat int primary key,
    Description_Mat varchar(30),
    [NSerie] int,
    id_Modele int foreign key references Modele(Id_Modele),
    Prix_achat money,
    ID_Lot int foreign key references Lot(Id_Lot),
    ID_Etat int foreign key references Etat(ID_Etat),
)
create table Reparation(
    ID_Reparation int primary key,
    ID_Priece int,
    ID_Mat int,
    date_Envoi_Reparation date,
    date_Reroure_Reparation date,
    Montant_Reparation float,
    Observation_Reparation  varchar(30)
)

insert into Modele values(1,'Libelle_Modele1')
insert into Modele values(2,'Libelle_Modele2')
insert into Modele values(3,'Libelle_Modele3')

insert into Piece values(1,'Libelle_Piece1',1)
insert into Piece values(2,'Libelle_Piece2',2)
insert into Piece values(3,'Libelle_Piece3',3)

insert into Etat values(1,'Libelle_Etat1')
insert into Etat values(2,'Libelle_Etat2')
insert into Etat values(3,'Libelle_Etat3')

insert into Lot values(1,'Libelle_Lot1','2020-10-10',100.00)
insert into Lot values(2,'Libelle_Lot2','2020-11-11',200.00)
insert into Lot values(3,'Libelle_Lot3','2020-12-12',300.00)

insert into Materiel values(1,'Description_Mat1',1,1,10.00,1,1)
insert into Materiel values(2,'Description_Mat2',2,2,20.00,2,2)
insert into Materiel values(3,'Description_Mat3',3,3,30.00,3,3)

insert into Reparation values(1,1,1,'2020-11-11','2020-11-22',1000.00,'Observation_Reparation1')
insert into Reparation values(2,2,3,'2020-12-11','2020-12-22',2000.00,'Observation_Reparation2')
insert into Reparation values(3,3,4,'2021-01-11','2021-01-22',3000.00,'Observation_Reparation3')


select*from Modele
select*from Piece
select*from Etat
select*from Lot
select*from Materiel
select*from Reparation


