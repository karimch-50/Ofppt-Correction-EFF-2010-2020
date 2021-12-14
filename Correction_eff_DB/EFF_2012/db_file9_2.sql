create database EFF2012_TP_V1_1_DB
--remarque ses question et le meme pour EFF2012_TP_V1_2 aussi pour EFF2012_TP_V1_3 
--just la base de donne et different
use EFF2012_TP_V1_1_DB
create table region (
    idr int primary key,
    nomr varchar(20) 
)
create table provinceprefecture(
    idprofpref  int primary key,
    nomprofpref varchar(20) ,
    idr int foreign key references region (idr)
)
create table circonscription (
    idcircon int primary key,
    nomcir varchar(20),
    nombresiege  int,
    idprofpref  int foreign key references provinceprefecture(idprofpref) 
)
create table parti (
    idparti int primary key,
    nompart varchar(20) 
)
create table candidat(
    cincandidat int primary key,
    nomcandidat  varchar(20),
    prenomcandidat varchar(20),
    dateNC date ,
    adrcandidat varchar(20),
    idcircon  int foreign key references circonscription(idcircon),
    idparti int foreign key references parti(idparti)
)
create table electeur (
    cinelect int primary key,
    nomelec varchar(20), 
    prenomelec varchar(20),
    dateNE date,
    adrelec varchar(20),
    idcircon int foreign key references circonscription(idcircon)
)

insert into region values(1,'nomr1')
insert into region values(2,'nomr2')
insert into region values(3,'nomr3')

insert into provinceprefecture values(1,'nomprofpref1',1)
insert into provinceprefecture values(2,'nomprofpref2',2)
insert into provinceprefecture values(3,'nomprofpref3',3)

insert into circonscription values(1,'nomcir1',10,1)
insert into circonscription values(2,'nomcir1',20,2)
insert into circonscription values(3,'nomcir1',30,3)

insert into parti values(1,'nompart1')
insert into parti values(2,'nompart2')
insert into parti values(3,'nompart3')

insert into candidat values(1,'nomcandidat1','prenomcandidat1','1990-10-10','adrcandidat1',1,1)
insert into candidat values(2,'nomcandidat2','prenomcandidat2','1990-11-11','adrcandidat2',2,2)
insert into candidat values(3,'nomcandidat3','prenomcandidat3','1990-12-12','adrcandidat3',3,3)

insert into electeur values(1,'nomelec1','prenomelec1','1990-01-01','adrelec1',1)
insert into electeur values(2,'nomelec2','prenomelec2','1990-01-10','adrelec2',2)
insert into electeur values(3,'nomelec3','prenomelec3','1990-01-20','adrelec3',3)

select*from region
select*from provinceprefecture
select*from circonscription
select*from parti
select*from candidat
select*from electeur



