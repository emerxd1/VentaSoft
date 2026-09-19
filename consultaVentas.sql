SELECT * FROM Rol
SELECT * FROM Usuario
SELECT * FROM Permiso
SELECT * FROM Categoria

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
inner join Rol r on r.IdRol = u.IdRol /*consulta para mostrar datos en datagridview usuarios o empleados */


/*Select *  FROM dbo.Permiso
WHERE IdPermiso IN (1003,1004,1005,1006,1007,1008);*/



/*-----------------------PROCEDIMIENTOS PRA CRUD DE EMPLEADOS --------------------------------------*/

/*METODO PARA REGISTRAR USUARIOS*/

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
@Mensaje VARCHAR(500) output/*DEVUELVEN RESULTADOS DEL SP*/

)
AS 
BEGIN
SET @IdUsuarioResultado=0
SET @Mensaje=''

IF NOT EXISTS (SELECT * FROM Usuario WHERE DNI = @DNI )
BEGIN 
INSERT INTO Usuario(DNI,Nombre1,Nombre2,Apellido1,Apellido2,
Correo,Clave,IdRol,Estado) VALUES
(@DNI,@Nombre1,@Nombre2,@Apellido1,@Apellido2,
@Correo,@Clave,@IdRol,@Estado)

SET @IdUsuarioResultado = SCOPE_IDENTITY()
SET @Mensaje =''
END
ELSE 
SET @Mensaje = 'El valor ingresado ya se encuentra asignado a otro usuario. No se permiten valores duplicados.'


END

/*METODO PARA EDITAR USUARIOS*/
GO

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

    -- Validar duplicados
        -- Verifica si el DNI ya pertenece a OTRO usuario (IdUsuario distinto al que se está editando).
    -- Usamos IdUsuario <> @IdUsuario para excluir la propia fila que estamos editando,
    -- ya que si comparamos contra el mismo usuario (sin cambiar el DNI), siempre se
    -- encontraría a sí mismo y bloquearía la actualización por error.
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
    /*ANTES SOLO EDITABA EL USUARIO SI EL USUARIO CAMBIABA EL DNI AHORA NO*/
END




/*METODO PARA ELIMINAR USUARIO*/
GO

CREATE PROC SP_DELETEUSER
(
@IdUsuario int,
@Error bit output,
@Mensaje VARCHAR(500) output/*DEVUELVEN RESULTADOS DEL SP*/

)
AS 
BEGIN
SET @Error=0
SET @Mensaje=''
DECLARE @Pasavalidaciones bit =1

/*PARA VALIDAR SI UN USUARIO RELACIONADO A UNA COMPRA EXISTE, QUE NO SE ELIMINE*/
IF EXISTS (SELECT * FROM Compra c
INNER JOIN  Usuario u on u.IdUsuario = c.IdUsuario
WHERE u.IdUsuario = @IdUsuario

)

BEGIN 

SET @Pasavalidaciones = 0
SET @Error=0
SET @Mensaje= @Mensaje + 'No se puede eliminar un usuario relacionado a una Compra\n'


END


/*PARA VALIDAR SI UN USUARIO RELACIONADO A UNA VENTA EXISTE, QUE NO SE ELIMINE*/

IF EXISTS (SELECT * FROM Venta v
INNER JOIN  Usuario u on u.IdUsuario = v.IdUsuario
WHERE u.IdUsuario = @IdUsuario

)

BEGIN 

SET @Pasavalidaciones = 0
SET @Error=0
SET @Mensaje= @Mensaje + 'No se puede eliminar un usuario relacionado a una Venta\n'


END



IF (@Pasavalidaciones = 1 )

BEGIN 
DELETE FROM Usuario WHERE IdUsuario= @IdUsuario
set @Error = 1
END 


END

DBCC CHECKIDENT ('Usuario', NORESEED);
DBCC CHECKIDENT ('Usuario', RESEED, 2);


/*VALIDANDO CORREO PARA QUE SEA NO NULO YA QUE AIN CORREO NO HAY LOGIN*/

ALTER TABLE Usuario
ALTER COLUMN Correo VARCHAR(100) NOT NULL;



/*PRIMERO HAY QUE QUITAR LA RESTRICCION */
ALTER TABLE Usuario
DROP CONSTRAINT UQ_Correo_Usuario;

/*AGREGANDO OTRA VEZ LA RESTRICCION*/
ALTER TABLE Usuario
ADD CONSTRAINT UQ_Correo_Usuario UNIQUE (Correo);


/* MEJORAS Y CORRECCIONES DE ERRORES*/
SELECT IdUsuario, DNI, Nombre1, IdRol, Estado, FechaCreacion 
FROM Usuario 
WHERE IdRol IS NULL OR Estado IS NULL OR FechaCreacion IS NULL;

ALTER TABLE Usuario ALTER COLUMN IdRol INT NOT NULL;
ALTER TABLE Usuario ALTER COLUMN Estado BIT NOT NULL;




sp_helptext 'SP_EDITUSER'

SELECT name FROM sys.triggers WHERE parent_id = OBJECT_ID('Usuario');



/*---------------------PROCEDIMIENTO PARA GESTIONAR CATEGORIAS DE PRODUCTOS (CRUD)----------------*/


go
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
        INSERT INTO Categoria (Nombre,Descripcion,Estado) VALUES (@Nombre,@Descripcion,@Estado); /*SEA AGREGO ESTADO NO ESTABA EN EL PROCESO*/
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
 @Estado BIT, -- Nuevo campo para estado (activo/inactivo)
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


