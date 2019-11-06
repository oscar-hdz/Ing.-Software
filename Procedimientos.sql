USE DB_TIENDA
GO

--------------------------------------
ALTER PROCEDURE SPD_VENTA_CLIENTE
(
	@vnIDProducto INT,
	@vnIDCliente INT,
	@vnCantidad INT,
	@vbDeuda BIT,
	@vcResultado VARCHAR(100) OUTPUT
)
AS
	BEGIN
		IF @vnIDProducto NOT IN (SELECT NID_PRODUCTO FROM TBL_PRODUCTOS WHERE BHABILITADO = 1)
		BEGIN
			SET @vcResultado ='No existe el producto en el inventario...'
		END
		ELSE IF @vnIDCliente NOT IN (SELECT NID_CLIENTE FROM CAT_CLIENTES WHERE BHABILITADO = 1)
		BEGIN
			SET @vcResultado ='No existe el cliente, darlo de alta primero...'
		END
		ELSE IF (SELECT TOP 1 (BDEUDA) FROM TBL_VENTAS 
				 WHERE NID_CLIENTE = @vnIDCliente AND DATEDIFF(DAY, GETDATE(), DFECHA_ALTA) < 0
				 ORDER BY DFECHA_ALTA DESC) = 1
		BEGIN
			SET @vcResultado ='El cliente tiene una deuda pendiente'
		END
		ELSE 
			BEGIN
				BEGIN TRANSACTION
					INSERT INTO TBL_VENTAS
					VALUES(@vnIDProducto, @vnIDCliente, @vnCantidad, @vbDeuda, 1, GETDATE(), NULL)
					IF @@ERROR <> 0
						BEGIN
							SET @vcResultado = 'Hubo un error en el proceso de inserción de datos, intente más tarde...'
							ROLLBACK
						END
					ELSE
						BEGIN
							SET @vcResultado = 'La venta fue concretada con éxito!'
							COMMIT
						END
			END
	END
GO

DECLARE @RESULTADO VARCHAR(100)
EXEC .dbo.SPD_VENTA_CLIENTE 5, 2, 2, 1, @RESULTADO OUTPUT
SELECT @RESULTADO
SELECT * FROM TBL_VENTAS
GO

------------------------------------
ALTER PROCEDURE SPD_SALDAR_DEUDA
(
	@vnIDCliente INT,
	@vcResultado VARCHAR(100) OUTPUT
)
AS
	BEGIN
		IF @vnIDCliente NOT IN (SELECT NID_CLIENTE FROM CAT_CLIENTES WHERE BHABILITADO = 1)
			BEGIN
				SET @vcResultado ='No existe el cliente, darlo de alta primero...'
			END
		ELSE IF 1 NOT IN (SELECT BDEUDA FROM TBL_VENTAS WHERE NID_CLIENTE = @vnIDCliente AND BHABILITADO = 1)
			BEGIN
				SET @vcResultado = 'No hay deudas que saldar'
			END
		ELSE
			BEGIN
				BEGIN TRANSACTION
					UPDATE TBL_VENTAS
					SET BDEUDA = 0
					WHERE NID_CLIENTE = @vnIDCliente AND BDEUDA = 1
					IF @@ERROR <> 0
						BEGIN 
							SET @vcResultado = 'Ocurrió un error, intente de nuevo más tarde...'
							ROLLBACK
						END
					ELSE
						BEGIN
							SET @vcResultado = 'Deuda saldada'
							COMMIT
						END
			END
	END
GO

DECLARE @RESULT VARCHAR(100)
EXEC dbo.SPD_SALDAR_DEUDA 1, @RESULT OUTPUT
SELECT @RESULT
SELECT * FROM TBL_VENTAS
GO

---------------------------------------
ALTER PROCEDURE SPD_VER_DEUDA_CLIENTE
(
	@vnIDCliente int,
	@vcResultado VARCHAR (100) OUTPUT
)
AS
	BEGIN
		IF @vnIDCliente NOT IN (SELECT NID_CLIENTE FROM CAT_CLIENTES WHERE BHABILITADO = 1)
			BEGIN
				SET @vcResultado ='No existe el cliente, darlo de alta primero...'
			END
		ELSE IF 1 NOT IN (SELECT BDEUDA FROM TBL_VENTAS WHERE NID_CLIENTE = @vnIDCliente)
			BEGIN
				SET @vcResultado = 'El cliente no tiene ninguna deuda pendiente.'
			END
		ELSE
			BEGIN
				SELECT CPRODUCTO AS PRODUCTO, TV.NCANTIDAD AS CANTIDAD, CPRECIO_VENTA AS PRECIO, TV.DFECHA_ALTA AS FECHA FROM TBL_VENTAS TV
				INNER JOIN CAT_CLIENTES AS CC
				ON CC.NID_CLIENTE = TV.NID_CLIENTE
				INNER JOIN TBL_PRODUCTOS AS TP
				ON TP.NID_PRODUCTO = TV.NID_PRODUCTO
				WHERE CC.NID_CLIENTE = @vnIDCliente AND BDEUDA = 1
				SET @vcResultado = 'La deuda es: ' + (SELECT [Total a pagar] FROM VDEUDORES AS VD
													  INNER JOIN CAT_CLIENTES AS CC
													  ON CC.CTELEFONO = VD.CTELEFONO
													  WHERE NID_CLIENTE = @vnIDCliente)
			END
	END
