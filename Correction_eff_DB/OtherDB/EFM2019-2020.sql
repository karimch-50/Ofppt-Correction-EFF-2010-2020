create database gestion_marine
use gestion_marine
create table navir(numn int primary key,capasite int,localisation varchar(30))
create table navigateur(numnav int primary key,nomnav varchar(30),adrnav varchar(30),salaire float)
create table tournee(numtr int primary key,numnav int foreign key references navigateur(numnav),numn int foreign key references navir(numn),ville_dep varchar(30) check(ville_dep like 'D%'),ville_arr varchar(30) check(ville_arr in('Marseille','Malaga','Barcelone')),d_dep date,d_arr date default(getdate()))

select max(salaire) from navigateur n,tournee t where n.numnav=t.numnav and ville_dep='tenger' and ville_arr='marsille'
select count(*),n.numnav from tournee t,navigateur n where t.numnav=n.numnav and count(*)=0 group by n.numnav
delete from navir where capasite>500
go
create procedure p1
as
begin
update navigateur set salaire=salaire*0.8
end

go
create procedure p2 @localisation varchar(30)
as
begin
select*from navir where localisation=@localisation
end

go
create function f1 (@date1 date , @date2 date)
returns int
as
begin
declare @sum int
set @sum=(select count(n.numn) from navir n,tournee t where n.numn=t.numn and d_dep=@date1 and d_arr=@date2)
return @sum
end

go
create trigger t1
on navir
for update
as
begin
if exists(select*from updated)
begin
raiserror('inderdit de modiffeir cette table',16,1)
rollback
end
end

alter table navigateur
add date_derniere_tournee  date

go
alter trigger t2
on tournee
for insert 
as
begin
if exists(select*from inserted)
update navigateur set date_derniere_tournee=(select d_dep from inserted)
end


