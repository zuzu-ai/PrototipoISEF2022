
namespace CapaVistaSeguridadHSC
{
    partial class frmLoginHSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginHSC));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnPasswordn = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.adUser = new System.Windows.Forms.Panel();
            this.adClave = new System.Windows.Forms.Panel();
            this.lkbRecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtIdFoto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(153, 332);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 19);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.EnabledChanged += new System.EventHandler(this.txtUsuario_EnabledChanged);
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClave.Location = new System.Drawing.Point(153, 404);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(163, 19);
            this.txtClave.TabIndex = 0;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // btnPasswordn
            // 
            this.btnPasswordn.BackColor = System.Drawing.Color.Transparent;
            this.btnPasswordn.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.hide__1_;
            this.btnPasswordn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordn.FlatAppearance.BorderSize = 0;
            this.btnPasswordn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordn.Location = new System.Drawing.Point(322, 405);
            this.btnPasswordn.Name = "btnPasswordn";
            this.btnPasswordn.Size = new System.Drawing.Size(19, 19);
            this.btnPasswordn.TabIndex = 1;
            this.btnPasswordn.UseVisualStyleBackColor = false;
            this.btnPasswordn.Visible = false;
            this.btnPasswordn.Click += new System.EventHandler(this.btnPasswordn_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.ask_question_32px;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(0, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 34);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.login_50px;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Location = new System.Drawing.Point(361, 400);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(31, 31);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.see__1_;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(322, 405);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(19, 19);
            this.btnPassword.TabIndex = 2;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(149, 368);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClave.ForeColor = System.Drawing.Color.Transparent;
            this.lblClave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClave.Location = new System.Drawing.Point(149, 440);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(0, 17);
            this.lblClave.TabIndex = 3;
            this.lblClave.Click += new System.EventHandler(this.label1_Click);
            // 
            // adUser
            // 
            this.adUser.BackColor = System.Drawing.Color.Transparent;
            this.adUser.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.error;
            this.adUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adUser.Location = new System.Drawing.Point(127, 366);
            this.adUser.Name = "adUser";
            this.adUser.Size = new System.Drawing.Size(19, 20);
            this.adUser.TabIndex = 5;
            this.adUser.Visible = false;
            // 
            // adClave
            // 
            this.adClave.BackColor = System.Drawing.Color.Transparent;
            this.adClave.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.error;
            this.adClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adClave.Location = new System.Drawing.Point(127, 438);
            this.adClave.Name = "adClave";
            this.adClave.Size = new System.Drawing.Size(19, 20);
            this.adClave.TabIndex = 5;
            this.adClave.Visible = false;
            // 
            // lkbRecuperarContraseña
            // 
            this.lkbRecuperarContraseña.AutoSize = true;
            this.lkbRecuperarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lkbRecuperarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbRecuperarContraseña.LinkColor = System.Drawing.Color.LightGray;
            this.lkbRecuperarContraseña.Location = new System.Drawing.Point(149, 517);
            this.lkbRecuperarContraseña.Name = "lkbRecuperarContraseña";
            this.lkbRecuperarContraseña.Size = new System.Drawing.Size(187, 16);
            this.lkbRecuperarContraseña.TabIndex = 6;
            this.lkbRecuperarContraseña.TabStop = true;
            this.lkbRecuperarContraseña.Text = "¿Has olvidado la contraseña?";
            this.lkbRecuperarContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbRecuperarContraseña_LinkClicked);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(121, 160);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(225, 147);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // txtIdFoto
            // 
            this.txtIdFoto.Enabled = false;
            this.txtIdFoto.Location = new System.Drawing.Point(358, 285);
            this.txtIdFoto.Name = "txtIdFoto";
            this.txtIdFoto.Size = new System.Drawing.Size(32, 20);
            this.txtIdFoto.TabIndex = 117;
            this.txtIdFoto.TabStop = false;
            this.txtIdFoto.Tag = "logo";
            this.txtIdFoto.Visible = false;
            this.txtIdFoto.TextChanged += new System.EventHandler(this.txtIdFoto_TextChanged);
            // 
            // frmLoginHSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(471, 590);
            this.Controls.Add(this.txtIdFoto);
            this.Controls.Add(this.lkbRecuperarContraseña);
            this.Controls.Add(this.adClave);
            this.Controls.Add(this.adUser);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnPasswordn);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnAyuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoginHSC";
            this.Text = "0001 LoginHSC";
            this.Load += new System.EventHandler(this.frmLoginHSC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnPasswordn;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel adUser;
        private System.Windows.Forms.Panel adClave;
        private System.Windows.Forms.LinkLabel lkbRecuperarContraseña;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtIdFoto;
    }
}