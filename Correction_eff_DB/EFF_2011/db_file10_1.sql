create database EFF_2011_TH
use EFF_2011_TH
create table Satellite(
    code_satellite int primary key,
    nom_satellite varchar(30),
    position_oroitale varchar(30)
)
create table Langue(
    code_langue char(2) primary key,
    nom_langue varchar(30)
)
create table Pays(
    code_pays varchar(3) primary key,
    nom_pays varchar(30)
)
create table chaine(
    code_chaine varchar(30) primary key,
    code_langue char(2) foreign key references Langue(code_langue),
    code_pays varchar(3) foreign key references Pays(code_pays),
    nom_chaine varchar(30),
    date_lancement date,
    cryptee bit
)
create table emettre(
    code_chaine varchar(30) foreign key references chaine(code_chaine),
    code_satellite int foreign key references Satellite(code_satellite),
    frequence int,
    polarisation char(1),
    debit int,
    primary key(code_chaine,code_satellite)
)

insert into Satellite values(1,'nom_satellite1','position_oroitale1')
insert into Satellite values(2,'nom_satellite2','position_oroitale2')
insert into Satellite values(3,'nom_satellite3','position_oroitale3')

insert into Langue values('l1','nom_langue1')
insert into Langue values('l2','nom_langue2')
insert into Langue values('l3','nom_langue3')

insert into Pays values('Cp1','nom_pays1')
insert into Pays values('Cp2','nom_pays2')
insert into Pays values('Cp3','nom_pays3')

insert into chaine values('code_chaine1','l1','Cp1','nom_chaine1','1999-10-10',0)
insert into chaine values('code_chaine2','l2','Cp2','nom_chaine2','2000-12-12',1)
insert into chaine values('code_chaine3','l3','Cp3','nom_chaine3','1998-08-08',0)

insert into emettre values('code_chaine1',1,11250,'H',120)
insert into emettre values('code_chaine2',2,11350,'V',160)
insert into emettre values('code_chaine3',3,11750,'H',180)



select*from Satellite
select*from Langue
select*from Pays
select*from chaine
select*from emettre