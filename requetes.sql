use master;
Create database bibliotheque
on primary
(name=biblio_db,
filename ="C:\Users\pfievet\Desktop\exos\bibliothéque\Bd\BD_files\biblio_db.mdf",
size = 400 Mb,
maxsize = 500 Mb,
filegrowth= 5%
)
log on 
(
name=biblio_db_log,
filename = "C:\Users\pfievet\Desktop\exos\bibliothéque\Bd\BD_files\biblio_db_log.ldf",
size = 30 Mb,
maxsize = 120 mb,
filegrowth = 5%
)

use bibliotheque;
create table abonne
(
idAbo int identity(1,1) primary key,
nomAbo varchar(20) not null,
prenomAbo varchar(20) not null,
telAbo int null,
dateArrAbo datetime not null,
dateResAbo datetime null
)

create table Relance
(
idRelance int identity(1,1) primary key,
DateRelance datetime not null,
IdAbo int not null
)

create table theme
(
idTheme int identity(1,1) primary key,
nomTheme varchar(20) not null
)

create table editeur
(
idEditeur int identity(1,1) primary key,
nomEditeur varchar(20) not null
)

create table auteur
(
idAuteur int identity(1,1) primary key,
nomAuteur varchar(20) not null,
prenomAuteur varchar(20) not null
)

create table livre
(
idLiv int identity (1,1) primary key,
titLiv varchar(20) not null,
dateEngLiv datetime not null,
etatLiv char(9) null,
dateEditLiv datetime not null,
IdTheme int not null,
IdEditeur int not null
)

create table emprunt
(
idEmp int identity(1,1) primary key,
dateEmp datetime not null,
dateReEmp datetime null,
IdAbo int not null,
IdLiv int not null
)

create table rebus
(
idRebus int identity(1,1) primary key,
dateRebus datetime not null,
IDliv int not null
)

create table ecrire
(
IdLiv int not null,
IdAuteur int not null
)

alter table relance
add constraint FK_idAbo foreign key (IdAbo) references abonne(idAbo)

alter table rebus
add constraint FK_idliv foreign key (IdLiv) references livre(idLiv)

alter table emprunt 
add constraint FK_emprunt_Abonne foreign key (IdAbo) references abonne(idAbo)

alter table emprunt
add constraint FK_emprunt_livre foreign key (IdLiv) references livre(idLiv)

alter table livre
add constraint FK_theme foreign key (IdTheme) references theme(idTheme)

alter table livre
add constraint FK_editeur foreign key (IdEditeur) references editeur(idEditeur)

alter table ecrire
add constraint PK_ecrire primary key nonclustered (IdLiv,IdAuteur)

alter table ecrire
add constraint FK_ecrire_livre foreign key (IdLiv) references livre(idLiv)

alter table ecrire
add constraint FK_ecrire_auteur foreign key(IdAuteur) references auteur(idAuteur)

