using CapaNegocios;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class Empleados : Form
    {
        ClaseEmpleado obj_Empleado = new ClaseEmpleado();
        ClaseEnviarDatos obj_EnviarDatos = new ClaseEnviarDatos();

        public Empleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar datos
                obj_Empleado.Identificacion = txtIdentificacion.Text;
                obj_Empleado.Nombre = txtNombre.Text;
                obj_Empleado.Telefono = txtTelefono.Text;
                obj_Empleado.Correo = txtCorreo.Text;
                obj_Empleado.Salario = float.Parse(txtSalario.Text);
                obj_Empleado.Direccion = txtDireccion.Text;
                obj_Empleado.EstadoCivil = txtEstadoCivil.Text;
                obj_Empleado.Fecha_Nacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                obj_Empleado.Genero = txtGenero.Text;
                obj_Empleado.FechaRegistro = DateTime.Now;
                obj_Empleado.ID_Distrito = txtDistrito.Text;

                if (ListBoxActivo.Text == "Activo")
                {

                    obj_Empleado.Activo = 1;
                }
                else
                {
                    obj_Empleado.Activo = 0;
                }

                obj_EnviarDatos.ModificarEmpleado(obj_Empleado);

               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
