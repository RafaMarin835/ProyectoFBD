namespace ProyectoBD
{
    partial class InformacionProductos
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
            this.volverAProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnMargenGanacia = new System.Windows.Forms.Button();
            this.btnProductosConStockBajo = new System.Windows.Forms.Button();
            this.btnGanaciaTotal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnMargenGanancia = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.volverAProductosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 25);
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
            // volverAProductosToolStripMenuItem
            // 
            this.volverAProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverAProductosToolStripMenuItem.Name = "volverAProductosToolStripMenuItem";
            this.volverAProductosToolStripMenuItem.Size = new System.Drawing.Size(131, 21);
            this.volverAProductosToolStripMenuItem.Text = "Volver a productos";
            this.volverAProductosToolStripMenuItem.Click += new System.EventHandler(this.volverAProductosToolStripMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMACION DE PRODUCTOS";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(30, 126);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(776, 290);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnMargenGanacia
            // 
            this.btnMargenGanacia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMargenGanacia.Location = new System.Drawing.Point(21, 440);
            this.btnMargenGanacia.Name = "btnMargenGanacia";
            this.btnMargenGanacia.Size = new System.Drawing.Size(157, 59);
            this.btnMargenGanacia.TabIndex = 3;
            this.btnMargenGanacia.Text = "Ver margen de ganancia de todos los productos";
            this.btnMargenGanacia.UseVisualStyleBackColor = true;
            this.btnMargenGanacia.Click += new System.EventHandler(this.btnMargenGanacia_Click);
            // 
            // btnProductosConStockBajo
            // 
            this.btnProductosConStockBajo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosConStockBajo.Location = new System.Drawing.Point(184, 440);
            this.btnProductosConStockBajo.Name = "btnProductosConStockBajo";
            this.btnProductosConStockBajo.Size = new System.Drawing.Size(157, 59);
            this.btnProductosConStockBajo.TabIndex = 4;
            this.btnProductosConStockBajo.Text = "Ver productos con bajo stock (Menos de 10)";
            this.btnProductosConStockBajo.UseVisualStyleBackColor = true;
            this.btnProductosConStockBajo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGanaciaTotal
            // 
            this.btnGanaciaTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanaciaTotal.Location = new System.Drawing.Point(347, 440);
            this.btnGanaciaTotal.Name = "btnGanaciaTotal";
            this.btnGanaciaTotal.Size = new System.Drawing.Size(149, 59);
            this.btnGanaciaTotal.TabIndex = 5;
            this.btnGanaciaTotal.Text = "Ver la ganacia total de todos los productos";
            this.btnGanaciaTotal.UseVisualStyleBackColor = true;
            this.btnGanaciaTotal.Click += new System.EventHandler(this.btnGanaciaTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo producto:\r\n";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(122, 66);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(113, 20);
            this.txtCodigoProducto.TabIndex = 7;
            // 
            // btnMargenGanancia
            // 
            this.btnMargenGanancia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMargenGanancia.Location = new System.Drawing.Point(241, 63);
            this.btnMargenGanancia.Name = "btnMargenGanancia";
            this.btnMargenGanancia.Size = new System.Drawing.Size(164, 29);
            this.btnMargenGanancia.TabIndex = 8;
            this.btnMargenGanancia.Text = "Ver margen de ganancia";
            this.btnMargenGanancia.UseVisualStyleBackColor = true;
            this.btnMargenGanancia.Click += new System.EventHandler(this.btnMargenGanancia_Click);
            // 
            // InformacionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(861, 592);
            this.Controls.Add(this.btnMargenGanancia);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGanaciaTotal);
            this.Controls.Add(this.btnProductosConStockBajo);
            this.Controls.Add(this.btnMargenGanacia);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InformacionProductos";
            this.Text = "InformacionProductos";
            this.Load += new System.EventHandler(this.InformacionProductos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnMargenGanacia;
        private System.Windows.Forms.Button btnProductosConStockBajo;
        private System.Windows.Forms.Button btnGanaciaTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button btnMargenGanancia;
    }
}