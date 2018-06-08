/** CONEXION BASE DE DATOS **/
USE GD1C2018
GO

--/** CREACION DE SCHEMA **/
--CREATE SCHEMA FAAE AUTHORIZATION gdHotel2018
--GO

/** CREACION DE TABLAS **/
CREATE TABLE FAAE.Historial_Reserva (
    hire_codigo numeric(10,0) PRIMARY KEY,
    hire_rese_codigo numeric(10),
	hire_descripcion nvarchar(50),
	hire_usua_doc_tipo nvarchar(10),
	hire_usua_doc_nro numeric(10)
)
CREATE TABLE FAAE.Cliente (
    clie_doc_tipo nvarchar(10) default 'pasaporte',
	clie_doc_nro numeric(10),
	clie_nombre nvarchar(20) not null,
	clie_apellido nvarchar(20) not null,
	clie_mail nvarchar(25) not null,
	clie_telefono nvarchar(16) default 00000000,
	clie_dire_calle nvarchar(25) not null,
	clie_dire_nro numeric(5),
	clie_dire_localidad nvarchar(16) default 'caba',
	clie_dire_pais nvarchar(16) default 'argentina',
	clie_nacionalidad nvarchar(16) not null,
	clie_habilitado bit default 1,
	clie_fecha_nacimiento smalldatetime not null,
	clie_piso numeric(2),
	clie_depto nvarchar(1)
	PRIMARY KEY (clie_doc_tipo, clie_doc_nro),
)
CREATE TABLE FAAE.Rol_Usuario (
    rous_clie_doc_tipo nvarchar(10),
	rous_clie_doc_nro numeric(10),
	rous_rol_nombre nvarchar(16)
	PRIMARY KEY (rous_clie_doc_tipo, rous_clie_doc_nro, rous_rol_nombre)
)
CREATE TABLE FAAE.Estadia (
    esta_rese_codigo numeric(10),
	esta_habi_nro numeric(10),
	esta_hote_codigo numeric(10),
	esta_clie_doc_tipo nvarchar(10),
	esta_clie_doc_nro numeric(10),
	esta_fecha_salida smalldatetime,
	PRIMARY KEY (esta_rese_codigo, esta_habi_nro, esta_hote_codigo,esta_clie_doc_tipo,esta_clie_doc_nro)
)
CREATE TABLE FAAE.Reserva_Habitacion (
    reha_rese_codigo numeric(10),
	reha_habi_nro numeric(10),
	reha_hote_codigo numeric(10),
	reha_precio numeric(10),
	PRIMARY KEY (reha_rese_codigo,reha_habi_nro, reha_hote_codigo)
)
CREATE TABLE FAAE.Reserva (
    rese_codigo numeric(10) IDENTITY(1,1) PRIMARY KEY,
	rese_fecha_realizacion smalldatetime,
	rese_fecha_desde smalldatetime,
	rese_fecha_hasta smalldatetime,
	rese_hote_codigo numeric(10),
	rese_regi_codigo nvarchar(16),
	rese_clie_doc_tipo nvarchar(10) default 'pasaporte',
	rese_clie_doc_nro numeric(10),
	rese_estado char(25) default 'Reserva Correcta'
)
CREATE TABLE FAAE.Rol (
    rol_nombre nvarchar(16) PRIMARY KEY,
	rol_habilitado bit default 1
)
CREATE TABLE FAAE.Item_Factura (
    item_fact_tipo nvarchar(10),
	item_fact_nro numeric(10),
	item_cons_codigo numeric(10),
	item_cantidad numeric(10),
	item_precio decimal(3,2),
	PRIMARY KEY (item_fact_tipo,item_fact_nro,item_cons_codigo)
)
CREATE TABLE FAAE.Habitacion (
    habi_nro numeric(10),
	habi_hote_codigo numeric(10),
	habi_piso numeric(2) not null,
	habi_vista_exterior char(1) not null,
	habi_tipo_codigo numeric(10) not null,
	habi_habilitada bit default 1,
	PRIMARY KEY (habi_nro,habi_hote_codigo)
)
CREATE TABLE FAAE.Tipo (
    tipo_codigo numeric(10) PRIMARY KEY,
	tipo_descripcion nvarchar(30),
	tipo_cant_personas numeric(1),
	tipo_porcentual decimal(4,2)
)
CREATE TABLE FAAE.Funcionalidad (
    func_rol_nombre nvarchar(16),
	func_funcion nvarchar(16),
	PRIMARY KEY (func_rol_nombre,func_funcion)
)
CREATE TABLE FAAE.Consumible (
    cons_codigo numeric(10) PRIMARY KEY,
	cons_descipcion nvarchar(25),
	cons_precio decimal(3,2)
)
CREATE TABLE FAAE.Factura (
    fact_tipo nvarchar(10) default 'A',
	fact_nro numeric(10),
	fact_fecha smalldatetime,
	fact_total decimal(6,2),
	fact_forma_pago nvarchar(10) default 'efectivo',
	fact_rese_codigo numeric(10),
	fact_habi_nro numeric(10),
	fact_hote_codigo numeric(10),
	PRIMARY KEY (fact_tipo,fact_nro),
	CHECK(fact_forma_pago IN('efectivo', 'credito', 'debito'))
)
CREATE TABLE FAAE.Hotel (
    hote_codigo numeric(10) IDENTITY(1,1) PRIMARY KEY,
	hote_nombre nvarchar(16) default 'Hotel Pepito',
	hote_mail nvarchar(25) default 'hotelPrincipal@hotel.com',
	hote_telefono nvarchar(16) default '00000000',
	hote_dire_calle nvarchar(25) not null,
	hote_dire_nro numeric(5) not null,
	hote_cant_estrellas numeric(1) not null,
	hote_ciudad nvarchar(16) not null,
	hote_pais nvarchar(16) default 'argentina',
	hote_fecha_creacion smalldatetime,
	hote_recarga_estrellas decimal(3,2) not null
)
CREATE TABLE FAAE.Regimen_Hotel (
    reho_hote_codigo numeric(10),
	reho_regi_codigo nvarchar(16),
	PRIMARY KEY (reho_hote_codigo,reho_regi_codigo)
)
CREATE TABLE FAAE.Regimen (
	regi_nombre nvarchar(16) PRIMARY KEY,
	regi_precio_base decimal(3,2),
	regi_activo bit default 1
)
CREATE TABLE FAAE.Motivo (
    moti_codigo nvarchar(10) PRIMARY KEY,
	moti_descripcion nvarchar(50)
)
CREATE TABLE FAAE.Historial_Inhabilitado (
    hiin_codigo nvarchar(10) PRIMARY KEY,
	hiin_hote_codigo numeric(10),
	hiin_moti_codigo nvarchar(10),
	hiin_fecha_inicio smalldatetime,
	hiin_fecha_fin smalldatetime
)
CREATE TABLE FAAE.Hotel_Usuario (
    hous_usua_doc_tipo nvarchar(10),
	hous_usua_doc_nro numeric(10),
	hous_hote_codigo numeric(10),
	PRIMARY KEY (hous_usua_doc_tipo,hous_usua_doc_nro,hous_hote_codigo)
)
CREATE TABLE FAAE.Usuario (
    usua_doc_tipo nvarchar(10),
	usua_doc_nro numeric(10),
	usua_username nvarchar(10) not null,
	usua_password nvarchar(10) not null,
	usua_nombre nvarchar(16) not null,
	usua_apellido nvarchar(16) not null,
	usua_mail nvarchar(25) not null,
	usua_telefono numeric(10) not null,
	usua_dire_calle nvarchar(25) not null,
	usua_dire_nro numeric(5) not null,
	usua_fecha_nacimiento smalldatetime not null,
	usua_cant_log_in_fallidos numeric(1) default 0,
	usua_hote_codigo_ultimo_log_in numeric(10),
	usua_habilitado bit default 1,
	PRIMARY KEY (usua_doc_tipo,usua_doc_nro)
)

