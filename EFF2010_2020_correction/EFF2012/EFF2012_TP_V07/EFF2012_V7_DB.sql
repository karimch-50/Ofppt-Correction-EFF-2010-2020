create database EFF2012_V7
use EFF2012_V7
drop database EFF2012_V7
create table Conducteur (
idconducteur int primary key,
nomC varchar(30),
prenC varchar(30),
dateN date,
pass varchar(30)
)
create table Vehicule(
immat varchar(30) primary key,
marque varchar(30),
modele varchar(30),
puissance int,
carburant varchar(30),
dateAchat date,
compteur int,
idconducteur int foreign key references Conducteur(idconducteur) on update cascade on delete cascade
)
create table Entretien(
idEntretien int primary key,
nomEntretien varchar(30),
frequence int,
periode varchar(30),
kilometrage int,
montant float
)
create table EntrVehicule(
idEntVeh int primary key,
immat varchar(30) foreign key references Vehicule(immat) on update cascade on delete cascade,
idEntretien int foreign key references Entretien(idEntretien) on update cascade on delete cascade,
dateEbtretien date,
kmVehicule int
)
create table AssVehicule(
idAss int primary key,
nomAssureur varchar(30),
dateAss date,
dateExpiration date,
immat varchar(30) foreign key references Vehicule(immat) on update cascade on delete cascade
)

insert into Conducteur values(1,'nomC1','prenC1','1990-12-12','pass1')
insert into Conducteur values(2,'nomC2','prenC2','1980-12-12','pass2')
insert into Conducteur values(3,'nomC3','prenC3','1970-12-12','pass3')

insert into Vehicule values('imma1','marque1','modele1',120,'carburant1','2010-10-10',120,1)
insert into Vehicule values('imma2','marque2','modele2',300,'carburant1','2020-10-10',120,1)
insert into Vehicule values('imma3','marque3','modele3',200,'carburant1','2015-10-10',120,1)
insert into Vehicule values('imma4','marque4','modele4',200,'carburant4','2005-10-10',120,3)

insert into Entretien values(1,'nomEntretien1',100,'periode1',10000,50000.80)
insert into Entretien values(2,'nomEntretien2',200,'periode2',2000,90000)
insert into Entretien values(3,'nomEntretien3',300,'periode3',300,100000.50)
insert into Entretien values(4,'nomEntretien4',400,'periode3',100,100000.50)

insert into EntrVehicule values(1,'imma1',1,'2020-10-10',1000)
insert into EntrVehicule values(2,'imma2',2,'2020-08-10',2000)
insert into EntrVehicule values(3,'imma3',3,'2020-06-10',3000)
insert into EntrVehicule values(4,'imma4',4,'2020-04-10',100)

insert into AssVehicule values(1,'nomAssureur1','2021-01-01','2021-04-01','imma1')
insert into AssVehicule values(2,'nomAssureur2','2021-02-02','2021-05-29','imma2')
insert into AssVehicule values(3,'nomAssureur3','2021-03-03','2021-06-10','imma3')

select*from Conducteur
select*from Vehicule
select*from Entretien
select*from EntrVehicule
select*from AssVehicule

select E1.*
from Entretien E1,EntrVehicule E2,Vehicule V
where E1.idEntretien=E2.idEntretien and V.immat=E2.immat and E2.immat='imma4' and V.compteur>E1.kilometrage

select immat,modele,puissance,compteur from Vehicule where marque='' and compteur>200000

select V.marque,V.modele,V.immat,V.carburant,C.nomC,C.prenC from Vehicule V,Conducteur C where V.idconducteur=C.idconducteur order by marque

select*from