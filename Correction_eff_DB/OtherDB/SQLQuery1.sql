declare @A as int,@f as int,@i as int
set @A=0
set @f=1
set @i=1
if(@A!=0)begin
while(@i<=@A)
begin
set @f=@f*@i
set @i=@i+1
end
print'fact est:'+convert(varchar(30),@f)
end
else
begin 
set @f=1
print'fact est:'+convert(varchar(30),@f)
end
   