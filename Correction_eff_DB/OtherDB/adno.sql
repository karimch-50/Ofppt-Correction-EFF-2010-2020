create database DB_Calcul3
use DB_Calcul3
create table nbr_premier(num1 int,num2 int,op char(1),resultat int)
insert into nbr_premier(num1,num2) values(1,4)
insert into nbr_premier(num1,num2) values(2,3)
insert into nbr_premier(num1,num2) values(1,6)
insert into nbr_premier(num1,num2) values(7,4)
insert into nbr_premier(num1,num2) values(9,3)
insert into nbr_premier(num1,num2) values(1,2)
declare @num1 int
declare @num2 int
declare @op char(1)
declare @R 
declare myc cursor for select num1,num2,op from nbr_premier
open myc
fetch myc into @num1,@num2,@op,@R
while @@FETCH_STATUS=0
begin
if (@op='+')

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