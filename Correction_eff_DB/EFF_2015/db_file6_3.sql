create database EFF2015_TP_V2_1_DB
--remarque ses question et le meme pour EFF2015_TP_V2_2 aussi pour EFF2015_TP_V2_3 
--just la base de donne et different
use EFF2015_TP_V2_1_DB
create table Abonne (
    idAbonne int primary key, 
    nomAb varchar(30), 
    adresseAb varchar(30), 
    TelAb varchar(30), 
    pass varchar(30)
)
create table Usage (
    idUsage int primary key, 
    nomUsage varchar(30), 
    montantUsage float
)
create table Abonnement (
    idAbonnement int primary key, 
    dateAb date, 
    idusage int foreign key references Usage(idUsage), 
    idAbonne int foreign key references Abonne(idAbonne) 
)
create table Consommation (
    idconsommation int primary key identity, 
    periode varchar(30), 
    Qte int,
    idAbonnement int foreign key references Abonnement(idAbonnement) 
)
create table Tranches (
    NumTranche int primary key, 
    valMin int, 
    valMax int, 
    PU float
)

insert into Abonne values(1,'nomAb1','adresseAb1','0600000000','pass1')
insert into Abonne values(2,'nomAb2','adresseAb2','0600000001','pass2')
insert into Abonne values(3,'nomAb3','adresseAb3','0600000002','pass3')

insert into Usage values(1,'nomUsage1',10.00)
insert into Usage values(2,'nomUsage2',20.00)
insert into Usage values(3,'nomUsage3',30.00)

insert into Abonnement values(1,'2020-10-10',1,1)
insert into Abonnement values(2,'2020-11-11',2,2)
insert into Abonnement values(3,'2020-12-12',3,3)

insert into Consommation(periode,Qte,idAbonnement) values('periode1',100,1)
insert into Consommation(periode,Qte,idAbonnement) values('periode2',200,2)
insert into Consommation(periode,Qte,idAbonnement) values('periode3',300,3)

insert into Tranches values(1,1,100,10.00)
insert into Tranches values(2,2,200,20.00)
insert into Tranches values(3,3,300,30.00)


select*from Abonne
select*from Usage
select*from Abonnement
select*from Consommation
select*from Tranches