ALTER TABLE FAAE.Historial_Reserva ADD CONSTRAINT Historial_Reserva_Reserva FOREIGN KEY (hire_rese_codigo) REFERENCES FAAE.Reserva(rese_codigo)
ALTER TABLE FAAE.Historial_Reserva ADD CONSTRAINT Historial_Reserva_Usuario FOREIGN KEY (hire_usua_doc_tipo , hire_usua_doc_nro) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro)

ALTER TABLE FAAE.Rol_Usuario ADD CONSTRAINT Rol_Usuario_Usuario FOREIGN KEY (rous_clie_doc_tipo, rous_clie_doc_nro) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro)
ALTER TABLE FAAE.Rol_Usuario ADD CONSTRAINT Rol_Usuario_Rol FOREIGN KEY (rous_rol_nombre) REFERENCES FAAE.Rol(rol_nombre)

ALTER TABLE FAAE.Estadia ADD CONSTRAINT Estadia_Reserva_Habitacion FOREIGN KEY (esta_rese_codigo, esta_habi_nro, esta_hote_codigo) REFERENCES FAAE.Reserva_Habitacion(reha_rese_codigo, reha_habi_nro, reha_hote_codigo)
ALTER TABLE FAAE.Estadia ADD CONSTRAINT Estadia_Cliente FOREIGN KEY (esta_clie_doc_tipo, esta_clie_doc_nro) REFERENCES FAAE.Cliente(clie_doc_tipo, clie_doc_nro)

