CREATE DATABASE SistemaVentas;
USE SistemaVentas;

GO

-- Tabla CATEGORIA
CREATE TABLE Categoria (
    IdCategoria INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    Descripcion VARCHAR(MAX) NOT NULL,
    Estado BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),

    
);
ALTER TABLE Categoria ADD Nombre VARCHAR(100) NOT NULL
Select * FROM Categoria
-- Tabla PRODUCTO
CREATE TABLE Producto (
    IdProducto INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    Codigo VARCHAR(50) UNIQUE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(MAX) NULL,
    IdCategoria INT NOT NULL,
    Stock INT DEFAULT 0 ,
    PrecioCompra DECIMAL(10,2) NULL,
    PrecioVenta DECIMAL(10,2) NOT NULL,
    Estado BIT DEFAULT 1,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
);

-- Tabla PROVEEDOR
CREATE TABLE Proveedor (
    IdProveedor INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    RazonSocial VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) UNIQUE NULL,
    Telefono VARCHAR(20) NOT NULL,
    Estado BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE()
);

-- Tabla ROL
CREATE TABLE Rol (
    IdRol INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    Descripcion VARCHAR(MAX) NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE()
);

-- Tabla USUARIO
CREATE TABLE Usuario (
    IdUsuario INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    DNI VARCHAR(50) UNIQUE NOT NULL,
    Nombre1 VARCHAR(50) NOT NULL,
    Nombre2 VARCHAR(50)  NULL,
    Apellido1 VARCHAR(50) NOT NULL,
    Apellido2 VARCHAR(50)  NULL,
    Correo VARCHAR(100) UNIQUE,
    Clave VARCHAR(20) NOT NULL,
    IdRol INT,
    Estado BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdRol) REFERENCES Rol(IdRol)
);

-- Tabla CLIENTE
CREATE TABLE Cliente (
    IdCliente INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    DNI VARCHAR(50) UNIQUE NOT NULL,
    Nombre1 VARCHAR(50) NOT NULL,
    Nombre2 VARCHAR(50)  NULL,
    Apellido1 VARCHAR(50) NOT NULL,
    Apellido2 VARCHAR(50)  NULL,
    Correo VARCHAR(100) UNIQUE NULL,
    Telefono VARCHAR(20),
    Estado BIT DEFAULT 1,
    FechaCreacion DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Tabla PERMISO
CREATE TABLE Permiso (
    IdPermiso INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    IdRol INT,
    NombreMenu VARCHAR(50) NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdRol) REFERENCES Rol(IdRol)

);

--TABLA FACTURA
CREATE TABLE Factura (
    IdFactura  INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    NumeroFactura VARCHAR(20) UNIQUE NOT NULL,
    IdCliente INT ,
    IdUsuario INT ,
    Fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
    SubTotal DECIMAL(10,2),
    Descuento DECIMAL(10,2),
    Total DECIMAL(10,2),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario)
);

-- Tabla COMPRA
CREATE TABLE Compra (
    IdCompra  INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    IdUsuario INT,
    IdProveedor INT,
    NumeroFactura VARCHAR(20),
    MontoTotal DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor),
    FOREIGN KEY(NumeroFactura) REFERENCES Factura (NumeroFactura)
);


-- Tabla DETALLE_COMPRA
CREATE TABLE DetalleCompra (
    IdDetalleCompra INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    IdCompra INT,
    IdProducto INT,
    PrecioCompra DECIMAL(10,2),
    PrecioVenta DECIMAL(10,2),
    Cantidad INT,
    Total DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdCompra) REFERENCES Compra(IdCompra),
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);



-- Tabla VENTA
CREATE TABLE Venta (
    IdVenta INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    IdUsuario INT,
    IdCliente INT,
    NumeroFactura VARCHAR(20),
    MontoPago DECIMAL(10,2),
    MontoCambio DECIMAL(10,2),
    MontoTotal DECIMAL(10,2),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN  KEY (NumeroFactura) REFERENCES Factura (NumeroFactura),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente),

);

-- Tabla DETALLE_VENTA
CREATE TABLE DetalleVenta (
    IdDetalleVenta INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
    IdVenta INT,
    IdProducto INT,
    PrecioVenta DECIMAL(10,2),
    Cantidad INT,
    SubTotal DECIMAL(10,2),
    NumeroFactura VARCHAR(20),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdVenta) REFERENCES Venta(IdVenta),
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto),
    FOREIGN  KEY (NumeroFactura) REFERENCES Factura (NumeroFactura),
);
