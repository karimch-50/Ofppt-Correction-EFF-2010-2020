show databases;
create database coffee_store;
use coffee_store;
create table products(
id int auto_increment primary key,
name varchar(30),
price decimal(3,2)
);
create table customers(
id int auto_increment primary key,
first_name varchar(20),
last_name varchar(20),
gender enum('M','F'),
phone_number varchar(10)
);
create table orders(
id int auto_increment primary key,
products_id int,
customers_id int,
order_time datetime,
foreign key (products_id) references products(id),
foreign key (customers_id) references customers(id)
);
show tables;




