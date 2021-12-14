create database EFF_2014_TH
use EFF_2014_TH
create table Filiere(
    idFiliere int primary key,
    nomFilere varchar(30)
)
create table Stagiaire(
    idStagiaire int primary key,
    nom varchar(30),
    prenom varchar(30),
    idFiliere int foreign key references Filiere(idFiliere),
    TotaleAbsence int,
)
create table Module(
    IdModule int primary key,
    nomModule varchar(30),
    NbreHeure int
)
create table Fil_Module(
    idModule int foreign key references Module(IdModule),
    idFiliere int foreign key references Filiere(idFiliere),
    primary key(idFiliere,idModule)
)
create table Absence(
    idAbsence int primary key,
    dateAbs date,
    idStagiaire int foreign key references Stagiaire(idStagiaire),
    idModule int foreign key references Module(IdModule),
    TypeAbsence varchar(30)
)

insert into Filiere values(1,'nomFilere1')
insert into Filiere values(2,'nomFilere2')
insert into Filiere values(3,'nomFilere3')

insert into Stagiaire values(1,'nom1','prenom1',1,10)
insert into Stagiaire values(2,'nom2','prenom2',2,15)
insert into Stagiaire values(3,'nom3','prenom3',3,20)

insert into Module values(1,'nomModule1',100)
insert into Module values(2,'nomModule2',110)
insert into Module values(3,'nomModule3',120)

insert into Fil_Module values(1,1)
insert into Fil_Module values(2,2)
insert into Fil_Module values(3,3)

insert into Absence values(1,'2020-10-10',1,1,'TypeAbsence1')
insert into Absence values(2,'2020-11-10',2,2,'TypeAbsence2')
insert into Absence values(3,'2020-12-10',3,3,'TypeAbsence3')


select*from Filiere 
select*from Stagiaire 
select*from Module 
select*from Fil_Module 
select*from Absence


go
create procedure P1 @idF int
as
begin
select count(A.idAbsence) 
from Absence A,Module M,Fil_Module F
where A.idModule=M.idModule
and F.idModule=M.idModule
and A.TypeAbsence='non justifier'
and F.idFiliere=@idF
group by A.idStagiaire
end


go
create trigger T1
on Absence
for insert
as
begin
declare @idStg int
declare @idModul int

select @idStg=idStagiaire from inserted

select @idModul=M.idModule 
from Module M,Fil_Module FM,Stagiaire S
where M.idModule=FM.idModule
and FM.idFiliere=S.idFiliere
and idStagiaire=@idStg

if exists(select*from inserted where idModule<>@idModul)
rollback

end


go
create trigger T2
on Absence
for insert
as
begin
declare @idStg int
select @idStg=idStagiaire from inserted
if exists(select*from inserted)
begin
update Stagiaire
set TotaleAbsence=TotaleAbsence+10
where idStagiaire=@idStg
end 
end


go
create function F1(@idStg int)
returns float
as
begin
declare @noteI float
declare @nbrAbs int
declare @noteF float

set @noteI=20
select @nbrAbs=S.TotaleAbsence from Stagiaire S,Absence A
where S.idStagiaire=A.idStagiaire
and S.idStagiaire=@idStg 
and TypeAbsence='non justifier'


if(@nbrAbs>20)
set @noteF=0

if(@nbrAbs<20)
begin
set @noteF = @noteI-@nbrAbs
end

return @noteF
end


go
create procedure P2 @idMd int
as
begin
select S.idStagiaire from Stagiaire S,Module M,Fil_Module FM
where S.idFiliere=FM.idFiliere
and M.IdModule=FM.idModule
and M.IdModule=@idMd
and S.TotaleAbsence*2.5>M.NbreHeure*0.3
end


select distinct S.idStagiaire 
from Stagiaire S,Absence A1,Absence A2
where A1.idAbsence=A2.idAbsence
and A1.idStagiaire=S.idStagiaire
and datediff(day,A1.dateAbs,A2.dateAbs)<15 
group by S.idStagiaire 
having count(A1.idAbsence)>2