ALTER TABLE FAAE.Reserva_Habitacion ADD CONSTRAINT Reserva_Habitacion_Reserva FOREIGN KEY (reha_rese_codigo) REFERENCES FAAE.Reserva(rese_codigo)
ALTER TABLE FAAE.Reserva_Habitacion ADD CONSTRAINT Reserva_Habitacion_Habitacion FOREIGN KEY (reha_habi_nro, reha_hote_codigo) REFERENCES FAAE.Habitacion(habi_nro, habi_hote_codigo)

ALTER TABLE FAAE.Reserva ADD CONSTRAINT Reserva_Regimen_Hotel FOREIGN KEY (rese_hote_codigo, rese_regi_codigo) REFERENCES FAAE.Regimen_Hotel(reho_hote_codigo, reho_regi_codigo)
ALTER TABLE FAAE.Reserva ADD CONSTRAINT Reserva_Cliente FOREIGN KEY (rese_clie_doc_tipo, rese_clie_doc_nro) REFERENCES FAAE.Cliente(clie_doc_tipo, clie_doc_nro)

ALTER TABLE FAAE.Item_Factura ADD CONSTRAINT Item_Factura_Factura FOREIGN KEY (item_fact_tipo, item_fact_nro) REFERENCES FAAE.Factura(fact_tipo, fact_nro)
ALTER TABLE FAAE.Item_Factura ADD CONSTRAINT Item_Factura_Consumible FOREIGN KEY (item_cons_codigo) REFERENCES FAAE.Consumible(cons_codigo)

