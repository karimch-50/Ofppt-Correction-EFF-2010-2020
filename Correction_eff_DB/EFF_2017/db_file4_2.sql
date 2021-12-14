create database EFF2017_TP_V1_1_DB
--remarque ses question et le meme pour EFF2017_TP_V1_2 
--just la base de donne et different
use EFF2017_TP_V1_1_DB
create table Utilisateur(
    idUtil int primary key,
    nomUtil varchar(30),
    prenUtil varchar(30),
    adresseUtil int,
    pass varchar(30)
)
create table Parking(
    idPark int primary key,
    nomPark varchar(30),
    adPark varchar(30),
    ville varchar(30),
    nbPlace int,
    nbPlaceLivbre int
)
create table TypeTarif(
    idType int primary key,
    nomType varchar(30),
)
create table TarifParking(
    idPark int foreign key references Parking(idPark),
    idType int foreign key references TypeTarif(idType),
    prix float,
    primary key(idPark,idType)
)
create table Stationnement(
    idStat int primary key,
    dateStat date,
    idUtil int foreign key references Utilisateur(idUtil),
    idPark int foreign key references Parking(idPark),
    idType int foreign key references TypeTarif(idType),
    nbUnit int
)

insert into Utilisateur values(1,'nomUtil1','prenUtil1',1,'pass1')
insert into Utilisateur values(2,'nomUtil2','prenUtil2',2,'pass2')
insert into Utilisateur values(3,'nomUtil3','prenUtil3',3,'pass3')

insert into Parking values(1,'nomPark1','adPark1','ville1',50,30)
insert into Parking values(2,'nomPark2','adPark2','ville2',20,10)
insert into Parking values(3,'nomPark3','adPark3','ville3',40,20)

insert into TypeTarif values(1,'nomType1')
insert into TypeTarif values(2,'nomType2')
insert into TypeTarif values(3,'nomType3')

insert into TarifParking values(1,1,2.50)
insert into TarifParking values(2,2,1.75)
insert into TarifParking values(3,3,2.00)

insert into Stationnement values(1,'2020-10-10',1,1,1,10)
insert into Stationnement values(2,'2020-11-11',2,2,2,20)
insert into Stationnement values(3,'2020-12-12',3,3,3,30)

select*from Utilisateur
select*from Parking
select*from TypeTarif
select*from TarifParking
select*from Stationnement

