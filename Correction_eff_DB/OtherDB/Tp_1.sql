create database gestion_cours;
use gestion_cours;
create table Etudiant (
 NumE int primary key,
 NomE varchar(20), 
 PrénomE varchar(20), 
 Ville varchar(20)
 );
create table Salles (
NumS int primary key,
 Département varchar(20)
 );
create table  Cours (
NomC varchar(20) primary key, 
Salles_NumS int,
foreign key(Salles_NumS) references Salles(NumS)
);
create table Notes (
Etudiant_NumE int, 
Cours_NomC varchar(20),
Valeur int check(valeur>0),
foreign key(Etudiant_NumE) references Etudiant(NumE),
foreign key(Cours_NomC) references Cours(NomC)
 );
create table  Horaires (
Cours_NomC varchar(20),
 Jour varchar(10), 
 Heure int primary key,
 foreign key (Cours_NomC ) references Cours(NomC) 
 );
 drop table Etudiant;
 drop table Salles;
 drop table  Cours;

