
--DROP LOGIN [usrthalassa];
CREATE DATABASE LabGatePayNavieras;
GO
USE [master]
GO
CREATE LOGIN [usrthalassa] WITH PASSWORD = N'123456', 
	DEFAULT_DATABASE=[LabGatePayNavieras], 
	CHECK_EXPIRATION=OFF, 
	CHECK_POLICY=ON;
GO
USE [LabGatePayNavieras]
GO
CREATE USER [usrthalassa] FOR LOGIN [usrthalassa]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrthalassa]
GO


--vamos a conectarnos
DROP TABLE SolicitudPagoBancoChile;
DROP TABLE Historial;
DROP TABLE Factura;
DROP TABLE GateIn;
DROP TABLE SolicitudPago;
DROP TABLE Naviera;
DROP TABLE Cliente;
DROP TABLE Usuario;
 -- Tabla Usuario
 CREATE TABLE Usuario (
	Id INT PRIMARY KEY IDENTITY(1,1),
	NombreUsuario VARCHAR(50) NOT NULL,
	Contrasena VARCHAR(100) NOT NULL,
	Rol VARCHAR(20) NOT NULL --administrador o operador--
 );
 GO

 --Tabla Cliente
 CREATE TABLE Cliente (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(100) NOT NULL,
	Telefono VARCHAR(100) NOT NULL,
	Email VARCHAR(100),
	TipoCliente VARCHAR(30) NOT NULL,
 );
 GO

 --Tabla Naviera
 CREATE TABLE Naviera (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50) NOT NULL,
	URLPortal VARCHAR(200)
 );
 GO

 CREATE TABLE SolicitudPago (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdCliente INT NOT NULL,
    IdNaviera INT NOT NULL,
    NumeroBL VARCHAR(50) NOT NULL,
    Contenedor VARCHAR(50),
    MontoEstimado DECIMAL(10, 2) NOT NULL,
    TipoCambio DECIMAL(10,2) NOT NULL,
    Comision DECIMAL(10,2) NOT NULL,
    TotalEnBolivianos AS (MontoEstimado * TipoCambio + Comision) PERSISTED,
    EstadoG VARCHAR(20) NOT NULL DEFAULT 'Pendiente', -- Pendiente, Cancelado, Rechazado
    FechaSolicitud DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_SolicitudPago_Cliente FOREIGN KEY(IdCliente) REFERENCES Cliente(Id),
    CONSTRAINT fk_SolicitudPago_Naviera FOREIGN KEY(IdNaviera) REFERENCES Naviera(Id)
);


 --Tabla gatein (compra de servicio)
 CREATE TABLE GateIn (
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdCliente INT NOT NULL,
	IdNaviera INT NOT NULL,
	NumeroBL VARCHAR(50) NOT NULL,
	Contenedor VARCHAR(50) NOT NULL,
	MontoPago DECIMAL(10, 2) NOT NULL,
	MetodoPago VARCHAR(20) NOT NULL, -- efectivo o transferencia
	FechaPago DATETIME NOT NULL DEFAULT GETDATE(),
	IdUsuario INT NOT NULL, --FK A USUARIO
	-- este es la relacion entre gatein y usuario
	CONSTRAINT fk_GateIn_Usuario FOREIGN KEY(IdUsuario) REFERENCES Usuario(Id),
	--este es la relacion entre gatein y cliente
	CONSTRAINT fk_GateIn_Cliente FOREIGN KEY(IdCliente) REFERENCES Cliente(Id),
	--este es la relacion entre gatein y naviera
	CONSTRAINT fk_GateIn_Naviera FOREIGN KEY(IdNaviera) REFERENCES Naviera(Id)
 );
GO

--Tabal Factura
CREATE TABLE Factura (
	Id INT PRIMARY KEY IDENTITY(1,1),
	IdGateIn INT NOT NULL,
	RutaArchivoPDF VARCHAR(200),
	FechaEmision DATETIME NOT NULL,
	NumeroFactura VARCHAR(50) NOT NULL,
	--esta es la relacion que hay entre factura y gatein
	CONSTRAINT fk_Factura_GateIn FOREIGN KEY(IdGateIn) REFERENCES GateIn(Id)
);
GO

-- Tabla Historial
CREATE TABLE Historial (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    Accion VARCHAR(100) NOT NULL,
    FechaHora DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT fk_Historial_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)
);
GO

