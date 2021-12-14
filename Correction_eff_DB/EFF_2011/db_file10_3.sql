create database EFF2011_TP_V2_1_DB
--remarque ses question et le meme pour EFF2011_TP_V2_2 aussi pour EFF2011_TP_V2_3 
--just la base de donne et different
use EFF2011_TP_V2_1_DB
create table Personne(
    loginn varchar(30) primary key,
    nom_personne varchar(30),
    prenom_personne varchar(30),
    passe varchar(30),
    email varchar(30)
)
create table Ville(
    code_ville int primary key,
    nom_ville varchar(30)
)
create table Caleche(
    code_caleche int primary key,
    description_caleche varchar(30),
    loginn varchar(30) foreign key references Personne(loginn),
    code_ville int foreign key references Ville(code_ville)
)
create table Imagee(
    code_imagee int primary key,
    chemin_image varchar(30),
    description_image varchar(30),
    code_caleche int foreign key references Caleche(code_caleche)
)
create table Circuit(
    code_circuit int primary key,
    description_circuit varchar(30),
    prix_moyen money,
    code_ville int foreign key references Ville(code_ville)
)

insert into Personne values('loginn1','nom_personne1','prenom_personne1','passe1','email1')
insert into Personne values('loginn2','nom_personne2','prenom_personne2','passe2','email2')
insert into Personne values('loginn3','nom_personne3','prenom_personne3','passe3','email3')

insert into Ville values(1,'nom_ville1')
insert into Ville values(2,'nom_ville2')
insert into Ville values(3,'nom_ville3')

insert into Caleche values(1,'description_caleche1','loginn1',1)
insert into Caleche values(2,'description_caleche2','loginn2',2)
insert into Caleche values(3,'description_caleche3','loginn3',3)

insert into Imagee values(1,'chemin_image1','description_image1',1)
insert into Imagee values(2,'chemin_image2','description_image2',2)
insert into Imagee values(3,'chemin_image3','description_image3',3)

insert into Circuit values(1,'description_circuit1',100.00,1)
insert into Circuit values(2,'description_circuit2',200.00,2)
insert into Circuit values(3,'description_circuit3',300.00,3)


select*from Personne 
select*from Ville 
select*from Caleche 
select*from Imagee 
select*from Circuit 
