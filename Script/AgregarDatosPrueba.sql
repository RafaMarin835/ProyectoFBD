Use ElQuiosco

select * from PROVINCIAS
select * from CANTON
where ID_PROVINCIA = 2
select * from DISTRITO
where ID_CANTON = 27

-- CLIENTES

INSERT INTO Clientes (Nombre, Direccion, Estado_Civil, Telefono, Fecha_Nacimiento, Correo, Genero, Fecha_Registro, Identificacion, ID_Provincia, ID_Canton, ID_Distrito, Activo) VALUES
('Rafael Marin', 'Cartago', 'Soltero', '11111111', '2000-01-01', 'rm@example.com', 'Maculino', GETDATE(), '1-1111-1111', 2, 27, 133, 1),
('Ana Gómez', 'Av. Central 123', 'Soltera', '8888-0001', '1990-05-12', 'ana@example.com', 'Femenino', GETDATE(), '1-1234-5678', 3, 7, 10, 1),
('Luis Pérez', 'Calle 5, Escazú', 'Casado', '8888-0002', '1985-03-22', 'luis@example.com', 'Masculino', GETDATE(), '2-2345-6789', 1, 2, 4, 1),
('María Rodríguez', 'Barrio El Molino', 'Soltera', '8888-0003', '1992-07-15', 'maria@example.com', 'Femenino', GETDATE(), '3-3456-7890', 3, 7, 11, 1),
('Carlos Jiménez', 'San Pedro', 'Casado', '8888-0004', '1980-11-30', 'carlos@example.com', 'Masculino', GETDATE(), '4-4567-8901', 3, 8, 12, 1),
('Laura Vargas', 'Heredia Centro', 'Soltera', '8888-0005', '1995-09-10', 'laura@example.com', 'Femenino', GETDATE(), '5-5678-9012', 4, 9, 13, 1),
('Pedro Sánchez', 'Liberia', 'Casado', '8888-0006', '1988-01-05', 'pedro@example.com', 'Masculino', GETDATE(), '6-6789-0123', 5, 11, 15, 1),
('Sofía Morales', 'Nicoya', 'Soltera', '8888-0007', '1993-04-18', 'sofia@example.com', 'Femenino', GETDATE(), '7-7890-1234', 5, 12, 16, 1),
('Andrés Castro', 'Barranca', 'Casado', '8888-0008', '1987-06-25', 'andres@example.com', 'Masculino', GETDATE(), '8-8901-2345', 6, 13, 17, 1),
('Daniela Rojas', 'Guápiles', 'Soltera', '8888-0009', '1991-12-01', 'daniela@example.com', 'Femenino', GETDATE(), '9-9012-3456', 7, 16, 20, 1),
('Jorge Salas', 'Desamparados', 'Casado', '8888-0010', '1983-08-14', 'jorge@example.com', 'Masculino', GETDATE(), '10-0123-4567', 1, 3, 3, 1),
('Natalia Ruiz', 'San Rafael', 'Soltera', '8888-0011', '1994-02-20', 'natalia@example.com', 'Femenino', GETDATE(), '11-1122-3344', 4, 9, 13, 1),
('Esteban Mora', 'San Antonio', 'Casado', '8888-0012', '1986-07-07', 'esteban@example.com', 'Masculino', GETDATE(), '12-2233-4455', 1, 2, 5, 1),
('Gabriela Soto', 'San Juan', 'Soltera', '8888-0013', '1997-03-30', 'gabriela@example.com', 'Femenino', GETDATE(), '13-3344-5566', 2, 5, 8, 1),
('Ricardo León', 'San Isidro', 'Casado', '8888-0014', '1982-10-10', 'ricardo@example.com', 'Masculino', GETDATE(), '14-4455-6677', 2, 6, 9, 1),
('Vanessa Chaves', 'Occidental', 'Soltera', '8888-0015', '1996-06-06', 'vanessa@example.com', 'Femenino', GETDATE(), '15-5566-7788', 3, 7, 10, 1),
('Tomás Araya', 'Oriental', 'Casado', '8888-0016', '1989-09-09', 'tomas@example.com', 'Masculino', GETDATE(), '16-6677-8899', 3, 7, 11, 1),
('Isabel Pineda', 'Santiago', 'Soltera', '8888-0017', '1990-01-01', 'isabel@example.com', 'Femenino', GETDATE(), '17-7788-9900', 3, 8, 12, 1),
('Felipe Navarro', 'San Antonio', 'Casado', '8888-0018', '1984-04-04', 'felipe@example.com', 'Masculino', GETDATE(), '18-8899-0011', 4, 10, 14, 1),
('Camila Ureña', 'Limón Centro', 'Soltera', '8888-0019', '1993-05-05', 'camila@example.com', 'Femenino', GETDATE(), '19-9900-1122', 7, 15, 19, 1),
('Diego Méndez', 'Guápiles', 'Casado', '8888-0020', '1981-12-12', 'diego@example.com', 'Masculino', GETDATE(), '20-1010-2233', 7, 16, 20, 1);
Go

--Roles
INSERT INTO Roles (ID_Cliente, Descripcion) VALUES
(1, 'Administrador');
Go

--Proveedores
INSERT INTO Proveedores (Nombre_Proveedor, Correo, Telefono, Direccion, Activo) VALUES
('Distribuidora El Sol', 'sol@proveedores.com', '2222-1111', 'San José', 1),
('Alimentos Tico', 'tico@proveedores.com', '2222-2222', 'Cartago', 1),
('Bebidas del Valle', 'valle@proveedores.com', '2222-3333', 'Heredia', 1),
('Lácteos del Norte', 'norte@proveedores.com', '2222-4444', 'Alajuela', 1),
('Verduras Frescas', 'verduras@proveedores.com', '2222-5555', 'Limón', 1); 
Go

