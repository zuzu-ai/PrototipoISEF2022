using CapaControladorSeguridadHSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitacoraUsuario;
using static datosUsuario;

namespace CapaVistaSeguridadHSC
{
    public partial class frmMantenimientoUsuario : Form
    {
        public frmMantenimientoUsuario()
        {
            InitializeComponent();
            LimparlblContraseña();
            //Usuario
            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "usuario", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);
            // navegador1.funLlenarComboControl(cbxCodMarca, "marcaP", "idMarca", "nombre", "estatus");

            //inicio de elementos para dar de baja
            navegador1.campoEstado = "Estado";
            //fin de elementos para dar de baja

            /* Inicio ID Aplicacion usada para reportes y ayudas */
            navegador1.idAplicacion = "1002";
            /* Inicio ID Aplicacion usada para reportes y ayudas */

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda


            // Inicio datos para ejecurar reportes
            navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes

            navegador1.ObtenerNombreDGV(this.dtgUsuarios);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);
        }
        private ObtenerPermisos global = new ObtenerPermisos();
        private void btnPassword_Click(object sender, EventArgs e)
        {
            Controlador s = new Controlador();
            Encriptar a = new Encriptar();
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            string hash = a.metodoDecryptString(key, txtContraseña.Text.Trim());
            lblContraseña.Text = hash.ToString();
            txtContraseña.UseSystemPasswordChar = false;
            lblContraseña.Visible = true;
            btnPassword.Visible = false;
            btnPasswordn.Visible = true;          
        }

        private void btnPasswordn_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            lblContraseña.Visible = false;
            btnPassword.Visible = true;
            btnPasswordn.Visible = false;
            lblContraseña.Text = "";
        }          
        private void rbnActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstatus, rbnHabilitado, "1");
        }
        private void rbnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstatus, rbnInhabilitado, "0");
        }
        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.ActivaRadiobtn(rbnHabilitado, rbnInhabilitado, txtEstatus);
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                frmConfirmarContraseña form3 = new frmConfirmarContraseña();
                form3.MdiParent = this.MdiParent;
                form3.Show();
            }
        }
        private void LimparlblContraseña()
        {
            if (txtUsuario.Text == "")
            {
                lblContraseña.Text = "";
            }
        }

        public void txtContraseña_Enter(object sender, EventArgs e)
        {
            try
            {
                txtContraseña.Text = global.Hash.ToString();
            }
            catch { }
        }
        private void dvgConsulta_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dtgUsuarios);
        }

    }
}
