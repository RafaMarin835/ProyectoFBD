Use ElQuiosco
Go

--Para clientes *********************************************************---------------------------------
	--Ver clientes y su membresía
	Create VIEW vw_ClientesxMembresia AS
	select C.Identificacion, C.Nombre, M.Fecha_Contrato, TM.Descripcion, C.Telefono, C.Correo, M.Total_Puntos, M.Activo as Activo_Membresia From Clientes C
	join Membresias M on C.ID_Cliente = M.ID_Cliente
	join Tipo_Membresias TM on M.ID_T_Membresia = TM.ID_T_Membresia
	go

	--Ver clientes y sus compras
	Create VIEW vw_ClientesxCompras AS
	select C.Identificacion, C.Nombre, V.Fecha_Venta, Total, Puntos_Usados, Cantidad, NombreProducto From Clientes C
	join Ventas V on C.ID_Cliente = V.ID_Cliente
	join Detalle_Venta DV on DV.ID_Venta = V.ID_Venta
	join Productos P on P.ID_Producto = DV.ID_Producto
	go

	--Ver clientes y su ultimo pago de membresía
	Create VIEW vw_ClientesxPagoMembresia AS
	select Identificacion, Nombre, M.Activo as EstadoMembresia, Frecuencia_Pago, Descripcion, Fecha_Ultimo_Pago from Clientes C
	join Membresias M on M.ID_Cliente = C.ID_Cliente
	join Pago_Membresias PM on PM.ID_Membresia = M.ID_Membresia
	go

	----Ver clientes con pagos de membresía atrasados
	Create VIEW vw_ClientesxPagoAtrasado AS
	select Identificacion, Nombre, M.Activo as EstadoMembresia, Frecuencia_Pago, Descripcion, Fecha_Ultimo_Pago from Clientes C
	join Membresias M on M.ID_Cliente = C.ID_Cliente
	join Pago_Membresias PM on PM.ID_Membresia = M.ID_Membresia
	where DATEDIFf(DAY, Fecha_Ultimo_Pago, GETDATE()) > Frecuencia_Pago
	go


--Para empleados *********************************************************---------------------------------
	--Ver todas las auditorias de los empleados 
	Create VIEW vw_EmpleadosAuditorias AS
	select Nombre, Correo, Telefono, AG.Accion, AG.Fecha, AG.Tabla, AG.ID_Registro from Empleados E
	join AuditoriaGeneral AG on AG.ID_Empleado = E.ID_Empleado
	go


--Para compra de proveedor *********************************************************---------------------------------
	--Ver todas las compras a los proveedores
	Create VIEW vw_CompraxProveedores AS
	select P.Cedula_Proveedor, Pd.Codigo_Producto, P.Nombre_Proveedor, Pd.NombreProducto, CP.Descripcion, CP.Cant_Comprada, CP.Total, CP.Fecha_Compra   from CompraProveedores CP
	join Proveedores P on CP.ID_Proveedor = P.ID_Proveedor
	join Productos Pd on Pd.ID_Producto = CP.ID_Producto
	go


--Para productos *********************************************************---------------------------------
	--Margen de ganancia para todos los productos
	Create VIEW vw_ProductosConMargen AS
	SELECT P.ID_Producto, Codigo_Producto, NombreProducto, Categoria,
			PrecioProveedor, Precio,(Precio - PrecioProveedor) AS Ganancia, Stock, P.Activo
	FROM Productos P
	go

	--Ver productos con stock bajo (menos de 10)
	CREATE VIEW vw_ProductosStockBajo AS
	SELECT ID_Producto, NombreProducto, Stock, Precio
	FROM Productos
	WHERE Stock < 10 AND Activo = 1;
	Go

	--Ver la ganacia total de cada producto
	CREATE VIEW vw_RentabilidadProducto AS
	SELECT 
	  P.ID_Producto,
	  P.NombreProducto,
	  SUM(DV.Cantidad) AS TotalVendidas,
	  SUM(DV.Cantidad * P.Precio) AS IngresoTotal,
	  SUM(DV.Cantidad * P.PrecioProveedor) AS CostoTotal,
	  SUM(DV.Cantidad * (P.Precio - P.PrecioProveedor)) AS Ganancia
	FROM Detalle_Venta DV
	JOIN Productos P ON DV.ID_Producto = P.ID_Producto
	GROUP BY P.ID_Producto, P.NombreProducto;


--Para ventas *********************************************************---------------------------------
	--Ver todos los registros de ventas
	CREATE VIEW vw_VentasClientesProducto AS
	SELECT C.Identificacion, C.Nombre, V.Puntos_Usados, V.Total, DV.Cantidad, P.Codigo_Producto, NombreProducto, Fecha_Venta FROM Ventas V
	join Detalle_Venta DV on DV.ID_Venta = V.ID_Venta
	JOIN Productos P ON DV.ID_Producto = P.ID_Producto
	Join Clientes C on C.ID_Cliente = V.ID_Cliente
	Go

	--Ver ventas con detalle del margen de ganacia
	CREATE VIEW vw_DetalleVentaConMargen AS
	SELECT DV.ID_Detalle, DV.ID_Venta, P.NombreProducto, DV.Cantidad, P.Precio, P.PrecioProveedor, 
			(P.Precio - P.PrecioProveedor) AS MargenUnitario,
			(DV.Cantidad * (P.Precio - P.PrecioProveedor)) AS MargenTotal
	FROM Detalle_Venta DV
	JOIN Productos P ON DV.ID_Producto = P.ID_Producto;
	Go

	--Ver resumen de ventas de clientes
	CREATE VIEW vw_ResumenVentasCliente AS
	SELECT C.Identificacion, C.Nombre, COUNT(V.ID_Venta) AS TotalVentas, SUM(V.Total) AS MontoTotal
	FROM Clientes C
	JOIN Ventas V ON C.ID_Cliente = V.ID_Cliente
	GROUP BY C.Identificacion, C.Nombre;

--Pantalla de pago de membresia *********************************************************---------------------------------
	--Ver todo el historial de pagos de membresía
	Create VIEW vw_PagoMembresiaDetalle AS
	select Identificacion, Nombre, Fecha_Ultimo_Pago, Descripcion, Frecuencia_Pago  from Pago_Membresias PM
	join Membresias M on M.ID_Membresia = PM.ID_Membresia
	join Clientes C on C.ID_Cliente = M.ID_Cliente
	go
	


