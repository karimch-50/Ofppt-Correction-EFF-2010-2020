create database EFF2011_TP_V01
use EFF2011_TP_V01
create table Personne(
Matricule int primary key,
nom varchar(30),
prenom varchar(30),
telephone varchar(30),
passe varchar(30)
)
create table Marque(
nom_marque varchar(30) primary key
)
create table Autocar(
code_car int primary key,
capacite int,
date_achat date,
consommation int,
nom_marque varchar(30) foreign key references Marque(nom_marque)
)
create table Ville(
code_ville int primary key,
nom_ville varchar(30)
)
create table Ligne(
code_ligne int primary key,
distance int,
#code_ville_depart int foreign key references Ville(code_ville),
#code_ville_arrivee int foreign key references Ville(code_ville)
)
create table Calendrier(
code_calendrier int primary key,
jour_voyage int,
heur_depart time,
heur_arrivee time,
code_ligne int foreign key references Ligne(code_ligne)
)
create table Voyage(
code_voyage int primary key identity,
dh_depart_voyage datetime,
dh_arrive_voyage datetime,
places int,
compteur_depart int,
compteur_arrivee int,
matricule int foreign key references Personne(Matricule),
code_car int foreign key references Autocar(code_car),
code_calendrier int foreign key references Calendrier(code_calendrier)
)

insert into Personne values(1,'N1','P1','Tele1','Passe1')
insert into Personne values(2,'N2','P2','Tele2','Passe2')
insert into Personne values(3,'N3','P3','Tele3','Passe3')

insert into Marque values('NM1')
insert into Marque values('NM2')
insert into Marque values('NM3')
insert into Marque values('NM4')

insert into Autocar values(1,10,'2020/12/12',100,'NM1')
insert into Autocar values(2,20,'2020/09/30',200,'NM2')
insert into Autocar values(3,30,'2020/10/27',300,'NM3')

insert into Ville values(1,'NV1')
insert into Ville values(2,'NV2')
insert into Ville values(3,'NV3')

insert into Ligne values(1,1000,1,3)
insert into Ligne values(2,5000,2,1)
insert into Ligne values(3,100,2,1)

insert into Calendrier values(1,10,'13:12:00','23:30:16',1)
insert into Calendrier values(2,17,'08:12:00','12:40:09',1)
insert into Calendrier values(3,23,'17:12:56','02:26:32',1)

insert into Voyage(
dh_depart_voyage,
dh_arrive_voyage,
places,
compteur_depart,
compteur_arrivee,
matricule,
code_car,
code_calendrier
) values('2020/08/11 15:12:00','2020/08/12 02:30:00',50,10000,10500,1,1,1)
insert into Voyage(
dh_depart_voyage,
dh_arrive_voyage,
places,
compteur_depart,
compteur_arrivee,
matricule,
code_car,
code_calendrier
) values('2020/12/20 23:30:00','2020/12/21 04:44:00',100,234025,234432,2,2,2)
insert into Voyage(
dh_depart_voyage,
dh_arrive_voyage,
places,
compteur_depart,
compteur_arrivee,
matricule,
code_car,
code_calendrier
) values('2020/10/21 15:12:00','2020/10/22 12:03:00',45,60030,60263,3,3,3)


select*from Personne
select*from Marque
select*from Autocar
select*from Ville
select*from Ligne
select*from Calendrier
select*from Voyage

select C.jour_voyage,C.heur_depart,C.heur_arrivee from Calendrier C,Ligne L where C.code_ligne=1and L.#code_ville_depart=2 and L.#code_ville_arrivee=1

select V.* from Voyage V,Personne P where V.matricule=P.Matricule and P.Matricule=(select Matricule from Personne where nom='N1')