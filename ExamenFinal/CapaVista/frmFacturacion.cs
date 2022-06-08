using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
	public partial class frmFacturacion : Form
	{
		public frmFacturacion()
		{
			InitializeComponent();
			navegador1.LlenarCombobox(cbxCliente, "cliente", "Pkid", "nombre", "estado");
			navegador1.LlenarCombobox(cbxfpago, "formapago", "Pkid", "nombre", "estado");
			navegador1.LlenarCombobox(cbxPS, "producto", "Pkid", "nombre", "estado");
			CapaControlador.Controlador controlador = new CapaControlador.Controlador();
			int id = controlador.idSiguienteDeNuevoIngreso("facturacionEncabezado", "pkId");
			txtIdfactura.Text = id.ToString();
		}
		CapaControlador.Controlador controlador = new CapaControlador.Controlador();
		private void dtpFechaemision_ValueChanged(object sender, EventArgs e)
		{
			try
			{

				navegador1.CambiarFormatoFecha(dtpFechaemision, txtfechaemision);
				navegador1.SeleccionarFechaDTP(dtpFechaemision, txtfechaemision);
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

		private void txtfechaemision_TextChanged(object sender, EventArgs e)
		{
			navegador1.SeleccionarFechaDTP(dtpFechaemision, txtfechaemision);
			navegador1.CambiarFormatoFecha(dtpFechaemision, txtfechaemision);
		}

		private void txtidcliente_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtidfpago_TextChanged(object sender, EventArgs e)
		{
		}

		private void txtidps_TextChanged(object sender, EventArgs e)
		{

			string stock = controlador.stockProducto(txtidps.Text.ToString());
			txtStock.Text = stock;
		}

		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnActiva, rbnVencida, txtEstado);
		}

		private void rbnActiva_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtEstado, rbnActiva, "1");
		}

		private void rbnVencida_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtEstado, rbnVencida, "0");
		}

		private void cbxPS_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtidps.Text = controlador.idProducto(cbxPS.Text);
		}
	}
}
