create database EFF2010_TP_V7_DB
--remarque ses question et le meme pour EFF2010_TP_V8_DB est EFF2010_TP_V9_DB 
--just la base de donne et different
use EFF2010_TP_V7_DB
create table Engrais(
    Reference int primary key,
    Libelle varchar(30),
    teneurN varchar(30),
    teneurP varchar(30),
    teneurK varchar(30),
    teneurS varchar(30),
    PrixUnetaire float,
    [QCE/ha] int,
    Stock int
)
create table AchatEngrais(
    Numero int primary key,
    dateachat date,
    RefEngrais int foreign key references Engrais(Reference),
    QuantiteAchete int
)
create table Parcelle(
    NumParcele int primary key,
    nomParcele varchar(30),
    suface varchar(30),
    Type_sol varchar(30),
    profondeur int,
    adresse varchar(30)
)
create table Fertilisation(
    Num int primary key,
    RefEgrais int foreign key references Engrais(Reference),
    [N parcele] int foreign key references Parcelle(NumParcele),
    datePrevue date,
    dateEspandage date,
    Quantite int,
)
create table Culture(
    NumCulture int primary key,
    NomCulture varchar(30),
    CoefExportGrain int,
    CoafExportPaile int,
    [ftrytoSanitaire(O/N)] varchar(30),
)
create table cultureParParcelle(
    [N parcele] int foreign key references Parcelle(NumParcele),
    RefCulturs int foreign key references Culture(NumCulture),
    Saison varchar(30),
    [rendement_prevue(jhe)] varchar(30),
    [rendement_realise(ha)] varchar(30),
    primary key([N parcele],RefCulturs)
)
create table Variete(
    Num int primary key,
    NomVariete varchar(30),
    NumCulture int foreign key references Culture(NumCulture)
)

insert into Engrais values(1,'Libelle1','teneurN1','teneurP1','teneurK1','teneurS1',100.00,10,100)
insert into Engrais values(2,'Libelle2','teneurN2','teneurP2','teneurK2','teneurS2',200.00,20,200)
insert into Engrais values(3,'Libelle3','teneurN3','teneurP3','teneurK3','teneurS3',300.00,30,300)

insert into AchatEngrais values(1,'2020-10-10',1,100)
insert into AchatEngrais values(2,'2020-11-12',2,200)
insert into AchatEngrais values(3,'2020-12-13',3,300)

insert into Parcelle values(1,'nomParcele1','suface1','Type_sol1',4,'adresse1')
insert into Parcelle values(2,'nomParcele2','suface2','Type_sol2',6,'adresse2')
insert into Parcelle values(3,'nomParcele3','suface3','Type_sol3',8,'adresse3')

insert into Fertilisation values(1,1,1,'2020-01-01','2020-05-05',10)
insert into Fertilisation values(2,2,2,'2020-02-02','2020-06-05',20)
insert into Fertilisation values(3,3,3,'2020-03-03','2020-07-05',30)

insert into Culture values(1,'NomCulture1',10,10,'[ftrytoSanitaire(O/N)]1')
insert into Culture values(2,'NomCulture2',20,20,'[ftrytoSanitaire(O/N)]2')
insert into Culture values(3,'NomCulture3',30,30,'[ftrytoSanitaire(O/N)]3')

insert into cultureParParcelle values(1,1,'Saison1','[rendement_prevue(jhe)]1','[rendement_realise(ha)]1')
insert into cultureParParcelle values(2,2,'Saison2','[rendement_prevue(jhe)]2','[rendement_realise(ha)]2')
insert into cultureParParcelle values(3,3,'Saison3','[rendement_prevue(jhe)]3','[rendement_realise(ha)]3')

insert into Variete values(1,'NomVariete1',1)
insert into Variete values(2,'NomVariete2',2)
insert into Variete values(3,'NomVariete3',3)


SELECT*FROM Engrais
SELECT*FROM AchatEngrais
SELECT*FROM Parcelle
SELECT*FROM Fertilisation
SELECT*FROM Culture
SELECT*FROM cultureParParcelle
SELECT*FROM Variete










