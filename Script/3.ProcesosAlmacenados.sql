use ElQuiosco
go

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
  @Distrito varchar(50), 
  @Activo bit
AS
BEGIN
    Declare @ID_Distrito as int, @ID_Canton AS int, @ID_Provincia as int --para declarar variable Global

    set @ID_Distrito = (select ID_Distrito from Distrito where @Distrito = DESCRIPCION)
    set @ID_Canton = (select C.ID_Canton from CANTON C
                        join DISTRITO D on D.ID_CANTON = C.ID_Canton
                        where D.ID_Distrito = @ID_Distrito)
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
        exec sp_RegistrarAuditoria 'Actualizar un Empleado', @Fecha_Registro
    END
    ELSE
    BEGIN
        INSERT INTO Empleados (Identificacion, Nombre, Telefono, Correo, Salario, Direccion, Estado_Civil, 
                                Fecha_Nacimiento, Genero, Fecha_Registro, ID_Provincia, ID_Canton, ID_Distrito, Activo)
        VALUES (@Identificacion, @Nombre, @Telefono, @Correo, @Salario, @Direccion, @Estado_Civil, @Fecha_Nacimiento, 
            @Genero, @Fecha_Registro, @ID_Provincia, @ID_Canton, @ID_Distrito, 1);
        exec sp_RegistrarAuditoria 'Agregar un Empleado', @Fecha_Registro
    END
END
GO

  --***************************************Para registrar mebresias (se crean "solas" al agregar usuarios)*********************
CREATE PROCEDURE sp_Membresia
  @ID_Cliente int,
  @ID_T_Membresia int ,
  @Frecuencia_Pago int, --en dias cada cuanto paga
  @Fecha_Contrato Date
AS
BEGIN
  INSERT INTO Membresias (ID_Cliente, ID_T_Membresia, Fecha_Contrato, Total_Puntos, Frecuencia_Pago, Activo)
  VALUES (@ID_Cliente, @ID_T_Membresia, @Fecha_Contrato, 0, @Frecuencia_Pago,  1);
END;
GO

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
    @Distrito Varchar(50),
    @Activo bit
AS
BEGIN
    Declare @ID_Distrito as int, @ID_Canton AS int, @ID_Provincia AS int, @ultimoID as int, @t_membresia as int --para declarar variable Global

    set @ID_Distrito = (select ID_Distrito from Distrito where @Distrito = DESCRIPCION)
    set @ID_Canton = (select C.ID_Canton from CANTON C
                        join DISTRITO D on D.ID_CANTON = C.ID_Canton
                        where D.ID_Distrito = @ID_Distrito)
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
        
        --IMPORTANTE
            --Cada vez que se agrega un cliente se le crea automaticamente una membresia con el trigger trg_CrearMembresiaInicial
    END
END
GO

  --***************************************Para actualizar membresia de un cliente*********************
CREATE PROCEDURE sp_ActualizarMembresia
  @Identificacion varchar(100),
  @ID_T_Membresia int, --el nuevo tipo de membresia
  @Frecuencia_Pago int, --en dias cada cuanto paga
  @Fecha_Contrato date
AS
BEGIN
    Declare @ID_Membresia int

    SELECT @ID_Membresia = M.ID_Membresia FROM Membresias M 
                INNER JOIN Clientes C ON M.ID_Cliente = C.ID_Cliente
                WHERE C.Identificacion = @Identificacion

    IF EXISTS ( SELECT 1 FROM Membresias WHERE Activo = 0 and @ID_Membresia = ID_Membresia)
    BEGIN
        RAISERROR('No se puede actualizar la membresía si no esta activa', 16, 1);
        RETURN;
    END
    
    update Membresias
    set ID_T_Membresia = @ID_T_Membresia, Frecuencia_Pago = @Frecuencia_Pago, Fecha_Contrato = @Fecha_Contrato
    where ID_Membresia = @ID_Membresia
END;
GO

  --***************************************Para actualizar pagos de membresias*********************
Create PROCEDURE sp_PagoMembresia
  @Identificacion varchar(100),
  @Descripcion varchar(200),
  @Fecha_Ultimo_Pago date
