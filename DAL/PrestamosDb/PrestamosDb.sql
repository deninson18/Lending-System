create database PrestamosDb;
use PrestamosDb;

select * from Usuarios;select * from Rutas;select * from Cobradores;select * from Clientes;select * from Prestamos;select * from Atrasos;

drop table Usuarios;drop table Rutas;drop table Cobradores;drop table Clientes;drop table Prestamos;drop table Atrasos;

create table Usuarios(UsuarioId int identity primary key,
Nombres varchar(30),NombresUsuarios varchar(40),AreaUsuarios varchar(30),
Contrasena varchar(50),Fecha varchar(30));

insert into Usuarios(Nombres,NombresUsuarios,AreaUsuarios,Contrasena,Fecha) values('Natanael', 'elnata93', 'Administrador','nrpabc','12-03-2015');
delete from Cobradores where CobradorId=2;

create table Rutas(RutaId int identity primary key,
NombreRuta varchar(100),CobradorId int references Cobradores(CobradorId),RutaDetalle varchar(200));
insert into Rutas(NombreRuta,CobradorId) Values ('Pimentel',1)
select c.Nombres,c.Apellidos,c.Direccion,r.RutaId from Rutas r inner join Cobradores c on c.CobradorId = r.CobradorId where RutaId=3;
insert into Cobradores(Nombres,Apellidos,Direccion,Telefono,Celular,Cedula) Values ('Anthony','Burgos','Los arcarizos','8092905555','80934324342','0564324324324')

create table Cobradores(CobradorId int identity primary key,
Nombres varchar(30),Apellidos varchar(30),
Direccion varchar(100),Telefono varchar(14),Celular varchar(14),
Cedula varchar(13));

create table Clientes(ClienteId int identity primary key,
Nombres varchar(30),Apellidos varchar(30),Apodos varchar(30),
Direccion varchar(100),Referencia varchar(50),Sexo bit,
Cedula varchar(12),Telefono varchar(14),Celular varchar(14),RutaId int references Rutas(RutaId));
drop table Clientes
select * from Clientes

create table Prestamos(PrestamoId int identity primary key,ClienteId int,
Direccion  varchar(100),FechaInicial varchar(20),FechaVencimiento varchar(20),
RutaId int,NombreRuta varchar(100),Capital float,Cuotas float,Interes float,
TipodePrestamo varchar(15));
                            
create table Atrasos(AtrasoId int identity primary key,CantidadAtraso int);

select c.CobradorId, c.Nombres,c.Apellidos from Cobradores c inner join Rutas r on c.CobradorId = r.CobradorId;