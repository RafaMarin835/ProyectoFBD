using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseRegistrarVenta
    {
        string _id_Cliente;
        int _cantidad;
        int _puntosUsados;
        DateTime _fechaventa;
        int _id_Producto;


        public string Id_Clientes { get => _id_Cliente; set => _id_Cliente = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public int PuntosUsados { get => _puntosUsados; set => _puntosUsados = value; }
        public DateTime FechaVenta { get => _fechaventa; set => _fechaventa = value; }
        public int Id_Producto { get => _id_Producto; set => _id_Producto = value; }


        public void esValido()
        {
            if (string.IsNullOrEmpty(_id_Cliente))
                throw new Exception("El ID del cliente no puede estar vacío.");
            if (_cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor que cero.");
            if (_puntosUsados < 0)
                throw new Exception("Los puntos usados no pueden ser negativos.");
            if (_fechaventa > DateTime.Now)
                throw new Exception("La fecha de venta no puede ser en el futuro.");
            if (_id_Producto <= 0)
                throw new Exception("El ID del producto no es válido.");
        }

    }
}
