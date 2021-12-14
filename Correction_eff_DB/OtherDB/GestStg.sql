Create Database GestStg
Use GestStg
create table Stagiaire(IdStg int identity primary key, Nom varchar(20), Moyenne real)
Create table Module (IdMod int identity primary key, Libelle varchar(20), Coeff real)
Create table Note(IdStg int foreign key references Stagiaire(IdStg), IdMod int foreign key references Module(IdMod), Note real)
Go

insert into stagiaire values ('Ali',null)
insert into stagiaire values ('Ahmed', null)


select * from stagiaire
delete from stagiaire where idstg=1

Insert into Module  values ('SGBD1',2)
Insert into Module  values ('SGBD2',3)

select * from Module 

Insert into Note values (3,1,10)
Insert into Note values (3,2,11)
Insert into Note values (1,2,15)
Insert into Note values (2,2,11)
Insert into Note values (2,2,-5)
Insert into Note values (2,1,16)

delete from note where note=11 and idstg=3
Select * from Note

alter trigger T1
on Note
for insert,update
as
begin
if Not exists(select * from stagiaire,inserted, Module where stagiaire.idstg=inserted.idstg and inserted.IdMod=Module.IdMod)
begin
raiserror('problem integ refe',16,1)
rollback
end
if not exists(select * from inserted where note between 0 and 20)
begin
raiserror('problem integ refe',16,1)
rollback
end
end

alter trigger T2_1
on Stagiaire
for delete
as 
begin
declare @t int
select @t= Idstg from deleted
print''+convert(varchar(10),@t)
delete from Note where IdStg =(select Idstg from deleted)
end

ALTER trigger T2_2
on Module
INSTEAD OF delete
as 
begin
delete from Note where IdMod in(select IdMod from deleted)
end

select*from Note
delete from Stagiaire where Idstg=1

