using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CapaDatos // De momento se ingnora
{
    public class ClaseSQLManager
    {

        SqlConnection _conexion;

        //Cambia segun el servidor que se esta trabajando
        String _cadenaConexion = "Data Source=SEBASTIAN;Integrated Security = True; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name = SQL Server Management Studio; Command Timeout = 30";


        //Metodos
        #region Metodos
        private void EstablecerConexion()
        {
            _conexion = new SqlConnection(_cadenaConexion);

            //establece la conexion a partir del string de conexion
            _conexion.Open();

        } //fin establecer conexion

        private void CerrarConexion()
        {
            //cierra la conexion
            _conexion.Close();
        } //fin cerrar conexion

        //Metodos para recibir comandos (recuperar datos, insertar, actualizar, eliminar)

        private DataTable RecuperarTabla(String nombreTabla)
        {
            try
            {
                EstablecerConexion();
                var da = new SqlDataAdapter($"SELECT * FROM {nombreTabla}", _conexion);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt; //Retorna la tabla completa con los datos
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al recuperar la tabla " + nombreTabla, ex);
            }
            finally
            {
                _conexion.Close();
            }

        } //fin recuperar tabla

        public DataTable Obtener_Por_Comando(String comandoSql)
        {
            try
            {
                EstablecerConexion();
                var da = new SqlDataAdapter(comandoSql, _conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt; //Retorna la tabla completa con los datos segun el comando
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar el comando SQL: " + comandoSql, ex);
            }
            finally
            {
                _conexion.Close();
            }
        } //fin obtener por comando

        public void ModificarEmpleado(ClaseEmpleado obj) // para modificar un empleado
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Empleado", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", obj.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Estado_Civil", obj.EstadoCivil);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", obj.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                cmd.Parameters.AddWithValue("@Genero", obj.Genero);
                cmd.Parameters.AddWithValue("@Fecha_Registro", obj.FechaRegistro);
                cmd.Parameters.AddWithValue("@ID_Distrito", obj.ID_Distrito);
                cmd.Parameters.AddWithValue("@Activo", obj.Activo);
                cmd.Parameters.AddWithValue("@Salario", obj.Salario);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al guardar el empleado en DB: " + ex.Message);
            }
        }

        public void ModificarCliente(ClaseCliente obj) // para guardar o actualizar un usuario
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Cliente", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", obj.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Estado_Civil", obj.EstadoCivil);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", obj.Fecha_Nacimiento);
                cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                cmd.Parameters.AddWithValue("@Genero", obj.Genero);
                cmd.Parameters.AddWithValue("@Fecha_Registro", obj.FechaRegistro);
                cmd.Parameters.AddWithValue("@ID_Distrito", obj.ID_Distrito);
                cmd.Parameters.AddWithValue("@Activo", obj.Activo);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al guardar el cliente en DB: " + ex.Message);
            }
        }

        public void ActualizarMembresia(ClaseActualizarMembresia obj) // para actualizar una membresia
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarMembresia", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", obj.Identificacion);
                cmd.Parameters.AddWithValue("@Id_T_Membresia", obj.Id_T_Membresia);
                cmd.Parameters.AddWithValue("@Frecuencia_Pago", obj.Frecuencia_Pago);
                cmd.Parameters.AddWithValue("@Fecha_Contrato", obj.Fecha_Contrato);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la membresia en DB: " + ex.Message);
            }
        }

        public void ActualizarPagoMembresia(ClasePagoMembresia obj) // para realizar el pago de membresia
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_PagoMembresia", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", obj.Identificacion);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha_Ultmo_Pago", obj.Fecha_ultmo_Pago);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al pagar la membresia en DB: " + ex.Message);
            }
        }

        public void ModificarProveedores(ClaseProveedor obj) // para modificar los proveedores
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Proveedor", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula_proveedor", obj.Cedula_proveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", obj.NombreProveedor);
                cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@FechaRegistro", obj.FechaRegistro);
                cmd.Parameters.AddWithValue("@Activo", obj.Activo);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la membresia en DB: " + ex.Message);
            }
        }

        public void ModificarProductos(ClaseProducto obj) // para modificar los productos
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Productos", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Producto", obj.Codigo_Producto);
                cmd.Parameters.AddWithValue("@Nombre_Producto", obj.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
                cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                cmd.Parameters.AddWithValue("@PrecioProveedoor", obj.PrecioProveedoor);
                cmd.Parameters.AddWithValue("@Stock", obj.Stock);
                cmd.Parameters.AddWithValue("@FechaRegistro", obj.FechaRegistro);
                cmd.Parameters.AddWithValue("@Activo", obj.Activo);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al modificar el producto en DB: " + ex.Message);
            }
        }

        public void RegistrarCompraProveedor(ClaseCompraProveedor obj) // Para registrar una compra a un proveedor
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_CompraProveedor", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula_Proveedor", obj.CedulaProveedor);
                cmd.Parameters.AddWithValue("@Codigo_Producto", obj.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@CantidadComprada", obj.CantidadComprada);
                cmd.Parameters.AddWithValue("@Total", obj.Total);
                cmd.Parameters.AddWithValue("@FechaCompra", obj.FechaCompra);
                cmd.Parameters.AddWithValue("@Activo", obj.Activo);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la membresia en DB: " + ex.Message);
            }
        }

        public void RegistrarVenta(ClaseRegistrarVenta obj) // para registrar una venta
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Venta", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", obj.Identificacion);
                cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                cmd.Parameters.AddWithValue("@PuntosUsados", obj.PuntosUsados);
                cmd.Parameters.AddWithValue("@FechaVenta", obj.FechaVenta);
                cmd.Parameters.AddWithValue("@Id_Producto", obj.Id_Producto);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la membresia en DB: " + ex.Message);
            }
        }


        /////////////////////////////////////////////*************************///////////////////////////
        
        //////Funciones extras
        ///
        public void ActualizarSecionUser(String user, string contrasena) // para actualizar el usuario y contraseña de un empleado
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarUsuarioContrasena", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Usuario", user);
                cmd.Parameters.AddWithValue("@@NuevaContraseña", contrasena);


                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la membresia en DB: " + ex.Message);
            }
        }

        #endregion Metodos
    }
}
