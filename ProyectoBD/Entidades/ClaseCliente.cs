using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseCliente
    {
        //Cliente
        string _identificacion;
        string _nombre;
        string _direccion;
        string _estadoCivil;
        string _telefono;
        DateTime _fecha_Nacimiento;
        string _correo;
        string _genero;
        DateTime _fechaRegistro;
        string _distrito;
        int _activo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime Fecha_Nacimiento { get => _fecha_Nacimiento; set => _fecha_Nacimiento = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string Identificacion { get => _identificacion; set => _identificacion = value; }
        public string Distrito { get => _distrito; set => _distrito = value; }
        public int Activo { get => _activo; set => _activo = value; }

        //Metodos 
        public void esValido()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new Exception("El nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Direccion))
                throw new Exception("La dirección no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(EstadoCivil))
                throw new Exception("El estado civil no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(Telefono))
                throw new Exception("El teléfono no puede estar vacio");
            if (Fecha_Nacimiento >= DateTime.Now)
                throw new Exception("La fecha de nacimiento no puede ser en el futuro.");
            if (string.IsNullOrWhiteSpace(Correo) || !Correo.Contains("@"))
                throw new Exception("El correo electrónico no es válido debe contener @");
            if (string.IsNullOrWhiteSpace(Genero))
                throw new Exception("El género no puede estar vacío.");
            if (FechaRegistro > DateTime.Now)
                throw new Exception("La fecha de registro no puede ser en el futuro.");
            if (string.IsNullOrWhiteSpace(Identificacion))
                throw new Exception("La identificación no puede estar vacía.");
            if (string.IsNullOrWhiteSpace(Distrito))
                throw new Exception("El distrito no puede estar vacío.");
            if (Activo != 1 && Activo != 0)
                throw new Exception("El estado de activo debe ser verdadero (1) o falso (0).");
        } //fin validaciones



    }
}
