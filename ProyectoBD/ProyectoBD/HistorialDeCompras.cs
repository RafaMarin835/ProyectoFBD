using CapaNegocios;
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
    public partial class HistorialDeCompras : Form
    {
        public HistorialDeCompras()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void volverAComprasProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CompraProveedor compraProveedor = new CompraProveedor();
                compraProveedor.Show();
                this.Hide();
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

        private void HistorialDeCompras_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvHistorialProveedores.DataSource = recibirDatos.ObtenerComprasPorProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHistorialProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvHistorialProveedores.DataSource = recibirDatos.ObtenerComprasPorProveedorEspecifico(txtIDProveedor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
