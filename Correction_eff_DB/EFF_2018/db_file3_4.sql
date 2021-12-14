create database EFF2018_TP_V3_1
--remarque ses question et le meme pour EFF2018_TP_V3_2 
--just la base de donne et different
use EFF2018_TP_V3_1
create table centre_artisanal(
    num_centre_artisanal int primary key,
    nomcentre varchar(20),
	datedebutrealis date,
	budget int,
	dureerealisat int,
	datelancement date,
	nomporteurprojet varchar(20),
	lieu varchar(20)
)
create table activite_artisanal (
    idactivite int primary key,
    nomactivite varchar(20)
)
create table atelier (
    idatelier int primary key,
    nomatelier varchar(20),
	superficie varchar(20),
	prix_location  float,
	num_centre_artisanal int foreign key references centre_artisanal(num_centre_artisanal) ,
	idactivite int foreign key references activite_artisanal(idactivite),
	etat varchar(20)
)
create table artisan (
    cin int primary key,
    nomartisan varchar(20),
	prenomartisan varchar(20),
	age int,
	sexe varchar(1),
	situationfamil varchar(20)
)
create table locationatelier(
    idatelier int foreign key references atelier (idatelier),
    cin  int foreign key references artisan (cin),
	datelocation date,
	datefinlocation date,
	primary key (idatelier,cin)
)

insert into centre_artisanal values(1,'nomcentre1','2020-12-12',10,5,'2020-10-10','nomporteurprojet1','lieu1')
insert into centre_artisanal values(2,'nomcentre2','2020-12-10',10,5,'2020-10-12','nomporteurprojet2','lieu2')
insert into centre_artisanal values(3,'nomcentre3','2020-12-14',10,5,'2020-10-14','nomporteurprojet3','lieu3')

insert into activite_artisanal values(1,'nomactivite1')
insert into activite_artisanal values(2,'nomactivite2')
insert into activite_artisanal values(3,'nomactivite3')

insert into atelier values(1,'nomatelier1','superficie1',200.00,1,1,'etat1')
insert into atelier values(2,'nomatelier2','superficie2',300.00,2,2,'etat2')
insert into atelier values(3,'nomatelier3','superficie3',400.00,3,3,'etat3')

insert into artisan values(111111,'nomartisan1','prenomartisan1',28,'M','situationfamil1')
insert into artisan values(111112,'nomartisan2','prenomartisan2',30,'M','situationfamil2')
insert into artisan values(111113,'nomartisan3','prenomartisan3',35,'M','situationfamil3')

insert into locationatelier values(1,111111,'2020-05-10','2020-06-10')
insert into locationatelier values(2,111112,'2020-07-20','2020-11-20')
insert into locationatelier values(3,111113,'2020-04-10','2020-10-10')


select*from centre_artisanal
select*from activite_artisanal
select*from atelier
select*from artisan
select*from locationatelier




go
create procedure P1 @num_centre_artisanal int
as
begin
select*from centre_artisanal C,atelier A1 ,activite_artisanal A2
where C.num_centre_artisanal=A1.num_centre_artisanal
and A2.idactivite=A1.idactivite
and C.num_centre_artisanal=@num_centre_artisanal
and nomactivite='borderies'
end




go 
create procedure P3
as
begin
select nomcentre,budget
from centre_artisanal C,artisan A1,atelier A2,locationatelier L
where C.num_centre_artisanal=A2.num_centre_artisanal
and L.idatelier=A2.idatelier
and L.cin= A1.cin
group by nomcentre,budget
having count(A1.cin)>100
end


go
create procedure P2 
as
begin
select count(idatelier) as nbrAltelier from atelier where prix_location>(select avg(prix_location) from atelier)
end

exec P2


go
create procedure P4
as
begin
select* from centre_artisanal where datediff(year,datelancement,getdate())=1
end


go
create procedure P5 @annee int
as
begin
select *from where 
end



go
create trigger T1
on atelier
for update
as
begin
if exists(select*from inserted new,atelier old 
			where new.idatelier=old.idatelier
			and new.superficie<>old.superficie)
rollback
end



go
create trigger T2
on activite_artisanal
for update
as
begin
if exists(select*from inserted new,activite_artisanal old 
			where new.idactivite=old.idactivite
			and new.nomactivite<>old.nomactivite)
rollback
end

