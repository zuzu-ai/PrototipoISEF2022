use hotelSanCarlos;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Primer sprint - Angel Chacón - Tablasjornada y conceptos - Fecha: 04/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
-- se hizo un alter a la tabla de banco ya que no tenia el campo estado
alter table banco add estado VARCHAR(1) NOT NULL;
-- se normalizo el campo esta de la tabla modena
alter table moneda drop estadomoneda;
alter table moneda add estado VARCHAR(1) NOT NULL;
-- tablas necesarias para los conceptos
-- cambio de datos para las ayudas de los mantenimientos de las tablas asignadas
UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\ayuda bancos y moneda.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-bancos.html' WHERE pkId='0009';
UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\ayuda bancos y moneda.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-moneda.html' WHERE pkId='0010';

UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\AyudaConceptosExcepciones.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-conceptos.html' WHERE pkId='0007';
UPDATE aplicacion SET rutaChm='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\AyudaConceptosExcepciones.chm',rutaHtml='C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\Ayudas-Pareja2\\Ayuda-para-la-vista-del-mantenimiento-de-Excepciones.html' WHERE pkId='0008';
-- indicacion de las rutas de los reportes de conceptos y las excepciones
INSERT INTO reporte VALUES ('1','Reporte 1','C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteExcepciones.rpt','0008','1');
INSERT INTO reporte VALUES ('2','Reporte 2','C:\\Users\\achac\\OneDrive\\Escritorio\\RRHH\\Cambios 04042022\\IS220221\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteConceptos.rpt','0007','1');

-- inserts a la tabla de modulo para los reportes de conceptos y las excepciones
insert into modulo values ('2','Banco','Modulo Bancos','1');
insert into modulo values ('3','Conceptos','Modulo Coceptos','1');