GO

DECLARE @RESULTADO VARCHAR(100)
EXEC .dbo.SPD_VER_DEUDA_CLIENTE 2, @RESULTADO OUTPUT
SELECT @RESULTADO AS Pendiente
GO

---------------------------------
CREATE TYPE Lista_compra AS TABLE ( NID_PRODUCTO INT )
GO

-------------------------------
CREATE PROCEDURE SPD_VENTA
(
	@vnIDProducto INT,
	@vnCantidad INT,
	@vcResultado VARCHAR (100) OUTPUT
)
AS
	BEGIN
		IF @vnIDProducto NOT IN (SELECT NID_PRODUCTO FROM TBL_PRODUCTOS WHERE BHABILITADO = 1)
			BEGIN
				SET @vcResultado ='No existe el producto en el inventario...'
			END
		ELSE 
			BEGIN
				BEGIN TRANSACTION
					INSERT INTO TBL_VENTAS
					VALUES(@vnIDProducto, NULL, @vnCantidad, NULL, 1, GETDATE(), NULL)

					IF @@ERROR <> 0
						BEGIN
							SET @vcResultado = 'Ocurrió un error durante la inserción de los datos, intente de nuevo más tarde...'
							ROLLBACK
						END
					ELSE
						BEGIN
							SET @vcResultado = 'La venta fue concretada con éxito!'
							COMMIT 
						END
			END
	END
GO

DECLARE @RESULTADO VARCHAR(100)
EXEC .dbo.SPD_VENTA 6, 2, @RESULTADO OUTPUT
SELECT @RESULTADO
SELECT * FROM TBL_VENTAS
GO
--------------------------

ALTER PROCEDURE SPD_COMPRA_PRODUCTO
(
	@vnIDProducto INT,
	@vnCantidad INT,
	@vcResultado VARCHAR(100) OUTPUT
)
AS
	BEGIN
		IF @vnIDProducto NOT IN (SELECT NID_PRODUCTO FROM TBL_PRODUCTOS WHERE BHABILITADO = 1)
			BEGIN
				SET @vcResultado ='No existe el producto en el inventario...'
			END
		ELSE 
			BEGIN
				BEGIN TRANSACTION
					INSERT INTO TBL_COMPRAS 
					VALUES(@vnIDProducto, .dbo.FN_GET_PROVEEDOR(@vnIDProducto), @vnCantidad, 1, GETDATE(), NULL)
					IF @@ERROR <> 0
						BEGIN
							SET @vcResultado = 'Hubo un error en el proceso de inserción de datos, intente más tarde...'
							ROLLBACK
						END
					ELSE
						BEGIN
							UPDATE TBL_PRODUCTOS 
							SET NCANTIDAD += @vnCantidad
							WHERE NID_PRODUCTO = @vnIDProducto
							IF @@ERROR <> 0
								BEGIN
									SET @vcResultado = 'Hubo un error en el proceso de inserción de datos, intente más tarde...'
									ROLLBACK
								END
							ELSE
								BEGIN
									SET @vcResultado = 'La compra fue concretada con éxito!'
									COMMIT
								END
						END
			END
	END
GO

DECLARE @RESULTADO VARCHAR(100)
EXEC .dbo.SPD_COMPRA_PRODUCTO 1, 20, @RESULTADO OUTPUT
SELECT @RESULTADO AS RESULTADO
SELECT * FROM TBL_COMPRAS
SELECT * FROM TBL_PRODUCTOS
GO

INSERT INTO TBL_VENTAS
VALUES(1, NULL, 5, NULL, 1, CONVERT(DATE, '20 SEP 2019'), NULL)

SELECT CONVERT(DATE, '20 SEP 2019')

SELECT * FROM TBL_VENTAS

ALTER PROCEDURE dbo.SPD_NUEVO_CLIENTE
(
	@vcNombres VARCHAR(40),
	@vcApellidoP VARCHAR(20),
	@vcApellidoM VARCHAR(20),
	@vcTelefono VARCHAR(10),
	@vcEmail VARCHAR(35),
	@RESULTADO VARCHAR(50) OUTPUT
) 
AS
	BEGIN
		IF @vcApellidoM = ''
			BEGIN
				SET @vcApellidoM = NULL
			END
		IF @vcEmail = ''
			BEGIN
				SET @vcEmail = NULL
			END
		INSERT INTO CAT_CLIENTES
		VALUES(@vcNombres, @vcApellidoP, @vcApellidoM, @vcTelefono, @vcEmail, 1, GETDATE(), NULL)
		IF @@ERROR <> 0
			BEGIN
				SET @RESULTADO = 'Ocurrió un error en la inserción de datos'
			END
		ELSE
			BEGIN
				SET @RESULTADO = 'Se creó la cuenta de ' + @vcNombres + ' ' + @vcApellidoP
			END
	END
GO

DECLARE @RESULTADO VARCHAR(70)
EXEC dbo.SPD_NUEVO_CLIENTE 'Isauth', 'Cabrejos', 'Reyes', '1123456991', 'isauth@gmail.com', @RESULTADO OUTPUT
SELECT @RESULTADO AS RESULTADO
SELECT * FROM CAT_CLIENTES
GO

