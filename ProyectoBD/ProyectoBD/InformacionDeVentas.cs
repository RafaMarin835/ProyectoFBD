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
    public partial class InformacionDeVentas : Form
    {
        public InformacionDeVentas()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void volverAVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = new RegistrarVenta();
            registrarVenta.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIDCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvVentas.DataSource = recibirDatos.ObtenerVentasPorClienteEspecifico(txtIDCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVentaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvVentas.DataSource = recibirDatos.ObtenerVentasPorCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDetalleVentaMargen_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvVentas.DataSource = recibirDatos.ObtenerDetalleVentaConMargen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos recibirDatos = new ClaseRecibirDatos();
                dgvVentas.DataSource = recibirDatos.ObtenerResumenVentasCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
