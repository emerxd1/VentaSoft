SELECT * FROM Rol
SELECT * FROM Usuario
SELECT * FROM Permiso
SELECT * FROM Cliente
SELECT * FROM Categoria
SELECT * FROM Producto

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

insert into Rol (Descripcion)values ('Empleado')

insert into Permiso (IdRol,NombreMenu) values 
(2,'MenuProducto'),
(2, 'MenuVentas'),
(2, 'MenuCompras'),
(2, 'MenuProveedores'),
(2, 'MenuClientes'),
(2, 'MenuAbout')

/*AGRENGANDO UN NUEVO SUBMENU CATEGORIA PARA GESTIONAR CATEGORIAS DE PRODUCTOS*/
insert into Permiso (IdRol,NombreMenu) values 
(2,'MenuCategory')

insert into Permiso (IdRol,NombreMenu) values 
(1,'MenuCategory')









Delete from Rol where IdRol =2;

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
VALUES ('002-894566-8922O','Empleado','Prueba','Numero','1', 'empleadoex@gmail.com','user',2,1)

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

/* REGISTRAR USUARIO */
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
                            Correo, Clave, IdRol, Estado)
        VALUES (@DNI, @Nombre1, @Nombre2, @Apellido1, @Apellido2,
                @Correo, @Clave, @IdRol, @Estado)

        SET @IdUsuarioResultado = SCOPE_IDENTITY()
        SET @Mensaje = ''
    END
    ELSE
        SET @Mensaje = 'El valor ingresado ya se encuentra asignado a otro usuario. No se permiten valores duplicados.'
END
GO

/* EDITAR USUARIO */
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
                   Estado <> @Estado
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
                Estado = @Estado
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

/* ELIMINAR USUARIO (BORRADO LOGICO) */
CREATE OR ALTER PROCEDURE SP_DELETEUSER
(
    @IdUsuario int,
    @Error bit OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON
    SET @Error = 0
    SET @Mensaje = ''

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Usuario WHERE IdUsuario = @IdUsuario)
        BEGIN
            SET @Mensaje = 'El usuario no existe.'
            RETURN
        END

        IF EXISTS (SELECT 1 FROM Usuario WHERE IdUsuario = @IdUsuario AND Estado = 0)
        BEGIN
            SET @Mensaje = 'El usuario ya se encuentra inactivo.'
            RETURN
        END

        UPDATE Usuario SET Estado = 0 WHERE IdUsuario = @IdUsuario

        SET @Error = 1
        SET @Mensaje = 'Usuario inactivado correctamente.'
    END TRY
    BEGIN CATCH
        SET @Error = 0
        SET @Mensaje = ERROR_MESSAGE()
    END CATCH
END
GO



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
END
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

    -- Validación 2: el RUC no debe pertenecer a OTRO proveedor
    IF EXISTS (SELECT 1 FROM Proveedor WHERE RUC = @RUC AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'El N° de RUC ya existe'
        RETURN
    END

    -- Validación 3: la Razón Social no debe pertenecer a OTRO proveedor
    IF EXISTS (SELECT 1 FROM Proveedor WHERE RazonSocial = @RazonSocial AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'Ya existe un proveedor con esa Razón Social'
        RETURN
    END

    -- Validación 4: lo mismo para el correo (UNIQUE)
    IF ISNULL(@Correo, '') <> ''
       AND EXISTS (SELECT 1 FROM Proveedor WHERE Correo = @Correo AND IdProveedor <> @IdProveedor)
    BEGIN
        SET @Mensaje = 'El correo ya está asignado a otro proveedor'
        RETURN
    END

    -- Validación 5: el teléfono no debe pertenecer a OTRO proveedor
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