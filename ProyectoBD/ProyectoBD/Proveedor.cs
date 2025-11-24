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
    public partial class Proveedor : Form
    {
        ClaseProveedor obj_proveedor = new ClaseProveedor();
        ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();

        public Proveedor()
        {
            InitializeComponent();
        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            try
            {
               obj_proveedor.Cedula_proveedor = txtIdentificacion.Text;
                obj_proveedor.NombreProveedor = txtNombre.Text;
                obj_proveedor.Correo = txtCorreoElectronico.Text;
                obj_proveedor.Telefono = txtTelefono.Text;
                obj_proveedor.Direccion = txtDireccion.Text;
                obj_proveedor.FechaRegistro = DateTime.Now;
                if (ListBoxEstado.Text == "Activo")
                {
                    obj_proveedor.Activo = 1;
                }
                else
                {
                    obj_proveedor.Activo = 0;
                }

                obj_enviarDatos.ModificarProveedor(obj_proveedor);
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
