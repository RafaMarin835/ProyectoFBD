using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseCompraProveedor
    {
        int _cedula_Proveedor;
        int _codigo_Producto;
        string _descripcion;
        int _cantidadComprada;
        float _total;
        DateTime _fechaCompra;
        int _activo;

        public int CedulaProveedor { get => _cedula_Proveedor; set => _cedula_Proveedor = value; }
        public int CodigoProducto { get => _codigo_Producto; set => _codigo_Producto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int CantidadComprada { get => _cantidadComprada; set => _cantidadComprada = value; }
        public float Total { get => _total; set => _total = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public int Activo { get => _activo; set => _activo = value; }

        public void esValido()
        {
            if (_cedula_Proveedor <= 0)
                throw new Exception("La cédula del proveedor debe ser un número positivo.");
            if (_codigo_Producto <= 0)
                throw new Exception("El código del producto debe ser un número positivo.");
            if (string.IsNullOrEmpty(_descripcion))
            {
                throw new Exception("La descripción no puede estar vacía.");
            }
            if (_cantidadComprada <= 0)
            {
                throw new Exception("La cantidad comprada debe ser mayor que cero.");
            }
            if (_total <= 0)
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
