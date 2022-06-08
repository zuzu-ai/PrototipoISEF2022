use hotelSanCarlos;
-- ------------------------------------------------------------------------------------------------------------
-- 								MÓDULO BANCOS
-- ------------------------------------------------------------------------------------------------------------
Create Table banco (
	IdBanco varchar(15) NOT NULL,
	PRIMARY KEY (IdBanco),
	nombreBanco varchar(20) NOT NULL,
	direccionBanco varchar(25) NOT NULL
)engine=InnoDB DEFAULT CHARSET=latin1;

Create Table cuentasBancos (
	IdCuenta varchar(15) NOT NULL,
	PRIMARY KEY (IdCuenta),
	FkidBanco varchar(15) not null,
	nombreCuentaB varchar(20) NOT NULL,
	tipoCuentaB varchar(25) NOT NULL,
	direccionCuentaB varchar(25) NOT NULL,
	EstadoCuentaB varchar(1) not null,
	foreign key (FkidBanco) references Banco(IdBanco)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table moneda(
	Pkid varchar(15) primary key NOT NULL,
	nombreMoneda varchar(30) not null,
	estadoMoneda varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

create table tipoCambio (
	idTipoc varchar(15) primary key NOT NULL,
	fkidMoneda varchar(15) not null,
	fechaTipoC date not null,
	cambioTipoC float not null,

	foreign key (fkidMoneda) references Moneda(Pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;