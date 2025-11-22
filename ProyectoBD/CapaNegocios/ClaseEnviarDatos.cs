using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaNegocios
{
    public class ClaseEnviarDatos
    {
        ClaseSQLManager claseSQL = new ClaseSQLManager(); //Para conectar con la base de datos


        public void ModificarEmpleado(ClaseEmpleado obj_EntidadEmpleado) //recibe el obejto con la informacion a enviar para agregar o actualizar empleados
        {
            obj_EntidadEmpleado.esValido(); //valida que la informacion sea correcta
            claseSQL.ModificarEmpleado(obj_EntidadEmpleado);
        }

        public void ModificarCliente(ClaseCliente obj_EntidadCliente) //recibe el obejto a enviar para agregar o actualizar clientes
        {
            obj_EntidadCliente.esValido(); //valida que la informacion sea correcta
            claseSQL.ModificarCliente(obj_EntidadCliente);
        }

        public void ActualziarMembresia(ClaseActualizarMembresia obj_EntidadMembresia) //recibe el obejto con la informacion a enviar para actualizar una membresia
        {
            obj_EntidadMembresia.esValido(); //valida que la informacion sea correcta
            claseSQL.ActualizarMembresia(obj_EntidadMembresia);
        }

        public void PagarMembresia(ClasePagoMembresia obj_EntidadPagarMembresia) //recibe el obejto con la informacion a enviar para pagar una membresia
        {
            obj_EntidadPagarMembresia.esValido(); //valida que la informacion sea correcta
            claseSQL.ActualizarPagoMembresia(obj_EntidadPagarMembresia);
        }

        public void ModificarProveedor(ClaseProveedor obj_EntidadProveedor) //recibe el obejto con la informacion a enviar para agregar o actualizar proveedores
        {
            obj_EntidadProveedor.esValido(); //valida que la informacion sea correcta
            claseSQL.ModificarProveedores(obj_EntidadProveedor);
        }

        public void ModificarProducto(ClaseProducto obj_EntidadProducto) //recibe el obejto con la informacion a enviar para agregar o actualizar productos
        {
            obj_EntidadProducto.esValido(); //valida que la informacion sea correcta
            claseSQL.ModificarProductos(obj_EntidadProducto);
        }

        public void RegistrarComprarProveedor(ClaseCompraProveedor obj_EntidadCompraProveedor) //recibe el obejto con la informacion a enviar para registrar una compra a proveedor
        {
            obj_EntidadCompraProveedor.esValido(); //valida que la informacion sea correcta
            claseSQL.RegistrarCompraProveedor(obj_EntidadCompraProveedor);
        }

        public void RegistrarVenta(ClaseRegistrarVenta obj_EntidadVenta) //recibe el obejto con la informacion a enviar para registrar una venta
        {
            obj_EntidadVenta.esValido(); //valida que la informacion sea correcta
            claseSQL.RegistrarVenta(obj_EntidadVenta);
        }


        /////////////////////////////////////////////***********************************//////////////////////////////////////
        
        ///Otras funciones que no requieren un objeto entidad
        public void ActualizarUsuario(String user, string contrasena) //recibe el obejto con la informacion a enviar para modificar la configuracion
        {
            if (string.IsNullOrEmpty(user))
                throw new Exception("El nombre de usuario no puede estar vacío.");
            if (string.IsNullOrEmpty(contrasena))
                throw new Exception("La contraseña no puede estar vacía.");

            claseSQL.ActualizarSecionUser(user, contrasena);
        }

    }
}