alter table abonne
add constraint CK_tel check (telAbo like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')


/* manip supplementaires    */
alter table emprunt
drop constraint FK_emprunt_livre


create table utilisateurs
(
numUser int identity(1,1) primary key,
pseudo varchar(30) not null,
password varchar(10) not null
)
//
insert into utilisateurs(pseudo,password) values('admin','pwd')
select * from utilisateurs
//
alter trigger tg_utilisateurs
on dbo.abonne
after insert
As 
	begin
	declare @pseudo varchar(30), @password varchar(15)
	select @pseudo = substring(prenomAbo,1,3) + substring(nomAbo,1,3) + cast (DATEPART(dw,current_timestamp) as char) from inserted
	select @password = substring(nomAbo,1,2) + cast (DATEPART(dw,dateArrAbo) as char) from inserted
	
	insert into dbo.utilisateurs (pseudo,password,idAbo) values(@pseudo,@password,(select idAbo from inserted))
	end

insert into abonne(nomAbo,prenomAbo,dateArrAbo) values('fievet','philippe',current_timestamp)
insert into abonne(nomAbo,prenomAbo) values('fievet','philippe')
//
create trigger tg_delUser
on dbo.abonne
after delete
As
	begin
	delete from dbo.utilisateurs where pseudo = ( select substring(prenomAbo,1,3) + substring(nomAbo,1,3) + cast (DATEPART(dw,dateArrAbo) as char) from deleted)
	end
//

create proc PS_insertLivre
@newTitre varchar(20),
@idAuteur int,
@idTheme int,
@idEditeur int,
@dateEnregis datetime,
@dateEdition datetime
As 
begin tran
	insert into livre (titLiv,dateEngLiv,etatLiv,dateEditLiv,IdTheme,IdEditeur) 
	values(@newTitre,CURRENT_TIMESTAMP,'enregistre',@dateEdition,@idTheme,@idEditeur)
	

commit tran

alter proc PS_insertLivre
@newTitre varchar(20),
@idAuteur int,
@idTheme int,
@idEditeur int,
@dateEdition varchar(20)
As 
begin tran
	begin 

	
		insert into livre (titLiv,dateEngLiv,etatLiv,dateEditLiv,IdTheme,IdEditeur,Idauteur) 
		values(@newTitre,CURRENT_TIMESTAMP,'dispo',@dateEdition,@idTheme,@idEditeur,@idAuteur)
	end

commit tran
	
//
create trigger TG_EmpruntLivre
on dbo.emprunt
after insert
As
begin
	update dbo.livre set etatLiv='emprunt' where idLiv = (select IDLiv from inserted)
end

//

create view listEmprunts
As
select Code,nomAbo,prenomAbo,dateEmp,nbrRelance from emprunt E
join abonne A on E.IdAbo = A.idAbo
join relance R on A.idAbo = R.IdAbo

//

create trigger TG_ListEmprunts
on emprunt
after insert 
As
insert into Relance (DateRelance,IdAbo,nbrRelance) values (CURRENT_TIMESTAMP,(select IdAbo from inserted),0)

//
alter proc listAboREl
@nbre int

As
begin 
	select Code ,nomAbo ,prenomAbo from Relance 
	join abonne on abonne.idAbo = Relance.IdAbo
	join emprunt on emprunt.IdAbo = Relance.IdAbo
	where nbrRelance = @nbre 
end

exec listAboREl 0,@Code OUTPUT,@nomAbo OUTPUT,@prenomAbo OUTPUT
//
alter proc AffEmpruntbyCode
@code varchar(8)
As
begin
	select titLiv,dateEmp,IdAbo from livre 
	join emprunt on emprunt.IdLiv = livre.idLiv
	where Code = @code
end

exec AffEmpruntbyCode 'emp5'
//
create trigger TG_REbus
on dbo.rebus
after insert
As
update livre set etatLiv = 'rebus' where idLiv = (select IDliv from inserted)

drop trigger TG_REbus

update dbo.livre set etatLiv='dispo' where etatLiv ='enreg'
//

create trigger TG_REbusversDIspo
on dbo.rebus
after delete
As
update livre set etatLiv = 'dispo' where idLiv = (select IDliv from deleted)
//
alter proc PS_InfoDateLivre
@idlivre int
As
begin
	select dateEditLiv,dateEngLiv,dateEmp,nomAbo,prenomAbo,nomEditeur,livre.idLiv from livre 
	join emprunt on emprunt.IdLiv = livre.idLiv
	join abonne on emprunt.IdAbo = abonne.idAbo
	join editeur on livre.IdEditeur = editeur.idEditeur   
	where livre.idLiv = @idlivre
end

exec PS_InfoDateLivre 27

alter proc PS_InfoDateLivre
@idlivre int,
@status varchar(8) 
As
begin
	if( (select COUNT(*) from emprunt where IdLiv = @idlivre) > 0)
		begin 
			
			select dateEditLiv,dateEngLiv,dateEmp,nomAbo,prenomAbo,nomEditeur,livre.idLiv from livre 
			join emprunt on emprunt.IdLiv = livre.idLiv
			join abonne on emprunt.IdAbo = abonne.idAbo
			join editeur on livre.IdEditeur = editeur.idEditeur   
			where livre.idLiv = @idlivre
		end
	if( (select COUNT(*) from emprunt where IdLiv = @idlivre) = 0)
	begin
			select dateEditLiv,dateEngLiv,nomEditeur,livre.idLiv from livre 
			join editeur on livre.IdEditeur = editeur.idEditeur   
			where livre.idLiv = @idlivre
	end
	if( (select COUNT(*) from rebus where IdLiv = @idlivre) = 1)
	begin
			select dateEditLiv,dateEngLiv,nomEditeur,livre.idLiv,dateRebus from livre 
			join editeur on livre.IdEditeur = editeur.idEditeur
			join rebus on rebus.IDliv = livre.idLiv   
			where livre.idLiv = @idlivre
	end
end

select COUNT(*) from emprunt where IdLiv = 21
exec PS_InfoDateLivre 27

//
  create view dbo.Vue_listedesempruntencours
  as
  select Code,nomAbo,prenomAbo,dateEmp,titLiv,dateReEmp from emprunt E join abonne A on E.IdAbo = A.idAbo join livre on livre.idLiv = E.IdLiv where etatLiv ='emprunt' 
	except
  select Code,nomAbo,prenomAbo,dateEmp,titLiv,dateReEmp from emprunt E join abonne A on E.IdAbo = A.idAbo join livre on livre.idLiv = E.IdLiv where etatLiv ='emprunt' and DATEDIFF(day,dateEmp,dateReEmp) > 0
//

  select idAbo,nomAbo,prenomAbo from dbo.Vue_listedesempruntencours
//
  alter view dbo.Vue_listedesempruntencours
  as
  select A.idAbo,Code,nomAbo,prenomAbo,dateEmp,titLiv,dateReEmp from emprunt E join abonne A on E.IdAbo = A.idAbo join livre on livre.idLiv = E.IdLiv where etatLiv ='emprunt' 
	except
  select A.idAbo,Code,nomAbo,prenomAbo,dateEmp,titLiv,dateReEmp from emprunt E join abonne A on E.IdAbo = A.idAbo join livre on livre.idLiv = E.IdLiv where etatLiv ='emprunt' and DATEDIFF(day,dateEmp,dateReEmp) > 0
//
  select * from abonne where EXISTS (select * from dbo.Vue_listedesempruntencours)
 //

create proc VerifLogin
@login varchar(30),
@password varchar(10),
@n int output
As
begin
set @n = (select count(*) from utilisateurs where pseudo=@login and password=@password)
end

declare @n int
declare @id int
exec VerifLogin phifie7,fi7,@n output,@id output
print @n
print @id


alter proc VerifLogin
@login varchar(30),
@password varchar(10),
@n int output,
@id int output
As
begin
set @n = (select count(*) from utilisateurs where pseudo=@login and password=@password)
end
begin
set @id = (select idAbo from utilisateurs where pseudo=@login and password=@password)
end

	
	


