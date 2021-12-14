create database EFF_2010_TH
use EFF_2010_TH
create table Aeroport(
    IdAeroport int primary key,
    NomAeroport varchar(30),
    NomVilleDesserie varchar(30)
)
create table VOL(
    NumVol int primary key,
    AeroportDepart int foreign key references Aeroport(IdAeroport),
    heurDepart int,
    AeroportArrivee int foreign key references Aeroport(IdAeroport),
    heurArrivee int
)
create table CONSTRUCTEUR(
    IdConstructeur int primary key,
    NomConstructeur varchar(30)
)
create table TYPEE(
    TypeAvion int primary key,
    Capital varchar(30),
    IdConstructeur int foreign key references CONSTRUCTEUR(IdConstructeur)
)
create table AVION(
    NumAvion int primary key,
    TypeAvion int foreign key references TYPEE(TypeAvion),
    BaseAeroport int foreign key references Aeroport(IdAeroport)
)
create table Pilote(
    IdPilote int primary key,
    NomPilote varchar(30),
    PrenomPilote varchar(30)
)
create table AFFECTATION(
    NumVol int foreign key references Vol(NumVol),
    DateVol date,
    NumAvion int foreign key references AVION(NumAvion),
    IdPilote int foreign key references Pilote(IdPilote),
    primary key(NumVol,DateVol)
)

insert into Aeroport values(1,'NomAeroport1','NomVilleDesserie1')
insert into Aeroport values(2,'NomAeroport2','NomVilleDesserie2')
insert into Aeroport values(3,'NomAeroport3','NomVilleDesserie3')

insert into VOL values(1,1,12,2,22)
insert into VOL values(2,2,01,3,9)
insert into VOL values(3,3,16,2,00)

insert into CONSTRUCTEUR values(1,'NomConstructeur1')
insert into CONSTRUCTEUR values(2,'NomConstructeur2')
insert into CONSTRUCTEUR values(3,'NomConstructeur3')

insert into TYPEE values(1,'Capital1',1)
insert into TYPEE values(2,'Capital2',2)
insert into TYPEE values(3,'Capital3',3)

insert into AVION values(1,1,1)
insert into AVION values(2,2,2)
insert into AVION values(3,3,3)

insert into Pilote values(1,'NomPilote1','PrenomPilote1')
insert into Pilote values(2,'NomPilote2','PrenomPilote2')
insert into Pilote values(3,'NomPilote3','PrenomPilote3')

insert into AFFECTATION values(1,'2020-10-10',1,1)
insert into AFFECTATION values(2,'2020-11-11',2,2)
insert into AFFECTATION values(3,'2020-12-12',3,3)



select*from Aeroport
select*from VOL
select*from CONSTRUCTEUR
select*from TYPEE
select*from AVION
select*from AFFECTATION

