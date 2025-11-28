namespace ProyectoBD
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoMembresiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMembresiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraProveedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mientrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Heading", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 104);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(727, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PROYECTO SISTEMA DE GESTION DE MEMBRESIAS";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiantes.Location = new System.Drawing.Point(12, 167);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(348, 195);
            this.lblEstudiantes.TabIndex = 1;
            this.lblEstudiantes.Text = "Estudiantes:\r\nPedro Sebastian Navarro Mariño\r\nRafael Marín Mora\r\nDorian Blanco\r\nF" +
    "rancisco Vega Chaves\r\n";
            this.lblEstudiantes.Click += new System.EventHandler(this.lblEstudiantes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.registroVentaToolStripMenuItem,
            this.pagoMembresiaToolStripMenuItem,
            this.actualizarMembresiaToolStripMenuItem,
            this.compraProveedToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.mientrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productoToolStripMenuItem.Text = "Productos";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // registroVentaToolStripMenuItem
            // 
            this.registroVentaToolStripMenuItem.Name = "registroVentaToolStripMenuItem";
            this.registroVentaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.registroVentaToolStripMenuItem.Text = "Registro Venta";
            this.registroVentaToolStripMenuItem.Click += new System.EventHandler(this.registroVentaToolStripMenuItem_Click);
            // 
            // pagoMembresiaToolStripMenuItem
            // 
            this.pagoMembresiaToolStripMenuItem.Name = "pagoMembresiaToolStripMenuItem";
            this.pagoMembresiaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.pagoMembresiaToolStripMenuItem.Text = "Pago Membresia";
            this.pagoMembresiaToolStripMenuItem.Click += new System.EventHandler(this.pagoMembresiaToolStripMenuItem_Click);
            // 
            // actualizarMembresiaToolStripMenuItem
            // 
            this.actualizarMembresiaToolStripMenuItem.Name = "actualizarMembresiaToolStripMenuItem";
            this.actualizarMembresiaToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.actualizarMembresiaToolStripMenuItem.Text = "Actualizar Membresia";
            this.actualizarMembresiaToolStripMenuItem.Click += new System.EventHandler(this.actualizarMembresiaToolStripMenuItem_Click);
            // 
            // compraProveedToolStripMenuItem
            // 
            this.compraProveedToolStripMenuItem.Name = "compraProveedToolStripMenuItem";
            this.compraProveedToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.compraProveedToolStripMenuItem.Text = "Compra Proveedor";
            this.compraProveedToolStripMenuItem.Click += new System.EventHandler(this.compraProveedToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mientrasToolStripMenuItem
            // 
            this.mientrasToolStripMenuItem.Name = "mientrasToolStripMenuItem";
            this.mientrasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.mientrasToolStripMenuItem.Text = "Mientras";
            this.mientrasToolStripMenuItem.Click += new System.EventHandler(this.mientrasToolStripMenuItem_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 760);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoMembresiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMembresiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraProveedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mientrasToolStripMenuItem;
    }
}

