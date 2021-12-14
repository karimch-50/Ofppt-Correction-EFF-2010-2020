create database Serie_REVISION_EX2
use Serie_REVISION_EX2
create table ARTICLES (
NoArt int primary key,
Libelle int,
Stock int,
PrixInvent int
) 
create table FOURNISSEURS (
NoFour int primary key,
NomFour varchar(30),
AdrFour varchar(50),
VilleFour varchar(30)
) 
create table FOURNIR (
FOURNISSEURS_NoFour int foreign key references FOURNISSEURS(NoFour),
ARTICLES_NoArt int foreign key references ARTICLES(NoArt),
PrixArticle int,
Delai int
)

select*from ARTICLES where NoArt>10 and Libelle>10

select NoArt from ARTICLES where PrixInvent between 100 and 300

select NomFour from FOURNISSEURS where NomFour like'STE%'

select F1.NomFour,F1.AdrFour from ARTICLES A,FOURNISSEURS F1,FOURNIR F2 where A.NoArt=F2.ARTICLES_NoArt and F1.NoFour=F2.FOURNISSEURS_NoFour and Delai>20

select NoArt,Libelle from ARTICLES order by(Stock) desc

select max(F.PrixArticle) as prix_maximum,min(F.PrixArticle) as prix_minimum,avg(F.PrixArticle) as prix_moyen from ARTICLES A,FOURNIR F where A.NoArt=F.ARTICLES_NoArt group by A.NoArt,A.Libelle

						   


