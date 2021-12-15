create database EFM_ASP_208
drop database EFM_ASP_208
use master
use EFM_ASP_208
create table Professeur(
    MatriculeProfesseur varchar(30) primary key,
    Nom varchar(30),
    Tel bigint
)
create table Cours(
    NumCours int primary key,
    Salle varchar(30),
    MatriculeProfesseur varchar(30) foreign key references Professeur(MatriculeProfesseur),
    Titre varchar(30),
    Coef int
)
create table Etudiant(
    code_Etudiant int primary key identity,
    Nom varchar(30),
    Date_naiss date,
    Tel bigint,
    mail varchar(30) unique,
    pass varchar(30)
)
create table Examen(
    numCours int foreign key references Cours(NumCours),
    CodeEtudiant int foreign key references Etudiant(code_Etudiant),
    Datee date,
    Note float,
    primary key(CodeEtudiant,numCours)
)

insert into Cours values(1,'Salle1','MatriculeProfesseur1','Titre1',2)
insert into Cours values(2,'Salle2','MatriculeProfesseur2','Titre2',1)
insert into Cours values(3,'Salle3','MatriculeProfesseur3','Titre3',3)

insert into Etudiant values('Nom1','2020-10-10',0600000000,'mail1','pass1')
insert into Etudiant values('Nom2','2020-11-11',0600000001,'mail2','pass2')
insert into Etudiant values('Nom3','2020-12-12',0600000002,'mail3','pass3')

insert into Professeur values('MatriculeProfesseur1','Nom1',0600000010)
insert into Professeur values('MatriculeProfesseur2','Nom2',0600000011)
insert into Professeur values('MatriculeProfesseur3','Nom3',0600000012)

insert into Examen values(1,1,'2020-01-01',18.50)
insert into Examen values(2,2,'2020-02-02',16.25)
insert into Examen values(3,3,'2020-03-03',14.75)

select*from Cours
select*from Etudiant
select*from Professeur
select*from Examen

select C.* from Cours C,Etudiant E,Examen E1 where C.NumCours = E1.numCours and E1.CodeEtudiant=E.Etudiant and code_Etudiant


select*from Cours where Salle=''

select*from Cours where MatriculeProfesseur=''


delete from Professeur where MatriculeProfesseur=''


update Professeur set Nom='',Tel= where MatriculeProfesseur=''
