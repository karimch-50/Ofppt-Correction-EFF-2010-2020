create database DB1
use DB1
create table Formateur
(
mat_for int primary key,
nom_for varchar(30),
pre_for varchar(30),
ville_for varchar(30)
)
create table Module
(
num_mod int primary key,
int_mod varchar(30),
mh_mod varchar(30)
)
create table Affectation
(
num_for int foreign key references Formateur(mat_for),
num_mod int foreign key references Module(num_mod),
etat_mod varchar(30),
primary key(num_for,num_mod)
)

insert into Formateur values(1,'NF1','PF1','V1')
insert into Formateur values(2,'NF2','PF2','V2')
insert into Formateur values(3,'NF3','PF3','V3')

insert into Module values(1000,'I1','10')
insert into Module values(1001,'I2','5')
insert into Module values(1002,'I3','2')

insert into Affectation values(1,1000,'etat1')
insert into Affectation values(2,1001,'etat2')
insert into Affectation values(3,1002,'etat3')

select*from Formateur
select*from Module
select*from Affectation

alter table Affectation
add constraint C2
foreign key(num_mod) references Module(num_mod) on delete cascade on update cascade



