--drop database EFF_2019_TH
create database EFF_2019_TH
use EFF_2019_TH
--use master
create table Pelerin(
    Numpelerin varchar(30) primary key,
    Nom varchar(30),
    Prenom varchar(30),
    age int,
    photo varchar(30),
    Sexe varchar(1),
    pays varchar(30),
    num_passport int
)
create table Hotel(
    numhotel int primary key,
    nomhotel varchar(30),
    nombreetoile varchar(30),
    ville varchar(30),
)
create table Chambre (
    idchambre int primary key,
    Typee varchar(30),
    Etage int,
    nb_list_max int,
    typeee varchar(30),
    numhotel int foreign key references Hotel(numhotel)
)
create table Accompagner(
    idAccompagner varchar(30) primary key,
    Numpelerin varchar(30) foreign key references Pelerin (Numpelerin),
    Nom varchar(30),
    Prenom varchar(30),
    age int,
    photo varchar(30),
    Sexe varchar(1),
    pays varchar(30),
    num_passport int
)
create table Hebergement(
    Numpelerin varchar(30) foreign key references Pelerin(Numpelerin),
    idchambre int foreign key references Chambre(idchambre),
    date_entree date,
    date_sortie date,
    primary key(Numpelerin,idchambre)
)

insert into Pelerin values(1,'nom1','prenom1',39,'photo1','M','Pays1',10)
insert into Pelerin values(2,'nom2','prenom2',60,'photo2','M','Pays2',11)
insert into Pelerin values(3,'nom3','prenom3',65,'photo3','M','Pays3',12)
insert into Pelerin values(4,'nom3','prenom3',120,'photo3','M','Pays3',12)


insert into Hotel values(1,'nomhotel1',4,'ville1')
insert into Hotel values(2,'nomhotel2',5,'ville2')
insert into Hotel values(3,'nomhotel3',2,'ville3')

insert into Chambre values(1,'Type1',4,12,'type1',1)
insert into Chambre values(2,'Type2',3,10,'type2',2)
insert into Chambre values(3,'Type3',5,8,'type3',3)

insert into Accompagner values(1,1,'nom1','prenom1',39,'photo1','M','Pays1',10)
insert into Accompagner values(2,2,'nom2','prenom2',40,'photo2','F','Pays2',11)
insert into Accompagner values(3,3,'nom3','prenom3',38,'photo3','M','Pays3',12)

insert into Hebergement values (1,1,'2020-10-10','2020-12-10')
insert into Hebergement values (2,2,'2020-08-10','2020-10-10')
insert into Hebergement values (3,3,'2020-06-10','2020-08-10')

select*from Pelerin
select*from Hotel
select*from Chambre
select*from Accompagner
select*from Hebergement


select pays,count(Numpelerin) as nbrPelerin from Pelerin group by pays

select nomhotel from Hotel H1,Pelerin P,Chambre C,Hebergement H2 
where H1.numhotel = C.numhotel 
and P.Numpelerin=H2.Numpelerin 
and C.idchambre=H2.idchambre
and P.pays<>'marocaine'

select P.Nom,A.Nom from Pelerin P,Accompagner A where P.Numpelerin=A.Numpelerin


go
create function F1 (@date date,@numhotel int)
returns int
as
begin
    return (select ((count(C.idchambre)*sum(nb_list_max))/100) 
    from Chambre C,Hebergement H
     where C.idchambre=H.idchambre 
     and C.numhotel=@numhotel
     and date_sortie>@date)
end

go
alter procedure P1 
as
begin 
    select P.Numpelerin from Pelerin P,Pelerin PA,Accompagner A 
    where P.Numpelerin=A.Numpelerin
    and PA.Numpelerin=A.Numpelerin
    and PA.Numpelerin='1'
end

exec P1

go
create trigger T1
on Accompagner
for insert 
as
begin 
    if exists(select*from inserted where Sexe='F')
    begin
    rollback
    end
end




alter table Hotel
add constraint C
check(nomhotel like 'A%')

alter table Hotel
add constraint C3
check (ville like upper(substring(ville,1,1)))


    -- alter table Hotel
    -- ADD CONSTRAINT uppercase 
    -- CHECK (ASCII(LEFT(ville, 1)) BETWEEN ASCII('A') and ASCII('Z'));

select*from Hotel

alter table Hotel
drop constraint C1

select*from Pelerin

alter table Pelerin 
add constraint C1
check (age between 1 and 100)








