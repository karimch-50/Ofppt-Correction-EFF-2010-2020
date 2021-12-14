create database EFF_2012_TH
use EFF_2012_TH
create table Equipe (
    codeEquipe int primary key,
    nomEquipe varchar(30)
)
create table Stade(
    codeStade int primary key,
    nomStade varchar(30)
)
create table Match(
    numMatch int primary key,
    dateMatch date,
    nombreSpectateur int,
    numJournee int,
    codeStade int foreign key references Stade(codeStade),
    codeEquipeLocaux int foreign key references Equipe(codeEquipe),
    codeEquipeVisiteurs int foreign key references Equipe(codeEquipe),
    nombreButLocaux int,
    nombreButVisiteurs int
)

insert into Equipe values(1,'nomEquipe1')
insert into Equipe values(2,'nomEquipe2')
insert into Equipe values(3,'nomEquipe3')

insert into Stade values(1,'nomStade1')
insert into Stade values(2,'nomStade2')
insert into Stade values(3,'nomStade3')

insert into Match values(1,'2020-10-10',120,10,1,1,2,0,1)
insert into Match values(2,'2020-11-11',150,20,2,2,3,2,3)
insert into Match values(3,'2020-12-12',170,30,3,3,1,0,4)
insert into Match values(4,'2020-12-13',200,40,3,3,1,2,4)
insert into Match values(5,'2020-12-13',200,40,3,2,1,4,2)



select*from Equipe 
select*from Stade 
select*from Match 


select count(*) from Match where numJournee=12

select numJournee,count(numMatch)  as nbrMatch from Match group by numJournee

select top(1)numMatch from Match order by nombreSpectateur desc 


declare @nbrP int
set @nbrP=0
select @nbrP= (case 
            when nombreButLocaux<nombreButVisiteurs then @nbrP+3
            when nombreButLocaux=nombreButVisiteurs then @nbrP+1
            else @nbrP
            end)
            from Match where codeEquipeVisiteurs=3
select @nbrP


go
create procedure P1 @numJournee int
as
begin
select codeEquipeLocaux,codeEquipeVisiteurs from Match where (nombreButLocaux<nombreButVisiteurs or nombreButLocaux>nombreButVisiteurs) and numJournee=@numJournee
end

go
create trigger T1 
on Match
for insert 
as
begin
if exists(select*from inserted where codeEquipeLocaux=codeEquipeVisiteurs)
rollback
end

