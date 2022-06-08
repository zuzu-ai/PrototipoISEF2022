use hotelsancarlos;
-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO VENTAS Y CUENTAS POR COBRAR
-- ------------------------------------------------------------------------------------------------------------
create table clienteEmpresa(
	fkidcliente varchar(15) not null,
	fkidempresa varchar(15) not null,

	foreign key (fkidcliente) references cliente(pkid),
	foreign key (fkidempresa) references empresa(idempresa)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table fraccionamiento(
	Pkid varchar(15) primary key,
	Nombre varchar(30) not null,
	Cuotas int not null,
	Estatus varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table tipoDocumento(
	Pkid varchar(15) primary key,
	Nombre varchar(30) not null,
	Estatus varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table caja(
	Pkid varchar(15) primary key,
	Nombre varchar(30) not null,
	Estatus varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table mora(
	Pkid varchar(15) primary key,
	Nombre varchar(30) not null,
	Cantidad float not null,
	Estatus varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table cuentasporCobrar(
	Pkid varchar(15) primary key,
	Fkcliente varchar(15) not null,
	Fechaemision date not null,
	Fechavencimiento date not null,
	Fkfraccionamiento varchar(15) not null,
	Fktipodocumento varchar(15) not null,
	Fkformapago varchar(15),
	Fkcaja varchar(15),
	Fkmoneda varchar(15),
	Fkbanco varchar(15),
	Fkcuentabancaria varchar(15),
	Fkmora varchar(15) not null,
	Totalmonto float not null,
	Faltantemonto float not null,
	Abono float not null,
	Estatus varchar(1),

	foreign key (Fkcliente) references Cliente (Pkid),
	foreign key (Fkfraccionamiento) references Fraccionamiento (Pkid),
	foreign key (Fktipodocumento) references TipoDocumento (Pkid),
	foreign key (Fkformapago) references FormaPago (PKid),
	foreign key (Fkcaja) references Caja (Pkid),
	foreign key (Fkmoneda) references moneda(Pkid),
	foreign key (Fkbanco) references banco (IdBanco),
	foreign key (Fkmora) references Mora (Pkid),
	foreign key (Fkcuentabancaria) references CuentasBancos (IdCuenta)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table cotizacionEncabezado(
	Pkid varchar(15) primary key,
	Fkidcliente varchar(15) not null,
	Fechaemision date not null,
	Fechavencimiento date not null,
	Total float not null,

	foreign key (Fkidcliente) references Cliente (Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table cotizacionDetalle(
	Pkid varchar(15) primary key,
	Fkencabezado varchar(15) not null,
	Fkidproducto varchar(15),

	foreign key (Fkencabezado) references cotizacionEncabezado (Pkid),
	foreign key (Fkidproducto) references producto (pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table facturacionEncabezado(
	Pkid varchar(15) primary key,
	Fkidcliente varchar(15) not null,
	Fkidempleado varchar(15) not null, #SUJETO A CAMBIOS
	Fechaemision date not null,
	Fkidcotizacion varchar(15),
	impuestoTurismo float,
	Total float not null,
	estatus varchar(1) not null,

	foreign key (Fkidcliente) references Cliente (Pkid),
	foreign key (Fkidempleado) references Empleado (pkidempleado),
	foreign key (Fkidcotizacion) references CotizacionEncabezado (Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table facturacionDetalle(
	Pkid varchar(15) primary key,
	Fkencabezado varchar(15) not null,
	Fkidproducto varchar(15),

	subtotal float not null,
	iva float not null,
	
	foreign key (Fkencabezado) references facturacionEncabezado (Pkid),
	foreign key (Fkidproducto) references Producto (Pkid)

)engine=InnoDB DEFAULT CHARSET=latin1;


create table comision(
	Pkid varchar(15) primary key,
	nombre varchar(30) not null,
	porcentaje float not null,
	estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table comisionAsignadaEncabezado(
	Pkid varchar(15) primary key,
	Fkidempleado varchar(15),
	Comisionesmes float not null,
	FechaComisiones date,
	
	foreign key (Fkidempleado) references Empleado(pkidempleado) 
)engine=InnoDB DEFAULT CHARSET=latin1;

create table comisionAsignadaDetalle(
	Pkid varchar(15) primary key,
	FkidEncabezado varchar(15) not null,
	Fkidfactura varchar(15) not null,
	FkidComision varchar(15) not null,
	Montofactura float not null,
	Cantidadcomision float not null,

	foreign key (FkidEncabezado) references ComisionAsignadaEncabezado(Pkid),
	foreign key (Fkidfactura) references FacturacionEncabezado(Pkid),
	foreign key (FkidComision) references Comision(Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table pedidoEncabezado(
	pkid varchar(15) primary key,
	fkidCliente varchar(15),
	fkidBodega varchar(15) not null,
	fechapedido datetime not null,
	fechamaxentrega datetime not null,
	estado varchar(1) not null,
	foreign key (fkidBodega) references Bodega(pkid),
	foreign key (fkidCliente) references Cliente(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;


create table pedidoDetalle(
	pkid varchar(15) primary key,
	fkidpedido varchar(15) not null,
	cantidad int not null,
	fkidproducto varchar(15) not null,
	foreign key (fkidpedido) references PedidoEncabezado(pkid),
	foreign key (fkidproducto) references Producto(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table movimientoMotivo(
	Pkid varchar(15) primary key,
	Movimiento varchar(15),    
	Estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table movimientoInventario(
	Pkid varchar(15) primary key,                #id del movimiento
	Fkiddocumento varchar(15) not null,              #Se guarda el id del documento donde se realizó la operacion
	Cantidad int not null,                    #Cantidad de inventario que se movió
	Fkidmotivo varchar(15) not null,              #id del  motivo del movimiento
	FechaMovimiento date not null,
	foreign key (Fkidmotivo) references MovimientoMotivo(Pkid),
	foreign key (Fkiddocumento) references FacturacionEncabezado(Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
