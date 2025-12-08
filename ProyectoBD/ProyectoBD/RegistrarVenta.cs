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
    public partial class RegistrarVenta : Form
    {
        ClaseRegistrarVenta obj_venta = new ClaseRegistrarVenta();
        ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();

        public RegistrarVenta()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Enviar Datos
                obj_venta.Identificacion = txtIdentificacion.Text;
                obj_venta.Cantidad = int.Parse(txtCantidad.Text);
                obj_venta.PuntosUsados = int.Parse(txtPuntosUtilizados.Text);
                obj_venta.FechaVenta = DateTime.Now;
                obj_venta.Id_Producto = int.Parse(txtIDProducto.Text);

                obj_enviarDatos.RegistrarVenta(obj_venta);
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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void informacionDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionDeVentas informacionDeVentas = new InformacionDeVentas();
                informacionDeVentas.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtIDProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
