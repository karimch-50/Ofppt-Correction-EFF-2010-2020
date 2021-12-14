create database TP_4;
use TP_4;
create table DEPT (
DNO int primary key, 
DNOM varchar(20), 
DIR int,
VILLE varchar(30)
 );
create table EMP (
ENO int primary key, 
ENOM varchar(20), 
PROF varchar(20), 
DATEEMB date, 
SAL int, 
COMM int, 
DEPT_DNO int,
foreign key (DEPT_DNO) references DEPT(DNO)
);
insert into DEPT values(1,'commercial',30,'new york');
insert into DEPT values(2,'Production',20,'Houston');
insert into DEPT values(3,'Developpement',40,'Boston');
insert into EMP values(10,'jeo','Ingenieur','1993/10/01',4000,3000,3);
insert into EMP values(20,'jack','Technicien',1988/05/01,3000,2000,2);
insert into EMP values(30,'jim','Vendeur',1980/03/01,5000,5000,1);
insert into EMP values(40,'luky','Ingenieur',1980/03/01,5000,5000,3);
select*from EMP
update EMP(

)

