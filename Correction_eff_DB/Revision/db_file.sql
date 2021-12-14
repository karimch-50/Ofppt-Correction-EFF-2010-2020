create database VideoClube
use VideoClube
create table FORMULE(
    NuFormule int primary key,
    Nom varchar(30),
    PrixCotisation float check(PrixCotisation>20),
    PrixVideo float
)
create table ABONNE(
    NuAbonne int primary key,
    Nom varchar(30),
    Prenom varchar(30),
    Adresse varchar(30),
    NuFormule int,
    DateAbonnement date,
    DateCotisation Date
)
create table VIDEO(
    CodeVideo int primary key,
    Titre varchar(30),
    Realisateur varchar(30),
    DateSortie date
)
create table EXEMPLAIRE(
    CodeVdeo int foreign key  references VIDEO(CodeVideo),
    NuExemplaire int ,
    Formatt varchar(30),
    primary key(CodeVdeo,NuExemplaire)
)
create table EMPRUNT(
    NuAbonne int foreign key references ABONNE(NuAbonne),
    CodeVideo int,
    NuExemplaire int,
    foreign key (CodeVideo,NuExemplaire ) references EXEMPLAIRE(CodeVdeo,NuExemplaire),
    DateLocation date,
    DateRendu date,
    primary key(NuAbonne,CodeVideo,NuExemplaire,DateLocation),
)
create table ASSOCIATION(
    CodeVdeo int foreign key  references VIDEO(CodeVideo),
    CodeVdeoAssocie int foreign key  references VIDEO(CodeVideo),
    primary key(CodeVdeo,CodeVdeoAssocie)
)


insert into FORMULE VALUES (1,'Nom1',100.00,10.00)
insert into FORMULE VALUES (2,'Nom2',200.00,20.25)
insert into FORMULE VALUES (3,'Nom3',300.00,30.50)

insert into ABONNE VALUES (1,'Nom1','Prenom1','adresse1',1,'2020-10-10','2020-10-20')
insert into ABONNE VALUES (2,'Nom2','Prenom2','adresse2',2,'2020-11-10','2020-12-20')
insert into ABONNE VALUES (3,'Nom3','Prenom3','adresse3',3,'2020-12-10','2020-12-20')

insert into VIDEO VALUES (1,'Titre1','Realisateur1','2020-10-10')
insert into VIDEO VALUES (2,'Titre2','Realisateur2','2020-11-11')
insert into VIDEO VALUES (3,'Titre3','Realisateur3','2020-12-12')

insert into EXEMPLAIRE VALUES (1,1,'Formatt1')
insert into EXEMPLAIRE VALUES (2,2,'Formatt1')
insert into EXEMPLAIRE VALUES (3,3,'Formatt1')

insert into EMPRUNT VALUES (1,1,1,'2020-10-10','2020-10-20')
insert into EMPRUNT VALUES (2,2,2,'2020-11-1','2020-10-20')
insert into EMPRUNT VALUES (3,3,3,'2020-12-10','2020-10-20')

insert into ASSOCIATION VALUES (1,1)
insert into ASSOCIATION VALUES (2,2)
insert into ASSOCIATION VALUES (3,3)

select*from FORMULE
select*from ABONNE
select*from VIDEO
select*from EXEMPLAIRE
select*from EMPRUNT
select*from ASSOCIATION


update VIDEO set Titre='Avatar' where CodeVideo=15

alter table FORMULE
alter column PrixVideo float



alter table VIDEO
add  nombre_exemplaires int


--6)cursors

declare @nombre_exemplaires int
declare @CodeVideo varchar(30)

declare myc cursor for select CodeVideo,count(*) as nbr_ex from VIDEO group by CodeVideo
open myc
while(@@FETCH_STATUS=0)
begin
fetch myc into @CodeVideo,@nombre_exemplaires
    update VIDEO
    set nombre_exemplaires=@nombre_exemplaires
    where CodeVideo=@CodeVideo
