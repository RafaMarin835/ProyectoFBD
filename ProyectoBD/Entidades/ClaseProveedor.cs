using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ClaseProveedor
    {
        string _nombreProveedor;
        string _correo;
        string _telefono;
        string _direccion;


        public string NombreProveedor { get => _nombreProveedor; set => _nombreProveedor = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public void ValidarProveedor()
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
        }

    }
}
