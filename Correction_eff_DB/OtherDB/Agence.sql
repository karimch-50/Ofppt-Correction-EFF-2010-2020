create database Agence
use Agence
create table Station (
nomStation varchar(30) primary key,
capacit� int,
lieu varchar(30),
r�gion varchar(30),
tarif float
)
create table Activite (
nomStation varchar(30) foreign key references Station(nomStation),
libell� varchar(30),
prix int
)
create table Client (
id int primary key identity(10,10), 
nom varchar(30),
pr�nom varchar(30), 
ville varchar(30),
r�gion varchar(30),
solde float
)
create table Sejour (
idClient int foreign key references Client(id),
station varchar(30) ,
d�but date,
nbPlaces int
)
alter table Station alter column station
add constraint pk
foreign key references Station(nomStation)


insert into Station values(2,12,'jqidq','qwdwd',1813.13)
insert into Station values(3,13,'jqidq','qwdwd',1813.13)
insert into Station values(3,12,'jqidq','qwdwd',1813.13)
insert into Activite values(2,'doi',1000)
insert into Activite values(3,'kkkk',1001)
insert into Activite values(3,'kkdd',1001)
insert into Client(nom,pr�nom,ville,r�gion,solde)values('cgwa','agr','casa','weiud','10.1')
insert into Sejour values(10,'QDIQYG','2020-12-12',16)
insert into Sejour values(10,'2','2020-12-12',10000000)

select*from Client
select*from Sejour
select*from Station

--1 Cr�er une PS NomClient qui prend en entr�e l�id d�un client et qui affiche une cha�ne contenant le pr�nom et le nom du client 
create procedure NomClient @id int
as
begin
select nom+' '+pr�nom from Client where id=@id
end

--2 Cr�er une fonction  Activit�s qui prend en entr�e le nom du station et produit une cha�ne de caract�res contenant l��num�ration des activit�s de la station (par exemple, �Ski, Yoga, Massage�).
alter function Activit�s(@nomStation varchar(30))
returns varchar(30)
as
begin
declare @X varchar(30)
declare list_libelle cursor for select libell� from Activite where nomStation=@nomStation
open list_libelle
fetch list_libelle into @X
declare @A varchar(30)
set @A=''
while @@FETCH_STATUS=0
begin
set @A=@A+@X+','
fetch list_libelle into @X
end
close list_libelle
deallocate list_libelle
return substring(@A,1,len(@A)-1)
end

select*from Activite

select dbo.Activit�s('3')

--3 Cr�er ensuite une vue qui affiche les stations, avec un attribut suppl�mentaire donnant la liste des activit�s (par appel � la fonction bien s�r).
create view v2
as 
select dbo.Activit�s(nomStation)as 'liste_activit�s' from Station 

select*from v2

--4 Cr�er une PS Actualiser qui prend en entr�e un pourcentage et le nom d�une station, et augmente le tarif de la station et le prix de chacune de ses activit�s du pourcentage indiqu�.
create procedure Actualiser @pourcentage int,@nomStation varchar(30)
as
begin
update Station set tarif=tarif+(tarif*@pourcentage)/100 where nomStation=@nomStation
update Activite set prix=prix+(prix*@pourcentage)/100 where nomStation=@nomStation
end

exec Actualiser @pourcentage=10,@nomStation='2'

delete from Activite where nomStation=3

update Activite
select*from Station
select*from Activite

--5 Implantez par un trigger la r�gle suivante : si le prix d�une activit� baisse, alors le tarif de la station doit augmenter de la diff�rence. Indication : le trigger doit se d�clencher sur une modification, et doit faire un UPDATE de la station pour ajouter la diff�rence entre l�ancienne et la nouvelle valeur. (faites le teste)
create trigger t1
on activite 
for update
as 
begin
declare @dif int
set @dif=(select old.prix-new.prix from inserted new, deleted old 
where new.libell� =old.libell� and new.nomStation=old.nomStation)
if (@dif>0) 
Begin
update station
set tarif=tarif+@dif
where nomStation=(select nomStation from inserted)
end
end

select*from activite
select*from station

update Activite set prix=prix-100 where nomStation=2

--6 (a) Ajoutez la colonne nbActivites avec pour valeur par d�faut 0
alter table Station 
add nbActivites int default 0

--6 (b)Cr�ez un trigger qui maintient cette information.
create trigger t2
on Activite
for insert,update,delete
as
begin
update station set nbActivites=(select count(*)from activite  
where activite.nomstation=station.nomstation)
where nomstation in (select nomstation from inserted union select nomstation from deleted)
end

update Activite set nomStation=3 where prix=1000

select*from Station
select*from Activite

--7 Interdisez par un trigger l�insertion d�une ligne dans la table S�jour si le solde du client est inf�rieur au nombre de places multipli� par le tarif de la station.
create trigger t3
on Sejour
for insert
as
begin
if(select solde-tarif*nbPlaces from Client C,inserted I,Station S where C.id=I.idClient and S.nomStation=I.station)>0
begin
raiserror('Solde insiffusent !!',16,1)
rollback
end
end



