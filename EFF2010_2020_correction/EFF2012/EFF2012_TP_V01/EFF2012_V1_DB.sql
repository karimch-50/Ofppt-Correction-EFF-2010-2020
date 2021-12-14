create database EFF2012_TP_V01
use EFF2012_TP_V01
create table Region (
idRegion int primary key,
nomRegion varchar(30)
)
create table ProvincePrefecture (
idProvPref int primary key,
nomProvPref varchar(30),
idRegion int foreign key references Region(idRegion) on update cascade on delete cascade
)
create table Circonscription (
idCirconscription int primary key,
nomCir varchar(30),
NombreSiege int,
idProvPref int foreign key references ProvincePrefecture(idProvPref) on update cascade on delete cascade
)
create table Parti (
idParti int primary key,
nomParti varchar(30)
)
create table Candidat (
CINcandidat varchar(30) primary key,
nomCandidat varchar(30),
prenomCandidat varchar(30),
DateNC date,
adrCandidat varchar(30),
idCirconscription int foreign key references Circonscription(idCirconscription) on update cascade on delete cascade,
idParti int foreign key references Parti(idParti) on update cascade on delete cascade
)
create table Electeur (
CINelecteur varchar(30) primary key,
nomElecteur varchar(30),
prenElecteur varchar(30),
dateNE date,
adrElecteur varchar(30),
idCirconscription int foreign key references Circonscription(idCirconscription) on update cascade on delete cascade
)


insert into Region values (1,'R1')
insert into Region values (2,'R2')
insert into Region values (3,'R3')
insert into Region values (4,'R4')


insert into ProvincePrefecture values (10,'P1',1)
insert into ProvincePrefecture values (11,'P2',2)
insert into ProvincePrefecture values (12,'P3',3)
insert into ProvincePrefecture values (13,'P4',4)

insert into Circonscription values (100,'NC1',2,10)
insert into Circonscription values (101,'NC2',4,11)
insert into Circonscription values (102,'NC3',6,12)

insert into Parti values (1,'NP1')
insert into Parti values (2,'NP2')
insert into Parti values (3,'NP3')

insert into Candidat values('BB100000','NC1','PC1','2010/10/28','ADR1',100,1)
insert into Candidat values('BB100001','NC2','PC2','2000/05/17','ADR2',101,2)
insert into Candidat values('BB100002','NC3','PC3','1989/09/07','ADR3',102,3)

insert into Electeur values ('AA100000','NE1','PE1','2020/01/12','ADR1',100)
insert into Electeur values ('AA100001','NE2','PE2','2019/11/20','ADR2',101)
insert into Electeur values ('AA100002','NE3','PE3','2018/05/29','ADR3',102)

go
create procedure P1 @nomParti varchar(30),@nomCir varchar(30)
as 
begin
select*from Candidat CA,Circonscription CI,Parti P 
where CA.idCirconscription=CI.idCirconscription and CA.idParti=P.idParti and nomParti=@nomParti and nomCir=@nomCir
end

go 
create procedure P2 @idRegion int
as
begin
select count(CINelecteur) from Electeur E,Region R,ProvincePrefecture PP,Circonscription C 
where E.idCirconscription=C.idCirconscription and PP.idProvPref=C.idProvPref and R.idRegion=PP.idRegion and R.idRegion=@idRegion group by nomProvPref
end

go
create procedure P3 @nomCir varchar(30)
as
begin
--select*from Parti P,Circonscription CI,Candidat CA
--where P.idParti=CA.idParti and CA.idCirconscription= CI.idCirconscription and nomCir=@nomCir
select*from Parti 
where nomParti = 'politiques' and idParti not in
(select idParti from Circonscription CI,Candidat CA 
where CA.idCirconscription= CI.idCirconscription and nomCir=@nomCir)
end

go
create trigger T1
on Circonscription
for insert
as
begin
if exists(select*from inserted where NombreSiege<0 and NombreSiege>6)
rollback
end

go
create trigger T2
on Candidat
for insert
as
begin
if exists(select*from inserted i)
begin
insert into Electeur select I.CINcandidat,I.nomCandidat,I.prenomCandidat,I.DateNC,I.adrCandidat,I.idCirconscription 
from inserted I
end
end

select*from Region
select*from ProvincePrefecture
select*from Circonscription
select*from Parti
select*from Candidat
select*from Electeur



delete from Region
delete from ProvincePrefecture
delete from Circonscription
delete from Parti
delete from Candidat
delete from Electeur

drop table Region
drop table ProvincePrefecture
drop table Circonscription
drop table Parti
drop table Candidat
drop table Electeur


--select P.idParti,P.nomParti,count(CA.CINcandidat) as total from Circonscription CI,Parti P,Candidat CA 
--where CI.idCirconscription=CA.idCirconscription and P.idParti=CA.idParti

--select P.idParti,P.nomParti,count(CA.CINcandidat) as total from Circonscription CI,Parti P,Candidat CA 
--where CI.idCirconscription=CA.idCirconscription and P.idParti=CA.idParti and CI.idCirconscription = 100 
--group by P.idParti,P.nomParti


--delete Circonscription from Circonscription,Candidat where Candidat.idCirconscription=Circonscription.idCirconscription and idParti = 1


select*from Candidat where idCirconscription=100 and idParti=1


