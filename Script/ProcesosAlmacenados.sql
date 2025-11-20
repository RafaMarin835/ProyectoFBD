use ElQuiosco

--***************************************Para agregar y modificar clientes*********************
CREATE PROCEDURE sp_Cliente
    @Identificacion VARCHAR(50),
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(200),
    @Estado_Civil VARCHAR(50),
    @Telefono VARCHAR(20),
    @Fecha_Nacimiento DATE,
    @Correo VARCHAR(100),
    @Genero VARCHAR(10),
    @Fecha_Registro DATE,
    @ID_Distrito INT,
    @Activo bit
AS
BEGIN
    Declare @ID_Canton AS Varchar(100) --para declarar variable Global
    set @ID_Canton = (select C.ID_Canton from CANTON C
                        join DISTRITO D on D.ID_CANTON = C.ID_Canton
                        where D.ID_Distrito = @ID_Distrito)
    Declare @ID_Provincia AS Varchar(100) --para declarar variable Global
    set @ID_Provincia = (select P.ID_Provincia from PROVINCIAS P
                        join CANTON C on P.ID_Provincia = C.ID_PROVINCIA
                        where C.ID_Canton = @ID_Canton)


    IF EXISTS (SELECT 1 FROM Clientes WHERE Identificacion = @Identificacion)
    BEGIN
        UPDATE Clientes
        SET Nombre = @Nombre, Direccion = @Direccion, Estado_Civil = @Estado_Civil,
            Telefono = @Telefono, Fecha_Nacimiento = @Fecha_Nacimiento, Correo = @Correo,
            Genero = @Genero, Fecha_Registro = @Fecha_Registro,
            ID_Provincia = @ID_Provincia, ID_Canton = @ID_Canton, ID_Distrito = @ID_Distrito, Activo = @Activo
        WHERE Identificacion = @Identificacion
    END
    ELSE
    BEGIN
        INSERT INTO Clientes(Identificacion, Nombre, Direccion, Estado_Civil, Telefono, Fecha_Nacimiento, Correo,
                                  Genero, Fecha_Registro, ID_Provincia, ID_Canton, ID_Distrito, Activo)
        VALUES (@Identificacion, @Nombre, @Direccion, @Estado_Civil, @Telefono, @Fecha_Nacimiento, @Correo,
                    @Genero, @Fecha_Registro, @ID_Provincia, @ID_Canton, @ID_Distrito, @Activo)
    END
END
GO

--***************************************Para agregar y modificar Empleados*********************
CREATE PROCEDURE sp_Empleado
  @Identificacion VARCHAR(100),
  @Nombre VARCHAR(50),
  @Telefono VARCHAR(100),
  @Correo VARCHAR(100),
  @Salario DECIMAL(10,2),
  @Direccion VARCHAR(100),
  @Estado_Civil VARCHAR(100),
  @Fecha_Nacimiento DATE,
  @Genero VARCHAR(100),
  @Fecha_Registro DATE,
  @ID_Distrito INT, 
  @Activo bit
AS
BEGIN
    Declare @ID_Canton AS Varchar(100) --para declarar variable Global
    set @ID_Canton = (select C.ID_Canton from CANTON C
                        join DISTRITO D on D.ID_CANTON = C.ID_Canton
                        where D.ID_Distrito = @ID_Distrito)
    Declare @ID_Provincia AS Varchar(100) --para declarar variable Global
    set @ID_Provincia = (select P.ID_Provincia from PROVINCIAS P
                        join CANTON C on P.ID_Provincia = C.ID_PROVINCIA
                        where C.ID_Canton = @ID_Canton)


    IF EXISTS (SELECT 1 FROM Empleados WHERE Identificacion = @Identificacion)
    BEGIN
        UPDATE Empleados
        SET Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Salario = @Salario, Direccion = @Direccion, Estado_Civil = @Estado_Civil,
             Fecha_Nacimiento = @Fecha_Nacimiento, 
            Genero = @Genero, Fecha_Registro = @Fecha_Registro,
            ID_Provincia = @ID_Provincia, ID_Canton = @ID_Canton, ID_Distrito = @ID_Distrito, Activo = @Activo
        WHERE Identificacion = @Identificacion
    END
    ELSE
    BEGIN
        INSERT INTO Empleados (Identificacion, Nombre, Telefono, Correo, Salario, Direccion, Estado_Civil, 
                                Fecha_Nacimiento, Genero, Fecha_Registro, ID_Provincia, ID_Canton, ID_Distrito, Activo)
        VALUES (@Identificacion, @Nombre, @Telefono, @Correo, @Salario, @Direccion, @Estado_Civil, @Fecha_Nacimiento, 
            @Genero, @Fecha_Registro, @ID_Provincia, @ID_Canton, @ID_Distrito, 1);
    END
