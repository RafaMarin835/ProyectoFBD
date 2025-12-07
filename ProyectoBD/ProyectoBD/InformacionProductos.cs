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
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void volverAProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformacionProductos_Load(object sender, EventArgs e)
        {
            ClaseRecibirDatos recibirDatos= new ClaseRecibirDatos();
            dgvProductos.DataSource = recibirDatos.ObtenerProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
            dgvProductos.DataSource = recibirDatos.ObtenerProductosStockBajo();
        }

        private void btnGanaciaTotal_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
            dgvProductos.DataSource = recibirDatos.ObtenerRentabilidadProductos();
        }

        private void btnMargenGanacia_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
            dgvProductos.DataSource = recibirDatos.ObtenerProductosConMargen();
        }

        private void btnMargenGanancia_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
            dgvProductos.DataSource = recibirDatos.ObtenerMargenGananciaProducto(txtCodigoProducto.Text);
        }
    }
}
