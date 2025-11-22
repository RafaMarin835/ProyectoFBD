Use ElQuiosco

--Tipo membresias
INSERT INTO Tipo_Membresias (Descripcion, Costo_Mensual, CompraxPunto, Valor_Puntos, Activo) VALUES
('Miembro', 0, 1000, 1, 1),
('Basica', 5000, 500, 5, 1),
('Premium', 10000, 300, 7, 1),
('VIP', 15000, 100, 10, 1);

-- CLIENTES
exec sp_Cliente '111111111','Rafael Marin', 'Cartago', 'Soltero', '11111111', '2000-01-01', 'rm@example.com', 'Maculino', '2025-11-20', 133, 1
exec sp_Cliente '112345678','Ana Gómez', 'Av. Central 123', 'Soltera', '8888-0001', '1990-05-12', 'ana@example.com', 'Femenino', '2025-11-20', 10, 1
exec sp_Cliente '223456789','Luis Pérez', 'Calle 5, Escazú', 'Casado', '8888-0002', '1985-03-22', 'luis@example.com', 'Masculino', '2025-11-20', 4, 1
exec sp_Cliente '334567890','María Rodríguez', 'Barrio El Molino', 'Soltera', '8888-0003', '1992-07-15', 'maria@example.com', 'Femenino', '2025-11-20', 11, 1
exec sp_Cliente '445678901','Carlos Jiménez', 'San Pedro', 'Casado', '8888-0004', '1980-11-30', 'carlos@example.com', 'Masculino', '2025-11-20', 12, 1
exec sp_Cliente '556789012','Laura Vargas', 'Heredia Centro', 'Soltera', '8888-0005', '1995-09-10', 'laura@example.com', 'Femenino', '2025-11-20', 13, 1
exec sp_Cliente '667890123','Pedro Sánchez', 'Liberia', 'Casado', '8888-0006', '1988-01-05', 'pedro@example.com', 'Masculino', '2025-11-20',  15, 1
exec sp_Cliente '778901234','Sofía Morales', 'Nicoya', 'Soltera', '8888-0007', '1993-04-18', 'sofia@example.com', 'Femenino', '2025-11-20',  16, 1
exec sp_Cliente '189012345','Andrés Castro', 'Barranca', 'Casado', '8888-0008', '1987-06-25', 'andres@example.com', 'Masculino', '2025-11-20',  17, 1
exec sp_Cliente '290123456','Daniela Rojas', 'Guápiles', 'Soltera', '8888-0009', '1991-12-01', 'daniela@example.com', 'Femenino', '2025-11-20',  20, 1
exec sp_Cliente '401234567','Jorge Salas', 'Desamparados', 'Casado', '8888-0010', '1983-08-14', 'jorge@example.com', 'Masculino', '2025-11-20',  3, 1
exec sp_Cliente '311223344','Natalia Ruiz', 'San Rafael', 'Soltera', '8888-0011', '1994-02-20', 'natalia@example.com', 'Femenino', '2025-11-20',  13, 1
exec sp_Cliente '222334455','Esteban Mora', 'San Antonio', 'Casado', '8888-0012', '1986-07-07', 'esteban@example.com', 'Masculino', '2025-11-20',  5, 1
exec sp_Cliente '133445566','Gabriela Soto', 'San Juan', 'Soltera', '8888-0013', '1997-03-30', 'gabriela@example.com', 'Femenino', '2025-11-20',  8, 1
exec sp_Cliente '744556677','Ricardo León', 'San Isidro', 'Casado', '8888-0014', '1982-10-10', 'ricardo@example.com', 'Masculino', '2025-11-20',  9, 1
exec sp_Cliente '655667788','Vanessa Chaves', 'Occidental', 'Soltera', '8888-0015', '1996-06-06', 'vanessa@example.com', 'Femenino', '2025-11-20',  10, 1
exec sp_Cliente '566778899','Tomás Araya', 'Oriental', 'Casado', '8888-0016', '1989-09-09', 'tomas@example.com', 'Masculino', '2025-11-20',  11, 1
exec sp_Cliente '477889900','Isabel Pineda', 'Santiago', 'Soltera', '8888-0017', '1990-01-01', 'isabel@example.com', 'Femenino', '2025-11-20',  12, 1
exec sp_Cliente '388990011','Felipe Navarro', 'San Antonio', 'Casado', '8888-0018', '1984-04-04', 'felipe@example.com', 'Masculino', '2025-11-20',  14, 1
exec sp_Cliente '299001122','Camila Ureña', 'Limón Centro', 'Soltera', '8888-0019', '1993-05-05', 'camila@example.com', 'Femenino', '2025-11-20',  19, 1
exec sp_Cliente '110102233','Diego Méndez', 'Guápiles', 'Casado', '8888-0020', '1981-12-12', 'diego@example.com', 'Masculino', '2025-11-20',  20, 1
Go

