
create database hotelsancarlos;
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
    estado char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table sucursal(
	idSucursal varchar(15) primary key not null,
	idEmpresa varchar(15) not null,
    nombre varchar(35) not null,
    direccion text not null,
    telefono int(10) not null,
    codigoPostal varchar(25) not null,
    estado char(1) not null,
    
    foreign key (idEmpresa) references empresa (idEmpresa)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE puesto (
  pkIdPuesto VARCHAR(11) PRIMARY KEY,
  nombre VARCHAR(45) NULL DEFAULT NULL,
  añosDeExperiencia INT NULL DEFAULT NULL,
  fkIdPuestoSuperior VARCHAR(11) NOT NULL,
  estado char(1) not null
 -- FOREIGN KEY (fkIdPuestoSuperior) REFERENCES puesto (pkIdPuesto))
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
 
create table tipofalta(
pkidTipofalta int primary key,
nombreTipofalta varchar(35) not null,
estado varchar(1) not null
)engine=InnoDB;

create table departamento(
pkidDepartamento int primary key,
nombreDepartamento varchar(35) not null,
estado varchar(1)
)engine=InnoDB;

CREATE TABLE cuentasContables (
    pkId VARCHAR(15)primary key,
    nombre VARCHAR(45),
    codigo VARCHAR(45),
    estado VARCHAR(1) 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table moneda(
	Pkid varchar(15) primary key,
	nombreMoneda varchar(30) not null,
	estado char(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

Create Table banco (
	IdBanco varchar(15)primary key,
	nombreBanco varchar(20) NOT NULL,
	direccionBanco varchar(25) NOT NULL,
    estado char(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE tipoConcepto (
    pkIdTipoConcepto VARCHAR(15),         
    nombreTipoConcepto VARCHAR(50),         
    estado VARCHAR(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE detalle_personalizado_unicamente (
    fkIdEmpleado VARCHAR(15),        
    fkIdConcepto VARCHAR(15)        
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE detalle_personalizado_excepto (
    fkIdEmpleado VARCHAR(15),        
    fkIdConcepto VARCHAR(15)       
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ------------------------------------------------------------------------------------------------------------
-- 	COMPONENTE SEGURIDAD
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE empleado (
	pkIdEmpleado VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NOT NULL,
	apellido VARCHAR(45) NOT NULL,
	fechaDeNacimiento VARCHAR(45) NOT NULL,
	sueldo FLOAT NOT NULL,
	correo VARCHAR(45) NOT NULL,
	direccion VARCHAR(45) NOT NULL,
	contratado VARCHAR(45) NOT NULL,
	añosDeExperiencia INT NOT NULL,
	telefono VARCHAR(10) NOT NULL,
    fechaContratacion DATE NOT NULL,
	finDeContrato DATE NOT NULL,
	fkIdPuesto VARCHAR(15) NOT NULL,
	fkIdEmpresa VARCHAR(15) NOT NULL,
    estado varchar(1) not null,
  
	FOREIGN KEY (fkIdPuesto) REFERENCES puesto (pkIdPuesto),
	FOREIGN KEY (fkIdEmpresa) REFERENCES empresa (IdEmpresa)
  )ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE usuario(
	pkId VARCHAR(15) PRIMARY KEY,
	fkIdEmpleado varchar(15) NOT NULL, 
	nombre VARCHAR(30) NOT NULL,
	contraseña VARCHAR(100) NOT NULL,
	estado VARCHAR(1) NOT NULL,
	
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
	rutaChm varchar(180) not null,
	rutaHtml varchar(180) not null,
    estado varchar(1) not null,
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

-- ------------------------------------------------------------------------------------------------------------
-- 	TABLAS GENERALES
-- ------------------------------------------------------------------------------------------------------------

