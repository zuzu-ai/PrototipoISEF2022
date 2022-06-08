
namespace CapaVista
{
	partial class frmProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
			this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.lblEstatus = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.navegador1 = new DLL.nav.navegador();
			this.txtPrecioC = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPreciov = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxIDEmpresa = new System.Windows.Forms.ComboBox();
			this.lblIDEmpresa = new System.Windows.Forms.Label();
			this.txtBodega = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvVistaPrevia
			// 
			this.dgvVistaPrevia.AllowUserToAddRows = false;
			this.dgvVistaPrevia.AllowUserToDeleteRows = false;
			this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVistaPrevia.Location = new System.Drawing.Point(406, 88);
			this.dgvVistaPrevia.Name = "dgvVistaPrevia";
			this.dgvVistaPrevia.ReadOnly = true;
			this.dgvVistaPrevia.RowHeadersWidth = 51;
			this.dgvVistaPrevia.Size = new System.Drawing.Size(769, 179);
			this.dgvVistaPrevia.TabIndex = 113;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(341, 299);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(33, 20);
			this.txtEstado.TabIndex = 111;
			this.txtEstado.TabStop = false;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Location = new System.Drawing.Point(135, 289);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 112;
			// 
			// rbnEstatusamodulo
			// 
			this.rbnEstatusamodulo.AutoSize = true;
			this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
			this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
			this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
			this.rbnEstatusamodulo.TabIndex = 6;
			this.rbnEstatusamodulo.TabStop = true;
			this.rbnEstatusamodulo.Text = "Activo";
			this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
			// 
			// rbnEstatusimodulo
			// 
			this.rbnEstatusimodulo.AutoSize = true;
			this.rbnEstatusimodulo.Location = new System.Drawing.Point(134, 7);
			this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
			this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
			this.rbnEstatusimodulo.TabIndex = 7;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// lblEstatus
			// 
			this.lblEstatus.AutoSize = true;
			this.lblEstatus.Location = new System.Drawing.Point(55, 292);
			this.lblEstatus.Name = "lblEstatus";
			this.lblEstatus.Size = new System.Drawing.Size(45, 13);
			this.lblEstatus.TabIndex = 110;
			this.lblEstatus.Text = "Estatus:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(139, 160);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(209, 20);
			this.txtCantidad.TabIndex = 106;
			this.txtCantidad.Tag = "cantidad";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(139, 134);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(209, 20);
			this.txtNombre.TabIndex = 105;
			this.txtNombre.Tag = "nombre";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(139, 108);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(209, 20);
			this.txtID.TabIndex = 104;
			this.txtID.Tag = "Pkid";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 109;
			this.label3.Text = "Cantidad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 108;
			this.label2.Text = "Nombre";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 107;
			this.label1.Text = "ID";
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(0, -5);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 103;
			// 
			// txtPrecioC
			// 
			this.txtPrecioC.Location = new System.Drawing.Point(139, 195);
			this.txtPrecioC.Name = "txtPrecioC";
			this.txtPrecioC.Size = new System.Drawing.Size(209, 20);
			this.txtPrecioC.TabIndex = 114;
			this.txtPrecioC.Tag = "precioc";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 13);
			this.label4.TabIndex = 115;
			this.label4.Text = "Precio Compra";
			// 
			// txtPreciov
			// 
			this.txtPreciov.Location = new System.Drawing.Point(139, 230);
			this.txtPreciov.Name = "txtPreciov";
			this.txtPreciov.Size = new System.Drawing.Size(209, 20);
			this.txtPreciov.TabIndex = 116;
			this.txtPreciov.Tag = "preciov";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 117;
			this.label5.Text = "Precio Venta";
			// 
			// cbxIDEmpresa
			// 
			this.cbxIDEmpresa.FormattingEnabled = true;
			this.cbxIDEmpresa.Location = new System.Drawing.Point(139, 262);
			this.cbxIDEmpresa.Name = "cbxIDEmpresa";
			this.cbxIDEmpresa.Size = new System.Drawing.Size(209, 21);
			this.cbxIDEmpresa.TabIndex = 118;
			this.cbxIDEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxIDEmpresa_SelectedIndexChanged);
			// 
			// lblIDEmpresa
			// 
			this.lblIDEmpresa.AutoSize = true;
			this.lblIDEmpresa.Location = new System.Drawing.Point(52, 265);
			this.lblIDEmpresa.Name = "lblIDEmpresa";
			this.lblIDEmpresa.Size = new System.Drawing.Size(44, 13);
			this.lblIDEmpresa.TabIndex = 119;
			this.lblIDEmpresa.Text = "Bodega";
			// 
			// txtBodega
			// 
			this.txtBodega.Location = new System.Drawing.Point(354, 265);
			this.txtBodega.Name = "txtBodega";
			this.txtBodega.Size = new System.Drawing.Size(34, 20);
			this.txtBodega.TabIndex = 120;
			this.txtBodega.TabStop = false;
			this.txtBodega.Tag = "bodega";
			this.txtBodega.Visible = false;
			this.txtBodega.TextChanged += new System.EventHandler(this.txtBodega_TextChanged);
			// 
			// frmProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1186, 344);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtBodega);
			this.Controls.Add(this.txtPreciov);
			this.Controls.Add(this.txtPrecioC);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.cbxIDEmpresa);
			this.Controls.Add(this.lblIDEmpresa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvVistaPrevia);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblEstatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.navegador1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProducto";
			this.Text = "Producto";
			((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvVistaPrevia;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnEstatusamodulo;
		private System.Windows.Forms.RadioButton rbnEstatusimodulo;
		private System.Windows.Forms.Label lblEstatus;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.TextBox txtPrecioC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPreciov;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbxIDEmpresa;
		private System.Windows.Forms.Label lblIDEmpresa;
		private System.Windows.Forms.TextBox txtBodega;
	}
}