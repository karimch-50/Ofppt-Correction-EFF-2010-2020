create database EFF_2017_TH
use EFF_2017_TH
create table Utilisateur(
    idUtilisateur int primary key,
    nom varchar(30),
    prenom varchar(30),
    Tel bigint
)
create table Groupe(
    idGroupe int primary key,
    nomGroupe varchar(30)
)
create table Compte(
    adresseEmail varchar(30) Primary key,
    dateCreation date,
    etat varchar(30),
    idUtilisateur int foreign key references Utilisateur(idUtilisateur),
    idGroupe int foreign key references Groupe(idGroupe)
)
create table Messagee(
    idMessage int primary key identity,
    dateMessage date,
    objet varchar(30),
    contenu varchar(30),
    priorite varchar(30),
    adresseEmailExpediteur varchar(30) foreign key references Compte(adresseEmail),
    adresseEmailDistinataire varchar(30) foreign key references Compte(adresseEmail),
    idMessageReponce int default(null)
)

insert into Utilisateur values(1,'nom1','prenom1',0600000001)
insert into Utilisateur values(2,'nom2','prenom2',0600000002)
insert into Utilisateur values(3,'nom3','prenom3',0600000003)

insert into Groupe values(1,'nomGroupe1')
insert into Groupe values(2,'nomGroupe2')
insert into Groupe values(3,'nomGroupe3')

insert into Compte values('adresseEmail1','2016-10-10','etat1',1,1)
insert into Compte values('adresseEmail2','2015-10-10','etat2',2,2)
insert into Compte values('adresseEmail3','2017-10-10','etat3',3,3)

insert into Messagee values('2020-10-10','objet1','contenu1','priorite1','adresseEmail1','adresseEmail2',null)
insert into Messagee values('2020-11-10','objet2','contenu2','priorite2','adresseEmail2','adresseEmail1','hhhhh')
insert into Messagee values('2020-12-10','objet3','contenu3','priorite3','adresseEmail3','adresseEmail2',null)


select*from Utilisateur
select*from Groupe
select*from Compte
select*from Messagee


select*from Messagee where adresseEmailExpediteur='saber112@gmail.com'


alter table Messagee
add constraint C1
check (priorite in('Elevee','Moyenne','Faible'))


go
create function F1(@idUtilisateur int)
returns int
as
begin
    return (select count(idMessage) as nbrMessage 
            from Messagee M,Compte C,Utilisateur U
            where M.adresseEmailExpediteur=C.adresseEmail
            and U.idUtilisateur=C.idUtilisateur
            and U.idUtilisateur=@idUtilisateur
            )
end


go
create procedure PRepondre @idMessage int,@Contenu varchar(30)
as
begin
declare @objet1 varchar(30)
declare @AEE varchar(30)
declare @AED varchar(30)

select  objet=@objet1,
        adresseEmailExpediteur=@AEE,
        adresseEmailDistinataire=@AED
        from Messagee
        where idMessageReponce=@idMessage

insert into 
Messagee(dateMessage,objet,contenu,priorite,adresseEmailExpediteur,adresseEmailDistinataire,idMessageReponce)
values(getDate(),'RE:'+@objet1,@Contenu,'Moyenne',@AEE,@AED,@idMessage)
end




go
create trigger T1
on Messagee
for insert
as
begin

if exists(select*from inserted I,Groupe G,Compte C
where C.idGroupe=G.idGroupe
and I.adresseEmailExpediteur=I.adresseEmail
and G.nomGroupe='chef de service')
begin

update Messagee
set priorite='Eleve'
where adresseEmailExpediteur=(select adresseEmailExpediteur from inserted)

end
end






go
create trigger T2
on Messagee
for insert
as
begin
if exists(select*from inserted I,Compte C 
where C.adresseEmail=I.adresseEmailExpediteur
and C.etat='Occupe')
rollback
end
