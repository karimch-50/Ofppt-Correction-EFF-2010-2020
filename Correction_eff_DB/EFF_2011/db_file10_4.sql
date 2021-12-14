create database EFF2011_TP_V3_1_DB
--remarque ses question et le meme pour EFF2011_TP_V3_2 est EFF2011_TP_V3_3 
--just la base de donne et different
use EFF2011_TP_V3_1_DB
create table Membre(
    login varchar(30) primary key,
    nom varchar(30),
    prenom varchar(30),
    email varchar(30),
    passe varchar(30)
) 
create table Theme(
    code_theme int primary key,
    nom_theme varchar(30),
    description_theme varchar(30)
)
create table Document(
    code_document int primary key,
    document_document varchar(30),
    chemin_document varchar(30),
    date_envoi date,
    etat_document varchar(30),
    code_theme int foreign key references Theme(code_theme),
    login varchar(30) foreign key references Membre(login),
)
create table Commentaire(
    code_commentaire int primary key,
    date_commentaire date,
    text_commentaire varchar(30),
    etat_commentaire varchar(30),
    code_document int foreign key references Document(code_document),
    login varchar(30) foreign key references Membre(login),
)
create table Role(
    nom_rol varchar(30) primary key
)
create table Role_utilisateur(
    login varchar(30) foreign key references Membre(login),
    nom_rol varchar(30) foreign key references Role(nom_rol),
    primary key(login,nom_rol)
)

insert into Membre values('login1','nom1','prenom1','email1','passe1')
insert into Membre values('login2','nom2','prenom2','email2','passe2')
insert into Membre values('login3','nom3','prenom3','email3','passe3')

insert into Theme values(1,'nom_theme1','description_theme1')
insert into Theme values(2,'nom_theme2','description_theme2')
insert into Theme values(3,'nom_theme3','description_theme3')

insert into Document values(1,'document_document1','chemin_document1','2020-10-10','etat_document1',1,'login1')
insert into Document values(2,'document_document2','chemin_document2','2020-11-11','etat_document2',2,'login2')
insert into Document values(3,'document_document3','chemin_document3','2020-12-12','etat_document3',3,'login3')

insert into Commentaire values(1,'2020-10-10','text_commentaire1','etat_commentaire1',1,'login1')
insert into Commentaire values(2,'2020-11-11','text_commentaire2','etat_commentaire2',2,'login2')
insert into Commentaire values(3,'2020-12-12','text_commentaire3','etat_commentaire3',3,'login3')

insert into Role values('nom_rol1')
insert into Role values('nom_rol2')
insert into Role values('nom_rol3')

insert into Role_utilisateur values('login1','nom_rol1')
insert into Role_utilisateur values('login2','nom_rol2')
insert into Role_utilisateur values('login3','nom_rol3')

select*from Membre
select*from Theme
select*from Document
select*from Commentaire
select*from Role
select*from Role_utilisateur








