/** CONEXION BASE DE DATOS **/
USE [GD1C2018]
GO

/** CREACION DE SCHEMA **/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FAAE')
BEGIN
    EXEC ('CREATE SCHEMA FAAE AUTHORIZATION gd')
END
GO

/** VALIDACION DE TABLAS **/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Historial_Reserva'))
    DROP TABLE FAAE.Historial_Reserva	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Cliente'))
    DROP TABLE FAAE.Cliente
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Estadia'))
    DROP TABLE FAAE.Estadia
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Reserva_Habitacion'))
    DROP TABLE FAAE.Reserva_Habitacion
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Reserva'))
    DROP TABLE FAAE.Reserva
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Rol_Usuario'))
    DROP TABLE FAAE.Rol_Usuario
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Rol'))
    DROP TABLE FAAE.Rol
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Item_Factura'))
    DROP TABLE FAAE.Item_Factura
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Habitacion'))
    DROP TABLE FAAE.Habitacion
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Tipo'))
    DROP TABLE FAAE.Tipo
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Funcionalidad'))
    DROP TABLE FAAE.Funcionalidad
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Consumible'))
    DROP TABLE FAAE.Consumible
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Factura'))
    DROP TABLE FAAE.Factura
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Hotel'))
    DROP TABLE FAAE.Hotel
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Regimen_Hotel'))
    DROP TABLE FAAE.Regimen_Hotel
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Regimen'))
    DROP TABLE FAAE.Regimen
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Motivo'))
    DROP TABLE FAAE.Motivo
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Historial_Inhabilitado'))
    DROP TABLE FAAE.Historial_Inhabilitado
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Hotel_Usuario'))
    DROP TABLE FAAE.Hotel_Usuario
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FAAE.Usuario'))
    DROP TABLE FAAE.Usuario

