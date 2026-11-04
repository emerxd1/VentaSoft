SELECT * FROM Rol
SELECT * FROM Usuario
SELECT * FROM Permiso WHERE IdRol=2;
SELECT * FROM Cliente
SELECT * FROM Categoria
SELECT * FROM Producto
SELECT * FROM Compra
SELECT * FROM Venta
SELECT * FROM Proveedor;

Truncate table Proveedor

ALTER TABLE Producto
ADD StockMinimo INT DEFAULT 5;


ALTER TABLE Usuario
ADD Telefono VARCHAR(20) NULL;


SELECT Estado, COUNT(*) FROM Cliente GROUP BY Estado

insert into Permiso (IdRol,NombreMenu) values 
(1, 'MenuEmpleados'),
(1, 'MenuVentas'),
(1, 'MenuCompras'),
(1, 'MenuAdministrar'),
(1, 'MenuProveedores'),
(1, 'MenuClientes'),
(1, 'MenuProducto'),
(1, 'MenuReportes'),
(1, 'MenuAbout')
insert into Permiso (IdRol,NombreMenu) values 
(1,'MenuInicio')

insert into Rol (Descripcion)values ('Empleado')

insert into Permiso (IdRol,NombreMenu) values 
(2,'MenuProducto'),
(2, 'MenuVentas'),
(2, 'MenuCompras'),
(2, 'MenuProveedores'),
(2, 'MenuClientes'),
(2, 'MenuAbout')
insert into Permiso (IdRol,NombreMenu) values 
(2,'MenuInicio')

/*AGRENGANDO UN NUEVO SUBMENU CATEGORIA PARA GESTIONAR CATEGORIAS DE PRODUCTOS*/
insert into Permiso (IdRol,NombreMenu) values 
(2,'MenuCategory')

insert into Permiso (IdRol,NombreMenu) values 
(1,'MenuCategory')




/*Delete from Rol where IdRol =2;*/

SELECT * FROM Rol

select p.IdRol,p.NombreMenu from Permiso p
inner join Rol r ON r.IdRol = p.IdRol
inner join Usuario u on u.IdRol = r.IdRol

where u.IdUsuario = 1 

/*  Esta consulta obtiene los menús (permisos) a los que tiene acceso el usuario 1,
 cruzando Usuario -> Rol -> Permiso mediante INNER JOIN.
 INNER JOIN solo devuelve resultados cuando existe coincidencia en ambas tablas;
 si el usuario no tiene rol, o el rol no tiene permisos, no se devuelve ninguna fila.  */

 select p.IdRol,p.NombreMenu from Permiso p
inner join Rol r ON r.IdRol = p.IdRol
inner join Usuario u on u.IdRol = r.IdRol

where u.IdUsuario = 2

/*  Esta consulta obtiene los menús (permisos) a los que tiene acceso el usuario 2,
 cruzando Usuario -> Rol -> Permiso mediante INNER JOIN.
 INNER JOIN solo devuelve resultados cuando existe coincidencia en ambas tablas;
 si el usuario no tiene rol, o el rol no tiene permisos, no se devuelve ninguna fila.  */


insert into Usuario (DNI,Nombre1,Nombre2,Apellido1,Apellido2,Correo,Clave,IdRol,Estado)
VALUES ('001-120202','Emer','Andres','Granados','Castellon', 'emercastellon26@gmail.com','empleado1',2,1)

insert into Usuario (DNI,Nombre1,Nombre2,Apellido1,Apellido2,Correo,Clave,IdRol,Estado)
VALUES ('001-120202-0010L','Alexander','Josue','Guerrero','Alfaro', 'guerreroalfaroalexnderjosue@gmail.com','empleado2',2,1)

insert into Usuario (DNI,Nombre1,Nombre2,Apellido1,Apellido2,Correo,Clave,IdRol,Estado)
VALUES ('001-120204-0010M','Rigoberto','Jose','Centeno','Gallo', 'rigobertocenteno189@gmail.com','admin',2,1)

UPDATE Usuario
SET  IdRol  = 1
WHERE DNI = '001-120204-0010M';

select u.IdUsuario,u.DNI,u.Nombre1,u.Nombre2,u.Apellido1,u.Apellido2,u.Correo,u.Clave,u.Estado, r.IdRol,r.Descripcion from Usuario u
inner join Rol r on r.IdRol = u.IdRol 
/*consulta para mostrar datos en datagridview usuarios o empleados */


/*Select *  FROM dbo.Permiso
WHERE IdPermiso IN (1003,1004,1005,1006,1007,1008);*/


/*====================================================================================
  PROCEDIMIENTOS ALMACENADOS - VentaSoft
  - Los procedimientos de "eliminar" hacen BORRADO LOGICO: ponen Estado = 0 (inactivo)
    en lugar de borrar el registro. 
====================================================================================*/


/*------------------------------------------------------------------------------------
  USUARIOS (EMPLEADOS)
------------------------------------------------------------------------------------*/


/* 2) REGISTRAR USUARIO */
ALTER PROCEDURE SP_REGISTERUSER
(
    @DNI VARCHAR(30),
    @Nombre1 VARCHAR(50),
    @Nombre2 VARCHAR(50),
    @Apellido1 VARCHAR(50),
    @Apellido2 VARCHAR(50),
    @Correo VARCHAR(100),
    @Clave VARCHAR(20),
    @IdRol int,
    @Estado bit,
    @Telefono VARCHAR(20) = NULL,   -- nuevo (con valor por defecto: el código viejo sigue funcionando)
    @IdUsuarioResultado int output,
    @Mensaje VARCHAR(500) output
)
AS
BEGIN
    SET @IdUsuarioResultado = 0
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT * FROM Usuario WHERE DNI = @DNI)
    BEGIN
        INSERT INTO Usuario(DNI, Nombre1, Nombre2, Apellido1, Apellido2,
                            Correo, Clave, IdRol, Estado, Telefono)
        VALUES (@DNI, @Nombre1, @Nombre2, @Apellido1, @Apellido2,
                @Correo, @Clave, @IdRol, @Estado, @Telefono)

        SET @IdUsuarioResultado = SCOPE_IDENTITY()
        SET @Mensaje = ''
    END
    ELSE
        SET @Mensaje = 'El valor ingresado ya se encuentra asignado a otro usuario. No se permiten valores duplicados.'
END
GO

