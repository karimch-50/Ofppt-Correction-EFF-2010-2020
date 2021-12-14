create database EFF2012_TP_V3_1_DB
--remarque ses question et le meme pour EFF2012_TP_V3_2 est EFF2012_TP_V3_3 
--just la base de donne et different
use EFF2012_TP_V3_1_DB
CREATE TABLE entretien 
(   
    identretien int PRIMARY KEY ,
    nomentretien NVARCHAR(35),
    frequence int,
    periode NVARCHAR(35) check (periode in ('jour','mois','semaine','année')),
    kilometrage int,
    montant float
)
CREATE TABLE conducteur 
(   
    idconducteur int PRIMARY KEY ,
    nomc NVARCHAR(35),
    prenc NVARCHAR(35),
    daten date,
    pass NVARCHAR(35)
)
CREATE TABLE vehicule
(
    immat NVARCHAR(35) PRIMARY KEY,
    marque NVARCHAR(35),
    modele NVARCHAR(35),
    puissance int ,
    carburant NVARCHAR(35) check (carburant in ('essence','diesel')),
    dateachat date,
    compteur int ,
    idconducteur int foreign key REFERENCES conducteur(idconducteur)
   
)
CREATE TABLE assvehicule
(   
    idass int PRIMARY KEY ,
    nomassureur NVARCHAR(35),
    dateass date,
    dateexpiration date,
    immat NVARCHAR(35) foreign key REFERENCES vehicule(immat)
)
CREATE TABLE entrvehicule
(   
    identrveh int PRIMARY KEY ,
    immat NVARCHAR(35) foreign key REFERENCES vehicule(immat),
    identretien int foreign key REFERENCES entretien(identretien),
    dateentretien date,
    kmvehicule int 
)

insert into conducteur values (1,'nomc1','prenc1',GETDATE(),'pass1')
insert into conducteur values (2,'nomc2','prenc2',GETDATE(),'pass2')
insert into conducteur values (3,'nomc3','prenc3',GETDATE(),'pass3')

insert into vehicule VALUES('immat1','marque1','modele1',11,'essence',getdate(),15,1)
insert into vehicule VALUES('immat2','marque2','modele2',22,'diesel',getdate(),15,2)
insert into vehicule VALUES('immat3','marque2','modele3',33,'essence',getdate(),15,3)

insert into entretien values(1,'nomentretien1',11,'jour',22,1000)
insert into entretien values(2,'nomentretien2',22,'mois',22,2000)
insert into entretien values(3,'nomentretien3',33,'année',22,3000)

insert into entrvehicule values (1,'immat1',1,getdate(),11)
insert into entrvehicule values (2,'immat2',2,getdate(),33)
insert into entrvehicule values (3,'immat3',3,getdate(),33)

insert into assvehicule values (1,'nomassureur1',getdate(),'20210707','immat1')
insert into assvehicule values (2,'nomassureur2',getdate(),'20210707','immat2')
insert into assvehicule values (3,'nomassureur3',getdate(),'20210707','immat3')

select * from conducteur
select * from vehicule
select * from entretien
select * from entrvehicule
select * from assvehicule