/** CREACION DE TABLAS **/
CREATE TABLE [FAAE].[Historial_Reserva] (
    [hire_codigo] [nvarchar](10) PRIMARY KEY,
    [hire_rese_codigo] [nvarchar](10),
	[hire_descripcion] [nvarchar](50),
	[hire_usua_doc_tipo] [nvarchar](10),
	[hire_usua_doc_nro] [numeric](10)
)
CREATE TABLE [FAAE].[Cliente] (
    [clie_doc_tipo] [nvarchar](10) default 'DNI - Documento Nacional de Identidad',
	[clie_doc_nro] [numeric](10),
	[clie_nombre] [nvarchar](10),
	[clie_apellido] [nvarchar](10),
	[clie_mail] [nvarchar](25) NOT NULL,
	[clie_telefono] [numeric](10),
	[clie_dire_calle] [nvarchar](10),
	[clie_localidad] [nvarchar](10),
	[clie_nacionalidad] [nvarchar](10),
	[clie_habilitado] [bit],
	PRIMARY KEY (clie_doc_tipo, clie_doc_nro),
    CONSTRAINT [tipo_doc] CHECK (clie_doc_tipo IN ('DNI - Documento Nacional de Identidad', 'LC - Libreta Civica', 'LE - Libreta de Enrolamiento', 'Pasaporte'))
)
CREATE TABLE [FAAE].[Rol_Usuario] (
    [rous_clie_doc_tipo] [nvarchar](10),
	[rous_clie_doc_nro] [numeric](10),
	[rous_rol_nombre] [nvarchar](10)
	PRIMARY KEY (rous_clie_doc_tipo, rous_clie_doc_nro, rous_rol_nombre)
)
CREATE TABLE [FAAE].[Estadia] (
    [esta_rese_codigo] [nvarchar](10),
	[esta_habi_nro] [numeric](10),
	[esta_hote_codigo] [nvarchar](10),
	[esta_clie_doc_tipo] [nvarchar](10),
	[esta_clie_doc_nro] [numeric](10),
	[esta_fecha_salida] [smalldatetime],
	PRIMARY KEY (esta_rese_codigo, esta_habi_nro, esta_hote_codigo,esta_clie_doc_tipo,esta_clie_doc_nro)
)
CREATE TABLE [FAAE].[Reserva_Habitacion] (
    [reha_rese_codigo] [nvarchar](10),
	[reha_habi_nro] [numeric](10),
	[reha_hote_codigo] [nvarchar](10),
	[reha_precio] [numeric](10),
	PRIMARY KEY (reha_rese_codigo,reha_habi_nro, reha_hote_codigo)
)
CREATE TABLE [FAAE].[Reserva] (
    [rese_codigo] [nvarchar](10) PRIMARY KEY,
	[rese_fecha_realizacion] [smalldatetime],
	[rese_fecha_desde] [smalldatetime],
	[rese_fecha_hasta] [smalldatetime],
	[rese_hote_codigo] [nvarchar](10),
	[rese_regi_codigo] [nvarchar](10),
	[rese_clie_doc_tipo] [nvarchar](10),
	[rese_clie_doc_nro] [numeric](10),
	[rese_estado] [bit]
)
CREATE TABLE [FAAE].[Rol] (
    [rol_nombre] [nvarchar](10) PRIMARY KEY,
	[rol_habilitado] [bit]
)
CREATE TABLE [FAAE].[Item_Factura] (
    [item_fact_tipo] [nvarchar](10),
	[item_fact_nro] [numeric](10),
	[item_cons_codigo] [nvarchar](10),
	[item_cantidad] [numeric](10),
	[item_precio] [decimal](3,2),
	PRIMARY KEY (item_fact_tipo,item_fact_nro,item_cons_codigo)
)
CREATE TABLE [FAAE].[Habitacion] (
    [habi_nro] [numeric](10),
	[habi_hote_codigo] [nvarchar](10),
	[habi_piso] [numeric](2),
	[habi_vista_exterior] [bit],
	[habi_tipo_codigo] [nvarchar](10),
	[habi_habilitada] [bit],
	PRIMARY KEY (habi_nro,habi_hote_codigo)
)
CREATE TABLE [FAAE].[Tipo] (
    [tipo_codigo] [nvarchar](10) PRIMARY KEY,
	[tipo_descripcion] [nvarchar](50),
	[tipo_cant_personas] [numeric](1)
)
CREATE TABLE [FAAE].[Funcionalidad] (
    [func_rol_nombre] [nvarchar](10),
	[func_funcion] [nvarchar](10),
	PRIMARY KEY (func_rol_nombre,func_funcion)
)
CREATE TABLE [FAAE].[Consumible] (
    [cons_codigo] [nvarchar](10) PRIMARY KEY,
	[cons_descipcion] [nvarchar](50),
	[cons_precio] [decimal](3,2)
)
CREATE TABLE [FAAE].[Factura] (
    [fact_tipo] [nvarchar](10),
	[fact_nro] [numeric](10),
	[fact_fecha] [smalldatetime],
	[fact_total] [decimal](4,2),
	[fact_forma_pago] [nvarchar](10),
	[fact_rese_codigo] [nvarchar](10),
	[fact_habi_nro] [numeric](10),
	[fact_hote_codigo] [nvarchar](10),
	PRIMARY KEY (fact_tipo,fact_nro),
	CONSTRAINT [forma_pago] CHECK (fact_forma_pago IN ('Efectivo', 'Crédito', 'Débito', 'Sin especificar'))
)
CREATE TABLE [FAAE].[Hotel] (
    [hote_codigo] [nvarchar](10) PRIMARY KEY,
	[hote_nombre] [nvarchar](10),
	[hote_mail] [nvarchar](25),
	[hote_telefono] [numeric](10),
	[hote_dire_calle] [nvarchar](10),
	[hote_dire_nro] [numeric](10),
	[hote_cant_estrellas] [numeric](1),
	[hote_ciudad] [nvarchar](10),
	[hote_pais] [nvarchar](10),
	[hote_fecha_creacion] [smalldatetime],
	[hote_recarga_estrellas] [decimal](2,2)
)
CREATE TABLE [FAAE].[Regimen_Hotel] (
    [reho_hote_codigo] [nvarchar](10),
	[reho_regi_codigo] [nvarchar](10),
	PRIMARY KEY (reho_hote_codigo,reho_regi_codigo)
)
CREATE TABLE [FAAE].[Regimen] (
    [regi_codigo] [nvarchar](10) PRIMARY KEY,
	[regi_nombre] [nvarchar](10),
	[regi_precio_base] [decimal](3,2),
	[regi_activo] [bit]
)
CREATE TABLE [FAAE].[Motivo] (
    [moti_codigo] [nvarchar](10) PRIMARY KEY,
	[moti_descripcion] [nvarchar](50)
)
CREATE TABLE [FAAE].[Historial_Inhabilitado] (
    [hiin_codigo] [nvarchar](10) PRIMARY KEY,
	[hiin_hote_codigo] [nvarchar](10),
	[hiin_moti_codigo] [nvarchar](10),
	[hiin_fecha_inicio] [smalldatetime],
	[hiin_fecha_fin] [smalldatetime]
)
CREATE TABLE [FAAE].[Hotel_Usuario] (
    [hous_usua_doc_tipo] [nvarchar](10),
	[hous_usua_doc_nro] [numeric](10),
	[hous_hote_codigo] [nvarchar](10),
	PRIMARY KEY (hous_usua_doc_tipo,hous_usua_doc_nro,hous_hote_codigo)
)
CREATE TABLE [FAAE].[Usuario] (
    [usua_doc_tipo] [nvarchar](10),
	[usua_doc_nro] [numeric](10),
	[usua_username] [nvarchar](10),
	[usua_password] [nvarchar](10),
	[usua_nombre] [nvarchar](10),
	[usua_apellido] [nvarchar](10),
	[usua_mail] [nvarchar](25),
	[usua_telefono] [numeric](10),
	[usua_dire_calle] [nvarchar](10),
	[usua_dire_nro] [numeric](5),
	[usua_fecha_nacimiento] [smalldatetime],
	[usua_cant_log_in_fallidos] [numeric](1),
	[usua_hote_codigo_ultimo_log_in] [nvarchar](10),
	PRIMARY KEY (usua_doc_tipo,usua_doc_nro)
)

