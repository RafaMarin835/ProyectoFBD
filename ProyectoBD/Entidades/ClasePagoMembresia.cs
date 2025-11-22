using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClasePagoMembresia
    {
        int _id_Membresia;
        float _monto;
        string _descripcion;

        public int Id_Membresia { get => _id_Membresia; set => _id_Membresia = value; }
        public float Monto { get => _monto; set => _monto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public void esValido()
        {
            if (_id_Membresia <= 0)
                throw new Exception("El ID de la membresía no puede ser menor o igual a cero.");
            if (_monto <= 0)
                throw new Exception("El monto debe ser mayor que cero.");
            if (string.IsNullOrWhiteSpace(_descripcion))
                throw new Exception("La descripción no puede estar vacía.");
        }

    }
}
