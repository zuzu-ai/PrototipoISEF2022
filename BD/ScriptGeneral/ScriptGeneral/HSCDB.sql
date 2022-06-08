-- --------------------------
# LDD Database hotelSanCarlos
-- --------------------------
-- DROP DATABASE hotelSanCarlos;
CREATE DATABASE hotelSanCarlos;
USE hotelSanCarlos;

-- ------------------------------------------------------------------------------------------------------------
-- 	TABLAS GENERALES
-- ------------------------------------------------------------------------------------------------------------
create table empresa(
	idEmpresa varchar(15) primary key not null,
	nit varchar(13) not null,
    nombre varchar(35) not null,
    direccion text not null,
    telefono int(10) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table sucursal(
	idSucursal varchar(15) primary key not null,
	idEmpresa varchar(15) not null,
    nombre varchar(35) not null,
    direccion text not null,
    telefono int(10) not null,
    codigoPostal int not null,
    estatus char(1) not null,
    
    foreign key (idEmpresa) references empresa (idEmpresa)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE puesto (
  pkIdPuesto VARCHAR(11) PRIMARY KEY,
  nombre VARCHAR(45) NULL DEFAULT NULL,
  añosDeExperiencia INT NULL DEFAULT NULL,
  fkIdPuestoSuperior VARCHAR(11) NOT NULL

 -- FOREIGN KEY (fkIdPuestoSuperior) REFERENCES puesto (pkIdPuesto))
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
 

-- ------------------------------------------------------------------------------------------------------------
-- 	COMPONENTE SEGURIDAD
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE empleado (
	pkIdEmpleado VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NULL DEFAULT NULL,
	apellido VARCHAR(45) NULL DEFAULT NULL,
	fechaDeNacimiento VARCHAR(45) NULL DEFAULT NULL,
	sueldo FLOAT NULL DEFAULT NULL,
	correo VARCHAR(45) NULL DEFAULT NULL,
	direccion VARCHAR(45) NULL DEFAULT NULL,
	contratado VARCHAR(45) NULL DEFAULT NULL,
	añosDeExperiencia INT NULL DEFAULT NULL,
	telefono VARCHAR(10) NULL DEFAULT NULL,
    fechaContratacion DATE NULL,
	finDeContrato DATE NULL,
	fkIdPuesto VARCHAR(15) NOT NULL,
	fkIdEmpresa VARCHAR(15) NOT NULL,
  
	FOREIGN KEY (fkIdPuesto) REFERENCES puesto (pkIdPuesto),
	FOREIGN KEY (fkIdEmpresa) REFERENCES empresa (IdEmpresa)
  )ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuario(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdEmpleado varchar(15) NOT NULL, 
	nombre VARCHAR(30) NOT NULL,
	contraseña VARCHAR(100) NOT NULL,
	estado VARCHAR(1) NOT NULL,
	intento INT NULL,

	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado(pkIdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE modulo(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	estado VARCHAR(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
	
CREATE TABLE aplicacion(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdModulo VARCHAR(15) NOT NULL,
	nombre VARCHAR(45) NULL,
	estado INT NOT NULL,
	rutaChm varchar(180) not null,
	rutaHtml varchar(180) not null,
	FOREIGN KEY (fkIdModulo) REFERENCES modulo(pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE bitacoraUsuario(
	pkId INT AUTO_INCREMENT PRIMARY KEY,
	fkIdUsuario VARCHAR(15) NOT NULL,
	`host` VARCHAR(45) NULL DEFAULT NULL,
	ip VARCHAR(20) NULL,
	fkIdModulo VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	accion VARCHAR(200) NOT NULL,
	conexionFecha DATE NULL,
	conexionHora TIME NULL,
  
	FOREIGN KEY (fkIdUsuario) REFERENCES usuario (pkId),
	FOREIGN KEY (fkIdModulo) REFERENCES modulo (pkId),
	FOREIGN KEY (fkIdAplicacion) REFERENCES aplicacion(pkID)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE perfil(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NULL,
	estado VARCHAR(45) NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuarioPerfil(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdPerfil VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuarioAplicacion(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
   
CREATE TABLE aplicacionPerfil (
	fkIdPerfil VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Vista #1
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hotelSanCarlos`.`vwpermisosperfil` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdPerfil`,
        `b`.`nombre` AS `Perfil`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`hotelSanCarlos`.`aplicacionperfil` `a`
        JOIN `hotelSanCarlos`.`perfil` `b` ON ((`b`.`pkId` = `a`.`fkIdPerfil`)))
        JOIN `hotelSanCarlos`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdPerfil`;

-- Vista #2
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hotelSanCarlos`.`vwpermisosusuario` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdUsuario`,
        `b`.`nombre` AS `Usuario`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`hotelSanCarlos`.`usuarioaplicacion` `a`
        JOIN `hotelSanCarlos`.`usuario` `b` ON ((`b`.`pkId` = `a`.`fkIdUsuario`)))
        JOIN `hotelSanCarlos`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdUsuario`;
    

CREATE TABLE usuarioAplicacionAsignados(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- REPORTEADOR
-- ------------------------------------------------------------------------------------------------------------
create table reporte (
	idReporte varchar(15) NOT NULL primary key,
	nombre varchar(20) NOT NULL,
	ruta varchar(100) NOT NULL,
    idAplicacion VARCHAR(15) not null,
	estado varchar(1) NOT NULL,
    foreign key (idAplicacion) references aplicacion(pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- CONSULTAS INTELIGENTES
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE registro_consultas (
   id_registro int primary key auto_increment NOT NULL,
   nombre varchar(200) DEFAULT NULL,
   consulta varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- MÓDULO CONTABILIDAD - PÓLIZAS
-- ------------------------------------------------------------------------------------------------------------
create table tipoCuenta(
	idTipoCuenta varchar(15), -- si es activo o pasivo
	nombre varchar(65), -- escribir nombre completo ej Activo Corriente
	estado varchar(1),

	primary key (idTipoCuenta)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table cuenta(
	idCuenta varchar(15), -- Identificador de la cuenta
	nombre varchar(65), -- Nombre de la cuenta
	idTipoCuenta varchar(15), -- foránea con Tipo Cuenta, se utiliza para los estados financieros
    cargo float default 0, -- cargo de la cuenta, inicia en 0 al crear la cuenta
    abono float default 0, -- abono de la cuenta, inicia en 0 al crear la cuenta
    saldoAcumulado float default 0, -- Saldo acumulado en la cuenta, inicia en 0 al crear la cuenta
	estado varchar(1) ,-- A-Activo , I-Inactivo
    -- Se usa Recursividad -> Para indicar el padre de la cuenta
    idCuentaPadre varchar(15) default null,
    -- Primaria
	primary key (idCuenta),
	-- Foránea
    foreign key (idTipoCuenta) references tipoCuenta (idTipoCuenta),
	-- Foránea
    foreign key (idCuentaPadre) references cuenta (idCuenta)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table tipoPoliza(
	idTipoPoliza varchar(15),
	descripcion varchar(65),
	estado varchar(1), -- A-Activo , I-Inactivo

	primary key (idTipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table polizaEncabezado(
	idPolizaEncabezado varchar(15),
	fechaPoliza date,
	idTipoPoliza varchar(15), -- foranea con tipo poliza
	

	primary key(idPolizaEncabezado,fechaPoliza),
    
	foreign key (idTipoPoliza) references tipoPoliza (idTipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table tipoOperacion(
	idTipoOperacion varchar(15),
	nombre varchar(65), 
	estado varchar(1),-- A-Activo , I-Inactivo

	primary key (idTipoOperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table polizaDetalle(
	idPolizaEncabezado varchar(15), 
    fechaPoliza date,
	idCuenta varchar(15), 		-- foranea con cuenta
	saldo float,
	idTipoOperacion varchar(15), -- debe/haber
	concepto varchar(65),
	
	primary key(idPolizaEncabezado, fechaPoliza, idCuenta),
    
    foreign key (idPolizaEncabezado) references polizaEncabezado (idPolizaEncabezado),
	foreign key (idCuenta) references Cuenta (idCuenta),
	foreign key (idTipoOperacion) references tipoOperacion (idTipoOperacion)
	
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- 	TABLAS GENERALES
-- ------------------------------------------------------------------------------------------------------------
create table tipoCliente(                      /*Huésped, Invitado(consumidor)*/
	idTipo varchar(15) primary key not null,
    nombre varchar(35) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


create table cliente(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	idTipo varchar(15) not null,
	apellido varchar(30) not null,
	nit varchar(15) not null,
	telefono varchar(15) not null,
	direccion varchar(50) not null,
	correo varchar(50) not null,
	estatus varchar(1),

foreign key (idTipo) references tipoCliente(idTipo)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table formaPago(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	estatus varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table tipoInventario(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	estatus varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

-- el impuesto y su %, lo calcula cada módulo según los que le apliquen
create table impuesto(
	idImpuesto varchar(15), -- ID del impuesto que cada módulo podra usar
    nombre varchar(65), -- el nombre del impuesto, ej: IVA
    porcentaje float, -- Porcentaje del impuesto, Ej el IVA que es del 12% se ingresa como 0.12, asi con los demás
    estado varchar(1), -- A activo, I inactivo
    primary key(idImpuesto) -- primaria del impuesto
)ENGINE = InnoDB DEFAULT CHARSET=latin1;

create table tipoBodega(
	pkid varchar(15) primary key,
	nombre varchar(30) not null,
	estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table bodega(
	pkid varchar(15) primary key,
	fkidTipobodega varchar(15) not null,
	nombre varchar(30) not null,
	direccion varchar(65) not null,
	estado varchar(1) not null,
	
    foreign key (fkidTipobodega) references Tipobodega(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table proveedor(
	idProveedor varchar(15),
	nombre varchar(100) not NULL,
	direccion varchar(500) not NULL,
	telefono int not NULL,
	email varchar(200) not NULL,
	idEmpresa varchar(15),
	stsproveedor varchar(1),
	primary key (idProveedor),
    
	foreign key (idEmpresa) references empresa (idEmpresa)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE marca (
	idMarca varchar(15),
	nombre varchar(100) not NULL,
	descripcion varchar(500) not NULL,
	primary key (idMarca)
 )ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE linea (
	idLinea varchar(15),
	nombre varchar(100) not NULL,
	descripcion varchar(500) not NULL,
	idMarca varchar(15) not null,
	primary key (idLinea),
	foreign key (idMarca) references marca (idMarca)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table Inventario(
	Pkid varchar(15) primary key,
	fkidsucursal varchar(15) not null,
	Fktipoinventario varchar(15) not null,
	fkidbodega varchar(15) NOT NULL,

	foreign key (Fktipoinventario) references TipoInventario (Pkid),
	foreign key (Fkidsucursal) references sucursal (idsucursal),
	foreign key (Fkidbodega) references bodega (pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table producto (
	pkid varchar(15) primary key,
	fkinventario varchar(15) not null,
	Nombre varchar(30) not null,
	Fkidlinea varchar(15) not null,
	Stock int not null,
    StockMaximo int not null,
    StockMinimo int not null,
	Costo float not null,
	Precio float not null,
	Estatus varchar(1),

	foreign key (Fkidlinea) references linea (idLinea),
	foreign key (fkinventario) references inventario (Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
