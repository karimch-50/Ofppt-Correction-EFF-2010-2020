create database var8_2012
use var8_2012
go
create table conducteur(idconducteur int primary key,
nomC varchar(50),
prenC varchar(50),
DateN datetime,
pass varchar(50))
create table vehicule (immat int primary key,
marque varchar(50),
modele varchar(50),
puissance varchar(50),
carburant varchar(50),
dateachat datetime,
compteur varchar(50),
idconducteur int foreign key references conducteur)
create table histoconducteur(idhc int primary key,
immat int foreign key references vehicule,
idconducteur int foreign key references conducteur,
dateDebut datetime,
datefin datetime)

create table assvehicule (idass int primary key,
nomassureur varchar(50),
dateass datetime,
dateexpiration datetime,
immat int foreign key references vehicule,
montant float)

create table panne(idpanne int primary key,
datepanne datetime,
datereprise datetime,
descpanne varchar(50),
kilometrage int,
immat int foreign key references vehicule)
go
create table accident(idaccident int primary key,
dateaccident datetime,
note float,
immat int foreign key references vehicule)

create database var8 ; 
use var8 ; 
create table conducteur ( Id_Conducteur int primary key , 
Nomc varchar(100) ,
PrenomC varchar(100) , 
DateN datetime , 
Pass varchar(100) ) ; 

--Question2 : 

create proc Question2 ( @DateAchat date ) 
as begin 
select * from vehicule where dateachat < @DateAchat ; 
end 
--Question3 : 

create proc Question3 ( @N int ) 
as begin 
select vehicule.* from vehicule inner join assvehicule 
where DATEDIFF( DAY , GETDATE , assvehicule.dateexpiration )=@N ;
end 
--Question4 : 
create Proc Question4 ( @Mat int ) 
as begin 
select * from panne where YEAR (datepanne ) = 2011 and immar = @Mat ;
end 

--Question5 : 
create Trigger Question5 on Panne 
for insert 
as begin 
declare @immat int , @Kil int , @Compteur int ; 
set @immat = (select immat from inserted ) ; 
set @Kil = (select kilometrage from inserted );
set @Compteur = (select Compteur from vehicule where immat = @immat ) ; 
if @Kil < @Compteur 
begin 
print('Kilomtrage inferieur au Compteur ') ; 
rollback tran
end 
end 
--Question6 : 
create trigger Question6 on Vahicule 
after update 
as begin 
if update(idconducteur)
begin 
insert into HistoConducteur values ( (select immat from inserted) , (select idconducteur from inserted) , getdate , null ) ;
end 
end