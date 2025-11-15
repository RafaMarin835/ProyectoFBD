using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaNegocios
{
    public class C_Clientes
    {
        ClaseSQLManager obj_Tabla = new ClaseSQLManager(); //Para conectar con la base de datos


        public void AgregarModificarCliente(ClaseCliente obj_EntidadClientes) //recibe el obejto con la informacion a enviar
        {
            obj_EntidadClientes.esValido(); //valida que la informacion sea correcta
            obj_Tabla.GuardarCliente(obj_EntidadClientes);
        }

    }
}
