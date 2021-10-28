CREATE TABLE usuario(
	usuario_id			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	correo				NVARCHAR(256) NOT NULL,
	contrasenha			NVARCHAR(256) NOT NULL,
	intentos_fallidos	INT NOT NULL DEFAULT 0,
	ultimo_acceso		DATETIME,
	rol					NVARCHAR(15),
	estado				INT NOT NULL DEFAULT 1
);

CREATE TABLE reporte(
	reporte_id			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	fecha				DATETIME DEFAULT GETDATE(),
	total_horas			INT NOT NULL DEFAULT 0,
	estado				INT NOT NULL DEFAULT 1,
	usuario_id			INT FOREIGN KEY REFERENCES usuario(usuario_id)
);

CREATE TABLE actividad(
	actividad_id		INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	actividad			NVARCHAR(256) NOT NULL,
	horas				INT NOT NULL,
);

CREATE TABLE estado_reporte(
	estado_id			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	estado				NVARCHAR(256) NOT NULL
);

CREATE TABLE reporte_linea(
	linea_id			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	reporte_id			INT FOREIGN KEY REFERENCES reporte(reporte_id),
	actividad_id		INT FOREIGN KEY REFERENCES actividad(actividad_id),
	estado_id			INT FOREIGN KEY REFERENCES estado_reporte(estado_id)
);

INSERT INTO usuario(correo, contrasenha, ultimo_acceso, rol) VALUES('hmendozaq@gmail.com', '123456', getdate(), 'admin');

INSERT INTO actividad(actividad, horas) VALUES('Reporte de ventas', 2);
INSERT INTO actividad(actividad, horas) VALUES('Generación de PKs', 5);
INSERT INTO actividad(actividad, horas) VALUES('Visita al cliente', 5);

INSERT INTO estado_reporte(estado) VALUES('Ingresado');
INSERT INTO estado_reporte(estado) VALUES('Validado');
INSERT INTO estado_reporte(estado) VALUES('Autorizado');
INSERT INTO estado_reporte(estado) VALUES('Rechazado');

INSERT INTO reportE(usuario_id) VALUES(1);

INSERT INTO reporte_linea(reporte_id, actividad_id, estado_id) VALUES(1, 1, 1);
INSERT INTO reporte_linea(reporte_id, actividad_id, estado_id) VALUES(1, 1, 3);
INSERT INTO reporte_linea(reporte_id, actividad_id, estado_id) VALUES(1, 2, 4);

INSERT INTO reporte_linea(reporte_id, actividad_id, estado_id) VALUES(2, 3, 2);
INSERT INTO reporte_linea(reporte_id, actividad_id, estado_id) VALUES(2, 1, 4);
INSERT INTO reporte_linea(reporte_id, actividad_id, estado_id) VALUES(2, 2, 3);

SELECT * FROM reporte;
SELECT * FROM reporte_linea;

SELECT r.reporte_id, u.correo, r.fecha, r.total_horas, a.actividad, a.horas, e.estado FROM reporte r 
INNER JOIN reporte_linea l ON r.reporte_id = l.reporte_id
INNER JOIN actividad a ON l.actividad_id = a.actividad_id
INNER JOIN estado_reporte e ON l.estado_id = e.estado_id
INNER JOIN usuario u ON r.usuario_id = u.usuario_id;