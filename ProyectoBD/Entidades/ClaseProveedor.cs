using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseProveedor
    {
        string _cedula_proveedor;
        string _nombreProveedor;
        string _correo;
        string _telefono;
        string _direccion;
        DateTime _fechaRegistro;
        int _activo;


        public string NombreProveedor { get => _nombreProveedor; set => _nombreProveedor = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public DateTime FechaRegistro { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string Cedula_proveedor { get => _cedula_proveedor; set => _cedula_proveedor = value; }
        public int Activo { get => _activo; set => _activo = value; }

        public void esValido()
        {
            if (string.IsNullOrEmpty(_nombreProveedor))
            {
                throw new Exception("El nombre del proveedor no puede estar vacío.");
            }
            if (string.IsNullOrEmpty(_correo) || !_correo.Contains("@"))
            {
                throw new Exception("El correo del proveedor no es válido y debe contener @");
            }
            if (string.IsNullOrEmpty(_telefono) || _telefono.Length < 7)
            {
                throw new Exception("El teléfono del proveedor no es válido y debe tener al menos 7 dígitos.");
            }
            if (string.IsNullOrEmpty(_direccion))
            {
                throw new Exception("La dirección del proveedor no puede estar vacía.");
            }
            if (_fechaRegistro > DateTime.Now)
            {
                throw new Exception("La fecha de registro no puede ser en el futuro.");
            }
            if (string.IsNullOrEmpty(_cedula_proveedor))
            {
                throw new Exception("La cédula del proveedor no puede estar vacía.");
            }
            if (_activo != 0 && _activo != 1)
                throw new Exception("El estado activo del proveedor debe ser 0 (inactivo) o 1 (activo).");
        }

    }
}
