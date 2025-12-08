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
    public partial class Proveedor : Form
    {
        ClaseProveedor obj_proveedor = new ClaseProveedor();
        ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();

        public Proveedor()
        {
            InitializeComponent();

            dgvProveedor.CellDoubleClick += dgvProveedor_CellDoubleClick;
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_proveedor.Cedula_proveedor = txtIdentificacion.Text;
                obj_proveedor.NombreProveedor = txtNombre.Text;
                obj_proveedor.Correo = txtCorreoElectronico.Text;
                obj_proveedor.Telefono = txtTelefono.Text;
                obj_proveedor.Direccion = txtDireccion.Text;
                obj_proveedor.FechaRegistro = DateTime.Now;
                if (ListBoxEstado.Text == "Activo")
                {
                    obj_proveedor.Activo = 1;
                }
                else
                {
                    obj_proveedor.Activo = 0;
                }

                obj_enviarDatos.ModificarProveedor(obj_proveedor);
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

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
                dgvProveedor.DataSource = obj_recibirDatos.BuscarProveedorPorCedulaProveedor(txtIdentificacion.Text);
                btnVerTodosProveedores.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
                dgvProveedor.DataSource = obj_recibirDatos.ObtenerProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVerTodosProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
                dgvProveedor.DataSource = obj_recibirDatos.ObtenerProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evitar clic en encabezado
                if (e.RowIndex < 0) return;

                DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];

                txtIdentificacion.Text = fila.Cells["Cedula_proveedor"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre_Proveedor"].Value.ToString();
                txtCorreoElectronico.Text = fila.Cells["Correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();

                int activo = Convert.ToInt32(fila.Cells["Activo"].Value);
                if (activo == 1)
                    ListBoxEstado.Text = "Activo";
                else
                    ListBoxEstado.Text = "Inactivo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDesactivarProveedor_Click(object sender, EventArgs e)
        {
            ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();
            try
            {
                obj_enviarDatos.DesactivarProveedor(txtIdentificacion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReactivarProveedor_Click(object sender, EventArgs e)
        {
            ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();
            try
            {
                obj_enviarDatos.ReactivarProveedor(txtIdentificacion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
    }
}
