using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseActualizarMembresia
    {
        string _identificacion;
        int _id_T_Membresia;
        int _frecuencia_Pago;
        DateTime _fecha_Contrato;

        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        public int Id_T_Membresia { get => _id_T_Membresia; set => _id_T_Membresia = value; }
        public int Frecuencia_Pago { get => _frecuencia_Pago; set => _frecuencia_Pago = value; }
        public DateTime Fecha_Contrato { get => _fecha_Contrato; set => _fecha_Contrato = value; }

        public void esValido()
        {
            if (string.IsNullOrWhiteSpace(_identificacion))
                throw new Exception("La identificación no puede estar vacía.");
            if (_id_T_Membresia <= 0)
                throw new Exception("El ID del tipo de membresía no puede ser menor o igual a cero.");
            if (_frecuencia_Pago <= 0)
                throw new Exception("La frecuencia de pago debe ser mayor que cero.");
            if (_fecha_Contrato > DateTime.Now)
                throw new Exception("La fecha de contrato no puede ser en el futuro.");
        }
    }
}
