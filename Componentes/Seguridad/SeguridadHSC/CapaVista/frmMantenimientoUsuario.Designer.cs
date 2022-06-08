
namespace CapaVistaSeguridadHSC
{
    partial class frmMantenimientoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoUsuario));
            this.navegador1 = new DLL.nav.navegador();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.labeldireccioncliente = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.labelestadocliente = new System.Windows.Forms.Label();
            this.labelapellidocliente = new System.Windows.Forms.Label();
            this.labelnombrecliente = new System.Windows.Forms.Label();
            this.labelidcliente = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnPasswordn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(278, 306);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(52, 26);
            this.txtEstatus.TabIndex = 67;
            this.txtEstatus.Tag = "Estado";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(111, 236);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(220, 26);
            this.txtContraseña.TabIndex = 71;
            this.txtContraseña.Tag = "contraseña";
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(111, 198);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 26);
            this.txtUsuario.TabIndex = 68;
            this.txtUsuario.Tag = "nombre";
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(111, 161);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(220, 26);
            this.txtIdEmpleado.TabIndex = 73;
            this.txtIdEmpleado.Tag = "fkIdEmpleado";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(111, 124);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(220, 26);
            this.txtIdUsuario.TabIndex = 66;
            this.txtIdUsuario.Tag = "pkId";
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(50, 307);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 65;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(154, 308);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 74;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // labeldireccioncliente
            // 
            this.labeldireccioncliente.AutoSize = true;
            this.labeldireccioncliente.BackColor = System.Drawing.Color.Transparent;
            this.labeldireccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccioncliente.Location = new System.Drawing.Point(7, 164);
            this.labeldireccioncliente.Name = "labeldireccioncliente";
            this.labeldireccioncliente.Size = new System.Drawing.Size(106, 20);
            this.labeldireccioncliente.TabIndex = 79;
            this.labeldireccioncliente.Text = "ID Empleado:";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(365, 95);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(154, 20);
            this.labelClientes.TabIndex = 76;
            this.labelClientes.Text = "Usuario Registrados";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(369, 124);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(794, 381);
            this.dtgUsuarios.TabIndex = 75;
            this.dtgUsuarios.SelectionChanged += new System.EventHandler(this.dvgConsulta_SelectionChanged);
            // 
            // labelestadocliente
            // 
            this.labelestadocliente.AutoSize = true;
            this.labelestadocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelestadocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadocliente.Location = new System.Drawing.Point(12, 278);
            this.labelestadocliente.Name = "labelestadocliente";
            this.labelestadocliente.Size = new System.Drawing.Size(64, 20);
            this.labelestadocliente.TabIndex = 64;
            this.labelestadocliente.Text = "Estado:";
            // 
            // labelapellidocliente
            // 
            this.labelapellidocliente.AutoSize = true;
            this.labelapellidocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelapellidocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellidocliente.Location = new System.Drawing.Point(7, 239);
            this.labelapellidocliente.Name = "labelapellidocliente";
            this.labelapellidocliente.Size = new System.Drawing.Size(96, 20);
            this.labelapellidocliente.TabIndex = 63;
            this.labelapellidocliente.Text = "Contraseña:";
            // 
            // labelnombrecliente
            // 
            this.labelnombrecliente.AutoSize = true;
            this.labelnombrecliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrecliente.Location = new System.Drawing.Point(8, 202);
            this.labelnombrecliente.Name = "labelnombrecliente";
            this.labelnombrecliente.Size = new System.Drawing.Size(68, 20);
            this.labelnombrecliente.TabIndex = 62;
            this.labelnombrecliente.Text = "Usuario:";
            // 
            // labelidcliente
            // 
            this.labelidcliente.AutoSize = true;
            this.labelidcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidcliente.Location = new System.Drawing.Point(8, 130);
            this.labelidcliente.Name = "labelidcliente";
            this.labelidcliente.Size = new System.Drawing.Size(30, 20);
            this.labelidcliente.TabIndex = 61;
            this.labelidcliente.Text = "ID:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContraseña.Location = new System.Drawing.Point(139, 266);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(0, 20);
            this.lblContraseña.TabIndex = 85;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.see__1_;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(337, 234);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(19, 19);
            this.btnPassword.TabIndex = 84;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnPasswordn
            // 
            this.btnPasswordn.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordn.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.hide__1_;
            this.btnPasswordn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordn.FlatAppearance.BorderSize = 0;
            this.btnPasswordn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordn.Location = new System.Drawing.Point(337, 235);
            this.btnPasswordn.Name = "btnPasswordn";
            this.btnPasswordn.Size = new System.Drawing.Size(19, 19);
            this.btnPasswordn.TabIndex = 82;
            this.btnPasswordn.UseVisualStyleBackColor = false;
            this.btnPasswordn.Visible = false;
            this.btnPasswordn.Click += new System.EventHandler(this.btnPasswordn_Click);
            // 
            // frmMantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 526);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnPasswordn);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.labeldireccioncliente);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.labelestadocliente);
            this.Controls.Add(this.labelapellidocliente);
            this.Controls.Add(this.labelnombrecliente);
            this.Controls.Add(this.labelidcliente);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.Label labeldireccioncliente;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Label labelestadocliente;
        private System.Windows.Forms.Label labelapellidocliente;
        private System.Windows.Forms.Label labelnombrecliente;
        private System.Windows.Forms.Label labelidcliente;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnPasswordn;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.Label lblContraseña;
    }
}