create database  gestion_commande
use gestion_commande
create table Client(
IdClient int primary key,
Nom varchar(30),
Prenom varchar(30),
Vile varchar(50)
)
create table Commande(
NumCommande int primary key,
IdClient int foreign key references Client(IdClient) ,
Quntite int,
Prix_Total int
)
create table Facture(
NumFacture int primary key,
NumCommande int foreign key references Commande(NumCommande),
DateFacture date
)
insert into Client values(1,'chaouki','karim','casa')
insert into Client values(2,'souri','monsif','casa')
insert into Commande values(10,1,12,3000)
insert into Commande values(11,2,100,10000)
insert into Facture values(35,10,'2020-11-10')
insert into Facture values(36,11,'2020-10-29')

create procedure affiche_info_client1
as
select*from Client

create procedure affiche_list_commandes @Id int
as
select*from Commande where IdClient=@Id

create procedure affiche_info_client2
as
begin
select Quntite 
from Commande C,Facture F 
where C.NumCommande=F.NumCommande and Quntite>75 and datepart(year,DateFacture) between 2003 and 2004
end

create procedure somme_prix @some int output
as
begin
declare @sum int
select sum(Prix_Total) from Commande 
set @sum=@some
end

create procedure affiche_nom_prenome
as
begin
select Nom,Prenom from Client where Nom like'Al%'
end

create procedure nombre_commandes 
as
select count(*) from Commande