ALTER TABLE [FAAE].[Historial_Reserva] ADD CONSTRAINT Historial_Reserva_Reserva FOREIGN KEY (hire_rese_codigo) REFERENCES [FAAE].[Reserva](rese_codigo)
ALTER TABLE [FAAE].[Historial_Reserva] ADD CONSTRAINT Historial_Reserva_Usuario FOREIGN KEY (hire_usua_doc_tipo) REFERENCES [FAAE].[Usuarios](usua_doc_tipo)
ALTER TABLE [FAAE].[Historial_Reserva] ADD CONSTRAINT Historial_Reserva_Usuario FOREIGN KEY (hire_usua_doc_nro) REFERENCES [FAAE].[Usuarios](usua_doc_nro)

ALTER TABLE [FAAE].[Rol_Usuario] ADD CONSTRAINT Rol_Usuario_Usuario FOREIGN KEY (rous_clie_doc_tipo) REFERENCES [FAAE].[Usuario](usua_doc_tipo)
ALTER TABLE [FAAE].[Rol_Usuario] ADD CONSTRAINT Rol_Usuario_Usuario FOREIGN KEY (rous_clie_doc_nro) REFERENCES [FAAE].[Usuario](usua_doc_nro)
ALTER TABLE [FAAE].[Rol_Usuario] ADD CONSTRAINT Rol_Usuario_Ciente FOREIGN KEY (rous_clie_doc_tipo) REFERENCES [FAAE].[Cliente](clie_doc_tipo)
ALTER TABLE [FAAE].[Rol_Usuario] ADD CONSTRAINT Rol_Usuario_Ciente FOREIGN KEY (rous_clie_doc_nro) REFERENCES [FAAE].[Cliente](clie_doc_nro)
ALTER TABLE [FAAE].[Rol_Usuario] ADD CONSTRAINT Rol_Usuario_Rol FOREIGN KEY (rous_rol_nombre) REFERENCES [FAAE].[Rol](rol_nombre)

