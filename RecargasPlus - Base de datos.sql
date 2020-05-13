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
	saldo INT NOT NULL DEFAULT 0,
	persona INT NOT NULL CONSTRAINT fk_colaborador_es_persona REFERENCES Persona);
GO
CREATE TABLE Monto(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	monto INT NOT NULL DEFAULT 0);
GO
CREATE TABLE Compania(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	compania VARCHAR(50) NOT NULL);
GO
CREATE TABLE Bonificacion(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	bonificacion TINYINT NOT NULL,
	monto INT NOT NULL CONSTRAINT fk_bonificacion_tiene_monto REFERENCES Monto,
	compania INT NOT NULL CONSTRAINT fk_bonificacion_tiene_compania REFERENCES Compania);
GO
CREATE TABLE Recarga(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	numero VARCHAR(12) NOT NULL,
	colaborador INT NOT NULL CONSTRAINT fk_recarga_hecha_colaborador REFERENCES Colaborador,
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


SELECT * FROM Compania;
SELECT * FROM Monto;
SELECT * FROM Persona;
SELECT * FROM Administrador;

use OUTDOOR;
DROP DATABASE RecargaPlus;