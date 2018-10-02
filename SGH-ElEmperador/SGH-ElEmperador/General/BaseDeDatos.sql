/*
*	SQLite 3
*	Base de datos para el Sistema de gestión del hotel El Emperador
*	SGH-ElEmperador
*   LUANDAPE Software
* 	Nombre del archivo: DB-SGH-ElEmperador.db
*	Versión: 20181002	
*/

/*
	tipo_habitacion
	Guarda la información referente a las categorías de habitacion existentes
*/
DROP TABLE IF EXISTS tipo_habitacion;
CREATE TABLE tipo_habitacion(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	TIPO TEXT, --Tipo de habitación S=Simple, D=Doble, U=Suite
	PRECIO REAL, --Precio de renta
	NUMPERSONAS TEXT --Numero de personas que caben en la habitación MINNUM-MAXNUM
);

/*
	habitaciones
	Guarda la información referente a las habitaciones
*/
DROP TABLE IF EXISTS habitaciones;
CREATE TABLE habitaciones(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	NUMERO INTEGER, --Número de habitación
	IDTIPO INTEGER, --Categoría de la habitación
	ESTADO TEXT, --Estado actual L=Libre, O=Ocupado, R=Reservada
	FOREIGN KEY(IDTIPO) REFERENCES tipo_habitacion(ID)
);

/*
	usuarios
	Guarda la información referente a los usuarios
*/
DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	NOMBRE TEXT, --Nombre
	APELLIDOS TEXT, --Apellidos
	TIPO TEXT, --Tipo de usuario O=Operador, A=Administrador
	USUARIO TEXT, --Nombre de usuario de acceso
	PASSWORD TEXT --Contraseña de acceso
);

/*
	hospedajes
	Guarda la información referente a los hospedajes
*/
DROP TABLE IF EXISTS hospedajes;
CREATE TABLE hospedajes(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	IDHABITACION INTEGER, --ID De habitación a ocupar
	DIAS INTEGER, --Dias de instancia
	FECHAENTRADA TEXT, --Fecha de entrada
	ESTADO TEXT, --Estado, A=Activo, C=Concluido, X=Cancelado
	SUBTOTAL REAL, --Total sin IVA
	TOTAL REAL, --Total
	FECHASALIDA TEXT, --Fecha de salida
	IDOPERADORENTRADA INTEGER, --ID del usuario que dio entrada
	IDOPERADORSALIDA INTEGER, --ID del usuario que dio salida
	FOREIGN KEY(IDHABITACION) REFERENCES habitaciones(ID),
	FOREIGN KEY(IDOPERADORENTRADA) REFERENCES usuarios(ID),
	FOREIGN KEY(IDOPERADORSALIDA) REFERENCES usuarios(ID)
);

/*
	huespedes
	Guarda la información referente a las personas hospedadas
*/
DROP TABLE IF EXISTS huespedes;
CREATE TABLE huespedes(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	IDHOSPEDAJE INTEGER, --Hospedaje del huesped
	NOMBRE TEXT, --Nombre
	APELLIDOS TEXT, --Apellidos
	DOCIDENTIDAD TEXT, --Documento de identificación
	FECHANACIMIENTO TEXT, --Fecha de nacimiento
	FOREIGN KEY (IDHOSPEDAJE) REFERENCES hospedajes(ID)
);

/*
	facturas
	Guarda la información referente a las facturas
*/
DROP TABLE IF EXISTS facturas;
CREATE TABLE facturas(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	NOFACTURA INTEGER, --Número de factura
	IDHOSPEDAJE INTEGER, --Hospedaje base de la factura
	FOREIGN KEY (IDHOSPEDAJE) REFERENCES hospedajes(ID)
);
