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
    public partial class InformacionPagoMembresia : Form
    {
        public InformacionPagoMembresia()
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
                MessageBox.Show("Error al abrir la pantalla principal: " + ex.Message);
            }
        }

        private void volverAPagoDeMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PagoMembresia pagoMembresia = new PagoMembresia();
                pagoMembresia.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al volver al pago de membresía: " + ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIDCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos claseRecibirDatos = new ClaseRecibirDatos();
                dgvPagoMembresia.DataSource = claseRecibirDatos.ObtenerClientePagoMembresia(txtIDCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
            }
        }

        private void InformacionPagoMembresia_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos claseRecibirDatos = new ClaseRecibirDatos();
                dgvPagoMembresia.DataSource = claseRecibirDatos.ObtenerDetallePagoMembresia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de pagos de membresía: " + ex.Message);
            }
        }
    }
}
