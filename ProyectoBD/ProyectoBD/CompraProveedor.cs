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

                obj_CompraProveedor.CedulaProveedor = Convert.ToInt16 (txtIDProveedor.Text);
                obj_CompraProveedor.CodigoProducto = Convert.ToInt16 (txtCodigoProducto.Text);
                obj_CompraProveedor.Descripcion = txtDescripcion.Text;
                obj_CompraProveedor.CantidadComprada = Convert.ToInt16 (txtCantComprada.Text);
                obj_CompraProveedor.Total = float.Parse (txtTotal.Text);
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
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
