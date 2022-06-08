
namespace CapaVista
{
    partial class frmMDI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventanaConFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión ";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// catálogosToolStripMenuItem
			// 
			this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventana1ToolStripMenuItem,
            this.ventanaConFotoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.formaDePagoToolStripMenuItem});
			this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
			this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.catálogosToolStripMenuItem.Text = "Catálogos ";
			// 
			// ventana1ToolStripMenuItem
			// 
			this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
			this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ventana1ToolStripMenuItem.Text = "Bodega";
			this.ventana1ToolStripMenuItem.Click += new System.EventHandler(this.ventana1ToolStripMenuItem_Click);
			// 
			// ventanaConFotoToolStripMenuItem
			// 
			this.ventanaConFotoToolStripMenuItem.Name = "ventanaConFotoToolStripMenuItem";
			this.ventanaConFotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ventanaConFotoToolStripMenuItem.Text = "Producto";
			this.ventanaConFotoToolStripMenuItem.Click += new System.EventHandler(this.ventanaConFotoToolStripMenuItem_Click);
			// 
			// productoToolStripMenuItem
			// 
			this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
			this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.productoToolStripMenuItem.Text = "Forma de Pago";
			this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
			// 
			// formaDePagoToolStripMenuItem
			// 
			this.formaDePagoToolStripMenuItem.Name = "formaDePagoToolStripMenuItem";
			this.formaDePagoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.formaDePagoToolStripMenuItem.Text = "Cliente";
			this.formaDePagoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagoToolStripMenuItem_Click);
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem});
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// facturaciónToolStripMenuItem
			// 
			this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
			this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.facturaciónToolStripMenuItem.Text = "Facturación";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// ayudasToolStripMenuItem
			// 
			this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
			this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.ayudasToolStripMenuItem.Text = "Ayudas";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(622, 3);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 2;
			this.txtUsuario.Visible = false;
			// 
			// frmMDI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources.fondo;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMDI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMDI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMDI_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaConFotoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formaDePagoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
	}
}