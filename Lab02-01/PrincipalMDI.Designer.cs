
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSisSalir
            // 
            this.mnuSisSalir.Name = "mnuSisSalir";
            this.mnuSisSalir.Size = new System.Drawing.Size(200, 26);
            this.mnuSisSalir.Text = "Salir del sistema";
            this.mnuSisSalir.Click += new System.EventHandler(this.mnuSisSalir_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(224, 26);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(224, 26);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcVenta,
            this.mnuProcCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProcVenta
            // 
            this.mnuProcVenta.Name = "mnuProcVenta";
            this.mnuProcVenta.Size = new System.Drawing.Size(208, 26);
            this.mnuProcVenta.Text = "Registrar Venta";
            // 
            // mnuProcCompra
            // 
            this.mnuProcCompra.Name = "mnuProcCompra";
            this.mnuProcCompra.Size = new System.Drawing.Size(208, 26);
            this.mnuProcCompra.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepVentas,
            this.mnuRepCompras,
            this.mnuRepInventarioProductos,
            this.mnuRepProveedores,
            this.mnuRepUsuarios,
            this.mnuRepClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepVentas
            // 
            this.mnuRepVentas.Name = "mnuRepVentas";
            this.mnuRepVentas.Size = new System.Drawing.Size(252, 26);
            this.mnuRepVentas.Text = "Reporte de ventas";
            // 
            // mnuRepCompras
            // 
            this.mnuRepCompras.Name = "mnuRepCompras";
            this.mnuRepCompras.Size = new System.Drawing.Size(252, 26);
            this.mnuRepCompras.Text = "Reporte de Compras";
            // 
            // mnuRepInventarioProductos
            // 
            this.mnuRepInventarioProductos.Name = "mnuRepInventarioProductos";
            this.mnuRepInventarioProductos.Size = new System.Drawing.Size(252, 26);
            this.mnuRepInventarioProductos.Text = "Inventario de Productos";
            // 
            // mnuRepProveedores
            // 
            this.mnuRepProveedores.Name = "mnuRepProveedores";
            this.mnuRepProveedores.Size = new System.Drawing.Size(252, 26);
            this.mnuRepProveedores.Text = "Reporte de Proveedores";
            // 
            // mnuRepUsuarios
            // 
            this.mnuRepUsuarios.Name = "mnuRepUsuarios";
            this.mnuRepUsuarios.Size = new System.Drawing.Size(252, 26);
            this.mnuRepUsuarios.Text = "Reporte de Usuarios";
            // 
            // mnuRepClientes
            // 
            this.mnuRepClientes.Name = "mnuRepClientes";
            this.mnuRepClientes.Size = new System.Drawing.Size(252, 26);
            this.mnuRepClientes.Text = "Reporte de Clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProcVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProcCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuRepVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepClientes;
    }
}