/* ELIMINAR CATEGORIA */
CREATE PROCEDURE SP_DeleteCategory
(
 @IdCategoria INT,
 @Resultado INT OUTPUT,
 @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Resultado = 1;

    IF NOT EXISTS (
        SELECT 1
        FROM Categoria c
        INNER JOIN Producto p ON p.IdCategoria = c.IdCategoria
        WHERE c.IdCategoria = @IdCategoria
    )
    BEGIN
        DELETE FROM Categoria WHERE IdCategoria = @IdCategoria;
        SET @Mensaje = 'Categoría eliminada correctamente.';
    END
    ELSE
    BEGIN
        SET @Resultado = 0;
        SET @Mensaje = 'La categoría está relacionada a un producto. No se puede eliminar.';
    END
END
GO



SELECT Nombre,Descripcion,Estado FROM Categoria


INSERT INTO Categoria(Nombre,Descripcion,Estado) VALUES ('Enlatados', 'Productos enlatados como Sardinas, Atun,etc',1)
INSERT INTO Categoria(Nombre,Descripcion,Estado) VALUES ('Granos Basicos', 'Arroz, Frijoles, Azucar,etc',1)





SELECT * FROM Producto
INSERT INTO Producto(Nombre,Descripcion,IdCategoria,Stock,PrecioCompra,PrecioVenta,Estado) VALUES ('Arroz','Arroz Faisan 1lb',2,12,26.2,28.2,1)
/*=====================================================================================================================*/

EXEC sp_help 'Producto';
ALTER TABLE Producto
DROP COLUMN Codigo;

ALTER TABLE Producto
DROP CONSTRAINT UQ_CodigoProducto;

ALTER TABLE Producto
ADD Codigo AS ('P' + RIGHT('0000' + CAST(IdProducto AS VARCHAR(4)), 4)) PERSISTED;

-- CAMBIO: Columna 'Codigo' convertida en columna calculada/autogenerada
-- Motivo: Evitar que el código de producto se ingrese manualmente,
--         generándolo automáticamente a partir del Id (correlativo).
-- 
-- Pasos realizados:
--   1. Se eliminó la restricción UNIQUE 'UQ_CodigoProducto' que dependía de Codigo
--   2. Se eliminó la columna 'Codigo' (manual)
--   3. Se volvió a crear 'Codigo' como columna calculada PERSISTED:
--      Formato: 'P' + Id con padding de 4 dígitos (ej: P0001, P0002...)
--   4. La columna ya no requiere UNIQUE explícito porque el Id 
--      (IDENTITY) garantiza unicidad por diseño
-- 
-- Resultado: Codigo se genera automáticamente al insertar un producto,
-- el usuario ya no debe llenarlo manualmente en el formulario C#.

/*===================================================================================================*/

/*-----------------PROCEDIMIENTOS PARA PRODUCTOS -----------------------------*/


/*================PROCEDIMIENTO PARA REGISTRAR UN PRODUCTO==================*/
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
         INSERT INTO Producto ( Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado)
        VALUES ( @Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioCompra, @PrecioVenta, @Estado)

        SET @IdResult = SCOPE_IDENTITY()
        SET @Mensaje = 'Producto registrado correctamente'
    END
    ELSE
    BEGIN
        SET @Mensaje = 'Ya existe un producto con ese nombre'
    END
END

GO 

/*=======================PROCEDIMIENT PARA ACTUALZIAR UN PRODUCTO=========================*/
CREATE PROCEDURE SP_UPDATEPRODUCT
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

    -- Si paso todas las validaciones, actualiza
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

/*=========================PROCEDIMIENTO PARA ELIMINAR UN PRODUCTO=====================*/


CREATE PROCEDURE SP_DELETEPRODUCT
(
  @IdProducto INT,
  @Respuesta BIT OUTPUT,
  @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0
    SET @Mensaje = ''
    DECLARE @PasoReglas BIT = 1

    -- Verifica que el producto exista
    IF NOT EXISTS (SELECT * FROM Producto WHERE IdProducto = @IdProducto)
    BEGIN
        SET @Mensaje = 'El producto no existe'
        RETURN
    END

    -- Valida que no esté relacionado a una COMPRA
    IF EXISTS (
        SELECT * FROM DetalleCompra dc
        INNER JOIN PRODUCTO p ON p.IdProducto = dc.IdProducto
        WHERE p.IdProducto = @IdProducto
    )
    BEGIN
        SET @PasoReglas = 0
        SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA' + CHAR(13)
    END

    -- Valida que no esté relacionado a una VENTA
    IF EXISTS (
        SELECT * FROM DetalleVenta dv
        INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
        WHERE p.IdProducto = @IdProducto
    )
    BEGIN
        SET @PasoReglas = 0
        SET @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA' + CHAR(13)
    END

    -- Si no hay relaciones, elimina
    IF (@PasoReglas = 1)
    BEGIN
        DELETE FROM PRODUCTO WHERE IdProducto = @IdProducto
        SET @Respuesta = 1
        SET @Mensaje = 'Producto eliminado correctamente'
    END
END


SELECT IdProducto,Codigo,p.Nombre,p.Descripcion,c.Idcategoria,c.Nombre[Categoria],Stock,
PrecioCompra,PrecioVenta,p.Estado FROM Producto p
INNER JOIN Categoria c on c.IdCategoria = p.IdCategoria
