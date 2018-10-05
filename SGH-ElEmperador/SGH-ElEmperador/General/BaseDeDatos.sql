/*
*	SQLite 3
*	Base de datos para el Sistema de gestión del hotel El Emperador
*	SGH-ElEmperador
*   LUANDAPE Software
* 	Nombre del archivo: DB-SGH-ElEmperador.db
*	Versión: 20181003	
*/

/*
	habitaciones
	Guarda la información referente a las habitaciones
*/
DROP TABLE IF EXISTS habitaciones;
CREATE TABLE habitaciones(
	ID INTEGER PRIMARY KEY AUTOINCREMENT, --ID Unico
	NUMERO INTEGER, --Número de habitación
	TIPO TEXT, --Categoría de la habitación, S=Simple, D=Doble, U=suite
	ESTADO TEXT --Estado actual L=Libre, O=Ocupado, R=Reservada
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

/*
*	Datos base
*/
/* Usuarios */
INSERT INTO usuarios(NOMBRE,APELLIDOS,TIPO,USUARIO, PASSWORD) 
VALUES('Administrador','Administrador','A','admin','123'), 
('Operador','Operador','O','oper','123');

/* Habitaciones */
INSERT INTO habitaciones (NUMERO,TIPO,ESTADO) 
VALUES(101,'S', 'L'), (102,'S', 'L'), (103,'S', 'L'), (104,'S', 'L'), (105,'S', 'L')
(106,'S', 'L'), (107,'S', 'L'), (108,'S', 'L'), (109,'S', 'L'), (110,'S', 'L'),
(150,'D', 'L'), (151,'D', 'L'), (152,'D', 'L'), (153,'D', 'L'), (154,'D', 'L'),
(155,'D', 'L'), (156,'D', 'L'), (157,'D', 'L'), (158,'D', 'L'), (159,'D', 'L'), (160,'D', 'L'),
(170,'U', 'L'), (171,'U', 'L'), (172,'U', 'L'), (173,'U', 'L'), (174,'U', 'L');

