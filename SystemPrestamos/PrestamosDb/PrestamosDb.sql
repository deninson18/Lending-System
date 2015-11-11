create DataBase PrestamosDb;
use PrestamosDb;

select * from Usuarios;select * from Rutas;select * from Cobradores;select * from Clientes;select * from Prestamos;select * from Atrasos;

drop table Usuarios;drop table Rutas;drop table Cobradores;drop table Clientes;drop table Prestamos;drop table Atrasos;

create table Usuarios(UsuarioId int identity primary key,
Nombres varchar(30),NombresUsuarios varchar(40),
Contrasena varchar(50),Fecha date);

insert into Usuarios(Nombres,NombresUsuarios,Contrasena,Fecha) values('Nrp', 'the last', '1234anrp','12-03-2015');
delete from Usuarios where UsuarioId=2 ;

create table Rutas(RutaId int identity primary key,
NombreRuta varchar(100),CobradorId int,RutaDetalle varchar(200));

create table Cobradores(CobradorId int identity primary key,
Nombres varchar(30),Apellidos varchar(30),
Direccion varchar(100),Telefono varchar(20),Celular varchar(20),
Cedula varchar(20),RutaId int);

create table Clientes(ClienteId int identity primary key,
Nombres varchar(30),Apellidos varchar(30),Apodos varchar(30),
Direccion varchar(100),Referencia varchar(50),Sexo varchar(10),
Cedula varchar(30),Telefono varchar(20),Celular varchar(20));

create table Prestamos(PrestamoId int identity primary key,ClienteId int,
Direccion  varchar(100),FechaInicial datetime,FechaVencimiento datetime,
RutaId int,NombreRuta varchar(100),MontoPrestamos float,Cuotas float,Interes float,
TipodePrestamo varchar(15),PrestamosDetalle float);
                            
create table Atrasos(AtrasoId int identity primary key,CantidadAtraso int);

select * from Clientes
