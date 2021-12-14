create database TP_5;
use TP_5;
Create table Matiere(
ID_Mat int primary key, 
Intitule varchar(30) not null unique,
Dscription varchar(100)
 );
drop table Matiere;
Create table Groupe (
ID_Gr int primary key,
LibG varchar(20),
Effectif int
 );
Create table Etudiant (
ID_Etu int primary key, 
Nom varchar(30), 
Prénom varchar(30), 
Date_Naissance date, 
Adresse varchar(50), 
Ville varchar(20), 
CP varchar(20), 
Email varchar(20) check(email like '%@%.%'),
Groupe_ID_Gr int,
foreign key (Groupe_ID_Gr) references Groupe(ID_Gr)
 );
 drop table Etudiant;
Create table Formateur (
ID_For int primary key, 
Nom varchar(20), 
Prenom varchar(20), 
Typee varchar(20) check(typee in('Vacataire','Contractuel','statutaire')) default 'Vacataire', 
Date_Emb date, 
Email varchar(20), 
Salaire int
);
Create table Former (
Formateur_ID_For int, 
Groupe_ID_Gr int,
foreign key (Formateur_ID_For) references Formateur(ID_For),
foreign key (Groupe_ID_Gr) references Groupe(ID_Gr)
);
Create table Enseigne (
Matiere_ID_Mat int, 
Formateur_ID_For int,
MasseHoraire int,
primary key(Matiere_ID_Mat,Formateur_ID_For),
foreign key (Matiere_ID_Mat) references Matiere(ID_Mat),
foreign key (Formateur_ID_For) references Formateur(ID_For)
 );
Create table Salle(
Num_S int primary key,
Capacite int
 );
Create table Réservation(
ID_Res int primary key, 
Salle_Num_S int, 
Formateur_ID_For int,
Groupe_ID_Gr int, 
Date_Res date, 
Heure_Debut int ,
Heure_Fin int ,
check(Heure_Debut<Heure_Fin),
foreign key (Salle_Num_S) references Salle(Num_S),
foreign key (Formateur_ID_For) references Formateur(ID_For),
foreign key (Groupe_ID_Gr) references Groupe(ID_Gr)
 );
