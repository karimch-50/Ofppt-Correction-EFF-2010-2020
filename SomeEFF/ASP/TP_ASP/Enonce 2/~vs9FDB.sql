create database Stg 
use Stg 
create table Stagiaire (
idstg int primary key,
nom varchar(30),
prenom varchar(30),
datenaiss date
)
create table Module(
idmod int primary key,
nom varchar(30),
Masshor int
)
create table Note(
idstg int foreign key references Stagiaire(idstg),
idmod int foreign key references Module(idmod),
note float
)

insert into Stagiaire values(1,'nom1','prenom1','2000-12-12')

insert into Module values(1,'nom1',100)

insert into Note values(1,1,17.5)

select*from Stagiaire
select*from Module
select*from Note

