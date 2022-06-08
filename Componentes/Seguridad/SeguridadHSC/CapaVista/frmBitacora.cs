using BitacoraUsuario;
using System;
using System.Data;
using System.Windows.Forms;
using static datosUsuario;

namespace CapaVistaSeguridadHSC
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
            actualizardatagriew();
        }

        public void actualizardatagriew()
        {
            CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
            DataTable dt = bitacora.llenarTblBitacora("bitacorausuario");
            dataBitacora.DataSource = dt;
        }

        private void btnActualizarBitacora_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
            CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
            bitacora.guardarEnBitacora(IdUsuario, "1", "0011", "Actualizar Bitácora");
            
        }
    }
}