ALTER TABLE FAAE.Habitacion ADD CONSTRAINT Habitacion_Hotel FOREIGN KEY (habi_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Habitacion ADD CONSTRAINT Habitacion_Tipo FOREIGN KEY (habi_tipo_codigo) REFERENCES FAAE.Tipo(tipo_codigo)

ALTER TABLE FAAE.Funcionalidad ADD CONSTRAINT Funcionalidad_Rol FOREIGN KEY (func_rol_nombre) REFERENCES FAAE.Rol(rol_nombre)

ALTER TABLE FAAE.Factura ADD CONSTRAINT Factura_Reserva_Habitacion FOREIGN KEY (fact_rese_codigo, fact_habi_nro, fact_hote_codigo) REFERENCES FAAE.Reserva_Habitacion(reha_rese_codigo, reha_habi_nro, reha_hote_codigo)

ALTER TABLE FAAE.Regimen_Hotel ADD CONSTRAINT Regimen_Hotel_Hotel FOREIGN KEY (reho_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Regimen_Hotel ADD CONSTRAINT Regimen_Hotel_Regimen FOREIGN KEY (reho_regi_codigo) REFERENCES FAAE.Regimen(regi_nombre)

ALTER TABLE FAAE.Historial_Inhabilitado ADD CONSTRAINT Historial_Inhabilitado_Hotel FOREIGN KEY (hiin_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Historial_Inhabilitado ADD CONSTRAINT Historial_Inhabilitado_Motivo FOREIGN KEY (hiin_moti_codigo) REFERENCES FAAE.Motivo(moti_codigo)

ALTER TABLE FAAE.Hotel_Usuario ADD CONSTRAINT Hotel_Usuario_Usuario FOREIGN KEY (hous_usua_doc_tipo, hous_usua_doc_nro) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro)
ALTER TABLE FAAE.Hotel_Usuario ADD CONSTRAINT Hotel_Usuario_Cliente FOREIGN KEY (hous_usua_doc_tipo, hous_usua_doc_nro) REFERENCES FAAE.Cliente(clie_doc_tipo, clie_doc_nro)
ALTER TABLE FAAE.Hotel_Usuario ADD CONSTRAINT Hotel_Usuario_Hotel FOREIGN KEY (hous_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Usuario ADD CONSTRAINT Usuario_Hotel FOREIGN KEY (usua_hote_codigo_ultimo_log_in) REFERENCES FAAE.Hotel(hote_codigo)


/** Migración **/
create PROCEDURE FAAE.sp_cargar_tablas
AS
BEGIN
	insert FAAE.Usuario(usua_doc_tipo,usua_doc_nro,usua_username,usua_password,usua_nombre,usua_apellido,usua_mail,usua_telefono,usua_dire_calle,usua_dire_nro,usua_fecha_nacimiento) 
		values	('pasaporte',0000000000,'admin','w23e','admin','admin','admin@admin.com',00000000,'admin',0000,getdate())

	insert FAAE.Rol (rol_nombre) values ('admin'), ('cliente'), ('recepcion')

	insert FAAE.Rol_Usuario values	('pasaporte',0000000000, 'admin')
	insert FAAE.Rol_Usuario values	('pasaporte',0000000000, 'recepcion')

	insert FAAE.Funcionalidad values ('admin', 'ABM rol') -- no se sabe bien a quien se le asigna
	insert FAAE.Funcionalidad values ('admin','ABM usuario')
	insert FAAE.Funcionalidad values ('recepcion','ABM cliente')
	insert FAAE.Funcionalidad values ('admin','ABM hotel')
	insert FAAE.Funcionalidad values ('admin','ABM habitacion')
	insert FAAE.Funcionalidad values ('recepcion','ABM reserva')
	insert FAAE.Funcionalidad values ('cliente','ABM reserva')

	insert FAAE.Cliente(clie_nombre, clie_apellido, clie_doc_nro, clie_mail, clie_dire_calle, clie_dire_nro, clie_nacionalidad, clie_piso, clie_depto, clie_fecha_nacimiento) 
		select distinct Cliente_Nombre,Cliente_Apellido,Cliente_Pasaporte_Nro,Cliente_Mail,Cliente_Dom_Calle, Cliente_Nro_Calle,Cliente_Nacionalidad,Cliente_Piso,Cliente_Depto,Cliente_Fecha_Nac 
		from gd_esquema.Maestra
	
	set identity_insert FAAE.Hotel on
	insert FAAE.Hotel(hote_dire_calle,hote_dire_nro,hote_cant_estrellas,hote_recarga_estrellas,hote_ciudad) 
		select distinct Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Hotel_Ciudad
		from gd_esquema.Maestra
	
	insert FAAE.Tipo(tipo_codigo,tipo_descripcion,tipo_cant_personas,tipo_porcentual) 
		select distinct Habitacion_Tipo_Codigo,Habitacion_Tipo_Descripcion,cantPersonas(Habitacion_Tipo_Descripcion),Habitacion_Tipo_Porcentual
		from gd_esquema.Maestra

	insert FAAE.Habitacion(habi_nro,habi_piso, habi_vista_exterior, habi_tipo_codigo, habi_hote_codigo) 
		select distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, Habitacion_Tipo_Codigo, obtenerHotelCodigo(.....)
		from gd_esquema.Maestra

	insert FAAE.Regimen(regi_nombre,regi_precio_base) 
		select distinct Regimen_Descripcion,Regimen_Precio
		from gd_esquema.Maestra

	insert FAAE.Regimen_Hotel(reho_hote_codigo,reho_regi_codigo) 
		select distinct obtenerHotelCodigo(...), Regimen_Descripcion
		from gd_esquema.Maestra

	set identity_insert FAAE.Reserva on
	insert FAAE.Reserva(rese_fecha_desde,rese_fecha_hasta,rese_hote_codigo,rese_regi_codigo,rese_clie_doc_nro) 
		select distinct Reserva_Fecha_Inicio, Reserva_Fecha_Inicio+Reserva_Cant_Noches, obtenerHotelCodigo(.....), Regimen_Descripcion, Cliente_Pasaporte_Nro
		from gd_esquema.Maestra



	insert FAAE.Factura(fact_nro) 
		select distinct Factura_Nro 
		from gd_esquema.Maestra 
		where Factura_Nro is not null
END
go

create TRIGGER FAAE.t_mail_unico 
   ON FAAE.Cliente  
   instead of INSERT
AS 
BEGIN
    if((select count(distinct clie_mail)
	    from inserted)
	   > 1)
	begin
		raiserror ('MISMO MAIL EN VARIOS USUARIOS', 1, 1)
	end
END
go

create TRIGGER FAAE.t_agregar_Hotel 
   ON FAAE.Hotel 
   AFTER INSERT
AS 
BEGIN
	insert FAAE.Hotel (hote_fecha_creacion) values (getdate())
END

create TRIGGER FAAE.t_agregar_Reserva
   ON FAAE.Hotel 
   AFTER INSERT
AS 
BEGIN
	insert FAAE.Reserva(rese_fecha_realizacion) values (getdate())
END


-- LOGIN

CREATE VIEW FAAE.RolXUsuario 
AS
SELECT usua_username username, rous_rol_nombre rol_nombre
	FROM faae.Usuario u join faae.Rol_Usuario ru 
		 ON (u.usua_doc_tipo = ru.rous_clie_doc_tipo AND u.usua_doc_nro = ru.rous_clie_doc_nro)


GO
CREATE PROCEDURE FAAE.login_fallido
@username VARCHAR(10)
AS
BEGIN
	
	DECLARE @nueva_cant_login_fallidos NUMERIC(1)
	SET @nueva_cant_login_fallidos = (SELECT usua_cant_log_in_fallidos 
										FROM FAAE.Usuario 
										WHERE usua_username = @username) + 1

	IF @nueva_cant_login_fallidos >= 3
		BEGIN
			UPDATE FAAE.Usuario 
				SET usua_cant_log_in_fallidos = @nueva_cant_login_fallidos, usua_habilitado = 0
				WHERE usua_username = @username
		END
	ELSE
		BEGIN
			UPDATE FAAE.Usuario 
				SET usua_cant_log_in_fallidos = @nueva_cant_login_fallidos
				WHERE usua_username = @username
		END

END

GO
CREATE PROCEDURE FAAE.limpiar_login_fallidos
@username VARCHAR(10)
AS
BEGIN
	UPDATE FAAE.Usuario 
		SET usua_cant_log_in_fallidos = 0
		WHERE usua_username = @username
END


-- ABM Hotel

GO
CREATE PROCEDURE FAAE.guardar_hotel
@hote_codigo numeric(10), @hote_nombre nvarchar(16), @hote_mail nvarchar(25), @hote_telefono nvarchar(16), @hote_dire_calle nvarchar(25), @hote_dire_nro numeric(5), 
@hote_cant_estrellas numeric(1), @hote_ciudad nvarchar(16), @hote_pais nvarchar(16), @hote_fecha_creacion smalldatetime, @hote_recarga_estrellas decimal(3,2)
AS
BEGIN
	IF( EXISTS(SELECT hote_codigo FROM FAAE.Hotel WHERE hote_codigo = @hote_codigo) )
		BEGIN
			UPDATE FAAE.Hotel 
				SET hote_nombre = @hote_nombre, 
					hote_mail = @hote_mail, 
					hote_telefono = @hote_telefono, 
					hote_dire_calle = @hote_dire_calle, 
					hote_dire_nro = @hote_dire_nro, 
					hote_cant_estrellas = @hote_cant_estrellas, 
					hote_ciudad = @hote_ciudad, 
					hote_pais = @hote_pais, 
					hote_fecha_creacion = @hote_fecha_creacion, 
					hote_recarga_estrellas = @hote_recarga_estrellas
				WHERE hote_codigo = @hote_codigo
		END
	ELSE
		BEGIN
			INSERT INTO FAAE.Hotel
			VALUES(@hote_nombre, @hote_mail, @hote_telefono, @hote_dire_calle, @hote_dire_nro, @hote_cant_estrellas, @hote_ciudad, @hote_pais, @hote_fecha_creacion, @hote_recarga_estrellas)
		END
END


GO
CREATE PROCEDURE FAAE.eliminar_hotel
@hote_codigo numeric(10)
AS
BEGIN
	DELETE FROM FAAE.Hotel WHERE hote_codigo = @hote_codigo
END

GO
CREATE PROCEDURE FAAE.inhabilitar_usuario
@username nvarchar(10)
AS
BEGIN
	UPDATE FAAE.Usuario 
		SET usua_habilitado = 0
		WHERE usua_username = @username
END

GO
CREATE PROCEDURE FAAE.inhabilitar_rol
@nombre nvarchar(16)
AS
BEGIN
	UPDATE FAAE.Rol 
		SET rol_habilitado = 0
		WHERE rol_nombre = @nombre
END

GO
CREATE PROCEDURE FAAE.guardar_rol
@rol_nombre nvarchar(16), @rol_habilitado bit
AS
BEGIN
	IF( NOT EXISTS(SELECT rol_nombre FROM FAAE.Rol WHERE rol_nombre = @rol_nombre) )
		BEGIN
			INSERT INTO FAAE.Rol
				VALUES(@rol_nombre, @rol_habilitado)
		END
	ELSE
		BEGIN
			UPDATE FAAE.Rol
				SET rol_habilitado = @rol_habilitado
				WHERE rol_nombre = @rol_nombre
		END
END

GO
CREATE PROCEDURE FAAE.asignar_funcionalidad_rol
@rol_nombre nvarchar(16), @funcionalidad nvarchar(16)
AS
BEGIN
	IF( NOT EXISTS(SELECT func_rol_nombre, func_funcion  FROM FAAE.Funcionalidad WHERE func_rol_nombre = @rol_nombre AND func_funcion = @funcionalidad) )
		BEGIN
			INSERT INTO FAAE.Funcionalidad
				VALUES(@rol_nombre, @funcionalidad)
		END
END

CREATE PROCEDURE FAAE.eliminar_funcionalidades_rol
@rol_nombre nvarchar(16)
AS
BEGIN
	DELETE FROM FAAE.Funcionalidad
		WHERE func_rol_nombre = @rol_nombre
END


--ABM Habitaciones
--alta
GO
CREATE PROCEDURE FAAE.guardar_habitacion
@habi_nro numeric(10), @habi_hote_codigo numeric(10), @habi_piso numeric(2,0), 
@habi_vista_exterior char(1), @habi_tipo_codigo numeric(10,0), @habi_habilitada bit
AS
BEGIN
	IF( EXISTS(SELECT habi_nro FROM FAAE.Habitacion WHERE habi_nro = @habi_nro) )
		BEGIN
			UPDATE FAAE.Habitacion 
				SET habi_nro = @habi_nro, 
					habi_hote_codigo = @habi_hote_codigo, 
					habi_piso = @habi_piso,
					habi_vista_exterior = @habi_vista_exterior,
					habi_tipo_codigo = @habi_tipo_codigo,
					habi_habilitada = @habi_habilitada
				WHERE habi_nro = @habi_nro AND habi_hote_codigo = @habi_hote_codigo
		END
	ELSE
		BEGIN
			INSERT INTO FAAE.Habitacion
			VALUES(@habi_nro, @habi_hote_codigo, @habi_piso, @habi_vista_exterior, @habi_tipo_codigo, @habi_habilitada)
		END
END

--Modificación
GO
CREATE PROCEDURE FAAE.modificar_habitacion
@habi_nro numeric(10), @habi_hote_codigo numeric(10), @habi_piso numeric(2,0), 
@habi_vista_exterior char(1), @habi_habilitada bit
AS
BEGIN
	IF( EXISTS(SELECT habi_nro FROM FAAE.Habitacion WHERE habi_nro = @habi_nro) )
		BEGIN
			UPDATE FAAE.Habitacion 
				SET habi_nro = @habi_nro, 
					habi_hote_codigo = @habi_hote_codigo, 
					habi_piso = @habi_piso,
					habi_vista_exterior = @habi_vista_exterior,
					habi_tipo_codigo = (SELECT habi_tipo_codigo FROM FAAE.Habitacion WHERE habi_nro = @habi_nro AND habi_hote_codigo = @habi_hote_codigo),
					habi_habilitada = @habi_habilitada
				WHERE habi_nro = @habi_nro AND habi_hote_codigo = @habi_hote_codigo
		END
	ELSE
		BEGIN
			INSERT INTO FAAE.Habitacion
			VALUES(@habi_nro, @habi_hote_codigo, @habi_piso, @habi_vista_exterior, 1001, @habi_habilitada)
		END
END

--Baja / Inhabilitar
GO
CREATE PROCEDURE FAAE.inhabilitar_habitacion
@habi_nro numeric(10), @habi_hote_codigo numeric(10)
AS
BEGIN
	UPDATE FAAE.Habitacion 
		SET habi_habilitada = 0
		WHERE habi_nro = @habi_nro AND habi_hote_codigo = @habi_hote_codigo
END