using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseVentas
    {
        string _id_Cliente;
        DateTime _fechaCompra;
        float _total;
        int _puntosUsados;
        int _cant_Vendidos;


        public string Id_Clientes { get => _id_Cliente; set => _id_Cliente = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public float Total { get => _total; set => _total = value; }
        public int PuntosUsados { get => _puntosUsados; set => _puntosUsados = value; }
        public int Cant_Venta { get => _cant_Vendidos; set => _cant_Vendidos = value; }

        public void ValidarVenta()
        {
            if (string.IsNullOrEmpty(_id_Cliente))
            {
                throw new Exception("El ID del cliente no puede estar vacío.");
            }
            if (_total < 0)
            {
                throw new Exception("El total de la venta no puede ser negativo.");
            }
            if (_puntosUsados < 0)
            {
                throw new Exception("Los puntos usados no pueden ser negativos.");
            }
            if (_cant_Vendidos <= 0)
            {
                throw new Exception("La cantidad vendida debe ser mayor a cero.");
            }
            if (_fechaCompra > DateTime.Now)
            {
                throw new Exception("La fecha de compra no puede ser en el futuro.");
            }
        }

    }
}
