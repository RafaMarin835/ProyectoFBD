using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD
{
    public class ClaseProveedores
    {

        string NombreProveedor;
        string Correo;
        string Telefono;
        string Direccion;
       

        public string NombreProveedor1 { get => NombreProveedor; set => NombreProveedor = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
    }

}
