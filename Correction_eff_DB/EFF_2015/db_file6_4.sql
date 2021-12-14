create database EFF2015_TP_V3_1_DB
--remarque ses question et le meme pour EFF2015_TP_V2_2 est EFF2015_TP_V2_3 
--just la base de donne et different
use EFF2015_TP_V3_1_DB
create table Pays (
    idpays int primary key, 
    nompays varchar(30)
)
create table Jeu (
    idJeu int primary key, 
    nomJeu varchar(30), 
    nbpartiespossibles int, 
    somme float
)
create table Joueur (
    idJoueur int primary key, 
    nom varchar(30), 
    prenom varchar(30), 
    dateN date, 
    email varchar(30), 
    pass varchar(30), 
    etatcivir varchar(30), 
    idpays int foreign key references Pays(idpays)
)
create table Serveur (
    idServeur int primary key, 
    ipServeur varchar(30)
)
create table Partie (
    idpartie int primary key, 
    datepartie date, 
    idServeur int foreign key references Serveur(idServeur), 
    idJeu int foreign key references Jeu(idJeu)
)
create table Participer_partie (
    idJoueur int foreign key references Joueur(idJoueur),
    idpartie int foreign key references Partie(idpartie), 
    score float,
    primary key(idJoueur,idpartie)
)

insert into Pays values(1,'nompays1')
insert into Pays values(2,'nompays2')
insert into Pays values(3,'nompays3')

insert into Jeu values(1,'nomJeu1',10,10.00)
insert into Jeu values(2,'nomJeu2',20,20.00)
insert into Jeu values(3,'nomJeu3',30,30.00)

insert into Joueur values(1,'nom1','prenom1','2000-10-10','email1','pass1','etatcivir1',1)
insert into Joueur values(2,'nom2','prenom2','2000-11-11','email2','pass2','etatcivir2',2)
insert into Joueur values(3,'nom3','prenom3','2000-12-12','email3','pass3','etatcivir3',3)

insert into Serveur values(1,'ipServeur1')
insert into Serveur values(2,'ipServeur2')
insert into Serveur values(3,'ipServeur3')

insert into Partie values(1,'2020-10-10',1,1)
insert into Partie values(2,'2020-11-11',2,2)
insert into Partie values(3,'2020-12-12',3,3)

insert into Participer_partie values(1,1,100.00)
insert into Participer_partie values(2,2,200.00)
insert into Participer_partie values(3,3,300.00)


select*from Pays
select*from Jeu
select*from Joueur
select*from Serveur
select*from Partie
select*from Participer_partie