ALTER TABLE [FAAE].[Estadia] ADD CONSTRAINT Estadia_Reserva_Habitacion FOREIGN KEY (esta_rese_codigo) REFERENCES [FAAE].[Reserva_Habitacion](reha_rese_codigo)
ALTER TABLE [FAAE].[Estadia] ADD CONSTRAINT Estadia_Reserva_Habitacion FOREIGN KEY (esta_habi_nro) REFERENCES [FAAE].[Reserva_Habitacion](reha_habi_nro)
ALTER TABLE [FAAE].[Estadia] ADD CONSTRAINT Estadia_Reserva_Habitacion FOREIGN KEY (esta_habi_nro) REFERENCES [FAAE].[Reserva_Habitacion](reha_hote_codigo)
ALTER TABLE [FAAE].[Estadia] ADD CONSTRAINT Estadia_Cliente FOREIGN KEY (esta_clie_doc_tipo) REFERENCES [FAAE].[Cliente](clie_doc_tipo)
ALTER TABLE [FAAE].[Estadia] ADD CONSTRAINT Estadia_Cliente FOREIGN KEY (esta_clie_doc_nro) REFERENCES [FAAE].[Cliente](clie_doc_nro)

ALTER TABLE [FAAE].[Reserva_Habitacion] ADD CONSTRAINT Reserva_Habitacion_Reserva FOREIGN KEY (reha_rese_codigo) REFERENCES [FAAE].[Reserva](rese_codigo)
ALTER TABLE [FAAE].[Reserva_Habitacion] ADD CONSTRAINT Reserva_Habitacion_Habitacion FOREIGN KEY (reha_habi_nro) REFERENCES [FAAE].[Habitacion](habi_nro)
ALTER TABLE [FAAE].[Reserva_Habitacion] ADD CONSTRAINT Reserva_Habitacion_Habitacion FOREIGN KEY (reha_hote_codigo) REFERENCES [FAAE].[Habitacion](habi_hote_codigo)

ALTER TABLE [FAAE].[Reserva] ADD CONSTRAINT Reserva_Regimen_Hotel FOREIGN KEY (rese_hote_codigo) REFERENCES [FAAE].[Regimen_Hotel](reho_hote_codigo)
ALTER TABLE [FAAE].[Reserva] ADD CONSTRAINT Reserva_Regimen_Hotel FOREIGN KEY (rese_regi_codigo) REFERENCES [FAAE].[Regimen_Hotel](reho_codigo)
ALTER TABLE [FAAE].[Reserva] ADD CONSTRAINT Reserva_Cliente FOREIGN KEY (rese_clie_doc_tipo) REFERENCES [FAAE].[Cliente](clie_doc_tipo)
ALTER TABLE [FAAE].[Reserva] ADD CONSTRAINT Reserva_Cliente FOREIGN KEY (rese_clie_doc_nro) REFERENCES [FAAE].[Cliente](clie_doc_nro)

ALTER TABLE [FAAE].[Item_Factura] ADD CONSTRAINT Item_Factura_Factura FOREIGN KEY (item_fact_tipo) REFERENCES [FAAE].[Factura](fact_tipo)
ALTER TABLE [FAAE].[Item_Factura] ADD CONSTRAINT Item_Factura_Factura FOREIGN KEY (item_fact_nro) REFERENCES [FAAE].[Factura](fact_nro)
ALTER TABLE [FAAE].[Item_Factura] ADD CONSTRAINT Item_Factura_Consumible FOREIGN KEY (item_cons_codigo) REFERENCES [FAAE].[Consumible](cons_codigo)

ALTER TABLE [FAAE].[Habitacion] ADD CONSTRAINT Habitacion_Hotel FOREIGN KEY (habi_hote_codigo) REFERENCES [FAAE].[Hotel](hote_codigo)
ALTER TABLE [FAAE].[Habitacion] ADD CONSTRAINT Habitacion_Tipo FOREIGN KEY (habi_tipo_codigo) REFERENCES [FAAE].[Tipo](tipo_codigo)

ALTER TABLE [FAAE].[Funcionalidad] ADD CONSTRAINT Funcionalidad_Rol FOREIGN KEY (func_rol_nombre) REFERENCES [FAAE].[Rol](rol_nombre)

