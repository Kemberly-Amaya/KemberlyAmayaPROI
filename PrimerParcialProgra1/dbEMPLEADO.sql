use master
go
drop database if exists EMPLEADO
go
create database EMPLEADO
go
use EMPLEADO

create table Tbl_empleado(
	id_empleado int primary key not null identity,
	Empl_nombre varchar(100) ,
	Empl_apellido varchar(100),
	Empl_DUI varchar(10),
	Empl_direccion varchar(200),
	Empl_tel varchar(15),
	Empl_email varchar(100),
	Empl_cargo varchar(50),
);

insert into Tbl_empleado values('Alfredo','Palacios','87346574-4','Chalatenango','78547645','alfredP@gmail.com','Gerente'),
						   ('Ginema','Osorio','67548745-5','reubicacion 2, pol7 casa#6','67547645','gimenaOsorio@gmail.com','Cajera'),
						   ('Wilfredo','Arteaga','78949834-6','La palma, chalatenango','67898765','wilfredo87438@gmail.com','Encargado de bodega');

select * from Tbl_empleado