AS
BEGIN
    declare @ID_membresia as int

    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE Identificacion = @Identificacion)
    Begin
        RAISERROR('No se encontro ninguna membresia para esa identificacion', 16, 1);
        return;
    EnD

    set @ID_membresia = (select M.ID_Membresia from Clientes C 
                        join Membresias M  on M.ID_Cliente = C.ID_Cliente 
                        where C.Identificacion = @Identificacion)
    if Exists (select 1 from Pago_Membresias where @ID_membresia = ID_Membresia)
    begin
        update Pago_Membresias
        set Descripcion = @Descripcion, Fecha_Ultimo_Pago = @Fecha_Ultimo_Pago
        Where @ID_membresia = ID_Membresia
    end
    else
    begin
        insert into Pago_Membresias values (@ID_membresia, @Descripcion, @Fecha_Ultimo_Pago)
    end
END;
GO

  --***************************************Para agregar y modificar Proveedores*********************
CREATE PROCEDURE sp_Proveedor
    @Cedula_Proveedor VARCHAR(100),
    @Nombre_Proveedor VARCHAR(100),
    @Correo VARCHAR(100),
    @Telefono VARCHAR(20),
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
Create PROCEDURE sp_CompraProveedor
  @Cedula_Proveedor varchar(100),
  @Codigo_Producto varchar(100),
  @Descripcion varchar(200) null,
  @Cant_Comprada int,
  @PrecioProveedorUd decimal,
  @Fecha_Compra date,
  @Activo bit
AS
BEGIN
    Declare @ID_Proveedor int, @ID_Producto int, @PrecioUnitario decimal

    select @ID_Proveedor = ID_Proveedor from Proveedores where @Cedula_Proveedor = Cedula_Proveedor
    select @ID_Producto = ID_Producto, @PrecioUnitario = PrecioProveedor from Productos where @Codigo_Producto = Codigo_Producto

    if @ID_Proveedor is null
    begin
        RAISERROR('El proveedor no existe en DB', 16, 1);
        RETURN;
    end
    
    if @ID_Producto is null
    begin
        RAISERROR('El producto no existe en DB', 16, 1);
        RETURN;
    end

    --Insertar compra
    INSERT INTO CompraProveedores(ID_Proveedor , ID_Producto, Descripcion, Cant_Comprada, Total, Fecha_Compra, Activo)
    VALUES (@ID_Proveedor, @ID_Producto, @Descripcion, @Cant_Comprada, (@PrecioProveedorUd * @Cant_Comprada), @Fecha_Compra, @Activo)
    
    --Actualizar stock
    UPDATE Productos
    SET Stock = Stock + @Cant_Comprada, PrecioProveedor = @PrecioProveedorUd
    WHERE ID_Producto = @ID_Producto;
END
GO

  --***************************************Para registrar una venta*********************
CREATE PROCEDURE sp_Venta
  @Identificacion varchar(100),
  @Cantidad INT,
  @Puntos_Usados int,
  @Fecha_Venta DATE,
  @ID_Producto INT
AS
BEGIN
    DECLARE @Precio DECIMAL, @StockActual INT, @Total DECIMAL, @ID_Venta INT, @Valor_Puntos decimal, @CompraxPunto decimal, @ID_Cliente int;

    --Para recuperar info extra
    select @ID_Cliente = ID_Cliente from Clientes
    where Identificacion = @Identificacion and Activo = 1
    
    SELECT @Valor_Puntos = Valor_Puntos, @CompraxPunto = CompraxPunto from Tipo_Membresias TM
    join Membresias M on M.ID_T_Membresia = TM.ID_T_Membresia
    where @ID_Cliente = M.ID_Cliente

    --Validar que cliente exista
    if @ID_Cliente is null
    begin
        RAISERROR('El cliente no existe en DB', 16, 1);
        RETURN;
    end

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
    SET @Total = ((@Precio * @Cantidad) - (@Puntos_Usados * @Valor_Puntos));
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

  --***************************************Para registrar auditorias (historial)*********************
Create PROCEDURE sp_RegistrarAuditoria
  @Accion VARCHAR(500),
  @Fecha DATETIME
AS
BEGIN
  INSERT INTO AuditoriaGeneral (Accion, Fecha)
  VALUES (@Accion, @Fecha);
END;
GO

  --***************************************Procedimientos extras************//////////////////////////////*********
--***************************************Actualizar contraseña de usuarios*********************
CREATE PROCEDURE sp_ActualizarUsuarioContrasena
  @ID_Usuario INT,
  @NuevaContraseña VARCHAR(100)
AS
BEGIN
  UPDATE Usuarios
  SET Contraseña = @NuevaContraseña
  WHERE ID_Usuario = @ID_Usuario;
