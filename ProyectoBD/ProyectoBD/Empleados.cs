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
            dgvEmpleados.CellDoubleClick += dgvEmpleados_CellDoubleClick;
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
            try
            {
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvEmpleados.DataSource = obj_RecibirDatos.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evitar error si se hace doble clic en encabezado
                if (e.RowIndex < 0) return;

                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                txtIdentificacion.Text = fila.Cells["Identificacion"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtSalario.Text = fila.Cells["Salario"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtEstadoCivil.Text = fila.Cells["Estado_Civil"].Value.ToString();
                txtFechaNacimiento.Text = fila.Cells["Fecha_Nacimiento"].Value.ToString();
                txtGenero.Text = fila.Cells["Genero"].Value.ToString();
                txtDistrito.Text = fila.Cells["ID_Distrito"].Value.ToString();

                int activo = Convert.ToInt32(fila.Cells["Activo"].Value);
                if (activo == 1)
                    ListBoxActivo.Text = "Activo";
                else
                    ListBoxActivo.Text = "Inactivo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void informacionEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionEmpleados informacionEmpleados = new InformacionEmpleados();
                informacionEmpleados.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvEmpleados.DataSource = obj_RecibirDatos.BuscarEmpleadoPorIdentificacion(txtIdentificacion.Text);
                btnVerTodosLosEmpleados.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVerTodosLosEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvEmpleados.DataSource = obj_RecibirDatos.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
