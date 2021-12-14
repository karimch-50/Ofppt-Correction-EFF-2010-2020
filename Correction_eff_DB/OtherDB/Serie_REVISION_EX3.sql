create database Serie_REVISION_EX3
use Serie_REVISION_EX3
create table DEPT (
NumDept int primary key,
NomDept varchar(30),
Lieu varchar(50)
) 
create table EMP (
Matr int primary key,
NomE varchar(30),
Poste varchar(30),
DateEmb date,
ID_SUP int,
Salaire int,
Commission varchar(30),
DEPT_NumDept int foreign key references DEPT(NumDept)
) 
create table PROJET (
CodeP int primary key,
NomP int
) 
create table PARTICIPATION (
Matr int primary key,
PROJET_CodeP int foreign key references PROJET(CodeP),
Fonction varchar(30)
) 

