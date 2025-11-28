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

namespace ProyectoBD
{
    public partial class pruebasRafa : Form
    {
        ClaseRecibirDatos recibir = new ClaseRecibirDatos();

        public pruebasRafa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = textBox1.Text;
                dataGridView1.DataSource = recibir.BuscarClientePorIdentificacion(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
