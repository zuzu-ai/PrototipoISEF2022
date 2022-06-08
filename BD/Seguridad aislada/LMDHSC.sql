-- ------------------------------
# LMD DATABASE hotelSanCarlos
-- ------------------------------
USE hotelSanCarlos;

-- ---------------------------------------------------
-- COMPONENTE SEGURIDAD
-- ---------------------------------------------------
-- alter de campo estado en empleado y no aceptar nulos
ALTER TABLE hotelsancarlos.empleado
ADD COLUMN estado VARCHAR(1) NOT NULL AFTER fkIdEmpresa,
CHANGE COLUMN nombre nombre VARCHAR(45) NOT NULL ,
CHANGE COLUMN apellido apellido VARCHAR(45) NOT NULL ,
CHANGE COLUMN fechaDeNacimiento fechaDeNacimiento VARCHAR(45) NOT NULL ,
CHANGE COLUMN sueldo sueldo FLOAT NOT NULL ,
CHANGE COLUMN correo correo VARCHAR(45) NOT NULL ,
CHANGE COLUMN direccion direccion VARCHAR(45) NOT NULL ,
CHANGE COLUMN contratado contratado VARCHAR(45) NOT NULL ,
CHANGE COLUMN añosDeExperiencia añosDeExperiencia INT NOT NULL ,
CHANGE COLUMN telefono telefono VARCHAR(10) NOT NULL ,
CHANGE COLUMN fechaContratacion fechaContratacion DATE NOT NULL ,
CHANGE COLUMN finDeContrato finDeContrato DATE NOT NULL ;

-- Insert con relacion al empleado
insert into puesto values("1","Gerente", "10","1", "1");
insert into empresa values("1", "65464-k","hotel san carlos","zona 6 de mixco", "65467654","1" );
insert into empleado values("1","María","Hernandez","1999-09-25","4000.00","cmaria@gmail.com", "zona 11","4", "5", "789654123", "2016-10-25", "2021-12-25","1","1","0");

#usuario: admin
#contraseña: 12345
INSERT INTO usuario(pkId,fkIdEmpleado, nombre, contraseña,estado) VALUES ("1", "1", "admin","LKAekHU9EtweB49HAaTRfg==","1");

-- Inserts con relacion a seguridad
insert into perfil values("1","Administrador","1");
insert into perfil values("2","Vendedor","1");

INSERT INTO modulo VALUES ('1','Seguridad','Módulo de Seguridad',1);
INSERT INTO modulo VALUES ('2','Recursos Humanos', 'Módulo de Recursos Humanos',1);

INSERT INTO aplicacion VALUES ("0001","1","Login Seguridad HSC",1,0001,0);
INSERT INTO aplicacion VALUES ("0002","1","Registrar Usuario",1,0002,0);
INSERT INTO aplicacion VALUES ("0003","1","Mantenimiento Aplicación",1,0003,0);
INSERT INTO aplicacion VALUES ("0004","1","Mantenimiento Perfil",1,0004,0);
INSERT INTO aplicacion VALUES ("0005","1","Asignación de Aplicación a Perfiles",1,0005,0);
INSERT INTO aplicacion VALUES ("0006","1","Asignación de Aplicación a Usuarios",1,0006,0);
INSERT INTO aplicacion VALUES ("0007","1","Asignación de Perfiles a Usuarios",1,0007,0);
INSERT INTO aplicacion VALUES ("0008","1","Asignación Permisos",1,0008,0);
INSERT INTO aplicacion VALUES ("0009","1","Recuperar Contraseña",1,0009,0);
INSERT INTO aplicacion VALUES ("0010","1","Cambiar Contraseña",1,0010,0);
INSERT INTO aplicacion VALUES ("0011","1","Consulta Bitácora",1,0011,0);
INSERT INTO aplicacion VALUES ("0012","1","Mantenimiento Módulo",1,0012,0);
INSERT INTO aplicacion VALUES ("0013","2",'Mantenimiento Departamentos',"123","12334","1");
INSERT INTO aplicacion VALUES ("0014","2",'Mantenimiento Tipo Falta',"123","12334","1");
INSERT INTO aplicacion VALUES ("0015","2",'Mantenimiento Sucursales',"123","12334","1");
INSERT INTO aplicacion VALUES ("0016","2",'Mantenimiento Puestos',"123","12334","1");
INSERT INTO aplicacion VALUES ("0017","2",'Mantenimiento Empresas',"123","12334","1");
INSERT INTO aplicacion VALUES ("0018","2",'Mantenimiento Empleados',"123","12334","1");

/*Alter con ajuste de tamaño para el campo de ip en bitácora*/ 
ALTER TABLE hotelsancarlos.bitacorausuario 
CHANGE COLUMN ip ip VARCHAR(100) NULL DEFAULT NULL ;

/*Alter con ajuste de tamanio para nombre de reporte*/
ALTER TABLE hotelsancarlos.reporte
CHANGE COLUMN nombre nombre VARCHAR(80) NOT NULL ;

/*Alter con ajuste de tamanio para la ruta del reporte*/
ALTER TABLE hotelsancarlos.reporte 
CHANGE COLUMN ruta ruta VARCHAR(180) NOT NULL;

INSERT INTO reporte VALUES ('1','Departamentos','C:\\Users\\ZUZU\\Desktop\\AyudasyReportes\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteDepartamentos.rpt','0013','1');
INSERT INTO reporte VALUES ('2','TipoFalta','C:\\Users\\ZUZU\\Desktop\\AyudasyReportes\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteTipoFalta.rpt','0014','1');
INSERT INTO reporte VALUES ('3','Sucursales','C:\\Users\\ZUZU\\Desktop\\AyudasyReportes\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteSucursales.rpt','0015','1');
INSERT INTO reporte VALUES ('4','Puestos','C:\\Users\\ZUZU\\Desktop\\AyudasyReportes\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReportePuestos.rpt','0016','1');
INSERT INTO reporte VALUES ('5','Empresas','C:\\Users\\ZUZU\\Desktop\\AyudasyReportes\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteEmpresas.rpt','0017','1');
INSERT INTO reporte VALUES ('6','Empleados','C:\\Users\\ZUZU\\Desktop\\AyudasyReportes\\Modulos\\ModuloRRHH\\CapaVistaRRHH\\ReporteEmpleados.rpt','0018','1');

UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaDepartamentos.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaDepartamentos.html' WHERE pkId='0013';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaTipoFalta.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaTipoFalta.html' WHERE pkId='0014';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaSucursales.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaSucursales.html' WHERE pkId='0015';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaPuestos.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaPuestos.html' WHERE pkId='0016';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaEmpresas.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaEmpresas.html' WHERE pkId='0017';
UPDATE aplicacion SET rutaChm='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaEmpleados.chm',rutaHtml='C:\\Users\\ZUZU\\Desktop\\Ayudas-Pareja1\\AyudaEmpleados.html' WHERE pkId='0018';


