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
    @Nombre VARCHAR(30),
    @Descripcion VARCHAR(MAX),
    @IdCategoria INT,
    @Estado BIT,
    @Stock INT,
    @PrecioCompra DECIMAL(10,2),
    @PrecioVenta DECIMAL(10,2),
    @IdResult INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdResult = 0

    IF NOT EXISTS (SELECT * FROM Producto WHERE Nombre = @Nombre)
    BEGIN
        INSERT INTO Producto (Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado)
        VALUES (@Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioCompra, @PrecioVenta, @Estado)

        SET @IdResult = SCOPE_IDENTITY()
        SET @Mensaje = 'Producto registrado correctamente'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'Ya existe un producto con ese nombre'
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