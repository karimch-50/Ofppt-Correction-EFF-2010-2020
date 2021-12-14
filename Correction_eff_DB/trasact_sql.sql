begin
declare @age int
set @age=13
declare @name varchar(50)
select @name='karim'
print'my name is:'+@name+' i`m '+ +cast(@age as varchar(30))+' years old'
print @name 
select @age
declare @client table(c1 int,c2 int,c3 int)
insert into @client values(1,2,3)
select*from @client

end
declare @i int
set @i=1
while @i<10
begin
print 'hello';
set @i=@i+1 ;
end
