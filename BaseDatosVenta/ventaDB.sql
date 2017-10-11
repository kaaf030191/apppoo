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
	costoVenta decimal(5,2) not null default 0,
	igvVenta decimal(5,2) not null default 0,
	montoTotal decimal(5,2) not null default 0,
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
	costo decimal(5,2) not null default 0,
	foreign key (idVenta) references tventa(idVenta),
	foreign key (idProducto) references tproducto(idProducto)
);

/**/

insert into tcliente values ('12345678', 'Cliente1', 'Aperllidos1', 'Direcion1', '123456789', 'M');
insert into tcliente values ('22332233', 'Cliente2', 'Aperllidos2', 'Direcion2', '123456739', 'M');
insert into tcliente values ('56757666', 'Cliente3', 'Aperllidos3', 'Direcion3', '123456729', 'F');

insert into tvendedor values ('77777777', 'Vendedor1', 'Aperllidos1', 'Direcion1', '123456789', 'Mañana', 'habilitado');
insert into tvendedor values ('11111111', 'Vendedor2', 'Aperllidos2', 'Direcion1', '123456789', 'Tarde', 'habilitado');

insert into tsucursal (nombreSucursal, direccionSucursal, telefonoSucursal) values('sucursalAbancay', 'Av lima', '222222222');
insert into tsucursal (nombreSucursal, direccionSucursal, telefonoSucursal) values('sucursalTamburco', 'Tamburco', '111111111');

insert into tcategoriaproducto(nombreCategoria, descripcionCategoria) values ('aseo', 'limpieza del hogar');
insert into tcategoriaproducto(nombreCategoria, descripcionCategoria) values ('golosinas', 'golosinas etc');

insert into tproducto (nombreProducto, precioProducto, stockProducto, idCategoria) values ('Detergente Bolivar', 2.3 , 10, 1 );
insert into tproducto (nombreProducto, precioProducto, stockProducto, idCategoria) values ('Jabon Marsella', 1.5 , 10, 1 );
insert into tproducto (nombreProducto, precioProducto, stockProducto, idCategoria) values ('Limpia todo POET', 2 , 10, 1 );
insert into tproducto (nombreProducto, precioProducto, stockProducto, idCategoria) values ('Galletas Oreo', 0.6 , 10, 1 );
insert into tproducto (nombreProducto, precioProducto, stockProducto, idCategoria) values ('Galleta Rellenitas', 0.5 , 10, 1 );
insert into tproducto (nombreProducto, precioProducto, stockProducto, idCategoria) values ('Papitas Lays', 1 , 10, 1 );


insert into tcomprobante (fechaEmisionComprobante, tipoComprobante) values (SYSDATETIME(), 'ticket');
insert into tcomprobante (fechaEmisionComprobante, tipoComprobante) values (SYSDATETIME(), 'boleta');

insert into tfactura(razonSocialFactura, rucFactura, direccionFactura, fechaEmisionFactura) values (
	'Empresa TAmbo', '12345678901', 'Av Junin', SYSDATETIME() );


insert into tventa(dniCliente, dniVendedor, idSucursal, idComprobante, idFactura, fechaVenta, costoVenta, igvVenta, montoTotal) 
	values ('12345678', '77777777', 1, 1, null, SYSDATETIME(), 4.2 , 0.8 , 5);
insert into tventa(dniCliente, dniVendedor, idSucursal, idComprobante, idFactura, fechaVenta, costoVenta, igvVenta, montoTotal) 
	values ('22332233', '77777777', 1, 2, null, SYSDATETIME(), 4.7, 0.8, 5.5);
insert into tventa(dniCliente, dniVendedor, idSucursal, idComprobante, idFactura, fechaVenta, costoVenta, igvVenta, montoTotal) 
	values ('56757666', '11111111', 2, null, 1, SYSDATETIME(), 22.7, 4 , 26.7 );

/**/
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (1,4,2,1.2);
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (1,5,2,1);
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (1,6,2,2);

/**/
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (2,4,2,1.2);
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (2,2,1,1.5);
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (2,6,2,2);

/**/
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (3,1,4, 9.2);
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (3,2,5,7.5);
insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (3,3,3,6);



/*trigger*/
IF OBJECT_ID ('insertarDetalleVentaProducto', 'TR') IS NOT NULL
BEGIN
   DROP TRIGGER insertarDetalleVentaProducto;
END;
-- Cremamos un Trigger sobre la tabla expedientes
CREATE TRIGGER insertarDetalleVentaProducto
ON tdetalleventa
FOR INSERT
AS
BEGIN
	SET NOCOUNT ON;

	declare @stock int;
	select @stock = stockProducto from tproducto join inserted on inserted.idProducto = tproducto.idProducto
	
	if (@stock>=(select cantidad from inserted))
		begin
			UPDATE tproducto SET 
			stockProducto = stockProducto - inserted.cantidad
			from tproducto join inserted
			on tproducto.idProducto = inserted.idProducto;

			UPDATE inserted SET 
				costo = inserted.cantidad * tproducto.precioProducto
			from inserted join tproducto
			on tproducto.idProducto = inserted.idProducto;

		end
	else
	  begin
		raiserror ('Hay menos productos en stock de los solicitados para la venta', 16, 1)
		rollback transaction
	  end
END

CREATE TRIGGER eliminarDetalleVentaProducto
ON tdetalleventa
FOR DELETE
AS
BEGIN
	SET NOCOUNT ON;
		
	UPDATE tproducto SET 
	stockProducto = stockProducto + deleted.cantidad
	from tproducto join deleted
	on tproducto.idProducto = deleted.idProducto
END


insert into tdetalleventa (idVenta, idProducto, cantidad, costo) values (1,6,9,2);


/**/
