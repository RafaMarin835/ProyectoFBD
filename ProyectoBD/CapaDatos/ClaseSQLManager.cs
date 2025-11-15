using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace CapaDatos // De momento se ingnora
{
    public class ClaseSQLManager
    {

        SqlConnection _conexion;

        //Cambia segun el servidor que se esta trabajando
        String _cadenaConexion = "Data Source = (localdb)\\MSSQLLocalDB; " + "Integrated Security=SSPI; " + "Initial Catalog=ElQuiosco";


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

        private void ActualizarDB(string sqlInsert, params SqlParameter[] parametros) // Método genérico para insertar, actualizar o eliminar datos en la base de datos
        {
            try
            {
                EstablecerConexion();
                using (var sqlinstruccion = new SqlCommand(sqlInsert, _conexion))
                {
                    sqlinstruccion.Parameters.AddRange(parametros);
                    sqlinstruccion.ExecuteNonQuery();
                }
                _conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la accion a DB: " + ex.Message);
            }
        }

        public void GuardarCliente(ClaseCliente cliente ) // Método para guardar o actualizar un usuario
        {
            string ComandoSQL = @"
        IF EXISTS (SELECT 1 FROM Usuarios WHERE Identificacion = @Identificacion)
        BEGIN
            UPDATE Clientes
            SET Nombre = @Nombre,
                Direccion = @Direccion,
                Estado_Civil = @Estado_Civil,
                Telefono = @Telefono,
                Fecha_Nacimiento = @Fecha_Nacimiento,
                Correo = @Correo,
                Genero = @Genero,
                Fecha_Registro = @Fecha_Registro,
                ID_Provincia = @ID_Provincia,
                ID_Canton = @ID_Canton,
                ID_Distrito = @ID_Distrito
            WHERE Identificacion = @Identificacion
        END
        ELSE
        BEGIN
            INSERT INTO Usuarios (Identificacion, Nombre, Direccion, Estado_Civil, Telefono, Fecha_Nacimiento, Correo,
                                  Genero, Fecha_Registro, ID_Provincia, ID_Canton, Email)
            VALUES (@Identificacion, @Nombre, @Direccion, @Estado_Civil, @Telefono, @Fecha_Nacimiento, @Correo,
                    @Genero, @Fecha_Registro, @ID_Provincia, @ID_Canton, @ID_Distrito)
        END";
            ActualizarDB(ComandoSQL,
                new SqlParameter("@Identificacion", cliente.Identificacion),
                new SqlParameter("@Nombre", cliente.Nombre),
                new SqlParameter("@Direccion", cliente.Direccion),
                new SqlParameter("@Estado_Civil", cliente.EstadoCivil),
                new SqlParameter("@Telefono", cliente.Telefono),
                new SqlParameter("@Fecha_Nacimiento", cliente.Fecha_Nacimiento),
                new SqlParameter("@Correo", cliente.Correo),
                new SqlParameter("@Genero", cliente.Genero),
                new SqlParameter("@Fecha_Registro", cliente.FechaRegistro),
                new SqlParameter("@ID_Provincia", cliente.ID_Provincia),
                new SqlParameter("@ID_Canton", cliente.ID_Canton),
                new SqlParameter("@ID_Distrito", cliente.ID_Distrito)
                );
        }





        #endregion

    }
}
