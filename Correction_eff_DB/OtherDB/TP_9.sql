create database TP_9a
use TP_9a
create table cliens(
noclient int IDENTITY(1,1) primary key ,
nom varchar(30),
téléphone varchar(10),
adresse varchar(50),
ville varchar(30),
codepostal int
)
create procedure Ps_Ajouter_Client1 @nom varchar(30),@téléphone varchar(10),@adresse varchar(50),@ville varchar(30),@codepostal int 
as
insert into cliens(nom,téléphone,adresse, ville,codepostal) values(@nom,@téléphone,@adresse,@ville,@codepostal)

create procedure Ps_Modifier_Client as update cliens set

create procedure Ps_Supprimer_Client as truncate cliens

create procedure Ps_Afficher as select*from cliens

create procedure Ps_Afficher_ville as select ville from cliens where

create procedure Ps_Rechercher_Id1 @noclient int 
as 
declare @message varchar(30)
if(@noclient!=null)
set @message='le client existe '
else
set @message='le client n`existe pas'
select nom, téléphone, adresse, ville,codepostal from cliens where noclient=@noclient select @message

create procedure Ps_Rechercher_Id2 @noclient int as select*from cliens where noclient=@noclient

create procedure Ps_Rechercher_Id3 as



exec Ps_Ajouter_Client1  @nom='karim',@téléphone='0600000000',@adresse='iaohW142' ,@ville='casablanca',@codepostal=1321
exec Ps_Modifier_Client
exec Ps_Supprimer_Client
exec Ps_Afficher
exec Ps_Afficher_ville
exec Ps_Rechercher_Id1 @noclient=1
exec Ps_Rechercher_Id2 @noclient=1
exec Ps_Rechercher_Id3