Create database Egresados_ITN

create table Roles(
RoleID int,
rNombre char(50)
)

create table Egresados(
NoControl int not null,
eNombre char(50) not null,
eCarreraID int not null,
eFechaIngreso date not null,
eFechaEgreso date not null,
eTitulado char(2),
eTrabaja char(2),
eEmpresa char(30),
ePuesto char(20),
eContacto char(20),
eTelefono int not null,
eCorreo nvarchar(50) not null,
ePswd char(12) not null,
eRoleID int not null
)

create table Departamentos(
dDepartamento int not null,
dNombre varchar(30) not null
)

create table Carreras(
cCarreraID int not null,
cNombre varchar(50)
)

create table Profesores(
RFC char(15) not null,
pNombre nvarchar(50) not null,
pDepartamentoID int not null,
pPswd char(12) not null,
pRoleID int not null
)

create table Solicitudes(
sNoControl int not null,
sNombre nvarchar(50) not null,
sCarreraID int not null,
sFechaIngreso date not null,
sFechaEgreso date not null,
sTitulado char(2),
sTrabaja char(2),
sEmpresa nvarchar(50),
sPuesto nchar(30),
sContacto nvarchar(50),
sTelefono int not null,
sCorreo nvarchar(50) not null,
sPswd char(12) not null,
sRoleID int not null
)

create table Noticias(
NoticiaID int not null,
nNombre nchar(50) not null,
nContenido nvarchar(500),
nImagen image,
nFechaPub date not null
)