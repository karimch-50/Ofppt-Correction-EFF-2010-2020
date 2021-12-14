create database EFF2018_TP_V1_1_DB
--remarque ses question et le meme pour EFF2018_TP_V1_2 
--just la base de donne et different
use EFF2018_TP_V1_1_DB
create table Marque(
idMarq int primary key,
libelle varchar(30),
)
create table Voiture(
matricule int primary key,
modele varchar(30),
prixLocation float,
idMarq int foreign key references Marque(idMarq)
) 
create table Conducteur(
noPermis varchar(30) primary key,
nomConducteur varchar(30),
prenomConducteur varchar(30),
emailConducteur varchar(30),
mdpConducteur varchar(30),
)
create table Locationn(
idLoc int primary key,
noPermis varchar(30) foreign key references Conducteur(noPermis),
matricule int foreign key references Voiture(matricule),
dateLocation date,
DateRouteur date,
dureeLocation int,
montantTotal float
) 
create table Dommage(
idD int primary key,
idLoc int foreign key references Locationn(idLoc),
descriptionn varchar(30),
coutEstime float
)

insert into Marque values(1,'libelle1')
insert into Marque values(2,'libelle2')
insert into Marque values(3,'libelle3')

insert into Voiture values(1,'modele1',40000.99,1)
insert into Voiture values(2,'modele2',78000.20,2)
insert into Voiture values(3,'modele3',34000.50,3)

insert into Conducteur values('noPermis1','nomConducteur1','prenomConducteur1','exemple1@exmple.com','1234')
insert into Conducteur values('noPermis2','nomConducteur2','prenomConducteur2','exemple2@exmple.com','1234')
insert into Conducteur values('noPermis3','nomConducteur3','prenomConducteur3','exemple3@exmple.com','1234')

insert into Locationn values(1,'noPermis1',1,'2020/01/01','2020/02/01',30,6000.00)
insert into Locationn values(2,'noPermis2',2,'2020/10/01','2021/02/01',120,20000.00)
insert into Locationn values(3,'noPermis3',3,'2020/05/01','2020/12/01',240,44000.00)

insert into Dommage values(1,1,'descriptionn1',2500.00)
insert into Dommage values(2,2,'descriptionn2',500.00)
insert into Dommage values(3,3,'descriptionn3',1000.00)

select*from Marque
select*from Voiture
select*from Conducteur
select*from Locationn
select*from Dommage

go
create function F1(@idLoc int)
returns float
as
begin
    return (select (V.prixLocation*L.dureeLocation+coutEstime) 
    as MontantTotale 
    from Locationn L,Voiture V,Dommage D 
    where V.matricule=L.matricule
    and D.idLoc=L.idLoc
    and L.idLoc=1)
end

go
create procedure P1 @noPermis int
as 
begin
select V.* from voiture V,Conducteur C,Locationn L 
where V.matricule=L.matricule
and C.noPermis=L.noPermis
and C.noPermis=@noPermis
end

go
alter function F2(@matricule int,@dateLocation date,@DateRouteur date)
returns varchar(30)
as 
begin 
declare @dipo varchar(30)
    if exists(
        select*from voiture V,Locationn L
        where V.matricule=L.matricule
        and V.matricule=@matricule
        and L.dateLocation=@dateLocation
        and L.DateRouteur=@DateRouteur)
        set @dipo='la voiture et disponible'
    else
        set @dipo='la voiture et pas disponible'
    
return @dipo
end
go

select dbo.F2(12,'2020/01/01','2020/02/01')  

go
create trigger T1
on Locationn
for update
as
begin
if exists(select*from inserted I,Locationn L 
where I.idLoc=L.idLoc
and I.DateRouteur<>L.DateRouteur)
begin

declare @DateRouteur1 date
declare @dateLocation date

set @DateRouteur1=(select DateRouteur from inserted)
set @dateLocation=(select dateLocation from Locationn)

    update Locationn 
    set dureeLocation=datediff(day,@DateRouteur1,@dateLocation),
    montantTotal=datediff(day,@dateLocation,@DateRouteur1)*(select prixLocation from Voiture)
end
end

go
create trigger T2 
on Dommage
for insert
as
begin
if exists(select*from inserted)
begin
update Locationn set montantTotal=montantTotal+(select coutEstime from inserted)
end
end