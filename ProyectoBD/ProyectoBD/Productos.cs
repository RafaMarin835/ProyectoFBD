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
    
    public partial class Productos : Form
    {
        ClaseProducto obj_producto = new ClaseProducto();
        ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                obj_producto.Codigo_Producto = txtCodigoProducto.Text;
                obj_producto.Nombre_Producto = txtNombreProducto.Text;
                obj_producto.Categoria = txtCategoria.Text;
                obj_producto.Precio = float.Parse(txtPrecio.Text);
                obj_producto.PrecioProveedoor = float.Parse(txtPrecioProveedor.Text);
                obj_producto.Stock = int.Parse(txtStock.Text);
                obj_producto.FechaRegistro = DateTime.Now;

                if (ListBoxEstado.Text == "Activo")
                {
                    obj_producto.Activo = 1;
                }
                else
                {
                    obj_producto.Activo = 0;
                }

                obj_enviarDatos.ModificarProducto(obj_producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
