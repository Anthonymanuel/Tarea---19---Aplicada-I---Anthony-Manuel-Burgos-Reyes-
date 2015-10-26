Create database PeliculaDB
use PeliculaDB

create table Peliculas(
PeliculaId int identity(1,1) primary key,
Titulo varchar(40) not null,
Descripcion varchar(100),
Ano int not null,
Calificacion int,
IMBD int ,
CategoriaId int,
Foto varchar(200),
Video varchar(200),
Estudio Varchar(100)

)

Create table Generos(
GeneroId int identity(1,1) primary key,
Descripcion  varchar(60)
)

create table Estudios(
EstudioId int identity(1,1),
NombreEstudio varchar(100)
)

create table Actores(
ActorId int identity(1,1) primary key,
Nombre varchar(150)
)

Create table PeliculasActores(
PeliculaId int,
ActorId int  

)
Create table PeliculasGeneros(
PeliculaId int,
GeneroId int  

)