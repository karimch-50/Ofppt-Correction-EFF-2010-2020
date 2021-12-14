create database TP_10_Triggers
use TP_10_Triggers
CREATE TABLE Formations (
Num INT primary key identity,
Titre varchar(150),
Date_début date,
Date_fin date,
NbParticipants int
)
CREATE TABLE Journal (
DateOperation datetime default getdate(),
Opération varchar(50),
Nbligneaffectée int,
utilisateur sysname default system_user
)

create trigger T1
on Formations
after insert
as 
begin
declare @nbr int
select @nbr=count(*) from INSERTED
insert into Journal(DateOperation,Opération,Nbligneaffectée) values(getdate(),'ajoute',@nbr)
end

select*from Formations
select*from Journal

insert into Formations(Titre,Date_début,Date_fin,NbParticipants) values('qwjf',getdate(),'2020-12-30',12)

create trigger T2
on Formations
after update
as 
begin
declare @nbr int
select @nbr=count(*) from INSERTED
insert into Journal(DateOperation,Opération,Nbligneaffectée) values(getdate(),'modification	',@nbr)
end

update Formations set NbParticipants=77

create trigger T3
on Formations
after delete
as 
begin
declare @nbr int
select @nbr=count(*) from deleted
insert into Journal(DateOperation,Opération,Nbligneaffectée) values(getdate(),'suppression',@nbr)
end

delete from Formations

alter table Formations enable trigger T1

create trigger t
on Formations
after insert,update,delete
as 
begin
declare @op
if exists(select*from inserted)and exists(select*from deleted)
set @op='Modification'
select @nbr=count(*) from inserted
else if exists(select*from inserted)
set @op='inserted'
select @nbr=count(*) from inserted
else if exists(select*from deleted)
set @op='suppression'
select @nbr=count(*) from deleted

insert into Journal(DateOperation,Opération,Nbligneaffectée) values(getdate(),'ajoute',@nbr)
end



