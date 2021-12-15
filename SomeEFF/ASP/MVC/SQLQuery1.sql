create database MvcCRUDDb
use MvcCRUDDb
create table Product(
ProductID int primary key,
ProductName varchar(50),
price decimal(18,2),
Countt int 
)

insert into Product values(1,'ProductName1',12,1)
insert into Product values(2,'ProductName2',9,2)
insert into Product values(3,'ProductName3',18,3)
insert into Product values(4,'ProductName4',3,4)

select*from Product