USE hotelSanCarlos;
-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO RRHH - PÓLIZAS
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE prestacionlaboral (
	pkIdPrestacionLaboral VARCHAR(11) PRIMARY KEY,
	nombre VARCHAR(45) NULL DEFAULT NULL,
	calcularDesde int NULL DEFAULT NULL,
	descripcion VARCHAR(45) NULL DEFAULT NULL)
 ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE totalPrestacion (
	pkPrestacion VARCHAR(11) PRIMARY KEY,
	fkIdEmpleado VARCHAR(11) NOT NULL,
	fkIdPrestacionLaboral VARCHAR(11) NOT NULL,
	fechaInicio DATETIME NULL,
	fechaFInal DATETIME NULL,
	totalDiasTrabajados INT NULL,
	totalPrestacion DECIMAL NULL,
  
	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado),
	FOREIGN KEY (fkIdPrestacionLaboral) REFERENCES prestacionlaboral (pkIdPrestacionLaboral))
 ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE desarrollodecarrrera (
	pkIdDesarrolloDeCarrera VARCHAR(11) PRIMARY KEY,
	observaciones VARCHAR(45) NULL DEFAULT NULL,
	aspiradorSueldo VARCHAR(45) NULL DEFAULT NULL,
	ausencias VARCHAR(45) NULL DEFAULT NULL,
	fkIdEmpleado VARCHAR(11) NOT NULL,
  
	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado))
 ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE mediodecontacto (
	pkIdMedioDeContacto VARCHAR(11) PRIMARY KEY,
	nombre VARCHAR(45) NULL DEFAULT NULL,
	costoMensual VARCHAR(45) NULL DEFAULT NULL,
	mediodecontactocol VARCHAR(45) NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE reclutamiento (
	pkIdReclutamiento VARCHAR(11) PRIMARY KEY,
	fkIdEmpleado VARCHAR(11) NOT NULL,
	fkIdMedioDeContacto VARCHAR(11) NOT NULL,
	
	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado),
	FOREIGN KEY (fkIdMedioDeContacto) REFERENCES mediodecontacto (pkIdMedioDeContacto)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE diasLaborados (
	pkDiasTrabajados VARCHAR(11) PRIMARY KEY,
	fkIdEmpleado VARCHAR(11) NOT NULL,
	año INT NULL,
	enero INT NULL,
	febrero INT NULL,
	marzo INT NULL,
	abril INT NULL,
	mayo INT NULL,
	junio INT NULL,
	julio INT NULL,
	agosto INT NULL,
	septiembre INT NULL,
	octubre INT NULL,
	noviembre INT NULL,
	diciembre INT NULL,
	totalDiasTrabajados INT NULL,
  
	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE nominas (
	pkIdNominas VARCHAR(11) PRIMARY KEY, 
	fkIdEmpleado VARCHAR(11) NOT NULL,
	año INT NULL,
	mes VARCHAR(45) NULL,
	diasLaborados int NULL,
	horasOrdinarias float NULL,
	horasExtraordinarias float NULL,
	salarioTotal float NULL,
	igss float NULL,
	isr float NULL,
	totalDeducciones float NULL,
	salarioLiquido float NULL,

	FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
