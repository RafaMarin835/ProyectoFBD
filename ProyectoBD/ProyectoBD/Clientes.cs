using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using Entidades;

namespace ProyectoBD
{
    public partial class Clientes : Form
    {
        ClaseCliente obj_EntidadClientes = new ClaseCliente();
        ClaseEnviarDatos obj_Clientes = new ClaseEnviarDatos();

        public Clientes()
        {
            InitializeComponent();

            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_EntidadClientes.Identificacion = txtIdentificacion.Text;
                obj_EntidadClientes.Nombre = txtNombre.Text;
                obj_EntidadClientes.EstadoCivil = txtEstadoCivil.Text;
                obj_EntidadClientes.Telefono = txtTelefono.Text;
                obj_EntidadClientes.Fecha_Nacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                obj_EntidadClientes.Correo = txtCorreo.Text;
                obj_EntidadClientes.Genero = txtGenero.Text;
                obj_EntidadClientes.Direccion = txtDireccion.Text;
                obj_EntidadClientes.FechaRegistro = DateTime.Now;
                obj_EntidadClientes.ID_Distrito = txtDistrito.Text;

                if (ListBoxActivo.Text == "Activo")
                {
                    obj_EntidadClientes.Activo = 1;
                }
                else
                { 
                    obj_EntidadClientes.Activo = 0;
                }

                obj_Clientes.ModificarCliente(obj_EntidadClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
             ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
             dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientes();
             dgvClientes.Visible = true;
        }

        private void btnVerClientesYCompras_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
            dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesPorCompras();
            dgvClientes.Visible = true;
        }

        private void btnClientesYMembresias_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
            dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesPorMembresia();
            dgvClientes.Visible = true;
        }

        private void btnPagoAtrasado_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
            dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesConPagosAtrasados();
            dgvClientes.Visible = true;
        }

        private void btnClientesPago_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
            dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesPorUltimoPagoMembresia();
            dgvClientes.Visible = true;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                txtIdentificacion.Text = fila.Cells["Identificacion"].Value?.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtEstadoCivil.Text = fila.Cells["Estado_Civil"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtFechaNacimiento.Text = fila.Cells["Fecha_Nacimiento"].Value?.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString();
                txtGenero.Text = fila.Cells["Genero"].Value?.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString();
                txtDistrito.Text = fila.Cells["ID_Distrito"].Value?.ToString();

                ListBoxActivo.Text = (fila.Cells["Activo"].Value.ToString() == "1") ? "Activo" : "Inactivo";
            }
        }
    }
}
