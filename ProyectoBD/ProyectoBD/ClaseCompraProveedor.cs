using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD
{
    public class ClaseCompraProveedor
    {
        string IDProducto;
        string Descripcion;
        string CantidadComprada;
        string Total;
        DateTime FechaCompra;
        string PrecioUnitario;

        public string IDProducto1 { get => IDProducto; set => IDProducto = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string CantidadComprada1 { get => CantidadComprada; set => CantidadComprada = value; }
        public string Total1 { get => Total; set => Total = value; }
        public DateTime FechaCompra1 { get => FechaCompra; set => FechaCompra = value; }
        public string PrecioUnitario1 { get => PrecioUnitario; set => PrecioUnitario = value; }
    }
}
