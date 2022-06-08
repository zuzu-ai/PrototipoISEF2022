use hotelsancarlos;
-- ------------------------------------------------------------------------------------------------------------
-- 										LMD Módulo de Hoteleria 
-- ------------------------------------------------------------------------------------------------------------

-- tabla tipoServicio
ALTER TABLE hotelsancarlos.tiposervicio
ADD COLUMN precio FLOAT NOT NULL AFTER nombre;

-- tabla servicioDetallado
ALTER TABLE hotelsancarlos.serviciodetallado 
ADD COLUMN subtotal FLOAT NOT NULL AFTER costo;

-- tabla salon
ALTER TABLE hotelsancarlos.salon 
	DROP FOREIGN KEY salon_ibfk_1;
	ALTER TABLE hotelsancarlos.salon 
	DROP COLUMN idCuenta,
	DROP INDEX idCuenta;
;

-- tabla tipocama
ALTER TABLE hotelsancarlos.tipocama 
DROP COLUMN idCuenta;

-- tabla mesa
ALTER TABLE hotelsancarlos.mesa
DROP COLUMN idCuenta;
