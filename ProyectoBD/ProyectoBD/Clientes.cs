using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using Entidades;

namespace ProyectoBD
{
    public partial class Clientes : Form
    {
        ClaseCliente obj_EntidadClientes = new ClaseCliente();
        C_Clientes obj_Clientes = new C_Clientes();

        public Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_EntidadClientes.Identificacion = txtIdentificacion.Text;
                obj_EntidadClientes.Nombre = txtNombre.Text;
                //aca es continuar con lo mismo para los otros campos


                obj_Clientes.AgregarModificarCliente(obj_EntidadClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
