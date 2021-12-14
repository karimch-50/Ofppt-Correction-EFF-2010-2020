create database DB_Calcul2
use DB_Calcul2
create table nbr_premier(num int,reponse varchar(30))
insert into nbr_premier(num) values(1)
insert into nbr_premier(num) values(2)
insert into nbr_premier(num) values(3)
insert into nbr_premier(num) values(4)
insert into nbr_premier(num) values(5)
insert into nbr_premier(num) values(6)
declare @num int
declare myc cursor for select num from nbr_premier
open myc
fetch myc into @num
while @@FETCH_STATUS=0
begin
declare @i int 
declare @cpt int
set @cpt=0
set @i=2
while(@i<@num)
begin
if(@num%@i=0)
set @cpt+=1
set @i+=1
end
if(@cpt=0)
update nbr_premier set reponse='le nombre est premier'where num=@num
else
update nbr_premier set reponse='le nombre n`est pas premier'where num=@num
fetch myc into @num
end
close myc
deallocate myc
select*from nbr_premier