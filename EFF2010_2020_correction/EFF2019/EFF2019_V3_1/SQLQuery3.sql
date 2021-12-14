create database EFF2019_V3_1
use EFF2019_V3_1
create table Palente(
NumP int primary key,
nomP varchar(30),
origine varchar(30),
prix float,
)
create table Jardinier(
NumJardinier int primary key,
NomJardinier varchar(30),
PrenomJardinier varchar(30),
date_embauche date,
loginn varchar(30) unique,
mdp varchar(30),
)
create table Jardin(
NumJ int primary key,
nomJardin varchar(30),
adresse varchar(30),
ville varchar(30),
superficie varchar(30),
jardinier int foreign key references Jardinier(NumJardinier)
)
create table Contenu(
idContenu int primary key identity,
Jardin int foreign key references Jardin(NumJ),
plant int foreign key references Palente(NumP),
quantite int,
date_plantation date
)

insert into Palente values(1,'nomP1','origine1',200.50)
insert into Palente values(2,'nomP2','origine2',100.75)
insert into Palente values(3,'nomP3','origine3',50.25)

insert into Jardinier values(1,'NomJardinier1','PrenomJardinier1','2020-12-12','loginn1','mdp1')
insert into Jardinier values(2,'NomJardinier3','PrenomJardinier2','2020-10-10','loginn2','mdp2')
insert into Jardinier values(3,'NomJardinier3','PrenomJardinier3','2020-11-11','loginn3','mdp3')

insert into Jardin values(1,'nomJardin1','adresse1','ville1','superficie1',1)
insert into Jardin values(2,'nomJardin2','adresse2','ville2','superficie2',2)
insert into Jardin values(3,'nomJardin3','adresse3','ville3','superficie3',3)

insert into Contenu values(1,1,20,'2020-12-20')
insert into Contenu values(2,2,10,'2020-05-01')
insert into Contenu values(3,3,50,'2020-01-01')

select*from Palente
select*from Jardinier
select*from Jardin
select*from Contenu