--Actualizar algunas membresias
exec sp_ActualizarMembresia 1, 2, 15, '2025-11-20'
exec sp_ActualizarMembresia 2, 3, 15, '2025-11-20'
exec sp_ActualizarMembresia 3, 4, 15, '2025-11-20'
exec sp_ActualizarMembresia 4, 3, 15, '2025-11-20'

--Pago membresias
exec sp_PagoMembresia '111111111', 0, 'Pagado', '2025-10-01'
exec sp_PagoMembresia '112345678', 10000, 'Pendiente', '2025-10-22'
exec sp_PagoMembresia '223456789', 15000, 'Pagado','2025-11-15'
exec sp_PagoMembresia '334567890', 10000, 'Pagado', '2025-11-10'
exec sp_PagoMembresia '445678901', 5000, 'Retrasado', '2025-10-20'

--Empleados
exec sp_Empleado '117950957', 'Rafael Marin', '11111111', 'rm@example.com', 200000, 'Cartago oreamuno', 'Soltero',  '2000-01-01', 'Maculino', '2025-11-20', 133, 1
exec sp_Empleado '111111111', 'Pepe', '22222222', 'ty@example.com', 500000, 'asd', 'Soltero',  '1991-03-10', 'Maculino', '2025-11-20', 57, 1


--Proveedores
exec sp_Proveedor '111111111', 'Distribuidora El Sol', 'sol@proveedores.com', '2222-1111', 'San José', '2025-11-20', 1
exec sp_Proveedor '111111112', 'Alimentos Tico', 'tico@proveedores.com', '2222-2222', 'Cartago','2025-11-20', 1
exec sp_Proveedor '111111113', 'Bebidas del Valle', 'valle@proveedores.com', '2222-3333', 'Heredia', '2025-11-20', 1
exec sp_Proveedor '111111114', 'Lácteos del Norte', 'norte@proveedores.com', '2222-4444', 'Alajuela', '2025-11-20', 1
exec sp_Proveedor '111111115', 'Verduras Frescas', 'verduras@proveedores.com', '2222-5555', 'Limón', '2025-11-20', 1 
Go

--Productos
exec sp_Productos '0001', 'Galletas Choco', 'Galletas', 800, 750, 50, '2025-11-20', 1
exec sp_Productos '0002', 'Refresco Cola', 'Bebida', 900, 800, 100, '2025-11-20', 1
exec sp_Productos '0003', 'Arroz 1kg', 'Arroz', 1200, 200, 180, '2025-11-20', 1
exec sp_Productos '0004', 'Frijoles Negros', 'Frijoles', 1000, 750, 150, '2025-11-20', 1
exec sp_Productos '0005', 'Jugo Natural', 'Bebida', 1300, 1225, 80, '2025-11-20', 1
exec sp_Productos '0006', 'Agua embotellada', 'Bebida', 600, 550, 300, '2025-11-20', 1
exec sp_Productos '0007', 'Leche Entera', 'Lacteo', 950, 900, 120, '2025-11-20', 1
exec sp_Productos '0008', 'Queso Turrialba', 'Lacteo', 1800, 1600, 60, '2025-11-20', 1
exec sp_Productos '0009', 'Zanahoria', 'Verduras', 700, 689, 90, '2025-11-20', 1
exec sp_Productos '0010', 'Tomate', 'Fruta', 850, 750, 100, '2025-11-20', 1
Go

--Compra proveedores
exec sp_CompraProveedor 1, 1, 'Compra mensual de galletas', 100, 80000, '2025-10-01', 1
exec sp_CompraProveedor 1, 2, 'Refrescos para fin de semana', 150, 135000, '2025-10-05', 1
exec sp_CompraProveedor 2, 3, 'Arroz y frijoles', 200, 220000, '2025-10-03', 1
exec sp_CompraProveedor 3, 5, 'Jugo y agua', 180, 180000, '2025-10-04', 1
exec sp_CompraProveedor 4, 7, 'Lácteos variados', 120, 150000, '2025-10-06', 1
exec sp_CompraProveedor 5, 9, 'Verduras frescas', 90, 72000, '2025-10-07', 1
exec sp_CompraProveedor 2, 3, 'Reabastecimiento arroz', 100, 120000, '2025-10-10', 1
exec sp_CompraProveedor 3, 5, 'Jugo adicional', 50, 65000, '2025-10-12', 1
exec sp_CompraProveedor 4, 8, 'Queso fresco', 60, 108000, '2025-10-15', 1
exec sp_CompraProveedor 5, 10, 'zanahorias', 120, 96000, '2025-10-18', 1
Go

--Ventas
exec sp_Venta '111111111', 10, 0, '2025-11-01', 1
exec sp_Venta '111111111', 10, 0, '2025-11-01', 2
exec sp_Venta '223456789', 10, 0, '2025-11-01', 3
exec sp_Venta '111111111', 10, 0, '2025-11-01', 4
exec sp_Venta '445678901', 10, 0, '2025-11-01', 5
exec sp_Venta '111111111', 10, 0, '2025-11-01', 6
exec sp_Venta '111111111', 10, 0, '2025-11-01', 7