create database EFF_2020_TH
use EFF_2020_TH
create table Ville(
    idV int primary key,
    libelleV varchar(30)
)
create table Participant(
    idP int primary key,
    nom varchar(30),
    prenom varchar(30),
    civilite varchar(30),
    tel bigint,
    idV int foreign key references Ville(idV)
)
create table Blague(
    idBlague int primary key,
    idP int foreign key references Participant(idP),
    intitule varchar(30),
    contenu varchar(30),
    nobreVote int
)
create table Vote (
    IDSESSION int primary key,
    idBlague int foreign key references Blague(idBlague),
    date_vote date
)

insert into Ville values(1,'libelleV1')
insert into Ville values(2,'libelleV2')
insert into Ville values(3,'libelleV3')
insert into Ville values(4,'fes')

insert into Participant values(1,'nom1','prenom1','civilote1',0600000001,1)
insert into Participant values(2,'nom2','prenom2','civilote2',0600000002,2)
insert into Participant values(3,'nom3','prenom3','civilote3',0600000003,3)

insert into Blague values(1,1,'intitule1','contenu1',12)
insert into Blague values(2,2,'intitule2','contenu2',20)
insert into Blague values(3,3,'intitule3','contenu3',100)

insert into Vote values(1,1,'2020-12-12')
insert into Vote values(2,2,'2020-12-10')
insert into Vote values(3,3,'2020-12-08')
insert into Vote values(4,3,'2020-12-06')
insert into Vote values(5,3,'2020-12-06')



select*from Ville
select*from Participant
select*from Blague
select*from Vote



select top(3)idBlague from Blague order by nobreVote


delete from Blague where  nobreVote<3

select nom,prenom from Participant P,Ville V where P.idV=V.idV and libelleV='fes'

select nom,prenom,count(idBlague) as NBRBlague from Participant P ,Blague B where P.idP=B.idP group by nom,prenom having count(idBlague)>2

select top (3) count(IDSESSION) as nbrVote,nom,prenom from Participant P ,Blague B,Vote V where P.idP=B.idP and V.idBlague=B.idBlague group by nom,prenom order by  nbrVote desc

go
create procedure P1 @id int
as
begin 
    select count(IDSESSION)as nbrVote from Vote V,Participant P,Blague B where P.idP=B.idP and V.idBlague=B.idBlague and P.idP=@id
end

exec P1 @id=1


go
alter trigger T1
on Vote
for insert
as
begin
    declare @id int
    if exists (select*from inserted)
    begin
        set  @id=(select idBlague from inserted)
        update Blague set nobreVote+=1 where idBlague=@id
    end
end