END
GO

  --***************************************Para agregar y modificar Proveedores*********************
CREATE PROCEDURE sp_Proveedor
    @Cedula_Proveedor VARCHAR(100),
    @Nombre_Proveedor VARCHAR(100),
    @Telefono VARCHAR(20),
    @Correo VARCHAR(100),
    @Direccion VARCHAR(200),
    @Fecha_Registro DATE,
    @Activo bit
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Proveedores WHERE Cedula_Proveedor = @Cedula_Proveedor)
    BEGIN
        UPDATE Proveedores
        SET Nombre_Proveedor = @Nombre_Proveedor, Telefono = @Telefono, Correo = @Correo,
            Direccion = @Direccion, Fecha_Registro = @Fecha_Registro, Activo = @Activo
        WHERE Cedula_Proveedor = @Cedula_Proveedor
    END
    ELSE
    BEGIN
        INSERT INTO Proveedores(Cedula_Proveedor, Nombre_Proveedor, Telefono, Correo,
                                Direccion, Fecha_Registro, Activo)
        VALUES (@Cedula_Proveedor, @Nombre_Proveedor, @Telefono, @Correo, @Direccion, @Fecha_Registro, @Activo)
    END
END
GO

  --***************************************Para agregar y modificar Productos*********************
CREATE PROCEDURE sp_Productos
  @Codigo_Producto VARCHAR(100),
  @NombreProducto varchar(100),
  @Categoria varchar(100),
  @Precio decimal,
  @PrecioProveedor decimal,
  @Stock int,
  @Fecha_Registro DATE,
  @Activo bit
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Productos WHERE Codigo_Producto = @Codigo_Producto)
    BEGIN
        UPDATE Productos
        SET NombreProducto = @NombreProducto, Categoria = @Categoria, Precio = @Precio,
            Stock = @Stock, Fecha_Registro = @Fecha_Registro, Activo = @Activo
        WHERE Codigo_Producto = @Codigo_Producto
    END
    ELSE
    BEGIN
        INSERT INTO Productos(Codigo_Producto ,NombreProducto, Categoria, Precio, PrecioProveedor,
                            Stock, Fecha_Registro, Activo)
        VALUES (@Codigo_Producto, @NombreProducto, @Categoria, @Precio, @PrecioProveedor, @Stock, @Fecha_Registro, @Activo)
    END
END
GO

  --***************************************Para registrar una compra a proveedor*********************
CREATE PROCEDURE sp_CompraProveedor
  @ID_Proveedor int,
  @ID_Producto int,
  @Descripcion varchar(200) null,
  @Cant_Comprada int,
  @Total decimal,
  @Fecha_Compra date,
  @Activo bit
AS
BEGIN
    --Insertar compra
    INSERT INTO CompraProveedores(ID_C_Proveedor , ID_Producto, Descripcion, Cant_Comprada, Total, Fecha_Compra, Activo)
    VALUES (@ID_Proveedor, @ID_Producto, @Descripcion, @Cant_Comprada, @Total, @Fecha_Compra, @Activo)
    
    --Actualizar stock
    UPDATE Productos
    SET Stock = Stock + @Cant_Comprada
    WHERE ID_Producto = @ID_Producto;
END
GO

  --***************************************Para registrar una venta*********************
CREATE PROCEDURE sp_Venta
  @ID_Cliente INT,
  @Cantidad INT,
  @Puntos_Usados int,
  @Fecha_Venta DATE,
  @ID_Producto INT
