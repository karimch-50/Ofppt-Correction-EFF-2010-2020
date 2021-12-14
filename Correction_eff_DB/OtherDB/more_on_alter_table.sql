use test;
alter table addresses
add primary key (id) ;
alter table people
add primary key (id) ;
alter table pets
add primary key (id) ;
describe addresses;
describe people;
describe pets;

alter table people
add constraint addres_id
foreign key (addres_id) references addresses(id);

alter table people
drop foreign key addres_id;

alter table pets
add constraint u_spercies unique(spercies);

alter table pets
drop index u_spercies;

alter table pets change `animal_name` `spercies` varchar(20);
 select*from pets;
 
 alter table addresses
 modify city varchar(20);
 
 describe addresses;
 
 alter table pets
 add constraint owne_id
 foreign key (owne_id) references people(id);
 
 alter table people
 add column email varchar(20);
 
alter table people
add constraint u_email unique(email);

alter table pets
change `name` `first_name` varchar(20);

alter table addresses
modify postcard char(7);
describe addresses;
describe pets;

 







