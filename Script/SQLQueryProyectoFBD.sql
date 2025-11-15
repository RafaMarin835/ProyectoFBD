Create database ElQuiosco
GO
Use ElQuiosco
Go

 CREATE TABLE PROVINCIAS (
  ID_Provincia INT PRIMARY KEY IDENTITY(1,1),
  DESCRIPCION VARCHAR(200) UNIQUE,
  ACTIVO BIT NOT NULL
);
Go
CREATE TABLE CANTON (
  ID_Canton INT PRIMARY KEY IDENTITY(1,1),
  DESCRIPCION VARCHAR(100),
  ACTIVO BIT,
  ID_PROVINCIA INT NOT NULL,
  FOREIGN KEY (ID_PROVINCIA) REFERENCES PROVINCIAS(ID_PROVINCIA)
);
Go
CREATE TABLE DISTRITO (
  ID_Distrito INT PRIMARY KEY IDENTITY(1,1),
  DESCRIPCION VARCHAR(100),
  ACTIVO BIT,
  ID_CANTON INT NOT NULL,
  FOREIGN KEY (ID_CANTON) REFERENCES CANTON(ID_CANTON)
);
Go

CREATE TABLE Clientes (
  ID_Cliente INT PRIMARY KEY IDENTITY(1,1),
  Nombre VARCHAR(100) NOT NULL,
  Direccion VARCHAR(100) NOT NULL,
  Estado_Civil VARCHAR(100) NOT NULL,
  Telefono VARCHAR(100) NOT NULL,
  Fecha_Nacimiento DATE NOT NULL,
  Correo VARCHAR(100) NOT NULL,
  Genero VARCHAR(100) NOT NULL,
  Fecha_Registro DATETIME NOT NULL,
  Identificacion VARCHAR(100) UNIQUE NOT NULL,
  ID_Provincia INT NOT NULL,
  ID_Canton INT NOT NULL,
  ID_Distrito INT NOT NULL,
  Activo Bit not null,  
  FOREIGN KEY (ID_Provincia) REFERENCES PROVINCIAS(ID_PROVINCIA),
  FOREIGN KEY (ID_Canton) REFERENCES CANTON(ID_CANTON),
  FOREIGN KEY (ID_Distrito) REFERENCES DISTRITO(ID_DISTRITO)
);
GO

CREATE TABLE Roles (
  ID_Rol INT PRIMARY KEY IDENTITY(1,1),
  ID_Cliente int not null,
  Descripcion varchar(100) not null,
  FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);
Go

CREATE TABLE Proveedores (
  ID_Proveedor INT PRIMARY KEY IDENTITY(1,1),
  Nombre_Proveedor varchar(150) not null,
  Correo VARCHAR(100) NOT NULL,
  Telefono VARCHAR(100) NOT NULL,
  Direccion VARCHAR(100) NOT NULL,
  Activo Bit not null
);
Go

CREATE TABLE Productos (
  ID_Producto INT PRIMARY KEY IDENTITY(1,1),
  NombreProducto varchar(100) not null,
  Descripcion varchar(100) not null,
  Precio decimal not null,
  Stock int not null,
  Activo bit not null
);
Go

CREATE TABLE CompraProveedores (
  ID_C_Proveedor INT PRIMARY KEY IDENTITY(1,1),
  ID_Proveedor int not null,
  ID_Producto int not null,
  Descripcion varchar(200),
  Cant_Comprada int not null,
  Total decimal not null,
  Fecha_Compra date not null,
  Activo bit not null,
  FOREIGN KEY (ID_Proveedor) REFERENCES Proveedores(ID_Proveedor),
  FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);
Go

CREATE TABLE Ventas (
  ID_Venta INT PRIMARY KEY IDENTITY(1,1),
  ID_Cliente INT NOT NULL,
  Fecha_Venta DATETIME NOT NULL,
  Total DECIMAL NOT NULL,
  Puntos_Usados int not null,
  FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);
Go

CREATE TABLE Detalle_Venta (
  ID_Detalle INT PRIMARY KEY IDENTITY(1,1),
  ID_Venta INT NOT NULL,
  ID_Producto INT NOT NULL,
  Cantidad INT NOT NULL,
  FOREIGN KEY (ID_Venta) REFERENCES Ventas(ID_Venta),
  FOREIGN KEY (ID_Producto) REFERENCES Productos(ID_Producto)
);
Go

CREATE TABLE Tipo_Membresias (
  ID_T_Membresia INT PRIMARY KEY IDENTITY(1,1),
  Descripcion varchar(100) not null,
  Costo_Mensual decimal not null,
  CompraxPunto decimal not null, --cuanto debo gastar para obtener un punto
  Valor_Puntos decimal not null, --Cuanto vale cada punto al cambiarlo por valor real
  Activo bit not null
);
Go

CREATE TABLE Membresias (
  ID_Membresia INT PRIMARY KEY IDENTITY(1,1),
  ID_Cliente int not null,
  ID_T_Membresia int not null,
  Total_Puntos int not null,
  Activo bit not null,
  FOREIGN KEY (ID_T_Membresia) REFERENCES Tipo_Membresias(ID_T_Membresia),
  FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente)
);
Go

CREATE TABLE Estado_Membresias (
  ID_E_Membresia INT PRIMARY KEY IDENTITY(1,1),
  ID_Membresia int not null,
  Fecha_Contrato date not null,
  Descripcion varchar(200),
  Fecha_Proximo_Pago date not null,
  Fecha_Ultimo_Pago date not null,
  Activo bit not null,
  FOREIGN KEY (ID_Membresia) REFERENCES Membresias(ID_Membresia)
);
