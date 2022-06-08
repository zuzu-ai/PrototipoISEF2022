using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorSeguridadHSC;


namespace CapaVistaSeguridadHSC
{
    public partial class frmConfirmarContraseña : Form
    {
        private ObtenerPermisos global = new ObtenerPermisos();
        public frmConfirmarContraseña()
        {
            InitializeComponent();
        }
        public void metodoValidarContraseña()
        {
            if (txtClave.Text.Trim() != "")
            {
                lblUsuario.Text = "";
                adUser.Visible = false;
            }
            else
            {
                lblUsuario.Text = "Debe ingresar una contraseña.";
                adUser.Visible = true;
                txtClave.Focus();
            }
        }
        //Kevin Flores 9959-18-17632
        public void metodoValidarCoincidencia()
        {
            if (txtClave.Text.Trim() != txtConfirmar.Text.Trim())
            {
                lblClave.Text = "Las contraseñas no coinciden.";
                txtConfirmar.Text = "";
                adClave.Visible = true;
                txtClave.Focus();
            }
            else
            {
                metodoEncriptarContraseña();
                lblClave.Text = "";
                adClave.Visible = false;
                
                this.Close();
            }
        }
        public void metodoEncriptarContraseña()
        {
            try
            {   
                Controlador s = new Controlador();
                Encriptar a = new Encriptar();
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                string hash = a.metodoEncryptString(key, txtClave.Text);
                txtHash.Text = hash.ToString();
                global.Hash=txtHash.Text;
                MessageBox.Show(hash);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consular usuario:  " + ex);
             }

        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = false;
            txtConfirmar.UseSystemPasswordChar = false;
            btnPassword.Visible = false;
            btnPasswordn.Visible = true;
        }
        private void btnPasswordn_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;
            btnPassword.Visible = true;
            btnPasswordn.Visible = false;
        }
        public void txtClave_TextChanged(object sender, EventArgs e)
        {
            metodoValidarContraseña();
        }

        public void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            metodoValidarCoincidencia();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            metodoValidarCoincidencia();

        }
       

    }
}
