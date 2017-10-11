create database bdventa;
use bdventa;

create table tcliente (
	dniCliente char(8) not null primary key,
	nombreCliente varchar(30) not null,
	apellidosCliente varchar(40) not null,
	direccionCliente varchar(45) not null,
	telefonoCliente varchar(9) not null,
	sexoCliente char(1) not null
);

create table tvendedor (
	dniVendedor char(8) not null primary key,
	nombreVendedor varchar(30) not null,
	apellidosVendedor varchar(40) not null,
	direccionVendedor varchar(45) not null,
	telefonoVendedor varchar(9) not null,
	turnoVendedor varchar(15) not null,
	estadoVendedor varchar(20) not null default 'habilitado'
);

create table tsucursal (
	idSucursal int not null primary key identity(1,1),
	nombreSucursal varchar(40) not null,
	direccionSucursal varchar(40) not null,
	telefonoSucursal varchar(9) not null
);

create table tcategoriaproducto (
	idCategoria int not null primary key identity(1,1),
	nombreCategoria varchar(50) not null,
	descripcionCategoria varchar(100) null
);

create table tproducto (
	idProducto int not null primary key identity(1,1),
	nombreProducto varchar(50) not null,
	precioProducto decimal(5,2) not null,
	stockProducto int not null,
	idCategoria int not null,
	foreign key (idCategoria) references tcategoriaproducto(idCategoria)
);

create table tcomprobante (
	idComprobante int not null primary key identity(1,1),
	fechaEmisionComprobante date not null,
	tipoComprobante varchar(50) not null default 'ticket'
);

create table tfactura (
	idFactura int not null primary key identity(1,1),
	razonSocialFactura varchar(100) not null,
	rucFactura char(11) not null,
	direccionFactura varchar(50) not null,
	fechaEmisionFactura date not null
);

create table tventa (
	idVenta int not null primary key identity(1,1),
	dniCliente char(8) not null,
	dniVendedor char(8) not null,
	idSucursal int not null,
	idComprobante int null,
	idFactura int null,
	fechaVenta date not null,
	costoVenta decimal(5,2) not null,
	igvVenta decimal(5,2) not null,
	montoTotal decimal(5,2) not null,
	foreign key (dniCliente) references tcliente(dniCliente),
	foreign key (dniVendedor) references tvendedor(dniVendedor),
	foreign key (idSucursal) references tsucursal(idSucursal),
	foreign key (idComprobante) references tcomprobante(idComprobante),
	foreign key (idFactura) references tfactura(idFactura)
);

create table tdetalleventa (
	idDetalleVenta int not null primary key identity(1,1),
	idVenta int not null,
	idProducto int not null,
	cantidad int not null,
	costo decimal(5,2) not null,
	foreign key (idVenta) references tventa(idVenta),
	foreign key (idProducto) references tproducto(idProducto)
);
