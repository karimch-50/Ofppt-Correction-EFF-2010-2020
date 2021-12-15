create database  InfoMember
use InfoMember
drop database InfoMember
create table Membres (
loginn varchar(20) primary key, 
pass varchar(20) ,
nom varchar(20),
mail varchar(20),
dateNaissance date
)

insert into Membres values('L1','P1','Nom1','Email1','2000-12-12')

select*from Membres