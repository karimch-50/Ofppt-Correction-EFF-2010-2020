create database EFF_2013_TH
use EFF_2013_TH
create table COMPTE(
    NUMTELE char(14) primary key,
    CODEPUCE int,
    CODEPIN int,
    TYPECOMPTE varchar(30),
    TYPERECHARGE varchar(30),
    VALIDER varchar(3),
    MONTANTRESTR money,
    DATEEXPIRATION datetime
)
create table CLIENT(
    NUMTEL char(14) foreign key references COMPTE(NUMTELE),
    NOMCLIENT varchar(30),
    PRENOMCLIENT varchar(30),
    ADRESSECLIENT varchar(30),
    EMAILCLIENT varchar(30),
    primary key(NUMTEL)
)
create table TECKET(
    CODETICKET int primary key,
    DATEMISSION datetime,
    DATEEXPIRATION datetime,
    MONATANT money,
    TEMPS int,
    QTE int,
    UTILISATEUR varchar(30)
)
create table RECHARGER(
    CODERECH int primary key,
    CODETICKET int foreign key references TECKET(CODETICKET),
    #NUMTEL char(14) foreign key references COMPTE(NUMTELE),
    DATEHEURERECH datetime,
    ETAT char(3)
)
create table MACHINE(
    ADRESSEMAC varchar(14) primary key,
    ADRESSEIP varchar(14),
    NOMMACHINE varchar(30)
)
create table CONNECTION(
    IDCNX int primary key,
    NUMTEL char(14) foreign key references COMPTE(NUMTELE),
    DATEHEURDEBUT datetime,
    DATEHEURFIN datetime,
    ADRESSEIP varchar(16),
    ADRESSEEMAC varchar(14) foreign key references MACHINE(ADRESSEMAC)
)

insert into COMPTE values('0600000000',10000000,0000,'TYPECOMPTE1','TYPERECHARGE1','oui',12,'2020-10-10 10:00:00')
insert into COMPTE values('0600000001',10000001,0001,'TYPECOMPTE2','TYPERECHARGE2','non',20,'2020-11-11 11:00:00')
insert into COMPTE values('0600000002',10000002,0002,'TYPECOMPTE3','TYPERECHARGE3','oui',30,'2020-12-12 12:00:00')

insert into CLIENT values('0600000000','NOMCLIENT1','PRENOMCLIENT1','ADRESSECLIENT1','EMAILCLIENT1')
insert into CLIENT values('0600000001','NOMCLIENT2','PRENOMCLIENT2','ADRESSECLIENT2','EMAILCLIENT2')
insert into CLIENT values('0600000002','NOMCLIENT3','PRENOMCLIENT3','ADRESSECLIENT3','EMAILCLIENT3')

insert into TECKET values(1,'2020-10-10 10:00:00','2020-12-10 10:00:00',10,10,10,'UTILISATEUR1')
insert into TECKET values(2,'2020-10-15 11:00:00','2020-12-15 11:00:00',20,20,20,'UTILISATEUR2')
insert into TECKET values(3,'2020-10-20 12:00:00','2020-12-20 12:00:00',30,30,30,'UTILISATEUR3')

insert into RECHARGER values(1000000000,1,'0600000000','2020-10-10 10:00:00','ET1')
insert into RECHARGER values(1000000001,2,'0600000001','2020-10-12 12:00:00','ET2')
insert into RECHARGER values(1000000002,3,'0600000002','2020-10-14 14:00:00','ET3')

insert into MACHINE values('ADRESSEMAC1','ADRESSEIP1','NOMMACHINE1')
insert into MACHINE values('ADRESSEMAC2','ADRESSEIP2','NOMMACHINE2')
insert into MACHINE values('ADRESSEMAC3','ADRESSEIP3','NOMMACHINE3')

insert into CONNECTION values(1,'0600000000','2020-10-10 10:00:00','2020-12-10 10:00:00','ADRESSEIP1','ADRESSEMAC1')
insert into CONNECTION values(2,'0600000001','2020-10-15 11:00:00','2020-12-15 11:00:00','ADRESSEIP2','ADRESSEMAC2')
insert into CONNECTION values(3,'0600000002','2020-10-20 12:00:00','2020-12-20 12:00:00','ADRESSEIP3','ADRESSEMAC3')



select*from COMPTE
select*from CLIENT
select*from TECKET
select*from RECHARGER
select*from MACHINE
select*from CONNECTION



