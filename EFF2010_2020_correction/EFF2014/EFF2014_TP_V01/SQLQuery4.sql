create database EFF2014_TP_V01
use EFF2014_TP_V01
create table Regoin(
IdRegion int primary key,
nomRegion varchar(30)
)
create table Academie(
idAcademie int primary key,
nomAcademie varchar(30),
IdRegion int foreign key references Regoin(IdRegion)
)
create table Lycee(
idLycee int primary key,
nomLycee varchar(30),
ville varchar(30),
idAcademie int foreign key references Academie(idAcademie)
)
create table Professeur(
idProfesseur int primary key,
nom varchar(30),
prenom varchar(30),
dateN date,
email varchar(30),
pass varchar(30),
dateAffLycee date,
etatCivi varchar(30),
nEfants int,
idLycee int foreign key references Lycee(idLycee)
)
create table Demande(
idDemande int primary key identity,
dateDem date,
idProfesseur int foreign key references Professeur(idProfesseur)
)
create table Detail_Demande(
idDemande int foreign key references Demande(idDemande),
idLycee int foreign key references Lycee(idLycee),
numOrder int,
primary key(idDemande,idLycee)
)

insert into Regoin values(1,'NR1')
insert into Regoin values(2,'NR2')
insert into Regoin values(3,'NR3')

insert into Academie values(1,'NA1',1)
insert into Academie values(2,'NA2',2)
insert into Academie values(3,'NA3',3)

insert into Lycee values(1,'NL1','V1',1)
insert into Lycee values(2,'NL2','V2',2)
insert into Lycee values(3,'NL3','V3',3)

insert into Professeur values(1,'N1','P1','2020/10/10','exemple1@exemple.com','pass1','2020/11/11','EC1',1,1)
insert into Professeur values(2,'N2','P2','2020/10/10','exemple2@exemple.com','pass2','2020/11/11','EC2',2,2)
insert into Professeur values(3,'N3','P3','2020/10/10','exemple3@exemple.com','pass3','2020/11/11','EC3',3,3)

insert into Demande(dateDem,idProfesseur) values('2020/08/12',1)
insert into Demande(dateDem,idProfesseur) values('2020/08/12',2)
insert into Demande(dateDem,idProfesseur) values('2020/08/12',3)

insert into Detail_Demande values(1,1,10)
insert into Detail_Demande values(2,2,20)
insert into Detail_Demande values(3,3,30)

select*from Regoin
select*from Academie
select*from Lycee
select*from Professeur
select*from Demande
select*from Detail_Demande

go
create trigger T1
on Professeur
for insert,update
as
begin
if exists()
begin

end
end


go
create function F1(@idProfesseur int)
returns int
as 
begin
return(select)
end



