create database  DB_Banque
use DB_Banque
create table AGENCE(
Num_Agence int primary key,
Nom varchar(30),
Ville varchar(30),
Actif varchar(30)
)
create table CLIENT(
Num_Client int primary key,
Nom varchar(30),
Ville varchar(30)
)
create table COMPTE(
Num_compte int,
Num_Agence int,
Num_Client int,
solde int,
foreign key(Num_Agence)references AGENCE(Num_Agence),
foreign key(Num_Client)references CLIENT(Num_Client),
)
create table EMPRUNT(
Num_Emprunt int,
Num_Agence int,
Num_Client int,
Montant int,
foreign key(Num_Agence)references AGENCE(Num_Agence),
foreign key(Num_Client)references CLIENT(Num_Client)
)

insert into AGENCE values(55,'bmce','casablanca','kjasigiha')
insert into CLIENT values(100,'karim chaouki','casablanca')
insert into COMPTE values(5677,55,100,30000)
insert into EMPRUNT values(9745,55,100,300)

insert into AGENCE values(54,'cih','casablanca','maqedkw')
insert into CLIENT values(101,'adam','casablanca')
insert into COMPTE values(5670,54,100,20000)
insert into EMPRUNT values(9746,54,100,400)

truncate table AGENCE
truncate table CLIENT
truncate table COMPTE
truncate table EMPRUNT

select*from AGENCE
select*from CLIENT
select*from COMPTE
select*from EMPRUNT

update compte set solde =0 where solde is null 

update EMPRUNT set Montant=Montant*0.95 where Num_Client in(select Num_Client from CLIENT where Ville='casablanca')

update COMPTE set solde< 0 where solde<0

select Nom from CLIENT
where nom like'B_A%'

select a.Nom from AGENCE a join COMPTE cpt on a.Num_Agence=cpt.Num_Agence

select C.Nom from CLIENT C join COMPTE cmp on cmp.Num_Client=C.Num_Client
where Ville='casablanca'

select C.Nom from CLIENT C join COMPTE cmp on cmp.Num_Client=C.Num_Client join EMPRUNT emp on emp.Num_Client=C.Num_Client 
where Ville='Rabat'

select A.Nom,AVG(C.solde) as solde_moyen from COMPTE C join AGENCE A on C.Num_Agence=A.Num_Agence group by(A.Nom)

select A.Nom,sum(C.solde) as totale_solde from COMPTE C join AGENCE A on C.Num_Agence=A.Num_Agence group by(A.Nom)

update EMPRUNT set Montant=(select E.Montant-Montant*0.05 from CLIENT C,EMPRUNT E where C.Num_Client=E.Num_Client and C.Ville='casablanca')
