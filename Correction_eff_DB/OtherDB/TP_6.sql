create database TP_6
use TP_6 
create table PILOTE (
NUMPIL int primary key, 
NOMPIL varchar(30), 
PREPIL varchar(30), 
ADR varchar(50),
SAL int
check(SAL>=5000 and SAL<=30000)
) 
create table AVION (
NUMAV int primary key,
NOMAV varchar(30),
CAPACITE int,
LOC varchar(50),
check(CAPACITE<1000)
) 
create table VOL (
NUMVOL int primary key,
PILOTE_NUMPIL int,
AVION_NUMAV int,
VILLE_DEP varchar(50),
VILLE_ARR varchar(50),
D_DEP date,
D_ARR date,
H_DEP int,
H_ARR int,
foreign key(PILOTE_NUMPIL) references PILOTE(NUMPIL),
foreign key(AVION_NUMAV) references AVION(NUMAV),
check(D_DEP<D_ARR)
) 
insert into PILOTE values(1,'aziz','ahmed','casablanca gqei',27000)
insert into PILOTE values(2,'khalidi','ayoub','agadir vweyu',15000)
insert into PILOTE values(3,'ahmadi','abdelkader','tanger gfu',7000)

insert into AVION values(355,'Airbus.',130,'casablanca')
insert into AVION values(356,'Bristol',500,'agadir')
insert into AVION values(357,' ATR',870,'tanger')

insert into VOL values(75,1,355,'casablanca','calefornia','2020/05/03','2020/05/04',13,13)
insert into VOL values(76,2,356,'agadir','paris','2020/07/22','2020/07/23',18,23)
insert into VOL values(77,3,357,'tanger','brlin','2020/01/15','2020/01/16',7,1)

sp_help PILOTE

select*from PILOTE
select*from AVION
select*from VOL

alter table  VOL
add constraint v1
check(H_DEP between 0 and 24 and H_ARR between 0 and 24)

update PILOTE
set SAL=SAL*1.15
where NOMPIL like'A%'

delete from AVION
where CAPACITE<200

select upper(NOMPIL) from PILOTE where NOMPIL like'A%'

select upper(NOMPIL)+ ' ' +upper(left(PREPIL,1))+lower(substring(PREPIL,2,LEN(PREPIL))) from PILOTE where SAL>15000

select min(SAL) AS salaire_minimum from PILOTE P,AVION A ,VOL V where P.NUMPIL=V.PILOTE_NUMPIL and A.NUMAV=V.NUMVOL and NOMAV='Bordeaux-Marseille'

select ADR from PILOTE where avg(SAL)=max(SAL)