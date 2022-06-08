-- ------------------------------------------------------------------------------------------------------------
-- 								MÓDULO COMPRAS
-- ------------------------------------------------------------------------------------------------------------
use hotelSanCarlos;

create table ordencompra(
  idOrdenCompra varchar(15),
  idProveedor	varchar(15) not null,
  total			float not null,
  fecha 		date,
  descripcion	varchar(100),
  primary key (idOrdenCompra),
  foreign key (idProveedor) references proveedor (idProveedor)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table movimiento (
  idMovimiento  varchar(15),
  idOrdenCompra varchar(15) not null,
  total			float,
  abonado		float,
  stsMov		varchar(1),
  primary key	(idMovimiento),
  foreign key   (idOrdenCompra) references ordencompra (idOrdenCompra)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE facturaEncabezado (
  idFacturaEncabezado varchar(15),
  idProveedor varchar(15) not NULL,
  fecha date,
  descripcion varchar(200),
  total float not null,
  idOrdenCompra varchar(15) not null,
  primary key(idFacturaEncabezado),
  foreign key (idProveedor) references proveedor(idProveedor),  
  foreign key (idOrdenCompra) references ordencompra (idOrdenCompra)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table facturaDetalle(
	idFacturaDetalle varchar(15), 
	idFacturaEncabezado varchar(15),
	idProducto			varchar(15),
	monto float,
	concepto varchar(65),
	primary key(idFacturaDetalle),
    foreign key (idFacturaEncabezado) references facturaEncabezado (idFacturaEncabezado),
    foreign key (idProducto) references producto (pkid)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE trasladoProducto(
	pkId VARCHAR(15) PRIMARY KEY,
	fkidbodegaO VARCHAR(15) NOT NULL, 
	fkidbodegaD VARCHAR(15) NOT NULL,
	fecha_salid date,
	fecha_ingreso date,
    fkidproducto varchar(15) NOT NULL,
	cantidad INT,
    foreign key (fkidbodegaO) references bodega(pkid),
    foreign key (fkidbodegaD) references bodega(pkid),
    foreign key (fkidproducto) references producto(pkid)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

