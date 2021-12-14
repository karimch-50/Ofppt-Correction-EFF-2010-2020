create database EFF2010_TP_V2_1_DB
--remarque ses question et le meme pour EFF2010_TP_V2_2 aussi pour EFF2010_TP_V2_3 
--just la base de donne et different
use EFF2010_TP_V2_1_DB
create table Ville(
    code_ville int primary key,
    nom_ville varchar(30)
)
create table Benvole(
    code_benevole int primary key,
    nom_benevole varchar(30),
    prenom_benevole varchar(30),
    adresse_benevole varchar(30),
    telephone_benevole varchar(30),
    mail_benevole varchar(30),
    login_benevole varchar(30),
    passe_benevole varchar(30),
)
create table Categorie(
    code_categorie int primary key,
    nom_categorie varchar(30),
)
create table Association(
    code_association int primary key,
    nom_association varchar(30),
    adresse_association varchar(30),
    contrate_association varchar(30),
    telephone_association varchar(30),
    fax_association varchar(30),
    mail_association varchar(30),
    web_association varchar(30),
    login_association varchar(30),
    pass_association varchar(30),
    code_ville int foreign key references Ville(code_ville)
)
create table Action(
    code_action int primary key,
    titre_action varchar(30),
    description_action varchar(30),
    date_debut date,
    date_fin date,
    etat varchar(30),
    code_ville int foreign key references Ville(code_ville),
    code_categorie int foreign key references Categorie(code_categorie),
    code_association int foreign key references Association(code_association)
)
create table condidature(
    code_benevole int foreign key references Benvole(code_benevole),
    code_action int foreign key references Action(code_action),
    date_candidature date,
    message_candidat varchar(30),
    primary key(code_benevole,code_action)
)
create table Competence(
    code_comptence int primary key,
    nom_comptence varchar(30),
    description_comptence varchar(30)
)
create table exiger(
    code_comptence int foreign key references Competence(code_comptence),
    code_action int foreign key references Action(code_action),
    primary key(code_comptence,code_action)
)

insert into Ville values(1,'nom_ville1')
insert into Ville values(2,'nom_ville2')
insert into Ville values(3,'nom_ville3')

insert into Benvole values(1,'nom_benevole1','prenom_benevole1','adresse_benevole1','0600000000','mail_benevole1','login_benevole1','passe_benevole1')
insert into Benvole values(2,'nom_benevole2','prenom_benevole2','adresse_benevole2','0600000001','mail_benevole2','login_benevole2','passe_benevole2')
insert into Benvole values(3,'nom_benevole3','prenom_benevole3','adresse_benevole3','0600000002','mail_benevole3','login_benevole3','passe_benevole3')

insert into Categorie values(1,'nom_categorie1')
insert into Categorie values(2,'nom_categorie2')
insert into Categorie values(3,'nom_categorie3')

insert into Association values(1,'nom_association1','adresse_benevole1','contrate_association1','0600000010','0500000000','mail_association1','web_association1','login_association1','pass_association1',1)
insert into Association values(2,'nom_association2','adresse_benevole2','contrate_association2','0600000012','0500000001','mail_association2','web_association2','login_association2','pass_association2',2)
insert into Association values(3,'nom_association3','adresse_benevole3','contrate_association3','0600000013','0500000002','mail_association3','web_association3','login_association3','pass_association3',3)

insert into Action values(1,'titre_action1','description_action1','2020-10-10','2021-10-10','etat1',1,1,1)
insert into Action values(2,'titre_action2','description_action2','2020-10-20','2021-10-20','etat2',2,2,2)
insert into Action values(3,'titre_action3','description_action3','2020-10-30','2021-10-30','etat3',3,3,3)

insert into condidature values(1,1,'2020-10-10','message_candidat1')
insert into condidature values(2,2,'2020-10-12','message_candidat2')
insert into condidature values(3,3,'2020-10-14','message_candidat3')

insert into Competence values(1,'nom_comptence1','description_comptence1')
insert into Competence values(2,'nom_comptence2','description_comptence2')
insert into Competence values(3,'nom_comptence3','description_comptence3')

insert into exiger values(1,1)
insert into exiger values(2,2)
insert into exiger values(3,3)




select*from Ville
select*from Benvole
select*from Categorie
select*from Association
select*from Action
select*from condidature
select*from Competence
select*from exiger
