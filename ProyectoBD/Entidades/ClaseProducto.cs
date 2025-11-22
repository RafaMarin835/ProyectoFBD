using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseProducto
    {
        string _codigo_Producto;
        string _nombre_Producto;
        string _Categoria;
        float _precio;
        float _precioProveedoor;
        int _stock;
        DateTime _fechaRegistro;
        int _activo;

        public string Codigo_Producto { get => _codigo_Producto; set => _codigo_Producto = value; }
        public string Nombre_Producto { get => _nombre_Producto; set => _nombre_Producto = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public float PrecioProveedoor { get => _precioProveedoor; set => _precioProveedoor = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public int Activo { get => _activo; set => _activo = value; }

        public void esValido()
        {
            if (string.IsNullOrWhiteSpace(Codigo_Producto))
                throw new Exception("El código del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Nombre_Producto))
                throw new Exception("El nombre del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Categoria))
                throw new Exception("La categoría del producto no puede estar vacía.");
            if (Precio <= 0)
                throw new Exception("El precio debe ser mayor que cero.");
            if (PrecioProveedoor <= 0)
                throw new Exception("El precio del proveedor debe ser mayor que cero.");
            if (Stock < 0)
                throw new Exception("El stock no puede ser negativo.");
            if (FechaRegistro > DateTime.Now)
                throw new Exception("La fecha de registro no puede ser en el futuro.");
            if (Activo != 1 && Activo != 0)
                throw new Exception("El estado de activo debe ser verdadero (1) o falso (0).");
        }
    }
}
