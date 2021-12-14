
create database test;
use test;
create table addresses(
id int,
city varchar(20),
postcard varchar(7)
);
create table people(
id int,
first_name varchar(20),
last_name varchar(20),
addres_id int
);
create table pets(
id int,
name varchar(20),
spercies varchar(20),
owne_id int
);
show tables


 