create database DB_Calcul
use DB_Calcul
create table Pair_impair(num int,reponse varchar(30))
insert into Pair_impair(num) values(1)
insert into Pair_impair(num) values(2)
insert into Pair_impair(num) values(3)
insert into Pair_impair(num) values(4)
insert into Pair_impair(num) values(5)
insert into Pair_impair(num) values(6)
declare @num int
declare myc cursor for select num from Pair_impair
open myc
fetch myc into @num
while @@FETCH_STATUS=0
begin
if(@num%2=0)
update Pair_impair set reponse='pair'where num=@num
else
update Pair_impair set reponse='impair'where num=@num
fetch myc into @num
end
close myc
deallocate myc
select*from Pair_impair
