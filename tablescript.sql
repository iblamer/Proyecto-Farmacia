create table Usuarios 
(
UsuarioId int primary key identity(1,1),
Nombres varchar(30),
NombreUsuario varchar(20),
FechaNacimiento datetime,
Clave varchar(16),
TelefonoCasa varchar (11),
TelefonoCelular varchar (11),
TipoId int
);

create table Medicinas(
MedicinaId int primary key identity (1,1),
Nombre varchar(30),
Descripcion varchar(100),
PrecioVenta float,
PrecioCompra float,
FechaVencimiento datetime,
CantidadExistencia int,
LaboratorioId int,
Especificaciones varchar(100),
CategoriaId int
);

create table TipoUsuarios(
TipoId int primary key identity(1,1),
Descripcion varchar(30)
);

create table Laboratorios(
LaboratorioId int primary key identity (1,1),
Nombre varchar(30)
);

create table Ventas(
VentaId int primary key identity(1,1),
FechaVenta datetime,
Total float,
SubTotal float,
ITBIS float,
TipoVenta varchar(20),
MedicinaId int
);
