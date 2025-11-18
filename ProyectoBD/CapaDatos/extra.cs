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