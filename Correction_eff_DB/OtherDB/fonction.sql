create database fonction
use fonction
 Create table formule 
(NuFormule int identity(1,1) primary key ,Nom varchar(30), PrixCotisation float, PrixVideo float,
constraint ck check (PrixVideo>20))

Create table abonne (NumAbonne int primary key,
 Nom varchar(20), Prenom varchar(20), 
 Adresse varchar(30) check(in('','','')),
 like('D%')
 NuFormule int foreign key references formule(NuFormule), 
 DateAbonnement datetime, DateCotisation datetime)
 
 Create table video 
 (CodeVideo int primary key, Titre varchar(20), Realisateur varchar(20), DateSortie datetime)

 Create table exemplaire 
 (Codevideo int foreign key references video(CodeVideo), NuExemplaire int , Format varchar(20)
 constraint PK1 primary key (codevideo, NuExemplaire))
 
 Create table emprunt 
 (NumAbonne int foreign key references abonne(NumAbonne), codeVideo int foreign key references video(CodeVideo),
  NuExemplaire int, dateLocation datetime, DateRendu datetime
 constraint PK3 primary key (NumAbonne,codeVideo,NuExemplaire, dateLocation ))
 
 Create table association (CodeVideo int foreign key references video(CodeVideo), CodeVideoAssocie int,
 constraint PK2 primary key (codevideo,CodeVideoAssocie ))

 insert into formule values ('mensuel', 10, 40)
 insert into formule values ('hebdomadaire', 5, 80)
 insert into formule values ('annuel',100, 30)
 insert into formule values ('trimestriel', 40, 60)
 insert into formule values ('semestriel', 70, 50)

 insert into abonne values ( 1,'a1','P1','casa',1,'10/10/2012','11/10/2012')
 insert into abonne values ( 2,'a2','P2','rabat',2,'12/09/2012','21/09/2012')
 insert into abonne values ( 3,'a3','P3','knitra',1,'14/07/2012','11/08/2012')
 insert into abonne values ( 4,'a4','P4','mohammadia',3,'22/09/2012','02/10/2012')
 insert into abonne values ( 5,'a5','P5','marakech',4,'16/07/2012','11/12/2012')
 insert into abonne values ( 6,'a6','P6','taza',2,'23/10/2012','16/11/2012')

 insert into video values (1,'avatar','aa','11/08/2006')
 insert into video values (2,'CABARET','xx','21/04/2007')
 insert into video values (3,'mission impossible','ee','09/11/2008')
 insert into video values (4,'the last dance','uu','13/10/2009')
 insert into video values (5,'avatar','gg','07/07/2011')
 insert into video values (6,'avatar','tt','24/04/2005')
 insert into video values (7,'avatar','pp','23/05/2004')
 insert into video values (15,'tito','ff','12/09/2005')

 insert into exemplaire values(1,1,'cassette') 
 insert into exemplaire values(1,2,'CD') 
 insert into exemplaire values(1,3,'dvd') 
 insert into exemplaire values(1,4,'cassette') 
 insert into exemplaire values(2,1,'cassette') 
 insert into exemplaire values(2,2,'CD') 
 insert into exemplaire values(2,3,'dvd') 
 insert into exemplaire values(3,4,'cassette') 
 insert into exemplaire values(3,1,'cassette') 
 insert into exemplaire values(3,2,'CD') 
 insert into exemplaire values(3,3,'dvd') 
 insert into exemplaire values(3,4,'cassette') 
 insert into exemplaire values(4,1,'cassette') 
 insert into exemplaire values(4,2,'CD') 
 insert into exemplaire values(4,3,'dvd') 
 insert into exemplaire values(4,4,'cassette') 
 insert into exemplaire values(4,5,'cassette') 
 insert into exemplaire values(4,6,'CD') 
 insert into exemplaire values(4,7,'dvd') 
 insert into exemplaire values(5,1,'cassette')

 insert into emprunt values ( 1,1,1,'10/10/2012','16/10/2012')
 insert into emprunt values ( 2,2,1,'11/09/2012','01/10/2012')
 insert into emprunt values ( 2,3,1,'12/08/2012','30/08/2012')
 insert into emprunt values ( 2,4,2,'13/07/2012','21/07/2012')
 insert into emprunt values ( 1,4,3,'14/04/2012','01/05/2012')
 insert into emprunt values ( 1,5,1,'15/11/2012','08/12/2012')
 insert into emprunt values ( 3,1,1,'20/12/2012','30/12/2012')
 insert into emprunt values ( 3,1,1,'21/03/2012','30/03/2012')
 insert into emprunt values ( 4,1,1,'22/04/2012','02/05/2012')
 insert into emprunt values ( 1,2,3,'23/10/2012','11/11/2012')
 insert into emprunt values ( 1,3,4,'14/10/2012','24/10/2012')

 insert into association values (1,210)
 insert into association values (2,310)
 insert into association values (3,421)
 insert into association values (4,120)
 insert into association values (5,510)
 insert into association values (6,921)


 create function 