end
close myc
deallocate myc



update FORMULE
set PrixVideo=PrixVideo+10
where NuFormule in (select from where year(DateAbonnement)>2012) 


alter table 
add constraint C1
check(Nom)


select*from VIDEO where Titre like('s%e')

--2_3)

select*from FORMULE where Nom like('')

select CodeVideo,substring(Realisateur,1,3) from VIDEO 


select V.* from VIDEO V,EMPRUNT E 
where V.CodeVideo=E.CodeVideo 
and datediff(year,DateLocation,getdate())>3


select*from ABONNE 
where datediff(month,DateAbonnement,DateCotisation)=6


--3_3)
select*from ABONNE where 


--3_4)
select*from VIDEO where day(DateSortie)>6


select top(1)* from FORMULE order by PrixVideo asc


select top(1)* from FORMULE order by PrixVideo desc


select avg(PrixVideo) from FORMULE 



select Realisateur from VIDEO group by Realisateur having count(CodeVideo)>10 


select Realisateur,count(CodeVideo) as nbrVideo from VIDEO group by Realisateur


select count(CodeVideo), from ABONNE A,EXEMPLAIRE E where


go
create procedure P1 @nom varchar(30)
as
begin
select count(*) from ABONNE where Nom=@Nom
end


go
create procedure P2 @CodeVdeo int
as
begin
select count(NuExemplaire) from EXEMPLAIRE where CodeVdeo=@CodeVdeo
end



go
create procedure P3 @CodeVdeo int
as
begin
select*,case(
            when then 'emprunte'
            else 'non_emprunte'
                    ) from EXEMPLAIRE 
                        where CodeVdeo=@CodeVdeo

end


--cursor

declare @codevideo int 
declare @titre varchar(30)
declare @Realisateur varchar(30)
declare @DateSortie date

declare Myc2 cursor for select codevideo,titre,Realisateur,DateSortie from VIDEO
open Myc2
fetch Myc2 into @codevideo,@titre,@Realisateur,@DateSortie
while(@@FETCH_STATUS=0)
begin
print 'la video numero :'+cast(@codevideo as varchar(30))+' intitulee:'+@titre+' a ete realisee par le realisateur:'+@Realisateur+' et sortie depuis:'+cast(@DateSortie as varchar(30))
fetch Myc2 into @codevideo,@titre,@Realisateur,@DateSortie
end
close Myc2
deallocate Myc2


go
create function F1(@DateCotisation date)
returns int
as
begin
return(select count(*) from ABONNE where DateCotisation=@DateCotisation)
end


go
create function F2(@NuAbonne int)
returns varchar(100)
as
begin
return(select Nom+' '+Prenom+' '+ Adresse from ABONNE where NuAbonne=@NuAbonne)
end


go
create function F3(@PrixVideo float)
returns int
as
begin
return(select count(*) from FORMULE where PrixVideo=@PrixVideo and PrixCotisation=PrixVideo)
end


go
create function F4(@NuAbonne int)
returns int
as
begin
return(select count(*) from EXEMPLAIRE E1,EMPRUNT E2 
    where E1.CodeVdeo=E2.CodeVideo 
    and NuAbonne=@NuAbonne)
end


go
create function F5()
returns table
as
return(select Realisateur,count(CodeVideo) as nombre_video from VIDEO group by Realisateur )

go
select*from F5()



go
create function F6()
returns table
as
return(select CodeVideo,nombre_exemplaires from VIDEO)

go
select*from F6()



go
create function F7(@NuAbonne int)
returns table
as
return(select V.CodeVideo,V.Titre,V.Realisateur,V.DateSortie 
        from VIDEO V,ABONNE A,EMPRUNT E,EXEMPLAIRE Ex
        where V.CodeVideo=EX.CodeVdeo
        and Ex.CodeVdeo=E.CodeVideo
        and A.NuAbonne=E.NuAbonne
        and A.NuAbonne=@NuAbonne)

go
select*from F7()




declare 


