create database EFF_2016_TH
use EFF_2016_TH
create table Etablisement(
    codeEtab int primary key,
    nomEtab varchar(30),
    ville varchar(30)
)
create table PointConsommation(
    codePC int primary key,
    nomPC varchar(30),
    codeEtab int foreign key references Etablisement(codeEtab),
    cumulMontantConsommation int
)
create table Article(
    codeArt int primary key,
    nomArt varchar(30),
    typee varchar(30),
    PU int
)
create table Etab_Art(
    codeEtab int foreign key references Etablisement(codeEtab),
    codeArt int foreign key references Article(codeArt),
    QteStock int check(QteStock>=0)
)
create table SortieArt(
    numBon int primary key,
    DateS date,
    Qte int,
    codeArt int foreign key references Article(codeArt),
    codePCons int foreign key references PointConsommation(codePC),
)

insert into Etablisement values(1,'nomEtab1','ville1')
insert into Etablisement values(2,'nomEtab2','ville2')
insert into Etablisement values(3,'nomEtab3','ville3')

insert into PointConsommation values(1,'nomPC1',1,10)
insert into PointConsommation values(2,'nomPC2',2,20)
insert into PointConsommation values(3,'nomPC3',3,30)

insert into Article values(1,'nomArt1','typee1',10)
insert into Article values(2,'nomArt2','typee2',20)
insert into Article values(3,'nomArt3','typee3',30)

insert into Etab_Art values(1,1,100)
insert into Etab_Art values(2,2,200)
insert into Etab_Art values(3,3,300)

insert into SortieArt values(1,'2020-10-10',10,1,1)
insert into SortieArt values(2,'2020-11-11',20,2,2)
insert into SortieArt values(3,'2020-12-12',30,3,3)

select*from Etablisement
select*from PointConsommation
select*from Article
select*from Etab_Art
select*from SortieArt


select E.nomEtab ,sum(S.Qte)
from SortieArt S,Etablisement E,PointConsommation P
where S.codePCons=P.codePC
and P.codeEtab=E.codeEtab
group by(E.nomEtab)


go
create function F1(@dateD date,@dateF date,@codeE int)
returns float
as
begin
return (select sum(S.Qte)*A.PU 
from Article A,SortieArt S,PointConsommation P
where A.codeArt=S.codeArt
and S.codePCons=P.codePC
and P.codeEtab=@codeE
and DateS between @dateD and @dateF
group by A.PU)
end


go
create procedure Transferer @codeES int,@codeED int,@codeA int,@Qte int
as
begin
declare @QteStock int
select QteStock=@QteStock from Etab_Art where codeEtab=@codeES

if(@Qte>@QteStock)
    print'code Erreur 2'
    
else if(@Qte=@QteStock)
    print'code Erreur 3'
else 
begin

update Etab_Art
set QteStock=QteStock-@Qte
where codeEtab=@codeES
insert into Etab_Art values(@codeED,@codeA,@Qte)

end

end


go
create trigger T1
on SortieArt
for insert 
as
begin

declare @codePC int
declare @Qte int
declare @codeArt int
select codePCons=@codePC,Qte=@Qte,codeArt=@codeArt from inserted 

if exists(select*from inserted)
begin
update PointConsommation
set cumulMontantConsommation=@Qte*(select PU from Article where codeArt=@codeArt)
where codePC=@codePC

end

end



go
create trigger T2
on SortieArt
for insert 
as
begin
if exists(select*from inserted I,Etab_Art EA,Article A
                where I.codeArt=A.codeArt
                and EA.codeArt=A.codeArt
                and I.Qte>EA.QteStock*0.2)
Rollback
end

