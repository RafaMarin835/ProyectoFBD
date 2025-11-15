using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseMembresia
    {
        //para membresia de cliente
        int _id_Cliente;
        int _total_Puntos;

        //info extra para membresia
        DateTime _fecha_Contrato;
        string _descripcionEstado;
        DateTime _fecha_Proximo_Pago;
        DateTime _fecha_Ultimo_Pago;

        //getters and setters
        public int Id_Cliente { get => _id_Cliente; set => _id_Cliente = value; }
        public int TotalPuntos { get => _total_Puntos; set => _total_Puntos = value; }
        public DateTime Fecha_Contrato { get => _fecha_Contrato; set => _fecha_Contrato = value; }
        public string DescripcionEstado { get => _descripcionEstado; set => _descripcionEstado = value; }
        public DateTime Fecha_Proximo_Pago { get => _fecha_Proximo_Pago; set => _fecha_Proximo_Pago = value; }
        public DateTime Fecha_Ultimo_Pago { get => _fecha_Ultimo_Pago; set => _fecha_Ultimo_Pago = value; }

        public void ValidarEstadoMembresia()
        {
            if (_id_Cliente <= 0)
                throw new Exception("El ID del cliente no puede ser menor o igual a cero.");
            if (_total_Puntos < 0)
                throw new Exception("El total de puntos no puede ser negativo.");
            if (_fecha_Contrato > DateTime.Now)
                throw new Exception("La fecha de contrato no puede ser en el futuro.");
            if (_fecha_Proximo_Pago < DateTime.Now)
                throw new Exception("La fecha del próximo pago no puede ser en el pasado.");
            if (_fecha_Ultimo_Pago > DateTime.Now)
                throw new Exception("La fecha del último pago no puede ser en el futuro.");


        }
    }


}
