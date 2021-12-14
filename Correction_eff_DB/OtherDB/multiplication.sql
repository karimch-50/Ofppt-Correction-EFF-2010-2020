declare @N1 int, @i int
declare @t table(number1 int ,number2 int,result int)
select @N1=8,@i=1
while(@i<=10)
begin 
insert into @t values(@N1,@i,@i*@N1)
set @i=@i+1
end
select*from @t