create database TP_2_EX2;
create table ESPECE (
NOME varchar(20), 
ORIGINE_MAJORITAIRE varchar(20), 
SUPER_FAMILLE varchar(20)
);
create table PLANTE (
NUMP int, 
NOMP varchar(20), 
FAMILLE varchar(20), 
FLORAISON varchar(20), 
COULEUR varchar(20), 
TOXICITE enum('oui','non'),  
HAUTEUR int, 
ESPECE_NOME varchar(20), 
PATICULARITE varchar(20), 
PHOTOGRAPHIE varchar(20),
foreign key (ESPECE_NOME) references ESPECE(NOME)
); 
create table SYMPTOME (
LIBS int , 
DESCRIPTIONN varchar(100)
);
create table PROVOQUE (
PLANTE_NUMP int, 
SYMPTOME_LIBS int, 
QUANTITE int,
foreign key (SYMPTOME_LIBS) references SYMPTOME(LIBS),
foreign key (PLANTE_NUMP) references PLANTE(NUMP)
);
