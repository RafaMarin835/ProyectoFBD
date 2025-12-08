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
    public partial class ActualizarMembresia : Form
    {
        ClaseActualizarMembresia obj_actualizarMembresia = new ClaseActualizarMembresia();
        ClaseEnviarDatos obj_enviarDatos = new ClaseEnviarDatos();
        public ActualizarMembresia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
            
                obj_actualizarMembresia.Identificacion = txtIdentificacion.Text;
                obj_actualizarMembresia.Id_T_Membresia = Convert.ToInt16(txtTipoMembresia.Text);
                obj_actualizarMembresia.Frecuencia_Pago = Convert.ToInt16(txtFrecuenciaPago.Text);
                obj_actualizarMembresia.Fecha_Contrato = Convert.ToDateTime(txtFechaContrato.Text);

                obj_enviarDatos.ActualziarMembresia(obj_actualizarMembresia);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
