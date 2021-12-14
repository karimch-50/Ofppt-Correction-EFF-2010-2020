create database Serie_REVISION_EX1
use Serie_REVISION_EX1
create table Fournisseur (
Num_F int primary key,
nom varchar(30),
ville varchar(50)
)
create table Produit (
Code_P varchar(30) primary key,
libellé int,
origine varchar(30),
couleur varchar(30)
)
create table Fourniture (
Num_F int foreign key references Fournisseur(Num_F),
Code_P varchar(30) foreign key references Produit(Code_P),
quantité int
)















select F1.Num_F from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.libellé>=1

select F1.Num_F from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.Code_P='P6'

select F1.Num_F from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.Code_P<>'P6'

select F1.Num_F,F1.nom from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.libellé is null

select F1.nom from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.Code_P<>'P6'

select F1.Num_F from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.origine='DIJON'

select F1.nom,F1.ville from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.origine=F1.ville and F2.quantité is not null

select F1.Num_F from Fournisseur F1,Fourniture F2,Produit P where F1.Num_F=F2.Num_F and P.Code_P=F2.Code_P and P.Code_P='vert'