AS
BEGIN
    DECLARE @Precio DECIMAL, @StockActual INT, @Total DECIMAL, @ID_Venta INT, @Valor_Puntos decimal, @CompraxPunto decimal;

    --Para recuperar info extra
    SELECT @Valor_Puntos = Valor_Puntos, @CompraxPunto = CompraxPunto from Tipo_Membresias TM
    join Membresias M on M.ID_T_Membresia = TM.ID_T_Membresia
    where @ID_Cliente = M.ID_Cliente

    -- Validar stock y totales
    SELECT @Precio = Precio, @StockActual = Stock
    FROM Productos
    WHERE ID_Producto = @ID_Producto AND Activo = 1;

    IF @StockActual IS NULL
    BEGIN
        RAISERROR('Producto no existe o está inactivo.', 16, 1);
        RETURN;
    END

    --Calcular total si se usa puntos se descuentan
    SET @Total = (@Precio * @Cantidad) - (@Puntos_Usados * @Valor_Puntos);
    IF @Total < 0
    BEGIN
        RAIserror('No puedes gastar mas puntos que el monto total', 16, 1);
        return;
    end

    --Insertar en Ventas
    INSERT INTO Ventas (ID_Cliente, Fecha_Venta, Puntos_Usados, Total)
    VALUES (@ID_Cliente, @Fecha_Venta, @Puntos_Usados, @Total);

    SET @ID_Venta = SCOPE_IDENTITY();

    --Insertar en Detalle_Venta
    INSERT INTO Detalle_Venta (ID_Venta, ID_Producto, Cantidad)
    VALUES (@ID_Venta, @ID_Producto, @Cantidad);

    --Actualizar stock
    UPDATE Productos
    SET Stock = Stock - @Cantidad
    WHERE ID_Producto = @ID_Producto;

    --Actualizar puntos de membresía (un trigger resta los puntos usados)
    UPDATE Membresias
    SET Total_Puntos = Total_Puntos + FLOOR(@Total / @CompraxPunto) -- Para obtener los puntos ganados en la compra actual
    WHERE ID_Cliente = @ID_Cliente AND Activo = 1;
END
GO

  --***************************************Para registrar mebresias*********************
CREATE PROCEDURE sp_Membresia
  @ID_Cliente int,
  @ID_T_Membresia int ,
  @Fecha_Contrato Date
AS
BEGIN
  INSERT INTO Membresias (ID_Cliente, ID_T_Membresia, Fecha_Contrato, Total_Puntos, Activo)
  VALUES (@ID_Cliente, @ID_T_Membresia, @Fecha_Contrato, 0, 1);
END;
GO

  --***************************************Para registrar pagos de membresias*********************
CREATE PROCEDURE sp_PagoMembresia
  @ID_Membresia INT,
  @Monto DECIMAL,
  @Descripcion varchar(200),
  @Frecuencia_Pago int,
  @Fecha_Ultimo_Pago date
AS
BEGIN
  INSERT INTO Pago_Membresias (ID_Membresia, Monto)
  VALUES (@ID_Membresia, @Monto);

  insert into Estado_Membresias (ID_Membresia, Descripcion, Frecuencia_Pago, Fecha_Ultimo_Pago)
  values (@ID_Membresia, @Descripcion, @Frecuencia_Pago, @Fecha_Ultimo_Pago)
END;
GO

  --***************************************Para registrar auditorias (historial)*********************
CREATE PROCEDURE sp_RegistrarAuditoria
  @Tabla VARCHAR(100),
  @ID_Registro INT,
  @Accion VARCHAR(200),
  @ID_Empleado INT,
  @Fecha DATE
AS
BEGIN
  INSERT INTO AuditoriaGeneral (Tabla, ID_Registro, Accion, ID_Empleado, Fecha)
  VALUES (@Tabla, @ID_Registro, @Accion, @ID_Empleado, @Fecha);
END;
GO

  --***************************************Procedimientos extras************//////////////////////////////*********
--***************************************Actualizar contraseña de usuarios*********************
CREATE PROCEDURE sp_UsuarioContrasena
  @ID_Usuario INT,
  @NuevaContraseña VARCHAR(100)
AS
BEGIN
  UPDATE Usuarios
  SET Contraseña = @NuevaContraseña
  WHERE ID_Usuario = @ID_Usuario;
END;
GO

--***************************************Se usauria para eliminar un cliente del todo y saltarse el trigger que no lo permite*********************
CREATE PROCEDURE sp_eliminarClienteForzado
  @ID_Cliente INT
AS
BEGIN
    -- apago trigger
    ALTER TABLE Clientes DISABLE TRIGGER trg_DesactivarCliente;
    DELETE FROM Clientes WHERE ID_Cliente = @ID_Cliente; --elimino
    -- enciendo de nuevo
    ALTER TABLE Clientes ENABLE TRIGGER trg_DesactivarCliente;
END;


--***************************************PDDDDDDDDDD*********************