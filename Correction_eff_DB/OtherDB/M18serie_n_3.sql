create database AcciRoute1
use AcciRoute1

--2.Cr�er la proc�dure CreateAcciRoute qui permet de construire les tables de donn�es AcciRoute en les supprimant s�ils existent avant leur cr�ation 
create procedure CreateAcciRoute as
begin
if exists(select*from sys.tables where name like 'Personne')
drop table Personne
create table Personne (
Nas char(9) primary key,
nom varchar(35),
VilleP Varchar(50)
)
if exists(select*from sys.tables where name like 'Voiture')
drop table Voiture
create table Voiture (
Imma Char(6) primary key,
modele varchar(20),
annee char(4),
Nas char(9) foreign key references Personne(Nas)
)
if exists(select*from sys.tables where name like 'Accident')
drop table Accident
create table Accident (
DateAc Date,
Nas char(9) foreign key references Personne(Nas),
dommage numeric(7,2),
villeAc varchar(50),
Imma char(6) foreign key references Voiture(Imma)
)
end

--execution de la procedure CreateAcciRoute
exec CreateAcciRoute

insert into Personne  values('1','karim chaouki','casa')
insert into Personne  values('2','jeqwti','rabat')

insert into Voiture values('1','dasia',2017,'1')
insert into Voiture values('2','tesla',2077,'2')

--3 Cr�er la proc�dure InsertAccident qui permet d�ins�rer les donn�es dans Accident en v�rifiant l�int�grit� r�f�rentielle 

create procedure InsertAccident @Nas char(9),
								@Imma Char(6),
								@DateAc Date, 
								@dommage numeric(7,2),
								@villeAc varchar(50)							
as
begin
if exists(select*from Personne where Nas=@Nas)and exists(select*from Voiture where Imma=@Imma)
insert into Accident values(@DateAc,@Nas,@dommage,@villeAc,@Imma)
else raiserror('problem d`integ refer',16,1)
end
--execution de la procedure InsertAccident
exec InsertAccident @DateAc='2020-03-22',@Nas='1',@dommage=3000.5,@villeAc='rabat',@Imma='1'
exec InsertAccident @DateAc='2077-03-23',@Nas='2',@dommage=10000.23,@villeAc='rabat',@Imma='2'

select*from Personne
select*from Voiture
select*from Accident

--4.Cr�er la proc�dure GetnumProp qui permet de calculer le nombre de propri�taires impliqu�s dans un accident entre deux ann�es donn�es
create procedure GetnumProp @DateAc1 int,@DateAc2 int
as
begin
select count(Nas) 
from Accident 
where datepart(year,DateAc) between  @DateAc1 and @DateAc2
end
--execution de la procedure GetnumProp
exec GetnumProp 2019,2021

--5 Cr�er la proc�dure GetProp qui donne le nom et le nas des propri�taires qui ont fait deux accidents dans un intervalle de 4 mois.
create procedure GetProp  
as
begin
select P.Nas,P.nom from
Personne P,Accident A1,Accident A2 where
P.Nas=A1.Nas and A1.Nas=A2.Nas and datediff(month,A1.DateAc,A2.DateAc)>=4
end
--execution de la procedure GetProp
exec GetProp

--6.Cr�er la proc�dure GetDomCity qui calcule le total des dommages d�une ville donn�e et affiche � cat�gorie1 � pour dommage<=5000 et � cat�gorie2 � pour dommage entre 5000 et 10000 et � cat�gorie3 � pour dommage >10000
alter procedure GetDomCity @villeAc varchar(50) 
as 
begin
select sum(dommage),case 
when sum(dommage)<=5000  then 'cat�gorie1'
when sum(dommage) between 5000 and 10000 then 'cat�gorie2'
when sum(dommage)> 10000 then 'categorie3'
else 'categorie non valide'
end as 'categorie'
from Accident 
where villeAc=@villeAc
end
--execution de la procedure GetDomCity
exec GetDomCity @villeAc='we'

select*from Accident

--7.Cr�er la proc�dure GetnumAcci qui permet d�afficher pour chaque ville le nombre total d�accidents enregistr�s
create procedure GetnumAcci 
as
begin
select villeAc,count(*)as 'total_accidents' 
from Accident 
group by villeAc
end
--execution de la procedure GetnumAcci
exec GetnumAcci

--8.Cr�er la proc�dure GetNamProp qui permet d�afficher le nom des propri�taires qui r�sident dans une ville o� il y a eu plus de x accidents tel que x un param�tre de la proc�dure
create procedure GetNamProp @x int
as
begin
select nom from Personne 
where VilleP in(
select villeAc 
from Accident 
group by villeAc 
having count(*)>=@x
)
end
--execution de la procedure GetNamProp
exec GetNamProp @x=1

select*from Personne

--9.Cr�er la proc�dure GetnumAcciDat qui calcule le nombre d�accidents qui sont survenus � une date donn�e
create procedure GetnumAcciDat @DateAc Date 
as 
begin
select count(*)
from Accident 
where DateAc=@DateAc
end
--execution de la procedure GetnumAcciDat
exec GetnumAcciDat @DateAc='2077-03-20'

--10.Cr�er la proc�dure GetnumAcciHour qui calcule le nombre d�accidents survenus entre deux heures donn�es
alter procedure GetnumAcciHour @hourAc1 int,@hourAc2 int 
as
begin
select count(*) 
from Accident 
where datepart(hour,DateAc) between @hourAc1 and @hourAc2
end
--execution de la procedure GetnumAcciHour
exec GetnumAcciHour @hourAc1=11,@hourAc2=23

--11 Cr�er la proc�dure UpdateDom qui permet de diminuer de 5% le dommage � chaque v�hicule dont les dommages d�passant  les 5000.00
create procedure UpdateDom  
as 
begin
update Accident set dommage=dommage*0.95 
where dommage>5000.00
end

--execution de la procedure UpdateDom
exec UpdateDom

commit
rollback


create trigger kjaei
on Personne
after insert
as
select Nas from inserted



