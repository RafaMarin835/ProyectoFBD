using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseProducto
    {
        string _nombre_Producto;
        string _descripcion;
        float _precio;
        int _stock;

        public string Nombre_Producto { get => _nombre_Producto; set => _nombre_Producto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public void esValido()
        {
            if (string.IsNullOrWhiteSpace(Nombre_Producto))
                throw new Exception("El nombre del producto no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Descripcion))
                throw new Exception("La descripción no puede estar vacía.");
            if (Precio <= 0)
                throw new Exception("El precio debe ser mayor que cero.");
            if (Stock < 0)
                throw new Exception("El stock no puede ser negativo.");
        }
    }
}
