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
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
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

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = obj_recibirDatos.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = obj_recibirDatos.BuscarProductoPorCodigo(txtCodigoProducto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnVerTodosLosProductos_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseRecibirDatos obj_recibirDatos = new ClaseRecibirDatos();
                dgvProductos.DataSource = obj_recibirDatos.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evitar clic en encabezado
                if (e.RowIndex < 0) return;

                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtCodigoProducto.Text = fila.Cells["Codigo_Producto"].Value.ToString();
                txtNombreProducto.Text = fila.Cells["NombreProducto"].Value.ToString();
                txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtPrecioProveedor.Text = fila.Cells["PrecioProveedor"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();

                int activo = Convert.ToInt32(fila.Cells["Activo"].Value);
                if (activo == 1)
                    ListBoxEstado.Text = "Activo";
                else
                    ListBoxEstado.Text = "Inactivo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void verInformacionSobreLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InformacionProductos informacionProductos = new InformacionProductos();
                informacionProductos.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
