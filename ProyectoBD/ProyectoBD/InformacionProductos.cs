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
    public partial class InformacionProductos : Form
    {
        public InformacionProductos()
        {
            InitializeComponent();
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

        private void volverAProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Productos productos = new Productos();
                productos.Show();
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

        private void InformacionProductos_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = recibirDatos.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = recibirDatos.ObtenerProductosStockBajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGanaciaTotal_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = recibirDatos.ObtenerRentabilidadProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMargenGanacia_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = recibirDatos.ObtenerProductosConMargen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMargenGanancia_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = recibirDatos.ObtenerMargenGananciaProducto(txtCodigoProducto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
