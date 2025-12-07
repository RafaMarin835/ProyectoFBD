using CapaNegocios;
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
    public partial class InformacionEmpleados : Form
    {
        public InformacionEmpleados()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
            this.Hide();
        }

        private void volverAEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformacionEmpleados_Load(object sender, EventArgs e)
        {
            ClaseRecibirDatos obj_RecibirDatos = new ClaseRecibirDatos();
            dgvAuditoriaEmpleado.DataSource = obj_RecibirDatos.ObtenerAuditoriasEmpleados();
        }
    }
}
