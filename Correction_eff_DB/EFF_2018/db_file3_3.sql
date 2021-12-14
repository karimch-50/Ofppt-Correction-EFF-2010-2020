create database EFF2018_TP_V2_1
--remarque ses question et le meme pour EFF2018_TP_V2_2 
--just la base de donne et different
use EFF2018_TP_V2_1
create table Medicament(
NumMedicament int primary key,
designation varchar(30),
forme varchar(30),
datePeremptin date,
StockActuel int,
StockMin int,
)
create table Medecin(
NumMedecin int primary key,
NomMd varchar(30),
prenomMd varchar(30),
specialite varchar(30),
loginMd varchar(30) unique,
passMd varchar(30),
)
create table Pharmacien(
NumPharmacien int primary key,
NomPh varchar(30),
prenomPh varchar(30),
loginPh varchar(30) unique,
passPh varchar(30)
)
create table Patient(
NumPatient int primary key,
NomP varchar(30),
prenomP varchar(30),
dateNaissance date
)
create table Ordonnace(
NumOrdonnace int primary key identity,
NumPatient int foreign key references Patient(NumPatient),
NumMedecin int foreign key references Medecin(NumMedecin),
dateOrdonnace date
)
create table DetailOrdonnace(
NumOrdonnace int foreign key references Ordonnace(NumOrdonnace),
NumMedicament int foreign key references Medicament(NumMedicament),
qttePrescrite int,
primary key(NumOrdonnace,NumMedicament)
)

insert into Medicament values(1,'di1','forme1','2020/12/12',1000,120)
insert into Medicament values(6,'di1','forme1','2020/12/12',1000,120)
insert into Medicament values(7,'di1','forme1','2020/12/12',1000,120)
insert into Medicament values(2,'di2','forme2','2020/10/10',1000,120)
insert into Medicament values(3,'di3','forme3','2020/08/08',1000,120)
insert into Medicament values(4,'di4','comprimes','2020/11/01',102,10)
insert into Medicament values(5,'di5','pommade','2021/10/12',100,100)

insert into Medecin values(1,'NMd1','PMd1','specialite1','loginMd1','passMd1')
insert into Medecin values(2,'NMd2','PMd2','specialite2','loginMd2','passMd2')
insert into Medecin values(3,'NMd3','PMd3','specialite3','loginMd3','passMd3')

insert into Pharmacien values(1,'NomPh1','prenomPh1','loginPh1','passPh1')
insert into Pharmacien values(2,'NomPh2','prenomPh2','loginPh2','passPh2')
insert into Pharmacien values(3,'NomPh3','prenomPh3','loginPh3','passPh3')

insert into Patient values(1,'NomP1','prenomP1','1985/11/19')
insert into Patient values(2,'NomP2','prenomP2','1990/07/27')
insert into Patient values(3,'NomP3','prenomP3','1980/01/13')

insert into Ordonnace values(1,1,'2021/02/28')
insert into Ordonnace values(2,2,'2021/03/15')
insert into Ordonnace values(3,3,'2021/03/22')

insert into DetailOrdonnace values(1,1,19)
insert into DetailOrdonnace values(2,2,102)
insert into DetailOrdonnace values(2,3,76)

select*from Medicament 
select*from Medecin 
select*from Pharmacien 
select*from Patient 
select*from Ordonnace 
select*from DetailOrdonnace 


alter table Medicament
add constraint C1
check(forme in ('comrimes','gelules','sirop','spray','pommade'))


alter table Medicament
add constraint C2
check(StockActuel>=StockMin)


alter table Medecin
alter column passMd varchar(30) not null

select*from Medicament 
where NumMedicament 
in(select top 5 NumMedicament 
    from DetailOrdonnace
    order by qttePrescrite asc)

go
create function F1(@nom varchar(30))
returns int
as
begin
return (select count(O.NumOrdonnace) 
from Ordonnace O,Medecin M,DetailOrdonnace D
where O.NumMedecin=M.NumMedecin
and O.NumOrdonnace=D.NumOrdonnace
and NomMd=@nom
and D.qttePrescrite>0)
end

go
create procedure P1 @sp varchar(30)
as
begin
select M.* from Medecin M
where specialite='ee'
and NumMedecin in(select NumMedecin
from Ordonnace 
where month(dateOrdonnace)=month(getdate()) 
group by NumMedecin 
having count(*)>50)
end

go
create procedure P2(@tauxD int)
as
begin
update Medicament 
set StockMin=StockMin-@tauxD 
where NumMedicament not in(select NumMedicament 
                    from DetailOrdonnace )
end




go
create trigger T1
on DetailOrdonnace
for insert
as
begin

if exists(
    select*from inserted I,Ordonnace O
    where I.NumOrdonnace=O.NumOrdonnace
    and month(O.dateOrdonnace)=month(getdate())
    having sum(qttePrescrite)>20
    )
begin
    rollback
end

else
    begin
        insert into DetailOrdonnace select*from inserted

        update Medicament 
        set StockActuel= StockActuel-(
            select qttePrescrite 
            from inserted)
    end
end
