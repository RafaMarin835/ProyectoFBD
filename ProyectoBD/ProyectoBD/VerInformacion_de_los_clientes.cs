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
    public partial class VerInformacion_de_los_clientes : Form
    {
        public VerInformacion_de_los_clientes()
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void volverAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clientes = new Clientes();
                clientes.Show();
                this.Hide();
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

        private void VerInformacion_de_los_clientes_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClientesCompras_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesPorCompras();
                dgvClientes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesPorMembresia();
                dgvClientes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClientesPagoAtrasado_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesConPagosAtrasados();
                dgvClientes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnUltimoPago_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
                dgvClientes.DataSource = obj_RecibirDatos.ObtenerClientesPorUltimoPagoMembresia();
                dgvClientes.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
