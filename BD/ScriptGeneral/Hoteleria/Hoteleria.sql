use hotelsancarlos;
-- ------------------------------------------------------------------------------------------------------------
-- 							MÓDULO DE HOTELERÍA
-- ------------------------------------------------------------------------------------------------------------
-- Reservaciones
create table tipoCama(
	idTipoCama varchar(15) primary key not null,
    nombre varchar(35) not null,
    idCuenta varchar(15) not null,
	estatus varchar(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table tipoHabitacion(
	idTipoHabitacion varchar(15) primary key not null, 
    nombre varchar(35) not null,
    estatus varchar(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table habitacion(
	idHabitacion varchar(15) primary key not null,
    idTipoHabitacion varchar(15) not null,
    idTipoCama varchar(15) not null,
    precio float not null,
    estatus varchar(1) not null,
    /*Llaves foráneas*/
    foreign key (idTipoHabitacion) references tipoHabitacion(idTipoHabitacion),
    foreign key (idTipoCama) references tipoCama(idTipoCama)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- servicios
create table tipoServicio(    /*Lavanderia, de cuarto, atracciones y otros*/
	idTipoServicio varchar(15) primary key not null,
    nombre varchar(35) not null, 
    estatus varchar(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table reservacion(
	idReservacion varchar(15) primary key not null,
    idCliente varchar(15) not null,
    idHabitacion varchar(15) not null,
    cantidadHabitacion int not null,
    fechaInicio date not null,
    fechaFin date not null,
    estatus varchar(1) not null,             -- checkin, checkout, activo, inactivo
    
    /*Llaves foráneas*/
    foreign key (idCliente) references cliente (pkid),
    foreign key (idHabitacion) references habitacion (idHabitacion)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


create table servicioEncabezado(
	idServicioE varchar(15) not null,
    idReservacion varchar(15) not null,
    idImpuesto varchar(15) not null,          -- cambiar por ID que tomaremos de contabilidad (tabla de impuesto)
    descripcion varchar(80) not null,
    total float not null,
    estatus varchar(1) not null, 
    
    primary key (idServicioE, idReservacion),
    
    /*Llaves foráneas*/
    foreign key (idReservacion) references reservacion (idReservacion),
    foreign key (idImpuesto) references impuesto (idImpuesto)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table servicioDetallado(
	idServicioE varchar(15) not null,
    idOrdenServicio int auto_increment not null,
	idReservacion varchar(15) not null,
    idTipoServicio varchar(15) not null,
    fechaAdquisicion date not null,
    cantidad int not null,
    costo float not null, 
    
    primary key(idOrdenServicio, idServicioE, idReservacion, idTipoServicio),
    
	/*Llaves foráneas*/
	foreign key (idServicioE) references servicioEncabezado(idServicioE),
    foreign key (idReservacion) references reservacion (idReservacion),
    foreign key (idTipoServicio) references tipoServicio(idTipoServicio)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Restaurante
create table salon(
	idSalon varchar(15) primary key not null,
    nombre varchar(30) not null,
    idCuenta varchar(15) not null,
    estatus varchar(1) not null,
    
    /*relacion mantenimiento y cuenta*/
    foreign key (idCuenta) references cuenta(idCuenta)

) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Reservacion de eventos*/
create table actividadReservacion(
	idActividad varchar(15) primary key not null,
    nombre varchar(80) not null,
    idCliente varchar(15) not null,  -- clientes que no son huéspedes, tienen derecho a realizar pedidos  -- en el cbx los clientes que no son huespedes
    idSalon varchar(15) not null,
    costoActividad float not null,   -- Costo o precio de la actividad (total)
    descripcion text not null,
    estatus varchar(1) not null, 
    
    /*Llaves foráneas*/
    foreign key (idCliente) references cliente(pkid),
    foreign key (idSalon) references salon(idSalon)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table mesa(
	idMesa varchar(15) primary key not null,
    nombre varchar(30) not null,
    idSalon varchar(15) not null,
    idCuenta varchar(15) not null,
    estado varchar(1) not null,
    estadoDisponibilidad varchar(1) not null,
    
    /*Llaves foráneas*/
    foreign key (idSalon) references salon(idSalon)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*
create table ingrediente( -- van a estar con el inventario 
	idIngrediente varchar(15) primary key not null,
    nombre varchar(35) not null,
    estado varchar(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
*/

create table recetaEncabezado(
	idRecetaE varchar(15) primary key not null,
    nombre varchar(80) not null,
    preparacion text not null,
    estado varchar(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table recetaDetalle(
	idRecetaE varchar(15) not null,
    idproducto varchar(15) not null,
    descripcion text not null, 				-- descripcion con respecto al prodcuto (ingrediente)
    
	primary key(idRecetaE, idproducto),
    
    foreign key (idRecetaE) references recetaEncabezado(idRecetaE),
    foreign key (idProducto) references producto(pkid)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table pedidoEncabezadoHoteleria(
	idPedidoE varchar(15) not null,
    idActividad varchar(15) not null,
    cantidad int not null,
    fecha date not null,
    total float not null,
    
    primary key (idPedidoE, idActividad),
    
    /*Llaves foráneas*/
    foreign key (idActividad) references actividadReservacion(idActividad)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table pedidoDetalleHoteleria(
	idPedidoE varchar(15) not null,
    idOrdenPedido int auto_increment not null,
    idActividad varchar(15) not null,
    idRecetaE varchar(15) not null,
    
    primary key (idOrdenPedido, idPedidoE, idActividad, idRecetaE),
    
    foreign key (idPedidoE) references pedidoEncabezadoHoteleria (idPedidoE),
    foreign key (idActividad) references actividadReservacion(idActividad),
    foreign key (idRecetaE) references recetaEncabezado (idRecetaE)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
