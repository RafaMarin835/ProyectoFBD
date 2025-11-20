CREATE TRIGGER trg_PrevenirDeleteProductoConStock --Para evitar que se eliminen productos que tengan stock
ON Productos
AFTER DELETE
AS
BEGIN
    -- Verifica si alguno de los productos eliminados tiene stock
    IF EXISTS (
        SELECT 1
        FROM DELETED
        WHERE Stock > 0
    )
    BEGIN
        -- Revertir la operación y lanzar error
        RAISERROR('No se puede eliminar un producto con stock disponible.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END
GO



---********************************Crear usuario automaticamente al agregar un Empleado
CREATE TRIGGER trg_AgregarUsuarioEmpleado
ON Empleados
AFTER INSERT
AS
BEGIN
    INSERT INTO Usuarios (ID_Empleado, UsuarioLogin, Contraseña, Activo)
    SELECT i.ID_Empleado, i.Identificacion, i.Identificacion, 1
    FROM inserted i;
END;
GO

---********************************Eliminar un usuario automaticamente al eliminar un empleado
CREATE TRIGGER trg_DeleteUsuarioEmpleado
ON Empleados
AFTER DELETE
AS
BEGIN
    DELETE FROM Usuarios
    WHERE ID_Empleado IN (SELECT ID_Empleado FROM deleted);
END;
GO

---********************************Eliminar una mebresia, pero solo si el ultimo pago no es mayor a 10 dias
CREATE TRIGGER trg_EliminarMembresia
ON Membresias
INSTEAD OF DELETE
AS
BEGIN
    -- Verificamos cada membresía que se intenta eliminar
    IF EXISTS ( SELECT 1 FROM deleted d 
                INNER JOIN Estado_Membresias e ON d.ID_Membresia = e.ID_Membresia
                WHERE DATEDIFF(DAY, e.Fecha_Ultimo_Pago, GETDATE()) > 10)
    BEGIN
        RAISERROR('No se puede eliminar la membresía: han pasado más de 10 días desde el último pago.', 16, 1);
        RETURN;
    END

    -- Si cumple la condición (< 10 días) entonces lo elimino
    DELETE FROM Membresias
    WHERE ID_Membresia IN (SELECT ID_Membresia FROM deleted);
END;
GO

---********************************Validar que no surja stock negativo de ventas
CREATE TRIGGER trg_ValidarStockVenta
ON Detalle_Venta
AFTER INSERT
AS
BEGIN
  IF EXISTS (SELECT 1 FROM Productos P
            JOIN inserted I ON P.ID_Producto = I.ID_Producto
            WHERE P.Stock < I.Cantidad
  )
  BEGIN
    RAISERROR('Stock insuficiente para realizar la venta.', 16, 1);
    ROLLBACK TRANSACTION;
  END
END;
GO

---********************************Reactivar membresia al realizar pago
CREATE TRIGGER trg_ActivarMembresiaConPago
ON Pago_Membresias
AFTER INSERT
AS
BEGIN
  UPDATE Membresias
  SET Activo = 1
  WHERE ID_Membresia IN (SELECT ID_Membresia FROM inserted);
END;
GO

---********************************Al eliminar un cliente solo se desactiva
CREATE TRIGGER trg_DesactivarCliente
ON Clientes
INSTEAD OF DELETE
AS
BEGIN
  UPDATE Clientes
  SET Activo = 0
  WHERE ID_Cliente IN (SELECT ID_Cliente FROM deleted);
END;
GO

---********************************Confirma que el cliente tenga los puntos esperados
CREATE TRIGGER trg_ValidarPuntosVenta
ON Ventas
AFTER INSERT
AS
BEGIN
  IF EXISTS ( SELECT 1 FROM inserted I 
            JOIN Membresias M ON I.ID_Cliente = M.ID_Cliente
           WHERE I.Puntos_Usados > M.Total_Puntos
  )
  BEGIN
    RAISERROR('El cliente no tiene suficientes puntos.', 16, 1);
    ROLLBACK TRANSACTION;
  END
  ELSE
  BEGIN
    UPDATE Membresias
    SET Total_Puntos = Total_Puntos - I.Puntos_Usados
    FROM Membresias M
    JOIN inserted I ON M.ID_Cliente = I.ID_Cliente;
  END
END;





