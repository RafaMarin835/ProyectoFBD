using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseCompraProveedor
    {
        int _id_Proveedor;
        int _id_Producto;
        string _descripcion;
        int _cantidadComprada;
        float _total;
        DateTime _fechaCompra;

        public int Id_Proveedor { get => _id_Proveedor; set => _id_Proveedor = value; }
        public int Id_Producto { get => _id_Producto; set => _id_Producto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int CantidadComprada { get => _cantidadComprada; set => _cantidadComprada = value; }
        public float Total { get => _total; set => _total = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }

        public void ValidarCompra()
        {
            if (_id_Proveedor <= 0)
            {
                throw new Exception("El ID del proveedor no es válido.");
            }
            if (_id_Producto <= 0)
            {
                throw new Exception("El ID del producto no es válido.");
            }
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
        }
    }
}
