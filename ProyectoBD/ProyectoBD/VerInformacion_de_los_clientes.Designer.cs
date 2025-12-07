namespace ProyectoBD
{
    partial class VerInformacion_de_los_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnClientesCompras = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClientesPagoAtrasado = new System.Windows.Forms.Button();
            this.BtnUltimoPago = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apartado de visualizacion de datos de los clientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.volverAClientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // volverAClientesToolStripMenuItem
            // 
            this.volverAClientesToolStripMenuItem.Name = "volverAClientesToolStripMenuItem";
            this.volverAClientesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.volverAClientesToolStripMenuItem.Text = "Volver a clientes";
            this.volverAClientesToolStripMenuItem.Click += new System.EventHandler(this.volverAClientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 66);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(789, 309);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnClientesCompras
            // 
            this.btnClientesCompras.Location = new System.Drawing.Point(192, 381);
            this.btnClientesCompras.Name = "btnClientesCompras";
            this.btnClientesCompras.Size = new System.Drawing.Size(92, 36);
            this.btnClientesCompras.TabIndex = 3;
            this.btnClientesCompras.Text = "Ver clientes y sus compras";
            this.btnClientesCompras.UseVisualStyleBackColor = true;
            this.btnClientesCompras.Click += new System.EventHandler(this.btnClientesCompras_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Clientes y sus membresias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientesPagoAtrasado
            // 
            this.btnClientesPagoAtrasado.Location = new System.Drawing.Point(398, 381);
            this.btnClientesPagoAtrasado.Name = "btnClientesPagoAtrasado";
            this.btnClientesPagoAtrasado.Size = new System.Drawing.Size(97, 36);
            this.btnClientesPagoAtrasado.TabIndex = 5;
            this.btnClientesPagoAtrasado.Text = "Clientes con pago atrasado";
            this.btnClientesPagoAtrasado.UseVisualStyleBackColor = true;
            this.btnClientesPagoAtrasado.Click += new System.EventHandler(this.btnClientesPagoAtrasado_Click);
            // 
            // BtnUltimoPago
            // 
            this.BtnUltimoPago.Location = new System.Drawing.Point(501, 381);
            this.BtnUltimoPago.Name = "BtnUltimoPago";
            this.BtnUltimoPago.Size = new System.Drawing.Size(111, 36);
            this.BtnUltimoPago.TabIndex = 6;
            this.BtnUltimoPago.Text = "Cliente y su ultimo pago de membresia";
            this.BtnUltimoPago.UseVisualStyleBackColor = true;
            this.BtnUltimoPago.Click += new System.EventHandler(this.BtnUltimoPago_Click);
            // 
            // VerInformacion_de_los_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.BtnUltimoPago);
            this.Controls.Add(this.btnClientesPagoAtrasado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClientesCompras);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VerInformacion_de_los_clientes";
            this.Text = "VerInformacion_de_los_clientes";
            this.Load += new System.EventHandler(this.VerInformacion_de_los_clientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnClientesCompras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClientesPagoAtrasado;
        private System.Windows.Forms.Button BtnUltimoPago;
    }
}