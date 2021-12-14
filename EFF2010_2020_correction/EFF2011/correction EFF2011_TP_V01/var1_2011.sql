					
					

									---#######		By AJDI Yassin 2011/2012	  ######---

--Q1
use master
go
create database v12011
Go
use v12011
Go
create table Personnel(
	Matricule int primary key,
	nom varchar(50),
	prenom varchar(50),
	telephone varchar(50),
	passe varchar(20)
)
go
create table Marque(
	nom_marque varchar(50) primary key
)
go
create table Autocar(
	code_car int primary key, 
	capacite int, 
	date_achat smalldatetime, 
	consomation float, 
	nom_marque varchar(50) foreign key references Marque(nom_marque)
)
go
create table Ville(
	code_ville int primary key,
	nom_ville varchar(50)
)
go
create table Ligne(
	code_ligne int primary key, 
	distance float, 
	code_ville_depart int foreign key references Ville(code_ville), 
	code_ville_arrivee int foreign key references Ville(code_ville)
)
go
create table Calendrier(
	code_calendrier int primary key, 
	jour_voyage int, 
	heure_depart float, 
	heure_arrivee float, 
	code_ligne int foreign key references Ligne(code_ligne)
)
go
create table Voyage(
	code_voyage int identity primary key,
	dh_depart_voyage datetime,
	dh_arrive_voyage datetime,
	places int, 
	compteur_depart int,
	compteur_arrivee int, 
	matricule int foreign key references Personnel(Matricule),
	code_car int foreign key references Autocar(code_car), 
	code_calendrier int foreign key references Calendrier(code_calendrier)
)
Go
--insert simple
insert into Personnel values(1,'My friend','Friends','0000','123')
insert into Personnel values(2,'AJDI','Yassin','1111','222')
insert into Personnel values(3,'test','TEST','1111','3333')
go

insert into Marque values('Renault')
insert into Marque values('Mercedes')
go
insert into Autocar values(1,50,'1/1/2000',20,'Renault')
insert into Autocar values(2,30,'1/1/2000',10,'Renault')
go
insert into Ville values(1,'Casablanca')
insert into Ville values(2,'Rabat')
insert into Ville values(3,'Marrakech')
go
insert into Ligne values(1,160,1,2)
insert into Ligne values(2,400,1,3)
go
insert into Calendrier values(1,1,14.00,15.00,1) 
insert into Calendrier values(2,3,14.00,15.00,1)
insert into Calendrier values(3,3,14.00,15.00,1)

insert into Voyage values('3/4/2012 15:30','3/4/2012 16:30',45,23452,23543,1,1,1)
insert into Voyage values('3/4/2012 15:30','3/4/2012 16:30',45,23452,23543,2,2,1)
Go

-- Question 2
alter table Calendrier add constraint con_jv check(jour_voyage between 1 and 7)
alter table Voyage add constraint con_dv check(dh_depart_voyage < dh_arrive_voyage)
alter table Autocar add constraint con_cap check(capacite > 0)
go
-- Question 3
alter table Personnel add NP as nom + ' ' + prenom
go
-- Question 4
create trigger Question4 on Ligne after insert,update
as
begin
	if exists(select * from Ligne l inner join inserted i 
	on i.code_ville_depart = l.code_ville_depart and i.code_ville_arrivee = l.code_ville_arrivee) 
	begin
	--RAISERROR syntax: RAISERROR('msg',severity,state)
	--state must be between 1 and 127 :p,
	--also severity: must be between 1 and 19 .. use 11 to 19 if u are using catch bloc else just use a number between 1 and 10
	raiserror('Ligne Exist déjà',15,1)
	rollback
	end
end
go
--test
insert into Ligne values(5,160,1,2)
go

--Question 5: scaler function, returns a single value :)
create function dbo.Question5(@cl int = null) returns int
with returns null on null input
as 
begin
	declare @s real
	select @s=sum(places) from Voyage v inner join Calendrier c
	on v.code_calendrier= c.code_calendrier where code_ligne=@cl
	return @s
end
go
select dbo.Question5(1)
go
-- Question 6

create proc dbo.Question6 @cl int = 1
as
begin
	select v.* from Voyage v inner join Calendrier c 
	on c.code_calendrier= v.code_calendrier where code_ligne = @cl
end
go
Exec dbo.Question6 1
go
-- Question 7
create function dbo.Question7(@cl int) 
returns nvarchar(max)
as
begin
	declare @string nvarchar(max),@np nvarchar(250)
	set @string=''
	declare cr cursor for select p.np from Personnel p inner join Voyage v
	on p.Matricule=v.matricule inner join Calendrier c on v.code_calendrier=c.code_calendrier where c.code_ligne = @cl

	open cr
	fetch next from cr into @np
	while(@@fetch_status=0)
	begin
	set @string=@string + @np + ', '
	fetch next from cr into @np
	end
	close cr
	deallocate cr
	return substring(@string, 1, len(@string)-2)+'.'
end
go
select dbo.Question7(1)
go
--Another way to do this:
create function test (@cl int)
returns nvarchar(max)
as
begin
	declare @str as varchar(max)
	select @str=Coalesce(@str+', ','')+ p.np from Personnel p inner join Voyage v
	on p.Matricule=v.matricule inner join Calendrier c on v.code_calendrier=c.code_calendrier where c.code_ligne = @cl
	and p.np is not null
	return @str
end

select dbo.test(1)



									---#######		By AJDI Yassin 2011/2012	  ######---
									
													---### References:####---
							--## Raiserror: http://msdn.microsoft.com/en-us/library/ms177497(SQL.105).aspx ##--
								--## Data types: http://msdn.microsoft.com/en-us/library/ms187752.aspx ##--
								