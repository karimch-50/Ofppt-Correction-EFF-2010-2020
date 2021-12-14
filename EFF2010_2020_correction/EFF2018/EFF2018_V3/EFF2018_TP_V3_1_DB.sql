create database EFF2018_TP_V3_1
use EFF2018_TP_V3_1
drop database tdi2018j3
create table centre_artisanal(num_centre_artisanal int primary key,
                             nomcentre varchar(20),
							 datedebutrealis datetime,
							 budget int,
							 dureerealisat int,
							 datelancement date,
							 nomporteurprojet varchar(20),
							 lieu varchar(20)
							)


create table activite_artisanal (idactivite int primary key,
                                 nomactivite varchar(20))

create table atelier (idatelier int primary key,
                       nomatelier varchar(20),
					   superficie varchar(20),
					   prix_location  int,
					   num_centre_artisanal int foreign key references centre_artisanal(num_centre_artisanal) ,
					   idactivite int foreign key references activite_artisanal(idactivite),
					   etat varchar(20))

create table artisan (cin int primary key,
                      nomartisan varchar(20),
					  prenomartisan varchar(20),
					  age int,
					  sexe varchar(20),
					  situationfamil varchar(20))

create table locationatelier(idatelier int foreign key references atelier (idatelier),
                             cin  int foreign key references artisan (cin),
							 datelocation datetime,
							 datefinlocation datetime,
							 primary key (idatelier,cin))


go
	CREATE PROCEDURE p1

AS
begin
return ( select*from  atelier ATE, activite_artisanal AC  where AC.idactivite =ATE.idactivite and AC.nomactivite ='broderies')
end

CREATE PROCEDURE p2

AS
begin
return ( select count(ATE.idatelier) as qsdf, nomcentre,budget from centre_artisanal CA,atelier ATE ,artisan ART,locationatelier LA  where
CA.num_centre_artisanal =ATE.num_centre_artisanal and ART.cin=LA.cin  and ATE.idatelier=LA.idatelier  group by nomcentre ,budget having count(ATE.idatelier)>100 )

end

CREATE PROCEDURE p3
AS
BEGIN

select count(idatelier) as nbr,avg(prix_location),prix_location from atelier group by idatelier having prix_location>avg(prix_location) 
   
select A1.idatelier,count(A1.idatelier),A1.prix_location,avg(A2.prix_location) 
from atelier A1,atelier A2 where A2.idatelier=A1.idatelier group by A1.idatelier 
having A1.prix_location > avg(A2.prix_location)
    
END

SELECT count(idatelier) as nbr from atelier where prix_location >  (SELECT avg(prix_location) FROM atelier)


SELECT*from centre_artisanal where DATEDIFF(YEAR,datelancement,GETDATE())>1