--Productos
INSERT INTO Productos (ID_Proveedor, NombreProducto, Descripcion, Precio, Stock, Activo) VALUES
(1, 'Galletas Choco', 'Galletas de chocolate', 800, 50, 1),
(1, 'Refresco Cola', 'Bebida gaseosa 600ml', 900, 100, 1),
(2, 'Arroz 1kg', 'Arroz blanco', 1200, 200, 1),
(2, 'Frijoles Negros', 'Frijoles en bolsa 900g', 1000, 150, 1),
(3, 'Jugo Natural', 'Jugo de naranja 1L', 1300, 80, 1),
(3, 'Agua embotellada', 'Botella 600ml', 600, 300, 1),
(4, 'Leche Entera', 'Leche 1L', 950, 120, 1),
(4, 'Queso Turrialba', 'Queso fresco 500g', 1800, 60, 1),
(5, 'Zanahoria', 'Zanahoria fresca 1kg', 700, 90, 1),
(5, 'Tomate', 'Tomate rojo 1kg', 850, 100, 1);
Go

--Ventas
INSERT INTO Ventas (ID_Cliente, Fecha_Venta, Total, Puntos_Usados) VALUES
(1, '2025-11-01', 1600, 10),
(2, '2025-11-02', 900, 0),
(3, '2025-11-03', 2400, 20),
(4, '2025-11-04', 2000, 15),
(5, '2025-11-05', 1300, 5),
(6, '2025-11-06', 2400, 30),
(7, '2025-11-07', 1800, 10),
(8, '2025-11-08', 1400, 0),
(9, '2025-11-09', 2100, 25),
(10, '2025-11-10', 1700, 10);
Go

--Detalle de ventas
INSERT INTO Detalle_Venta (ID_Venta, ID_Producto, Cantidad) VALUES
(1, 1, 2), (1, 2, 1),
(2, 2, 1),
(3, 3, 2), (3, 4, 1),
(4, 4, 2),
(5, 5, 1),
(6, 6, 4),
(7, 7, 2),
(8, 8, 1),
(9, 9, 3),
(10, 10, 2),
(3, 5, 1),
(4, 6, 2),
(5, 7, 1),
(6, 8, 1),
(7, 9, 2),
(8, 10, 1),
(9, 1, 3),
(10, 2, 2);
Go

--Compra proveedores
INSERT INTO CompraProveedores (ID_Proveedor, Descripcion, Cant_Comprada, Total, Fecha_Compra, Activo) VALUES
(1, 'Compra mensual de galletas', 100, 80000, '2025-10-01', 1),
(1, 'Refrescos para fin de semana', 150, 135000, '2025-10-05', 1),
(2, 'Arroz y frijoles', 200, 220000, '2025-10-03', 1),
(3, 'Jugo y agua', 180, 180000, '2025-10-04', 1),
(4, 'Lácteos variados', 120, 150000, '2025-10-06', 1),
(5, 'Verduras frescas', 90, 72000, '2025-10-07', 1),
(2, 'Reabastecimiento arroz', 100, 120000, '2025-10-10', 1),
(3, 'Jugo adicional', 50, 65000, '2025-10-12', 1),
(4, 'Queso fresco', 60, 108000, '2025-10-15', 1),
(5, 'Tomates y zanahorias', 120, 96000, '2025-10-18', 1);
Go

--Tipo membresias
INSERT INTO Tipo_Membresias (Descripcion, Costo_Mensual, CompraxPunto, Valor_Puntos, Activo) VALUES
('Básica', 2500, 100, 10, 1),
('Premium', 5000, 80, 15, 1),
('VIP', 7500, 50, 20, 1);

--Membresias
INSERT INTO Membresias (ID_Cliente, ID_T_Membresia, Total_Puntos, Activo) VALUES
(1, 2, 150, 1),
(2, 1, 80, 1),
(3, 3, 300, 1),
(4, 2, 120, 1),
(5, 1, 60, 1),
(6, 2, 100, 1),
(7, 3, 250, 1),
(8, 1, 40, 1),
(9, 2, 90, 1),
(10, 3, 200, 1);
Go

--Estado membresias
INSERT INTO Estado_Membresias (ID_Membresia, Fecha_Contrato, Descripcion, Fecha_Proximo_Pago, Fecha_Ultimo_Pago, Activo) VALUES
(1, '2025-10-01', 'Pagado', '2025-11-01', '2025-10-01', 1),
(2, '2025-10-05', 'Pendiente', '2025-11-05', '2025-10-05', 1),
(3, '2025-09-15', 'Pagado', '2025-10-15', '2025-09-15', 1),
(4, '2025-10-10', 'Pagado', '2025-11-10', '2025-10-10', 1),
(5, '2025-10-20', 'Retrasado', '2025-11-20', '2025-10-20', 1),
(6, '2025-11-01', 'Pagado', '2025-12-01', '2025-11-01', 1),
(7, '2025-11-05', 'Pagado', '2025-12-05', '2025-11-05', 1),
(8, '2025-11-07', 'Pendiente', '2025-12-07', '2025-11-07', 1),
(9, '2025-11-10', 'Pagado', '2025-12-10', '2025-11-10', 1),
(10, '2025-11-12', 'Pagado', '2025-12-12', '2025-11-12', 1);