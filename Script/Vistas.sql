Use ElQuiosco
Go

--////////////////////////////////////////////////////////////Vista para informacion dde prductos y proveedor con ganacia esperada por producto
CREATE VIEW vw_ProductosConMargen AS
SELECT P.ID_Producto, Codigo_Producto, NombreProducto, Categoria, PrecioProveedor, CP.ID_Proveedor,
	Precio,(Precio - PrecioProveedor) AS Ganancia, Stock, P.Activo
FROM Productos P
join CompraProveedores CP on CP.ID_Producto = P.ID_Producto
WHERE P.Activo = 1;
go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles
CREATE VIEW vw_ComprasDetalle AS
SELECT CP.ID_C_Proveedor, P.Nombre_Proveedor, PR.NombreProducto, CP.Cant_Comprada, CP.Total, CP.Fecha_Compra
FROM CompraProveedores CP
JOIN Proveedores P ON CP.ID_Proveedor = P.ID_Proveedor
JOIN Productos PR ON CP.ID_Producto = PR.ID_Producto;
go

--////////////////////////////////////////////////////////////Vista de ventas, con total y cliente
CREATE VIEW vw_VentasClientes AS
SELECT V.ID_Venta, C.Nombre, V.Fecha_Venta, V.Total, V.Puntos_Usados 
FROM Ventas V
JOIN Clientes C ON V.ID_Cliente = C.ID_Cliente;
go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles

go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles

go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles

go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles

go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles

go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles

go

--////////////////////////////////////////////////////////////Vista para compras a proveedor con detalles
