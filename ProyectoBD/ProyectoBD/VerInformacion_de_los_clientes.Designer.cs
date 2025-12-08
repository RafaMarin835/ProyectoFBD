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
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(813, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // volverAClientesToolStripMenuItem
            // 
            this.volverAClientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverAClientesToolStripMenuItem.Name = "volverAClientesToolStripMenuItem";
            this.volverAClientesToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.volverAClientesToolStripMenuItem.Text = "Volver a clientes";
            this.volverAClientesToolStripMenuItem.Click += new System.EventHandler(this.volverAClientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 66);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(789, 309);
            this.dgvClientes.TabIndex = 2;
            // 
            // btnClientesCompras
            // 
            this.btnClientesCompras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesCompras.Location = new System.Drawing.Point(148, 394);
            this.btnClientesCompras.Name = "btnClientesCompras";
            this.btnClientesCompras.Size = new System.Drawing.Size(117, 48);
            this.btnClientesCompras.TabIndex = 3;
            this.btnClientesCompras.Text = "Ver clientes y sus compras";
            this.btnClientesCompras.UseVisualStyleBackColor = true;
            this.btnClientesCompras.Click += new System.EventHandler(this.btnClientesCompras_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(271, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Clientes y sus membresias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientesPagoAtrasado
            // 
            this.btnClientesPagoAtrasado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesPagoAtrasado.Location = new System.Drawing.Point(398, 395);
            this.btnClientesPagoAtrasado.Name = "btnClientesPagoAtrasado";
            this.btnClientesPagoAtrasado.Size = new System.Drawing.Size(111, 47);
            this.btnClientesPagoAtrasado.TabIndex = 5;
            this.btnClientesPagoAtrasado.Text = "Clientes con pago atrasado";
            this.btnClientesPagoAtrasado.UseVisualStyleBackColor = true;
            this.btnClientesPagoAtrasado.Click += new System.EventHandler(this.btnClientesPagoAtrasado_Click);
            // 
            // BtnUltimoPago
            // 
            this.BtnUltimoPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUltimoPago.Location = new System.Drawing.Point(515, 395);
            this.BtnUltimoPago.Name = "BtnUltimoPago";
            this.BtnUltimoPago.Size = new System.Drawing.Size(147, 47);
            this.BtnUltimoPago.TabIndex = 6;
            this.BtnUltimoPago.Text = "Cliente y su ultimo pago de membresia";
            this.BtnUltimoPago.UseVisualStyleBackColor = true;
            this.BtnUltimoPago.Click += new System.EventHandler(this.BtnUltimoPago_Click);
            // 
            // VerInformacion_de_los_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
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