create database EFF2019_V2_1_DB
use EFF2019_V2_1_DB
create table Abonne(
cin varchar(30) primary key,
nomAb varchar(30),
PrenomAb varchar(30),
datenaiss date,
loginn varchar(30),
motdepasse varchar(30),
)

select A1.* from Abonne A1,Abonnement A2 where A1.cin=A2.cin and noTelephone=1

create table Abonnement(
noTelephone bigint primary key,
noSeriePuce int,
dateMiseEnService date,
typeAb varchar(30),
cin varchar(30) foreign key references Abonne(cin)
)
create table Reclamation(
idrec int primary key,
noTelephone bigint foreign key references Abonnement(noTelephone),
dateRec varchar(30),
ObjetReclamation varchar(30),
etatRec varchar(30)
)

create table Operateur(
idOperateur int primary key,
nomOp varchar(30),
prenomOp varchar(30),
loginop varchar(30),
mdpop varchar(30)
)
create table intervention(
idInt int primary key,
isRec int foreign key references Reclamation(idrec),
dateInt date,
nature varchar(30),
idoperateur int foreign key references Operateur(idOperateur),
)

insert into Abonne values('cin1','nomAb1','PrenomAb1','1980-01-01','loginn1','motdepasse1')
insert into Abonne values('cin2','nomAb2','PrenomAb2','1990-10-10','loginn2','motdepasse2')
insert into Abonne values('cin3','nomAb3','PrenomAb3','1985-12-20','loginn3','motdepasse3')

insert into Abonnement values(0600000000,11111111,'2006-10-12','typeAb1','cin1')
insert into Abonnement values(0600000001,11111112,'2006-10-12','typeAb2','cin2')
insert into Abonnement values(0600000002,11111113,'2006-10-12','typeAb3','cin3')

insert into Reclamation values(1,0600000000,'2021-01-01','ObjetReclamation1','etatrec1')
insert into Reclamation values(2,0600000001,'2021-01-10','ObjetReclamation2','etatrec2')
insert into Reclamation values(3,0600000002,'2021-01-20','ObjetReclamation3','etatrec3')

insert into Operateur values(1,'nomOp1','prenomOp1','loginop1','mdpop1')
insert into Operateur values(2,'nomOp2','prenomOp2','loginop2','mdpop2')
insert into Operateur values(3,'nomOp3','prenomOp3','loginop3','mdpop3')

insert into intervention values(1,1,'2021-02-01','nature1',1)
insert into intervention values(2,2,'2021-02-10','nature2',2)
insert into intervention values(3,3,'2021-05-29','nature3',3)

select*from Abonne
select*from Abonnement
select*from Reclamation
select*from Operateur
select*from intervention










update Abonnement 
set noSeriePuce=,dateMiseEnService='',typeAb='',cin='' 
where noTelephone=

delete from Abonnement where noTelephone= 

select*from Reclamation where noTelephone=
