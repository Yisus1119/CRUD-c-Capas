-- Creacion de nuestra base de datos. --

create database MiPrimeraVez

use MiPrimeraVez

-- Creamos nuestra tabla tal como lo indica el mandato. --

create table Mercancias
( IdMercancia int not null IDENTITY(1,1),
Descripcion varchar(120),
Existencia tinyint default 0,
Comentario nvarchar(100),
Status varchar(10) default 'Activa',
NoEliminable bit default 0
)

-- Creamos nuestro índice y nuestra primary key con orden ascendente. --

alter table Mercancias add constraint PkMercancias primary key (IdMercancia ASC)
create index idx_Descripcion on Mercancias(Descripcion)

-- Insertamos dos registros para comprobar la validez de nuestra tabla. --

insert into Mercancias values ('Gorras',default,'Gorras en buen estado',default,default)

insert into Mercancias values ('Audifonos',45,'Audifonos en muy buen estado','Inactiva',1)

select * from Mercancias

-- procedimientos almacenados / store procedures --

-- Procedimiento para ver nuestras mercancías. --
create proc MostrarMercancias
as
select * from Mercancias
go

-- Procedimiento para insertar nuestras mercancías. --
create proc InsertarMercancia
@Descripcion varchar(120),
@Existencia tinyint,
@Comentario nvarchar(100),
@Status varchar(10),
@NoEliminable bit
as
insert into Mercancias values(@Descripcion,@Existencia,@Comentario,@Status,@NoEliminable)
go

-- Procedimiento para actualizar nuestras mercancías. --
create proc ActualizarMercancia
@Descripcion varchar(120),
@Existencia tinyint,
@Comentario nvarchar(100),
@Status varchar(10),
@NoEliminable bit,
@IdMercancia int
as
update Mercancias set Descripcion=@Descripcion, Existencia=@Existencia, Comentario=@Comentario, Status=@Status, NoEliminable=@NoEliminable
where IdMercancia=@IdMercancia
go

-- Procedimiento para borrar nuestra mercancía. --
create proc EliminarMercancia
@IdMercancia int
as
delete from Mercancias where IdMercancia=@IdMercancia
go

-- Procedimiento para buscar nuestras mercancías. --
create proc BuscarMercancia
@Descripcion varchar(120)
as
select * from Mercancias where Descripcion=@Descripcion
go

