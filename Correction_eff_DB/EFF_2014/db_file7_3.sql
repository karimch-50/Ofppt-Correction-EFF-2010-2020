create database EFF2014_TP_V2_1_DB
--remarque ses question et le meme pour EFF2014_TP_V2_2 aussi pour EFF2014_TP_V2_3 
--just la base de donne et different
use EFF2014_TP_V2_1_DB
create table Magasin (
    numéro int primary key,
    magasin varchar(30),
    Libelle_magasin varchar(30), 
    date_création date, 
    Tel varchar(30), 
    Adresse varchar(30), 
    Ville varchar(30)
)
create table Client(
    CIN int primary key,
    Genre varchar(30), 
    Nom varchar(30), 
    Prénom varchar(30), 
    Tel varchar(30), 
    Adresse varchar(30),
    numéro_magasin int foreign key references Magasin(numéro)
)
create table MotifsRejet (
    code_motif int primary key,
    libelle_motif varchar(30)
)
create table Banque (
    code_Banque int primary key,
    Libelle_banque varchar(30), 
    adresse_siège varchar(30), 
    Tel varchar(30), 
    Ville varchar(30)
)
create table cheque(
    numero_chèque int primary key, 
    Date_emission date, 
    Montant float, 
    url_cheque varchar(30), 
    code_motif int foreign key references MotifsRejet(code_motif),
    ClN int foreign key references Client(CIN),
    code_Banque int foreign key references Banque(code_Banque),
    numéro_magasin int foreign key references Magasin(numéro)
)


insert into Magasin values(1,'magasin1','Libelle_magasin1','2020-10-10','0600000000','Adresse1','Ville1')
insert into Magasin values(2,'magasin2','Libelle_magasin2','2020-11-11','0600000001','Adresse2','Ville2')
insert into Magasin values(3,'magasin3','Libelle_magasin3','2020-12-12','0600000002','Adresse3','Ville3')

insert into Client values(1,'Genre1','Nom1','Prénom1','0600000010','Adressee1',1)
insert into Client values(2,'Genre2','Nom2','Prénom2','0600000011','Adressee2',2)
insert into Client values(3,'Genre3','Nom3','Prénom3','0600000012','Adressee3',3)

insert into MotifsRejet values(1,'libelle_motif1')
insert into MotifsRejet values(2,'libelle_motif2')
insert into MotifsRejet values(3,'libelle_motif3')

insert into Banque values(1,'Libelle_banque1','adresse_siège1','0600000110','Ville1')
insert into Banque values(2,'Libelle_banque2','adresse_siège2','0600000111','Ville2')
insert into Banque values(3,'Libelle_banque3','adresse_siège3','0600000112','Ville3')

insert into cheque values(1,'2020-10-10',10.00,'url_cheque1',1,1,1,1)
insert into cheque values(2,'2020-11-10',20.00,'url_cheque2',2,2,2,2)
insert into cheque values(3,'2020-12-10',30.00,'url_cheque3',3,3,3,3)


select*from Magasin
select*from Client
select*from MotifsRejet
select*from Banque
select*from cheque






