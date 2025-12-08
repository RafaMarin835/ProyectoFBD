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

        //Cambia segun el servidor que se esta trabajando (solo comenta el que no usas)
        //String _cadenaConexion = "Data Source = SEBASTIAN; " + "Integrated Security = SSPI;" + "Initial Catalog = ElQuiosco";
        String _cadenaConexion = "Data Source = (localdb)\\MSSQLLocalDB; " + "Integrated Security = SSPI;" + "Initial Catalog = ElQuiosco";

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

        //Metodos para recibir comandos (recuperar datos, insertar, actualizar, eliminar)*********************************************

        #region Funciones uso general //**************************///////////////////////////***********************************///////////////////////////
        private DataTable RecuperarTablaVista(String nombre) //para recuperar una tabla completa o una vista
        {
            try
            {
                EstablecerConexion();
                var da = new SqlDataAdapter($"SELECT * FROM {nombre}", _conexion);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt; //Retorna la tabla completa con los datos
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al recuperar la tabla " + nombre, ex);
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

        #endregion Funciones uso general

        #region Recuperar datos por procedimientos almacenados o comandos //**************************///////////////////////////***********************************///////////////////////////
        public DataTable RecuperarPorIdentificador(String identificador, int indiceTablaVista) // para recuperar procedimientos por identificador (clientes, empleados, etc)
        {
            List<string> tablasVista = new List<string>
                {
                "Cliente",
                "Empleado",
                "Proveedor",
                "Producto",
                "ComprasProveedor",
                "GanaciaProducto",
                "VentasCliente",
                "ClientePagoMembresia"
            };
            if (indiceTablaVista < 0 || indiceTablaVista >= tablasVista.Count)
                throw new ArgumentException("El indice de la tabla o vista a consultar no es valido.");
            string TablaVista = tablasVista[indiceTablaVista];

            return Obtener_Por_Comando($"sp_BuscarPorIdentificador '{identificador}', {TablaVista}");
        }

        public DataTable RecuperarMargenProductoEspecifico(string codigoProducto) // para recuperar margen de un producto especifico
        {
            return Obtener_Por_Comando($"sp_MargenGananciaProductoEspecifico '{codigoProducto}'");
        }

        public DataTable RecuperarTablaCompleta(int indiceTabla) // para recuperar tabla completa
        {
            List<string> tablas = new List<string>
            {
                "Clientes",
                "Empleados",
                "Proveedores",
                "Productos"
            };
            if (indiceTabla < 0 || indiceTabla >= tablas.Count)
                throw new ArgumentException("El indice de la tabla a consultar no es valido.");
            string nombreTabla = tablas[indiceTabla];

            return RecuperarTablaVista(nombreTabla);
        }

        public DataTable RecuperarVista(int indiceVista) // para recuperar vistas especificas por indice
        {
            // Lista de nombres de vistas actuales
            List<string> vistas = new List<string>
            {
                "vw_ClientesxMembresia",
                "vw_ClientesxCompras",
                "vw_ClientesxPagoMembresia",
                "vw_ClientesxPagoAtrasado",
                "vw_EmpleadosAuditorias",
                "vw_CompraxProveedores",
                "vw_ProductosConMargen",
                "vw_ProductosStockBajo",
                "vw_RentabilidadProducto",
                "vw_VentasClientesProducto",
                "vw_DetalleVentaConMargen",
                "vw_ResumenVentasCliente",
                "vw_PagoMembresiaDetalle"
            };

            // Validar índice
            if (indiceVista < 0 || indiceVista >= vistas.Count)
                throw new ArgumentException("La vista buscada esta fuera del indice");

            // Obtener el nombre de la vista según el índice
            string nombreVista = vistas[indiceVista];

            //recuperar y retornar la vista
            return RecuperarTablaVista(nombreVista);
        }

        #endregion Recuperar datos por procedimientos almacenados

        #region eliminar/desactivar/reactivar Registros //**************************///////////////////////////***********************************///////////////////////////
        public void EliminarDesactivarRegistro(string identificador, int indicetabla, bool eliminar = false) //el identificador del registro a eliminar o desactivar, el indice de la tabla y si se elimina (true) o desactiva
        {
            try
            {
                EstablecerConexion();

                using (SqlCommand cmd = new SqlCommand("sp_EliminarDesactivarRegistro", _conexion))
                {
                    //--índice de la tabla(0 = Clientes, 1 = Empleados, 2 = Proveedores, 3 = Productos)
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tabla", indicetabla);
                    cmd.Parameters.AddWithValue("@Identificador", identificador);
                    cmd.Parameters.AddWithValue("@Eliminar", eliminar);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                        throw new Exception("No se encontró el registro con el identificador proporcionado.");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar el procedimiento: " + ex.Message);
            }
            finally
            {
                if (_conexion != null && _conexion.State == ConnectionState.Open)
                    _conexion.Close();
            }
        }

        public void ReactivarRegistro(string identificador, int indicetabla)
        {// -- índice de la tabla (0=Clientes, 1=Empleados, 2=Proveedores, 3=Productos)
            try
            {
                EstablecerConexion();

                using (SqlCommand cmd = new SqlCommand("sp_ReactivarRegistro", _conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tabla", indicetabla);
                    cmd.Parameters.AddWithValue("@Identificador", identificador);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                        throw new Exception("No se encontró el registro con el identificador proporcionado.");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar el procedimiento: " + ex.Message);
            }
            finally
            {
                if (_conexion != null && _conexion.State == ConnectionState.Open)
                    _conexion.Close();
            }
        }


        #endregion eliminar/desactivar Registros

        #region Modificar Registros //**************************///////////////////////////***********************************///////////////////////////
        public void ModificarEmpleado(ClaseEmpleado obj) // para modificar un empleado
        {
            try
            {
                EstablecerConexion();
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
                EstablecerConexion();
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
                EstablecerConexion();
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
                EstablecerConexion();
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
                EstablecerConexion();
                SqlCommand cmd = new SqlCommand("sp_Proveedor", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula_proveedor", obj.Cedula_proveedor);
                cmd.Parameters.AddWithValue("@Nombre_Proveedor", obj.NombreProveedor);
                cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", obj.Direccion);
                cmd.Parameters.AddWithValue("@Fecha_Registro", obj.FechaRegistro);
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
                EstablecerConexion();
                SqlCommand cmd = new SqlCommand("sp_Productos", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Producto", obj.Codigo_Producto);
                cmd.Parameters.AddWithValue("@Nombre_Producto", obj.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
                cmd.Parameters.AddWithValue("@Precio", obj.Precio);
                cmd.Parameters.AddWithValue("@PrecioProveedoor", obj.PrecioProveedoor);
                cmd.Parameters.AddWithValue("@Stock", obj.Stock);
                cmd.Parameters.AddWithValue("@Fecha_Registro", obj.FechaRegistro);
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
                EstablecerConexion();
                SqlCommand cmd = new SqlCommand("sp_CompraProveedor", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cedula_Proveedor", obj.CedulaProveedor);
                cmd.Parameters.AddWithValue("@Codigo_Producto", obj.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                cmd.Parameters.AddWithValue("@Cant_Comprada", obj.CantidadComprada);
                cmd.Parameters.AddWithValue("@PrecioProveedorUd", obj.PrecioUnidadProveedor);
                cmd.Parameters.AddWithValue("@Fecha_Compra", obj.FechaCompra);
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
                EstablecerConexion();
                SqlCommand cmd = new SqlCommand("sp_Venta", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", obj.Identificacion);
                cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                cmd.Parameters.AddWithValue("@Puntos_Usados", obj.PuntosUsados);
                cmd.Parameters.AddWithValue("@Fecha_Venta", obj.FechaVenta);
                cmd.Parameters.AddWithValue("@ID_Producto", obj.Id_Producto);

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
                EstablecerConexion();
                SqlCommand cmd = new SqlCommand("sp_ActualizarUsuarioContrasena", _conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Usuario", user);
                cmd.Parameters.AddWithValue("@NuevaContraseña", contrasena);


                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la membresia en DB: " + ex.Message);
            }
        }
        #endregion Modificar Registros

        #endregion Metodos
    }
}
