
namespace CapaVistaSeguridadHSC
{
    partial class frmConfirmarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmarContraseña));
            this.adClave = new System.Windows.Forms.Panel();
            this.adUser = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnPasswordn = new System.Windows.Forms.Button();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnitcliente = new System.Windows.Forms.Label();
            this.labelapellidocliente = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adClave
            // 
            this.adClave.BackColor = System.Drawing.Color.Transparent;
            this.adClave.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.error;
            this.adClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adClave.Location = new System.Drawing.Point(138, 133);
            this.adClave.Name = "adClave";
            this.adClave.Size = new System.Drawing.Size(19, 20);
            this.adClave.TabIndex = 100;
            this.adClave.Visible = false;
            // 
            // adUser
            // 
            this.adUser.BackColor = System.Drawing.Color.Transparent;
            this.adUser.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.error;
            this.adUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adUser.Location = new System.Drawing.Point(137, 81);
            this.adUser.Name = "adUser";
            this.adUser.Size = new System.Drawing.Size(19, 20);
            this.adUser.TabIndex = 101;
            this.adUser.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(162, 86);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 98;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblClave.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblClave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClave.Location = new System.Drawing.Point(163, 136);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(0, 17);
            this.lblClave.TabIndex = 99;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImage = global::CapaVistaSeguridadHSC.Properties.Resources.see__1_;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(360, 55);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(19, 19);
            this.btnPassword.TabIndex = 97;
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
            this.btnPasswordn.Location = new System.Drawing.Point(360, 55);
            this.btnPasswordn.Name = "btnPasswordn";
            this.btnPasswordn.Size = new System.Drawing.Size(19, 19);
            this.btnPasswordn.TabIndex = 96;
            this.btnPasswordn.UseVisualStyleBackColor = false;
            this.btnPasswordn.Visible = false;
            this.btnPasswordn.Click += new System.EventHandler(this.btnPasswordn_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Location = new System.Drawing.Point(134, 105);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(220, 26);
            this.txtConfirmar.TabIndex = 93;
            this.txtConfirmar.Tag = "";
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(134, 55);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(220, 26);
            this.txtClave.TabIndex = 92;
            this.txtClave.Tag = "";
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "contraseña:";
            // 
            // labelnitcliente
            // 
            this.labelnitcliente.AutoSize = true;
            this.labelnitcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnitcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnitcliente.Location = new System.Drawing.Point(31, 91);
            this.labelnitcliente.Name = "labelnitcliente";
            this.labelnitcliente.Size = new System.Drawing.Size(82, 20);
            this.labelnitcliente.TabIndex = 95;
            this.labelnitcliente.Text = "Confirmar ";
            // 
            // labelapellidocliente
            // 
            this.labelapellidocliente.AutoSize = true;
            this.labelapellidocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelapellidocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellidocliente.Location = new System.Drawing.Point(30, 59);
            this.labelapellidocliente.Name = "labelapellidocliente";
            this.labelapellidocliente.Size = new System.Drawing.Size(96, 20);
            this.labelapellidocliente.TabIndex = 91;
            this.labelapellidocliente.Text = "Contraseña:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(121, 181);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 102;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(242, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(134, 155);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(220, 20);
            this.txtHash.TabIndex = 103;
            this.txtHash.Visible = false;
            // 
            // frmConfirmarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 226);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.adClave);
            this.Controls.Add(this.adUser);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnPasswordn);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnitcliente);
            this.Controls.Add(this.labelapellidocliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adClave;
        private System.Windows.Forms.Panel adUser;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnPasswordn;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnitcliente;
        private System.Windows.Forms.Label labelapellidocliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtHash;
    }
}