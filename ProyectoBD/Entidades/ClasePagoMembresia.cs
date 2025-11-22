using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClasePagoMembresia
    {
        string _identificacion;
        string _descripcion;
        DateTime _fecha_ultmo_Pago;

        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime Fecha_ultmo_Pago { get => _fecha_ultmo_Pago; set => _fecha_ultmo_Pago = value; }

        public void esValido()
        {
            if (string.IsNullOrWhiteSpace(_identificacion))
                throw new Exception("La identificación no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(_descripcion))
                throw new Exception("La descripción no puede estar vacía.");
            if (_fecha_ultmo_Pago > DateTime.Now)
                throw new Exception("La fecha del último pago no puede ser futura.");
        }

    }
}