END;
GO

--***************************************Para eliminar o desactivar cleintes, empleado, proveedores y productos*********************
CREATE PROCEDURE sp_EliminarDesactivarRegistro --################### NO SE USA PERO LO DEJO
    @Tabla INT,              -- índice de la tabla (0=Clientes, 1=Empleados, 2=Proveedores, 3=Productos)
    @Identificador NVARCHAR(100),
    @Eliminar BIT
AS
BEGIN

    -- Clientes
    IF @Tabla = 0
    BEGIN
        IF @Eliminar = 1
            DELETE FROM Clientes WHERE Identificacion = @Identificador;
        ELSE
            UPDATE Clientes SET Activo = 0 WHERE Identificacion = @Identificador;
    END

    -- Empleados
    ELSE IF @Tabla = 1
    BEGIN
        IF @Eliminar = 1
            DELETE FROM Empleados WHERE Identificacion = @Identificador;
        ELSE
            UPDATE Empleados SET Activo = 0 WHERE Identificacion = @Identificador;
    END

    -- Proveedores
    ELSE IF @Tabla = 2
    BEGIN
        IF @Eliminar = 1
            DELETE FROM Proveedores WHERE Cedula_Proveedor = @Identificador;
        ELSE
            UPDATE Proveedores SET Activo = 0 WHERE Cedula_Proveedor = @Identificador;
    END

    -- Productos
    ELSE IF @Tabla = 3
    BEGIN
        IF @Eliminar = 1
            DELETE FROM Productos WHERE Codigo_Producto = @Identificador;
        ELSE
            UPDATE Productos SET Activo = 0 WHERE Codigo_Producto = @Identificador;
    END
END
GO


  --***************************************Procedimientos para vizualizar datos************//////////////////////////////*********

--***************************************Buscar por medio de un identificador*********************
CREATE PROCEDURE sp_BuscarPorIdentificador
  @Identificador varchar(100),
  @Tabla varchar(100)
AS
BEGIN
    if @Tabla = 'Cliente' --Buscar cliente por identificacion
    Begin
        Select Identificacion, Nombre, Direccion, Estado_Civil, Telefono, Fecha_Nacimiento, Correo, Genero, 
                Fecha_Registro, P.DESCRIPCION as Provincia, CT.DESCRIPCION as Cantón, D.DESCRIPCION as Distrito, C.Activo from Clientes C
        join PROVINCIAS P on P.ID_Provincia = C.ID_Provincia
        join CANTON CT on CT.ID_Canton = C.ID_Canton
        join DISTRITO D on D.ID_Distrito = C.ID_Distrito
        where @Identificador = Identificacion
    end;

    if @Tabla = 'Empleado' --Buscar empleado por identificacion
    Begin
        Select * from Empleados
        where @Identificador = Identificacion
    end;

    if @Tabla = 'Proveedor' --Buscar por cedula del proveedor
    Begin
        Select * from Proveedores
        where @Identificador = Cedula_Proveedor
    end;

    if @Tabla = 'Producto' --Buscar por codigo del producto
    Begin
        Select * from Productos
        where @Identificador = Codigo_Producto
    end;

    if @Tabla = 'ComprasProveedor' --Buscar por cedula proveedor todas las compras relacionadas
    Begin
        Select * from vw_CompraxProveedores
        where @Identificador = Cedula_Proveedor
    end;

    if @Tabla = 'GanaciaProducto' --Buscar por codigo de producto el margen de gancia
    Begin
        Select * from vw_ProductosConMargen
        where @Identificador = Codigo_Producto
    end;

    if @Tabla = 'VentasCliente' --Ver Historial de ventas para un cliente especifico
    Begin
        Select * from vw_ClientesxCompras
        where @Identificador = Identificacion
    end;

    if @Tabla = 'ClientePagoMembresia' --Ver cliente especifico y su ultimo pago de membresía
    Begin
        Select * from vw_ClientesxPagoMembresia
        where @Identificador = Identificacion
    end;

end;
GO

--***************************************Buscar por medio de un identificador*********************
create procedure sp_MargenGananciaProductoEspecifico
    @CodigoProducto varchar(100)
as
begin
    SELECT P.ID_Producto, Codigo_Producto, NombreProducto, Categoria,
			PrecioProveedor, Precio,(Precio - PrecioProveedor) AS Ganancia, Stock, P.Activo
	FROM Productos P
    where @CodigoProducto = P.Codigo_Producto
end
go