CREATE TABLE SolicitudPagoBancoChile (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdCliente INT NOT NULL,
    NombreSolicitante VARCHAR(100) NOT NULL,
    MontoDolares DECIMAL(10,2) NOT NULL,
    TipoCambio DECIMAL(10,2) NOT NULL, -- por ejemplo: 6.95
    Comision DECIMAL(10,2) NOT NULL, -- comisión que ustedes cobran
    MontoEnBolivianos DECIMAL(10,2) NOT NULL, -- precálculo: (MontoDolares * TipoCambio) + Comision
    EstadoPago VARCHAR(20) NOT NULL DEFAULT 'Pendiente', -- Pendiente o Pagado
    FechaSolicitud DATETIME NOT NULL DEFAULT GETDATE(),
    FechaPago DATETIME NULL,
    RutaComprobantePago VARCHAR(200), -- foto o PDF del voucher cuando se paga
    Observaciones TEXT NULL,

    CONSTRAINT fk_SolicitudPagoBancoChile_Cliente FOREIGN KEY (IdCliente) REFERENCES Cliente(Id)
);
GO

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Cliente ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Cliente ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Cliente ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Naviera ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Naviera ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Naviera ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE SolicitudPago ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE SolicitudPago ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE SolicitudPago ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE GateIn ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE GateIn ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE GateIn ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Factura ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Factura ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Factura ADD estado SMALLINT NOT NULL DEFAULT 1;

ALTER TABLE Historial ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Historial ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Historial ADD estado SMALLINT NOT NULL DEFAULT 1;

-- Procedimiento para listar clientes
-- esto sirve para listar los clientes selecciona todo de la tabla cliente donde el estado sea diferente de -1 y busca en los campos Nombre, Telefono, Email y TipoCliente
GO
ALTER PROC paClienteListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM Cliente
    WHERE estado <> -1 
      AND (Nombre + Telefono + ISNULL(Email, '') + TipoCliente) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY estado DESC, Nombre ASC;
END;

--- Procedimien0to para listar clientes
EXEC paClienteListar 'José ';
--

GO
--procedimiento para listar navieras
ALTER PROC paNavieraListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM Naviera
    WHERE estado <> -1 
      AND (Nombre + ISNULL(URLPortal, '')) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY estado DESC, Nombre ASC;
END;
GO

-- procedimiento para listar gatein  con cliente y naviera
ALTER PROC paGateInListar @parametro VARCHAR(100)
AS
BEGIN
    SELECT g.*, c.Nombre AS NombreCliente, n.Nombre AS NombreNaviera, u.NombreUsuario
    FROM GateIn g
    INNER JOIN Cliente c ON g.IdCliente = c.Id
    INNER JOIN Naviera n ON g.IdNaviera = n.Id
    INNER JOIN Usuario u ON g.IdUsuario = u.Id
    WHERE g.estado <> -1 
      AND (c.Nombre + n.Nombre + g.NumeroBL + g.Contenedor + g.MetodoPago + g.Estado) 
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY g.FechaPago DESC;
END;
GO

-- DML
INSERT INTO Usuario (NombreUsuario, Contrasena, Rol)
VALUES 
('admin', 'admin123', 'Administrador'),
('operador1', 'op123456', 'Operador');

INSERT INTO Cliente (Nombre, Telefono, Email, TipoCliente)
VALUES 
('Carlos Ramírez', '78945612', 'carlos.ramirez@gmail.com', 'Titular'),
('María López', '78542100', 'maria.lopez@yahoo.com', 'Representante'),
('José Quispe', '71234567', NULL, 'Titular');

INSERT INTO Naviera (Nombre, URLPortal)
VALUES 
('MSC', 'https://www.msc.com'),
('MAERSK', 'https://www.maersk.com'),
('HAPAG-LLOYD', 'https://www.hapag-lloyd.com');

INSERT INTO GateIn (IdCliente, IdNaviera, NumeroBL, Contenedor, MontoPago, MetodoPago, FechaPago, IdUsuario)
VALUES 
(1, 1, 'MSCBL001', 'MSCU1234567', 150.00, 'Efectivo', GETDATE(), 2),
(2, 2, 'MAERSKBL45', 'MAEU7894561', 200.00, 'Transferencia', GETDATE(), 2),
(3, 3, 'HAPAG123', 'HLXU4567890', 180.00, 'Efectivo', GETDATE(), 2);

INSERT INTO Factura (IdGateIn, RutaArchivoPDF, FechaEmision, NumeroFactura)
VALUES 
(1, 'C:\Facturas\factura001.pdf', GETDATE(), 'F001-0001'),
(3, 'C:\Facturas\factura002.pdf', GETDATE(), 'F001-0002');

INSERT INTO Historial (IdUsuario, Accion)
VALUES 
(2, 'Registró un GateIn para MSC'),
(2, 'Pagó trámite y generó factura para cliente Carlos'),
(1, 'Modificó estado del GateIn HAPAG123 a Pagado');

SELECT * FROM Usuario;
SELECT * FROM Cliente;
SELECT * FROM Naviera;
SELECT * FROM GateIn;
SELECT * FROM Factura;
SELECT * FROM Historial;