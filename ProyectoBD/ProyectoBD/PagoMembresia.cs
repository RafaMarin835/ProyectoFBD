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
    public partial class PagoMembresia : Form
    {
        public PagoMembresia()
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
                MessageBox.Show("Error al abrir la pantalla principal: " + ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informacionPagoDeMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionPagoMembresia informacionPagoMembresia = new InformacionPagoMembresia();
                informacionPagoMembresia.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la información de pago de membresía: " + ex.Message);
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                ClasePagoMembresia pagoMembresia = new ClasePagoMembresia();
                pagoMembresia.Identificacion = txtIdentificacion.Text;
                pagoMembresia.Descripcion = txtDescripcion.Text;
                pagoMembresia.Fecha_ultmo_Pago = Convert.ToDateTime(txtFechaUltimoPago.Text);

                ClaseEnviarDatos claseEnviarDatos = new ClaseEnviarDatos();


                claseEnviarDatos.PagarMembresia(pagoMembresia);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago de membresía: " + ex.Message);

            }
        }
    }
}
