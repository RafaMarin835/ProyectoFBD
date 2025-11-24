using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseCompraProveedor
    {
        String _cedula_Proveedor;
        String _codigo_Producto;
        string _descripcion;
        int _cantidadComprada;
        float _precioUnidadProveedor;
        DateTime _fechaCompra;
        int _activo;

        public String CedulaProveedor { get => _cedula_Proveedor; set => _cedula_Proveedor = value; }
        public String CodigoProducto { get => _codigo_Producto; set => _codigo_Producto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int CantidadComprada { get => _cantidadComprada; set => _cantidadComprada = value; }
        public float PrecioUnidadProveedor { get => _precioUnidadProveedor; set => _precioUnidadProveedor = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public int Activo { get => _activo; set => _activo = value; }

        public void esValido()
        {
            if (string.IsNullOrEmpty(_cedula_Proveedor))
            {
                throw new Exception("La cédula del proveedor no puede estar vacía.");
            }
            if (string.IsNullOrEmpty(_codigo_Producto))
            {
                throw new Exception("El código del producto no puede estar vacío.");
            }
            if (string.IsNullOrEmpty(_descripcion))
            {
                throw new Exception("La descripción no puede estar vacía.");
            }
            if (_cantidadComprada <= 0)
            {
                throw new Exception("La cantidad comprada debe ser mayor que cero.");
            }
            if (_precioUnidadProveedor <= 0)
            {
                throw new Exception("El total debe ser mayor que cero.");
            }
            if (_fechaCompra > DateTime.Now)
            {
                throw new Exception("La fecha de compra no puede ser en el futuro.");
            }
            if (_activo != 1 && _activo != 0)
            {
                throw new Exception("El estado de activo debe ser verdadero (1) o falso (0).");
            }
        }
    }
}