/* 3) EDITAR USUARIO */
ALTER PROC SP_EDITUSER
(
    @IdUsuario int,
    @DNI VARCHAR(30),
    @Nombre1 VARCHAR(50),
    @Nombre2 VARCHAR(50),
    @Apellido1 VARCHAR(50),
    @Apellido2 VARCHAR(50),
    @Correo VARCHAR(100),
    @Clave VARCHAR(20),
    @IdRol int,
    @Estado bit,
    @Telefono VARCHAR(20) = NULL,   -- nuevo
    @Error bit OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Error = 0
    SET @Mensaje = ''

    -- Verifica si el DNI ya pertenece a OTRO usuario (se excluye la propia fila)
    IF NOT EXISTS (SELECT 1 FROM Usuario WHERE DNI = @DNI AND IdUsuario <> @IdUsuario)
    BEGIN
        -- Verificar si hay diferencias reales
        IF EXISTS (
            SELECT 1 FROM Usuario
            WHERE IdUsuario = @IdUsuario
              AND (
                   DNI <> @DNI OR
                   Nombre1 <> @Nombre1 OR
                   Nombre2 <> @Nombre2 OR
                   Apellido1 <> @Apellido1 OR
                   Apellido2 <> @Apellido2 OR
                   Correo <> @Correo OR
                   Clave <> @Clave OR
                   IdRol <> @IdRol OR
                   Estado <> @Estado OR
                   ISNULL(Telefono, '') <> ISNULL(@Telefono, '')   -- nuevo (seguro con NULL)
              )
        )
        BEGIN
            UPDATE Usuario
            SET DNI = @DNI,
                Nombre1 = @Nombre1,
                Nombre2 = @Nombre2,
                Apellido1 = @Apellido1,
                Apellido2 = @Apellido2,
                Correo = @Correo,
                Clave = @Clave,
                IdRol = @IdRol,
                Estado = @Estado,
                Telefono = @Telefono                              
            WHERE IdUsuario = @IdUsuario;

            SET @Error = 1
            SET @Mensaje = 'Usuario actualizado correctamente.'
        END
        ELSE
        BEGIN
            SET @Mensaje = 'No se registraron cambios en el usuario.'
        END
    END
    ELSE
    BEGIN
        SET @Mensaje = 'El valor ingresado ya se encuentra asignado a otro usuario. No se permiten valores duplicados.'
    END
END
GO


/* 4) PENDIENTE: el SP que LISTA usuarios (no lo enviaste) debe incluir Telefono en su SELECT. */

/*------------------------------------------------------------------------------------
  CATEGORIAS
------------------------------------------------------------------------------------*/

/* REGISTRAR CATEGORIA */
ALTER PROCEDURE SP_RegisterCategory
(
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(MAX),
    @Estado bit,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 0;

    IF NOT EXISTS (SELECT 1 FROM Categoria WHERE Nombre = @Nombre)
    BEGIN
        INSERT INTO Categoria (Nombre, Descripcion, Estado) VALUES (@Nombre, @Descripcion, @Estado);
        SET @Resultado = SCOPE_IDENTITY();
        SET @Mensaje = 'Categoría registrada correctamente.';
    END
    ELSE
    BEGIN
        SET @Mensaje = 'La categoría ingresada ya existe. No se permiten valores duplicados.';
    END
END
GO

/* ACTUALIZAR CATEGORIA */
ALTER PROCEDURE SP_UpdateCategory
(
    @IdCategoria INT,
    @Nombre VARCHAR(100),
    @Descripcion VARCHAR(MAX),
    @Estado BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1;

    -- Validar duplicados
    IF EXISTS (SELECT 1 FROM Categoria WHERE Nombre = @Nombre AND IdCategoria <> @IdCategoria)
    BEGIN
        SET @Resultado = 0;
        SET @Mensaje = 'El nombre ingresado ya está asignado a otra categoría. No se permiten duplicados.';
    END
    ELSE
    BEGIN
        -- Validar si no hay cambios
        IF EXISTS (
            SELECT 1
            FROM Categoria
            WHERE IdCategoria = @IdCategoria
              AND Nombre = @Nombre
              AND Descripcion = @Descripcion
              AND Estado = @Estado
        )
        BEGIN
            SET @Resultado = 0;
            SET @Mensaje = 'No se detectaron cambios en la categoría.';
        END
        ELSE
        BEGIN
            UPDATE Categoria
            SET Nombre = @Nombre,
                Descripcion = @Descripcion,
                Estado = @Estado
            WHERE IdCategoria = @IdCategoria;

            SET @Resultado = 1;
            SET @Mensaje = 'Categoría actualizada correctamente.';
        END
    END
END
GO

/* ELIMINAR CATEGORIA (BORRADO LOGICO) */
CREATE OR ALTER PROCEDURE SP_DeleteCategory
(
    @IdCategoria INT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON
    SET @Resultado = 0
    SET @Mensaje = ''

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Categoria WHERE IdCategoria = @IdCategoria)
        BEGIN
            SET @Mensaje = 'La categoría no existe.'
            RETURN
        END

        IF EXISTS (SELECT 1 FROM Categoria WHERE IdCategoria = @IdCategoria AND Estado = 0)
        BEGIN
            SET @Mensaje = 'La categoría ya se encuentra inactiva.'
            RETURN
        END

        UPDATE Categoria SET Estado = 0 WHERE IdCategoria = @IdCategoria

        SET @Resultado = 1
        SET @Mensaje = 'Categoría inactivada correctamente.'
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END
GO


/*------------------------------------------------------------------------------------
  PRODUCTOS
------------------------------------------------------------------------------------*/

/* REGISTRAR PRODUCTO */
ALTER PROCEDURE SP_REGISTERPRODUCT
(
    @Nombre VARCHAR(100), -- Se amplió a 100 caracteres para nombres largos
    @Descripcion VARCHAR(MAX),
    @IdCategoria INT,
    @Estado BIT,
    @Stock INT,
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @StockMinimo INT = 5,
    @IdResult INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET @IdResult = 0;
    SET @Mensaje = '';

    -- Validar si el producto ya existe (se aplica RTRIM/LTRIM para omitir espacios extra)
    IF NOT EXISTS (SELECT 1 FROM Producto WHERE LOWER(Nombre) = LOWER(RTRIM(LTRIM(@Nombre))))
    BEGIN
        INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
        VALUES (@Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioCompra, @PrecioVenta, @Estado, GETDATE(), @StockMinimo);

        SET @IdResult = SCOPE_IDENTITY();
        SET @Mensaje = 'Producto registrado correctamente.';
    END
    ELSE
    BEGIN
        -- Si ya existe, finaliza sin lanzar error y avisa en el mensaje
        SET @Mensaje = 'El producto ya se encuentra registrado (Omitido).';
    END
END
GO


/* ACTUALIZAR PRODUCTO */
ALTER PROCEDURE SP_UPDATEPRODUCT
(
    @IdProducto INT,
    @Nombre VARCHAR(30),
    @Descripcion VARCHAR(MAX),
    @IdCategoria INT,
    @Estado BIT,
    @Stock INT,
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM Producto WHERE IdProducto = @IdProducto)
    BEGIN
        SET @Mensaje = 'El producto no existe'
        RETURN
    END

    IF EXISTS (SELECT * FROM Producto WHERE Nombre = @Nombre AND IdProducto <> @IdProducto)
    BEGIN
        SET @Mensaje = 'Ya existe otro producto con ese nombre'
        RETURN
    END

    -- Valida si no hubo ningun cambio real
    IF EXISTS (
        SELECT * FROM Producto
        WHERE IdProducto = @IdProducto
          AND Nombre = @Nombre
          AND Descripcion = @Descripcion
          AND IdCategoria = @IdCategoria
          AND Estado = @Estado
          AND Stock = @Stock
          AND PrecioCompra = @PrecioCompra
          AND PrecioVenta = @PrecioVenta
    )
    BEGIN
        SET @Mensaje = 'No se detectaron cambios'
        RETURN
    END

    UPDATE Producto
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        IdCategoria = @IdCategoria,
        Estado = @Estado,
        Stock = @Stock,
        PrecioCompra = @PrecioCompra,
        PrecioVenta = @PrecioVenta
    WHERE IdProducto = @IdProducto

    SET @Mensaje = 'Producto actualizado correctamente'
END
GO

/* ELIMINAR PRODUCTO (BORRADO LOGICO) */
CREATE OR ALTER PROCEDURE SP_DELETEPRODUCT
(
    @IdProducto INT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON
    SET @Respuesta = 0
    SET @Mensaje = ''

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Producto WHERE IdProducto = @IdProducto)
        BEGIN
            SET @Mensaje = 'El producto no existe'
            RETURN
        END

        IF EXISTS (SELECT 1 FROM Producto WHERE IdProducto = @IdProducto AND Estado = 0)
        BEGIN
            SET @Mensaje = 'El producto ya se encuentra inactivo'
            RETURN
        END

        UPDATE Producto SET Estado = 0 WHERE IdProducto = @IdProducto

        SET @Respuesta = 1
        SET @Mensaje = 'Producto inactivado correctamente'
    END TRY
    BEGIN CATCH
        SET @Respuesta = 0
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END
GO


/*------------------------------------------------------------------------------------
  CLIENTES
------------------------------------------------------------------------------------*/

/* REGISTRAR CLIENTE */
ALTER PROC sp_RegistrarCliente(
    @DNI varchar(50),
    @Nombre1 varchar(50),
    @Nombre2 varchar(50),
    @Apellido1 varchar(50),
    @Apellido2 varchar(50),
    @Correo varchar(100),
    @Telefono varchar(20),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(100) output
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT 1 FROM Cliente WHERE DNI = @DNI)
    BEGIN
        INSERT INTO Cliente(DNI, Nombre1, Nombre2, Apellido1, Apellido2, Correo, Telefono, Estado)
        VALUES (@DNI, @Nombre1, @Nombre2, @Apellido1, @Apellido2, @Correo, @Telefono, @Estado)

        SET @Resultado = SCOPE_IDENTITY()
        SET @Mensaje = 'Cliente registrado correctamente'
    END
    ELSE
                SET @Mensaje = 'El Cliente ingresado ya está registrado. No se permiten duplicados.';

END
GO

/* MODIFICAR CLIENTE */
ALTER PROC sp_ModificarCliente(
    @IdCliente int,
    @DNI varchar(50),
    @Nombre1 varchar(50),
    @Nombre2 varchar(50),
    @Apellido1 varchar(50),
    @Apellido2 varchar(50),
    @Correo varchar(100),
    @Telefono varchar(20),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(100) output
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    -- 1. Validar que el cliente exista
    IF NOT EXISTS (SELECT 1 FROM Cliente WHERE IdCliente = @IdCliente)
    BEGIN
        SET @Mensaje = 'El cliente no existe'
        RETURN
    END

    -- 2. Validar que el DNI no pertenezca a otro cliente
    IF EXISTS (SELECT 1 FROM Cliente WHERE DNI = @DNI AND IdCliente != @IdCliente)
    BEGIN
        SET @Mensaje = 'El DNI ya está asignado a otro cliente.No se permiten valores duplicados'
        RETURN
    END

    -- 3. Validar que haya al menos un cambio (ISNULL evita problemas con NULL)
    IF EXISTS (
        SELECT 1 FROM Cliente
        WHERE IdCliente = @IdCliente
          AND DNI = @DNI
          AND Nombre1 = @Nombre1
          AND ISNULL(Nombre2,'') = ISNULL(@Nombre2,'')
          AND Apellido1 = @Apellido1
          AND ISNULL(Apellido2,'') = ISNULL(@Apellido2,'')
          AND ISNULL(Correo,'') = ISNULL(@Correo,'')
          AND ISNULL(Telefono,'') = ISNULL(@Telefono,'')
          AND Estado = @Estado
    )
    BEGIN
        SET @Mensaje = 'No se realizaron cambios: los datos son iguales a los actuales'
        RETURN
    END
    END

    -- 4. Actualizar
    UPDATE Cliente SET
        DNI = @DNI,
        Nombre1 = @Nombre1,
        Nombre2 = @Nombre2,
        Apellido1 = @Apellido1,
        Apellido2 = @Apellido2,
        Correo = @Correo,
        Telefono = @Telefono,
        Estado = @Estado
    WHERE IdCliente = @IdCliente

    SET @Resultado = 1
    SET @Mensaje = 'Cliente actualizado correctamente'
GO

/* ELIMINAR CLIENTE (BORRADO LOGICO) */
CREATE OR ALTER PROCEDURE sp_EliminarCliente
(
    @IdCliente int,
    @Resultado int OUTPUT,
    @Mensaje varchar(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON
    SET @Resultado = 0
    SET @Mensaje = ''

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Cliente WHERE IdCliente = @IdCliente)
        BEGIN
            SET @Mensaje = 'El cliente no existe'
            RETURN
        END

        IF EXISTS (SELECT 1 FROM Cliente WHERE IdCliente = @IdCliente AND Estado = 0)
        BEGIN
            SET @Mensaje = 'El cliente ya se encuentra inactivo'
            RETURN
        END

        UPDATE Cliente SET Estado = 0 WHERE IdCliente = @IdCliente

        SET @Resultado = 1
        SET @Mensaje = 'Cliente inactivado correctamente'
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END
GO


/*------------------------------------------------------------------------------------
  PROVEEDORES
  (La columna RUC se agrega una sola vez, solo si todavia no existe)
------------------------------------------------------------------------------------*/
IF COL_LENGTH('Proveedor', 'RUC') IS NULL
    ALTER TABLE Proveedor ADD RUC VARCHAR(50) NULL;
GO

/* REGISTRAR PROVEEDOR */
ALTER PROC sp_RegistrarProveedores(
    @RUC varchar(50),
    @RazonSocial varchar(100),
    @Correo varchar(100),
    @Telefono varchar(20),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    -- Validación 1: el RUC no puede repetirse
    IF EXISTS (SELECT 1 FROM Proveedor WHERE RUC = @RUC)
    BEGIN
        SET @Mensaje = 'El N° de RUC ya existe'
        RETURN
    END

    -- Validación 2: la Razón Social no puede repetirse
    IF EXISTS (SELECT 1 FROM Proveedor WHERE RazonSocial = @RazonSocial)
    BEGIN
        SET @Mensaje = 'Ya existe un proveedor con esa Razón Social'
        RETURN
    END

    -- Validación 3: la columna Correo tiene restricción UNIQUE
    IF ISNULL(@Correo, '') <> ''
       AND EXISTS (SELECT 1 FROM Proveedor WHERE Correo = @Correo)
    BEGIN
        SET @Mensaje = 'El correo ya está asignado a otro proveedor'
        RETURN
    END

    -- Validación 4: el teléfono no puede repetirse
    IF EXISTS (SELECT 1 FROM Proveedor WHERE Telefono = @Telefono)
    BEGIN
        SET @Mensaje = 'El teléfono ya está asignado a otro proveedor'
        RETURN
    END

    INSERT INTO Proveedor (RUC, RazonSocial, Correo, Telefono, Estado)
    VALUES (@RUC, @RazonSocial, NULLIF(@Correo, ''), @Telefono, @Estado)

    SET @Resultado = SCOPE_IDENTITY()
    SET @Mensaje = 'Proveedor registrado correctamente'
END
GO

/* MODIFICAR PROVEEDOR */
ALTER PROC sp_ModificarProveedores(
    @IdProveedor int,
    @RUC varchar(50),
    @RazonSocial varchar(100),
    @Correo varchar(100),
    @Telefono varchar(20),
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)
AS
BEGIN
    SET @Resultado = 0
    SET @Mensaje = ''

    -- Validación 1: el proveedor debe existir
    IF NOT EXISTS (SELECT 1 FROM Proveedor WHERE IdProveedor = @IdProveedor)
    BEGIN
        SET @Mensaje = 'El proveedor no existe'
        RETURN
    END

    -- Validación 2: debe haber al menos un cambio respecto a lo guardado.
    -- Se compara con collation sensible a mayúsculas/acentos para que cambiar
    -- solo una mayúscula cuente como cambio. El correo NULL se trata como ''.
    IF EXISTS (
        SELECT 1
        FROM Proveedor
        WHERE IdProveedor = @IdProveedor
          AND RUC         COLLATE Latin1_General_CS_AS = @RUC         COLLATE Latin1_General_CS_AS
          AND RazonSocial COLLATE Latin1_General_CS_AS = @RazonSocial COLLATE Latin1_General_CS_AS
          AND ISNULL(Correo, '') COLLATE Latin1_General_CS_AS = ISNULL(@Correo, '') COLLATE Latin1_General_CS_AS
          AND Telefono    COLLATE Latin1_General_CS_AS = @Telefono    COLLATE Latin1_General_CS_AS
          AND Estado = @Estado
    )
    BEGIN
        SET @Mensaje = 'No se registraron cambios'
        RETURN
    END

    -- Validación 3: el RUC no debe pertenecer a OTRO proveedor
    IF EXISTS (SELECT 1 FROM Proveedor WHERE RUC = @RUC AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'El N° de RUC ya existe'
        RETURN
    END

    -- Validación 4: la Razón Social no debe pertenecer a OTRO proveedor
    IF EXISTS (SELECT 1 FROM Proveedor WHERE RazonSocial = @RazonSocial AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'Ya existe un proveedor con esa Razón Social'
        RETURN
    END

    -- Validación 5: lo mismo para el correo (UNIQUE)
    IF ISNULL(@Correo, '') <> ''
       AND EXISTS (SELECT 1 FROM Proveedor WHERE Correo = @Correo AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'El correo ya está asignado a otro proveedor'
        RETURN
    END

    -- Validación 6: el teléfono no debe pertenecer a OTRO proveedor
    IF EXISTS (SELECT 1 FROM Proveedor WHERE Telefono = @Telefono AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'El teléfono ya está asignado a otro proveedor'
        RETURN
    END

    UPDATE Proveedor SET
        RUC = @RUC,
        RazonSocial = @RazonSocial,
        Correo = NULLIF(@Correo, ''),
        Telefono = @Telefono,
        Estado = @Estado
    WHERE IdProveedor = @IdProveedor

    SET @Resultado = 1
    SET @Mensaje = 'Proveedor actualizado correctamente'
END
GO
/* ELIMINAR PROVEEDOR (BORRADO LOGICO) */
CREATE OR ALTER PROCEDURE sp_EliminarProveedores
(
    @IdProveedor int,
    @Resultado bit OUTPUT,
    @Mensaje varchar(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON
    SET @Resultado = 0
    SET @Mensaje = ''

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Proveedor WHERE IdProveedor = @IdProveedor)
        BEGIN
            SET @Mensaje = 'El proveedor no existe'
            RETURN
        END

        IF EXISTS (SELECT 1 FROM Proveedor WHERE IdProveedor = @IdProveedor AND Estado = 0)
        BEGIN
            SET @Mensaje = 'El proveedor ya se encuentra inactivo'
            RETURN
        END

        UPDATE Proveedor SET Estado = 0 WHERE IdProveedor = @IdProveedor

        SET @Resultado = 1
        SET @Mensaje = 'Proveedor inactivado correctamente'
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END
GO

/*---------------------------------------------------------------------
  CONSULTA FINAL
---------------------------------------------------------------------*/
SELECT IdProveedor, RUC, RazonSocial, Correo, Telefono, Estado
FROM Proveedor
GO

--Añadi la columna RUC para proovedor ya que no estaba
IF COL_LENGTH('Proveedor', 'RUC') IS NULL
    ALTER TABLE Proveedor ADD RUC VARCHAR(50) NULL;
GO

SELECT name FROM sys.procedures WHERE name LIKE '%Proveedor%';



-------------------*Procedimientos para compra*----------------------

--Actualizacion a la base de datos
IF COL_LENGTH('Compra', 'TipoDocumento') IS NULL
    ALTER TABLE Compra ADD TipoDocumento VARCHAR(500) NULL;
IF COL_LENGTH('Compra', 'NumeroDocumento') IS NULL
    ALTER TABLE Compra ADD NumeroDocumento VARCHAR(500) NULL;
GO

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE  --Tipo de tabla definido por el usuario
(
    [IdProducto] int NULL,
    [PrecioCompra] decimal(18,2) NULL,
    [PrecioVenta] decimal(18,2) NULL,
    [Cantidad] int NULL,
    [MontoTotal] decimal(18,2) NULL
)

GO

--Codigo autogenerado para compras
--00001
--00002 

--Procedimiento almacenado para registrar una nueva compra en el sistema con su detalle
CREATE OR ALTER PROCEDURE sp_RegistrarCompra
(
    @IdUsuario int,
    @IdProveedor int,
    @TipoDocumento varchar(500),
    @NumeroDocumento varchar(500),
    @MontoTotal decimal(18,2),
    @DetalleCompra dbo.EDetalle_Compra READONLY,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
AS
BEGIN
    BEGIN TRY
        --inicializamos las variables de repuesta
        DECLARE @idcompra int = 0
        SET @Resultado = 1
        SET @Mensaje = ''

        BEGIN TRANSACTION registro --iniciamos la transaccion

        --Registramos el encavesado de la compra
        INSERT INTO Compra(IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal)
        VALUES (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

        --Obtenemos el id de la compra recien creada
        SET @idcompra = SCOPE_IDENTITY()

        --Registrar los detalles de los productos comprados
        INSERT INTO DetalleCompra(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, Total)
        SELECT @idcompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal FROM @DetalleCompra

        --Actualizar el stock y los precios en el inventario de los productos
        UPDATE p SET p.Stock = p.Stock + dc.Cantidad,
            p.PrecioCompra = dc.PrecioCompra,
            p.PrecioVenta = dc.PrecioVenta
        FROM Producto p
        INNER JOIN @DetalleCompra dc ON dc.IdProducto = p.IdProducto

        --Si todo sale bien se confirma los cambios
        COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
    -- Si ocurre un error, el mensaje se captura y deshace todo
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION
    END CATCH
END
GO

--Comprobacion

SELECT * FROM Compra;
SELECT * FROM DetalleCompra;
SELECT IdProducto, Stock, PrecioCompra, PrecioVenta FROM Producto;

USE SistemaVentas;

--------------------------DETALLES DE LA COMPRA----------------------------------
SELECT c.IdCompra,
u.Nombre1,u.Nombre2,u.Apellido1,u.Apellido2,
pr.RUC,pr.RazonSocial,
c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,convert(char(10),FechaRegistro,103)[FechaRegistro]
FROM Compra c
inner join Usuario u on u.IdUsuario = c.IdUsuario
inner join Proveedor pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento ='C0001'

select p.Nombre,dc.PrecioCompra,dc.Cantidad,dc.Total
from DetalleCompra dc
inner join Producto p on p.IdProducto = dc.IdProducto
where dc.IdCompra = 1



/*-----Procesos para registrar una venta-----*/
IF TYPE_ID('dbo.EDetalle_Venta') IS NULL
CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE
(
    [IdProducto]  int NULL,
    [PrecioVenta] decimal(18,2) NULL,
    [Cantidad]    int NULL,
    [SubTotal]    decimal(18,2) NULL
)
GO

CREATE OR ALTER PROCEDURE sp_RegistrarVenta
(
    @IdUsuario     int,
    @IdCliente     int,
    @TipoDocumento varchar(50),
    @NumeroFactura varchar(50),
    @MontoPago     decimal(18,2),
    @MontoCambio   decimal(18,2),
    @MontoTotal    decimal(18,2),
    @DetalleVenta  dbo.EDetalle_Venta READONLY,
    @Resultado     bit          OUTPUT,
    @Mensaje       varchar(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
        DECLARE @idventa int = 0
        DECLARE @Nombre1 varchar(50), @Apellido1 varchar(50)
        DECLARE @faltante varchar(200) = NULL
        SET @Resultado = 1
        SET @Mensaje = ''

        BEGIN TRANSACTION registro

        -- Nombre y apellido salen del cliente not null
        SELECT @Nombre1 = Nombre1, @Apellido1 = Apellido1
        FROM Cliente WHERE IdCliente = @IdCliente

        IF @Nombre1 IS NULL
            RAISERROR('El cliente seleccionado no existe', 16, 1)

        -- Validar el stock
        SELECT TOP 1 @faltante = p.Nombre
        FROM Producto p WITH (UPDLOCK, HOLDLOCK)
        INNER JOIN (SELECT IdProducto, SUM(Cantidad) AS Cantidad
                    FROM @DetalleVenta GROUP BY IdProducto) dv
                ON dv.IdProducto = p.IdProducto
        WHERE p.Stock < dv.Cantidad

        IF @faltante IS NOT NULL
            RAISERROR('Stock insuficiente para el producto: %s', 16, 1, @faltante)

        INSERT INTO Venta(IdUsuario, IdCliente, TipoDocumento, NumeroFactura, Nombre1, Apellido1,
                          MontoPago, MontoCambio, MontoTotal, FechaRegistro)
        VALUES (@IdUsuario, @IdCliente, @TipoDocumento, @NumeroFactura, @Nombre1, @Apellido1,
                @MontoPago, @MontoCambio, @MontoTotal, GETDATE())

        SET @idventa = SCOPE_IDENTITY()

        INSERT INTO DetalleVenta(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
        SELECT @idventa, IdProducto, PrecioVenta, Cantidad, SubTotal FROM @DetalleVenta

        -- Descontar stock
        UPDATE p SET p.Stock = p.Stock - dv.Cantidad
        FROM Producto p
        INNER JOIN (SELECT IdProducto, SUM(Cantidad) AS Cantidad
                    FROM @DetalleVenta GROUP BY IdProducto) dv
                ON dv.IdProducto = p.IdProducto

        COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
        SET @Resultado = 0
        SET @Mensaje = ERROR_MESSAGE()
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION
    END CATCH
END
GO

------------consultas de la venta------------

SELECT v.IdVenta,
       u.Nombre1 AS UsuNombre1, u.Apellido1 AS UsuApellido1,
       c.DNI AS DNICliente,
       c.Nombre1 AS CliNombre1, c.Nombre2 AS CliNombre2,
       c.Apellido1 AS CliApellido1, c.Apellido2 AS CliApellido2,
       v.TipoDocumento, v.NumeroFactura,
       v.MontoPago, v.MontoCambio, v.MontoTotal,
       CONVERT(char(10), v.FechaRegistro, 103) AS FechaRegistro
FROM Venta v
INNER JOIN Usuario u ON u.IdUsuario = v.IdUsuario
INNER JOIN Cliente c ON c.IdCliente = v.IdCliente
WHERE v.NumeroFactura = 'V0001'

SELECT p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal
FROM DetalleVenta dv
INNER JOIN Producto p ON p.IdProducto = dv.IdProducto
WHERE dv.IdVenta = 1


----------cambio de codigo para ventas y  compras-------
----------Ventas: V0001--------
----------Compras C0001-------


UPDATE Compra SET NumeroDocumento = 'C' + RIGHT(NumeroDocumento, 4)
WHERE NumeroDocumento IS NOT NULL AND NumeroDocumento NOT LIKE 'C%';

UPDATE Venta SET NumeroFactura = 'V' + RIGHT(NumeroFactura, 4)
WHERE NumeroFactura IS NOT NULL AND NumeroFactura NOT LIKE 'V%';





-- Columnas
SELECT t.name AS Tabla, c.name AS Columna, ty.name AS Tipo, c.max_length, c.is_nullable
FROM sys.tables t
JOIN sys.columns c ON c.object_id = t.object_id
JOIN sys.types ty ON ty.user_type_id = c.user_type_id
ORDER BY t.name, c.column_id;

-- Claves foráneas y su acción al borrar
SELECT fk.name, OBJECT_NAME(fk.parent_object_id) AS Tabla,
       OBJECT_NAME(fk.referenced_object_id) AS Referencia, fk.delete_referential_action_desc
FROM sys.foreign_keys fk;

-- Triggers
SELECT name, OBJECT_NAME(parent_id) AS Tabla FROM sys.triggers;

-- Procedimientos desplegados que contienen DELETE
SELECT OBJECT_NAME(object_id) AS Nombre, definition
FROM sys.sql_modules WHERE definition LIKE '%DELETE%';


select
CONVERT(char(10), c.FechaRegistro, 103) [FechaRegistro], 
c.TipoDocumento, 
c.NumeroDocumento, 
c.MontoTotal,
u.Nombre1 + u.Apellido1 [UsuarioRegistro], -- Puedes concatenar con apellido si deseas: u.Nombre1 + ' ' + u.Apellido1
pr.RUC [DocumentoProveedor], 
pr.RazonSocial,
p.IdProducto [CodigoProducto], 
p.Nombre [NombreProducto], 
ca.Descripcion [Categoria], 
dc.PrecioCompra, 
dc.PrecioVenta, 
dc.Cantidad, 
dc.Total [SubTotal]

from Compra c
inner join Usuario u on u.IdUsuario = c.IdUsuario
inner join Proveedor pr on pr.IdProveedor = c.IdProveedor
inner join DetalleCompra dc on dc.IdCompra = c.IdCompra
inner join Producto p on p.IdProducto = dc.IdProducto
inner join Categoria ca on ca.IdCategoria = p.IdCategoria




/* =====================================================================
   REPORTES DE COMPRAS Y VENTAS
   - Los alias de columnas NO llevan espacios y coinciden con las
     propiedades de ReporteCompra / ReporteVentas y con el C# (D_Reports).
   - Cada CREATE va separado por GO (CREATE OR ALTER PROC debe ser la
     primera instruccion de su lote).
   ===================================================================== */

-- Elimina el nombre viejo (el C# llama a sp_ReporteVentas)
DROP PROCEDURE IF EXISTS sp_Reporte_Ventas;
GO

/* ---------------------------- COMPRAS ---------------------------- */
CREATE OR ALTER PROC sp_ReporteCompras(
    @fechainicio DATE,
    @fechafin    DATE,
    @idproveedor INT          -- 0 = todos los proveedores
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        CONVERT(CHAR(10), c.FechaRegistro, 103)            AS FechaRegistro,
        c.TipoDocumento,                                   
        c.NumeroDocumento,
        TRIM(CONCAT(u.Nombre1, ' ', u.Apellido1))          AS UsuarioRegistro,
        pr.RUC                                             AS RUCProveedor,
        pr.RazonSocial,
        p.Codigo                                           AS CodigoProducto,
        p.Nombre                                           AS NombreProducto,
        ca.Nombre                                          AS Categoria,
        dc.PrecioCompra,
        dc.PrecioVenta,
        dc.Cantidad,
        dc.Total                                           AS SubTotal
    FROM Compra c
    INNER JOIN Usuario       u  ON u.IdUsuario    = c.IdUsuario
    INNER JOIN Proveedor     pr ON pr.IdProveedor = c.IdProveedor
    INNER JOIN DetalleCompra dc ON dc.IdCompra    = c.IdCompra
    INNER JOIN Producto      p  ON p.IdProducto   = dc.IdProducto
    INNER JOIN Categoria     ca ON ca.IdCategoria = p.IdCategoria
    WHERE c.FechaRegistro >= @fechainicio
      AND c.FechaRegistro <  DATEADD(DAY, 1, @fechafin)
      AND (@idproveedor = 0 OR c.IdProveedor = @idproveedor)
    ORDER BY c.FechaRegistro DESC, c.NumeroDocumento
    OPTION (RECOMPILE);
END
GO

/* ----------------------------- VENTAS ----------------------------- */
CREATE OR ALTER PROC sp_ReporteVentas(
    @fechainicio DATE,
    @fechafin    DATE
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        CONVERT(CHAR(10), v.FechaRegistro, 103)            AS FechaRegistro,
        v.TipoDocumento                                    AS TipoDocumento,   -- NUEVO
        v.NumeroFactura                                    AS NumeroDocumento,
        TRIM(CONCAT(u.Nombre1, ' ', u.Apellido1))          AS UsuarioRegistro,
        TRIM(CONCAT(v.Nombre1, ' ', v.Apellido1))          AS NombreCliente,
        p.Codigo                                           AS CodigoProducto,
        p.Nombre                                           AS NombreProducto,
        ca.Nombre                                          AS Categoria,
        dv.PrecioVenta,
        dv.Cantidad,
        dv.SubTotal                                        AS MontoTotal
    FROM Venta v
    INNER JOIN Usuario      u  ON u.IdUsuario    = v.IdUsuario
    INNER JOIN DetalleVenta dv ON dv.IdVenta     = v.IdVenta
    INNER JOIN Producto     p  ON p.IdProducto   = dv.IdProducto
    INNER JOIN Categoria    ca ON ca.IdCategoria = p.IdCategoria
    WHERE v.FechaRegistro >= @fechainicio
      AND v.FechaRegistro <  DATEADD(DAY, 1, @fechafin)
    ORDER BY v.FechaRegistro DESC, v.NumeroFactura
    OPTION (RECOMPILE);
END
GO
------------------------- PRUEBAS (manuales) -------------------------
EXEC sp_ReporteCompras @fechainicio = '2026-01-01', @fechafin = '2026-12-31', @idproveedor = 0;
EXEC sp_ReporteVentas  @fechainicio = '2026-01-01', @fechafin = '2026-12-31';
----------------------------------------------------------------------- 
/*--------------------------------------------------------------------
     las ventas ahora guardan codigos como V0001 y ese numero no
     existe en la tabla Factura entonces  hacia que  SQL rechazaba la venta
     el nombre de la llavr cambia en cada base por eso se busca solo
     por eso no borra datos solo quitamos la regla
--------------------------------------------------------------------*/
DECLARE @fk nvarchar(200);

SELECT @fk = fk.name
FROM sys.foreign_keys fk
INNER JOIN sys.foreign_key_columns fkc ON fkc.constraint_object_id = fk.object_id
WHERE fk.parent_object_id = OBJECT_ID('Venta')
  AND COL_NAME(fkc.parent_object_id, fkc.parent_column_id) = 'NumeroFactura';

-- si la llave existe se elimina y si ya no esta no hace nada
IF @fk IS NOT NULL EXEC('ALTER TABLE Venta DROP CONSTRAINT [' + @fk + ']');
GO

/*--------------------------------------------------------------------
     agregamos columna TipoDocumento a Venta boleta o factura por que con esta columna nos daba error
     en detalle de venta y en el registro de ventas no nos permitia descargar el pdf
--------------------------------------------------------------------*/
IF COL_LENGTH('Venta', 'TipoDocumento') IS NULL
    ALTER TABLE Venta ADD TipoDocumento VARCHAR(50) NULL;
GO

/*--------------------------------------------------------------------
-- Nombre1 y Apellido1 ya no la usamos en ventas el cliente lo mostramos por IdCliente solo las dejamos opcionales para que no falle el insert
--------------------------------------------------------------------*/
IF COL_LENGTH('Venta', 'Nombre1') IS NOT NULL
    ALTER TABLE Venta ALTER COLUMN Nombre1 VARCHAR(50) NULL;

IF COL_LENGTH('Venta', 'Apellido1') IS NOT NULL
    ALTER TABLE Venta ALTER COLUMN Apellido1 VARCHAR(50) NULL;
GO 

    SELECT name, create_date, modify_date
FROM sys.procedures
ORDER BY create_date DESC;


/*LIMPIEZA DE BASE DATOS*/



Truncate table Proveedores;

DELETE FROM Proveedor;
DBCC CHECKIDENT ('Proveedor', RESEED, 0);
DBCC CHECKIDENT ('dbo.Proveedor', RESEED, 0);

-- Quién referencia a Proveedores
SELECT OBJECT_NAME(parent_object_id) AS TablaHija, name AS FK
FROM sys.foreign_keys
WHERE referenced_object_id = OBJECT_ID('Proveedores');

-- Quién referencia a Compra (probablemente el detalle)
SELECT OBJECT_NAME(parent_object_id) AS TablaHija, name AS FK
FROM sys.foreign_keys
WHERE referenced_object_id = OBJECT_ID('Compra');

BEGIN TRAN;

DELETE FROM DetalleCompra;
DELETE FROM Compra;
DELETE FROM Proveedor;

DBCC CHECKIDENT ('DetalleCompra', RESEED, 0);
DBCC CHECKIDENT ('Compra', RESEED, 0);
DBCC CHECKIDENT ('Proveedores', RESEED, 0);

COMMIT;

SELECT @@TRANCOUNT;   -- debe dar 0

SELECT s.name AS Esquema, o.name AS Objeto, o.type_desc
FROM sys.objects o
JOIN sys.schemas s ON s.schema_id = o.schema_id
WHERE o.name LIKE 'Proveedor%';


ALTER TABLE Proveedor DROP CONSTRAINT UQ_CorreoProveedor;
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_CorreoProveedor
ON Proveedor (Correo)
WHERE Correo IS NOT NULL;
GO


SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
ORDER BY TABLE_NAME, ORDINAL_POSITION;




/*CONSULTAS PARA EL DASHBOARD*/


CREATE INDEX IX_Venta_FechaRegistro
ON Venta (FechaRegistro) INCLUDE (MontoTotal);

CREATE INDEX IX_DetalleVenta_IdVenta
ON DetalleVenta (IdVenta) INCLUDE (IdProducto, SubTotal);




INSERT INTO Proveedor ( RazonSocial, Correo, Telefono, Estado, RUC)
VALUES 
( 'Bimbo de Nicaragua S.A', 'ileana.suarez@grupobimbo.com', '2268-7783', 1, 'J0310000004080'),
( 'DIANA S.A', 'atencioncalconsumidorman@dismana.com.ni', '2266-1936', 1, 'J0310000004145'),
( 'TIGO Nicaragua', 'atencion@tigobusiness.com.ni', '8880-9999', 1, 'J0310000001740'),
( 'COMPANIA DISTRIBUIDORA DE NICARAGUA S A', NULL, '2255-7700', 1, 'J0310000193169'),
( 'Coca Cola FEMSA', NULL, '2248-6600', 1, 'J0310000004811'),
( 'OCAL S.A', 'ocalsa@ocalsa.com.ni', '2276-9400', 1, 'J0310000004153'),
( 'Tropigas de Nicaragua S.A', 'info@tropigas-sa.com.ni', '2255-8615', 1, 'J0310000001308'),
( 'DINANT S.A', NULL, '2251-4070', 1, 'J0310000003289'),
( 'CARGIL de Nicaragua S.A', 'nicaragua_consultas@cargill.com', '2279-9245', 1, 'J0310000003203'),
( 'DIINSA de Nicaragua S.A', 'servcliente@diinsa.com.ni', '2311-0851', 1, 'J0310000001251'),
( 'EDT Nicaragua S.A', NULL, '7517-6100', 1, 'J0310000124906'),
( 'INDUSTRIAS DELMOR, S.A.', 'ventas@delmor.com.n', '2265-1378', 1, 'J0310000003718'),
( 'AJE Nicaragua S.A', 'ajedelivery.ni@ajegroup.com', '8769-9500', 1, 'J0310000021619'),
( 'LOS PAISAS, S.A.', 'info@lospaisas.com.ni', '2264-8590', 1, 'J0310000106312'),
( 'BCAR COMERCIAL , CIA LTDA', NULL, '8824-1000', 1, 'J0910000412399'),
( 'GONPER LIBRERIA S.A', NULL, '2226-3610', 1, 'J0310000001499'),
( 'LALA Nicaragua S.A', 'lala800@grupolala.com', '8120-8100', 1, 'J0310000177678');


SELECT fk.name AS FK, OBJECT_NAME(fk.parent_object_id) AS TablaHija
FROM sys.foreign_keys fk
WHERE fk.referenced_object_id = OBJECT_ID('Proveedor');

SELECT 
    fk.name AS NombreFK,
    OBJECT_SCHEMA_NAME(fk.parent_object_id) AS EsquemaHija,
    OBJECT_NAME(fk.parent_object_id) AS TablaHija,
    COL_NAME(fkc.parent_object_id, fkc.parent_column_id) AS ColumnaHija,
    COL_NAME(fkc.referenced_object_id, fkc.referenced_column_id) AS ColumnaPadre
FROM sys.foreign_keys fk
JOIN sys.foreign_key_columns fkc ON fk.object_id = fkc.constraint_object_id
WHERE fk.referenced_object_id = OBJECT_ID('Proveedor');


ALTER TABLE dbo.Compra DROP CONSTRAINT FK_Compra_Proveedor;

TRUNCATE TABLE dbo.Proveedor;

ALTER TABLE dbo.Compra ADD CONSTRAINT FK_Compra_Proveedor
    FOREIGN KEY (IdProveedor) REFERENCES dbo.Proveedor(IdProveedor);

    -- 1. Quitar la FK
ALTER TABLE dbo.Compra DROP CONSTRAINT FK_Compra_IdProveedeor;

-- 2. Vaciar las tablas (Compra primero si querés limpiar también los datos hijos)
TRUNCATE TABLE dbo.Proveedor;

-- 3. Volver a crear la FK
ALTER TABLE dbo.Compra ADD CONSTRAINT FK_Compra_IdProveedeor
    FOREIGN KEY (IdProveedor) REFERENCES dbo.Proveedor(IdProveedor);


    DECLARE @fk sysname, @sql nvarchar(max);

-- Obtener el nombre real de la FK
SELECT @fk = name
FROM sys.foreign_keys
WHERE parent_object_id = OBJECT_ID('dbo.Compra')
  AND referenced_object_id = OBJECT_ID('dbo.Proveedor');

-- 1. Quitar la FK
SET @sql = 'ALTER TABLE dbo.Compra DROP CONSTRAINT ' + QUOTENAME(@fk);
EXEC(@sql);

-- 2. Vaciar las tablas (borrá esta línea si Compra no tiene datos o querés conservarlos)
DELETE FROM dbo.Compra;
TRUNCATE TABLE dbo.Proveedor;

-- 3. Recrear la FK con el mismo nombre
SET @sql = 'ALTER TABLE dbo.Compra ADD CONSTRAINT ' + QUOTENAME(@fk) +
           ' FOREIGN KEY (IdProveedor) REFERENCES dbo.Proveedor(IdProveedor)';
EXEC(@sql);


SELECT 
    fk.name AS NombreFK,
    OBJECT_SCHEMA_NAME(fk.parent_object_id) + '.' + OBJECT_NAME(fk.parent_object_id) AS TablaHija,
    OBJECT_SCHEMA_NAME(fk.referenced_object_id) + '.' + OBJECT_NAME(fk.referenced_object_id) AS TablaReferenciada
FROM sys.foreign_keys fk
WHERE OBJECT_NAME(fk.referenced_object_id) = 'Proveedor';


DELETE FROM dbo.Compra;
DELETE FROM dbo.Proveedor;

DBCC CHECKIDENT ('dbo.Compra', RESEED, 0);
DBCC CHECKIDENT ('dbo.Proveedor', RESEED, 0);


SELECT COUNT(*) AS Proveedores FROM dbo.Proveedor;
SELECT COUNT(*) AS Compras FROM dbo.Compra;

-- La FK sigue en su lugar
SELECT name FROM sys.foreign_keys WHERE parent_object_id = OBJECT_ID('dbo.Compra');


ALTER TABLE dbo.Proveedor DROP CONSTRAINT UQ_CorreoProveedor;

CREATE UNIQUE INDEX UQ_CorreoProveedor
ON dbo.Proveedor (Correo)
WHERE Correo IS NOT NULL;


--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
--('Tortilla de Trigo MON', 'Tortilla de Trigo 1p 250g Bolsa MON', 3, 15, 26.81, 37.00, 1, GETDATE(), 5),
--('Rapiditas Wraps BIM', 'Rapiditas Wraps 1p 320g Bolsa BIM', 3, 12, 49.28, 68.00, 1, GETDATE(), 5),
--('Rapiditas Integral BIM', 'Rapiditas Integral 1p 250g Bolsa BIM', 3, 24, 37.68, 52.00, 1, GETDATE(), 5),
--('Rapiditas Clasica BIM', 'Rapiditas Clasica 1p 312g Bolsa BIM', 3, 8, 37.68, 52.00, 1, GETDATE(), 5),
--('Rapiditas Burrito BIM', 'Rapiditas Burrito 1p 250g Bolsa BIM', 3, 19, 33.33, 46.00, 1, GETDATE(), 5),
--('Rapiditas Clasicas BIM', 'Rapiditas Clasicas 1p 260g Bolsa BIM', 3, 30, 31.88, 44.00, 1, GETDATE(), 5),
--('Tortilla Tostada Plana MR', 'Tortilla Tostada Plana 1p 175g Bolsa MR', 3, 14, 36.23, 50.00, 1, GETDATE(), 5),
--('Tortilla Tostada Ondula MR', 'Tortilla Tostada Ondula 1p 360g Bolsa MR', 3, 7, 65.22, 90.00, 1, GETDATE(), 5),
--('Submarinos Fresa MAR', 'Submarinos Fresa 1p 64g Flow MAR', 3, 22, 17.39, 24.00, 1, GETDATE(), 5),
--('Submarinos Vainilla MAR', 'Submarinos Vainilla 1p 64g Flow MAR', 3, 11, 17.39, 24.00, 1, GETDATE(), 5),
--('Bimboletes Vainilla BIM', 'Bimboletes Vainilla 1p 55g Flow BIM', 3, 25, 14.49, 20.00, 1, GETDATE(), 5),
--('Pinguinos 1p MAR', 'Pinguinos 1p 80g Flow MAR', 3, 18, 25.36, 35.00, 1, GETDATE(), 5),
--('Pinguino Triple Chocola MAR', 'Pinguino Triple Chocola 1p 80g Flow MAR', 3, 9, 25.36, 35.00, 1, GETDATE(), 5),
--('Pinguinos Cookies Cream MAR', 'Pinguinos Cookies Cream 1p 80g Flow MAR', 3, 16, 25.36, 35.00, 1, GETDATE(), 5),
--('Submarino Fresa 32g MAR', 'Submarino Fresa 1p 32g Flow MAR', 3, 21, 9.42, 13.00, 1, GETDATE(), 5),
--('Submarino Vainilla 32g MAR', 'Submarino Vainilla 1p 32g Flow MAR', 3, 13, 9.42, 13.00, 1, GETDATE(), 5),
--('Mini Barritas Fresa 104g MAR', 'Mini Barritas Fresa 1p 104g Flow MAR', 10, 27, 19.57, 27.00, 1, GETDATE(), 5),
--('Mini Barritas Pina 104g MAR', 'Mini Barritas Pina 1p 104g Flow MAR', 10, 10, 20.67, 27.00, 1, GETDATE(), 5),
--('Mini Barritas Fresa 260g MAR', 'Mini Barritas Fresa 5p 260g ME MAR', 10, 6, 43.48, 60.00, 1, GETDATE(), 5),
--('Mini Barritas Fresa 312g MAR', 'Mini Barritas Fresa 6p 312g ME MAR', 10, 20, 44.93, 62.00, 1, GETDATE(), 5),
--('Canelitas 1p MAR', 'Canelitas 1p 60g Flow MAR', 10, 15, 12.32, 17.00, 1, GETDATE(), 5),
--('Sponch Fresa 1p 90g MAR', 'Sponch Fresa 1p 90g FLOW MAR EXP', 10, 28, 19.57, 27.00, 1, GETDATE(), 5),
--('Sponch Fresa 360g MAR', 'Sponch Fresa 6p 360g ME MAR', 10, 8, 68.84, 95.00, 1, GETDATE(), 5),
--('Sponch Smore 360g MAR', 'Sponch Smore 6p 360g ME MAR', 10, 17, 68.84, 95.00, 1, GETDATE(), 5),
--('Sponch Fresa 240g MAR', 'Sponch Fresa 4p 240g ME MAR', 10, 23, 49.28, 68.00, 1, GETDATE(), 5),
--('Sponch Fresa 90g MAR', 'Sponch Fresa 1p 90g FLOW MAR', 10, 12, 19.57, 27.00, 1, GETDATE(), 5),
--('Sponch Smore 90g MAR', 'Sponch Smore 1p 90g FLOW MAR', 10, 19, 19.57, 27.00, 1, GETDATE(), 5),
--('Principe Vainilla Choco MAR', 'Principe Vainilla Choco 1p 85g Flow MAR', 10, 14, 19.57, 27.00, 1, GETDATE(), 5),
--('Principe Choco Blanco MAR', 'Principe Choco Blanco 1p 85g Flow MAR', 10, 26, 19.57, 27.00, 1, GETDATE(), 5),
--('Principe Limon 1p MAR', 'Principe Limon 1p 85g Flow MAR', 10, 9, 19.57, 27.00, 1, GETDATE(), 5),
--('Principe Lemon Drops 38g MAR', 'Principe Lemon Drops 1p 38g FLOW MAR', 10, 22, 10.14, 14.00, 1, GETDATE(), 5),
--('Principe Choco Drops 38g MAR', 'Principe Choco Drops 1p 38g FLOW MAR', 10, 11, 10.14, 14.00, 1, GETDATE(), 5),
--('Principe Vainilla 210g MAR', 'Principe Vainilla 5p 210g ME MAR', 10, 25, 47.10, 65.00, 1, GETDATE(), 5),
--('Principe Choco Blanco 210g MAR', 'Principe Choco Blanco 5p 210g ME MAR', 10, 16, 47.10, 65.00, 1, GETDATE(), 5),
--('Principe Limon 210g MAR', 'Principe Limon 5p 210g ME MAR', 10, 7, 47.10, 65.00, 1, GETDATE(), 5),
--('Principe Vainilla Choco 336g MAR', 'Principe Vainilla Choco 8p 336g ME MAR', 10, 18, 69.57, 96.00, 1, GETDATE(), 5),
--('Principe Limon 336g MAR', 'Principe Limon 8p 336g ME MAR', 10, 13, 69.57, 96.00, 1, GETDATE(), 5),
--('Principe Lemon Drops 228g MAR', 'Principe Lemon Drops 6p 228g ME MAR', 10, 29, 56.52, 78.00, 1, GETDATE(), 5),
--('Principe Choco Drops 228g MAR', 'Principe Choco Drops 6p 228g ME MAR', 10, 15, 56.52, 78.00, 1, GETDATE(), 5),
--('Galleta Salmas SAN', 'Galleta Salmas 1p 144g Cja SAN', 10, 20, 50.00, 69.00, 1, GETDATE(), 5),
--('Panquecitos 100g BIM', 'Panquecitos 1p 100g Flow BIM', 3, 10, 18.12, 25.00, 1, GETDATE(), 5),
--('Panque Pasas 250g BIM', 'Panque Pasas 1p 250g Flow BIM', 3, 24, 33.33, 46.00, 1, GETDATE(), 5);


--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
---- ACEITES Y GRASAS (IdCategoria: 2)
--('Aceite Clover Soya 500 ml', 'ACEITE CLOVER SOYA 500 ML', 2, 14, 42.00, 52.00, 1, GETDATE(), 5),
--('Aceite Clover Soya 900 ml', 'ACEITE CLOVER SOYA 900 ML', 2, 22, 70.00, 86.00, 1, GETDATE(), 5),
--('Aceite Clover Soya 1.5 Lt', 'ACEITE CLOVER SOYA 1.5 LT', 2, 18, 112.00, 138.00, 1, GETDATE(), 5),
--('Aceite Clover Soya 3 Lt', 'ACEITE CLOVER SOYA 3 LT', 2, 10, 210.00, 255.00, 1, GETDATE(), 5),
--('Aceite Clover Soya 17 Lt', 'ACEITE CLOVER SOYA 17 LT', 2, 6, 1150.00, 1380.00, 1, GETDATE(), 5),
--('Aceite Clover Girasol 500 ml', 'ACEITE CLOVER GIRASOL 500 ML', 2, 12, 46.00, 58.00, 1, GETDATE(), 5),
--('Aceite Clover Girasol 900 ml', 'ACEITE CLOVER GIRASOL 900 ML', 2, 11, 78.00, 96.00, 1, GETDATE(), 5),
--('Aceite Clover Girasol 3 Lt', 'ACEITE CLOVER GIRASOL 3 LT', 2, 7, 230.00, 280.00, 1, GETDATE(), 5),
--('Aceite Clover Frituras 500 ml', 'ACEITE CLOVER FRITURAS 500 ML', 2, 19, 40.00, 50.00, 1, GETDATE(), 5),
--('Aceite Clover Frituras 900 ml', 'ACEITE CLOVER FRITURAS 900 ML', 2, 25, 66.00, 82.00, 1, GETDATE(), 5),
--('Aceite Clover Frituras 1.5 Lt', 'ACEITE CLOVER FRITURAS 1.5 LT', 2, 15, 105.00, 130.00, 1, GETDATE(), 5),
--('Aceite Clover Frituras 3 Lt', 'ACEITE CLOVER FRITURAS 3 LT', 2, 8, 195.00, 240.00, 1, GETDATE(), 5),
--('Aceite Palma Comestible Clover Libra', 'ACEITE PALMA C. CLOVER LIBRA', 2, 20, 32.00, 40.00, 1, GETDATE(), 5),
--('Aceite D''Orofrit 17 Lt', 'ACEITE DOROFRIT 17 LT', 2, 5, 1100.00, 1320.00, 1, GETDATE(), 5),
--('Aceite Corona Litro', 'ACEITE CORONA LITRO', 2, 29, 65.00, 80.00, 1, GETDATE(), 5),
--('Aceite Corona 1/2 Galón', 'ACEITE CORONA 1/2 GALON', 2, 14, 120.00, 148.00, 1, GETDATE(), 5),
--('Aceite Corona Galón', 'ACEITE CORONA GALON', 2, 8, 230.00, 275.00, 1, GETDATE(), 5),
--('Aceite Palma Maxpan Libra', 'ACEITE PALMA C. MAXPAN LIBRA', 2, 21, 30.00, 38.00, 1, GETDATE(), 5),
--('Aceite Palma Maxpan 2 Lbs', 'ACEITE PALMA C. MAXPAN 2 LBS', 2, 16, 58.00, 72.00, 1, GETDATE(), 5),
--('Margarina Numar Barra 1/2', 'MARGARINA NUMAR 1/2 BARRA 1X12', 2, 24, 22.00, 28.00, 1, GETDATE(), 5),
--('Margarina Numar Barra 400g', 'MARG. NUMAR BARRA 400GR 1X24', 2, 25, 45.00, 56.00, 1, GETDATE(), 5),
--('Margarina Numar Taste Barra', 'MARG. NUMAR BARRA TASTE 1X24X4', 2, 13, 48.00, 60.00, 1, GETDATE(), 5),
--('Margarina Numar Sin Taste 425g', 'MARG. NUMAR S/ TASTE 425 GR', 2, 18, 50.00, 62.00, 1, GETDATE(), 5),
--('Margarina Good Living Oliva 452g', 'MARGARINA GOOD LIVING 452 GRS', 2, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Margarina Good Living Butter 450g', 'MARG. GOOD LIVING BUTTER 450G', 2, 15, 62.00, 76.00, 1, GETDATE(), 5),
--('Margarina Numar Light 500g', 'MARG. NUMAR BARRA LIGHT 500 GR', 2, 11, 55.00, 68.00, 1, GETDATE(), 5),
--('Margarina Numar Suave 450g', 'MARG. NUMAR SUAVE 450 GR 1X24', 2, 16, 52.00, 65.00, 1, GETDATE(), 5),
--('Margarina Numar Suave 250g', 'MARG. NUMAR SUAVE 250 GR 1X24', 2, 22, 30.00, 38.00, 1, GETDATE(), 5),
--('Margarina Numar Suave 3 Lbs', 'MARG. NUMAR SUAVE 3 LBS 1X12', 2, 7, 145.00, 180.00, 1, GETDATE(), 5),
--('Margarina Numar Ajo y Perejil 200g', 'MARG. NUMAR SUAVE C/AJO 200 GRS', 2, 19, 32.00, 40.00, 1, GETDATE(), 5),

---- HARINAS Y PANADERÍA INDUSTRIAL (IdCategoria: 3)
--('Aceite Palma Maxpan Bulk', 'ACEITE PALMA C. MAXPAN BULK', 3, 5, 850.00, 1020.00, 1, GETDATE(), 5),
--('Margarina Baker Clásica 20lb', 'MARG. BAKER CLASICA (20LB)', 3, 10, 520.00, 620.00, 1, GETDATE(), 5),
--('Margarina Baker Clásica 30lbs', 'MARG. BAKER CLAS (6X5) CJ 30LBS', 3, 8, 780.00, 930.00, 1, GETDATE(), 5),
--('Margarina Baker Compuesta 20lb', 'MARG. BAKER COMP. (20LB)', 3, 12, 510.00, 610.00, 1, GETDATE(), 5),
--('Margarina Baker Hojaldre 17.6lb', 'MARG. BAKER HOJALDRE (17.6LB)', 3, 6, 580.00, 690.00, 1, GETDATE(), 5),
--('Margarina Baker Batido 30lbs', 'MARGARINA BAKER BATIDO (30 LBS)', 3, 7, 790.00, 940.00, 1, GETDATE(), 5),
--('Harina Goldstar Pastelera 25lb', 'HARINA GOLDSTAR 25LB PASTELERA', 3, 7, 340.00, 410.00, 1, GETDATE(), 5),
--('Margarina Super Star Multiuso 20lb', 'MARG. MULTI USO SUPER STAR 20LB', 3, 9, 530.00, 635.00, 1, GETDATE(), 5),

---- DULCES Y CONFITERÍA / REPOSTERÍA (IdCategoria: 11)
--('Dulce de Leche Del Llano 1 kg', 'DULCE DE LECHE DEL LLANO 1 KG 1X10U', 11, 14, 130.00, 160.00, 1, GETDATE(), 5),
--('Dulce de Leche Del Llano 5 kg', 'DULCE DE LECHE DEL LLANO 5 KG 1X1U', 11, 4, 580.00, 700.00, 1, GETDATE(), 5),
--('Mermelada de Piña Riquísima 44lb', 'MERMELADA PINA RIQUISIMA 44LB', 11, 5, 850.00, 1020.00, 1, GETDATE(), 5),

---- CAFÉ Y BEBIDAS (IdCategoria: 6 y 7)
--('Café Instantáneo 1820 Pack 50g', 'CAFE INST-1820 PACK 50GR', 6, 26, 35.00, 45.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 50g', 'CAFE INST. 1820 FCO 50 GR', 6, 20, 60.00, 75.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 100g', 'CAFE INST. 1820-FCO.100 GR', 6, 22, 110.00, 135.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 150g', 'CAFE INST. 1820 FCO 150 GR', 6, 17, 155.00, 190.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 250g', 'CAFE INST. 1820 FCO 250 GR', 6, 10, 240.00, 290.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 400g', 'CAFE INST. 1820 FCO 400 GR', 6, 8, 380.00, 460.00, 1, GETDATE(), 5),
--('Café 1820 Tradicional 2g (80s)', 'CAFE 1820 TRADICIONAL 2GR (80)', 6, 15, 140.00, 175.00, 1, GETDATE(), 5),
--('Café 1820 Tradicional 2g (40s)', 'CAFE 1820 TRADICIONAL 2GR (40)', 6, 18, 75.00, 95.00, 1, GETDATE(), 5),
--('Café 1820 Tradicional Fco 250g', 'CAFE 1820 TRADICIONAL FCO 250 GR', 6, 12, 210.00, 260.00, 1, GETDATE(), 5),
--('Café 1820 Liofilizado 85g', 'CAFE INST. 1820 LIOFILIZADO 85 GR', 6, 14, 130.00, 160.00, 1, GETDATE(), 5),
--('Café Capuccino 1820 120g', 'CAFE CAPUCCINO INST. 1820 120 GR', 6, 13, 85.00, 105.00, 1, GETDATE(), 5),
--('Café Capuccino Vainilla 120g', 'CAFE1820 CAPUCCIN VAINILLA 120 GR', 6, 11, 85.00, 105.00, 1, GETDATE(), 5),
--('Café Mokaccino 1820 120g', 'CAFE MOKACCINO INST. 1820 120 GR', 6, 16, 85.00, 105.00, 1, GETDATE(), 5),
--('Café Frozen Cappuccino 1820 120g', 'CAFE INST. FROZEN CAPUCCINO 1820 120 GR', 6, 9, 90.00, 110.00, 1, GETDATE(), 5),
--('Café Molido 1820 Paq 200g', 'CAFE MOLIDO 1820 PAQ 200GR', 6, 24, 75.00, 92.00, 1, GETDATE(), 5),
--('Café Molido 1820 Paq 400g', 'CAFE MOLIDO 1820 PAQ. 400 GR', 6, 19, 145.00, 180.00, 1, GETDATE(), 5),
--('Café D''Oro Molido 25g', 'CAFE MOLIDO D''ORO 25 GR (40X12)', 6, 28, 10.00, 13.00, 1, GETDATE(), 5),
--('Café Molido 1820 Reserva Especial 340g', 'CAFE MOLIDO 1820 RES ESP 340GR', 6, 10, 180.00, 220.00, 1, GETDATE(), 5),
--('Pinolillo Campestre 42g', 'PINOLILLO CAMPESTRE 42GR 48X10', 7, 26, 8.50, 12.00, 1, GETDATE(), 5),

---- EMPAQUES, PAPEL Y DESECHABLES (IdCategoria: 19)
--('Papel Aluminio Link 25 ft', 'PAPEL ALUMINIO LINK 1X24 25 FT', 19, 17, 45.00, 58.00, 1, GETDATE(), 5),
--('Papel Aluminio Link 50 ft', 'PAPEL ALUMINIO LINK 1X24 50 FT', 19, 15, 80.00, 100.00, 1, GETDATE(), 5),
--('Papel Aluminio Link 75 ft', 'PAPEL ALUMINIO LINK 1X24 75 FT', 19, 11, 115.00, 142.00, 1, GETDATE(), 5),
--('Papel Aluminio Link Económico 25 ft', 'PAPEL ALUMINIO LINK ECONOMICO 1X24 25 FT', 19, 21, 38.00, 48.00, 1, GETDATE(), 5),
--('Plástico Adhesivo Link 100 ft', 'PLASTIC ADHESIVO LINK 100F1X24', 19, 13, 50.00, 65.00, 1, GETDATE(), 5),
--('Plástico Adhesivo Link 200 ft', 'PLASTIC ADHESIVO LINK 200F1X12', 19, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Plástico Adhesivo Link 2000 ft', 'PLASTIC ADHESIVO LINK 2000F1X4', 19, 5, 450.00, 540.00, 1, GETDATE(), 5),
--('Papel Aluminio Industrial Link 500 (12")', 'PAPEL ALUM LINK 1X4X500(12)', 19, 4, 380.00, 460.00, 1, GETDATE(), 5),
--('Papel Aluminio Industrial Link 500 (18")', 'PAPEL ALUM LINK 1X4X500(18)', 19, 3, 520.00, 630.00, 1, GETDATE(), 5),
--('Vasos Link #05 (Pack)', 'VASOS LINK #05', 19, 20, 35.00, 45.00, 1, GETDATE(), 5),
--('Vasos Link #08 (Pack)', 'VASOS LINK # 08', 19, 22, 40.00, 52.00, 1, GETDATE(), 5),
--('Vasos Link #12 (Pack)', 'VASOS LINK # 12', 19, 18, 50.00, 64.00, 1, GETDATE(), 5),
--('Cucharas Grandes Link (Pack)', 'CUCHILLOS GRANDES LINK', 19, 16, 28.00, 36.00, 1, GETDATE(), 5),
--('Platos Link #07 (Pack)', 'PLATOS LINK #07', 19, 25, 42.00, 54.00, 1, GETDATE(), 5),
--('Plato Térmico #9 C/Div Link', 'PLATO TERMICO #9 LINK C/DIV', 19, 18, 55.00, 70.00, 1, GETDATE(), 5),
--('Contenedor Termis 9x9 C/D', 'CONTENEDOR LINK (9X9) C/D', 19, 10, 85.00, 108.00, 1, GETDATE(), 5),
--('Bolsas Basura Lympac Mediana', 'BOLSA OLYMPIC NEG. MEDIANA', 19, 22, 32.00, 42.00, 1, GETDATE(), 5),
--('Bolsas Rollo Basura Lympac Grande', 'BOLSAS ROLLO NEGRA BASURA LYMPAC GRANDE', 19, 14, 75.00, 95.00, 1, GETDATE(), 5),

---- ADEREZOS Y SALSAS (IdCategoria: 15)
--('Aderezo César Campestre 200g', 'SALSA C/ADEREZO CESAR 200GR', 15, 18, 38.00, 48.00, 1, GETDATE(), 5),
--('Aderezo Italiano Campestre 200g', 'SALSA C/ADEREZO ITALIANO 200GR', 15, 16, 38.00, 48.00, 1, GETDATE(), 5),
--('Aderezo Ranch Campestre 200g', 'SALSA C/ADEREZO RANCH 200GR', 15, 17, 38.00, 48.00, 1, GETDATE(), 5),
--('Aderezo Chipotle Campestre 200g', 'ADEREZO SABOR CHIPOTLE 200GR', 15, 23, 38.00, 48.00, 1, GETDATE(), 5),
--('Salsa Rosada Campestre 200g', 'SALSA C/ADEREZO ROSADA 200GR', 15, 19, 38.00, 48.00, 1, GETDATE(), 5),
--('Salsa de Tomate Special Galón', 'SALSA DE TOMATE GALON 1X6', 15, 9, 160.00, 195.00, 1, GETDATE(), 5),
--('Salsa de Tomate Special Litro', 'SALSA DE TOMATE LITRO 1X16', 15, 20, 42.00, 54.00, 1, GETDATE(), 5),
--('Salsa Pasta/Pizza Special 480g', 'SALSA PASTA/PIZZA 480GR 1X24', 15, 15, 40.00, 50.00, 1, GETDATE(), 5),
--('Salsa Barbacoa Special 480g', 'SALSA BARBACOA 480GR 1X24', 15, 14, 45.00, 58.00, 1, GETDATE(), 5),
--('Salsa Búfalo Special 480g', 'SALSA BUFALO 480GR 1X24', 15, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Salsa Inglesa Special Litro', 'SALSA INGLESA LITRO 1X16', 15, 15, 45.00, 58.00, 1, GETDATE(), 5),
--('Salsa China Special Litro', 'SALSA CHINA LITRO 1X16', 15, 13, 45.00, 58.00, 1, GETDATE(), 5),
--('Vinagre Blanco Rey Galón', 'VINAGRE BLANCO REY GALON 1X6', 15, 12, 85.00, 105.00, 1, GETDATE(), 5),
--('Vinagre Blanco Rey 12 Onz', 'VINAGRE BLANCO REY 12 ONZ 1X24', 15, 25, 15.00, 20.00, 1, GETDATE(), 5),
--('Vainilla Rey 12 Onz', 'VAINILLA REY 12 ONZ 1X24', 15, 22, 18.00, 24.00, 1, GETDATE(), 5),

---- PAPEL HIGIÉNICO Y TOALLAS DE COCINA (IdCategoria: 18 y 24)
--('Papel Higiénico Nevax ExtraMás 4s', 'PH NEVAX EXTRAMAS 12X4 1000HS', 24, 20, 95.00, 118.00, 1, GETDATE(), 5),
--('Papel Higiénico Nevax Luxury 4s', 'PH NEVAX LUXURY 10X4 250 HT', 24, 16, 110.00, 136.00, 1, GETDATE(), 5),
--('Papel Higiénico Nevax Cuidado Suave 4s', 'PH NEVAX CUIDADO SUAVE 4X12 350 HD', 24, 18, 98.00, 122.00, 1, GETDATE(), 5),
--('Papel Higiénico Nevax Practimás 4s', 'PH NEVAX PRACTIMAS 12X4 220HD', 24, 22, 75.00, 94.00, 1, GETDATE(), 5),
--('Papel Higiénico Nevax Rendidor 4s', 'PH NEVAX RENDIDOR 12X4S1000H', 24, 25, 85.00, 105.00, 1, GETDATE(), 5),
--('Papel Higiénico Nevax Maxi Resist 4s', 'PH NEVAX MAXI RESIST 10X4400HD', 24, 19, 102.00, 126.00, 1, GETDATE(), 5),
--('Toalla de Cocina Nevax Ultra Absorb 1s', 'TOALLA ULTRA ABSORB 170HD12X1S', 18, 14, 38.00, 48.00, 1, GETDATE(), 5),
--('Toalla de Cocina Nevax Uso Rudo 1s', 'TOALLANEVAX USORUDO 60HT 1X12s', 18, 13, 40.00, 50.00, 1, GETDATE(), 5),
--('Toalla de Cocina Nevax Prácticas 2s', 'TOALLA COCINA NEVAX 85 HD 24X1s', 18, 21, 35.00, 45.00, 1, GETDATE(), 5),
--('Servilletas Nevax Cuadradas 100s', 'SERV. NEVAX CUADRADA 100 HS', 18, 25, 22.00, 28.00, 1, GETDATE(), 5),

---- CUIDADO FEMENINO Y ADULTO (IdCategoria: 23)
--('Toallitas Saba Ultra Delgada c/Alas 10s', 'SAB ULTR DEL NORM C/A16X10 SMO', 23, 26, 42.00, 54.00, 1, GETDATE(), 5),
--('Toallitas Saba Buenas Noches c/Alas 8s', 'SABA BUENAS NOCHES C/A 24X8', 23, 24, 55.00, 70.00, 1, GETDATE(), 5),
--('Toallitas Saba Confort Manzanilla 10s', 'SABA CONFORM RG. C/A 10X10 SMT', 23, 20, 38.00, 48.00, 1, GETDATE(), 5),
--('Toallitas Saba Clásica Reg. 10s', 'SABA CLASICA NEW AGE C/A 24X10', 23, 28, 30.00, 38.00, 1, GETDATE(), 5),
--('Protectores Diarios Saba Multiestilos 40s', 'P.D SAB MULTI ESTILO REG 28X40', 23, 19, 68.00, 85.00, 1, GETDATE(), 5),
--('Protectores Diarios Saba Tradicional Reg. 16s', 'SABA PROTECTOR REG (16) 24X16', 23, 21, 28.00, 36.00, 1, GETDATE(), 5),
--('Jabón Íntimo Saba V-Natural 200ml', 'SAB JABON INT V-NAT 1X12 200ML', 23, 15, 110.00, 138.00, 1, GETDATE(), 5),
--('Toallitas Húmedas Saba V-Natural 12s', 'TO ALLAS HUMEDAS SABA 48X12S', 23, 22, 25.00, 32.00, 1, GETDATE(), 5),
--('Tena Lady Normal 10s', 'TENA LADY NORMAL 12X10', 23, 12, 120.00, 148.00, 1, GETDATE(), 5),
--('Pañal Adulto Tena Pants Comfort G 8s', 'PANAL TENA PANT COMFORT G 12X8', 23, 9, 280.00, 345.00, 1, GETDATE(), 5),
--('Pañal Adulto Tena Slip Maxiprotect G 10s', 'TENA SLIP MAXI PROTECT G 6X10', 23, 8, 260.00, 320.00, 1, GETDATE(), 5),
--('Toallitas Húmedas Tena Adulto 40s', 'TO ALLAS TENA ADULTO 12X40', 23, 14, 95.00, 120.00, 1, GETDATE(), 5),

---- LIMPIEZA HOGAR Y LAVANDERÍA (IdCategoria: 17 y 18)
--('Suavizante Ensueño Primavera 850ml', 'ENSUEÑO MAX FRESC PRIM 850 ML', 17, 21, 48.00, 60.00, 1, GETDATE(), 5),
--('Jabón Doña Reyna 400g', 'JABÓN DOÑA REYNA 400 GR 1X6U', 18, 30, 20.00, 26.00, 1, GETDATE(), 5),
--('Desinfectante Pinol Original 500ml', 'PINOL ORIGINAL 500 ML', 18, 28, 35.00, 45.00, 1, GETDATE(), 5),
--('Desinfectante Pinol Lavanda 828ml', 'PINOL AROMA LAVANDA 828 ML', 18, 16, 52.00, 65.00, 1, GETDATE(), 5),

---- ESPECIAS, SAZONADORES Y OTROS (IdCategoria: 16)
--('Empanizador Pollo Los Patitos 60g', 'EMPANIZADOR POLLO RT 60 GR', 16, 25, 16.00, 22.00, 1, GETDATE(), 5),
--('Empanizador Multiuso Los Patitos 50g', 'EMPANIZADOR MULTIUSO 50GR 1X20', 16, 20, 15.00, 20.00, 1, GETDATE(), 5),
--('Miga de Pan Los Patitos 100g', 'MIGA DE PAN LOS PATITOS 100 GRS 1X24', 16, 18, 20.00, 26.00, 1, GETDATE(), 5),
--('Achiote Líquido Los Patitos 240ml', 'ACHIOTE LIQUIDO 240ML 1X24', 16, 22, 30.00, 38.00, 1, GETDATE(), 5),
--('Achiote en Pasta Los Patitos 90g', 'ACHIOTE PASTA 90G 1X48', 16, 27, 18.00, 25.00, 1, GETDATE(), 5),
--('Pasta de Ajo Los Patitos 90g', 'PASTA DE AJO 90GR 1X48', 16, 29, 24.00, 32.00, 1, GETDATE(), 5),
--('Consomé de Pollo Los Patitos 200g', 'CONSOME POLLO 200GR 1X24', 16, 19, 32.00, 42.00, 1, GETDATE(), 5),
--('Puré de Papa Los Patitos 100g', 'PURE DE PAPA 100 GR 1X12', 16, 15, 28.00, 36.00, 1, GETDATE(), 5),
--('Esencia Hermel Vainilla Blanca 1L', 'ESENCIA HERMEL VAINILLA BLANCA 1 lt', 16, 11, 75.00, 95.00, 1, GETDATE(), 5),
--('Polvo para Hornear Hermel 227g', 'POLVO PARA HORNEAR HERMEL 227g 1 x 12 U', 16, 24, 35.00, 45.00, 1, GETDATE(), 5);




--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
---- ===================================================
---- CATEGORÍA 1: Granos básicos
---- ===================================================
--('Arroz Tío Pelón 80/20 100lb', 'ARROZ TIO PELON 80/20 QUINTAL', 1, 12, 1200.00, 1380.00, 1, GETDATE(), 5),
--('Arroz Doña María 80/20 100lb', 'ARROZ DONA MARIA 80/20 QUINTAL', 1, 15, 1250.00, 1420.00, 1, GETDATE(), 5),
--('Arroz Don José 96% Super Entero', 'ARROZ DON JOSE 96% ENTERO QUINTAL', 1, 10, 1350.00, 1520.00, 1, GETDATE(), 5),
--('Arroz Don Carlos 96/4 100lb', 'ARROZ DON CARLOS 96/4 QUINTAL', 1, 8, 1320.00, 1500.00, 1, GETDATE(), 5),
--('Azúcar Monte Rosa 400g', 'AZUCAR MONTE ROSA 400 GR', 1, 28, 12.00, 16.00, 1, GETDATE(), 5),
--('Azúcar Sulfitada Caballo Negro 1lb', 'AZUCAR SULFITADA CABALLO NEGRO 1LB', 1, 22, 13.00, 17.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 2: Aceites y grasas
---- ===================================================
--('Mantequilla La Perfecta Barra 400g', 'MANTEQUILLA LA PERFECTA 400 GR', 2, 18, 55.00, 68.00, 1, GETDATE(), 5),
--('Margarina Cremy Barra 400g', 'MARGARINA CREMY VEGETAL 400 GR', 2, 20, 38.00, 48.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 3: Harinas y panadería
---- ===================================================
--('Maseca Harina de Maíz 1lb', 'MASECA HARINA DE MAIZ 1LB', 3, 25, 16.00, 21.00, 1, GETDATE(), 5),
--('Harina de Trigo Bollo Fino 2kg', 'HARINA DE TRIGO BOLLO FINO 2 KG', 3, 15, 52.00, 65.00, 1, GETDATE(), 5),
--('Harina de Trigo Bollo Fino 453g', 'HARINA DE TRIGO BOLLO FINO 453 GRS', 3, 20, 15.00, 20.00, 1, GETDATE(), 5),
--('Levadura Nevada Oro 450g', 'LEVADURA NEVADA ORO 450 gr 1x20 U', 3, 27, 115.00, 140.00, 1, GETDATE(), 5),
--('Levadura Saf-Instant Roja 500g', 'LEVADURA SAF INSTANT ROJA 500 gr 1 x 20 U', 3, 21, 125.00, 150.00, 1, GETDATE(), 5),
--('Levadura Tradipan 55g', 'LEVADURA TRADIPAN 55 gr 1 x 56 U', 3, 30, 22.00, 28.00, 1, GETDATE(), 5),
--('Mejorador Fortilix 440g', 'MEJORADOR PANIFICACION FORTILIX 440 gr', 3, 15, 95.00, 118.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 4: Lácteos y derivados
---- ===================================================
--('Leche Entera Eskimo Bolsita 450ml', 'LECHE ENTERA ESKIMO UHT 450 ML', 4, 24, 22.00, 28.00, 1, GETDATE(), 5),
--('Leche Saborizada Eskimo Fresa 400ml', 'LECHE ESKIMO SABOR FRESA 400 ML', 4, 19, 20.00, 25.00, 1, GETDATE(), 5),
--('Leche Eskimo Chocolits 200ml', 'LECHE ESKIMO CHOCOLITS 200 ML', 4, 26, 14.00, 18.00, 1, GETDATE(), 5),
--('Leche Shaka Laka Cajita Surtida', 'LECHE SHAKA LAKA CAJITA 24 UDS', 4, 15, 180.00, 225.00, 1, GETDATE(), 5),
--('Leche Eskimo Cajita Surtido 24s', 'LECHE ESKIMO CAJITA SURTIDO 24 UDS', 4, 12, 190.00, 235.00, 1, GETDATE(), 5),
--('Crema Ácida La Perfecta 420g', 'CREMA LA PERFECTA 100% NICA 420 GR', 4, 22, 32.00, 40.00, 1, GETDATE(), 5),
--('Yoghurt Nutri Lety Fresa 105g', 'YOGHURT NUTRI LETY FRESA 105 GR', 4, 17, 12.00, 16.00, 1, GETDATE(), 5),
--('Leche Nido FortiGrow 200g', 'LECHE EN POLVO NIDO FORTIGROW 200G', 4, 11, 65.00, 80.00, 1, GETDATE(), 5),
--('Cereal Infantil Nestum 200g', 'CEREAL INFANTIL NESTUM SURTIDO 200G', 4, 14, 45.00, 58.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 6: Gaseosas y jugos
---- ===================================================
--('Big Cola 360ml Pack 24', 'BIG COLA BOTELLA 360 ML PACK 24', 6, 11, 190.00, 240.00, 1, GETDATE(), 5),
--('Big Cola 500ml Pack 24', 'BIG COLA BOTELLA 500 ML PACK 24', 6, 14, 230.00, 288.00, 1, GETDATE(), 5),
--('Big Cola 2 Litros', 'BIG COLA BOTELLA 2 LITROS', 6, 18, 38.00, 48.00, 1, GETDATE(), 5),
--('Cfrut Citrus Punch 500ml Pack 12', 'CFRUT BOTELLA 500 ML PACK 12', 6, 16, 110.00, 140.00, 1, GETDATE(), 5),
--('Jugo Pulp Manzana 360ml Pack 6', 'JUGO PULP MANZANA 360 ML PACK 6', 6, 12, 95.00, 120.00, 1, GETDATE(), 5),
--('Jugo Pulp Melocotón 145ml', 'JUGO PULP MELOCOTON 145 ML', 6, 28, 10.00, 14.00, 1, GETDATE(), 5),
--('Tampico Citrus Punch 250ml', 'REFRESCO TAMPICO 250 ML', 6, 30, 12.00, 16.00, 1, GETDATE(), 5),
--('Coca-Cola 1 Lt Pack 12', 'COCA COLA 1 LITRO PACK 12 BOTELLAS', 6, 9, 360.00, 430.00, 1, GETDATE(), 5),
--('Coca-Cola 3 Litros', 'COCA COLA BOTELLA 3 LITROS', 6, 13, 75.00, 92.00, 1, GETDATE(), 5),
--('Té Helado Fuze Tea Limón 2L', 'FUZE TEA HELADO LIMON 2 LTS', 6, 11, 48.00, 60.00, 1, GETDATE(), 5),
--('Jugo Hi-C Del Valle Manzana 250ml', 'DEL VALLE HI-C MANZANA 250 ML', 6, 24, 12.00, 16.00, 1, GETDATE(), 5),
--('Refresco Del Valle Cítricos 1.5L', 'REFRESCO DEL VALLE CITRICOS 1.5L', 6, 15, 30.00, 38.00, 1, GETDATE(), 5),
--('Gaseosa Super Limón 2L', 'GASEOSA SUPER SABOR LIMON 2 LTS', 6, 17, 28.00, 35.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 7: Agua y refrescos
---- ===================================================
--('Agua Bio Aloe 500ml Pack 6', 'BIO ALOE VERA 500 ML PACK 6', 7, 10, 120.00, 150.00, 1, GETDATE(), 5),
--('Pinolillo SaSa 380g', 'PINOLILLO SASA SABOR Y SALUD 380 GR', 7, 21, 28.00, 35.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 8: Energizantes e isotónicos
---- ===================================================
--('Volt Energizante Ponche 625ml Pack 12', 'VOLT PONCHE DE FRUTAS 625 ML PACK 12', 8, 15, 210.00, 260.00, 1, GETDATE(), 5),
--('Volt Ginseng 300ml', 'VOLT ENERGIZANTE GINSENG 300 ML', 8, 20, 18.00, 24.00, 1, GETDATE(), 5),
--('Sporade / Porade Bebida Hidratante', 'SPORADE BEBIDA DEPORTIVA SURTIDA', 8, 22, 22.00, 28.00, 1, GETDATE(), 5),
--('Raptor Energizante 600ml', 'RAPTOR BEBIDA ENERGIZANTE 600 ML', 8, 19, 25.00, 32.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 9: Snacks saladas
---- ===================================================
--('Ziba''s Palitos de Papas Yummies', 'ZIBAS PALITOS DE PAPAS YUMMIES', 9, 21, 10.00, 14.00, 1, GETDATE(), 5),
--('Ranchitas Queso Yummies', 'SNACK RANCHITAS SABOR QUESO', 9, 25, 12.00, 16.00, 1, GETDATE(), 5),
--('Ranchitas Naturales Yummies', 'SNACK RANCHITAS NATURALES', 9, 18, 12.00, 16.00, 1, GETDATE(), 5),
--('Taqueritos Fuego Yummies', 'SNACK TAQUERITOS SABOR FUEGO', 9, 24, 12.00, 16.00, 1, GETDATE(), 5),
--('Chicharrones Del Rancho Prensitas', 'CHICHARRONES DEL RANCHO PRENSITAS', 9, 16, 15.00, 20.00, 1, GETDATE(), 5),
--('Zambos Ceviche Yummies', 'PLÁTANOS ZAMBOS SABOR CEVICHE', 9, 19, 14.00, 18.00, 1, GETDATE(), 5),
--('Diana Max Quesitos 35g', 'SNACK DIANA MAX QUESITOS', 9, 28, 8.00, 12.00, 1, GETDATE(), 5),
--('Diana Max Churritos', 'SNACK DIANA MAX CHURRITOS', 9, 22, 8.00, 12.00, 1, GETDATE(), 5),
--('Diana Max Jalapeños', 'SNACK DIANA MAX JALAPENOS', 9, 20, 8.00, 12.00, 1, GETDATE(), 5),
--('Diana Toztecas Original', 'SNACK DIANA TOZTECAS ORIGINAL', 9, 17, 10.00, 14.00, 1, GETDATE(), 5),
--('Diana Mani con Sal', 'DIANA MANI CON SAL SOBRE', 9, 26, 7.00, 10.00, 1, GETDATE(), 5),
--('Frijoli Chips Tortillitas 100g', 'FRIJOLI CHIPS TORTILLITAS CON FRIJOL', 9, 15, 18.00, 24.00, 1, GETDATE(), 5),
--('Kitos Megachicharra Chilimón', 'KITOS MEGACHICHARRA CHILIMON', 9, 14, 12.00, 16.00, 1, GETDATE(), 5),
--('Quesi Trix con Chile Envdal', 'QUESI TRIX CON CHILE SNACK', 9, 21, 10.00, 14.00, 1, GETDATE(), 5),
--('Papasitas con Queso Envdal', 'PAPASITAS SABOR A QUESO', 9, 19, 12.00, 16.00, 1, GETDATE(), 5),
--('Tortichips Jalapeño Tronix', 'TORTICHIPS TRONIX JALAPENO', 9, 18, 12.00, 16.00, 1, GETDATE(), 5),
--('Tortichips Limón Tronix', 'TORTICHIPS TRONIX LIMON', 9, 20, 12.00, 16.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 10: Galletas
---- ===================================================
--('Galletas Club Max Gama 12s', 'GALLETAS CLUB MAX GAMA PACK 12', 10, 16, 42.00, 52.00, 1, GETDATE(), 5),
--('Galletas Oreo Original Paq 10s', 'GALLETAS OREO ORIGINAL PAQ 10 UDS', 10, 22, 55.00, 70.00, 1, GETDATE(), 5),
--('Galletas Ritz Sandwich Queso 204g', 'GALLETAS RITZ SANDWICH QUESO 204G', 10, 14, 45.00, 58.00, 1, GETDATE(), 5),
--('Galletas Waffle Fresa / Vainilla', 'GALLETAS WAFFLE SABORES SURTIDOS', 10, 25, 12.00, 16.00, 1, GETDATE(), 5),
--('Galletas Chiky Chocolate Paq', 'GALLETAS CHIKY CHOCOLATE PACK', 10, 18, 38.00, 48.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 11: Dulces y confitería
---- ===================================================
--('Caramelos Bianchi Chocolate 100s', 'CARAMELO BIANCHI RELLENO CHOCOLATE 100U', 11, 15, 65.00, 82.00, 1, GETDATE(), 5),
--('Caramelos Bianchi Chocolate Blanco 100s', 'CARAMELO BIANCHI CHOCOLATE BLANCO 100U', 11, 12, 65.00, 82.00, 1, GETDATE(), 5),
--('Caramelos Chiclín Cereza 100s', 'CONFITES CHICLIN CEREZA 100 UDS', 11, 20, 50.00, 65.00, 1, GETDATE(), 5),
--('Caramelos Chiclín Menta 100s', 'CONFITES CHICLIN MENTA 100 UDS', 11, 18, 50.00, 65.00, 1, GETDATE(), 5),
--('Paletas Tipitín Corazón 24s', 'PALETAS TIPITIN CORAZON 24 UDS', 11, 16, 45.00, 58.00, 1, GETDATE(), 5),
--('Bon Bon Bum Fresa 24s', 'CHUPETES BON BON BUM FRESA 24 UDS', 11, 22, 55.00, 70.00, 1, GETDATE(), 5),
--('Gelitos Malvaviscos Napolitano', 'GELITOS MALVAVISCOS MARSHMALLOWS', 11, 17, 35.00, 45.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 12: Enlatados
---- ===================================================
--('Atún Gaviota Trozitos Aceite 100g', 'ATUN GAVIOTA LOMO EN TROZOS ACEITE', 12, 23, 28.00, 36.00, 1, GETDATE(), 5),
--('Sardina La Sirena Salsa Tomate 155g', 'SARDINAS LA SIRENA EN TOMATE 155G', 12, 25, 25.00, 32.00, 1, GETDATE(), 5),
--('Sardina La Sirena Pica Pica 425g', 'SARDINAS LA SIRENA PICA PICA 425G', 12, 14, 58.00, 72.00, 1, GETDATE(), 5),
--('Compota Gaga Manzana Pouch', 'COMPOTA GAGA MANZANA POUCH', 12, 24, 18.00, 24.00, 1, GETDATE(), 5),
--('Compota Gaga Pera Pouch', 'COMPOTA GAGA PERA POUCH', 12, 20, 18.00, 24.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 14: Sopas instantáneas
---- ===================================================
--('Sopa Maruchan Pollo Vaso 64g', 'MARUCHAN INSTANT LUNCH POLLO 64G', 14, 30, 18.00, 24.00, 1, GETDATE(), 5),
--('Sopa Maruchan Camarón y Chile Vaso', 'MARUCHAN INSTANT LUNCH CAMARON CHILE', 14, 25, 18.00, 24.00, 1, GETDATE(), 5),
--('Sopa Maruchan Ramen Pollo Sobre', 'MARUCHAN RAMEN SABOR POLLO SOBRE', 14, 28, 12.00, 16.00, 1, GETDATE(), 5),
--('Sopa Maruchan Ramen Camarón Sobre', 'MARUCHAN RAMEN SABOR CAMARON SOBRE', 14, 24, 12.00, 16.00, 1, GETDATE(), 5),
--('Sopa Laky Men Pollo Sobre 80g', 'SOPA LAKY MEN POLLO SOBRE 80 GR', 14, 26, 10.00, 14.00, 1, GETDATE(), 5),
--('Sopa Laky Men Camarón Sobre 80g', 'SOPA LAKY MEN CAMARON SOBRE 80 GR', 14, 22, 10.00, 14.00, 1, GETDATE(), 5),
--('Sopa Vaso Maruka Surtida', 'SOPA INSTANTANEA MARUKA VASO', 14, 18, 15.00, 20.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 15: Salsas y aderezos
---- ===================================================
--('Salsa de Tomate Rey Litro', 'SALSA DE TOMATE REY LITRO 1X16', 15, 22, 38.00, 48.00, 1, GETDATE(), 5),
--('Salsa Ketchup Natura''s Doypack', 'SALSA DE TOMATE KETCHUP NATURAS', 15, 26, 22.00, 28.00, 1, GETDATE(), 5),
--('Salsa Lizano Original 700ml', 'SALSA INGLESA LIZANO BOTELLA 700 ML', 15, 12, 110.00, 138.00, 1, GETDATE(), 5),
--('Chile Lizano Tabasco Bco', 'CHILE LIZANO BOTELLA', 15, 18, 35.00, 45.00, 1, GETDATE(), 5),
--('Salsa Picante Don Julio Bote', 'SALSA PICANTE DON JULIO', 15, 20, 20.00, 26.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 16: Especias y sazonadores
---- ===================================================
--('Café Toro Molido Sobres', 'CAFE TORO MOLIDO SOBRE TRADICIONAL', 16, 27, 8.00, 12.00, 1, GETDATE(), 5),
--('Sopa Maggi Pollo con Fideos 55g', 'SOPA MAGGI POLLO CON FIDEOS 55 GR', 16, 30, 14.00, 18.00, 1, GETDATE(), 5),
--('Sopa Criolla Costilla Maggi 58g', 'SOPA CRIOLLA COSTILLA MAGGI 58 GR', 16, 24, 14.00, 18.00, 1, GETDATE(), 5),
--('Crema de Tomate Maggi 76g', 'CREMA DE TOMATE MAGGI 76 GR', 16, 22, 16.00, 21.00, 1, GETDATE(), 5),
--('Mix de Achiote y Especias Maggi', 'MAGGI MIX DE ACHIOTE Y ESPECIAS', 16, 25, 10.00, 14.00, 1, GETDATE(), 5),
--('Consomé de Pollo Maggi Sobre', 'CONSOME DE POLLO MAGGI SOBRE 10G', 16, 30, 6.00, 8.50, 1, GETDATE(), 5),
--('Sazonador Naturísimo Maggi 10g', 'NATURISIMO MAGGI SAZONADOR COMPLETO', 16, 28, 6.50, 9.00, 1, GETDATE(), 5),
--('Sazonador Res Maggi 10g', 'SAZONADOR RES MAGGI SOBRE 10G', 16, 26, 6.50, 9.00, 1, GETDATE(), 5),
--('Sazonador Costilla Criolla Maggi', 'SAZONADOR COSTILLA CRIOLLA MAGGI', 16, 22, 6.50, 9.00, 1, GETDATE(), 5),
--('Sazonador Camarón Maggi 10g', 'SAZONADOR DE CAMARON MAGGI', 16, 19, 7.00, 10.00, 1, GETDATE(), 5),
--('Favora Consomé de Pollo Ristra 12s', 'FAVORA SAZONADOR POLLO RISTRA 12 UDS', 16, 17, 30.00, 40.00, 1, GETDATE(), 5),
--('Favora Sazón Completo', 'FAVORA SAZON COMPLETO SOBRE', 16, 25, 3.00, 5.00, 1, GETDATE(), 5),
--('Sal de Ajo Laky 5g', 'SAL DE AJO LAKY SOBRE 5 GR', 16, 29, 3.00, 5.00, 1, GETDATE(), 5),
--('Pimienta Negra Laky Polvo 2g', 'PIMIENTA NEGRA EN POLVO LAKY 2G', 16, 30, 2.50, 4.00, 1, GETDATE(), 5),
--('Empanizador Don Julio Mariscos 210g', 'EMPANIZADOR DON JULIO MARISCOS 210G', 16, 16, 28.00, 36.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 17: Lavandería
---- ===================================================
--('Detergente Espumil Antibacterial 500g', 'DETERGENTE ESPUMIL ANTIBACTERIAL 500G', 17, 22, 32.00, 40.00, 1, GETDATE(), 5),
--('Detergente Espumil c/Suavizante 500g', 'DETERGENTE ESPUMIL CON SUAVIZANTE 500G', 17, 20, 32.00, 40.00, 1, GETDATE(), 5),
--('Detergente Ultra Fuerza Total 400g', 'DETERGENTE EN POLVO ULTRA 400G', 17, 25, 22.00, 28.00, 1, GETDATE(), 5),
--('Detergente Surf Multiuso 400g', 'DETERGENTE SURF MULTIUSO 400G', 17, 21, 24.00, 30.00, 1, GETDATE(), 5),
--('Jabón de Ropa Rinso Limón 90g', 'JABON MULTIUSO RINSO LIMON 90G', 17, 28, 10.00, 14.00, 1, GETDATE(), 5),
--('Jabón de Ropa Doña Reyna Barra 340g', 'JABON DE BARRA REINA MULTIUSO 340G', 17, 24, 18.00, 24.00, 1, GETDATE(), 5),
--('Detergente Xedex Máximo Poder Limón', 'DETERGENTE XEDEX MAXIMO PODER LIMON', 17, 18, 35.00, 44.00, 1, GETDATE(), 5),
--('Suavizante Terso Intensas Sensaciones 720ml', 'SUAVIZANTE TERSO TERSO 720 ML', 17, 19, 42.00, 52.00, 1, GETDATE(), 5),
--('Suavizante Suavitel Cuidado Superior 670ml', 'SUAVITEL CUIDADO SUPERIOR 670 ML', 17, 16, 45.00, 56.00, 1, GETDATE(), 5),
--('Jabón de Lavar Marfil Ultra Barra', 'JABON LAVA LAVA MARFIL ULTRA', 17, 22, 16.00, 22.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 18: Limpieza general
---- ===================================================
--('Desinfectante Magia Blanca Lavanda 100ml', 'MAGIA BLANCA LAVANDA FRANCESA 100ML', 18, 30, 8.00, 12.00, 1, GETDATE(), 5),
--('Desinfectante Magia Blanca Manzana 100ml', 'MAGIA BLANCA MANZANA VERDE 100ML', 18, 27, 8.00, 12.00, 1, GETDATE(), 5),
--('Desinfectante Azistín Forta Sobres', 'DESINFECTANTE AZISTIN FORTA SOBRE', 18, 26, 7.00, 10.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 21: Higiene capilar y corporal
---- ===================================================
--('Crema de Peinar Sedal Rizos Definidos 300ml', 'SEDAL CREMA PARA PEINAR 300 ML', 21, 15, 68.00, 85.00, 1, GETDATE(), 5),
--('Crema de Peinar Pantene Rizos 300ml', 'PANTENE CREMA PARA PEINAR 300 ML', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Lady Speed Stick Gel 24/7', 'LADY SPEED STICK CREMA/GEL', 21, 14, 82.00, 102.00, 1, GETDATE(), 5),
--('Desodorante Speed Stick Xtreme Gel', 'SPEED STICK XTREME NIGHT GEL', 21, 13, 85.00, 105.00, 1, GETDATE(), 5),
--('Shampoo Head & Shoulders 2en1', 'HEAD & SHOULDERS SHAMPOO LIMPIEZA', 21, 11, 90.00, 112.00, 1, GETDATE(), 5),
--('Gel Fijador Ego Attraction 200ml', 'GEL FIJADOR EGO ATTRACTION 200 ML', 21, 18, 48.00, 60.00, 1, GETDATE(), 5),
--('Jabón de Baño DK12 Frutos Rojos', 'JABON DE BAÑO DK12 FRUTOS ROJOS', 21, 25, 18.00, 24.00, 1, GETDATE(), 5),
--('Jabón de Baño DK12 Avena Humectante', 'JABON DE BAÑO DK12 AVENA', 21, 28, 18.00, 24.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 22: Higiene oral
---- ===================================================
--('Crema Dental Colgate Triple Acción Tubo', 'CREMA DENTAL COLGATE TRIPLE ACCION', 22, 22, 32.00, 40.00, 1, GETDATE(), 5),
--('Cepillo Dental Colgate Classic 1x12', 'CEPILLO DENTAL COLGATE CLASSIC PACK', 22, 10, 120.00, 150.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 23: Cuidado del bebé y femenino
---- ===================================================
--('Pañales Jueguitos XG 50s', 'PANALES JUEGUITOS TALLA XG 50 UDS', 23, 8, 310.00, 380.00, 1, GETDATE(), 5),
--('Pañales Smarty Baby G 50s', 'PANALES SMARTY BABY TALLA G 50 UDS', 23, 9, 290.00, 355.00, 1, GETDATE(), 5),
--('Toallas Kotex Esencial Flujo Medio 10s', 'TOALLAS SANITARIAS KOTEX ESENCIAL 10S', 23, 21, 32.00, 42.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 28: Alimentos para animales
---- ===================================================
--('Alimento para Gato Gati 8kg', 'ALIMENTO GATI DEFENSAS ACTIVAS 8KG', 28, 5, 520.00, 620.00, 1, GETDATE(), 5),
--('Alimento para Perro Vichoc 50lb', 'ALIMENTO VICHOC PERRO ADULTO 50LB', 28, 4, 880.00, 1050.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 29: Artículos Ferreteros
---- ===================================================
--('Candados de Hierro Chrom Set', 'CANDADOS DE HIERRO CHROM PACK 12U', 29, 7, 220.00, 275.00, 1, GETDATE(), 5),
--('Candados de Hierro Rabbit Set 12s', 'CANDADOS DE HIERRO RABBIT PACK 12U', 29, 6, 210.00, 260.00, 1, GETDATE(), 5),
--('Pegamento Instantáneo Omega Ristra', 'PEGA INSTANTANEA OMEGA RISTRA 12U', 29, 15, 60.00, 80.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 34: Pastas (Espaguetis, conchitas, etc.)[cite: 26]
---- ===================================================
--('Pasta Milano Espagueti 200g', 'PASTA MILANO ESPAGUETI 200 GR', 34, 29, 11.00, 15.00, 1, GETDATE(), 5),
--('Pasta Milano Caracolitos 200g', 'PASTA MILANO CARACOLITOS 200 GR', 34, 23, 11.00, 15.00, 1, GETDATE(), 5),
--('Pasta Roma Espagueti 200g', 'PASTA ROMA ESPAGUETI 200 GR', 34, 20, 12.00, 16.00, 1, GETDATE(), 5);


--INSERT INTO Categoria (Nombre, Descripcion, Estado, FechaCreacion) 
--VALUES ('Café e infusiones', 'Café molido, café instantáneo, café en grano, té, etc.', 1, GETDATE());

--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
---- ===================================================
---- CATEGORÍA 6: Gaseosas y jugos
---- ===================================================
--('Néctar Kern''s Manzana Lata 330ml', 'NECTAR KERNS MANZANA LATA 330X24', 6, 24, 16.70, 57.00, 1, GETDATE(), 5),
--('D''Frutta Té Frío Limón 355ml', 'D FRUTTA TE FRIO LIMON 355ML X 12', 6, 12, 11.67, 14.00, 1, GETDATE(), 5),
--('D''Frutta Naranja 3 Lts', 'D FRUTTA NARANJA 3 LTS X 4', 6, 4, 46.75, 56.00, 1, GETDATE(), 5),
--('D''Frutta Té Frío Limón 3 Lts', 'D FRUTTA TE FRIO LIMON 3 LTS X 4', 6, 4, 46.75, 56.00, 1, GETDATE(), 5),
--('D''Frutta Manzana Lata 330ml', 'ID FRUTTA MANZANA LATA 330ML X 12', 6, 4, 42.50, 51.00, 1, GETDATE(), 5),
--('Yupi Cualquier Sabor', 'YUPI CUALQUIER SABOR', 6, 24, 4.46, 6.00, 1, GETDATE(), 5),
--('Prix Cola Pet 355ml', 'PRIX COLA PET 355 ML X 12', 6, 12, 10.83, 13.00, 1, GETDATE(), 5),
--('Prix Cola Pet 500ml', 'PRIX COLA PET 500 ML X 12', 6, 12, 14.17, 17.00, 1, GETDATE(), 5),
--('Prix Cola Pet 1.2 Lts', 'PRIX COLA PET 1.2 LTS X 6', 6, 6, 20.83, 25.00, 1, GETDATE(), 5),
--('Prix Cola Pet 2 Litros', 'PRIX COLA PET 2 LITROS X 6', 6, 6, 33.33, 40.00, 1, GETDATE(), 5),
--('Prix Cola Lata 355ml', 'PRIX COLA LATA 355 ML X 12', 6, 12, 16.67, 20.00, 1, GETDATE(), 5),
--('Jugo Tropical Mango 350ml', 'JUGO TROPICAL MANGO 350 ML X 12', 6, 12, 18.43, 22.00, 1, GETDATE(), 5),
--('Tropical Cero Manzana Kiwi 500ml', 'TROPICAL CERO MANZANA KIWI 500ML X 12', 6, 12, 25.00, 30.00, 1, GETDATE(), 5),
--('Jugo Tropical Té Frío Limón 1.75 Lt', 'JUGO TROPICAL TE FRIO LIMON 1.75 LT x 6.', 6, 6, 48.50, 58.00, 1, GETDATE(), 5),
--('Tropical Frutas Mixtas 2.5 Litros', 'TROPICAL FRUTAS MIXTAS 2.5 LITROS X 6', 6, 6, 82.35, 99.00, 1, GETDATE(), 5),
--('Jugo Tropical Té Frío Limón 2.5 Litros', 'JUGO TROPICAL TE FRIO LIMON 2.5 LITROS x 6', 6, 6, 75.17, 90.00, 1, GETDATE(), 5),
--('Néctar Kern''s Melocotón Tetra 200ml', 'NECTAR KERNS MELOCOTON TETRA 200X24', 6, 24, 11.69, 14.00, 1, GETDATE(), 5),
--('Kern''s Néctar Uva Tetra 1Lt', 'KERNS NECTAR UVA TETRA 1LT X1', 6, 1, 45.05, 54.00, 1, GETDATE(), 5),
--('Jugo de Vegetales Kern''s 330ml', 'JUGO DE VEGETALES KERNS 330ML X 24', 6, 24, 15.86, 19.00, 1, GETDATE(), 5),
--('Fun C Manzana 250ml', 'FUN C MANZANA 250 ml x 24', 6, 24, 14.20, 17.00, 1, GETDATE(), 5),
--('Fun C Melocotón 250ml', 'FUN C MELOCOTON 250 ml x 24', 6, 24, 14.20, 17.00, 1, GETDATE(), 5),
--('Jet Botella 600ml', 'JET BOTELLA 600 ML X 12', 6, 12, 25.00, 30.00, 1, GETDATE(), 5),
--('Jet Botella 350ml', 'JET BOTELLA 350 ML X 12', 6, 12, 17.50, 21.00, 1, GETDATE(), 5),
--('Coca-Cola Retornable 6.5onz', '6.5onz CC/SAB', 6, 24, 10.08, 12.00, 1, GETDATE(), 5),
--('Coca-Cola Retornable 12onz', '12onz CC/SAB', 6, 24, 12.04, 14.00, 1, GETDATE(), 5),
--('Coca-Cola Retornable 500ml', '500ml CC/SAB', 6, 24, 13.79, 16.00, 1, GETDATE(), 5),
--('Coca-Cola Retornable 1LT', '1LT CC', 6, 12, 19.75, 23.00, 1, GETDATE(), 5),
--('Coca-Cola Retornable 2LT', '2LT CC/SAB', 6, 8, 35.13, 41.00, 1, GETDATE(), 5),
--('Valle Retornable 12onz', '12onz valle', 6, 24, 11.21, 13.00, 1, GETDATE(), 5),
--('Coca-Cola Desechable 355ml', '355ml CC/SAB', 6, 24, 18.25, 21.00, 1, GETDATE(), 5),
--('Coca-Cola Desechable 250ml S/Azúcar', '250ml s/azucar', 6, 24, 8.42, 10.00, 1, GETDATE(), 5),
--('Coca-Cola Desechable 600ml', '600ml CC/SAB', 6, 24, 23.54, 28.00, 1, GETDATE(), 5),
--('Coca-Cola Desechable 600ml S/Azúcar', '600ml s/azucar', 6, 24, 19.29, 23.00, 1, GETDATE(), 5),
--('Coca-Cola Lata / Sabores / S/A', 'lata CC/SAB/SA', 6, 12, 21.08, 25.00, 1, GETDATE(), 5),
--('Coca-Cola Mini Lata', 'mini lata CC/SAB', 6, 12, 17.25, 20.00, 1, GETDATE(), 5),
--('Coca-Cola 1LT Pet S/Azúcar', '1LT pet s/azucar', 6, 12, 20.08, 24.00, 1, GETDATE(), 5),
--('Coca-Cola 1LT Pet CC', '1LT pet CC', 6, 12, 25.83, 29.00, 1, GETDATE(), 5),
--('Coca-Cola 2LT Pet CC', '2LT pet CC', 6, 8, 52.75, 59.00, 1, GETDATE(), 5),
--('Coca-Cola 2LT Pet Sabores', '2LT pet sabores', 6, 8, 53.25, 61.00, 1, GETDATE(), 5),
--('Coca-Cola 2LT Sin Azúcar', '2LT sin azucar', 6, 8, 42.75, 48.00, 1, GETDATE(), 5),
--('Coca-Cola 2.5Lt Pet CC', '2.5Lt pet CC', 6, 8, 60.88, 70.00, 1, GETDATE(), 5),
--('Coca-Cola 3LT', '3LT CC/SAB', 6, 6, 68.33, 78.00, 1, GETDATE(), 5),
--('Coca-Cola Mini Lata S/Azúcar', 'mini lata s/azuca', 6, 12, 13.58, 16.00, 1, GETDATE(), 5),
--('Hi-C 250ml / Sabores', 'Hic 250ml/ SAB', 6, 24, 18.46, 22.00, 1, GETDATE(), 5),
--('Hi-C Té 33ml Caja', 'Hic te 33ml Caja', 6, 24, 22.63, 27.00, 1, GETDATE(), 5),
--('Del Valle Lata', 'Del valle lata', 6, 12, 18.42, 22.00, 1, GETDATE(), 5),
--('Del Valle 500ml', 'Del valle 500ml', 6, 12, 21.17, 25.00, 1, GETDATE(), 5),
--('Alpina Gasificada', 'Alpina gasificada', 6, 12, 20.83, 25.00, 1, GETDATE(), 5),
--('Alpina 600ml', 'Alpina 600ml', 6, 24, 19.33, 23.00, 1, GETDATE(), 5),
--('Alpina 1LT', 'Alpina 1LT', 6, 12, 23.08, 28.00, 1, GETDATE(), 5),
--('Alpina 2LT', 'Alpina 2LT', 6, 6, 35.83, 42.00, 1, GETDATE(), 5),
--('Hi-C Té 2LT', 'Hic te 2LT', 6, 6, 46.17, 55.00, 1, GETDATE(), 5),
--('Del Valle 2LT', 'Del valle 2LT', 6, 6, 37.00, 44.00, 1, GETDATE(), 5),
--('Del Valle 3LT', 'Del valle 3LT', 6, 6, 48.67, 58.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 7: Agua y refrescos
---- ===================================================
--('Agua Caja 12 0.5 Litros Tapa Plana', '80 | CAJA 12 0.5 LITROS AGUA TAPA PLANA', 7, 12, 18.33, 22.00, 1, GETDATE(), 5),
--('Agua Tapa Plana 1 Litro x 6', '1456 | AGUA FP TAPA PLANA 1 LITRO X 6', 7, 6, 21.67, 26.00, 1, GETDATE(), 5),
--('Agua Caja 6 1.5 Litros Tapa Plana', '83 | CAJA 6 1.5 LITROS AGUA TAPA PLANA', 7, 6, 26.67, 32.00, 1, GETDATE(), 5),
--('Agua Fuente Pura 3 Lts x4', 'AGUA FUENTE PURA 3 LTS X4', 7, 4, 37.50, 45.00, 1, GETDATE(), 5),
--('Botellón de Agua 18.93 Litros', 'BOTELLON 18.93 LITROS', 7, 1, 95.00, 114.00, 1, GETDATE(), 5),
--('Agua Caja 4 Galón', 'CAJA 4 GALON AGUA', 7, 4, 38.25, 45.90, 1, GETDATE(), 5),
--('Fuente Pura Agua Gasificada x 6', 'FUENTE PURA AGUA GASIFICADA x 6', 7, 6, 20.83, 25.00, 1, GETDATE(), 5),
--('Agua Brisa 250 ml x 36', 'AGUA BRISA 250 ML X 36', 7, 36, 2.89, 4.00, 1, GETDATE(), 5),
--('Agua Brisa 500 ml x 18', 'AGUA BRISA 500 ML X 18', 7, 18, 3.73, 5.00, 1, GETDATE(), 5),
--('Agua Brisa Botella 500 ml x 12', 'AGUA BRISA BOTELLLA 500 ML X 12', 7, 12, 11.17, 14.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 8: Energizantes e isotónicos
---- ===================================================
--('Powerade 600ml', 'Powerade 600ml', 8, 12, 31.83, 38.00, 1, GETDATE(), 5),
--('Fury Energizante', 'FURY', 8, 12, 26.00, 31.00, 1, GETDATE(), 5),
--('Monster Energizante', 'MONSTER', 8, 6, 73.00, 85.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 9: Snacks saladas
---- ===================================================
--('Lay''s Original CT 18 gr x12', 'LAYS ORIGINAL CT 18 GR X12', 9, 12, 8.32, 10.00, 1, GETDATE(), 5),
--('Lay''s Max Queso 26gr', 'LAYS MAX QUESO 26GR. X1', 9, 1, 9.96, 12.00, 1, GETDATE(), 5),
--('Lay''s Sal 26gr', 'LAYS SAL CS 26GR. X1', 9, 1, 10.26, 12.00, 1, GETDATE(), 5),
--('Lay''s Sour Cream & Onion 1 oz', 'LAYS SOUR C&O 1 OZ X1', 9, 1, 21.45, 26.00, 1, GETDATE(), 5),
--('Lay''s Original CS 105gr', 'LAYS ORIGINAL CS 105GR. X1', 9, 1, 46.41, 56.00, 1, GETDATE(), 5),
--('Lay''s Original RTD 110gr', 'LAYS ORIGINAL RTD 110GR. X1', 9, 1, 48.34, 58.00, 1, GETDATE(), 5),
--('Lay''s Original CS 110gr', 'LAYS ORIGINAL CS 110GR. X1', 9, 1, 48.34, 58.00, 1, GETDATE(), 5),
--('Cheetos Crunchy CT 21gr x12', 'CHEETOS CRUNCHY CT 21GR. X12', 9, 12, 6.84, 9.00, 1, GETDATE(), 5),
--('Cheetos Poffs CT 18gr x12', 'CHEETOS POFFS CT 18GR. X12', 9, 12, 6.84, 9.00, 1, GETDATE(), 5),
--('Cheetos Poffs CT 23gr x12', 'CHEETOS POFFS CT 23GR. X12', 9, 12, 9.60, 12.00, 1, GETDATE(), 5),
--('Cheetos Crunchy GD CS 25gr x12', 'CHEETOS CRUNCHY GD CS 25GR. X12', 9, 12, 10.00, 12.00, 1, GETDATE(), 5),
--('Cheetos Crunchy CS 120gr', 'CHEETOS CRUNCHY CS 120GR. X1', 9, 1, 30.00, 36.00, 1, GETDATE(), 5),
--('Cheetos Poffs CS 142gr', 'CHEETOS POFFS CS 142GR. X1', 9, 1, 45.84, 55.00, 1, GETDATE(), 5),
--('Cheetos Crunchy 1.25 Oz', 'CHEETOS CRUNCHY 1.25 OZ X1', 9, 1, 21.45, 26.00, 1, GETDATE(), 5),
--('Doritos Nacho Atrevido CS 48gr', 'DORITOS NACHO ATREVIDO CS 48GR. X1', 9, 1, 10.79, 13.00, 1, GETDATE(), 5),
--('Doritos Nacho 1.125 Oz', 'DORITOS NACHO 1.125 OZ X1', 9, 1, 21.45, 26.00, 1, GETDATE(), 5),
--('Dorito Verde Radiante 150gr', 'DORITO VERDE RADIANTE 150GR. X1', 9, 1, 33.33, 40.00, 1, GETDATE(), 5),
--('Doritos Nacho Atrevido CT 25gr x12', 'DORITOS NACHO ATREVIDO CT 25GR. X12', 9, 1, 89.64, 108.00, 1, GETDATE(), 5),
--('Tortrix Limón CT 17gr x18', 'TORTRIX LIMON CT 17GR. X18', 9, 18, 4.98, 6.00, 1, GETDATE(), 5),
--('Tortrix Picante CT 17gr x18', 'TORTRIX PICANTE CT 17GR. X18', 9, 18, 4.98, 6.00, 1, GETDATE(), 5),
--('Tortrix Barbacoa CT 17gr x18', 'TORTRIX BARBACOA CT 17GR. X18', 9, 18, 4.98, 6.00, 1, GETDATE(), 5),
--('Tortrix Queso CT 17gr x18', 'TORTRIX QUESO CT 17GR. X18', 9, 18, 4.98, 6.00, 1, GETDATE(), 5),
--('Tortrix Taco Chilero CT 35gr x6', 'TORTRIX TACO CHILERO CT 35GR. X6', 9, 6, 8.30, 10.00, 1, GETDATE(), 5),
--('Tortrix Detodito 45gr x12', 'TORTRIX DETODITO 45GR. X12', 9, 12, 10.79, 13.00, 1, GETDATE(), 5),
--('Tortrix Chicharrón CS 125gr', 'TORTRIX CHICHARRON CS 125GR. X1', 9, 1, 32.00, 38.00, 1, GETDATE(), 5),
--('Tortrix Detodito 150gr', 'TORTRIX DETODITO 150GR. X1', 9, 1, 32.01, 39.00, 1, GETDATE(), 5),
--('Tortrix Limón 150gr', 'TORTRIX LIMON 150GR. X1', 9, 1, 32.00, 39.00, 1, GETDATE(), 5),
--('Tortrix Barbacoa CS 150gr', 'TORTRIX BARBACOA CS 150GR. X1', 9, 1, 32.00, 39.00, 1, GETDATE(), 5),
--('Tortrix Taco Chilero 170gr', 'TORTRIX TACO CHILERO 170GR. X1', 9, 1, 34.40, 42.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 4: Lácteos y derivados
---- ===================================================
--('Nutrilety 1000ml x 12', 'NUTRILETY 1000ML X 12 UNIDADES', 4, 12, 38.33, 46.00, 1, GETDATE(), 5),
--('Lala Entera 3% 1Lt x12', 'LALA ENTERA 3% 1LTX12', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Lala Semidescremada 2% 1Lt x12', 'LALA SEMIDESCREMADA 2% 1LTX12', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Lala Light 1% 1Lt x12', 'LALA LIGHT 1% 1LTX12', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Lala Deslactosada 1Lt x12', 'LALA DESLACTOSADA 1LT X12', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Leche Eskimo Lechelado Fresa Tetra 200ml', 'LECHE ESKIMO LECHELADO FRESA TETRA 200ML X27', 4, 27, 15.85, 19.00, 1, GETDATE(), 5),
--('Leche Eskimo Entera UHT Tetra 1000ml', 'LECHE ESKIMO ENTERA JUHT TETRA 1000ML X12', 4, 12, 46.67, 56.00, 1, GETDATE(), 5),
--('Leche Eskimo Semidescremada UHT Tetra 1000ml', 'LECHE ESKIMO SEMIDES 2UHT TETRA 1000ML X12', 4, 12, 46.67, 56.00, 1, GETDATE(), 5),
--('Leche Eskimo Descremada UHT Tetra 1000ml', 'LECHE ESKIMO DESCRE OUHT TETRA 1000ML X12', 4, 12, 46.67, 56.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 15: Salsas y aderezos
---- ===================================================
--('Salsa Tomate Kern''s Sachet 8gr x1000', 'SALSA TOMATE KERNS SACHET 8GRX1000', 15, 1000, 1.25, 1.50, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Sachet 52gr x12', 'SALSA TOMATE KERNS SACHET 52GRX12', 15, 12, 8.33, 10.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Doypack 4oz x12', 'SALSA TOMATE KERNS DOYPΑΚ 40ΖX12.', 15, 12, 15.84, 19.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Doypack Rosca 385g', 'SALSA TOMATE KERNS DOYPACK ROSCA 385 GRX1', 15, 1, 44.28, 53.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Bot. Plástica 375g', 'SALSA TOMATE KERNS BOT.PLASTICA 375GRX1', 15, 1, 47.44, 57.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Picante Pet 375g', 'SALSA TOMATE KERNS PICANTE PET 375GRX1', 15, 1, 50.92, 61.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Cero Azúcar Pet 520g', 'SALSA TOMATE KERNS CERO AZUCAR PET 520GR x1', 15, 1, 69.32, 83.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Pet 540g', 'SALSA TOMATE KERNS PET 540GR x1', 15, 1, 69.03, 83.00, 1, GETDATE(), 5),
--('Salsa Barbacoa Kern''s Pet 540g', 'SALSA BARBACOA KERNS PET 540 GR X 1', 15, 1, 83.69, 100.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Bot. Plástica 776g', 'SALSA TOMATE KERNS BOT.PLASTICA 776GRX1', 15, 1, 87.21, 105.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Pet 995g', 'SALSA TOMATE KERNS PET 995GR X1', 15, 1, 100.15, 120.00, 1, GETDATE(), 5),
--('Salsa Tomate Kern''s Galón', 'SALSA TOMATE KERNS GALON X1', 15, 1, 314.33, 377.00, 1, GETDATE(), 5),
--('Kern''s Salsa Hongos/Hierbas/Albahaca/Marinera 425g', 'KERNS SALSA HONGOS HIERBAS/ALBAHACA/MARINARA 425', 15, 1, 95.83, 115.00, 1, GETDATE(), 5),
--('Mayonesa Orig Ana Belly Doypack 100gr', 'MAYONESA ORIG ANA BELLY DOYPACK 100GR X1', 15, 1, 21.67, 26.00, 1, GETDATE(), 5),
--('Mayonesa Orig Ana Belly Bolsa 100gr', 'MAYONESA ORIG ANA BELLY BOLSA 100GR X1', 15, 1, 18.33, 22.00, 1, GETDATE(), 5),
--('Mayonesa Orig Ana Belly Doypack 200gr', 'MAYONESA ORIG ANA BELLY DOYPACK 200GR X1', 15, 1, 37.50, 45.00, 1, GETDATE(), 5),
--('Mayonesa Orig Ana Belly Doypack 400gr', 'MAYONESA ORIG ANA BELLY DOYPACK 400GR X1', 15, 1, 66.67, 80.01, 1, GETDATE(), 5),
--('Mayonesa Orig Ana Belly Bolsa 390gr', 'MAYONESA ORIG ANA BELLY BOLSA 390GR X1', 15, 1, 58.33, 70.00, 1, GETDATE(), 5),
--('Mayonesa Reducida Ana Belly 3500gr', 'MAYONESA REDUCIDA ANA BELLY 3500GR X1', 15, 1, 409.25, 491.10, 1, GETDATE(), 5),
--('Aderezo Mayonesa Ana Belly Tarro 3500gr', 'ADEREZO MAYONESA ANA BELLY TARRO 3500GR X1', 15, 1, 445.63, 534.75, 1, GETDATE(), 5),
--('Mostaza Prep Ana Belly Bolsa 100gr', 'MOSTAZA PREP ANA BELLY BOLSA 100GR X1', 15, 1, 8.34, 10.00, 1, GETDATE(), 5),
--('Mostaza Prep Ana Belly Bolsa 390gr', 'MOSTAZA PREP ANA BELLY BOLSA 390GR X1', 15, 1, 25.00, 30.00, 1, GETDATE(), 5),
--('Mostaza Preparada Ana Belly Bolsa 880g', 'MOSTAZA PREPARADA ANA BELLY BOLSA 880 GR X 1', 15, 1, 58.33, 70.00, 1, GETDATE(), 5),
--('Mostaza Prep Ana Belly Bolsa 3500gr', 'MOSTAZA PREP ANA BELLY BOLSA 3500GR X1', 15, 1, 216.25, 259.50, 1, GETDATE(), 5),
--('Mostaza Prep Ana Belly Tarro 3785gr', 'MOSTAZA PREP ANA BELLY TARRO 3785GR X1', 15, 1, 224.00, 268.80, 1, GETDATE(), 5),
--('Aderezo Sandw Spread Ana Belly Doyp 105gr', 'ADEREZO SANDW SPREAD ANA BELLY DOYP 105GR X1', 15, 1, 18.33, 22.00, 1, GETDATE(), 5),
--('Aderezo Sandw Spread Ana Belly Doyp 215gr', 'ADEREZO SANDW SPREAD ANA BELLY DOYP 215GR X1', 15, 1, 35.00, 42.01, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 1: Granos básicos (Frijoles Ducal)
---- ===================================================
--('Ducal Frijol Mol Rojo Doypa 8oz', 'DUCAL FRIJOL MOL ROJO DOΥΡΑ 802  1', 1, 1, 27.50, 33.00, 1, GETDATE(), 5),
--('Ducal Frijol Entero Rojo Doypa 14 oz', 'DUCAL FRIJOL ENTERO ROJO DOYPA 14 OZ X 1', 1, 1, 45.00, 54.00, 1, GETDATE(), 5),
--('Ducal Frijol Mol Rojo Doypa 14.1oz', 'DUCAL FRIJOL MOL ROJO DOΥΡΑ 14.102 Χ 1', 1, 1, 38.33, 46.00, 1, GETDATE(), 5),
--('Ducal Frijol Mol Rojo Pican Doypa 14.1oz', 'DUCAL FRIJOL MOL ROJO PICAN DOYPA 14.10Z X 1', 1, 1, 38.33, 46.00, 1, GETDATE(), 5),
--('Ducal Frijol Mol Negro Doypa 14.1oz', 'DUCAL FRIJOL MOL NEGRO DOYPA 14.102 X 1', 1, 1, 38.33, 46.00, 1, GETDATE(), 5),
--('Ducal Frijol Entero Rojo Doypa 28 oz', 'DUCAL FRIJOL ENTERO ROJO DOYPA 28 OZ X 1', 1, 1, 62.50, 75.00, 1, GETDATE(), 5),
--('Ducal Frijol Mol Rojo Doypa 35oz', 'DUCAL FRUOL MOL ROJO DOYPA 35OZ X 1', 1, 1, 68.33, 82.00, 1, GETDATE(), 5),
--('Ducal Frijol Mol Rojo Doypa 80oz', 'DUCAL FRIJOL MOL ROJO DOΥΡΑ 8002 Χ 1', 1, 1, 159.47, 191.36, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 35: Café e infusiones
---- ===================================================
--('Café Toro Molido Sobres', 'CAFE TORO MOLIDO SOBRE TRADICIONAL', 35, 27, 8.00, 12.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Pack 50g', 'CAFE INST-1820 PACK 50GR', 35, 26, 35.00, 45.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 50g', 'CAFE INST. 1820 FCO 50 GR', 35, 20, 60.00, 75.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 100g', 'CAFE INST. 1820-FCO.100 GR', 35, 22, 110.00, 135.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 150g', 'CAFE INST. 1820 FCO 150 GR', 35, 17, 155.00, 190.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 250g', 'CAFE INST. 1820 FCO 250 GR', 35, 10, 240.00, 290.00, 1, GETDATE(), 5),
--('Café Instantáneo 1820 Fco 400g', 'CAFE INST. 1820 FCO 400 GR', 35, 8, 380.00, 460.00, 1, GETDATE(), 5),
--('Café 1820 Tradicional 2g (80s)', 'CAFE 1820 TRADICIONAL 2GR (80)', 35, 15, 140.00, 175.00, 1, GETDATE(), 5),
--('Café 1820 Tradicional 2g (40s)', 'CAFE 1820 TRADICIONAL 2GR (40)', 35, 18, 75.00, 95.00, 1, GETDATE(), 5),
--('Café 1820 Tradicional Fco 250g', 'CAFE 1820 TRADICIONAL FCO 250 GR', 35, 12, 210.00, 260.00, 1, GETDATE(), 5),
--('Café 1820 Liofilizado 85g', 'CAFE INST. 1820 LIOFILIZADO 85 GR', 35, 14, 130.00, 160.00, 1, GETDATE(), 5),
--('Café Capuccino 1820 120g', 'CAFE CAPUCCINO INST. 1820 120 GR', 35, 13, 85.00, 105.00, 1, GETDATE(), 5),
--('Café Capuccino Vainilla 120g', 'CAFE1820 CAPUCCIN VAINILLA 120 GR', 35, 11, 85.00, 105.00, 1, GETDATE(), 5),
--('Café Mokaccino 1820 120g', 'CAFE MOKACCINO INST. 1820 120 GR', 35, 16, 85.00, 105.00, 1, GETDATE(), 5),
--('Café Frozen Cappuccino 1820 120g', 'CAFE INST. FROZEN CAPUCCINO 1820 120 GR', 35, 9, 90.00, 110.00, 1, GETDATE(), 5),
--('Café Molido 1820 Paq 200g', 'CAFE MOLIDO 1820 PAQ 200GR', 35, 24, 75.00, 92.00, 1, GETDATE(), 5),
--('Café Molido 1820 Paq 400g', 'CAFE MOLIDO 1820 PAQ. 400 GR', 35, 19, 145.00, 180.00, 1, GETDATE(), 5),
--('Café D''Oro Molido 25g', 'CAFE MOLIDO D''ORO 25 GR (40X12)', 35, 28, 10.00, 13.00, 1, GETDATE(), 5),
--('Café Molido 1820 Reserva Especial 340g', 'CAFE MOLIDO 1820 RES ESP 340GR', 35, 10, 180.00, 220.00, 1, GETDATE(), 5),
--('Mi Café 113 Gr', 'MI CAFE 113 GR x 1', 35, 1, 22.40, 26.88, 1, GETDATE(), 5),
--('Mi Café 25Gr x16', 'MI CAFE 25GR x 16', 35, 16, 6.40, 7.68, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 14: Sopas instantáneas
---- ===================================================
--('Sopas Mizzopita Camarón 64 Gr x12', 'SOPAS MIZZOPITA CAMARON 64 GR X 12', 14, 12, 25.00, 30.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 28: Alimentos para animales
---- ===================================================
--('AlfaCan 44 Libras', 'ALFACAN 44 LIBRAS', 28, 44, 23.33, 28.00, 1, GETDATE(), 5),
--('AlfaCan Hígado 44 Libras Adulto', 'ALFACAN HIGADO 44 LIBRAS ADULTO', 28, 44, 23.33, 28.00, 1, GETDATE(), 5),
--('AlfaCan Cachorro 25 Lb', 'ALFACAN CAHORRO 25 LB', 28, 25, 26.68, 32.02, 1, GETDATE(), 5),
--('Combis 50 Libras', 'COMBIS 50 LIBRAS', 28, 50, 21.87, 26.24, 1, GETDATE(), 5),
--('Combis Cachorro 50 Lbs', 'COMBIS CACHORRO 50 LBS', 28, 50, 24.38, 29.26, 1, GETDATE(), 5),
--('Dog Select 44 Lbs Adulto', 'DOG SELECT 44 LBS ADULTO', 28, 44, 29.16, 34.99, 1, GETDATE(), 5),
--('Dog Select 44 Lbs Cachorro', 'DOG SELECT 44 LBS CACHORRO', 28, 44, 33.34, 40.01, 1, GETDATE(), 5),
--('Spartacus Adulto 15 Lb', 'SPARTACUS ADULTO 15 LB X 1', 28, 15, 26.11, 31.33, 1, GETDATE(), 5),
--('Spartacus Adulto 7 Lb', 'SPARTACUS ADULTO 7 LB X1', 28, 7, 26.86, 32.23, 1, GETDATE(), 5),
--('Spartacus Cachorro 6 Lb', 'SPARTACUS CACHORRO 6 LB X 1', 28, 6, 31.18, 37.42, 1, GETDATE(), 5),
--('Goldy Cachorro 2 Kg', 'GOLDY CACHORRO 2 KG X 1', 28, 4, 45.45, 54.55, 1, GETDATE(), 5),
--('Goldy Adulto 4 Kg', 'GOLDY ADULTO 4 KG X 1', 28, 8, 41.08, 49.30, 1, GETDATE(), 5),
--('Goldy Adulto 8 Kg', 'GOLDY ADULTO 8 KG X 1', 28, 17, 39.22, 47.07, 1, GETDATE(), 5),
--('Asgard Cachorro 2 Kg', 'ASGARD CACHORRO 2 KG X 1', 28, 4, 55.32, 66.38, 1, GETDATE(), 5),
--('Asgard Adulto 4 Kg', 'ASGARD ADULTO 4 KG X 1', 28, 8, 49.36, 59.24, 1, GETDATE(), 5),
--('Asgard Adulto 20 Kg', 'ASGARD ADULTO 20 KG', 28, 44, 41.74, 50.09, 1, GETDATE(), 5),
--('Asgard Cachorro 20 Kg', 'ASGARD CACHORRO 20 KG', 28, 44, 49.31, 59.18, 1, GETDATE(), 5),
--('Asgard Adulto 8 Kg', 'ASGARD ADULTO 8 KG X1', 28, 17, 47.76, 57.31, 1, GETDATE(), 5),
--('Kitty Gato 18 Lb', 'KITTY GATO 18 LB', 28, 18, 39.17, 47.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 11: Dulces y confitería
---- ===================================================
--('Bon O Bon Blanco / Cookies / Frutilla / Chocolate 15 Gr', 'BON O BON BLANCO / COOKIES/FRUTILLA/CHOCOLATE 15 GR', 11, 30, 8.00, 10.00, 1, GETDATE(), 5),
--('Bob Leche / Blanco Cam 15gr x5', 'BOB LECHE/BLANCO CAM 15GR x5', 11, 5, 8.00, 10.00, 1, GETDATE(), 5),
--('Bob Bote Mixto 15gr x60', 'BOB BOTE MIXTO 15GR X60', 11, 60, 8.40, 10.00, 1, GETDATE(), 5),
--('Barra Bon O Bon 48gr x12', 'BARRA BON O BON 48GR X12', 11, 12, 24.00, 29.00, 1, GETDATE(), 5),
--('Barra Bob 24gr x24', 'BARRA BOB 24GR X24', 11, 24, 12.00, 15.00, 1, GETDATE(), 5),
--('Alka Bolsa Sabor Surtido', 'ALKA BOLSA CUALQUIER SABOR', 11, 100, 0.80, 1.00, 1, GETDATE(), 5),
--('Alka Barra Sabor Surtido', 'ALKA BARRA CUALQUIER SABOR', 11, 12, 8.80, 11.00, 1, GETDATE(), 5),
--('Alka Mini Sabor Surtido', 'ALKA MINI CUALQUIER SABOR', 11, 20, 9.00, 11.00, 1, GETDATE(), 5),
--('Alka 2 Sabor Surtido', 'ALKA 2 CUALQUIER SABOR', 11, 12, 12.50, 15.00, 1, GETDATE(), 5),
--('Mogul Ositos / Tiburón 30 Gr', 'MOGUL OSITOS/TIBURON 30 GR', 11, 12, 9.98, 12.00, 1, GETDATE(), 5),
--('Mogul Oso / Sandía Extreme 50 Gr x10', 'MOGUL OSO/SANDIA EXTREME 50 GR X10', 11, 10, 16.54, 20.00, 1, GETDATE(), 5),
--('Mogul Mora 50 Gr x10', 'MOGUL MORA 50 GR X10', 11, 10, 17.60, 21.00, 1, GETDATE(), 5),
--('Mogul Sandía Extreme / Oso Extreme y Osito 80 Gr', 'MOGUL SANDIA EXTREME/OSO EXTREME Y OSITO 80 GR X 1', 11, 1, 25.16, 30.00, 1, GETDATE(), 5),
--('Mogul Mora 80 Gr', 'MOGUL MORA 80 GR X 1', 11, 1, 25.60, 31.00, 1, GETDATE(), 5),
--('Party Mix 3lb', 'PARTY MIX 3LB X1', 11, 1, 224.00, 269.00, 1, GETDATE(), 5),
--('Party Mix Nic. 5lb', 'PARTY MIX NIC. 5LB X1', 11, 1, 416.00, 499.00, 1, GETDATE(), 5),
--('Caramelos Masticables Frutales Arcor 800gr', 'CARAMELO MASTICABLE FRUTALES ARCOR 800GR x1', 11, 1, 145.84, 175.00, 1, GETDATE(), 5),
--('Butter Toffees Choco / Leche 126 Gr', 'BUTTER TOFFEES CHOCO/LECHE 126 GR X1', 11, 1, 40.00, 48.00, 1, GETDATE(), 5),
--('Butter Toffees Chocolate Exp / Chokko Mint 300gr', 'BT CHOCOLATE EXP / CHOKKO MINT 300GR X1', 11, 1, 100.00, 120.00, 1, GETDATE(), 5),
--('Caramelos Surtidos Eucalipto/Fresa/Menta/Frutales 4gr', 'CARAMELO EUCALIPTO/FRESA/MENTA/CRISTAL/FRUTALES 4GR x100', 11, 1, 100.00, 120.00, 1, GETDATE(), 5),
--('Cinnamon D.V.L USA 5.9gr x38', 'CINNAMON D. V.L2012-USA 5.9GR x38', 11, 1, 76.00, 91.20, 1, GETDATE(), 5),
--('Honey Drops / Starlight Mints / Strawberry', 'HONEY DROPS/STARLIGHT MINTS/STRAWBERRY', 11, 1, 56.00, 67.20, 1, GETDATE(), 5),
--('Assort Fruitful V.L USA 6gr x28', 'ASSORT FRUITFUL V.L-USA 6GR x28', 11, 1, 50.17, 60.20, 1, GETDATE(), 5),
--('Choc.F.M V.L USA 6gr x24', 'CHOC.F.M. V.L-2012-USA 6GR x24', 11, 1, 50.00, 60.00, 1, GETDATE(), 5),
--('Pir Big Morango 500 Gr', 'PIR BBIG MORANGO 500 GR X1', 11, 1, 70.00, 84.00, 1, GETDATE(), 5),
--('Pir Big TFrutti 500 Gr', 'PIR BBIG TFRUTTI 500 GR X1', 11, 1, 70.00, 84.00, 1, GETDATE(), 5),
--('Chicle Big Big Bolitas 400gr', 'CHICLE BIG BIG BOLITAS 400GR X1', 11, 1, 80.00, 96.00, 1, GETDATE(), 5),
--('Nikolo Cacahuate 21 Gr x30', 'NIKOLO CACAHUATE 21 GR X30', 11, 30, 8.00, 29.00, 1, GETDATE(), 5),
--('Chicle Plutón Diente Ardiente 180gr x40', 'CHICLE PLUT DIENTE ARDIENTE 180GR x1x40', 11, 40, 1.74, 15.00, 1, GETDATE(), 5),
--('Chicle Poosh Fresa 200gr x40', 'CHICLE POOSH FRESA 200GR x1x40', 11, 40, 1.25, 1.50, 1, GETDATE(), 5);















--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
---- ===================================================
---- CATEGORÍA 7: Agua y refrescos[cite: 42]
---- ===================================================
--('Agua Cielo con Antioxidante 650ml', 'CIELO CON ANTIOXIDANTE 0.650 X12', 7, 12, 15.83, 19.00, 1, GETDATE(), 5),
--('Agua Cielo 250ml', 'CIELO AGUA 0.250 X24', 7, 24, 7.50, 9.00, 1, GETDATE(), 5),
--('Agua Cielo 625ml', 'CIELO AGUA 0.625 X20', 7, 20, 13.30, 16.00, 1, GETDATE(), 5),
--('Agua Cielo 1 Litro', 'CIELO AGUA 1.000 X12', 7, 12, 17.50, 21.00, 1, GETDATE(), 5),
--('Agua Cielo 2 Litros', 'CIELO AGUA 2.000 X6', 7, 6, 31.67, 38.00, 1, GETDATE(), 5),
--('Agua Cielo 3.3 Litros', 'CIELO AGUA 3.300 X6', 7, 6, 37.50, 45.00, 1, GETDATE(), 5),
--('Suero Di Lyte 650ml', 'DI LYTE SUERO 0.650 X6', 7, 6, 58.33, 70.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 6: Gaseosas y jugos[cite: 42]
---- ===================================================
--('Cielo Gaseosa 360ml', 'CIELO GASEOSA 0.360 X24', 6, 24, 10.83, 13.00, 1, GETDATE(), 5),
--('Big Cola 1.5 Litros', 'BIG COLA 1.500 X6', 6, 6, 27.50, 33.00, 1, GETDATE(), 5),
--('Big Cola 3.03 Litros', 'BIG COLA 3.030 X6', 6, 6, 53.33, 64.00, 1, GETDATE(), 5),
--('Bio Aloe 360ml', 'BIO ALOE 0.360 X6', 6, 6, 29.17, 35.00, 1, GETDATE(), 5),
--('Bio Aloe 500ml', 'BIO ALOE 0.500 X6', 6, 6, 41.67, 50.00, 1, GETDATE(), 5),
--('Bio Amayu 325ml', 'BIO AMAYU 0.325 X6', 6, 6, 40.00, 48.00, 1, GETDATE(), 5),
--('Cfrut 1 Litro', 'CFRUT 1.000 X12', 6, 12, 19.17, 23.00, 1, GETDATE(), 5),
--('Cfrut 2 Litros', 'CFRUT 2.000 X6', 6, 6, 34.17, 41.00, 1, GETDATE(), 5),
--('Cfrut 3.03 Litros', 'CFRUT 3.030 X6', 6, 6, 53.33, 64.00, 1, GETDATE(), 5),
--('Pule Néctar 145ml', 'PULE NECTAR 0.145 X12', 6, 12, 8.33, 10.00, 1, GETDATE(), 5),
--('Pule 250ml', 'PULE 0.250 X12', 6, 12, 12.50, 15.00, 1, GETDATE(), 5),
--('Pule 340ml', 'PULE 0.340 X6', 6, 6, 23.33, 28.00, 1, GETDATE(), 5),
--('Pule 360ml', 'PULE 0.360 X6', 6, 6, 16.67, 20.00, 1, GETDATE(), 5),
--('Hey Gaseosa 340ml', 'HEY GASEOSA 0.340 X6', 6, 6, 20.00, 24.00, 1, GETDATE(), 5),
--('Hey Gaseosa 600ml', 'HEY GASEOSA 0.600 X12', 6, 12, 20.00, 24.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 8: Energizantes e isotónicos[cite: 42]
---- ===================================================
--('Sporade Isotónica 360ml', 'SPORADE ISOTONICA 0.360 X12', 8, 12, 16.67, 20.00, 1, GETDATE(), 5),
--('Sporade 625ml', 'SPORADE 0.625 X12', 8, 12, 25.00, 30.00, 1, GETDATE(), 5),
--('Sport 625ml', 'CAP SPORT 0.625 X12', 8, 12, 27.50, 33.00, 1, GETDATE(), 5),
--('Sport 1 Litro', 'SPORT 1.000 X6', 8, 6, 36.67, 44.00, 1, GETDATE(), 5),
--('Volt Energizante 300ml', 'VOLT ENERGIZANTE 0.300 X12', 8, 12, 16.67, 20.00, 1, GETDATE(), 5),
--('Volt 340ml', 'VOLT 0.340 X6', 8, 6, 27.50, 33.00, 1, GETDATE(), 5),
--('Volt 625ml', 'VOLT 0.625 X12', 8, 12, 25.00, 30.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 3: Harinas y panadería[cite: 42]
---- ===================================================
--('D''Gussto Harina de Maíz 800g', 'D''GUSSTO HARINA MAIZ 0.800 X9', 3, 9, 50.00, 60.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 34: Pastas y cereales[cite: 42]
---- ===================================================
--('D''Gussto Cereales 25g', 'D''GUSSTO CEREALES 0.025 X12', 34, 12, 8.33, 10.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 14: Sopas instantáneas[cite: 42]
---- ===================================================
--('D''Gussto Sopas 64g', 'D''GUSSTO SOPAS 0.064 X12', 14, 12, 32.50, 39.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 9: Snacks saladas[cite: 42]
---- ===================================================
--('D''Gussto Snack 20g', 'D''GUSSTO SNACK 0.020 X12', 9, 12, 6.67, 8.00, 1, GETDATE(), 5),
--('D''Gussto Snack 55g', 'D''GUSSTO SNACK 0.055 X8', 9, 8, 12.50, 15.00, 1, GETDATE(), 5);













--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
---- ===================================================
---- CATEGORÍA 4: Lácteos y derivados[cite: 42]
---- ===================================================
--('Leche UHT Eskimo Entera 200 ml', 'LECHE UHT ESKIMO ENTERA 200 ML (Cód: 20114)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Leche UHT Eskimo Entera 450 ml', 'LECHE UHT ESKIMO ENTERA 450 ML (Cód: 16991)', 4, 24, 22.00, 28.00, 1, GETDATE(), 5),
--('Leche UHT Eskimo Entera 900 ml', 'LECHE UHT ESKIMO ENTERA 900 ML (Cód: 16992)', 4, 12, 45.00, 56.00, 1, GETDATE(), 5),
--('Leche UHT Eskimo Semidescremada 450 ml', 'LECHE UHT ESKIMO SEMIDESCREMADA 450 ML (Cód: 17002)', 4, 24, 22.00, 28.00, 1, GETDATE(), 5),
--('Leche UHT Eskimo Semidescremada 900 ml', 'LECHE UHT ESKIMO SEMIDESCREMADA 900 ML (Cód: 17003)', 4, 12, 45.00, 56.00, 1, GETDATE(), 5),
--('Leche UHT Eskimo Fortificada 450 ml', 'LECHE UHT ESKIMO FORTIFICADA 450 ML (Cód: 16994)', 4, 24, 22.00, 28.00, 1, GETDATE(), 5),
--('Leche UHT Eskimo Fortificada 900 ml', 'LECHE UHT ESKIMO FORTIFICADA 900 ML (Cód: 16995)', 4, 12, 45.00, 56.00, 1, GETDATE(), 5),
--('Leche UHT Lala Entera 1 Litro', 'LALA ENTERA 1 LITRO (Cód: 25061)', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Leche UHT Lala Semidescremada 1 Litro', 'LALA SEMIDESCREMADA 1 LITRO (Cód: 25063)', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Leche UHT Lala Descremada 1 Litro', 'LALA DESCREMADA 1 LITRO (Cód: 25062)', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Leche UHT Lala Deslactosada 1 Litro', 'LALA DESLACTOSADA 1 LITRO (Cód: 25064)', 4, 12, 51.67, 62.00, 1, GETDATE(), 5),
--('Leche OH Lala Saborizada Fresa 200 ml', 'OH LALA FRESA 200 ML (Cód: 24766)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Leche OH Lala Saborizada Chocolate 200 ml', 'OH LALA CHOCOLATE 200 ML (Cód: 24765)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Leche OH Lala Saborizada Vainilla 200 ml', 'OH LALA VAINILLA 200 ML (Cód: 24764)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Lechelado Eskimo Fresa 200 ml', 'LECHELADO FRESA 200 ML (Cód: 17994)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Lechelado Eskimo Chocolate 200 ml', 'LECHELADO CHOCOLATE 200 ML (Cód: 17995)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Lechelado Eskimo Vainilla 200 ml', 'LECHELADO VAINILLA 200 ML (Cód: 17996)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Leche Saborizada Eskimo Fresa 200 ml', 'LECHE SABORIZADA FRESA 200 ML (Cód: 19550)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Leche Saborizada Eskimo Chocolate 200 ml', 'LECHE SABORIZADA CHOCOLATE 200 ML (Cód: 19545)', 4, 24, 15.00, 19.00, 1, GETDATE(), 5),
--('Leche Saborizada Eskimo Fresa 400 ml', 'LECHE SABORIZADA FRESA 400 ML (Cód: 19546)', 4, 12, 25.00, 32.00, 1, GETDATE(), 5),
--('Leche Saborizada Eskimo Chocolate 400 ml', 'LECHE SABORIZADA CHOCOLATE 400 ML (Cód: 19544)', 4, 12, 25.00, 32.00, 1, GETDATE(), 5),
--('Leche Saborizada Eskimo Chocolate 900 ml', 'LECHE SABORIZADA CHOCOLATE 900 ML (Cód: 16986)', 4, 6, 50.00, 62.00, 1, GETDATE(), 5),
--('Leche Vidamás 450 ml', 'VIDAMAS 450 ML (Cód: 16648)', 4, 24, 24.00, 30.00, 1, GETDATE(), 5),
--('Leche Vidamás 900 ml', 'VIDAMAS 900 ML (Cód: 16649)', 4, 12, 48.00, 58.00, 1, GETDATE(), 5),
--('Leche en Polvo Nutri Lety 120 g', 'NUTRI LETY EN POLVO 120 G (Cód: 24337)', 4, 20, 22.00, 28.00, 1, GETDATE(), 5),
--('Leche en Polvo Nutri Lety 420 g', 'NUTRI LETY EN POLVO 420 G (Cód: 24338)', 4, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Leche en Polvo Nutri Lety 1,825 g', 'NUTRI LETY EN POLVO 1,825 G (Cód: 24339)', 4, 4, 260.00, 315.00, 1, GETDATE(), 5),
--('Yogurt Nutri Lety 115 ml', 'YOGURT NUTRI LETY 115 ML (Cód: 20954)', 4, 24, 12.00, 16.00, 1, GETDATE(), 5),
--('Yogurt Lala Batido 125 g', 'LALA BATIDO 125 G (Cód: 18533/18534)', 4, 12, 14.00, 18.00, 1, GETDATE(), 5),
--('Yogurt Lala Kids', 'LALA KIDS (Cód: 24321)', 4, 12, 14.00, 18.00, 1, GETDATE(), 5),
--('Yogurt Lala Bebible 200 g', 'LALA BEBIBLE 200 G (Cód: 18536/18537/18590/18591)', 4, 12, 18.00, 24.00, 1, GETDATE(), 5),
--('Yogurt Lala Bebible 90 g', 'LALA BEBIBLE 90 G (Cód: 17251)', 4, 12, 10.00, 14.00, 1, GETDATE(), 5),
--('Yogurt La Perfecta Batido 150 g', 'LA PERFECTA BATIDO 150 G (Cód: 19675/19673/19672)', 4, 12, 15.00, 20.00, 1, GETDATE(), 5),
--('Yogurt La Perfecta Bebible 200 g', 'LA PERFECTA BEBIBLE 200 G (Cód: 21625/21626)', 4, 12, 18.00, 24.00, 1, GETDATE(), 5),
--('Yogurt La Perfecta Batido 750 g', 'LA PERFECTA BATIDO 750 G (Cód: 25360/25359)', 4, 6, 55.00, 68.00, 1, GETDATE(), 5),
--('Crema Nutri Lety 105 g', 'CREMA NUTRI LETY 105 G (Cód: 24818)', 4, 24, 12.00, 16.00, 1, GETDATE(), 5),
--('Crema Nutri Lety Bolsa 9 K', 'CREMA NUTRI LETY BOLSA 9 K (Cód: 24721)', 4, 1, 650.00, 780.00, 1, GETDATE(), 5),
--('Crema Nutri Lety 400 g', 'CREMA NUTRI LETY 400 G (Cód: 24728)', 4, 12, 45.00, 56.00, 1, GETDATE(), 5),
--('Crema Nutri Lety 200 g', 'CREMA NUTRI LETY 200 G (Cód: 24729)', 4, 12, 25.00, 32.00, 1, GETDATE(), 5),
--('Crema La Perfecta 420 g', 'CREMA LA PERFECTA 420 G (Cód: 25604)', 4, 12, 35.00, 44.00, 1, GETDATE(), 5),
--('Crema Dulce Eskimo', 'CREMA DULCE ESKIMO (Cód: 16643)', 4, 12, 30.00, 38.00, 1, GETDATE(), 5),
--('Fresco / Leche Pasteurizada Cacao 250 ml', 'FRESCO CACAO 250 ML (Cód: 18373/16708)', 4, 24, 18.00, 24.00, 1, GETDATE(), 5),
--('Fresco / Leche Pasteurizada Cacao 473 ml', 'FRESCO CACAO 473 ML (Cód: 18372/16710)', 4, 12, 32.00, 40.00, 1, GETDATE(), 5),
--('Fresco / Leche Pasteurizada Cacao 1/2 Galón', 'FRESCO CACAO 1/2 GALON (Cód: 18685/16705)', 4, 6, 55.00, 68.00, 1, GETDATE(), 5),
--('Fresco / Leche Pasteurizada Cacao 1 Galón', 'FRESCO CACAO 1 GALON (Cód: 18747/16706)', 4, 4, 100.00, 125.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 2: Aceites y grasas[cite: 42]
---- ===================================================
--('Mantequilla Eskimo 100g x4pz', 'MANTEQUILLA ESKIMO 100G X 4 PZ (Cód: 20153)', 2, 12, 35.00, 45.00, 1, GETDATE(), 5),
--('Mantequilla La Perfecta 100g x4pz', 'MANTEQUILLA LA PERFECTA 100G X 4 PZ (Cód: 19337)', 2, 12, 35.00, 45.00, 1, GETDATE(), 5),
--('Mantequilla La Perfecta 10g x42pz', 'MANTEQUILLA LA PERFECTA 10G X 42 PZ (Cód: 18932)', 2, 12, 40.00, 50.00, 1, GETDATE(), 5),
--('Margarina La Perfecta 450g x5pz', 'MARGARINA LA PERFECTA 450G X 5 PZ (Cód: 18960)', 2, 10, 55.00, 68.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 6: Gaseosas y jugos[cite: 42]
---- ===================================================
--('Bebidas Eskimo Sabor Manzana 235 ml', 'BEBIDA ESKIMO MANZANA 235 ML (Cód: 20148)', 6, 24, 10.00, 14.00, 1, GETDATE(), 5),
--('Bebidas Eskimo Sabor Fresa 235 ml', 'BEBIDA ESKIMO FRESA 235 ML (Cód: 20146)', 6, 24, 10.00, 14.00, 1, GETDATE(), 5),
--('Bebidas Eskimo Sabor Uva 235 ml', 'BEBIDA ESKIMO UVA 235 ML (Cód: 20149)', 6, 24, 10.00, 14.00, 1, GETDATE(), 5),
--('Bebidas La Perfecta 235 ml', 'BEBIDA LA PERFECTA 235 ML (Cód: 18375/18376/18377)', 6, 24, 10.00, 14.00, 1, GETDATE(), 5),
--('Néctar Mango Eskimo 400 ml', 'NECTAR MANGO 400 ML (Cód: 18961)', 6, 12, 18.00, 24.00, 1, GETDATE(), 5),
--('Néctar Mango Eskimo 900 ml', 'NECTAR MANGO 900 ML (Cód: 18962)', 6, 12, 38.00, 48.00, 1, GETDATE(), 5),
--('Néctar Naranja Eskimo 400 ml', 'NECTAR NARANJA 400 ML (Cód: 18833)', 6, 12, 18.00, 24.00, 1, GETDATE(), 5),
--('Néctar Naranja Eskimo 900 ml', 'NECTAR NARANJA 900 ML (Cód: 18834)', 6, 12, 38.00, 48.00, 1, GETDATE(), 5),
--('Néctar Naranja Eskimo 1/2 Galón', 'NECTAR NARANJA 1/2 GALON (Cód: 18835)', 6, 6, 65.00, 80.00, 1, GETDATE(), 5),
--('Néctar Naranja Eskimo Galón', 'NECTAR NARANJA GALON (Cód: 18836)', 6, 4, 120.00, 150.00, 1, GETDATE(), 5),
--('Fruit Punch Eskimo 1/2 Gin', 'FRUIT PUNCH 1/2 GLN (Cód: 16631)', 6, 6, 65.00, 80.00, 1, GETDATE(), 5),
--('Fruit Punch Eskimo 1 Gln', 'FRUIT PUNCH 1 GLN (Cód: 16632)', 6, 4, 120.00, 150.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Naranja Cartón 473 ml', 'JUGO LA PERFECTA NARANJA 473 ML (Cód: 1200002175)', 6, 12, 22.00, 30.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Piña Cartón 473 ml', 'JUGO LA PERFECTA PINA 473 ML (Cód: 1200002176)', 6, 12, 22.00, 30.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Manzana Cartón 473 ml', 'JUGO LA PERFECTA MANZANA 473 ML (Cód: 1200002177)', 6, 12, 22.00, 30.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Ponche de Frutas Cartón 473 ml', 'JUGO LA PERFECTA PONCHE 473 ML (Cód: 1200002178)', 6, 12, 22.00, 30.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Naranja Cartón 946 ml', 'JUGO LA PERFECTA NARANJA 946 ML (Cód: 1200002171)', 6, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Piña Cartón 946 ml', 'JUGO LA PERFECTA PINA 946 ML (Cód: 1200002172)', 6, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Ponche de Frutas Cartón 946 ml', 'JUGO LA PERFECTA PONCHE 946 ML (Cód: 1200002174)', 6, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Naranja Zanahoria PET 473 ml', 'JUGO PREMIUM NARANJA ZANAHORIA 473 ML (Cód: 1200002180)', 6, 12, 26.00, 35.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Naranja PET 473 ml', 'JUGO PREMIUM NARANJA 473 ML (Cód: 1200002181)', 6, 12, 26.00, 35.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Naranja Mandarina PET 473 ml', 'JUGO PREMIUM NARANJA MANDARINA 473 ML (Cód: 1200002593)', 6, 12, 26.00, 35.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Naranja Mandarina 1,750 ml', 'JUGO PREMIUM NARANJA MANDARINA 1.75L (Cód: 1200002190)', 6, 6, 95.00, 125.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Naranja Sin Pulpa 1,750 ml', 'JUGO PREMIUM NARANJA SIN PULPA 1.75L (Cód: 1200002188)', 6, 6, 95.00, 125.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Naranja Zanahoria 1,750 ml', 'JUGO PREMIUM NARANJA ZANAHORIA 1.75L (Cód: 1200002189)', 6, 6, 95.00, 125.00, 1, GETDATE(), 5),
--('Jugo La Perfecta Premium Ponche de Frutas 1,750 ml', 'JUGO PREMIUM PONCHE 1.75L (Cód: 1200002191)', 6, 6, 95.00, 125.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 11: Dulces y confitería[cite: 42]
---- ===================================================
--('Cajeta de Leche 100 g', 'CAJETA DE LECHE 100 G (Cód: 22472)', 11, 12, 18.00, 24.00, 1, GETDATE(), 5),
--('Gelatina La Perfecta 100 g', 'GELATINA LA PERFECTA 100 G (Cód: 18923/18926/18924/18925)', 11, 12, 10.00, 14.00, 1, GETDATE(), 5);
















--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo) VALUES 
---- ===================================================
---- CATEGORÍA 21: Higiene capilar y corporal (Shampoos, Acondicionadores, Cremas de peinar)[cite: 42]
---- ===================================================
--('Head & Shoulders Shamp. 2en1 Suave y Manejable + Pantene Equilibrio Ristra', 'HS 2EN1 SUAVE Y MANEJABLE 10MLX24 + PANTENE EQUILIBRANTE 10MLX4', 21, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Manzana + Pantene Pro-V Fuerza Ristra', 'HS MANZANA 10MLX24 + PANTENE FUERZA 10MLX4', 21, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Menta Refrescante + Pantene Fuerza Ristra', 'HS MENTA 10MLX24 + PANTENE FUERZA 10MLX4', 21, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Protección Caída + Pantene Crema Keratina Ristra', 'HS PROT CAIDA 10MLX24 + PANTENE CREMA KERATINA 9MLX4', 21, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Old Spice + Pantene 2en1 Rizos Ristra', 'HS OLD SPICE 10MLX24 + PANTENE 2EN1 RIZOS 10MLX4', 21, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Keratina + Crema Keratina Ristra', 'PANTENE KERATINA 10MLX24 + CREMA KERATINA 9MLX4', 21, 24, 80.00, 100.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema Keratina + Shamp. Keratina Ristra', 'PANTENE CREMA KERATINA 9MLX24 + SHAMP KERATINA 10MLX4', 21, 24, 80.00, 100.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. 2en1 Rizos + Crema Liso Ristra', 'PANTENE 2EN1 RIZOS 10MLX24 + CREMA LISO 9MLX4', 21, 24, 80.00, 100.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema Rizos + H&S Limpieza y Revitalización Ristra', 'PANTENE CREMA RIZOS 9MLX24 + HS LIMPIEZA 10MLX4', 21, 24, 80.00, 100.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Equilibrante + Crema Rizos Definidos Ristra', 'PANTENE EQUILIBRANTE 10MLX24 + CREMA RIZOS 9MLX4', 21, 24, 80.00, 100.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Keratina 18 ml Ristra', 'PANTENE SHAMP KERATINA 18ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Equilibrante 18 ml Ristra', 'PANTENE SHAMP EQUILIBRANTE 18ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. 2en1 Rizos Definidos 18 ml Ristra', 'PANTENE 2EN1 RIZOS 18ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema Peinar Rizos Definidos 16 ml Ristra', 'PANTENE CREMA RIZOS 16ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Miracle Colágeno 18 ml Ristra', 'PANTENE COLAGENO 18ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. 2en1 Suave y Manejable 18 ml Ristra', 'HS 2EN1 SUAVE Y MANEJABLE 18ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador 3 Minute Miracle Restauración 18 ml Ristra', 'PANTENE 3 MINUTE RESTAURACION 18ML X12', 21, 12, 50.00, 65.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Protección Caída con Cafeína 18 ml Ristra', 'HS PROT CAIDA CAFEINA 18ML X12', 21, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. 2en1 Suave y Manejable 90 ml', 'HS 2EN1 SUAVE Y MANEJABLE 90ML', 21, 24, 35.00, 45.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Men con Old Spice Control Caspa 90 ml', 'HS MEN OLD SPICE 90ML', 21, 24, 35.00, 45.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Limpieza Renovadora 90 ml', 'HS LIMPIEZA RENOVADORA 90ML', 21, 24, 35.00, 45.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. 2en1 Rizos Definidos 100 ml', 'PANTENE 2EN1 RIZOS 100ML', 21, 24, 40.00, 52.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Restauración 100 ml', 'PANTENE RESTAURACION 100ML', 21, 24, 40.00, 52.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Bambú 200 ml', 'PANTENE BAMBU 200ML', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Control Caída 200 ml', 'PANTENE CONTROL CAIDA 200ML', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Rizos Definidos 200 ml', 'PANTENE RIZOS DEFINIDOS 200ML', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Restauración 200 ml', 'PANTENE RESTAURACION 200ML', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. 2en1 Cuidado Clásico 200 ml', 'PANTENE 2EN1 CUIDADO CLASICO 200ML', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador Rizos Definidos 200 ml', 'PANTENE ACOND RIZOS DEFINIDOS 200ML', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Liso Extremo 400 ml', 'PANTENE LISO EXTREMO 400ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Restauración 400 ml', 'PANTENE RESTAURACION 400ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Rizos Definidos 400 ml', 'PANTENE RIZOS DEFINIDOS 400ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador Rizos Definidos 400 ml', 'PANTENE ACOND RIZOS 400ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Bambú 400 ml', 'PANTENE BAMBU 400ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Equilibrante Raíz y Puntas 300 ml', 'PANTENE EQUILIBRANTE 300ML', 21, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Miracles Colágeno Nutritivo 300 ml', 'PANTENE COLAGENO 300ML', 21, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Pantene Pro-V Shamp. Keratina 175 ml', 'PANTENE KERATINA 175ML', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador Hidratante Equilibrio 250 ml', 'PANTENE ACOND EQUILIBRIO 250ML', 21, 12, 85.00, 105.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador 3 Minute Miracle Restauración 170 ml', 'PANTENE 3 MINUTE RESTAURACION 170ML', 21, 12, 85.00, 105.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador 3 Minute Miracle Bambú 170 ml', 'PANTENE 3 MINUTE BAMBU 170ML', 21, 12, 85.00, 105.00, 1, GETDATE(), 5),
--('Pantene Pro-V Acondicionador 3 Minute Miracle Colágeno 170 ml', 'PANTENE 3 MINUTE COLAGENO 170ML', 21, 12, 85.00, 105.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema de Peinar Miracles Colágeno 300 ml', 'PANTENE CREMA COLAGENO 300ML', 21, 12, 90.00, 110.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema de Peinar Liso Extremo 300 ml', 'PANTENE CREMA LISO EXTREMO 300ML', 21, 12, 90.00, 110.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema de Peinar Rizos Definidos 300 ml', 'PANTENE CREMA RIZOS DEFINIDOS 300ML', 21, 12, 90.00, 110.00, 1, GETDATE(), 5),
--('Pantene Pro-V Crema de Peinar Rizos Definidos 2 Pack 300 ml', 'PANTENE CREMA RIZOS 2PACK 300ML', 21, 10, 160.00, 195.00, 1, GETDATE(), 5),
--('Pantene Shamp. Restauración 400 ml + Acondicionador 200 ml Pack', 'PANTENE PACK RESTAURACION 400+200ML', 21, 10, 140.00, 175.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Suave y Manejable Control Caspa 2en1 180 ml', 'HS SUAVE Y MANEJABLE 2EN1 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Limpieza Renovadora 180 ml', 'HS LIMPIEZA RENOVADORA 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Protección Caída con Cafeína 180 ml', 'HS PROT CAIDA CAFEINA 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Purificación Capilar Carbón Activado 180 ml', 'HS CARBON ACTIVADO 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Hidratación Aceite de Coco 180 ml', 'HS ACEITE DE COCO 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Control Caspa Crece Fuerte 180 ml', 'HS CRECE FUERTE 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Manzana Fresh 180 ml', 'HS MANZANA FRESH 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. 3 en 1 Men 180 ml', 'HS 3 EN 1 MEN 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Men con Old Spice Control Caspa 180 ml', 'HS MEN OLD SPICE 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Control Caspa Limpieza y Revitalización 180 ml', 'HS LIMPIEZA Y REVITALIZACION 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Menta Extra Refrescante 180 ml', 'HS MENTA 180ML', 21, 12, 60.00, 75.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Menta Extra Refrescante 375 ml', 'HS MENTA 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Suave y Manejable 2 en 1 375 ml', 'HS SUAVE Y MANEJABLE 2EN1 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Protección Caída con Cafeína 375 ml', 'HS PROT CAIDA CAFEINA 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Manzana Fresh 375 ml', 'HS MANZANA FRESH 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Limpieza Renovadora Control Caspa 375 ml', 'HS LIMPIEZA RENOVADORA 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Hidratación Aceite de Coco 375 ml', 'HS ACEITE DE COCO 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Control Caspa Limpieza y Revitalización 375 ml', 'HS LIMPIEZA Y REVITALIZACION 375ML', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. 2 en 1 Suave y Manejable 650 ml', 'HS 2EN1 SUAVE Y MANEJABLE 650ML', 21, 10, 180.00, 220.00, 1, GETDATE(), 5),
--('Head & Shoulders Crema de Peinar Hidratación Aceite de Coco 300 ml', 'HS CREMA ACEITE DE COCO 300ML', 21, 12, 90.00, 110.00, 1, GETDATE(), 5),
--('Head & Shoulders Crema de Peinar Suave y Manejable 300 ml', 'HS CREMA SUAVE Y MANEJABLE 300ML', 21, 12, 90.00, 110.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. 2en1 Suave y Manejable 375 ml + Shamp. 180 ml', 'HS PACK 2EN1 375+180ML', 21, 10, 135.00, 165.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Limpieza Renovadora 375 ml + Shamp. 180 ml', 'HS PACK LIMPIEZA 375+180ML', 21, 10, 135.00, 165.00, 1, GETDATE(), 5),
--('H&S Shamp. Protección Caída con Cafeína 375 ml + Shamp. 180 ml', 'HS PACK PROT CAIDA 375+180ML', 21, 10, 135.00, 165.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Purificación Carbón Activado 375 ml + Shamp. 180 ml', 'HS PACK CARBON 375+180ML', 21, 10, 135.00, 165.00, 1, GETDATE(), 5),
--('Head & Shoulders Shamp. Hidratación Aceite de Coco 375 ml + Shamp. 180 ml', 'HS PACK COCO 375+180ML', 21, 10, 135.00, 165.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 21 / 23: Desodorantes y antitranspirantes (Gillette, Old Spice, Secret)
---- ===================================================
--('Desodorante Gillette Hydra Gel con Aloe 45 g', 'GILLETTE HYDRA GEL ALOE 45G', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Desodorante Gillette Clear Gel Cool Wave 45 g', 'GILLETTE CLEAR GEL COOL WAVE 45G', 21, 12, 65.00, 80.00, 1, GETDATE(), 5),
--('Desodorante Gillette Power Beads Gel Power Rush 82 g', 'GILLETTE POWER BEADS RUSH 82G', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Desodorante Gillette Power Beads Gel Cool Wave 82 g', 'GILLETTE POWER BEADS WAVE 82G', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Desodorante Gillette Clear Gel Cool Wave 82 g', 'GILLETTE CLEAR GEL WAVE 82G', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Desodorante Gillette Clear Gel Sport Triumph 82 g', 'GILLETTE CLEAR GEL TRIUMPH 82G', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Desodorante Gillette Hydra Gel con Aloe 82 g', 'GILLETTE HYDRA GEL ALOE 82G', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Desodorante Gillette Hydra Gel con Vitamina E 82 g', 'GILLETTE HYDRA GEL VIT E 82G', 21, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Desodorante Gillette Spray Cool Wave 150 ml', 'GILLETTE SPRAY COOL WAVE 150ML', 21, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Fresh 85 g', 'OLD SPICE BARRA FRESH 85G', 21, 12, 115.00, 140.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Wolf Thorn 50 g', 'OLD SPICE WOLF THORN 50G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Pure Sport 50 g', 'OLD SPICE PURE SPORT 50G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Leña 50 g', 'OLD SPICE LENA 50G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Fresh 50 g', 'OLD SPICE BARRA FRESH 50G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Fresh 50 g Two Pack', 'OLD SPICE FRESH 2PACK 50G', 21, 6, 140.00, 175.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Ocean Legend 50 g', 'OLD SPICE OCEAN LEGEND 50G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Barra Adventure 50 g', 'OLD SPICE ADVENTURE 50G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Old Spice Body Spray Ocean Legend 96 g', 'OLD SPICE SPRAY OCEAN LEGEND 96G', 21, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Desodorante Secret Barra Invisible Powder Protect Cotton 45 g', 'SECRET POWDER COTTON 45G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Secret Barra Invisible Vainilla 45 g', 'SECRET VAINILLA 45G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Secret Barra Invisible Coconut 45 g', 'SECRET COCONUT 45G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Secret Invisible Gel Coconut 45 g', 'SECRET GEL COCONUT 45G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Secret Invisible Gel Vainilla 45 g', 'SECRET GEL VAINILLA 45G', 21, 12, 75.00, 92.00, 1, GETDATE(), 5),
--('Desodorante Secret Spray Seco Coconut 93 g', 'SECRET SPRAY COCONUT 93G', 21, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Desodorante Secret Spray Seco Vainilla 93 g', 'SECRET SPRAY VAINILLA 93G', 21, 12, 95.00, 118.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 24: Higiene general (Máquinas de afeitar y espumas)
---- ===================================================
--('Gillette Prestobarba Ultragrip Rosada Ristra x 24', 'PRESTOBARBA ROSADA RISTRA X24', 24, 24, 180.00, 220.00, 1, GETDATE(), 5),
--('Perma Sharp Máquina de Afeitar II Plus Blister x 28', 'PERMA SHARP II BLISTER X28', 24, 24, 190.00, 230.00, 1, GETDATE(), 5),
--('Gillette Prestobarba Máquina Blister x 24', 'PRESTOBARBA BLISTER X24', 24, 24, 180.00, 220.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Máquina Blister x 10', 'PRESTOBARBA 3 BLISTER X10', 24, 120, 150.00, 185.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Máquina Blister x 4', 'PRESTOBARBA 3 BLISTER X4', 24, 36, 75.00, 95.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Cool Blister x 4', 'PRESTOBARBA 3 COOL BLISTER X4', 24, 36, 75.00, 95.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Sensitive Blister x 4', 'PRESTOBARBA 3 SENSITIVE BLISTER X4', 24, 36, 75.00, 95.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Blister x 2', 'PRESTOBARBA 3 BLISTER X2', 24, 72, 40.00, 52.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Cool Blister x 2', 'PRESTOBARBA 3 COOL BLISTER X2', 24, 72, 40.00, 52.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Rosa Blister x 2', 'PRESTOBARBA 3 ROSA BLISTER X2', 24, 36, 40.00, 52.00, 1, GETDATE(), 5),
--('Gillette Prestobarba 3 Sensitive Blister x 2', 'PRESTOBARBA 3 SENSITIVE BLISTER X2', 24, 72, 40.00, 52.00, 1, GETDATE(), 5),
--('Gillette Venus Simply 3 Máquinas Blister x 8', 'VENUS SIMPLY 3 BLISTER X8', 24, 80, 140.00, 175.00, 1, GETDATE(), 5),
--('Gillette Venus Recargable Blister x 1', 'VENUS RECARGABLE BLISTER X1', 24, 36, 95.00, 118.00, 1, GETDATE(), 5),
--('Gillette Venus Skin Comfort Breeze Blister x 1', 'VENUS SKIN COMFORT BREEZE X1', 24, 6, 110.00, 135.00, 1, GETDATE(), 5),
--('Gillette Venus Skin Protect Sensitive Blister x 1', 'VENUS SKIN PROTECT SENSITIVE X1', 24, 12, 110.00, 135.00, 1, GETDATE(), 5),
--('Gillette Venus Repuesto con 3 Hojas Caja x 2', 'VENUS REPUESTO 3 HOJAS X2', 24, 24, 85.00, 105.00, 1, GETDATE(), 5),
--('Gillette Venus Simply 3 Blister x 2', 'VENUS SIMPLY 3 BLISTER X2', 24, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Gillette Mach3 Recargable Caja x 1', 'MACH3 RECARGABLE CAJA X1', 24, 30, 120.00, 150.00, 1, GETDATE(), 5),
--('Gillette Mach3 Sensitive Recargable Caja x 1', 'MACH3 SENSITIVE RECARGABLE X1', 24, 30, 120.00, 150.00, 1, GETDATE(), 5),
--('Gillette Mach3 Repuesto con 3 Hojas Caja x 2', 'MACH3 REPUESTO 3 HOJAS X2', 24, 72, 110.00, 135.00, 1, GETDATE(), 5),
--('Gillette Mach3 Sensitive Repuesto con 3 Hojas Caja x 2', 'MACH3 SENSITIVE REPUESTO X2', 24, 72, 110.00, 135.00, 1, GETDATE(), 5),
--('Gillette Espuma para Afeitar Mentol 175 g', 'ESPUMA AFEITAR MENTOL 175G', 24, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Gillette Espuma para Afeitar Sensitive 175 g', 'ESPUMA AFEITAR SENSITIVE 175G', 24, 12, 95.00, 118.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 22: Higiene oral (Cepillos y pastas dentales Oral-B / Crest)
---- ===================================================
--('Oral-B Cepillo Dental Kids Blister x 1', 'CEPILLO ORAL-B KIDS X1', 22, 36, 25.00, 32.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental Stages Frozen 75 ml', 'PASTA ORAL-B STAGES FROZEN 75ML', 22, 12, 55.00, 68.00, 1, GETDATE(), 5),
--('Oral-B Kids Pasta Dental Pro-Salud Surtido 75 ml', 'PASTA ORAL-B PRO-SALUD KIDS 75ML', 22, 12, 55.00, 68.00, 1, GETDATE(), 5),
--('Oral-B Kids Pasta Dental Anticaries Sabor Chicle 37 ml', 'PASTA ORAL-B KIDS CHICLE 37ML', 22, 24, 30.00, 38.00, 1, GETDATE(), 5),
--('Oral-B Kids Pasta Dental Princesas 37 ml', 'PASTA ORAL-B KIDS PRINCESAS 37ML', 22, 24, 30.00, 38.00, 1, GETDATE(), 5),
--('Oral-B Cepillos Dentales 123 Medio Blister x 6', 'CEPILLOS ORAL-B 123 MEDIO X6', 22, 6, 120.00, 150.00, 1, GETDATE(), 5),
--('Oral-B Cepillos Dentales Complete Clean Medio Blister x 2', 'CEPILLOS COMPLETE CLEAN X2', 22, 36, 45.00, 58.00, 1, GETDATE(), 5),
--('Oral-B Cepillo Dental Indicator Clean Medio Blister x 2', 'CEPILLO INDICATOR CLEAN X2', 22, 36, 45.00, 58.00, 1, GETDATE(), 5),
--('Oral-B Cepillos Dentales Indicator Color Collection Suave Dispensador x 4', 'CEPILLOS INDICATOR COLOR X4', 22, 36, 85.00, 105.00, 1, GETDATE(), 5),
--('Oral-B Cepillos Dentales Advanced Suave 7 Beneficios Blister x 2', 'CEPILLOS ADVANCED 7 BENEFICIOS X2', 22, 36, 50.00, 65.00, 1, GETDATE(), 5),
--('Oral-B Cepillo Dental Advanced Radiant Medio Blister x 2', 'CEPILLO ADVANCED RADIANT X2', 22, 36, 50.00, 65.00, 1, GETDATE(), 5),
--('Oral-B Cepillo Dental Detox Sensitive Extra Suave Blister x 3', 'CEPILLO DETOX SENSITIVE X3', 22, 36, 75.00, 95.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental Complete 4 en 1 con Flúor 3 Pack 80 g', 'PASTA ORAL-B COMPLETE 3PACK 80G', 22, 8, 95.00, 118.00, 1, GETDATE(), 5),
--('Oral-B Complete Crema Dental Menta Refrescante 3 Pack 90 g', 'PASTA ORAL-B MENTA 3PACK 90G', 22, 8, 95.00, 118.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental Complete 4 en 1 con Flúor 80 g', 'PASTA ORAL-B COMPLETE 80G', 22, 24, 35.00, 45.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental Extra Blancura 150 ml', 'PASTA ORAL-B EXTRA BLANCURA 150ML', 22, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Crest Pasta Dental Anti-Sarro 66 ml', 'CREST ANTI-SARRO 66ML', 22, 36, 30.00, 38.00, 1, GETDATE(), 5),
--('Crest Pasta Dental Anti-Azúcar 140 ml', 'CREST ANTI-AZUCAR 140ML', 22, 24, 65.00, 80.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental 3D White Brilliant Fresh 53 ml', 'ORAL-B 3D WHITE 53ML', 22, 24, 45.00, 58.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental 3D White Brilliant Fresh 107 ml', 'ORAL-B 3D WHITE 107ML', 22, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental 3D White Brilliant Fresh 2 Pack 75 ml', 'ORAL-B 3D WHITE 2PACK 75ML', 22, 12, 90.00, 112.00, 1, GETDATE(), 5),
--('Oral-B Pasta Dental Detox Deep Clean 75 ml', 'ORAL-B DETOX DEEP CLEAN 75ML', 22, 12, 65.00, 80.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 17 / 18: Lavandería y limpieza general (Downy)
---- ===================================================
--('Downy Suavizante Concentrado Brisa Fresca 80 ml Ristra x 12', 'DOWNY BRISA FRESCA 80ML X12', 17, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Aroma Floral 80 ml Ristra x 12', 'DOWNY AROMA FLORAL 80ML X12', 17, 12, 45.00, 58.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Aroma Floral 600 ml', 'DOWNY AROMA FLORAL 600ML', 17, 12, 65.00, 82.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Aroma Floral 800 ml', 'DOWNY AROMA FLORAL 800ML', 17, 9, 85.00, 105.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Perfume Passion 750 ml', 'DOWNY PERFUME PASSION 750ML', 17, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Perfume Elegance 750 ml', 'DOWNY PERFUME ELEGANCE 750ML', 17, 12, 95.00, 118.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Amanecer 730 ml', 'DOWNY AMANECER 730ML', 17, 9, 90.00, 112.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Pureza Silvestre 1.4 L', 'DOWNY PUREZA SILVESTRE 1.4L', 17, 9, 130.00, 160.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Aroma Floral 1.4 L', 'DOWNY AROMA FLORAL 1.4L', 17, 9, 130.00, 160.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Amanecer 2.8 L', 'DOWNY AMANECER 2.8L', 17, 6, 240.00, 295.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Aroma Floral 2.8 L', 'DOWNY AROMA FLORAL 2.8L', 17, 6, 240.00, 295.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Pureza Silvestre 2.8 L', 'DOWNY PUREZA SILVESTRE 2.8L', 17, 6, 240.00, 295.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Aroma Floral 4.8 L', 'DOWNY AROMA FLORAL 4.8L', 17, 2, 380.00, 465.00, 1, GETDATE(), 5),
--('Downy Suavizante Concentrado Amanecer 4.8 L', 'DOWNY AMANECER 4.8L', 17, 2, 380.00, 465.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 25 / 26: Analgésicos, salud digestiva y primeros auxilios (Vick, Metamucil, Pepto-Bismol, Cebión)
---- ===================================================
--('Vick 44 Expectorante Infantil 120 ml', 'VICK 44 EXPECTORANTE INFANTIL 120ML', 25, 48, 95.00, 118.00, 1, GETDATE(), 5),
--('Inhaladores Vick 197 mg Dispensador x 75', 'INHALADORES VICK DISPENSADOR X75', 25, 75, 45.00, 58.00, 1, GETDATE(), 5),
--('Vick VapoRub Pomo x 100 g', 'VICK VAPORUB 100G', 25, 48, 120.00, 150.00, 1, GETDATE(), 5),
--('Vick VapoRub Pomo x 50 g', 'VICK VAPORUB 50G', 25, 96, 75.00, 95.00, 1, GETDATE(), 5),
--('Vick VapoRub 12 g Lata Dispensador x 12', 'VICK VAPORUB 12G LATA X12', 25, 30, 15.00, 19.00, 1, GETDATE(), 5),
--('Metamucil Natural Pomo x 504 g', 'METAMUCIL NATURAL 504G', 26, 6, 280.00, 345.00, 1, GETDATE(), 5),
--('Metamucil Natural Pomo x 210 g', 'METAMUCIL NATURAL 210G', 26, 12, 150.00, 185.00, 1, GETDATE(), 5),
--('Metamucil Naranja Pomo x 425 g', 'METAMUCIL NARANJA 425G', 26, 6, 250.00, 310.00, 1, GETDATE(), 5),
--('Metamucil Naranja Pomo x 174 g', 'METAMUCIL NARANJA 174G', 26, 6, 130.00, 160.00, 1, GETDATE(), 5),
--('Pepto-Bismol Fco x 118 ml', 'PEPTO-BISMOL 118ML', 26, 12, 65.00, 82.00, 1, GETDATE(), 5),
--('Pepto-Bismol Fco x 236 ml', 'PEPTO-BISMOL 236ML', 26, 12, 110.00, 138.00, 1, GETDATE(), 5),
--('Pepto-Bismol Fco x 473 ml', 'PEPTO-BISMOL 473ML', 26, 12, 195.00, 240.00, 1, GETDATE(), 5),
--('Pepto-Bismol Ristra x 24 Tabletas Masticables', 'PEPTO-BISMOL RISTRA 24 TAB', 26, 24, 75.00, 95.00, 1, GETDATE(), 5),
--('Cebión 500 mg Naranja Dispensador x 40 Tab Masticables', 'CEBION 500MG NARANJA X40', 25, 54, 95.00, 118.00, 1, GETDATE(), 5),

---- ===================================================
---- CATEGORÍA 23: Cuidado femenino y del bebé (Pampers)
---- ===================================================
--('Pampers Confort Sec Talla M Bolsa x 20', 'PAMPERS CONFORT SEC M 20UN', 23, 8, 120.00, 150.00, 1, GETDATE(), 5),
--('Pampers Confort Sec Talla G Bolsa x 20', 'PAMPERS CONFORT SEC G 20UN', 23, 8, 120.00, 150.00, 1, GETDATE(), 5),
--('Pampers Confort Sec Talla XG Bolsa x 16', 'PAMPERS CONFORT SEC XG 16UN', 23, 8, 120.00, 150.00, 1, GETDATE(), 5),
--('Pampers Confort Sec Talla XXG Bolsa x 16', 'PAMPERS CONFORT SEC XXG 16UN', 23, 8, 120.00, 150.00, 1, GETDATE(), 5),
--('Pampers Swaddlers Recién Nacido Talla 0 Bolsa x 31', 'PAMPERS SWADDLERS T0 31UN', 23, 4, 140.00, 175.00, 1, GETDATE(), 5),
--('Pampers Swaddlers Recién Nacido Talla 1 Bolsa x 32', 'PAMPERS SWADDLERS T1 32UN', 23, 4, 140.00, 175.00, 1, GETDATE(), 5),
--('Pampers Baby Dry Talla 2 Bolsa x 37', 'PAMPERS BABY DRY T2 37UN', 23, 4, 160.00, 198.00, 1, GETDATE(), 5),
--('Pampers Baby Dry Talla 3 Bolsa x 32', 'PAMPERS BABY DRY T3 32UN', 23, 4, 160.00, 198.00, 1, GETDATE(), 5),
--('Pampers Baby Dry Talla 4 Bolsa x 28', 'PAMPERS BABY DRY T4 28UN', 23, 4, 160.00, 198.00, 1, GETDATE(), 5),
--('Pampers Baby Dry Talla 5 Bolsa x 24', 'PAMPERS BABY DRY T5 24UN', 23, 4, 160.00, 198.00, 1, GETDATE(), 5),
--('Pampers Baby Dry Talla 6 Bolsa x 21', 'PAMPERS BABY DRY T6 21UN', 23, 4, 160.00, 198.00, 1, GETDATE(), 5),
--('Pampers Baby Wipes Sensitive Sin Fragancia x 56 Toallitas', 'PAMPERS WIPES SENSITIVE 56UN', 23, 8, 45.00, 58.00, 1, GETDATE(), 5),
--('Pampers Baby Wipes Sin Fragancia x 72 Toallitas', 'PAMPERS WIPES SIN FRAGANCIA 72UN', 23, 8, 55.00, 70.00, 1, GETDATE(), 5),
--('Pampers Baby Wipes Baby Fresh x 72 Toallitas', 'PAMPERS WIPES BABY FRESH 72UN', 23, 8, 55.00, 70.00, 1, GETDATE(), 5);
















--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--VALUES 
---- Embutidos y salchichas
--('Salchicha Hot Dog Delmor', 'Salchicha Hot Dog Delmor (454 g)', 13, 25, 38.00, 52.00, 1, GETDATE(), 5),
--('Chorizo Delmor Criollo', 'Chorizo Delmor Criollo (227 g)', 13, 20, 45.00, 60.00, 1, GETDATE(), 4),

---- Mortadelas
--('Mortadela Económica Delmor', 'Mortadela Económica Delmor (225 g / 454 g)', 13, 30, 48.00, 63.00, 1, GETDATE(), 6),
--('Mortadela con Chiltoma Delmor', 'Mortadela con Chiltoma Delmor (225 g)', 13, 30, 50.00, 68.00, 1, GETDATE(), 6),

---- Hamburguesas y carnes procesadas
--('Torta Hamburguesa de Pollo Delmor', 'Torta Hamburguesa de Pollo Delmor (454 g)', 13, 18, 90.00, 115.00, 1, GETDATE(), 4),

---- Productos ahumados y de temporada
--('Tocino Delmor Ahumado', 'Tocino Delmor Ahumado (1000 g)', 13, 15, 330.00, 420.00, 1, GETDATE(), 3),
--('Roller Ham Delmor', 'Roller Ham, Pollo Ahumado, Costillas Ahumadas, Pierna Ahumada', 13, 10, 250.00, 320.00, 1, GETDATE(), 2),
--('Jamón Selva Negra Delmor', 'Jamón Selva Negra y Jamón Virginia', 13, 12, 280.00, 350.00, 1, GETDATE(), 3);





----------------------------------------------------------------------------------------------------------------------------------------------------

--SELECT Nombre, COUNT(*) AS TotalRepeticiones
--FROM Producto
--GROUP BY Nombre
--HAVING COUNT(*) > 1;




--WITH CTE_Duplicados AS (
--    SELECT IdProducto,
--           ROW_NUMBER() OVER (PARTITION BY Nombre ORDER BY IdProducto ASC) AS RowNum
--    FROM Producto
--)
--DELETE FROM CTE_Duplicados
--WHERE RowNum > 1;



--ALTER TABLE Producto
--ADD CONSTRAINT UQ_Nombre_Producto UNIQUE (Nombre);


---------------------------------------------------------------------------------------------------------------------------------------------------------------


--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--VALUES 
---- Categoría 16: Especias y sazonadores (Consomés y sazonadores Maggi)
--('Consomé de Pollo Maggi', 'Consomé de pollo Maggi en sobre (12x10g)', 16, 30, 22.00, 30.00, 1, GETDATE(), 5),
--('Sabor y Color Maggi', 'Sazonador Sabor y Color Maggi', 16, 25, 18.00, 25.00, 1, GETDATE(), 5),
--('Mi Sazón Maggi', 'Mi Sazón Maggi con gallinita', 16, 40, 15.00, 22.00, 1, GETDATE(), 6),
--('Sazonador Res Maggi', 'Sazonador de res Maggi', 16, 25, 15.00, 22.00, 1, GETDATE(), 5),
--('Cubito Maggi Pollo', 'Cubitos de pollo Maggi caja 60 unidades', 16, 50, 85.00, 110.00, 1, GETDATE(), 10),
--('Naturísimo Sazonador Completo Maggi', 'Sazonador completo Naturísimo frasco 225g', 16, 20, 65.00, 85.00, 1, GETDATE(), 4),
--('Sazonador Pollo De la Huerta', 'Sazonador De la Huerta sabor Pollo', 16, 15, 12.00, 18.00, 1, GETDATE(), 3),
--('Sazonador Cerdo De la Huerta', 'Sazonador De la Huerta sabor Cerdo', 16, 15, 12.00, 18.00, 1, GETDATE(), 3),
--('Sazonador Res De la Huerta', 'Sazonador De la Huerta sabor Res', 16, 15, 12.00, 18.00, 1, GETDATE(), 3),

---- Categoría 14: Sopas instantáneas (Sopas de sobre y criollas Maggi)
--('Sopa Pollo con Caracolitos Maggi', 'Sopa Clara Maggi sabor Pollo con Caracolitos', 14, 30, 14.00, 19.00, 1, GETDATE(), 6),
--('Sopa Pollo con Fideos Maggi', 'Sopa Clara Maggi sabor Pollo con Fideos', 14, 30, 14.00, 19.00, 1, GETDATE(), 6),
--('Sopa Res con Fideos Maggi', 'Sopa Clara Maggi sabor Res con Fideos', 14, 30, 14.00, 19.00, 1, GETDATE(), 6),
--('Sopa Pollo con Letras Maggi', 'Sopa Clara Maggi sabor Pollo con Letras', 14, 25, 14.00, 19.00, 1, GETDATE(), 5),
--('Sopa Pollo con Arroz Maggi', 'Sopa Clara Maggi sabor Pollo con Arroz', 14, 25, 14.00, 19.00, 1, GETDATE(), 5),
--('Sopa Criolla Costilla Maggi', 'Sopa Criolla sabor Costilla 58g', 14, 20, 16.00, 22.00, 1, GETDATE(), 4),
--('Sopa Criolla Gallina con Fideos Maggi', 'Sopa Criolla sabor Gallina con Fideos 60g', 14, 20, 16.00, 22.00, 1, GETDATE(), 4),

---- Categoría 4: Lácteos y derivados (Leches, lácteos en polvo y fórmulas infantiles)
--('Lechera Nestlé Lata', 'Leche condensada La Lechera 387g', 4, 35, 62.00, 78.00, 1, GETDATE(), 8),
--('Leche Evaporada Ideal Nestlé', 'Leche evaporada Ideal 315g', 4, 30, 35.00, 45.00, 1, GETDATE(), 6),
--('Leche Nido 1+ Lata', 'Fórmula de crecimiento Nido 1+ 800g', 4, 15, 420.00, 495.00, 1, GETDATE(), 3),
--('Leche Nido 3+ Lata', 'Fórmula de crecimiento Nido 3+ 800g', 4, 15, 420.00, 495.00, 1, GETDATE(), 3),
--('Leche Nido 5+ Lata', 'Fórmula de crecimiento Nido 5+ 800g', 4, 15, 420.00, 495.00, 1, GETDATE(), 3),
--('Nido Forticrece Lata o Bolsa', 'Nido Forticrece 350g', 4, 25, 175.00, 215.00, 1, GETDATE(), 5),
--('Nan Optipro 1', 'Fórmula infantil de inicio Nan Optipro 1 (400g)', 4, 10, 380.00, 460.00, 1, GETDATE(), 2),
--('Nan Optipro 2', 'Fórmula infantil de seguimiento Nan Optipro 2 (400g)', 4, 10, 380.00, 460.00, 1, GETDATE(), 2),
--('Nan Optipro 3', 'Fórmula infantil de crecimiento Nan Optipro 3 (800g)', 4, 10, 680.00, 790.00, 1, GETDATE(), 2),
--('Nestogeno 1', 'Fórmula infantil de inicio Nestogeno 1 (400g)', 4, 12, 290.00, 350.00, 1, GETDATE(), 3),
--('Nestogeno 2', 'Fórmula infantil de seguimiento Nestogeno 2 (400g)', 4, 12, 290.00, 350.00, 1, GETDATE(), 3),

---- Categoría 34: Pastas y cereales (Cereales infantiles Nestum y Corn Flakes)
--('Cereal Nestum Arroz', 'Cereal infantil Nestum Arroz caja 200g', 34, 20, 75.00, 95.00, 1, GETDATE(), 4),
--('Cereal Nestum 5 Cereales', 'Cereal infantil Nestum 5 Cereales caja 200g', 34, 20, 75.00, 95.00, 1, GETDATE(), 4),
--('Cereal Nestum Trigo Miel', 'Cereal infantil Nestum Trigo Miel caja 200g', 34, 20, 75.00, 95.00, 1, GETDATE(), 4),
--('Cereal Corn Flakes Nestlé', 'Cereal de maíz Corn Flakes Sin Gluten 235g', 34, 18, 80.00, 105.00, 1, GETDATE(), 4),

---- Categoría 33: Otros Productos (Compotas / Colados Gerber)
--('Colado Gerber Manzana', 'Puré o colado Gerber sabor Manzana 100g', 33, 25, 24.00, 32.00, 1, GETDATE(), 5),
--('Colado Gerber Pera', 'Puré o colado Gerber sabor Pera 100g', 33, 25, 24.00, 32.00, 1, GETDATE(), 5),
--('Colado Gerber Banano', 'Puré o colado Gerber sabor Banano 100g', 33, 25, 24.00, 32.00, 1, GETDATE(), 5),

---- Categoría 6: Gaseosas y jugos / Bebidas saborizadas (Nesquik)
--('Nesquik Chocolate Lata', 'Bebida en polvo sabor chocolate Nesquik 400g', 6, 20, 115.00, 145.00, 1, GETDATE(), 4),
--('Nesquik Fresa Bolsa', 'Bebida en polvo sabor fresa Nesquik 14.1oz', 6, 20, 110.00, 138.00, 1, GETDATE(), 4),

---- Categoría 35: Café e infusiones (Nescafé y Presto)
--('Café Nescafé Clásico Frasco', 'Café 100% puro soluble Nescafé Clásico 225g', 35, 25, 210.00, 260.00, 1, GETDATE(), 5),
--('Café Nescafé 3 en 1', 'Mezcla instantánea de café sobre individual', 35, 30, 6.50, 9.00, 1, GETDATE(), 6),
--('Café Instantáneo Presto', 'Café 100% puro Presto 144g', 35, 30, 95.00, 120.00, 1, GETDATE(), 6);







-------------------------------------------
--truncate table cliente;



---- 1. Borra únicamente los registros (esto NO elimina la estructura ni la tabla)
--DELETE FROM Cliente;

---- 2. (Opcional) Si quieres reiniciar el ID para que el próximo cliente empiece desde 1
--DBCC CHECKIDENT ('Cliente', RESEED, 0);









--    -- ==========================================================
---- 1. LIMPIEZA DE DATOS (Respetando las Llaves Foráneas)
---- ==========================================================

---- Borrar primero los detalles o tablas dependientes de Compras y Ventas
--DELETE FROM DetalleVenta;
--DELETE FROM DetalleCompra;

---- Borrar Ventas y Compras
--DELETE FROM Venta;
--DELETE FROM Compra;

---- Borrar Clientes
--DELETE FROM Cliente

---- Reiniciar los contadores de identidad (IDs numéricos si los usan)
--DBCC CHECKIDENT ('DetalleVenta', RESEED, 0);
--DBCC CHECKIDENT ('DetalleCompra', RESEED, 0);
--DBCC CHECKIDENT ('Venta', RESEED, 0);
--DBCC CHECKIDENT ('Compra', RESEED, 0);
--DBCC CHECKIDENT ('Clientes', RESEED, 0);


---- ==========================================================
---- 2. INSERCIÓN DE LOS 30 CLIENTES NUEVOS
---- ==========================================================

--INSERT INTO Cliente (DNI, Nombre1, Nombre2, Apellido1, Apellido2, Correo, Telefono, Estado, FechaCreacion)
--VALUES 
--    ('001-230595-1001A', 'CARLOS', 'ALBERTO', 'GOMEZ', 'RIVAS', 'carlos.gomez@gmail.com', '+50588881234', 1, GETDATE()),
--    ('002-140290-2002B', 'MARIA', 'JOSE', 'PEREZ', 'LARA', 'mjose.perez@hotmail.com', '87654321', 1, GETDATE()),
--    ('003-051185-3003C', 'LUIS', NULL, 'RODRIGUEZ', 'MENDEZ', 'luis.rodriguez@yahoo.com', '+50577775678', 0, GETDATE()),
--    ('004-201200-4004D', 'ANA', 'PATRICIA', 'FLORES', 'CASTILLO', 'ana.flores@gmail.com', '81234567', 1, GETDATE()),
--    ('005-300692-5005E', 'JOSE', 'MANUEL', 'TORRES', NULL, 'jtorres@outlook.com', '+50589990000', 1, GETDATE()),
--    ('006-120394-6006F', 'SOFIA', 'MARGARITA', 'RUIZ', 'JIMENEZ', 'sofia.ruiz@gmail.com', '+50582223344', 1, GETDATE()),
--    ('007-250888-7007G', 'MIGUEL', 'ANGEL', 'CASTRO', 'MORALES', 'miguel.castro@hotmail.com', '88112233', 1, GETDATE()),
--    ('008-030995-8008H', 'CLAUDIA', NULL, 'HERRERA', 'ORTIZ', 'claudia.herrera@yahoo.com', '+50578889900', 0, GETDATE()),
--    ('009-150601-9009I', 'FRANCISCO', 'JAVIER', 'MEDINA', 'GUTIERREZ', 'fjavier.medina@gmail.com', '89445566', 1, GETDATE()),
--    ('010-301193-1010J', 'DANIELA', 'VALENTINA', 'SILVA', NULL, 'daniela.silva@outlook.com', '+50583334455', 1, GETDATE()),
--    ('011-180496-1011K', 'GABRIEL', 'ENRIQUE', 'VARGAS', 'NAVARRO', 'gabriel.vargas@gmail.com', '+50584445566', 1, GETDATE()),
--    ('012-090791-1012L', 'VALERIA', 'ISABEL', 'ROJAS', 'CHAVEZ', 'valeria.rojas@hotmail.com', '86667788', 1, GETDATE()),
--    ('013-220187-1013M', 'ROBERTO', NULL, 'MENDOZA', 'RIOS', 'roberto.mendoza@yahoo.com', '+50575556677', 0, GETDATE()),
--    ('014-111098-1014N', 'ADRIANA', 'LUCIA', 'AGUILAR', 'CRUZ', 'adriana.aguilar@gmail.com', '82221100', 1, GETDATE()),
--    ('015-040593-1015O', 'FERNANDO', 'JOSE', 'SUAREZ', NULL, 'fsuarez@outlook.com', '+50581112233', 1, GETDATE()),
--    ('016-280299-1016P', 'CAMILA', 'FERNANDA', 'SANTOS', 'VEGA', 'camila.santos@gmail.com', '+50587778899', 1, GETDATE()),
--    ('017-140886-1017Q', 'ALEJANDRO', 'DAVID', 'DELGADO', 'CAMPOS', 'ale.delgado@hotmail.com', '83332211', 1, GETDATE()),
--    ('018-070392-1018R', 'LUCIA', NULL, 'PEÑA', 'IBARRA', 'lucia.pena@yahoo.com', '+50571112233', 0, GETDATE()),
--    ('019-191197-1019S', 'DIEGO', 'ALONSO', 'CABRERA', 'FUENTES', 'diego.cabrera@gmail.com', '85554433', 1, GETDATE()),
--    ('020-020101-1020T', 'NATALIA', 'SOFIA', 'CARRASCO', NULL, 'natalia.carrasco@outlook.com', '+50586665544', 1, GETDATE()),
--    ('021-130990-1021U', 'ESTEBAN', 'MANUEL', 'LARA', 'SOLIS', 'esteban.lara@gmail.com', '+50589998877', 1, GETDATE()),
--    ('022-270489-1022V', 'PAOLA', 'ANDREA', 'VALDEZ', 'ACosta', 'paola.valdez@hotmail.com', '84443322', 1, GETDATE()),
--    ('023-080695-1023W', 'GONZALO', NULL, 'FIGUEROA', 'DUARTE', 'gonzalo.figueroa@yahoo.com', '+50579998811', 0, GETDATE()),
--    ('024-310893-1024X', 'BEATRIZ', 'ELENA', 'MEJIA', 'OCHOA', 'beatriz.mejia@gmail.com', '82223344', 1, GETDATE()),
--    ('025-160298-1025Y', 'RICARDO', 'ANTONIO', 'PARRA', NULL, 'rparra@outlook.com', '+50585556677', 1, GETDATE()),
----    ('026-050794-1026Z', 'ELENA', 'MARIA', 'CORTES', 'GARCIA', 'elena.cortes@gmail.com', '+50588889900', 1, GETDATE()),
----    ('027-211285-1027A', 'HECTOR', 'LUIS', 'NUNEZ', 'ZUNIGA', 'hector.nunez@hotmail.com', '87776655', 1, GETDATE()),
----    ('028-100300-1028B', 'MONICA', NULL, 'SOTO', 'VALENZUELA', 'monica.soto@yahoo.com', '+50573334455', 0, GETDATE()),
----    ('029-240992-1029C', 'JORGE', 'ALBERTO', 'MORA', 'ARIAS', 'jorge.mora@gmail.com', '86665544', 1, GETDATE()),
----    ('030-010597-1030D', 'VANESSA', 'CAROLINA', 'ROBLES', NULL, 'vanessa.robles@outlook.com', '+50582221100', 1, GETDATE());



--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    -- Categoría 24: Higiene general (Papel higiénico y Rasuradoras)
--    ('Papel higenico Scott 1000hjs Economil', 'Papel higenico Scott 1000hjs Economil 1x24x1000', 24, 24, 15.00, 22.00, 1, 5),
--    ('Papel higenico Scott 2 en 1 4pack', 'Papel higenico Scott 2 en 1 4pack 4x12x200', 24, 12, 12.00, 18.00, 1, 5),
--    ('Resuradora Bic Comfort Sensitive 12', 'Resuradora Bic Comfort Sensitive 12 1x48x12', 24, 48, 80.00, 110.00, 1, 5),
--    ('Resuradora Bic Comfort Sensitive 12+2', 'Resuradora Bic Comfort Sensitive 12+2 1x48x12', 24, 48, 85.00, 115.00, 1, 5),
--    ('Resuradora Bic Shaver Sensitive', 'Resuradora Bic Shaver Sensitive 1x48x24', 24, 48, 50.00, 70.00, 1, 5),
--    ('Resuradora Bic Twin Lady', 'Resuradora Bic Twin Lady 1x24x12', 24, 24, 45.00, 62.00, 1, 5),
--    ('Bic Hoja Doble Filo Lamina de Acero', 'Bic Hoja Doble Filo Lamina de Acero 1x240x100', 24, 240, 200.00, 270.00, 1, 5),
--    ('Resuradora Bic Comfort 3 Action Blister', 'Resuradora Bic Comfort 3 Action Blister 1x36', 24, 36, 90.00, 125.00, 1, 5),

--    -- Categoría 23: Cuidado femenino y del... (Toallas sanitarias, protectores, toallas húmedas y pañales)
--    ('Toa Fem Kot Esencial S/A', 'Toa Fem Kot Esencial S/A 24x10', 23, 24, 10.00, 15.00, 1, 5),
--    ('Toa Fem Kot Esencial C/A', 'Toa Fem Kot Esencial C/A 24x10', 23, 24, 10.00, 15.00, 1, 5),
--    ('Toa Fem Kot Esencial C/A Manzanilla', 'Toa Fem Kot Esencial C/A Manzanilla 24x10', 23, 24, 10.00, 15.00, 1, 5),
--    ('Toa Fem Kot Esencial S/A Tela TTX RVP', 'Toa Fem Kot Esencial S/A Tela TTX RVP 24x12', 23, 24, 11.00, 16.00, 1, 5),
--    ('Toa Fem Kot Noct. C/A', 'Toa Fem Kot Noct. C/A 16x8', 23, 16, 12.00, 18.00, 1, 5),
--    ('Toa Fem Kot Noct. C/A Manzanilla', 'Toa Fem Kot Noct. C/A Manzanilla 16x8', 23, 16, 12.00, 18.00, 1, 5),
--    ('Toa Fem Kot Noct. S/A', 'Toa Fem Kot Noct. S/A 16x8', 23, 16, 12.00, 18.00, 1, 5),
--    ('Toa Fem Kot Noct. S/A 8+2', 'Toa Fem Kot Noct. S/A 16x10', 23, 16, 13.00, 19.00, 1, 5),
--    ('Toa Fem Kot Noct. UltraFina C/A', 'Toa Fem Kot Noct. UltraFina C/A 12x8', 23, 12, 14.00, 20.00, 1, 5),
--    ('Toa Fem Kot Noct. C/A 8x16', 'Toa Fem Kot Noct. C/A 8x16', 23, 8, 15.00, 22.00, 1, 5),
--    ('Toa Fem Kot Up Nor C/A Manzanilla', 'Toa Fem Kot Up Nor C/A Manzanilla 24x10', 23, 24, 11.00, 16.00, 1, 5),
--    ('Toa Fem Kot Up Nor S/A Manzanilla', 'Toa Fem Kot Up Nor S/A Manzanilla 24x10', 23, 24, 11.00, 16.00, 1, 5),
--    ('Fem Pad Amiga Nor S/A CC', 'Fem Pad Amiga Nor S/A CC 12x10', 23, 12, 9.00, 13.00, 1, 5),
--    ('Fem Pad Amiga Nor C/A CC', 'Fem Pad Amiga Nor C/A CC 12x10', 23, 12, 9.00, 13.00, 1, 5),
--    ('Fem Lin Kotex Resp. Nor S/A TTX', 'Fem Lin Kotex Resp. Nor S/A TTX 24x15', 23, 24, 8.00, 12.00, 1, 5),
--    ('Prot. Dia Kotex Long Nor S/A RW', 'Prot. Dia Kotex Long Nor S/A RW 24x15', 23, 24, 8.00, 12.00, 1, 5),
--    ('Fem Lin Kotex Nor S/A MNZ TTX', 'Fem Lin Kotex Nor S/A MNZ TTX 24x15', 23, 24, 8.00, 12.00, 1, 5),
--    ('Fem Lin Kotex Nor S/A Ind. PH', 'Fem Lin Kotex Nor S/A Ind. PH 24x15', 23, 24, 8.00, 12.00, 1, 5),
--    ('Tamp. kot Aplic. Medio', 'Tamp. kot Aplic. Medio 16x8', 23, 16, 14.00, 20.00, 1, 5),
--    ('Tamp. kot Aplic. Super', 'Tamp. kot Aplic. Super 16x8', 23, 16, 14.00, 20.00, 1, 5),
--    ('BW Hug Limpieza Efectiva', 'BW Hug Limpieza Efectiva 24X16', 23, 24, 15.00, 22.00, 1, 5),
--    ('BW Hug Limp Dia', 'BW Hug Limp Dia 12x80', 23, 12, 25.00, 35.00, 1, 5),
--    ('BW Hug Manita y Carita', 'BW Hug Manita y Carita 24x48', 23, 24, 18.00, 26.00, 1, 5),
--    ('BW Hug Manita y Carita 80s', 'BW Hug Manita y Carita 12x80', 23, 12, 25.00, 35.00, 1, 5),
--    ('BW Hug Limpieza Efectiva 96s', 'BW Hug Limpieza Efectiva 12x96', 23, 12, 28.00, 40.00, 1, 5),
--    ('BW Hug Cin Ftop Tabasco', 'BW Hug Cin Ftop Tabasco 18x100', 23, 18, 30.00, 42.00, 1, 5),
--    ('BW Hug Limp Dia 112s', 'BW Hug Limp Dia 12x112', 23, 12, 32.00, 45.00, 1, 5),
--    ('Rashcre Huggies Sup Care 80gr', 'Rashcre Huggies Sup Care 80gr Care 12x1', 23, 12, 40.00, 55.00, 1, 5),
--    ('Pañ Huggies Natcare Maxi RN DC', 'Pañ Huggies Natcare Maxi RN DC 12x19', 23, 12, 45.00, 60.00, 1, 5),
--    ('Pañ Huggies Natcare Mega RN DC', 'Pañ Huggies Natcare Mega RN DC 6x38', 23, 6, 80.00, 110.00, 1, 5),
--    ('Pañ Kimbies Mega M', 'Pañ Kimbies Mega M 6x38', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Kimbies Mega XG', 'Pañ Kimbies Mega XG 6x38', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Kimbies Mega G', 'Pañ Kimbies Mega G 6x38', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Kimbies Mega XXL/XXG', 'Pañ Kimbies Mega XXL/XXG 6x28', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Huggies Class Mini Pack XXL/XXG', 'Pañ Huggies Class Mini Pack XXL/XXG 12x14', 23, 12, 25.00, 35.00, 1, 5),
--    ('Pañ Huggies Class Mini Pack L/G', 'Pañ Huggies Class Mini Pack L/G 12x14', 23, 12, 25.00, 35.00, 1, 5),
--    ('Pañ Huggies Class Mini Pack XL/XG', 'Pañ Huggies Class Mini Pack XL/XG 12x14', 23, 12, 25.00, 35.00, 1, 5),
--    ('Pañ Huggies Class Thor P Reg', 'Pañ Huggies Class Thor P Reg 12x14', 23, 12, 25.00, 35.00, 1, 5),
--    ('Pañ Huggies Class Thor M Reg', 'Pañ Huggies Class Thor M Reg 12x11', 23, 12, 22.00, 31.00, 1, 5),
--    ('Pañ Huggies Class Thor G Reg', 'Pañ Huggies Class Thor G Reg 12x10', 23, 12, 20.00, 28.00, 1, 5),
--    ('Pañ Huggies Class Thor XG Reg', 'Pañ Huggies Class Thor XG Reg 12x9', 23, 12, 18.00, 25.00, 1, 5),
--    ('Pañ Huggies Class Jumbo P', 'Pañ Huggies Class Jumbo P 6x50', 23, 6, 95.00, 130.00, 1, 5),
--    ('Pañ Huggies Class Jumbo M', 'Pañ Huggies Class Jumbo M 6x50', 23, 6, 95.00, 130.00, 1, 5),
--    ('Pañ Huggies Class Jumbo G', 'Pañ Huggies Class Jumbo G 6x50', 23, 6, 95.00, 130.00, 1, 5),
--    ('Pañ Huggies Class Jumbo XG', 'Pañ Huggies Class Jumbo XG 6x50', 23, 6, 95.00, 130.00, 1, 5),
--    ('Pañ Huggies Class Jumbo XXG', 'Pañ Huggies Class Jumbo XXG 6x50', 23, 6, 95.00, 130.00, 1, 5),
--    ('Dia Huggies ActSec MiniP M/2', 'Dia Huggies ActSec MiniP M/2 48x4', 23, 48, 12.00, 18.00, 1, 5),
--    ('Dia Huggies ActSec MiniP G/3', 'Dia Huggies ActSec MiniP G/3 48x4', 23, 48, 12.00, 18.00, 1, 5),
--    ('Dia Huggies ActSec MiniP XG/4', 'Dia Huggies ActSec MiniP XG/4 48x4', 23, 48, 12.00, 18.00, 1, 5),
--    ('Pan Huggies ActSec Heroe G/S3 Maquila', 'Pan Huggies ActSec Heroe G/S3 Maquila 8x25', 23, 8, 45.00, 62.00, 1, 5),
--    ('Pañ Huggies ActSec Heroe L Maquila', 'Pañ Huggies ActSec Heroe L Maquila 6x31', 23, 6, 50.00, 70.00, 1, 5),
--    ('Pañ Huggies ActSec M Maquila', 'Pañ Huggies ActSec M Maquila 8x25', 23, 8, 45.00, 62.00, 1, 5),
--    ('Pañ Huggies ActSec G Maquila', 'Pañ Huggies ActSec G Maquila 8x25', 23, 8, 45.00, 62.00, 1, 5),
--    ('Pañ Huggies ActSec XG Maquila', 'Pañ Huggies ActSec XG Maquila 8x25', 23, 8, 45.00, 62.00, 1, 5),
--    ('Pañ Huggies Actsec P', 'Pañ Huggies Actsec P 6x50', 23, 6, 110.00, 150.00, 1, 5),
--    ('Pañ Huggies Actsec M', 'Pañ Huggies Actsec M 4x50', 23, 4, 110.00, 150.00, 1, 5),
--    ('Pañ Huggies Actsec G', 'Pañ Huggies Actsec G 4x50', 23, 4, 110.00, 150.00, 1, 5),
--    ('Pañ Huggies Actsec XG', 'Pañ Huggies Actsec XG 4x50', 23, 4, 110.00, 150.00, 1, 5),
--    ('Pañ Huggies Actsec XXG', 'Pañ Huggies Actsec XXG 6x30', 23, 6, 85.00, 115.00, 1, 5),
--    ('Cal Adulto Plenitud Class M', 'Cal Adulto Plenitud Class M 10x8', 23, 10, 60.00, 85.00, 1, 5),
--    ('Pañ Adult Plenitud Protect M', 'Pañ Adult Plenitud Protect M 10x8', 23, 10, 65.00, 90.00, 1, 5),
--    ('Pant Adulto Plenitud P/M', 'Pant Adulto Plenitud P/M 4x8', 23, 4, 70.00, 95.00, 1, 5),
--    ('Cal Adulto Plenitud Class G/XG', 'Cal Adulto Plenitud Class G/XG 10x8', 23, 10, 65.00, 90.00, 1, 5),
--    ('Pant Adulto Plenitud Neutrazone G/XG', 'Pant Adulto Plenitud Neutrazone G/XG 10x8', 23, 10, 70.00, 95.00, 1, 5),
--    ('Pant Adulto Plenitud P/P G/XG', 'Pant Adulto Plenitud P/P G/XG 4x8', 23, 4, 75.00, 100.00, 1, 5),
--    ('Pant Adulto Plenitud Act Plus P/M', 'Pant Adulto Plenitud Act Plus P/M 2x16', 23, 2, 120.00, 160.00, 1, 5),
--    ('Pant Adulto Plenitud Act Plus G/XG', 'Pant Adulto Plenitud Act Plus G/XG 2x16', 23, 2, 130.00, 175.00, 1, 5),
--    ('Cal Adulto Plenitud Protect M', 'Cal Adulto Plenitud Protect M 3x20', 23, 3, 140.00, 190.00, 1, 5),
--    ('Cal Adulto Plenitud Protect G/XG', 'Cal Adulto Plenitud Protect G/XG 3x20', 23, 3, 150.00, 205.00, 1, 5),

--    -- Categoría 22: Higiene oral (Cremas dentales, cepillos, enjuagues e hilo dental)
--    ('CDC Dispensador 22ml', 'CDC Dispensador 22ml 1x12', 22, 12, 15.00, 22.00, 1, 5),
--    ('CDC Triple Accion 50ml', 'CDC Triple Accion 50ml 1x144', 22, 144, 18.00, 25.00, 1, 5),
--    ('CDC Doble Frescura 50ml', 'CDC Doble Frescura 50ml 1x144', 22, 144, 18.00, 25.00, 1, 5),
--    ('CDC Original 50ml', 'CDC Original 50ml 1x144', 22, 144, 18.00, 25.00, 1, 5),
--    ('CDC Triple Accion 75ml', 'CDC Triple Accion 75ml 1x72', 22, 72, 25.00, 35.00, 1, 5),
--    ('CDC Doble Frescura 75ml', 'CDC Doble Frescura 75ml 1x72', 22, 72, 25.00, 35.00, 1, 5),
--    ('CDC Original 75ml', 'CDC Original 75ml 1x72', 22, 72, 25.00, 35.00, 1, 5),
--    ('CDC Triple Accion 100ml', 'CDC Triple Accion 100ml 1x72', 22, 72, 32.00, 44.00, 1, 5),
--    ('CDC Doble Frescura 100ml', 'CDC Doble Frescura 100ml 1x72', 22, 72, 32.00, 44.00, 1, 5),
--    ('CDC Original 100ml', 'CDC Original 100ml 1x72', 22, 72, 32.00, 44.00, 1, 5),
--    ('CDC Triple Accion 150ml', 'CDC Triple Accion 150ml 1x72', 22, 72, 45.00, 60.00, 1, 5),
--    ('CDC Max White 160ml', 'CDC Max White 160ml 1x72', 22, 72, 55.00, 75.00, 1, 5),
--    ('CDC Total 12 50ml', 'CDC Total 12 50ml 1x144', 22, 144, 30.00, 42.00, 1, 5),
--    ('CDC Total 12 75ml', 'CDC Total 12 75ml 1x72', 22, 72, 42.00, 58.00, 1, 5),
--    ('CDC Total 12 Carbon Act. 75ml', 'CDC Total 12 Carbon Act. 75ml 1x72', 22, 72, 45.00, 62.00, 1, 5),
--    ('CDC Total 12 Antisarro 75ml', 'CDC Total 12 Antisarro 75ml 1x72', 22, 72, 42.00, 58.00, 1, 5),
--    ('CDC Total 12 Encias Rerz. 75ml', 'CDC Total 12 Encias Rerz. 75ml 1x72', 22, 72, 42.00, 58.00, 1, 5),
--    ('CDC Total 12 100ml', 'CDC Total 12 100ml 1x72', 22, 72, 55.00, 75.00, 1, 5),
--    ('CDC Total 12 Antisarro 150ml', 'CDC Total 12 Antisarro 150ml 1x72', 22, 72, 70.00, 95.00, 1, 5),
--    ('CDC Total 12 Carbon Act. 150ml', 'CDC Total 12 Carbon Act. 150ml 1x72', 22, 72, 75.00, 100.00, 1, 5),
--    ('CDC Total 12 170ml', 'CDC Total 12 170ml 1x72', 22, 72, 80.00, 110.00, 1, 5),
--    ('CDC Luminus White 50ml', 'CDC Luminus White 50ml 1x48', 22, 48, 35.00, 48.00, 1, 5),
--    ('CDC Luminus White 75ml', 'CDC Luminus White 75ml 1x48', 22, 48, 50.00, 68.00, 1, 5),
--    ('CDC Luminus White Carbon Act. 75ml', 'CDC Luminus White Carbon Act. 75ml 1x48', 22, 48, 52.00, 70.00, 1, 5),
--    ('CDC Luminus White Lovers 75ml', 'CDC Luminus White Lovers 75ml 1x48', 22, 48, 52.00, 70.00, 1, 5),
--    ('CDC Luminus White 125ml', 'CDC Luminus White 125ml 1x48', 22, 48, 75.00, 100.00, 1, 5),
--    ('CDC Sensitive Pro-Aliv. 110gr', 'CDC Sensitive Pro-Aliv. 110gr 1x12', 22, 12, 75.00, 100.00, 1, 5),
--    ('CDC Sensitive Xtreme 75ml', 'CDC Sensitive Xtreme 75ml 1x12', 22, 12, 65.00, 90.00, 1, 5),
--    ('CDC Sensitive Pro-Aliv. Blanq. 75ml', 'CDC Sensitive Pro-Aliv. Blanq. 75ml 1x12', 22, 12, 65.00, 90.00, 1, 5),
--    ('CDC Sensitive Pro-Aliv. Inmd. 60ml', 'CDC Sensitive Pro-Aliv. Inmd. 60ml 1x12', 22, 12, 60.00, 82.00, 1, 5),
--    ('CDC Sensitive Pro-Aliv. Enci. Refz. 75ml', 'CDC Sensitive Pro-Aliv. Enci. Refz. 75ml 1x12', 22, 12, 65.00, 90.00, 1, 5),
--    ('Cepillo Duro Clasico 14 und', 'Cepillo Duro Clasico 14 und 1x6', 22, 6, 40.00, 55.00, 1, 5),
--    ('Cepillo Premier Clean 6 und', 'Cepillo Premier Clean 6 und 1x14', 22, 14, 30.00, 42.00, 1, 5),
--    ('Kit cepillado Max. 22ml + Cepillo duro', 'Kit cepillado Max. 22ml + Cepillo duro 1x24', 22, 24, 25.00, 35.00, 1, 5),
--    ('Cepillo Orthoguard 1und', 'Cepillo Orthoguard 1und 1x12', 22, 12, 20.00, 28.00, 1, 5),
--    ('Kit Total 12 22ml + Cepillo viaje', 'Kit Total 12 22ml + Cepillo viaje 1x12', 22, 12, 35.00, 48.00, 1, 5),
--    ('Cepillo Twister Fresh 2 Pack', 'Cepillo Twister Fresh 2 Pack 1x36', 22, 36, 30.00, 42.00, 1, 5),
--    ('Cepillo Triple Accion 2 Pack', 'Cepillo Triple Accion 2 Pack 1x12', 22, 12, 30.00, 42.00, 1, 5),
--    ('Cepillo Slim Soft 2 Pack', 'Cepillo Slim Soft 2 Pack 1x12', 22, 12, 45.00, 62.00, 1, 5),
--    ('Cepillo Procuidado 2 Pack', 'Cepillo Procuidado 2 Pack 1x12', 22, 12, 35.00, 48.00, 1, 5),
--    ('Cepillo Twister 3 Pack', 'Cepillo Twister 3 Pack 1x12', 22, 12, 40.00, 55.00, 1, 5),
--    ('Cepillo Total 12 2 Pack', 'Cepillo Total 12 2 Pack 1x12', 22, 12, 42.00, 58.00, 1, 5),
--    ('Cepillo Renv. Enc. 2 Pack', 'Cepillo Renv. Enc. 2 Pack 1x12', 22, 12, 45.00, 62.00, 1, 5),
--    ('Cepillo Sens. Enc. 2 Pack', 'Cepillo Sens. Enc. 2 Pack 1x12', 22, 12, 45.00, 62.00, 1, 5),
--    ('Cepillo Zig-Zag 3 Pack', 'Cepillo Zig-Zag 3 Pack 1x12', 22, 12, 38.00, 52.00, 1, 5),
--    ('Cepillo 360 Base Twinpack', 'Cepillo 360 Base Twinpack 1x12', 22, 12, 50.00, 68.00, 1, 5),
--    ('Cepillo 360 Interdental', 'Cepillo 360 Interdental 1x12', 22, 12, 50.00, 68.00, 1, 5),
--    ('Cepillo 360 Sens. Pro Ali.', 'Cepillo 360 Sens. Pro Ali. 1x12', 22, 12, 52.00, 70.00, 1, 5),
--    ('Cepillo 360 Suav. Surr. Pow.', 'Cepillo 360 Suav. Surr. Pow. 1x12', 22, 12, 52.00, 70.00, 1, 5),
--    ('Cepillo 360 Surround Twinpack', 'Cepillo 360 Surround Twinpack 1x12', 22, 12, 55.00, 75.00, 1, 5),
--    ('Cepillo 360 Multibeneficios', 'Cepillo 360 Multibeneficios 1x12', 22, 12, 50.00, 68.00, 1, 5),
--    ('Cepillo 360 Gold', 'Cepillo 360 Gold 1x12', 22, 12, 55.00, 75.00, 1, 5),
--    ('Cepillo 360 Luminus White', 'Cepillo 360 Luminus White 1x12', 22, 12, 52.00, 70.00, 1, 5),
--    ('Cepillo 360 Advance', 'Cepillo 360 Advance 1x12', 22, 12, 50.00, 68.00, 1, 5),
--    ('CDC Kids DR Rabbit 50ml', 'CDC Kids DR Rabbit 50ml 1x24', 22, 24, 22.00, 30.00, 1, 5),
--    ('CDC Agnes Y Fluffy 60ml', 'CDC Agnes Y Fluffy 60ml 1x24', 22, 24, 25.00, 35.00, 1, 5),
--    ('CDC Smile 2-5 Years 75ml', 'CDC Smile 2-5 Years 75ml 1x12', 22, 12, 28.00, 38.00, 1, 5),
--    ('CDC Smile Barbie 75ml', 'CDC Smile Barbie 75ml 1x12', 22, 12, 28.00, 38.00, 1, 5),
--    ('CDC Smile Minions 6-mas 75ml', 'CDC Smile Minions 6-mas 75ml 1x12', 22, 12, 28.00, 38.00, 1, 5),
--    ('Cepillo kids Smile 2-5 Years', 'Cepillo kids Smile 2-5 Years 1x24', 22, 24, 20.00, 28.00, 1, 5),
--    ('Cepillo kids Dr Rabbit 2 años a mas', 'Cepillo kids Dr Rabbit 2 años a mas 1x12', 22, 12, 20.00, 28.00, 1, 5),
--    ('Cepillo kids Minions 2 Pack', 'Cepillo kids Minions 2 Pack 1x12', 22, 12, 35.00, 48.00, 1, 5),
--    ('Cepillo kids Smile 5 años a mas', 'Cepillo kids Smile 5 años a mas 1x24', 22, 24, 20.00, 28.00, 1, 5),
--    ('Cepillo Kids Infantil 2 Pack 5 años a mas', 'Cepillo Kids Infantil 2 Pack 5 años a mas 1x48', 22, 48, 35.00, 48.00, 1, 5),
--    ('Enjuage Bucal Plax Ice 60ml', 'Enjuage Bucal Plax Ice 60ml 1x24', 22, 24, 15.00, 22.00, 1, 5),
--    ('Enjuage Bucal Plax Ice 250ml', 'Enjuage Bucal Plax Ice 250ml 1x12', 22, 12, 35.00, 48.00, 1, 5),
--    ('Enjuage Bucal Soft Mint 250ml', 'Enjuage Bucal Soft Mint 250ml 1x12', 22, 12, 35.00, 48.00, 1, 5),
--    ('Enjuage Bucal Minioms 250ml', 'Enjuage Bucal Minioms 250ml 1x12', 22, 12, 35.00, 48.00, 1, 5),
--    ('Enjuage Bucal Plax Ice 500ml', 'Enjuage Bucal Plax Ice 500ml 1x24', 22, 24, 60.00, 82.00, 1, 5),
--    ('Enjuage Bucal Soft Mint 500ml', 'Enjuage Bucal Soft Mint 500ml 1x12', 22, 12, 60.00, 82.00, 1, 5),
--    ('Enjuage Bucal Total 12 500ml', 'Enjuage Bucal Total 12 500ml 1x12', 22, 12, 70.00, 95.00, 1, 5),
--    ('Enjuage Bucal Plax Ice 500ml+250ml', 'Enjuage Bucal Plax Ice 500ml+250ml 1x12', 22, 12, 75.00, 100.00, 1, 5),
--    ('Enjuage Bucal Odor Cont. 750ml+500ml', 'Enjuage Bucal Odor Cont. 750ml+500ml 1x12', 22, 12, 95.00, 130.00, 1, 5),
--    ('Enjuage Bucal Fresh Mint 750ml', 'Enjuage Bucal Fresh Mint 750ml 1x12', 22, 12, 85.00, 115.00, 1, 5),
--    ('Hilo Dental Total 12 Clean Mint 25 mts', 'Hilo Dental Total 12 Clean Mint 25 mts 1x24', 22, 24, 25.00, 35.00, 1, 5),
--    ('Hilo Dental Total 12 Flour Menta 25 mts', 'Hilo Dental Total 12 Flour Menta 25 mts 1x24', 22, 24, 25.00, 35.00, 1, 5),

--    -- Categoría 21: Higiene capilar y corporal (Jabones, Shampoos, Mennen y Desodorantes)
--    ('Jabon Protex Aloe 110gr', 'Jabon Protex Aloe 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Balance Salu. 110gr', 'Jabon Protex Balance Salu. 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Avena 110gr', 'Jabon Protex Avena 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Fresh 110gr', 'Jabon Protex Fresh 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Omega 3 110gr', 'Jabon Protex Omega 3 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Duo Protect 110gr', 'Jabon Protex Duo Protect 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Limp. Prof. 110gr', 'Jabon Protex Limp. Prof. 110gr 1x96', 21, 96, 18.00, 25.00, 1, 5),
--    ('Jabon Protex Vitamina E 330gr 3 Pack', 'Jabon Protex Vitamina E 330gr 3 Pack 1x32', 21, 32, 50.00, 68.00, 1, 5),
--    ('Jabon Protex Avena 330gr 3 Pack', 'Jabon Protex Avena 330gr 3 Pack 1x32', 21, 32, 50.00, 68.00, 1, 5),
--    ('Jabon Protex Liq. Aloe & Vera 221ml', 'Jabon Protex Liq. Aloe & Vera 221ml 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Jabon Protex Liq. Avena 221ml', 'Jabon Protex Liq. Avena 221ml 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Jabon Protex Liq. Avena Doypack 500ml', 'Jabon Protex Liq. Avena Doypack 500ml 1x12', 21, 12, 75.00, 100.00, 1, 5),
--    ('Jabon Palmolive Aloe & Vera 100gr', 'Jabon Palmolive Aloe & Vera 100gr 1x96', 21, 96, 16.00, 22.00, 1, 5),
--    ('Jabon Palmolive Tono Perfec. 100gr', 'Jabon Palmolive Tono Perfec. 100gr 1x96', 21, 96, 16.00, 22.00, 1, 5),
--    ('Jabon Palmolive Avena & Azucar 100gr', 'Jabon Palmolive Avena & Azucar 100gr 1x96', 21, 96, 16.00, 22.00, 1, 5),
--    ('Jabon Palmolive Fusion Nutr. 100gr', 'Jabon Palmolive Fusion Nutr. 100gr 1x96', 21, 96, 16.00, 22.00, 1, 5),
--    ('Jabon Palmolive Aloe & Vera 150gr', 'Jabon Palmolive Aloe & Vera 150gr 1x72', 21, 72, 22.00, 30.00, 1, 5),
--    ('Jabon Palmolive Lav. & Crem. 150gr', 'Jabon Palmolive Lav. & Crem. 150gr 1x72', 21, 72, 22.00, 30.00, 1, 5),
--    ('Jabon Palmolive Fusion Nutr. 150gr', 'Jabon Palmolive Fusion Nutr. 150gr 1x72', 21, 72, 22.00, 30.00, 1, 5),
--    ('Jabon Palmolive Yogurt & Frutas 150gr', 'Jabon Palmolive Yogurt & Frutas 150gr 1x72', 21, 72, 22.00, 30.00, 1, 5),
--    ('Shampoo Palmolive 2 en 1 200ml', 'Shampoo Palmolive 2 en 1 200ml 1x15', 21, 15, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Anticeramida 200ml', 'Shampoo Palmolive Anticeramida 200ml 1x15', 21, 15, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Chile & Aguacate 200ml', 'Shampoo Palmolive Chile & Aguacate 200ml 1x15', 21, 15, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Anticaspa 200ml', 'Shampoo Palmolive Anticaspa 200ml 1x15', 21, 15, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Control Caspa 200ml', 'Shampoo Palmolive Control Caspa 200ml 1x15', 21, 15, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Pro V5 200ml', 'Shampoo Palmolive Pro V5 200ml 1x15', 21, 15, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Anticeramidas 750ml', 'Shampoo Palmolive Anticeramidas 750ml 1x12', 21, 12, 120.00, 160.00, 1, 5),
--    ('Shampoo Palmolive Anticaspa 750ml', 'Shampoo Palmolive Anticaspa 750ml 1x12', 21, 12, 120.00, 160.00, 1, 5),
--    ('Shampoo Palmolive Suavidad E Hidra. 750ml', 'Shampoo Palmolive Suavidad E Hidra. 750ml 1x12', 21, 12, 120.00, 160.00, 1, 5),
--    ('Shampoo Palmolive Rep. Comp. 750ml', 'Shampoo Palmolive Rep. Comp. 750ml 1x12', 21, 12, 120.00, 160.00, 1, 5),
--    ('Shampoo Palmolive Biotina 750ml', 'Shampoo Palmolive Biotina 750ml 1x12', 21, 12, 125.00, 170.00, 1, 5),
--    ('Shampoo Palmolive Aceite Argan 750ml', 'Shampoo Palmolive Aceite Argan 750ml 1x12', 21, 12, 125.00, 170.00, 1, 5),
--    ('Shampoo Palmolive Coco y Bambu 750ml', 'Shampoo Palmolive Coco y Bambu 750ml 1x12', 21, 12, 125.00, 170.00, 1, 5),
--    ('Shampoo Palmolive Aguacate & Chile 750ml', 'Shampoo Palmolive Aguacate & Chile 750ml 1x12', 21, 12, 125.00, 170.00, 1, 5),
--    ('Shampoo Palmolive Optims #4 10ml', 'Shampoo Palmolive Optims #4 10ml 1x24', 21, 24, 5.00, 8.00, 1, 5),
--    ('Shampoo Palmolive Optims Anticaspa 10ml', 'Shampoo Palmolive Optims Anticaspa 10ml 1x24', 21, 24, 5.00, 8.00, 1, 5),
--    ('Shampoo Palmolive Optims #4 2 en 1 200ml', 'Shampoo Palmolive Optims #4 2 en 1 200ml 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Shampoo Palmolive Optims #4 2 en 1 400ml', 'Shampoo Palmolive Optims #4 2 en 1 400ml 1x12', 21, 12, 80.00, 110.00, 1, 5),
--    ('Shampoo Palmolive Optims Hialuronico 400ml', 'Shampoo Palmolive Optims Hialuronico 400ml 1x12', 21, 12, 85.00, 115.00, 1, 5),
--    ('Shampoo Palmolive Optims Reparacion + Acond. 400ml', 'Shampoo Palmolive Optims Reparacion + Acond. 400ml 1x12', 21, 12, 85.00, 115.00, 1, 5),
--    ('Crema Palmolive Optims Xtra Nutri. 150ml', 'Crema Palmolive Optims Xtra Nutri. 150ml 1x12', 21, 12, 40.00, 55.00, 1, 5),
--    ('Crema Palmolive Optims Rizos Hidratados 150ml', 'Crema Palmolive Optims Rizos Hidratados 150ml 1x12', 21, 12, 40.00, 55.00, 1, 5),
--    ('Jabon Mennen Neutro 90gr', 'Jabon Mennen Neutro 90gr 1x48', 21, 48, 18.00, 25.00, 1, 5),
--    ('Jabon Mennen Lavanda 90gr', 'Jabon Mennen Lavanda 90gr 1x48', 21, 48, 18.00, 25.00, 1, 5),
--    ('Shampoo Mennen Baby Magic Liquido 185ml', 'Shampoo Mennen Baby Magic Liquido 185ml 1x18', 21, 18, 55.00, 75.00, 1, 5),
--    ('Shampoo Mennen Manzanilla 200ml', 'Shampoo Mennen Manzanilla 200ml 1x12', 21, 12, 55.00, 75.00, 1, 5),
--    ('Shampoo Mennen Lavanda 200ml', 'Shampoo Mennen Lavanda 200ml 1x12', 21, 12, 55.00, 75.00, 1, 5),
--    ('Shampoo Mennen Zero 400ml', 'Shampoo Mennen Zero 400ml 1x12', 21, 12, 85.00, 115.00, 1, 5),
--    ('Aceite Mennen Niñ@ 100ml', 'Aceite Mennen Niñ@ 100ml 1x24', 21, 24, 45.00, 62.00, 1, 5),
--    ('Colonia Mennen Niñ@ 100ml', 'Colonia Mennen Niñ@ 100ml 1x24', 21, 24, 60.00, 82.00, 1, 5),
--    ('Colonia Mennen Niñ@ 200ml', 'Colonia Mennen Niñ@ 200ml 1x12', 21, 12, 95.00, 130.00, 1, 5),
--    ('Talco Mennen Niño 100ml', 'Talco Mennen Niño 100ml 1x24', 21, 24, 35.00, 48.00, 1, 5),
--    ('Talco Mennen Niña 100ml', 'Talco Mennen Niña 100ml 1x24', 21, 24, 35.00, 48.00, 1, 5),
--    ('Crema Mennen Baby Magic Niñ@ 300ml', 'Crema Mennen Baby Magic Niñ@ 300ml 1x12', 21, 12, 75.00, 102.00, 1, 5),
--    ('Estuche Bebe Casita Mennen', 'Estuche Bebe Casita Mennen 100ml/100ml/100ml/90gr 1x12', 21, 12, 150.00, 205.00, 1, 5),
--    ('Des SS Cool Night Gel Sachet 8gr', 'Des SS Cool Night Gel Sachet 8gr 1x18x24', 21, 18, 5.00, 8.00, 1, 5),
--    ('Des LSS Talco Crema Sachet 8gr', 'Des LSS Talco Crema Sachet 8gr 1x18x24', 21, 18, 5.00, 8.00, 1, 5),
--    ('Des SS Xtrem Night Gel Tubo 30gr', 'Des SS Xtrem Night Gel Tubo 30gr 1x24', 21, 24, 35.00, 48.00, 1, 5),
--    ('Des LSS Talco Crema Tubo 30gr', 'Des LSS Talco Crema Tubo 30gr 1x24', 21, 24, 35.00, 48.00, 1, 5),
--    ('Des SS Classic Crema Barra 50gr', 'Des SS Classic Crema Barra 50gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des SS Hipoalerginico Crema Barra 50gr', 'Des SS Hipoalerginico Crema Barra 50gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des SS Sport Talc Crema Barra 50gr', 'Des SS Sport Talc Crema Barra 50gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des SS Fresh Crema Barra 60gr', 'Des SS Fresh Crema Barra 60gr 1x12', 21, 12, 48.00, 65.00, 1, 5),
--    ('Des SS Xtreme 24/7 Crema Barra 50gr', 'Des SS Xtreme 24/7 Crema Barra 50gr 1x12', 21, 12, 50.00, 68.00, 1, 5),
--    ('Des SS Stainguard Crema Barra 50gr', 'Des SS Stainguard Crema Barra 50gr 1x12', 21, 12, 50.00, 68.00, 1, 5),
--    ('Des SS X5 Cema Barra 50gr', 'Des SS X5 Cema Barra 50gr 1x12', 21, 12, 52.00, 70.00, 1, 5),
--    ('Des SS Energy Crema Barra 50gr', 'Des SS Energy Crema Barra 50gr 1x12', 21, 12, 52.00, 70.00, 1, 5),
--    ('Des SS Carbon Activo Crema Barra 50gr', 'Des SS Carbon Activo Crema Barra 50gr 1x12', 21, 12, 52.00, 70.00, 1, 5),
--    ('Des LSS Powder Fresh Crema Barra 45gr', 'Des LSS Powder Fresh Crema Barra 45gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des LSS Wild Fressia Crema Barra 45gr', 'Des LSS Wild Fressia Crema Barra 45gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des LSS PRO 5 Crema Barra 45gr', 'Des LSS PRO 5 Crema Barra 45gr 1x12', 21, 12, 48.00, 65.00, 1, 5),
--    ('Des LSS Derma Aclarado Crema Barra 45gr', 'Des LSS Derma Aclarado Crema Barra 45gr 1x12', 21, 12, 50.00, 68.00, 1, 5),
--    ('Des LSS Inv. Floral Crema Barra 45gr', 'Des LSS Inv. Floral Crema Barra 45gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des LSS Orchard Blossom Crema Barra 45gr', 'Des LSS Orchard Blossom Crema Barra 45gr 1x12', 21, 12, 45.00, 62.00, 1, 5),
--    ('Des LSS Carbon Activo Crema Barra 50gr', 'Des LSS Carbon Activo Crema Barra 50gr 1x12', 21, 12, 50.00, 68.00, 1, 5),
--    ('Des SS Xtrem 24/7 Gel Barra 85gr', 'Des SS Xtrem 24/7 Gel Barra 85gr 1x12', 21, 12, 65.00, 88.00, 1, 5),
--    ('Des SS Xtrem Intenso 24/7 Gel Barra 85gr', 'Des SS Xtrem Intenso 24/7 Gel Barra 85gr 1x12', 21, 12, 65.00, 88.00, 1, 5),
--    ('Des SS Xtrem X5 24/7 Gel Barra 85gr', 'Des SS Xtrem X5 24/7 Gel Barra 85gr 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des LSS Floral Fresh Gel Barra 65gr', 'Des LSS Floral Fresh Gel Barra 65gr 1x12', 21, 12, 60.00, 82.00, 1, 5),
--    ('Des SS Xtreme Aerosol 150ml', 'Des SS Xtreme Aerosol 150ml 1x12', 21, 12, 65.00, 88.00, 1, 5),
--    ('Des SS Intense Aerosol 150ml', 'Des SS Intense Aerosol 150ml 1x12', 21, 12, 65.00, 88.00, 1, 5),
--    ('Des SS X5 Aerosol 150ml', 'Des SS X5 Aerosol 150ml 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des SS Stainguard Aerosol 150ml', 'Des SS Stainguard Aerosol 150ml 1x12', 21, 12, 65.00, 88.00, 1, 5),
--    ('Des SS Carbon Abs. Aerosol 150ml', 'Des SS Carbon Abs. Aerosol 150ml 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des SS Energy Aerosol 150ml', 'Des SS Energy Aerosol 150ml 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des LSS Powder Fresh Aerosol 150ml', 'Des LSS Powder Fresh Aerosol 150ml 1x12', 21, 12, 65.00, 88.00, 1, 5),
--    ('Des LSS PRO 5 Aerosol 150ml', 'Des LSS PRO 5 Aerosol 150ml 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des LSS Derma Perla Aerosol 150ml', 'Des LSS Derma Perla Aerosol 150ml 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des LSS Carbon Abs. Aerosol 150ml', 'Des LSS Carbon Abs. Aerosol 150ml 1x12', 21, 12, 68.00, 92.00, 1, 5),
--    ('Des SS Clinical Crema Barra 50gr', 'Des SS Clinical Crema Barra 50gr 1x12', 21, 12, 95.00, 130.00, 1, 5),
--    ('Des LSS Clinical Crema Barra 45gr', 'Des LSS Clinical Crema Barra 45gr 1x12', 21, 12, 95.00, 130.00, 1, 5),
--    ('HSS Clinical Complete Spray 150ml', 'HSS Clinical Complete Spray 150ml 1x12', 21, 12, 98.00, 135.00, 1, 5),
--    ('LSS Clinical Complete Spray 150ml', 'LSS Clinical Complete Spray 150ml 1x12', 21, 12, 98.00, 135.00, 1, 5),

--    -- Categoría 17: Lavandería (Suavitel)
--    ('Suavitel Base Primaveral Sachet 80ml', 'Suavitel Base Primaveral Sachet 80ml 1x12x6', 17, 12, 4.00, 7.00, 1, 5),
--    ('Suavitel Aroma Sol Sachet 80ml', 'Suavitel Aroma Sol Sachet 80ml 1x12x6', 17, 12, 4.00, 7.00, 1, 5),
--    ('Suavitel Flor Primaveral Sachet 80ml', 'Suavitel Flor Primaveral Sachet 80ml 1x12x6', 17, 12, 4.00, 7.00, 1, 5),
--    ('Suavitel Primaveral Complete Sachet 80ml', 'Suavitel Primaveral Complete Sachet 80ml 1x12x6', 17, 12, 4.00, 7.00, 1, 5),
--    ('Suavitel Cuidado Superior Doypack 670ml', 'Suavitel Cuidado Superior Doypack 670ml 1x12', 17, 12, 45.00, 62.00, 1, 5),
--    ('Suavitel Cuidado Superior Base Doypack 720ml', 'Suavitel Cuidado Superior Base Doypack 720ml 1x12', 17, 12, 50.00, 68.00, 1, 5),
--    ('Suavitel Cuidado Superior Manzana Doypack 720ml', 'Suavitel Cuidado Superior Manzana Doypack 720ml 1x12', 17, 12, 50.00, 68.00, 1, 5),
--    ('Suavitel Cuidado Superior Sachet 750ml', 'Suavitel Cuidado Superior Sachet 750ml 1x12', 17, 12, 48.00, 65.00, 1, 5),
--    ('Suavitel Cuidado Superior Base Pet 850ml', 'Suavitel Cuidado Superior Base Pet 850ml 1x12', 17, 12, 60.00, 82.00, 1, 5),
--    ('Suavitel Cuidado Superior Vainilla Pet 850ml', 'Suavitel Cuidado Superior Vainilla Pet 850ml 1x12', 17, 12, 60.00, 82.00, 1, 5),
--    ('Suavitel Cuidado Superior Manzana Pet 850ml', 'Suavitel Cuidado Superior Manzana Pet 850ml 1x12', 17, 12, 60.00, 82.00, 1, 5),
--    ('Suavitel Base Primaveral Pet 450ml', 'Suavitel Base Primaveral Pet 450ml 1x12', 17, 12, 35.00, 48.00, 1, 5),
--    ('Suavitel Base Primaveral Sachet 450ml', 'Suavitel Base Primaveral Sachet 450ml 1x24', 17, 24, 32.00, 44.00, 1, 5),
--    ('Suavitel Primaveral Doypack 720ml', 'Suavitel Primaveral Doypack 720ml 1x12', 17, 12, 50.00, 68.00, 1, 5),
--    ('Suavitel Anochecer Doypack 720ml', 'Suavitel Anochecer Doypack 720ml 1x12', 17, 12, 50.00, 68.00, 1, 5),
--    ('Suavitel Base Primaveral Pet 850ml', 'Suavitel Base Primaveral Pet 850ml 1x12', 17, 12, 60.00, 82.00, 1, 5),
--    ('Suavitel Aroma Sol Pet 850ml', 'Suavitel Aroma Sol Pet 850ml 1x12', 17, 12, 60.00, 82.00, 1, 5),
--    ('Suavitel Anochecer Pet 850ml', 'Suavitel Anochecer Pet 850ml 1x12', 17, 12, 60.00, 82.00, 1, 5),
--    ('Suavitel Base Primaveral Pet 2.8ltrs', 'Suavitel Base Primaveral Pet 2.8ltrs 1x6', 17, 6, 150.00, 205.00, 1, 5),
--    ('Suavitel Aroma Sol Pet 2.8ltrs', 'Suavitel Aroma Sol Pet 2.8ltrs 1x6', 17, 6, 150.00, 205.00, 1, 5),
--    ('Suavitel Flor Primaveral Pet 2.8ltrs', 'Suavitel Flor Primaveral Pet 2.8ltrs 1x6', 17, 6, 150.00, 205.00, 1, 5),
--    ('Suavitel Base Primaveral Pet 5ltrs', 'Suavitel Base Primaveral Pet 5ltrs 1x4', 17, 4, 250.00, 340.00, 1, 5),

--    -- Categoría 18: Limpieza general (Azistín y Fabuloso)
--    ('Azistin Lavanda Sachet 80ml', 'Azistin Lavanda Sachet 80ml 1x12x6', 18, 12, 4.00, 7.00, 1, 5),
--    ('Azistin Manzana Sachet 80ml', 'Azistin Manzana Sachet 80ml 1x12x6', 18, 12, 4.00, 7.00, 1, 5),
--    ('Azistin Alternativa Cloro Sachet 80ml', 'Azistin Alternativa Cloro Sachet 80ml 1x12x6', 18, 12, 4.00, 7.00, 1, 5),
--    ('Azistin Lavanda Pet 450ml', 'Azistin Lavanda Pet 450ml 1x24', 18, 24, 25.00, 35.00, 1, 5),
--    ('Azistin Manzana Pet 450ml', 'Azistin Manzana Pet 450ml 1x24', 18, 24, 25.00, 35.00, 1, 5),
--    ('Azistin Alternativa Cloro Pet 450ml', 'Azistin Alternativa Cloro Pet 450ml 1x24', 18, 24, 25.00, 35.00, 1, 5),
--    ('Azistin Lavanda Sachet 650ml', 'Azistin Lavanda Sachet 650ml 1x18', 18, 18, 32.00, 44.00, 1, 5),
--    ('Azistin Lavanda Pet 900ml', 'Azistin Lavanda Pet 900ml 1x12', 18, 12, 45.00, 62.00, 1, 5),
--    ('Azistin Alternativa Cloro Pet 900ml', 'Azistin Alternativa Cloro Pet 900ml 1x12', 18, 12, 45.00, 62.00, 1, 5),
--    ('Azistin Manzana Pet 900ml', 'Azistin Manzana Pet 900ml 1x12', 18, 12, 45.00, 62.00, 1, 5),
--    ('Azistin Lavanda Pet 2ltrs', 'Azistin Lavanda Pet 2ltrs 1x8', 18, 8, 85.00, 115.00, 1, 5),
--    ('Azistin Alternativa Cloro Pet 2ltrs', 'Azistin Alternativa Cloro Pet 2ltrs 1x8', 18, 8, 85.00, 115.00, 1, 5),
--    ('Azistin Lavanda Pet 1gln', 'Azistin Lavanda Pet 1gln 1x4', 18, 4, 140.00, 190.00, 1, 5),
--    ('Azistin Manzana Pet 1gln', 'Azistin Manzana Pet 1gln 1x4', 18, 4, 140.00, 190.00, 1, 5),
--    ('Fabuloso Lavanda Sachet 80ml', 'Fabuloso Lavanda Sachet 80ml 1x12x6', 18, 12, 4.00, 7.00, 1, 5),
--    ('Fabuloso Bicarbonato Sachet 80ml', 'Fabuloso Bicarbonato Sachet 80ml 1x12x6', 18, 12, 4.00, 7.00, 1, 5),
--    ('Fabuloso Alternativa Cloro Sachet 80ml', 'Fabuloso Alternativa Cloro Sachet 80ml 1x12x6', 18, 12, 4.00, 7.00, 1, 5),
--    ('Fabuloso Lavanda Sachet 425ml', 'Fabuloso Lavanda Sachet 425ml 1x24', 18, 24, 25.00, 35.00, 1, 5),
--    ('Fabuloso Lavanda Pet 450ml', 'Fabuloso Lavanda Pet 450ml 1x24', 18, 24, 28.00, 38.00, 1, 5),
--    ('Fabuloso Bicarbonato Pet 450ml', 'Fabuloso Bicarbonato Pet 450ml 1x24', 18, 24, 28.00, 38.00, 1, 5)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);






--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    -- Nuevos agregados
--    ('Apio (manojo)', 'Manojo de apio fresco', 31, 15, 15.00, 22.00, 1, 5),
--    ('Culantro (manojo)', 'Manojo de culantro fresco', 31, 20, 5.00, 10.00, 1, 5),
--    ('Hierbabuena (manojo)', 'Manojo de hierbabuena fresca', 31, 20, 5.00, 10.00, 1, 5),
--    ('Plátano maduro (unidad)', 'Plátano maduro por unidad', 31, 50, 5.00, 8.00, 1, 5),
    
--    -- Verduras y frutas anteriores
--    ('Cebolla blanca (libra)', 'Cebolla blanca fresca por libra', 31, 25, 25.00, 35.00, 1, 5),
--    ('Chiltoma pulpera (docena)', 'Chiltoma verde/roja por docena', 31, 15, 20.00, 30.00, 1, 5),
--    ('Tomate fresco (libra)', 'Tomate maduro/perita por libra', 31, 25, 25.00, 35.00, 1, 5),
--    ('Papa blanca (libra)', 'Papa blanca fresca por libra', 31, 30, 20.00, 30.00, 1, 5),
--    ('Zanahoria (libra)', 'Zanahoria fresca por libra', 31, 20, 20.00, 30.00, 1, 5),
--    ('Banano maduro (mano)', 'Mano de banano maduro', 31, 12, 15.00, 25.00, 1, 5),
--    ('Plátano verde (unidad)', 'Plátano verde para cocer o freír', 31, 50, 5.00, 8.00, 1, 5),
--    ('Repollo (unidad)', 'Repollo fresco entero', 31, 10, 25.00, 35.00, 1, 5),
--    ('Chayote (unidad)', 'Chayote fresco por unidad', 31, 15, 10.00, 15.00, 1, 5),
--    ('Ajo (cabeza)', 'Cabeza de ajo fresco', 31, 20, 12.00, 18.00, 1, 5)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);


--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    ('Purina inicio para pollitos (libra)', 'Alimento concentrado de inicio para pollitos por libra', 28, 40, 15.00, 22.00, 1, 5),
--    ('Purina desarrollo para aves (libra)', 'Concentrado de crecimiento para gallinas y pollos por libra', 28, 50, 14.00, 20.00, 1, 5),
--    ('Purina gallina ponedora (libra)', 'Alimento concentrado especializado para postura por libra', 28, 60, 13.00, 19.00, 1, 5),
--    ('Purina engorde para aves (libra)', 'Concentrado de engorde para aves de patio por libra', 28, 50, 14.00, 20.00, 1, 5),
--    ('Maíz dozado / partido para gallos (libra)', 'Maíz quebrado o dozado especial para alimentación de gallos', 28, 50, 12.00, 18.00, 1, 5),
--    ('King Feed / Ala Dorada para gallos (libra)', 'Alimento y grano especial para mantenimiento y cuido de gallos', 28, 40, 18.00, 26.00, 1, 5)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);




--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    ('Queso seco (1 lb)', 'Queso seco tradicional por libra', 4, 30, 45.00, 60.00, 1, 5),
--    ('Queso seco (media lb / 8 oz)', 'Queso seco tradicional por media libra', 4, 25, 23.00, 32.00, 1, 5),
--    ('Queso fresco / semiseco (1 lb)', 'Queso fresco para desayunar por libra', 4, 30, 40.00, 55.00, 1, 5),
--    ('Queso fresco / semiseco (media lb / 8 oz)', 'Queso fresco por media libra', 4, 25, 20.00, 28.00, 1, 5),
--    ('Cuajada fresca (1 lb)', 'Cuajada fresca de leche entera por libra', 4, 25, 42.00, 58.00, 1, 5),
--    ('Cuajada fresca (media lb / 8 oz)', 'Cuajada fresca por media libra', 4, 20, 22.00, 30.00, 1, 5),
--    ('Crema pura (botella / bolsa 16 oz)', 'Crema láctea pura tradicional', 4, 20, 35.00, 48.00, 1, 5),
--    ('Crema pura (por libra / 16 oz)', 'Crema agria o pura por libra', 4, 20, 38.00, 52.00, 1, 5)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);



--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    ('Huevos medianos (cajilla 30 und)', 'Cajilla de 30 huevos tamaño mediano', 5, 15, 120.00, 145.00, 1, 5),
--    ('Huevos grandes / 1era (cajilla 30 und)', 'Cajilla de 30 huevos tamaño grande de primera', 5, 20, 135.00, 160.00, 1, 5),
--    ('Huevos jumbo (cajilla 30 und)', 'Cajilla de 30 huevos tamaño jumbo', 5, 10, 150.00, 180.00, 1, 5),
--    ('Media cajilla de huevos (15 und)', 'Media cajilla de huevos medianos/grandes', 5, 15, 70.00, 85.00, 1, 5),
--    ('Huevo por unidad', 'Huevo fresco individual para venta al detalle', 5, 100, 4.50, 6.00, 1, 10)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);




--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    ('BT Scott Mil M1P 1x24x1000', '0300199 - BT Scott Mil M1P 1x24x1000', 24, 24, 15.00, 22.00, 1, 5),
--    ('BT Scott Mil H 1P 12x4x1000', '0300307 - BT Scott Mil H 1P 12x4x1000', 24, 12, 14.00, 20.00, 1, 5),
--    ('BT Scott Econo Mil 1x24x1000M', '0301138 - BT Scott Econo Mil 1x24x1000M', 24, 24, 14.50, 21.00, 1, 5),
--    ('BT Scott Econo Mil 72x4x1000H', '0501143 - BT Scott Econo Mil 72x4x1000H', 24, 72, 13.00, 19.00, 1, 5),
--    ('PH Dob Hig 2P REG 24x1x200AMAHB', '0300887 - PH Dob Hig 2P REG 24x1x200AMAHB', 24, 24, 10.00, 15.00, 1, 5),
--    ('PH Jumbo Dob Hig 2P Ind 1x24x280', '0300884 - PH Jumbo Dob Hig 2P Ind 1x24x280', 24, 24, 12.00, 18.00, 1, 5),
--    ('BT Scott Rindem MAX 1x24x420', '0300904 - BT Scott Rindem MAX 1x24x420', 24, 24, 18.00, 26.00, 1, 5),
--    ('Scott 2 en 1 tcl 1x4', '0301176 - Scott 2 en 1 tcl 1x4', 24, 4, 12.00, 18.00, 1, 5),
--    ('Fac Kleenex Orig Junior 1x12x50RW', '0300808 - Fac Kleenex Orig Junior 1x12x50RW', 24, 12, 8.00, 12.00, 1, 5),
--    ('Fac Kleenex Orig 1x12x80RW', '0300810 - Fac Kleenex Orig 1x12x80RW', 24, 12, 10.00, 15.00, 1, 5),
--    ('Fac Kleenex Fam 3P 1x12x150 816', '0300849 - Fac Kleenex Fam 3P 1x12x150 816', 24, 12, 18.00, 26.00, 1, 5),
--    ('Fac Kleenex Orig Pocket 36 x 4 x 10 SWE RW', '0300224 - Fac Kleenex Orig Pocket 36 x 4 x 10 SWE RW', 24, 36, 12.00, 18.00, 1, 5),
--    ('Serv Scott Dia a Dia tp Cuadrada 24x1x100BL', '0300148 - Serv Scott Dia a Dia tp Cuadrada 24x1x100BL', 24, 24, 15.00, 22.00, 1, 5),
--    ('Serv DELSEY 2P 24x100 DISP', '0300040 - Serv DELSEY 2P 24x100 DISP', 24, 24, 14.00, 20.00, 1, 5),
--    ('RT Scott Multiuso Abs 2P 24x1x80', '0300775 - RT Scott Multiuso Abs 2P 24x1x80', 24, 24, 18.00, 25.00, 1, 5),
--    ('TC Scott Cocina Cal Abs 2P 6x2x90', '0300366 - TC Scott Cocina Cal Abs 2P 6x2x90', 24, 6, 25.00, 35.00, 1, 5),
--    ('Toa Fem Kot Noct Tela S/A 16x8 TTX', '0300176 - Toa Fem Kot Noct Tela S/A 16x8 TTX', 23, 16, 12.00, 18.00, 1, 5),
--    ('Toa Fem Kot Noct Tela C/A 16x8 TTX', '0300257 - Toa Fem Kot Noct Tela C/A 16x8 TTX', 23, 16, 12.00, 18.00, 1, 5),
--    ('Toa Fem Kot Noct Tela C/A 16x8 MZ TTX', '0300435 - Toa Fem Kot Noct Tela C/A 16x8 MZ TTX', 23, 16, 12.00, 18.00, 1, 5),
--    ('Toa Fem Kot NT UF Tela CA 16x8', '0201144 - Toa Fem Kot NT UF Tela CA 16x8', 23, 16, 14.00, 20.00, 1, 5),
--    ('TOA FEM KOT NOCT LARGA 1X42X6', '0301223 - TOA FEM KOT NOCT LARGA 1X42X6', 23, 42, 15.00, 22.00, 1, 5),
--    ('Hug Classic P Jumbo 6x50 ZEUS DIS', '0300151 - Hug Classic P Jumbo 6x50 ZEUS DIS', 23, 6, 95.00, 130.00, 1, 5),
--    ('Hug Classic M Jumbo 6x56 ZEUS DIS', '0300152 - Hug Classic M Jumbo 6x56 ZEUS DIS', 23, 6, 95.00, 130.00, 1, 5),
--    ('Pañ Hug Classic G Jumbo 6x50', '0300153 - Pañ Hug Classic G Jumbo 6x50', 23, 6, 95.00, 130.00, 1, 5),
--    ('Hug Classic XG Jumbo 6x39 ZEUS DIS', '0300154 - Hug Classic XG Jumbo 6x39 ZEUS DIS', 23, 6, 95.00, 130.00, 1, 5),
--    ('Classic XXG Jumbo 6x30 ZEUS DIS', '0300311 - Classic XXG Jumbo 6x30 ZEUS DIS', 23, 6, 95.00, 130.00, 1, 5),
--    ('Dia Hug Classic L MiniP 48x4', '0301104 - Dia Hug Classic L MiniP 48x4', 23, 48, 12.00, 18.00, 1, 5),
--    ('Dia Hug Classic XL MiniP 48x4', '0301105 - Dia Hug Classic XL MiniP 48x4', 23, 48, 12.00, 18.00, 1, 5),
--    ('Dia Hug Classic XXL MiniP 48x4', '0301103 - Dia Hug Classic XXL MiniP 48x4', 23, 48, 12.00, 18.00, 1, 5),
--    ('Pañ Kimb G Mega 6x38 NOMULTI C&C', '0300876 - Pañ Kimb G Mega 6x38 NOMULTI C&C', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Kimb XG Mega 6x28 NOMULTI C&C', '0300906 - Pañ Kimb XG Mega 6x28 NOMULTI C&C', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Kimb M Mega 6x38 NOMULTI C&C', '0300911 - Pañ Kimb M Mega 6x38 NOMULTI C&C', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Kimb XXL Mega 6x28 NOMULTI C&C', '0301097 - Pañ Kimb XXL Mega 6x28 NOMULTI C&C', 23, 6, 65.00, 90.00, 1, 5),
--    ('Pañ Hug Act Sec M SinglePK 4x50 ZEUS DIS', '0300140 - Pañ Hug Act Sec M SinglePK 4x50 ZEUS DIS', 23, 4, 110.00, 150.00, 1, 5),
--    ('Pañ Hug Act Sec G SinglePK 4x50 ZEUS DIS', '0300228 - Pañ Hug Act Sec G SinglePK 4x50 ZEUS DIS', 23, 4, 110.00, 150.00, 1, 5),
--    ('Dia Hug Has ActSec S SinglePK 8x25 POCFOFF', '0300741 - Dia Hug Has ActSec S SinglePK 8x25 POCFOFF', 23, 8, 45.00, 62.00, 1, 5),
--    ('Pañ Hug Act Sec XG SinglePK 4x50 ZEUS DIS', '0300142 - Pañ Hug Act Sec XG SinglePK 4x50 ZEUS DIS', 23, 4, 110.00, 150.00, 1, 5),
--    ('Pañ Hug Act Sec M SinglePK 8x25 CAP AME', '0300196 - Pañ Hug Act Sec M SinglePK 8x25 CAP AME', 23, 8, 45.00, 62.00, 1, 5),
--    ('Pañ Hug Act Sec XXG SinglePK 6x30 SMURF', '0300804 - Pañ Hug Act Sec XXG SinglePK 6x30 SMURF', 23, 6, 85.00, 115.00, 1, 5),
--    ('Pañ Hug Has Heroe Single Pack G/S3 8x25', '0300197 - Pañ Hug Has Heroe Single Pack G/S3 8x25', 23, 8, 45.00, 62.00, 1, 5),
--    ('Dia Hug Natcare NB Mega 6x28 Magnum CAM', '0300986 - Dia Hug Natcare NB Mega 6x28 Magnum CAM', 23, 6, 80.00, 110.00, 1, 5),
--    ('BW HUG SIMPLE CLEAN FTOP 1X6X64', '0301262 - BW HUG SIMPLE CLEAN FTOP 1X6X64', 23, 6, 25.00, 35.00, 1, 5),
--    ('Aspirina Forte 100 mg 100 tabletas', '0220007 - Aspirina Forte 100 mg 100 tabletas', 25, 50, 40.00, 55.00, 1, 5),
--    ('Aspirina niños 100 mg 100 tabletas', '0320009 - Aspirina niños 100 mg 100 tabletas', 25, 50, 35.00, 48.00, 1, 5),
--    ('Aleve 220 mg 30 tabletas', '0320001 - Aleve 220 mg 30 tabletas', 25, 30, 45.00, 65.00, 1, 5),
--    ('Acetaminofen 500 mg 1x60x100', '0320099 - Acetaminofen 500 mg 1x60x100', 25, 60, 30.00, 42.00, 1, 5),
--    ('Dorival 200 mg LG 36 GT', '0320889 - Dorival 200 mg LG 36 GT', 25, 36, 40.00, 58.00, 1, 5),
--    ('Tabcin Gripe y Tos Liquid Gel Bayer 12 tabletas 1x36', '0320057 - Tabcin Gripe y Tos Liquid Gel Bayer 12 tabletas 1x36', 25, 36, 50.00, 70.00, 1, 5),
--    ('Tabcin Noche Liquid Gel Bayer 12 tabletas 1x36', '0320058 - Tabcin Noche Liquid Gel Bayer 12 tabletas 1x36', 25, 36, 50.00, 70.00, 1, 5),
--    ('Tabcin Día Liquid Gel Bayer 12 tabletas 1x36', '0320059 - Tabcin Día Liquid Gel Bayer 12 tabletas 1x36', 25, 36, 50.00, 70.00, 1, 5),
--    ('Tabcin Gripe y Tos Liquid Gel Bayer 60 tabletas 1x36', '0320061 - Tabcin Gripe y Tos Liquid Gel Bayer 60 tabletas 1x36', 25, 36, 120.00, 165.00, 1, 5),
--    ('Tabcin Noche Liquid Gel Bayer 60 tabletas 1x36', '0320062 - Tabcin Noche Liquid Gel Bayer 60 tabletas 1x36', 25, 36, 120.00, 165.00, 1, 5),
--    ('Tabcin Día Liquid Gel Bayer 60 tabletas 1x36', '0320063 - Tabcin Día Liquid Gel Bayer 60 tabletas 1x36', 25, 36, 120.00, 165.00, 1, 5),
--    ('Tabcin Gripe y Tos Bayer 245 mg 60 tabletas', '0320018 - Tabcin Gripe y Tos Bayer 245 mg 60 tabletas', 25, 60, 100.00, 140.00, 1, 5),
--    ('Tabcin Antigripal Bayer 510 mg 72 tabletas', '0320016 - Tabcin Antigripal Bayer 510 mg 72 tabletas', 25, 72, 110.00, 150.00, 1, 5),
--    ('Alka-Seltzer BAYER 50 tabletas 1x38', '0320075 - Alka-Seltzer BAYER 50 tabletas 1x38', 26, 38, 45.00, 60.00, 1, 5),
--    ('Alka-Gastric BAYER 500 mg 36 GT', '0320085 - Alka-Gastric BAYER 500 mg 36 GT', 26, 36, 45.00, 62.00, 1, 5),
--    ('Alka-AD BAYER 120 mg 72 tabletas', '0320095 - Alka-AD BAYER 120 mg 72 tabletas', 26, 72, 50.00, 70.00, 1, 5),
--    ('Alka-Seltzer FRUTABS 1x24', '0320087 - Alka-Seltzer FRUTABS 1x24', 26, 24, 30.00, 42.00, 1, 5),
--    ('Bon Bon Bum Cool 15x24x16 g', '0080298 - Bon Bon Bum Cool 15x24x16 g', 11, 24, 35.00, 50.00, 1, 5),
--    ('Bon Bon Bum Clear 15x24x16 g', '0080299 - Bon Bon Bum Clear 15x24x16 g', 11, 24, 35.00, 50.00, 1, 5),
--    ('Limonada Pink 1x20x64', '0080325 - Limonada Pink 1x20x64', 11, 20, 30.00, 42.00, 1, 5),
--    ('Bon Bon Bum Surtido 15x24x16 g', '0080300 - Bon Bon Bum Surtido 15x24x16 g', 11, 24, 35.00, 50.00, 1, 5),
--    ('Bon Bon Bum Sensation 15x24x16 g', '0080302 - Bon Bon Bum Sensation 15x24x16 g', 11, 24, 35.00, 50.00, 1, 5),
--    ('Tajin Pop Case of 16', '0080324 - Tajin Pop Case of 16', 11, 16, 40.00, 58.00, 1, 5),
--    ('Tipitin Surtido BX60S', 'C-0083238 - Tipitin Surtido BX60S', 11, 60, 25.00, 35.00, 1, 5),
--    ('Tipitin Sandia BX60S', 'C-0083299 - Tipitin Sandia BX60S', 11, 60, 25.00, 35.00, 1, 5),
--    ('Helado de Fresa Paleta', 'C-0080263 - Helado de Fresa Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Choco-Mani Paleta', 'C-0080035 - Choco-Mani Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Sabor a Yogurt Paleta', 'C-0080039 - Sabor a Yogurt Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Cervecita Paleta', 'C-0080044 - Cervecita Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Corazón Paleta', 'C-0080045 - Corazón Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Dos Corazones Paleta', 'C-0080110 - Dos Corazones Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Besos Paleta', 'C-0080232 - Besos Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Besos Mora Azul Paleta', 'C-0080312 - Besos Mora Azul Paleta', 11, 60, 25.00, 35.00, 1, 5),
--    ('Caramelo Relleno Surtido 120 unds', '0080030 - Caramelo Relleno Surtido 120 unds', 11, 120, 30.00, 42.00, 1, 5),
--    ('Frutica Surtido 100 unds', '0080207 - Frutica Surtido 100 unds', 11, 100, 25.00, 35.00, 1, 5),
--    ('Coffee Delight 100 unds', '0080193 - Coffee Delight 100 unds', 11, 100, 30.00, 42.00, 1, 5),
--    ('Coffee Delight Blando 100 unds', '0080229 - Coffee Delight Blando 100 unds', 11, 100, 30.00, 42.00, 1, 5),
--    ('Xtime Menta Helada 100 unds', '0080196 - Xtime Menta Helada 100 unds', 11, 100, 25.00, 35.00, 1, 5),
--    ('Xtime Menta Chocolate 100 unds', '0080195 - Xtime Menta Chocolate 100 unds', 11, 100, 25.00, 35.00, 1, 5),
--    ('Mini Choco Mani 100 unds', '0080199 - Mini Choco Mani 100 unds', 11, 100, 25.00, 35.00, 1, 5),
--    ('Caramelo Dulce Miel 1x12x100 unds', '0080194 - Caramelo Dulce Miel 1x12x100 unds', 11, 12, 25.00, 35.00, 1, 5),
--    ('Colombina Mix 1 kg', '0080197 - Colombina Mix 1 kg', 11, 10, 50.00, 70.00, 1, 5),
--    ('Colombina Mix 3 kg', '0080034 - Colombina Mix 3 kg', 11, 5, 140.00, 190.00, 1, 5),
--    ('Mini Bum Sandia 100 unds', '0080184 - Mini Bum Sandia 100 unds', 11, 100, 25.00, 35.00, 1, 5),
--    ('Mini Bum Mega Surtido 6 g 1x12x100 unds', '0080293 - Mini Bum Mega Surtido 6 g 1x12x100 unds', 11, 12, 30.00, 42.00, 1, 5),
--    ('Mini Bum Mango 5g 1x12x100 unds', '0080315 - Mini Bum Mango 5g 1x12x100 unds', 11, 12, 30.00, 42.00, 1, 5),
--    ('Xtime Gum Canela 1x12x100', '0080236 - Xtime Gum Canela 1x12x100', 11, 12, 30.00, 42.00, 1, 5),
--    ('Xtime Gum Yerbabuena 7g 12x100x3', '0080314 - Xtime Gum Yerbabuena 7g 12x100x3', 11, 12, 35.00, 48.00, 1, 5),
--    ('Chicle Acipogo 1x28x100', '0080240 - Chicle Acipogo 1x28x100', 11, 28, 25.00, 35.00, 1, 5),
--    ('Pogo Chibalón 1x18x100', '0080237 - Pogo Chibalón 1x18x100', 11, 18, 25.00, 35.00, 1, 5),
--    ('Mentas Confitadas Best 13 g 1x25x24', '1050014 - Mentas Confitadas Best 13 g 1x25x24', 11, 25, 15.00, 22.00, 1, 5),
--    ('Botoneta Chocolate Ristra 24 unds', '1050016 - Botoneta Chocolate Ristra 24 unds', 11, 24, 20.00, 28.00, 1, 5),
--    ('Botoneta Mani Ristra 24 unds', '1050017 - Botoneta Mani Ristra 24 unds', 11, 24, 20.00, 28.00, 1, 5),
--    ('Conito Mani Bolsa 8.5 g 10 unidades', '1050003 - Conito Mani Bolsa 8.5 g 10 unidades', 11, 10, 15.00, 22.00, 1, 5),
--    ('Conito Mani Pote 7 g 80 Unidades', '1050024 - Conito Mani Pote 7 g 80 Unidades', 11, 80, 80.00, 110.00, 1, 5),
--    ('Best Golosinas Pote 8.5g 70 Unidades', '1050002 - Best Golosinas Pote 8.5g 70 Unidades', 11, 70, 75.00, 100.00, 1, 5),
--    ('Chocogol Bolsa 40 unds', '1050019 - Chocogol Bolsa 40 unds', 11, 40, 40.00, 58.00, 1, 5),
--    ('Chocolate en Polvo Best Ristra 12 unds', '1050004 - Chocolate en Polvo Best Ristra 12 unds', 11, 12, 25.00, 35.00, 1, 5),
--    ('Cobertura ChocoFruta Tableta 300 g', '1050010 - Cobertura ChocoFruta Tableta 300 g', 11, 12, 35.00, 48.00, 1, 5),
--    ('Piazza Jirafa Surtido 1x24x12', '0080118 - Piazza Jirafa Surtido 1x24x12', 10, 24, 30.00, 42.00, 1, 5),
--    ('Piazza Fresa 1x24x10', '0080052 - Piazza Fresa 1x24x10', 10, 24, 25.00, 35.00, 1, 5),
--    ('Piazza Vainilla 1x24x10', '0080055 - Piazza Vainilla 1x24x10', 10, 24, 25.00, 35.00, 1, 5),
--    ('Bridge Vainilla 1x24x10', '0080061 - Bridge Vainilla 1x24x10', 10, 24, 25.00, 35.00, 1, 5),
--    ('Bridge Fresa 1x24x10', '0080057 - Bridge Fresa 1x24x10', 10, 24, 25.00, 35.00, 1, 5),
--    ('Bridge Naranja 1x24x10', '0080103 - Bridge Naranja 1x24x10', 10, 24, 25.00, 35.00, 1, 5),
--    ('Galleta Wafer Fresa 24x24x14 g', '0080309 - Galleta Wafer Fresa 24x24x14 g', 10, 24, 25.00, 35.00, 1, 5),
--    ('Galleta Wafer Vainilla 24x24x14 g', '0080310 - Galleta Wafer Vainilla 24x24x14 g', 10, 24, 25.00, 35.00, 1, 5),
--    ('Galleta Chapetín 12 unds 20g', '1050011 - Galleta Chapetín 12 unds 20g', 10, 12, 15.00, 22.00, 1, 5),
--    ('Galleta Best 20Gr 24x12UND', '1050025 - Galleta Best 20Gr 24x12UND', 10, 24, 25.00, 35.00, 1, 5),
--    ('Empanizador Sazonado Caja Ristra 1x12x6 50 g', '0810001 - Empanizador Sazonado Caja Ristra 1x12x6 50 g', 16, 12, 12.00, 18.00, 1, 5),
--    ('Empanizador Sazonado Caja Ristra 1x12x4 100 g', '0810002 - Empanizador Sazonado Caja Ristra 1x12x4 100 g', 16, 12, 18.00, 25.00, 1, 5),
--    ('Empanizador Sazonado 150 g', '0810030 - Empanizador Sazonado 150 g', 16, 12, 24.00, 32.00, 1, 5),
--    ('Pasas Caja Ristra 1x9x6 45g', '0810003 - Pasas Caja Ristra 1x9x6 45g', 16, 9, 10.00, 15.00, 1, 5),
--    ('Ajo Molido Caja Ristra 1x24x12 2g', '0810023 - Ajo Molido Caja Ristra 1x24x12 2g', 16, 24, 5.00, 8.00, 1, 5),
--    ('Pimienta Negra Caja Ristra 1x24x12 2g', '0810021 - Pimienta Negra Caja Ristra 1x24x12 2g', 16, 24, 5.00, 8.00, 1, 5),
--    ('Canela Molida Caja Ristra 1x24x12 2.5g', '0810022 - Canela Molida Caja Ristra 1x24x12 2.5g', 16, 24, 5.00, 8.00, 1, 5),
--    ('Sazón Todo Uso Caja Ristra 1x24x12 3g', '0810025 - Sazón Todo Uso Caja Ristra 1x24x12 3g', 16, 24, 5.00, 8.00, 1, 5),
--    ('Comino Molido 1x6 13g', '0810035 - Comino Molido 1x6 13g', 16, 6, 8.00, 12.00, 1, 5),
--    ('Consomé de Pollo Caja Ristra 1x24x12 8g', '0810024 - Consomé de Pollo Caja Ristra 1x24x12 8g', 16, 24, 6.00, 10.00, 1, 5),
--    ('Sabor y Color 1x24x13 10 g', '0810031 - Sabor y Color 1x24x13 10 g', 16, 24, 6.00, 10.00, 1, 5),
--    ('Salsa Picante Sol Maya 480 ml 1x24', '0810038 - Salsa Picante Sol Maya 480 ml 1x24', 15, 24, 28.00, 38.00, 1, 5),
--    ('Fósforos Águila (cajita unidad)', 'Cajita individual de fósforos Águila', 33, 100, 1.50, 2.50, 1, 5),
--    ('Fósforos Águila (paquete 10 unds)', 'Paquete de 10 cajitas de fósforos Águila (0070002)', 33, 20, 12.00, 18.00, 1, 5),
--    ('Papel Aluminio Thor 25 pies', '0800001 - Papel aluminio Thor rollo 25 pies', 19, 24, 25.00, 35.00, 1, 5),
--    ('Papel Aluminio Thor 75 pies', '0800002 - Papel aluminio Thor rollo 75 pies', 19, 24, 60.00, 82.00, 1, 5),
--    ('Palillo de Dientes El Sol 1x250', '0330001 - Palillo de Dientes El Sol 1x250', 19, 25, 8.00, 12.00, 1, 5),
--    ('Palillo de Dientes El Sol 1x500', '0350001 - Palillo de Dientes El Sol 1x500', 19, 25, 12.00, 18.00, 1, 5),
--    ('Palillo de Chocobanano 1x36x250', '0330015 - Palillo de Chocobanano 1x36x250', 19, 36, 15.00, 22.00, 1, 5),
--    ('Esponjas El Sol Doble Propósito 1x30x10', '0330018 - Esponjas El Sol Doble Propósito 1x30x10', 19, 30, 15.00, 22.00, 1, 5),
--    ('Esponjas El Sol 1x25x12', '0330019 - Esponjas El Sol 1x250x12', 19, 25, 18.00, 25.00, 1, 5),
--    ('Mecha para Lampazo Azul #20 Klintex', '0110003 - Mecha para Lampazo Azul #20 Klintex', 19, 20, 35.00, 48.00, 1, 5),
--    ('Mecha para Lampazo #24 Klintex', '0110070 - Mecha para Lampazo #24 Klintex', 19, 24, 40.00, 55.00, 1, 5),
--    ('Mecha para Lampazo #18 Klintex', '0110069 - Mecha para Lampazo #18 Klintex', 19, 18, 30.00, 42.00, 1, 5),
--    ('Escoba Bailarina Escoplast', '0230002 - Escoba Bailarina Escoplast', 19, 15, 45.00, 62.00, 1, 5),
--    ('Escoba Explendida Escoplast', '0230003 - Escoba Explendida Escoplast', 19, 15, 50.00, 68.00, 1, 5),
--    ('Escoba Super Bailarina Escoplast', '0230006 - Escoba Super Bailarina Escoplast', 19, 15, 55.00, 75.00, 1, 5),
--    ('Escoba Super Hermosa Escoplast', '0230007 - Escoba Super Hermosa Escoplast', 19, 15, 55.00, 75.00, 1, 5),
--    ('Eco Pala Plástica Escoplast', '0230010 - Eco Pala Plástica Escoplast', 19, 20, 25.00, 35.00, 1, 5),
--    ('Cepillo para Ropa Ecoplancha Escoplast', '0230001 - Cepillo para Ropa Ecoplancha Escoplast', 19, 20, 20.00, 28.00, 1, 5),
--    ('Cepillo Sanitario Escoplast 1x24', '0230012 - Cepillo Sanitario Escoplast 1x24', 19, 24, 30.00, 42.00, 1, 5),
--    ('Atún Calvo Lomo en Trozos en Agua 142 g 1x48', '0220059 - Atún Calvo Lomo en Trozos en Agua 142 g 1x48', 12, 48, 35.00, 48.00, 1, 5),
--    ('Atún Calvo Lomo en Trozos con Vegetales 142 g 1x48', '0220060 - Atún Calvo Lomo en Trozos con Vegetales 142 g 1x48', 12, 48, 35.00, 48.00, 1, 5),
--    ('Atún Calvo Lomo en Trocitos en Aceite Vegetal 142 g 1x48', '0220061 - Atún Calvo Lomo en Trocitos en Aceite Vegetal 142 g 1x48', 12, 48, 35.00, 48.00, 1, 5),
--    ('Sardina en Salsa Picante Calvo 1x50x155 g', '0220070 - Sardina en Salsa Picante Calvo 1x50x155 g', 12, 50, 25.00, 35.00, 1, 5),
--    ('Sardina en Salsa Tomate Calvo 1x50x155 g', '0220071 - Sardina en Salsa Tomate Calvo 1x50x155 g', 12, 50, 25.00, 35.00, 1, 5),
--    ('Leche en Polvo Pinito 110 g 1x12', '0370046 - Leche en Polvo Pinito 110 g 1x12', 4, 12, 40.00, 55.00, 1, 5),
--    ('Leche en Polvo Pinito 350 g 1x24', '0370020 - Leche en Polvo Pinito 350 g 1x24', 4, 24, 110.00, 145.00, 1, 5),
--    ('Leche en Polvo Pinito 1.5 Kg 1x6', '0370016 - Leche en Polvo Pinito 1.5 Kg 1x6', 4, 6, 420.00, 550.00, 1, 5),
--    ('Fragata Mini Encendedor 1x25', '0550017 - Fragata Mini Encendedor 1x25', 29, 25, 15.00, 22.00, 1, 5),
--    ('Fragata Maxi Encendedor 1x25', '0550016 - Fragata Maxi Encendedor 1x25', 29, 25, 18.00, 25.00, 1, 5),
--    ('Lámpara Philips 75W/13W LED 1x20', '0130094 - Lámpara Philips 75W/13W LED 1x20', 29, 20, 65.00, 90.00, 1, 5),
--    ('Lámpara LED Bulb EcoHome 6W 110V', '0130078 - Lámpara LED Bulb EcoHome 6W 110V', 29, 20, 40.00, 58.00, 1, 5),
--    ('Lámpara LED Bulb EcoHome 8W 110V', '0130079 - Lámpara LED Bulb EcoHome 8W 110V', 29, 20, 45.00, 62.00, 1, 5),
--    ('Lámpara LED Bulb EcoHome 10W 110V', '0130980 - Lámpara LED Bulb EcoHome 10W 110V', 29, 20, 50.00, 70.00, 1, 5),
--    ('Lámpara LED Bulb EcoHome 12W 110V', '0120081 - Lámpara LED Bulb EcoHome 12W 110V', 29, 20, 55.00, 78.00, 1, 5),
--    ('Lámpara LED Bulb EcoHome 14W 110V', '0130082 - Lámpara LED Bulb EcoHome 14W 110V', 29, 20, 60.00, 85.00, 1, 5),
--    ('Candelas Magic Light 50 x 10 unids', '0750001 - Candelas Magic Light 50 x 10 unids', 29, 50, 45.00, 62.00, 1, 5),
--    ('Veladora Magic Light Amarilla 3 pulg 1x24', '0750022 - Veladora Magic Light Amarilla 3 pulg 1x24', 29, 24, 15.00, 22.00, 1, 5),
--    ('Veladora Magic Light Blanca 3 pulg 1x24', '0750023 - Veladora Magic Light Blanca 3 pulg 1x24', 29, 24, 15.00, 22.00, 1, 5),
--    ('Veladora Magic Light Roja 3 pulg 1x24', '0750024 - Veladora Magic Light Roja 3 pulg 1x24', 29, 24, 15.00, 22.00, 1, 5),
--    ('Veladora Magic Light Amarilla 8 pulg 1x12', '0750009 - Veladora Magic Light Amarilla 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Magic Light Blanca 8 pulg 1x12', '0750008 - Veladora Magic Light Blanca 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Magic Light Roja 8 pulg 1x12', '0750010 - Veladora Magic Light Roja 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Magic Light Verde 8 pulg 1x12', '0750019 - Veladora Magic Light Verde 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Magic Light Morado 8 pulg 1x12', '0750020 - Veladora Magic Light Morado 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Magic Light Rosado 8 pulg 1x12', '0750018 - Veladora Magic Light Rosado 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Magic Light Negra 8 pulg 1x12', '0750028 - Veladora Magic Light Negra 8 pulg 1x12', 29, 12, 35.00, 48.00, 1, 5),
--    ('Veladora Inmaculada Concepción 8 pulg 1x12', '0750014 - Veladora Inmaculada Concepción 8 pulg 1x12', 29, 12, 40.00, 55.00, 1, 5),
--    ('Veladora Virgen de Guadalupe 8 pulg 1x12', '0750013 - Veladora Virgen de Guadalupe 8 pulg 1x12', 29, 12, 40.00, 55.00, 1, 5),
--    ('Veladora Sagrado Corazón 8 pulg 1x12', '0750012 - Veladora Sagrado Corazón 8 pulg 1x12', 29, 12, 40.00, 55.00, 1, 5),
--    ('Veladora Divino Niño 8 pulg 1x12', '0750011 - Veladora Divino Niño 8 pulg 1x12', 29, 12, 40.00, 55.00, 1, 5),
--    ('Globo No. 9 Surtido 1x100x100', '0890002 - Globo No. 9 Surtido 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Blanco 1x100x100', '0890002_B - Globo No. 9 Blanco 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Rojo 1x100x100', '0890003 - Globo No. 9 Rojo 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Azul 1x100x100', '0890004 - Globo No. 9 Azul 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Amarillo 1x100x100', '0890005 - Globo No. 9 Amarillo 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Celeste 1x100x100', '0890007 - Globo No. 9 Celeste 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Fucsia 1x100x100', '0890009 - Globo No. 9 Fucsia 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Verde Navideño 1x100x100', '0890011 - Globo No. 9 Verde Navideño 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Rosado Baby 1x100x100', '0890014 - Globo No. 9 Rosado Baby 1x100x100', 33, 100, 45.00, 62.00, 1, 5),
--    ('Globo No. 9 Dorado 1x100x100', '0890016 - Globo No. 9 Dorado 1x100x100', 33, 100, 50.00, 68.00, 1, 5),
--    ('Globo No. 9 Oro Perlado 1x100x100', '0890065 - Globo No. 9 Oro Perlado 1x100x100', 33, 100, 50.00, 68.00, 1, 5),
--    ('Globo Flexia Surtido 1x60x100', '0890032 - Globo Flexia Surtido 1x60x100', 33, 60, 40.00, 55.00, 1, 5),
--    ('Lápiz de Grafito 851759 PEP HB Pote 1x20x72', '1040062 - Lápiz de Grafito 851759 PEP HB Pote 1x20x72', 30, 20, 5.00, 8.00, 1, 5),
--    ('Lápiz de Color 832023 Color PEPS PR CJ 1x144x12', '1040069 - Lápiz de Color 832023 Color PEPS PR CJ 1x144x12', 30, 144, 45.00, 62.00, 1, 5),
--    ('Tajador 506300 Vivo Sencillo Disp 1x48x75', '1040018 - Tajador 506300 Vivo Sencillo Disp 1x48x75', 30, 48, 10.00, 15.00, 1, 5),
--    ('Tajador 534754 I-Gloo Sencillo Disp 1x36x30', '1040013 - Tajador 534754 I-Gloo Sencillo Disp 1x36x30', 30, 36, 12.00, 18.00, 1, 5),
--    ('Tajador 63211 Boogy Pote 1x48x75', '1040020 - Tajador 63211 Boogy Pote 1x48x75', 30, 48, 12.00, 18.00, 1, 5),
--    ('Borrador 116050 Technic Pulse Disp 1x24x20', '1040084 - Borrador 116050 Technic Pulse Disp 1x24x20', 30, 24, 8.00, 12.00, 1, 5),
--    ('Marcadores 84572003 Ocean 1x96x12', '1040058 - Marcadores 84572003 Ocean 1x96x12', 30, 96, 40.00, 58.00, 1, 5),
--    ('Resaltador 742534 Amarillo Disp 1x12x12', '1040053 - Resaltador 742534 Amarillo Disp 1x12x12', 30, 12, 12.00, 18.00, 1, 5),
--    ('Resaltador 742533 P Verde Disp 1x12x12', '1040054 - Resaltador 742533 P Verde Disp 1x12x12', 30, 12, 12.00, 18.00, 1, 5),
--    ('Resaltador 742535 P Naranja Disp 1x12x12', '1040055 - Resaltador 742535 P Naranja Disp 1x12x12', 30, 12, 12.00, 18.00, 1, 5)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);


--INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro, StockMinimo)
--SELECT p.Nombre, p.Descripcion, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta, p.Estado, GETDATE(), p.StockMinimo
--FROM (VALUES 
--    -- ... (todos los productos anteriores) ...

--    -- Nuevos Productos Solicitados:
--    ('Café Presto (sobre unidad)', 'Sobre individual de Café Presto instantáneo 2g', 35, 100, 2.50, 4.00, 1, 10),
--    ('Café Presto (paquete/lata)', 'Café Presto instantáneo 100g', 35, 20, 45.00, 60.00, 1, 5),
--    ('Coca-Cola 3 Litros Desechable', 'Gaseosa Coca-Cola botella 3 Litros NR', 6, 24, 65.00, 85.00, 1, 5),
--    ('Gaseosa Fresca 3 Litros', 'Gaseosa Fresca sabor toronja 3 Litros NR', 6, 24, 60.00, 80.00, 1, 5),
--    ('Gaseosa Fresca 500 ml', 'Gaseosa Fresca sabor toronja 500 ml', 6, 36, 15.00, 22.00, 1, 5),
--    ('Hielo en Bolsa (Bolsa de Hielo)', 'Bolsa de hielo en cubo 5 lbs / 10 lbs', 33, 30, 20.00, 30.00, 1, 5)
--) AS p(Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, StockMinimo)
--WHERE NOT EXISTS (
--    SELECT 1 FROM Producto target WHERE LOWER(RTRIM(LTRIM(target.Nombre))) = LOWER(RTRIM(LTRIM(p.Nombre)))
--);


--INSERT INTO Producto (
--    Nombre,
--    Descripcion,
--    IdCategoria,
--    Stock,
--    PrecioCompra,
--    PrecioVenta,
--    Estado,
--    FechaRegistro,
--    StockMinimo
--)
--SELECT
--    p.Nombre,
--    p.Descripcion,
--    p.IdCategoria,
--    p.Stock,
--    p.PrecioCompra,
--    p.PrecioVenta,
--    p.Estado,
--    GETDATE(),
--    p.StockMinimo
--FROM (
--    VALUES
--        ('Pollo Entero', 'Pollo entero fresco por unidad', 36, 20, 180.00, 220.00, 1, 3),
--        ('Pechuga de Pollo', 'Pechuga de pollo fresca por libra', 36, 30, 75.00, 95.00, 1, 5),
--        ('Alitas de Pollo', 'Alitas de pollo frescas por libra', 36, 25, 65.00, 85.00, 1, 5),
--        ('Menudo de Pollo', 'Menudo de pollo fresco por libra', 36, 20, 25.00, 40.00, 1, 5),
--        ('Pierna con Muslo', 'Pierna y muslo de pollo por libra', 36, 30, 55.00, 75.00, 1, 5),

--        ('Carne de Cerdo', 'Carne de cerdo fresca por libra', 36, 20, 95.00, 120.00, 1, 5),
--        ('Costilla de Cerdo', 'Costilla de cerdo fresca por libra', 36, 15, 105.00, 135.00, 1, 5),
--        ('Chuleta de Cerdo', 'Chuleta de cerdo por libra', 36, 20, 100.00, 130.00, 1, 5),

--        ('Carne de Res', 'Carne de res fresca por libra', 36, 20, 130.00, 165.00, 1, 5),
--        ('Carne Molida de Res', 'Carne molida de res por libra', 36, 20, 120.00, 150.00, 1, 5),
--        ('Costilla de Res', 'Costilla de res por libra', 36, 15, 135.00, 170.00, 1, 5),
--        ('Bistec de Res', 'Bistec de res por libra', 36, 20, 145.00, 180.00, 1, 5),

--        ('Higado de Res', 'Hígado de res fresco por libra', 36, 15, 70.00, 95.00, 1, 5),
--        ('Corazon de Res', 'Corazón de res fresco por libra', 36, 15, 60.00, 85.00, 1, 5),
--        ('Pata de Cerdo', 'Pata de cerdo fresca por libra', 36, 10, 45.00, 70.00, 1, 3)
--) AS p (
--    Nombre,
--    Descripcion,
--    IdCategoria,
--    Stock,
--    PrecioCompra,
--    PrecioVenta,
--    Estado,
--    StockMinimo
--)
--WHERE NOT EXISTS (
--    SELECT 1
--    FROM Producto target
--    WHERE LOWER(LTRIM(RTRIM(target.Nombre))) =
--          LOWER(LTRIM(RTRIM(p.Nombre)))
--);








--INSERT INTO Producto (
--    Nombre,
--    Descripcion,
--    IdCategoria,
--    Stock,
--    PrecioCompra,
--    PrecioVenta,
--    Estado,
--    FechaRegistro,
--    StockMinimo
--)
--SELECT
--    p.Nombre,
--    p.Descripcion,
--    p.IdCategoria,
--    p.Stock,
--    p.PrecioCompra,
--    p.PrecioVenta,
--    p.Estado,
--    GETDATE(),
--    p.StockMinimo
--FROM (
--    VALUES
--        ('Pan Unidad', 'Pan tradicional por unidad', 10, 120, 2.50, 4.00, 1, 20),
--        ('Pan Bolsa', 'Bolsa de pan tradicional', 10, 30, 25.00, 35.00, 1, 5),

--        ('Picos Unidad', 'Pico tradicional por unidad', 10, 150, 1.50, 3.00, 1, 20),
--        ('Picos Bolsa', 'Bolsa de picos tradicionales', 10, 25, 20.00, 30.00, 1, 5),

--        ('Polvoron Unidad', 'Polvorón tradicional por unidad', 10, 100, 3.00, 5.00, 1, 15),
--        ('Polvoron Bolsa', 'Bolsa de polvorones', 10, 20, 30.00, 45.00, 1, 5),

--        ('Puntos Rojos Unidad', 'Punto rojo por unidad', 10, 80, 4.00, 6.00, 1, 10),
--        ('Puntos Rojos Bolsa', 'Bolsa de puntos rojos', 10, 15, 40.00, 55.00, 1, 3),

--        ('Lenguas Unidad', 'Lengua dulce por unidad', 10, 80, 4.00, 6.00, 1, 10),
--        ('Lenguas Bolsa', 'Bolsa de lenguas dulces', 10, 15, 40.00, 55.00, 1, 3),

--        ('Margaritas Unidad', 'Margarita dulce por unidad', 10, 80, 4.00, 6.00, 1, 10),
--        ('Margaritas Bolsa', 'Bolsa de margaritas', 10, 15, 40.00, 55.00, 1, 3),

--        ('Torta Reposteria Unidad', 'Porción de torta de repostería', 10, 40, 8.00, 12.00, 1, 5),
--        ('Torta Reposteria Completa', 'Torta completa para venta', 10, 5, 120.00, 180.00, 1, 1),

--        ('Pan Hamburguesa Unidad', 'Pan para hamburguesa por unidad', 10, 100, 3.00, 5.00, 1, 15),
--        ('Pan Hamburguesa Bolsa', 'Bolsa de pan para hamburguesa', 10, 20, 25.00, 40.00, 1, 3),

--        ('Pan Barra Grande Unidad', 'Pan barra grande por unidad', 10, 50, 12.00, 18.00, 1, 5),
--        ('Pan Barra Grande Bolsa', 'Bolsa de pan barra grande', 10, 10, 70.00, 95.00, 1, 2)
--) AS p (
--    Nombre,
--    Descripcion,
--    IdCategoria,
--    Stock,
--    PrecioCompra,
--    PrecioVenta,
--    Estado,
--    StockMinimo
--)
--WHERE NOT EXISTS (
--    SELECT 1
--    FROM Producto target
--    WHERE LOWER(LTRIM(RTRIM(target.Nombre))) =
--          LOWER(LTRIM(RTRIM(p.Nombre)))
--);




--INSERT INTO Producto
--(
--    Nombre,
--    Descripcion,
--    IdCategoria,
--    Stock,
--    PrecioCompra,
--    PrecioVenta,
--    Estado,
--    FechaRegistro,
--    StockMinimo
--)
--SELECT
--    p.Nombre,
--    p.Descripcion,
--    p.IdCategoria,
--    p.Stock,
--    p.PrecioCompra,
--    p.PrecioVenta,
--    p.Estado,
--    GETDATE(),
--    p.StockMinimo
--FROM
--(
--    VALUES

--    -- BIG COLA
--    ('Big Cola 360 ml Unidad',
--     'Gaseosa Big Cola 360 ml venta unitaria',
--     6,48,10.83,15.00,1,10),

--    ('Big Cola 500 ml Unidad',
--     'Gaseosa Big Cola 500 ml venta unitaria',
--     6,48,15.00,20.00,1,10),

--    -- CFRUT
--    ('Cfrut Citrus Punch 500 ml Unidad',
--     'Bebida Cfrut Citrus Punch 500 ml',
--     6,48,12.00,18.00,1,10),

--    ('Cfrut 1 Litro Unidad',
--     'Bebida Cfrut 1 litro',
--     6,24,18.00,25.00,1,5),

--    ('Cfrut 2 Litros Unidad',
--     'Bebida Cfrut 2 litros',
--     6,24,28.00,38.00,1,5),

--    -- AGUA CIELO
--    ('Agua Cielo 250 ml Unidad',
--     'Agua purificada Cielo 250 ml',
--     7,48,5.00,8.00,1,10),

--    ('Agua Cielo 625 ml Unidad',
--     'Agua purificada Cielo 625 ml',
--     7,48,8.00,12.00,1,10),

--    ('Agua Cielo 1 Litro Unidad',
--     'Agua purificada Cielo 1 litro',
--     7,24,12.00,18.00,1,5),

--    ('Agua Cielo 2 Litros Unidad',
--     'Agua purificada Cielo 2 litros',
--     7,24,18.00,25.00,1,5),

--    ('Agua Cielo Antioxidante 650 ml Unidad',
--     'Agua Cielo con antioxidantes',
--     7,24,15.00,20.00,1,5),

--    -- VOLT
--    ('Volt Energizante 300 ml Unidad',
--     'Bebida energizante Volt 300 ml',
--     8,48,12.00,18.00,1,10),

--    ('Volt 340 ml Unidad',
--     'Bebida energizante Volt 340 ml',
--     8,48,12.00,18.00,1,10),

--    ('Volt 625 ml Unidad',
--     'Bebida energizante Volt 625 ml',
--     8,24,18.00,25.00,1,5),

--    ('Volt Ginseng 300 ml Unidad',
--     'Bebida energizante Volt Ginseng',
--     8,48,12.00,18.00,1,10),

--    -- SPORADE
--    ('Sporade 360 ml Unidad',
--     'Bebida hidratante Sporade 360 ml',
--     8,48,12.00,18.00,1,10),

--    ('Sporade 625 ml Unidad',
--     'Bebida hidratante Sporade 625 ml',
--     8,24,18.00,25.00,1,5),

--    -- BIO ALOE
--    ('Bio Aloe 360 ml Unidad',
--     'Bebida Bio Aloe 360 ml',
--     7,24,15.00,20.00,1,5),

--    ('Bio Aloe 500 ml Unidad',
--     'Bebida Bio Aloe 500 ml',
--     7,24,18.00,25.00,1,5),

--    -- D GUSSTO
--    ('D Gussto Snack 20 g Unidad',
--     'Snack D Gussto individual 20 gramos',
--     9,60,6.67,10.00,1,10),

--    ('D Gussto Snack 55 g Unidad',
--     'Snack D Gussto individual 55 gramos',
--     9,48,12.00,18.00,1,10)

--) AS p
--(
--    Nombre,
--    Descripcion,
--    IdCategoria,
--    Stock,
--    PrecioCompra,
--    PrecioVenta,
--    Estado,
--    StockMinimo
--)
--WHERE NOT EXISTS
--(
--    SELECT 1
--    FROM Producto t
--    WHERE LOWER(LTRIM(RTRIM(t.Nombre))) =
--          LOWER(LTRIM(RTRIM(p.Nombre)))
--);







--INSERT INTO Producto
--(
--    Nombre,Descripcion,IdCategoria,Stock,
--    PrecioCompra,PrecioVenta,
--    Estado,FechaRegistro,StockMinimo
--)
--SELECT
--    p.Nombre,p.Descripcion,p.IdCategoria,p.Stock,
--    p.PrecioCompra,p.PrecioVenta,
--    p.Estado,GETDATE(),p.StockMinimo
--FROM
--(
--VALUES

--('Taqueritos Buffalo Ranch','Snack de maiz sabor buffalo ranch',9,40,12.00,15.00,1,5),

--('Zambos Yuquitas Ajo Parmesano','Yuquitas sabor ajo parmesano',9,40,15.00,20.00,1,5),
--('Zambos Camote con Sal Marina','Chips de camote con sal marina',9,40,15.00,20.00,1,5),
--('Zambos Con Chicharron del Rancho','Tajaditas con sabor chicharron',9,40,15.00,20.00,1,5),

--('Zibas Miel Mostaza','Papas fritas sabor miel mostaza',9,40,15.00,20.00,1,5),

--('Ranchitas Buffalo Ranch','Tortillas sabor buffalo ranch',9,40,12.00,15.00,1,5),
--('Ranchitas Nacho Excitante','Tortillas sabor nacho excitante',9,40,12.00,15.00,1,5),
--('Ranchitas Nacho Extremo','Tortillas sabor nacho extremo',9,40,12.00,15.00,1,5),
--('Ranchitas Nacho Cinema','Tortillas sabor nacho cinema',9,40,12.00,15.00,1,5),

--('Taco Tornitos Chile Toreado','Tornitos sabor chile toreado',9,40,12.00,15.00,1,5),
--('Taco Tornitos Queso','Tornitos sabor queso',9,40,12.00,15.00,1,5),

--('Yumm Mix Tropical','Mezcla de snacks tropicales',9,30,18.00,25.00,1,5),
--('Yumm Mix Tropical Picositos','Mezcla de snacks tropicales picantes',9,30,18.00,25.00,1,5),

--('Yummi Pops Nacho Jalapeno Cream','Palomitas sabor jalapeño cream',9,30,15.00,20.00,1,5),
--('Yummi Pops Nacho Queso Blanco','Palomitas sabor queso blanco',9,30,15.00,20.00,1,5),

--('Anillitos de Papa Barbacoa','Anillitos de papa sabor barbacoa',9,30,10.00,15.00,1,5),
--('Anillitos de Papa Jalapeno','Anillitos de papa sabor jalapeño',9,30,10.00,15.00,1,5),

--('Xixi Leche de Burra','Snack Xixi Leche de Burra',9,30,10.00,15.00,1,5)

--) p
--(
--Nombre,Descripcion,IdCategoria,Stock,
--PrecioCompra,PrecioVenta,
--Estado,StockMinimo
--)
--WHERE NOT EXISTS
--(
--    SELECT 1
--    FROM Producto t
--    WHERE LOWER(LTRIM(RTRIM(t.Nombre)))
--       = LOWER(LTRIM(RTRIM(p.Nombre)))
--);

SELECT p.IdProducto, p.Codigo, p.Nombre, p.IdCategoria, p.Stock, p.PrecioCompra, p.PrecioVenta
FROM Producto p
ORDER BY p.IdCategoria, p.Nombre;

        SELECT Nombre AS Producto, Stock, StockMinimo AS [Mínimo]
        FROM Producto
        WHERE Estado = 1 AND Stock <= StockMinimo
        ORDER BY (Stock * 1.0 / NULLIF(StockMinimo, 0)), Nombre;
