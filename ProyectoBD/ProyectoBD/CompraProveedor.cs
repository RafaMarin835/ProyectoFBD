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
    public partial class CompraProveedor : Form
    {
        ClaseCompraProveedor obj_CompraProveedor = new ClaseCompraProveedor();
        ClaseEnviarDatos obj_ClaseEnviarDatos = new ClaseEnviarDatos();

        public CompraProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {

                obj_CompraProveedor.CedulaProveedor = txtIDProveedor.Text;
                obj_CompraProveedor.CodigoProducto = txtCodigoProducto.Text;
                obj_CompraProveedor.Descripcion = txtDescripcion.Text;
                obj_CompraProveedor.CantidadComprada = Convert.ToInt32 (txtCantComprada.Text);
                obj_CompraProveedor.PrecioUnidadProveedor = float.Parse (txtPrecioUnidadProveedor.Text);
                obj_CompraProveedor.FechaCompra = DateTime.Today;
                if (ListBoxEstado.Text == "Activo") { 
                
                    obj_CompraProveedor.Activo = 1;
                }
                else
                {
                    obj_CompraProveedor.Activo = 0;
                }

                obj_ClaseEnviarDatos.RegistrarComprarProveedor(obj_CompraProveedor);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoProveedor_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprasProveedor_Click(object sender, EventArgs e)
        {
          
        }

        private void historialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HistorialDeCompras historialDeCompras = new HistorialDeCompras();
                historialDeCompras.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProductos.Visible = true;

            ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
            dgvProductos.DataSource = obj_recibirDatos.ObtenerProductos();


        }
    }
}
