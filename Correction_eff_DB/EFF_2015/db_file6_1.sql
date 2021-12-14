create database EFF_2015_TH
use EFF_2015_TH
create table Electeur(
    IdElecteur int primary key,
    nomElecteur varchar(30),
    prenomElecteur varchar(30),
    aVote varchar(30)
)
create table Condidats(
    idCondidat int primary key,
    nomCondidat varchar(30),
    prenomCondidat varchar(30),
    dateNaissance date,
    nombreVoix int
)
create table Votes(
    IdElecteur int foreign key references Electeur(IdElecteur),
    idCondidat int foreign key references Condidats(idCondidat),
    primary key(IdElecteur,idCondidat)
)

insert into Electeur values(1,'nomElecteur1','prenomElecteur1','0')
insert into Electeur values(2,'nomElecteur2','prenomElecteur2','1')
insert into Electeur values(3,'nomElecteur3','prenomElecteur3','0')

insert into Condidats values(1,'nomCondidat1','prenomCondidat1','2020-10-10',10)
insert into Condidats values(2,'nomCondidat2','prenomCondidat2','2020-11-11',20)
insert into Condidats values(3,'nomCondidat3','prenomCondidat3','2020-12-12',30)

insert into Votes values(1,1)
insert into Votes values(1,2)
insert into Votes values(2,2)
insert into Votes values(3,3)
insert into Votes values(3,1)
delete from Votes  

select*from Electeur
select*from Condidats
select*from Votes


select E.IdElecteur from Electeur E,Votes V 
where E.IdElecteur=V.IdElecteur
group by E.IdElecteur
having count(idCondidat)=1 

select top(3)C.idCondidat 
from Condidats C,Votes V 
where C.idCondidat=V.idCondidat
group by C.idCondidat 
order by count(V.idCondidat) desc


go
create function F1(@idCondidat int)
returns table 
as
return(select E.* from Electeur E,Votes V
where E.IdElecteur=V.IdElecteur 
and idCondidat=@idCondidat)


go
alter trigger T1
on Votes
for insert
as
begin
declare @idCondidat int
declare @IdElecteur int
if exists(select*from inserted)
begin
select @idCondidat=idCondidat,@IdElecteur=IdElecteur from inserted
update Condidats
set nombreVoix=nombreVoix+1
where idCondidat=@idCondidat
update Electeur
set aVote=1
where IdElecteur=@IdElecteur
end
end



go
alter procedure P1 @idElec int,@idCondidat1 int,@idCondidat2 int,@idCondidat3 int
as
begin

if(@idCondidat1 is not null and @idCondidat2 is not null and @idCondidat3 is not null)
begin
insert into Votes values(@idElec,@idCondidat1),(@idElec,@idCondidat2),(@idElec,@idCondidat3)
end

if(@idCondidat1 is not null and @idCondidat2 is not null and @idCondidat3 is null)
begin
insert into Votes values(@idElec,@idCondidat1),(@idElec,@idCondidat2)
end

if(@idCondidat1 is not null and @idCondidat2 is null and @idCondidat3 is null)
begin
insert into Votes values(@idElec,@idCondidat1)
end
if(@idCondidat1 is null and @idCondidat2 is null and @idCondidat3 is null)
print 'error'
end

exec P1 1,1,null,null


select*from Votes
