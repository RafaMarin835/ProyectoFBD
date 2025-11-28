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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEstudiantes_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor proveedores = new Proveedor();
            proveedores.Show();
            this.Hide();
        }

        private void registroVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = new RegistrarVenta();
            registrarVenta.Show();
            this.Hide();
        }

        private void pagoMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoMembresia pagoMembresia = new PagoMembresia();  
            pagoMembresia.Show();
            this.Hide();
        }

        private void actualizarMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarMembresia actualizarMembresia = new ActualizarMembresia();
            actualizarMembresia.Show();
            this.Hide();
        }

        private void compraProveedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraProveedor compraProveedor = new CompraProveedor();
            compraProveedor.Show();
            this.Hide();
        }

        private void mientrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pruebasRafa pruebasRafa = new pruebasRafa();
            pruebasRafa.Show();
        }
    }
}
