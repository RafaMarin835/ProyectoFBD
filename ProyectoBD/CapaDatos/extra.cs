public void GuardarProveedor(ClaseProveedor proveedor)
{
    string ComandoSQL = @"
    IF EXISTS (SELECT 1 FROM Proveedores WHERE ID_Proveedor = @ID_Proveedor)
    BEGIN
        UPDATE Proveedores
        SET Nombre_Proveedor = @Nombre_Proveedor,
            Correo = @Correo,
            Telefono = @Telefono,
            Direccion = @Direccion,
            Activo = @Activo
        WHERE ID_Proveedor = @ID_Proveedor
    END
    ELSE
    BEGIN
        INSERT INTO Proveedores (Nombre_Proveedor, Correo, Telefono, Direccion, Activo)
        VALUES (@Nombre_Proveedor, @Correo, @Telefono, @Direccion, @Activo)
    END";

    ActualizarDB(ComandoSQL,
        new SqlParameter("@ID_Proveedor", proveedor.ID_Proveedor),
        new SqlParameter("@Nombre_Proveedor", proveedor.Nombre_Proveedor),
        new SqlParameter("@Correo", proveedor.Correo),
        new SqlParameter("@Telefono", proveedor.Telefono),
        new SqlParameter("@Direccion", proveedor.Direccion),
        new SqlParameter("@Activo", proveedor.Activo)
    );
}



public void GuardarProducto(ClaseProducto producto)
{
    string ComandoSQL = @"
    IF EXISTS (SELECT 1 FROM Productos WHERE ID_Producto = @ID_Producto)
    BEGIN
        UPDATE Productos
        SET NombreProducto = @NombreProducto,
            Descripcion = @Descripcion,
            Precio = @Precio,
            Stock = @Stock,
            Activo = @Activo
        WHERE ID_Producto = @ID_Producto
    END
    ELSE
    BEGIN
        INSERT INTO Productos (NombreProducto, Descripcion, Precio, Stock, Activo)
        VALUES (@NombreProducto, @Descripcion, @Precio, @Stock, @Activo)
    END";

    ActualizarDB(ComandoSQL,
        new SqlParameter("@ID_Producto", producto.ID_Producto),
        new SqlParameter("@NombreProducto", producto.NombreProducto),
        new SqlParameter("@Descripcion", producto.Descripcion),
        new SqlParameter("@Precio", producto.Precio),
        new SqlParameter("@Stock", producto.Stock),
        new SqlParameter("@Activo", producto.Activo)
    );
}