-- Tabla para guardar las sentencias SQl
CREATE TABLE sentenciaSqlPlanilla (      
    fkIdConcepto VARCHAR(15), 
    sentenciaSql VARCHAR(100)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - Tabla ISR ENCABEZADO Y DETALLE E INSERTS - Fecha: 09/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE isrencabezado (
    pkIdISR VARCHAR(15),
    periodoInicio DATE NOT NULL,
    periodoFinal DATE NOT NULL,
    isrTotal DOUBLE(10,2) NOT NULL,
    estado VARCHAR(1) NOT NULL,
    PRIMARY KEY (pkIdISR)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE isrdetalle (
    fkIdISR VARCHAR(15) NOT NULL,     
    fkIdEmpleado VARCHAR(15) NOT NULL,
    isrSubTotal DOUBLE(10,2) NOT NULL,
    estado VARCHAR(1) NOT NULL,
    FOREIGN KEY (fkIdISR) REFERENCES isrencabezado (pkIdISR),
    FOREIGN KEY (fkIdEmpleado) REFERENCES empleado (pkIdEmpleado)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `hotelsancarlos`.`empleado` (`pkIdEmpleado`, `nombre`, `apellido`, `fechaDeNacimiento`, `sueldo`, `correo`, `direccion`, `contratado`, `añosDeExperiencia`, `telefono`, `fechaContratacion`, `finDeContrato`, `fkIdPuesto`, `fkIdEmpresa`, `estado`) VALUES ('2', 'Pedro', 'Sanchez', '1998-05-23', '3500', 'spedro@gmail.com', 'zona 2', '4', '5', '65985874', '2016-11-03', '2021-12-01', '1', '1', '1');


-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Heydi Quemé, Kevin Flores - Tabla nomina detalle y encabezado - Fecha: 18/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
create table nomina_e
(
CodigoNominaE varchar (15) primary key,
FechaInicialN date not null,
FechaFinalN date not null,
TotalPercepciones float,
TotalDeducciones float,
TotalLiquido float,
 estado char(1) not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table nomina_d
(
CodigoNominaE varchar (15) not null,
pkIdEmpleado varchar (15) not null,
pkIdConcepto varchar (15) not null,
SueldoBase decimal not null,
CalculoConcepto float not null,
SueldoLiquido float not null,
estado varchar(1) not null,

foreign key (CodigoNominaE) references
nomina_e(CodigoNominaE),
foreign key (pkIdEmpleado) references
empleado(pkIdEmpleado),
foreign key (pkIdConcepto) references
concepto(pkIdConcepto)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - Tabla conceptos - Fecha: 28/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

use hotelsancarlos;

drop table if exists excepciones;


-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Heydi Quemé, Kevin Flores - tabla jornada, empleado y periodo - Fecha: 18/04/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE `hotelsancarlos`.`empleado` 
CHANGE COLUMN `contratado` `fkIdJornada` VARCHAR(15) NOT NULL ;

ALTER TABLE `hotelsancarlos`.`empleado` 
ADD CONSTRAINT `jornada_ibfk_1`
  FOREIGN KEY (`fkIdJornada`)
  REFERENCES `hotelsancarlos`.`jornada` (`pkId`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

CREATE TABLE jornada (
    pkId VARCHAR(15) PRIMARY KEY,   
    nombre VARCHAR(60) NOT NULL,              
    horaInicio time NULL,
    horaFin time NULL,    
    horasJornada VARCHAR(10) not NULL, 
    estado VARCHAR(1) NOT NULL       
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

  ALTER TABLE empleado ADD FOREIGN KEY (fkIdJornada) REFERENCES jornada(pkid);
  
  INSERT INTO JORNADA VALUES ("1","Matutina", "8:00:00","17:00:00","8","1");
  INSERT INTO JORNADA VALUES ("2","Diurna", "15:00:00","22:00:00","6","1");

CREATE TABLE periodo (
    pkId VARCHAR(15) PRIMARY KEY,           
    nombre VARCHAR(60) NOT NULL,                  
    inicio date NOT NULL,         
    fin date NOT NULL,    
    estado VARCHAR(1) NOT NULL       
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
  
-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón, Danny Saldaña - Tabla Cuentas Contables, Formulas, Conceptos - Fecha: 04/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE cuentasContables (
    pkId VARCHAR(15) primary key,
    nomenclatura VARCHAR(45),  -- 1001
    nombre VARCHAR(45), -- Caja, Bancos
    efecto VARCHAR(1), -- 1 = Deudor o 2 = Acreedor
    estado VARCHAR(1) 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into cuentascontables values ("1","1001","Caja","2","1");
insert into cuentascontables values ("2","1002","Banco","2","1");
insert into cuentascontables values ("3","1003","Bienes Muebles","2","1");

CREATE TABLE formula (
    pkIdFormula VARCHAR(15) PRIMARY KEY,               
    valorFormula VARCHAR(800),     
    estado VARCHAR(1) NOT NULL     
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

insert into formula values ("0","NA","1");

drop table if exists concepto;
CREATE TABLE concepto (
    pkIdConcepto VARCHAR(15) PRIMARY KEY,           
    nombreConcepto VARCHAR(60) NOT NULL,                
    efectoConcepto VARCHAR(1) NOT NULL,         
    aplicacion VARCHAR(1) NOT NULL,    -- Identificacion:    1=todos, 2=algunos, 3=todos,excepto
    fkformulaConcepto VARCHAR(15) DEFAULT NULL,     -- llave Foranea formulaConcepto
    valorConcepto VARCHAR(25), 
    fkCuentaContable VARCHAR(15),      -- llave Foranea CuentaContable
    estado VARCHAR(1) NOT NULL,
    foreign key (fkformulaConcepto) references  formula (pkIdFormula),
    foreign key (fkCuentaContable) references  cuentasContables (pkId)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE CONCEPTO MODIFY COLUMN  fkformulaConcepto VARCHAR(15) DEFAULT NULL;

ALTER TABLE `hotelsancarlos`.`concepto` 
DROP FOREIGN KEY `concepto_ibfk_1`;
ALTER TABLE `hotelsancarlos`.`concepto` 
CHANGE COLUMN `fkformulaConcepto` `TipoValor` VARCHAR(1) NULL DEFAULT NULL ,
DROP INDEX `fkformulaConcepto` ;
;
ALTER TABLE `hotelsancarlos`.`concepto` 
ADD CONSTRAINT `concepto_ibfk_1`
  FOREIGN KEY ()
  REFERENCES `hotelsancarlos`.`formula` ();


-- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - Tabla AsignarSaldosPorEmpleado - Fecha: 08/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

create table saldosporempleados(
pkid varchar (15) not null primary key,
fkIdConcepto varchar(15) not null,
fkIdEmpleado varchar(15) not null,
saldo double(10,2) not null,
estado varchar(1) not null,
foreign key (fkIdConcepto) references concepto (pkIdConcepto),
foreign key (fkIdEmpleado) references empleado (pkIdEmpleado)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

  -- --------------------------------------------------------------------------------------------------------------------------------------
-- Tercer sprint - Angel Chacón - tabla para la asignación de empleados a los conceptos - Fecha: 12/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
drop table empleado_concepto;
create table empleado_concepto(
fkIdConcepto varchar(15) not null,
fkIdEmpleado varchar(15) not null,
foreign key  (fkIdConcepto) references concepto (pkIdConcepto),
foreign key  (fkIdEmpleado) references empleado (pkIdEmpleado)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

 -- --------------------------------------------------------------------------------------------------------------------------------------
-- Cuarto sprint - Heydi Quemé - Cambios en Empleado y creación de tabla foto - Fecha: 14/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE `hotelsancarlos`.`empleado` 
ADD COLUMN `fotografia` VARCHAR(15) NULL AFTER `apellido`;

create table foto (
pkId varchar(15) primary key,
fotografia LONGBLOB
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE empleado ADD FOREIGN KEY (fotografia) REFERENCES foto(pkid);

INSERT INTO aplicacion VALUES ("2112","2",'Mantenimiento Jornada',"123","12334","1");
INSERT INTO aplicacion VALUES ("2113","2",'Mantenimiento Periodo',"123","12334","1");
INSERT INTO aplicacion VALUES ("2204","2",'Generacion Nomina',"123","12334","1");
INSERT INTO aplicacion VALUES ("22041","2",'Nomina',"123","12334","1");
INSERT INTO aplicacion VALUES ("2201","2",'Consulta Nomina',"123","12334","1");

INSERT INTO reporte VALUES ('7','Jornadas','C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteJornada.rpt','2112','1');
INSERT INTO reporte VALUES ('8','Periodos','C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReportePeriodo.rpt','2113','1');

UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaGenerarNomina.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaGenerarNomina.html' WHERE pkId='2204';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaNomina.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaNomina.html' WHERE pkId='22041';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaConsultaNomina.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaConsultaNomina.html' WHERE pkId='2201';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaNomina.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaJornada.html' WHERE pkId='2112';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaNomina.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaPeriodo.html' WHERE pkId='2113';

ALTER TABLE `hotelsancarlos`.`saldosporempleados` 
CHANGE COLUMN `saldo` `saldo` FLOAT NOT NULL ;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Cuarto sprint - Heydi Quemé - Tabla VacacionesEmpleado - Fecha: 17/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
create table Vacaciones_E(
vacaciones_e varchar(15) primary key,
periodo varchar(15),
estado varchar(1) not null,
foreign key (periodo) references periodo(pkid)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table Vacaciones_D(
vacaciones_e varchar(15) not null,
empleado varchar(15) not null,
diasdisponibles double not null,
diasgozados double not null,
estado varchar(1) not null,

foreign key (vacaciones_e) references vacaciones_e(vacaciones_e),
foreign key (empleado) references empleado(pkidempleado)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

#drop table candidato;
create table candidato(
pkid varchar(15) primary key,
fotografia varchar(15),
nombre varchar(50) not null,
apellido varchar(50) not null,
edad int not null,
dpi varchar(15),
telefono varchar(8) not null,
direccion varchar(50) not null,
correo varchar(50) not null,
estudios varchar(2000) not null,
experiencia varchar(2000) not null,
referencias varchar(500) not null,
estado varchar(1) not null,

foreign key (fotografia) references foto(pkid)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Cuarto sprint - Danny Saldaña- Tabla Poliza Fecha: 30/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

drop table poliza_Conf;
create table poliza_Conf(
pkPoliza_Conf varchar(15),
pago varchar(15),
gasto varchar(15),
pasivo varchar(15),
salario varchar(15)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `poliza_conf`(`pkPoliza_Conf`, `pago`, `gasto`, `pasivo`, `salario`) VALUES ('1', '1.1.1.2.001','6.1.1.1.006','2.1.3.1.003','6.1.1.1.001');

drop table poliza_p;
CREATE TABLE `poliza_p` (
  `fkidCuentaContable` varchar(15) DEFAULT NULL,
  `valor` varchar(15) DEFAULT NULL,
  `Periodo` date DEFAULT NULL,
  `estado` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Cuarto sprint - Heydi Quemé y Kevin Flores - Tabla Poliza Fecha: 30/05/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

ALTER TABLE `hotelsancarlos`.`empresa` ADD COLUMN `logo` VARCHAR(15) NULL AFTER `nombre`;
ALTER TABLE empresa ADD FOREIGN KEY (logo) REFERENCES foto(pkid);

-- --------------------------------------------------------------------------------------------------------------------------------------
-- Cuarto sprint - Heydi Quemé y Kevin Flores - Tabla Liquidación Fecha: 02/06/2022
-- --------------------------------------------------------------------------------------------------------------------------------------

create table liquidacion_e(
pkid varchar(15) primary key,
fecha date not null,
estado varchar(1) not null
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table liquidacion_d(
fkLiquidacion_e varchar(15) primary key not null,
fkIdEmpleado varchar(15) not null,
sueldo double not null,
ultimasVacaciones date not null,
salarioPromedio double not null,
bonificacionIncentivo double not null,
horasExtras double not null,
observaciones varchar(400) default null,
indemnizacionT double not null,
aguinaldoT double not null,
bono14T double not null,
bonificacionT double not null,
vacacionesT double not null,
comisionesT double not null,
horasExtraT double not null,
totalPercibido double not null,

foreign key (fkLiquidacion_e) references liquidacion_e(pkid),
foreign key (fkIdEmpleado) references empleado(pkIdEmpleado)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
-- --------------------------------------------------------------------------------------------------------------------------------------
-- Cuarto sprint - Heydi Quemé y Kevin Flores - Ayudas y reportes Fecha: 02/06/2022
-- --------------------------------------------------------------------------------------------------------------------------------------
INSERT INTO aplicacion VALUES ("2319","2",'Gestión de Vacaciones',"123","12334","1");
INSERT INTO aplicacion VALUES ("2320","2",'Asignación de Vacaciones',"123","12334","1");
INSERT INTO aplicacion VALUES ("2030","2",'Candidatos',"123","12334","1");
INSERT INTO aplicacion VALUES ("2315","2",'Liquidación',"123","12334","1");

UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaGestorVacaciones.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaGestorVacaciones.html' WHERE pkId='2319';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaAsignaVacaciones.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaAsignaVacaciones.html' WHERE pkId='2320';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaCandidatos.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaCandidatos.html' WHERE pkId='2030';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaLiquidacion.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\Ayudas-Pareja1\\AyudaLiquidacion.html' WHERE pkId='2315';

INSERT INTO reporte VALUES ('9','Candidatos','C:\\Users\\ZUZU\\Desktop\\ImplementarAyudas\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteCandidatos.rpt','2320','1');