ALTER TABLE [FAAE].[Factura] ADD CONSTRAINT Factura_Reserva_Habitacion FOREIGN KEY (fact_rese_codigo) REFERENCES [FAAE].[Reserva_Habitacion](reha_rese_codigo)
ALTER TABLE [FAAE].[Factura] ADD CONSTRAINT Factura_Reserva_Habitacion FOREIGN KEY (fact_habi_nro) REFERENCES [FAAE].[Reserva_Habitacion](reha_habi_nro)
ALTER TABLE [FAAE].[Factura] ADD CONSTRAINT Factura_Reserva_Habitacion FOREIGN KEY (fact_hote_codigo) REFERENCES [FAAE].[Reserva_Habitacion](reha_hote_codigo)

ALTER TABLE [FAAE].[Regimen_Hotel] ADD CONSTRAINT Regimen_Hotel_Hotel FOREIGN KEY (reho_hote_codigo) REFERENCES [FAAE].[Hotel](hote_codigo)
ALTER TABLE [FAAE].[Regimen_Hotel] ADD CONSTRAINT Regimen_Hotel_Regimen FOREIGN KEY (reho_regi_codigo) REFERENCES [FAAE].[Regimen](regi_codigo)

ALTER TABLE [FAAE].[Historial_Inhabilitado] ADD CONSTRAINT Historial_Inhabilitado_Hotel FOREIGN KEY (hiin_hote_codigo) REFERENCES [FAAE].[Hotel](hote_codigo)
ALTER TABLE [FAAE].[Historial_Inhabilitado] ADD CONSTRAINT Historial_Inhabilitado_Motivo FOREIGN KEY (hiin_moti_codigo) REFERENCES [FAAE].[Motivo](moti_codigo)

ALTER TABLE [FAAE].[Hotel_Usuario] ADD CONSTRAINT Hotel_Usuario_Usuario FOREIGN KEY (hous_usua_doc_tipo) REFERENCES [FAAE].[Usuario](usua_doc_tipo)
ALTER TABLE [FAAE].[Hotel_Usuario] ADD CONSTRAINT Hotel_Usuario_Usuario FOREIGN KEY (hous_usua_doc_nro) REFERENCES [FAAE].[Usuario](usua_doc_nro)
ALTER TABLE [FAAE].[Hotel_Usuario] ADD CONSTRAINT Hotel_Usuario_Cliente FOREIGN KEY (hous_usua_doc_tipo) REFERENCES [FAAE].[Cliente](clie_doc_tipo)
ALTER TABLE [FAAE].[Hotel_Usuario] ADD CONSTRAINT Hotel_Usuario_Cliente FOREIGN KEY (hous_usua_doc_nro) REFERENCES [FAAE].[Cliente](clie_doc_nro)
ALTER TABLE [FAAE].[Hotel_Usuario] ADD CONSTRAINT Hotel_Usuario_Hotel FOREIGN KEY (hous_hote_codigo) REFERENCES [FAAE].[Hotel](hote_codigo)

ALTER TABLE [FAAE].[Usuario] ADD CONSTRAINT Usuario_Hotel FOREIGN KEY (usua_hote_codigo_ultimo_log_in) REFERENCES [FAAE].[Hotel](hote_codigo)

/** Migración **/
--Insert Hotel
INSERT INTO FAAE.Hotel(hote_ciudad, hote_dire_calle)
    SELECT DISTINCT Publicacion_Rubro_Descripcion 
    FROM gd_esquema.Maestra 
    WHERE Publicacion_Rubro_Descripcion IS NOT NULL
GO

CREATE TABLE [FAAE].[Hotel] (
    [hote_codigo] [nvarchar](10) PRIMARY KEY,
	[hote_nombre] [nvarchar](10),
	[hote_mail] [nvarchar](25),
	[hote_telefono] [numeric](10),
	[hote_dire_calle] [nvarchar](10),
	[hote_dire_nro] [numeric](10),
	[hote_cant_estrellas] [numeric](1),
	[hote_ciudad] [nvarchar](10),
	[hote_pais] [nvarchar](10),
	[hote_fecha_creacion] [smalldatetime],
	[hote_recarga_estrellas] [decimal](2,2)
)