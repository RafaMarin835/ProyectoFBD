using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD
{
    public class ClaseCliente
    {
        //Cliente
        string Nombre;
        string Direccion;
        string EstadoCivil;
        string Telefono;
        string Fecha_Nacimiento;
        string Correo;
        string Genero;
        DateTime FechaRegistro;
        string Identificacion;
        string Provincia;
        string Canton;
        string Distrito;

        //Roles
        string Rol;

        //Membresia
        string TipoMembresia;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Fecha_Nacimiento1 { get => Fecha_Nacimiento; set => Fecha_Nacimiento = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public DateTime FechaRegistro1 { get => FechaRegistro; set => FechaRegistro = value; }
        public string Identificacion1 { get => Identificacion; set => Identificacion = value; }
        public string Provincia1 { get => Provincia; set => Provincia = value; }
        public string Canton1 { get => Canton; set => Canton = value; }
        public string Distrito1 { get => Distrito; set => Distrito = value; }
        public string Rol1 { get => Rol; set => Rol = value; }
        public string TipoMembresia1 { get => TipoMembresia; set => TipoMembresia = value; }
    }
}
