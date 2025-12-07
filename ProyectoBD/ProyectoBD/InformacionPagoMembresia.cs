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
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void volverAPagoDeMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoMembresia pagoMembresia = new PagoMembresia();
            pagoMembresia.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIDCliente_Click(object sender, EventArgs e)
        {
            ClaseRecibirDatos claseRecibirDatos = new ClaseRecibirDatos();
            dgvPagoMembresia.DataSource = claseRecibirDatos.ObtenerClientePagoMembresia(txtIDCliente.Text);
        }

        private void InformacionPagoMembresia_Load(object sender, EventArgs e)
        {
            ClaseRecibirDatos claseRecibirDatos = new ClaseRecibirDatos();
            dgvPagoMembresia.DataSource = claseRecibirDatos.ObtenerDetallePagoMembresia();
        }
    }
}
