create database TP_2;
use TP_2;
create table FAMILLE (
 RACE varchar(20) ,
 ORIGINE varchar(20),
 AMI varchar(20),
 constraint PK_FAMILLE primary key (RACE,ORIGINE)
 );
 describe FAMILLE;
 drop table FAMILLE;
create table MENU (
N_M int primary key, 
QTE_VIANDE int,
QTE_LEGUME int
);
create table ENFANT (
EENFANT int,
PARENT int,
foreign key(EENFANT) references ANIMAL(N_A),
foreign key(PARENT) references ANIMAL(N_A)
);
drop table ENFANT;
create table ANIMAL (
 N_A int primary key,
 NOM varchar(20),
 AGE int,
 FAMILLE_RACE varchar(20),
 FAMILLE_ORIGINE varchar(20),
 MENU_N_M int,
 foreign key(MENU_N_M) references MENU(N_M),
 foreign key(FAMILLE_RACE,FAMILLE_ORIGINE) references FAMILLE(RACE,ORIGINE)
 );
 
 
