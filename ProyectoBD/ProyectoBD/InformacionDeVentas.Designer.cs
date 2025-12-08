namespace ProyectoBD
{
    partial class InformacionDeVentas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.btnIDCliente = new System.Windows.Forms.Button();
            this.btnVentaCliente = new System.Windows.Forms.Button();
            this.btnDetalleVentaMargen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.volverAVentasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.menuPrincipalToolStripMenuItem.Text = "Menu principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // volverAVentasToolStripMenuItem
            // 
            this.volverAVentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverAVentasToolStripMenuItem.Name = "volverAVentasToolStripMenuItem";
            this.volverAVentasToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.volverAVentasToolStripMenuItem.Text = "Volver a ventas";
            this.volverAVentasToolStripMenuItem.Click += new System.EventHandler(this.volverAVentasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMACION DE VENTAS";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(15, 127);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(776, 256);
            this.dgvVentas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ver ventas por cliente (ID Cliente): ";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(220, 79);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(126, 20);
            this.txtIDCliente.TabIndex = 4;
            // 
            // btnIDCliente
            // 
            this.btnIDCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDCliente.Location = new System.Drawing.Point(352, 72);
            this.btnIDCliente.Name = "btnIDCliente";
            this.btnIDCliente.Size = new System.Drawing.Size(94, 31);
            this.btnIDCliente.TabIndex = 5;
            this.btnIDCliente.Text = "Buscar";
            this.btnIDCliente.UseVisualStyleBackColor = true;
            this.btnIDCliente.Click += new System.EventHandler(this.btnIDCliente_Click);
            // 
            // btnVentaCliente
            // 
            this.btnVentaCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaCliente.Location = new System.Drawing.Point(18, 408);
            this.btnVentaCliente.Name = "btnVentaCliente";
            this.btnVentaCliente.Size = new System.Drawing.Size(109, 43);
            this.btnVentaCliente.TabIndex = 6;
            this.btnVentaCliente.Text = "Obtener ventas por cliente";
            this.btnVentaCliente.UseVisualStyleBackColor = true;
            this.btnVentaCliente.Click += new System.EventHandler(this.btnVentaCliente_Click);
            // 
            // btnDetalleVentaMargen
            // 
            this.btnDetalleVentaMargen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleVentaMargen.Location = new System.Drawing.Point(133, 408);
            this.btnDetalleVentaMargen.Name = "btnDetalleVentaMargen";
            this.btnDetalleVentaMargen.Size = new System.Drawing.Size(130, 43);
            this.btnDetalleVentaMargen.TabIndex = 7;
            this.btnDetalleVentaMargen.Text = "Ver ventas con detalle del margen de ganacia";
            this.btnDetalleVentaMargen.UseVisualStyleBackColor = true;
            this.btnDetalleVentaMargen.Click += new System.EventHandler(this.btnDetalleVentaMargen_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(269, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Resumen de ventas de los clientes\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InformacionDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(831, 488);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDetalleVentaMargen);
            this.Controls.Add(this.btnVentaCliente);
            this.Controls.Add(this.btnIDCliente);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InformacionDeVentas";
            this.Text = "InformacionDeVentas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Button btnIDCliente;
        private System.Windows.Forms.Button btnVentaCliente;
        private System.Windows.Forms.Button btnDetalleVentaMargen;
        private System.Windows.Forms.Button button3;
    }
}