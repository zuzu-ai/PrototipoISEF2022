-- ------------------------------------------------------------------------------------------------------------
-- 										LMD Módulo de Ventas 
-- ------------------------------------------------------------------------------------------------------------
use hotelsancarlos;

-- ALTER EN COTIZACIONENCABEZADO
-- AÑADIR CAMPO FKIDTIPOCAMBIO DESPUES DEL CAMPO TOTAL
ALTER TABLE `CotizacionEncabezado` 
ADD COLUMN `fkidtipocambio` VARCHAR(15) NOT NULL AFTER `Total`;
;

ALTER TABLE `CotizacionEncabezado` 
ADD FOREIGN KEY (`fkidtipocambio`)
  REFERENCES `TipoCambio` (`idtipoc`);

-- AÑADIR CAMPO ESTADO
ALTER TABLE `CotizacionEncabezado` 
ADD COLUMN `estado` VARCHAR(1) NOT NULL AFTER `fkidtipocambio`;
;

-- ALTER EN COTIZACIONDETALLE
-- AÑADIR CAMPO CANTIDAD DESPUES DEL CAMPO FKENCABEZADO
ALTER TABLE `CotizacionDetalle` 
ADD COLUMN `cantidad` int NOT NULL AFTER `fkencabezado`;
  
  -- AÑADIR CAMPO FKSERVICIO DESPUES DEL CAMPO FKIDPRODUCTO
ALTER TABLE `CotizacionDetalle` 
ADD COLUMN `fkservicio` varchar(15) AFTER `fkidproducto`;
;
ALTER TABLE `CotizacionDetalle` 
ADD FOREIGN KEY (`fkservicio`)
  REFERENCES `TipoCambio` (`idtipoc`);
  
  -- AÑADIR CAMPO FKIDTIPOCAMBIO DESPUES DEL CAMPO TOTAL
ALTER TABLE `CotizacionDetalle` 
ADD COLUMN `subtotal` float not null AFTER `fkservicio`;


-- ALTER EN FACTURACIONENCABEZADO
-- AÑADIR CAMPO FKIDRESERVACION DESPUES DEL CAMPO FKIDCOTIZACION
ALTER TABLE `FacturacionEncabezado` 
ADD COLUMN `fkidreservacion` varchar(15) AFTER `fkidcotizacion`;
;
ALTER TABLE `FacturacionEncabezado` 
ADD FOREIGN KEY (`fkidreservacion`)
  REFERENCES `Reservacion` (`idReservacion`);

-- AÑADIR CAMPO FKIDTIPOCAMBIO DESPUES DEL CAMPO IMPUESTOTURISMO
  ALTER TABLE `FacturacionEncabezado` 
ADD COLUMN `fkidtipocambio` varchar(15) NOT NULL AFTER `impuestoturismo`;
;
ALTER TABLE `FacturacionEncabezado` 
ADD FOREIGN KEY (`fkidtipocambio`)
  REFERENCES `tipocambio` (`idtipoc`);
  
 -- AÑADIR CAMPO FKIDFORMAPAGO DESPUES DEL CAMPO FKIDTIPOCAMBIO
  ALTER TABLE `FacturacionEncabezado` 
ADD COLUMN `fkidformapago` varchar(15) NOT NULL AFTER `fkidtipocambio`;
;
ALTER TABLE `FacturacionEncabezado` 
ADD FOREIGN KEY (`fkidformapago`)
  REFERENCES `formapago` (`pkid`); 

-- ELIMINAR CAMPO ESTATUS
  ALTER TABLE `FacturacionEncabezado`
DROP COLUMN `estatus`;

-- AÑADIR CAMPO ESTADO DESPUES DEL CAMPO FKIDFORMAPAGO
  ALTER TABLE `FacturacionEncabezado` 
ADD COLUMN `estado` varchar(1) NOT NULL AFTER `fkidformapago`;

-- ALTER EN FACTURACIONDETALLE
-- AÑADIR CAMPO CANTIDAD DESPUES DEL CAMPO FKENCABEZADO
ALTER TABLE `FacturacionDetalle` 
ADD COLUMN `cantidad` int NOT NULL AFTER `fkencabezado`;
  
  -- AÑADIR CAMPO FKSERVICIO DESPUES DEL CAMPO FKIDPRODUCTO
ALTER TABLE `FacturacionDetalle` 
ADD COLUMN `fkservicio` varchar(15) AFTER `fkidproducto`;
;
ALTER TABLE `FacturacionDetalle` 
ADD FOREIGN KEY (`fkservicio`)
  REFERENCES `TipoCambio` (`idtipoc`);


-- ELIMINAR FKENCABEZADO
ALTER TABLE `facturaciondetalle` 
DROP FOREIGN KEY `facturaciondetalle_ibfk_1`;
ALTER TABLE `facturaciondetalle` 
DROP COLUMN `Fkencabezado`,
DROP INDEX `Fkencabezado` ;
;

-- AÑADIR FKENCABEZADO
 ALTER TABLE `FacturacionDetalle` 
ADD COLUMN `fkencabezado` varchar(15) NOT NULL AFTER `Pkid`;
;

ALTER TABLE `hotelsancarlos`.`facturaciondetalle` 
ADD INDEX `facturaciondetalle_ibfk_1_idx` (`fkencabezado` ASC) VISIBLE;
;
ALTER TABLE `hotelsancarlos`.`facturaciondetalle` 
ADD CONSTRAINT `facturaciondetalle_ibfk_1`
  FOREIGN KEY (`fkencabezado`)
  REFERENCES `hotelsancarlos`.`facturacionencabezado` (`Pkid`);

-- Comision
ALTER TABLE `hotelsancarlos`.`comisionasignadadetalle` 
ADD UNIQUE INDEX `Fkidfactura_UNIQUE` (`Fkidfactura` ASC) VISIBLE;
;

-- ------------------------------------------------------------------------------------------------------------
-- 										Insert Módulo Ventas
-- ------------------------------------------------------------------------------------------------------------
insert into modulo values("3001","Ventas","Modulo dedicado al área de Ventas","A");

insert into aplicacion values ("3002","3001","Cotizacion",1,"","");
insert into aplicacion values ("3003","3001","Facturacion","1","","");
insert into aplicacion values ("3004","3001","Pedidos","1","","");

insert into usuarioaplicacion values ("1","3002","1","1","1","1","1");
insert into usuarioaplicacion values ("1","3003","1","1","1","1","1");
insert into usuarioaplicacion values ("1","3004","1","1","1","1","1");
