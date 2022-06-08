create table bodega(
Pkid varchar(15) primary key,
nombre varchar(50) not null,
direccion varchar(50) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table producto(
Pkid varchar(15) primary key,
nombre varchar(50) not null,
cantidad varchar(50) not null,
precioc double not null,
preciov double not null,
bodega varchar(15) not null,
estado varchar(1) not null,

foreign key (bodega) references bodega (Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table cliente(
Pkid varchar(15) primary key,
nombre varchar(70) not null,
nit varchar(8) not null,
direccion varchar(50) not null,
telefono varchar(8) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table formapago(
Pkid varchar(15) primary key,
nombre varchar(50) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

create table facturacionEncabezado(
	Pkid varchar(15) primary key,
	Fkidcliente varchar(15) not null,
	Fechaemision date not null,
    formapago varchar(15) not null,
	Total float not null,
	estado varchar(1) not null,

	foreign key (Fkidcliente) references Cliente (Pkid),
    foreign key (formapago) references formapago (Pkid)
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