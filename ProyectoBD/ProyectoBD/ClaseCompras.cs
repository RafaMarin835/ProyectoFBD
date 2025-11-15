using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD
{
    public class ClaseCompras
    {
        string ID_Clientes;
        DateTime FechaCompra;
        float Total;
        int  PuntosUsados;

        public string ID_Clientes1 { get => ID_Clientes; set => ID_Clientes = value; }
        public DateTime FechaCompra1 { get => FechaCompra; set => FechaCompra = value; }
        public float Total1 { get => Total; set => Total = value; }
        public int PuntosUsados1 { get => PuntosUsados; set => PuntosUsados = value; }
    }
}
