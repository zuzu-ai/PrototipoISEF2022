
namespace CapaVistaSeguridadHSC
{
	partial class frmModulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModulo));
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtDescripcionmodulo = new System.Windows.Forms.TextBox();
			this.txtNombremodulo = new System.Windows.Forms.TextBox();
			this.txtIdmodulo = new System.Windows.Forms.TextBox();
			this.dtgModulo = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
			this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.navegador1 = new DLL.nav.navegador();
			((System.ComponentModel.ISupportInitialize)(this.dtgModulo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(348, 254);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(32, 20);
			this.txtEstado.TabIndex = 49;
			this.txtEstado.Tag = "estado";
			this.txtEstado.Visible = false;
			this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
			// 
			// txtDescripcionmodulo
			// 
			this.txtDescripcionmodulo.Location = new System.Drawing.Point(99, 208);
			this.txtDescripcionmodulo.Name = "txtDescripcionmodulo";
			this.txtDescripcionmodulo.Size = new System.Drawing.Size(216, 20);
			this.txtDescripcionmodulo.TabIndex = 45;
			this.txtDescripcionmodulo.Tag = "descripcion";
			// 
			// txtNombremodulo
			// 
			this.txtNombremodulo.Location = new System.Drawing.Point(99, 157);
			this.txtNombremodulo.Name = "txtNombremodulo";
			this.txtNombremodulo.Size = new System.Drawing.Size(216, 20);
			this.txtNombremodulo.TabIndex = 46;
			this.txtNombremodulo.Tag = "nombre";
			// 
			// txtIdmodulo
			// 
			this.txtIdmodulo.Location = new System.Drawing.Point(99, 112);
			this.txtIdmodulo.Name = "txtIdmodulo";
			this.txtIdmodulo.Size = new System.Drawing.Size(216, 20);
			this.txtIdmodulo.TabIndex = 47;
			this.txtIdmodulo.Tag = "pkid";
			// 
			// dtgModulo
			// 
			this.dtgModulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgModulo.Location = new System.Drawing.Point(466, 119);
			this.dtgModulo.Name = "dtgModulo";
			this.dtgModulo.Size = new System.Drawing.Size(634, 183);
			this.dtgModulo.TabIndex = 50;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbnEstatusamodulo);
			this.panel1.Controls.Add(this.rbnEstatusimodulo);
			this.panel1.Location = new System.Drawing.Point(99, 250);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 30);
			this.panel1.TabIndex = 48;
			// 
			// rbnEstatusamodulo
			// 
			this.rbnEstatusamodulo.AutoSize = true;
			this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
			this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
			this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
			this.rbnEstatusamodulo.TabIndex = 8;
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
			this.rbnEstatusimodulo.TabIndex = 9;
			this.rbnEstatusimodulo.TabStop = true;
			this.rbnEstatusimodulo.Text = "Inactivo";
			this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
			this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 261);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 44;
			this.label4.Text = "Estatus:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 211);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 43;
			this.label3.Text = "Descripción:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 42;
			this.label2.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 41;
			this.label1.Text = "ID:";
			// 
			// navegador1
			// 
			this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.navegador1.Location = new System.Drawing.Point(0, -1);
			this.navegador1.Name = "navegador1";
			this.navegador1.Size = new System.Drawing.Size(1189, 87);
			this.navegador1.TabIndex = 40;
			// 
			// frmModulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 311);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtDescripcionmodulo);
			this.Controls.Add(this.txtNombremodulo);
			this.Controls.Add(this.txtIdmodulo);
			this.Controls.Add(this.dtgModulo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.navegador1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmModulo";
			this.Text = "0012 Mantenimiento Módulo";
			((System.ComponentModel.ISupportInitialize)(this.dtgModulo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtDescripcionmodulo;
		private System.Windows.Forms.TextBox txtNombremodulo;
		private System.Windows.Forms.TextBox txtIdmodulo;
		private System.Windows.Forms.DataGridView dtgModulo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbnEstatusamodulo;
		private System.Windows.Forms.RadioButton rbnEstatusimodulo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private DLL.nav.navegador navegador1;
	}
}