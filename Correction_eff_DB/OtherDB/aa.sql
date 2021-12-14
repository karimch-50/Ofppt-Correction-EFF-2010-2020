declare @x as float,@fact as int,@i as int,@somme as float,@n as int
set @x=3.5
set @n=4
set @i=1
set @fact=1
set @somme=0
while(@i<@n)
begin
set @fact=@fact*@i
set @somme= @somme+power(@x,@i)/@fact
set @i=@i+1
end
print 'la somme est:'+convert(varchar(30),@somme)

