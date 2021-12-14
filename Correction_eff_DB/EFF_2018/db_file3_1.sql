create database EFF_2018_TH
use EFF_2018_TH
create table Categorie(
    codeCat int primary key,
    libelle varchar(30)
)
create table Film(
    codeF int primary key,
    Titre varchar(30),
    description varchar(30),
    langue varchar(30),
    anneeProduction int,
    codeCat int foreign key references Categorie(codeCat)
)
create table Juge(
    codeJuge int primary key,
    nom varchar(30),
    prenom varchar(30),
    nationalite varchar(30),
)
create table Vote(
    codeF int foreign key references Film(codeF),
    codeJuge int foreign key references Juge(codeJuge),
    primary key(codeF,codeJuge)
)

insert into Categorie values(1,'libelleV1')
insert into Categorie values(2,'libelleV2')
insert into Categorie values(3,'libelleV3')

insert into Film values(1,'Titre1','description1','langue1',2018,1)
insert into Film values(2,'Titre2','description2','langue2',2019,2)
insert into Film values(3,'Titre3','description3','langue3',2020,3)

insert into Juge values(1,'nom1','prenom1','nationalite')
insert into Juge values(2,'nom2','prenom2','nationalite')
insert into Juge values(3,'nom3','prenom3','nationalite')

insert into Vote values(1,1)
insert into Vote values(2,2)
insert into Vote values(3,3)
insert into Vote values(3,2)


select*from Categorie
select*from Film
select*from Juge
select*from Vote


alter table Film
add constraint C1
check (anneeProduction>getdate())


select F.* from Film F,Categorie C 
where F.codeCat=C.codeCat 
and libelle='Action'
and anneeProduction>=2016

select J.nom,J.prenom from Juge J,Vote V,Film F
where J.codeJuge=V.codeJuge
and F.codeF=V.codeF
and Titre='Avatar'


select J.nom,J.prenom from Juge J,Vote V
where J.codeJuge=V.codeJuge
and F.codeF=(select codeF from Film where Titre='Avatar')


select F.Titre,count(distinct V.codeJuge) as nbrVote from Film F,Vote V 
where F.codeF=V.codeF
group by F.Titre
order by nbrVote desc



select J.nom+'  '+J.prenom as fullname from Juge J,Film F,Vote V
where J.codeJuge=V.codeJuge
and F.codeF=V.codeF
and F.codeF like (select F.codeF from Film F,Vote V,Juge J 
where J.codeJuge=V.codeJuge
and F.codeF=V.codeF
and nom='Alberto'
and prenom='Toni')

