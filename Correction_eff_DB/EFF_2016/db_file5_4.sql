create database EFF2016_TP_V3_1_DB
--remarque ses question et le meme pour EFF2016_TP_V2_2 
--just la base de donne et different
use EFF2016_TP_V3_1_DB
create table formateur(
    num_formateur int primary key,
    nom_formateur varchar(30),
    prenom_formateur varchar(30),
    telephone bigint,
    adresse varchar(30),
    typee varchar(30),
)
create table formation(
    num_formation int primary key,
    nom_formation varchar(30),
    nombre_UV int,
    motdepasse varchar(30)
)
create table UV(
    num_UV int primary key,
    nom_UV varchar(30),
    masse_horaire_prevue int,
    num_formateur_enseignant int foreign key references formateur(num_formateur),
    num_formateur_responsable int foreign key references formateur(num_formateur),
    num_formation int foreign key references formation(num_formation),
)
create table chapitre(
    num_chapitre int primary key,
    nom_chapitre varchar(30),
    num_uv int foreign key references UV(num_UV),
)
create table section(
    num_section int primary key,
    nom_section varchar(30),
    num_formation int foreign key references formation(num_formation),
)
create table inscrite(
    num_inscrite int primary key,
    nom_inscrite varchar(30),
    num_section int foreign key references section(num_section),
)

insert into formateur values(1,'nom_formateur1','prenom_formateur1',060000000,'adresse1','typee1')
insert into formateur values(2,'nom_formateur2','prenom_formateur2',060000001,'adresse2','typee2')
insert into formateur values(3,'nom_formateur3','prenom_formateur3',060000002,'adresse3','typee3')

insert into formation values(1,'nom_formation1',10,'motdepasse1')
insert into formation values(2,'nom_formation2',20,'motdepasse2')
insert into formation values(3,'nom_formation3',30,'motdepasse3')

insert into UV values(1,'nom_UV1',120,1,1,1)
insert into UV values(2,'nom_UV2',100,2,2,2)
insert into UV values(3,'nom_UV3',80,3,3,3)

insert into chapitre values(1,'nom_chapitre1',1)
insert into chapitre values(2,'nom_chapitre2',2)
insert into chapitre values(3,'nom_chapitre3',3)

insert into section values(1,'nom_section1',1)
insert into section values(2,'nom_section2',2)
insert into section values(3,'nom_section3',3)

insert into inscrite values(1,'nom_inscrite1',1)
insert into inscrite values(2,'nom_inscrite2',2)
insert into inscrite values(3,'nom_inscrite3',3)

select*from formateur
select*from formation
select*from UV
select*from chapitre
select*from section
select*from inscrite

