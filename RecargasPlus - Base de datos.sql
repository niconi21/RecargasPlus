CREATE DATABASE RecargaPlus;
GO
USE RecargaPlus;
GO
/*
    Tablas
*/
CREATE TABLE Persona(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	apepat VARCHAR(30) NOT NULL,
	apemat VARCHAR(30) NOT NULL,
	usuario VARCHAR(30) NOT NULL,
	clave VARCHAR(30) NOT NULL,
	tipo TINYINT NOT NULL);
GO
CREATE TABLE Administrador(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	persona INT NOT NULL CONSTRAINT fk_administrador_es_persona REFERENCES Persona);
GO
CREATE TABLE Colaborador(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	saldo SMALLMONEY NOT NULL DEFAULT 0,
	persona INT NOT NULL CONSTRAINT fk_colaborador_es_persona REFERENCES Persona);
GO
CREATE TABLE Monto(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	monto SMALLMONEY NOT NULL DEFAULT 0);
GO
CREATE TABLE Compania(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	compania VARCHAR(50) NOT NULL);
GO
CREATE TABLE Bonificacion(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	bonificacion SMALLMONEY NOT NULL,
	monto INT NOT NULL CONSTRAINT fk_bonificacion_tiene_monto REFERENCES Monto,
	compania INT NOT NULL CONSTRAINT fk_bonificacion_tiene_compania REFERENCES Compania);
GO
CREATE TABLE Recarga(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	numero VARCHAR(12) NOT NULL,
	persona INT NOT NULL CONSTRAINT fk_recarga_hecha_persona REFERENCES persona,
	bonificacion INT NOT NULL CONSTRAINT fk_recarga_tiene_bonificacion REFERENCES Bonificacion,
	monto INT NOT NULL CONSTRAINT fk_recarga_tiene_monto REFERENCES Monto,
	compania INT NOT NULL CONSTRAINT fk_recarga_tiene_compania REFERENCES Compania);
GO
/*
    Monto por defecto
*/
INSERT INTO Compania VALUES ('Telcel');
INSERT INTO Compania VALUES ('Unefon');
INSERT INTO Compania VALUES ('AT&T');
INSERT INTO Compania VALUES ('Movistar');
/*
	Montos por defecto
*/
INSERT INTO Monto VALUES (10);
INSERT INTO Monto VALUES (20);
INSERT INTO Monto VALUES (30);
INSERT INTO Monto VALUES (50);
INSERT INTO Monto VALUES (100);
INSERT INTO Monto VALUES (150);
INSERT INTO Monto VALUES (200);
INSERT INTO Monto VALUES (300);
INSERT INTO Monto VALUES (500);
INSERT INTO Monto VALUES (1000);
/*
	Persona por defecto como administrador
*/
INSERT INTO Persona VALUES ('Nicolas', 'Moreno', 'Durán', 'niconi', 'niconi', 0);
/*
	Administrador por defecto
*/
INSERT INTO Administrador VALUES(0);
/*
	Persona por defecto como Colaboradores
*/
INSERT INTO Persona VALUES ('Francisco Enrique', 'Alberto', 'Cordova', 'francisco', 'francisco', 1);
INSERT INTO Persona VALUES ('Josue Jared', 'Camacho', 'Rolon', 'josue', 'josue', 1);
/*
	Administrador por defecto
*/
INSERT INTO Colaborador VALUES(1000, 1);
INSERT INTO Colaborador VALUES(1000, 2);

