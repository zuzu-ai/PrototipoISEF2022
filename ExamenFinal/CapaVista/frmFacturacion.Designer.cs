
namespace CapaVista
{
	partial class frmFacturacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.dtgDetalle = new System.Windows.Forms.DataGridView();
			this.dtgEncabezado = new System.Windows.Forms.DataGridView();
			this.txtidps = new System.Windows.Forms.TextBox();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.cbxPS = new System.Windows.Forms.ComboBox();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtIddetalle = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.navegador1 = new DLL.nav.navegador();
			this.txtidfpago = new System.Windows.Forms.TextBox();
			this.cbxfpago = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.cbxAE = new System.Windows.Forms.ComboBox();
			this.cbxidcambio = new System.Windows.Forms.ComboBox();
			this.cbxTipocambio = new System.Windows.Forms.ComboBox();
			this.cbxApellido = new System.Windows.Forms.ComboBox();
			this.cbxNombre = new System.Windows.Forms.ComboBox();
			this.txtfechaemision = new System.Windows.Forms.TextBox();
			this.txtidcliente = new System.Windows.Forms.TextBox();
			this.dtpFechaemision = new System.Windows.Forms.DateTimePicker();
			this.rbnVencida = new System.Windows.Forms.RadioButton();
			this.rbnActiva = new System.Windows.Forms.RadioButton();
			this.cbxCliente = new System.Windows.Forms.ComboBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtIdfactura = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblIdcotizacion = new System.Windows.Forms.Label();
			this.lblIdEmpleado = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblIdcliente = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgEncabezado)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.txtStock);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtCantidad);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.dtgDetalle);
			this.panel2.Controls.Add(this.dtgEncabezado);
			this.panel2.Controls.Add(this.txtidps);
			this.panel2.Controls.Add(this.btnLimpiar);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.btnInsertar);
			this.panel2.Controls.Add(this.cbxPS);
			this.panel2.Controls.Add(this.txtSubtotal);
			this.panel2.Controls.Add(this.txtIddetalle);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Location = new System.Drawing.Point(3, 113);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(802, 403);
			this.panel2.TabIndex = 15;
			// 
			// txtStock
			// 
			this.txtStock.Enabled = false;
			this.txtStock.Location = new System.Drawing.Point(67, 56);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(145, 20);
			this.txtStock.TabIndex = 47;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 46;
			this.label5.Text = "Stock:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(67, 82);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(145, 20);
			this.txtCantidad.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 44;
			this.label3.Text = "Cantidad:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(450, 8);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(99, 13);
			this.label15.TabIndex = 43;
			this.label15.Text = "Detalles de Factura";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(450, 199);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(103, 13);
			this.label14.TabIndex = 42;
			this.label14.Text = "Facturas Extendidas";
			// 
			// dtgDetalle
			// 
			this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgDetalle.Location = new System.Drawing.Point(233, 24);
			this.dtgDetalle.Name = "dtgDetalle";
			this.dtgDetalle.Size = new System.Drawing.Size(547, 175);
			this.dtgDetalle.TabIndex = 41;
			// 
			// dtgEncabezado
			// 
			this.dtgEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgEncabezado.Location = new System.Drawing.Point(233, 215);
			this.dtgEncabezado.Name = "dtgEncabezado";
			this.dtgEncabezado.Size = new System.Drawing.Size(547, 172);
			this.dtgEncabezado.TabIndex = 40;
			// 
			// txtidps
			// 
			this.txtidps.Location = new System.Drawing.Point(211, 29);
			this.txtidps.Name = "txtidps";
			this.txtidps.Size = new System.Drawing.Size(19, 20);
			this.txtidps.TabIndex = 39;
			this.txtidps.Visible = false;
			this.txtidps.TextChanged += new System.EventHandler(this.txtidps_TextChanged);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(137, 191);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 36;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(6, 191);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(121, 23);
			this.btnModificar.TabIndex = 34;
			this.btnModificar.Text = "Finalizar Factura";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(53, 162);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(113, 23);
			this.btnInsertar.TabIndex = 33;
			this.btnInsertar.Text = "Agregar Artículo";
			this.btnInsertar.UseVisualStyleBackColor = true;
			// 
			// cbxPS
			// 
			this.cbxPS.FormattingEnabled = true;
			this.cbxPS.Location = new System.Drawing.Point(67, 29);
			this.cbxPS.Name = "cbxPS";
			this.cbxPS.Size = new System.Drawing.Size(145, 21);
			this.cbxPS.TabIndex = 21;
			this.cbxPS.SelectedIndexChanged += new System.EventHandler(this.cbxPS_SelectedIndexChanged);
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Enabled = false;
			this.txtSubtotal.Location = new System.Drawing.Point(67, 108);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(145, 20);
			this.txtSubtotal.TabIndex = 19;
			// 
			// txtIddetalle
			// 
			this.txtIddetalle.Enabled = false;
			this.txtIddetalle.Location = new System.Drawing.Point(67, 3);
			this.txtIddetalle.Name = "txtIddetalle";
			this.txtIddetalle.Size = new System.Drawing.Size(145, 20);
			this.txtIddetalle.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 115);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Subtotal:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "P/S:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(4, 3);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 13);
			this.label12.TabIndex = 13;
			this.label12.Text = "ID:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.txtEstado);
			this.panel1.Controls.Add(this.navegador1);
			this.panel1.Controls.Add(this.txtidfpago);
			this.panel1.Controls.Add(this.cbxfpago);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.cbxAE);
			this.panel1.Controls.Add(this.cbxidcambio);
			this.panel1.Controls.Add(this.cbxTipocambio);
			this.panel1.Controls.Add(this.cbxApellido);
			this.panel1.Controls.Add(this.cbxNombre);
			this.panel1.Controls.Add(this.txtfechaemision);
			this.panel1.Controls.Add(this.txtidcliente);
			this.panel1.Controls.Add(this.dtpFechaemision);
			this.panel1.Controls.Add(this.rbnVencida);
			this.panel1.Controls.Add(this.rbnActiva);
			this.panel1.Controls.Add(this.cbxCliente);
			this.panel1.Controls.Add(this.txtTotal);
			this.panel1.Controls.Add(this.txtIdfactura);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.lblIdcotizacion);
			this.panel1.Controls.Add(this.lblIdEmpleado);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.lblIdcliente);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(802, 104);
			this.panel1.TabIndex = 14;
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(593, 65);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(19, 20);
			this.txtEstado.TabIndex = 94;
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(-140, -45);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 30);
			this.navegador1.TabIndex = 93;
			// 
			// txtidfpago
			// 
			this.txtidfpago.Location = new System.Drawing.Point(592, 34);
			this.txtidfpago.Name = "txtidfpago";
			this.txtidfpago.Size = new System.Drawing.Size(19, 20);
			this.txtidfpago.TabIndex = 63;
			this.txtidfpago.Visible = false;
			this.txtidfpago.TextChanged += new System.EventHandler(this.txtidfpago_TextChanged);
			// 
			// cbxfpago
			// 
			this.cbxfpago.FormattingEnabled = true;
			this.cbxfpago.Location = new System.Drawing.Point(441, 33);
			this.cbxfpago.Name = "cbxfpago";
			this.cbxfpago.Size = new System.Drawing.Size(145, 21);
			this.cbxfpago.TabIndex = 62;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(353, 36);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(82, 13);
			this.label16.TabIndex = 61;
			this.label16.Text = "Forma de Pago:";
			// 
			// cbxAE
			// 
			this.cbxAE.FormattingEnabled = true;
			this.cbxAE.Location = new System.Drawing.Point(588, 206);
			this.cbxAE.Name = "cbxAE";
			this.cbxAE.Size = new System.Drawing.Size(121, 21);
			this.cbxAE.TabIndex = 59;
			this.cbxAE.Visible = false;
			// 
			// cbxidcambio
			// 
			this.cbxidcambio.FormattingEnabled = true;
			this.cbxidcambio.Location = new System.Drawing.Point(11, 206);
			this.cbxidcambio.Name = "cbxidcambio";
			this.cbxidcambio.Size = new System.Drawing.Size(145, 21);
			this.cbxidcambio.TabIndex = 55;
			this.cbxidcambio.Visible = false;
			// 
			// cbxTipocambio
			// 
			this.cbxTipocambio.FormattingEnabled = true;
			this.cbxTipocambio.Location = new System.Drawing.Point(162, 206);
			this.cbxTipocambio.Name = "cbxTipocambio";
			this.cbxTipocambio.Size = new System.Drawing.Size(145, 21);
			this.cbxTipocambio.TabIndex = 54;
			this.cbxTipocambio.Visible = false;
			// 
			// cbxApellido
			// 
			this.cbxApellido.FormattingEnabled = true;
			this.cbxApellido.Location = new System.Drawing.Point(441, 206);
			this.cbxApellido.Name = "cbxApellido";
			this.cbxApellido.Size = new System.Drawing.Size(121, 21);
			this.cbxApellido.TabIndex = 40;
			this.cbxApellido.Visible = false;
			// 
			// cbxNombre
			// 
			this.cbxNombre.FormattingEnabled = true;
			this.cbxNombre.Location = new System.Drawing.Point(314, 206);
			this.cbxNombre.Name = "cbxNombre";
			this.cbxNombre.Size = new System.Drawing.Size(121, 21);
			this.cbxNombre.TabIndex = 39;
			this.cbxNombre.Visible = false;
			// 
			// txtfechaemision
			// 
			this.txtfechaemision.Location = new System.Drawing.Point(313, 30);
			this.txtfechaemision.Name = "txtfechaemision";
			this.txtfechaemision.Size = new System.Drawing.Size(19, 20);
			this.txtfechaemision.TabIndex = 36;
			this.txtfechaemision.Visible = false;
			this.txtfechaemision.TextChanged += new System.EventHandler(this.txtfechaemision_TextChanged);
			// 
			// txtidcliente
			// 
			this.txtidcliente.Location = new System.Drawing.Point(592, 3);
			this.txtidcliente.Name = "txtidcliente";
			this.txtidcliente.Size = new System.Drawing.Size(19, 20);
			this.txtidcliente.TabIndex = 34;
			this.txtidcliente.Visible = false;
			this.txtidcliente.TextChanged += new System.EventHandler(this.txtidcliente_TextChanged);
			// 
			// dtpFechaemision
			// 
			this.dtpFechaemision.Location = new System.Drawing.Point(107, 30);
			this.dtpFechaemision.Name = "dtpFechaemision";
			this.dtpFechaemision.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaemision.TabIndex = 15;
			this.dtpFechaemision.ValueChanged += new System.EventHandler(this.dtpFechaemision_ValueChanged);
			// 
			// rbnVencida
			// 
			this.rbnVencida.AutoSize = true;
			this.rbnVencida.Location = new System.Drawing.Point(523, 69);
			this.rbnVencida.Name = "rbnVencida";
			this.rbnVencida.Size = new System.Drawing.Size(64, 17);
			this.rbnVencida.TabIndex = 14;
			this.rbnVencida.TabStop = true;
			this.rbnVencida.Text = "Vencida";
			this.rbnVencida.UseVisualStyleBackColor = true;
			this.rbnVencida.CheckedChanged += new System.EventHandler(this.rbnVencida_CheckedChanged);
			// 
			// rbnActiva
			// 
			this.rbnActiva.AutoSize = true;
			this.rbnActiva.Location = new System.Drawing.Point(441, 68);
			this.rbnActiva.Name = "rbnActiva";
			this.rbnActiva.Size = new System.Drawing.Size(55, 17);
			this.rbnActiva.TabIndex = 13;
			this.rbnActiva.TabStop = true;
			this.rbnActiva.Text = "Activa";
			this.rbnActiva.UseVisualStyleBackColor = true;
			this.rbnActiva.CheckedChanged += new System.EventHandler(this.rbnActiva_CheckedChanged);
			// 
			// cbxCliente
			// 
			this.cbxCliente.FormattingEnabled = true;
			this.cbxCliente.Location = new System.Drawing.Point(441, 3);
			this.cbxCliente.Name = "cbxCliente";
			this.cbxCliente.Size = new System.Drawing.Size(145, 21);
			this.cbxCliente.TabIndex = 10;
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(107, 68);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(145, 20);
			this.txtTotal.TabIndex = 9;
			// 
			// txtIdfactura
			// 
			this.txtIdfactura.Enabled = false;
			this.txtIdfactura.Location = new System.Drawing.Point(107, 1);
			this.txtIdfactura.Name = "txtIdfactura";
			this.txtIdfactura.Size = new System.Drawing.Size(145, 20);
			this.txtIdfactura.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(392, 70);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Estado:";
			// 
			// lblIdcotizacion
			// 
			this.lblIdcotizacion.AutoSize = true;
			this.lblIdcotizacion.Location = new System.Drawing.Point(636, 65);
			this.lblIdcotizacion.Name = "lblIdcotizacion";
			this.lblIdcotizacion.Size = new System.Drawing.Size(0, 13);
			this.lblIdcotizacion.TabIndex = 16;
			// 
			// lblIdEmpleado
			// 
			this.lblIdEmpleado.AutoSize = true;
			this.lblIdEmpleado.Location = new System.Drawing.Point(230, 60);
			this.lblIdEmpleado.Name = "lblIdEmpleado";
			this.lblIdEmpleado.Size = new System.Drawing.Size(0, 13);
			this.lblIdEmpleado.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(64, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Total:";
			// 
			// lblIdcliente
			// 
			this.lblIdcliente.AutoSize = true;
			this.lblIdcliente.Location = new System.Drawing.Point(221, 29);
			this.lblIdcliente.Name = "lblIdcliente";
			this.lblIdcliente.Size = new System.Drawing.Size(0, 13);
			this.lblIdcliente.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Fecha de Emisión:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(393, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cliente:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// frmFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 520);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmFacturacion";
			this.Text = "Facturacion";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtgEncabezado)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dtgDetalle;
		private System.Windows.Forms.DataGridView dtgEncabezado;
		private System.Windows.Forms.TextBox txtidps;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.ComboBox cbxPS;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.TextBox txtIddetalle;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtidfpago;
		private System.Windows.Forms.ComboBox cbxfpago;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cbxAE;
		private System.Windows.Forms.ComboBox cbxidcambio;
		private System.Windows.Forms.ComboBox cbxTipocambio;
		private System.Windows.Forms.ComboBox cbxApellido;
		private System.Windows.Forms.ComboBox cbxNombre;
		private System.Windows.Forms.TextBox txtfechaemision;
		private System.Windows.Forms.TextBox txtidcliente;
		private System.Windows.Forms.DateTimePicker dtpFechaemision;
		private System.Windows.Forms.RadioButton rbnVencida;
		private System.Windows.Forms.RadioButton rbnActiva;
		private System.Windows.Forms.ComboBox cbxCliente;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtIdfactura;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblIdcotizacion;
		private System.Windows.Forms.Label lblIdEmpleado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblIdcliente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DLL.nav.navegador navegador1;
		private System.Windows.Forms.TextBox txtEstado;
	}
}