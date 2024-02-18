namespace Proyecto
{
    partial class FormLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnl_TituloLigin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lbldevnow = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblErrorVacio = new System.Windows.Forms.Label();
            this.pnl_TituloLigin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Yu Gothic Light", 36.25F);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(43, 125);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(353, 63);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Inicio de Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(83, 195);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 29);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F);
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(49, 251);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(124, 29);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Yu Gothic Light", 12F);
            this.txtUser.Location = new System.Drawing.Point(179, 191);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(189, 33);
            this.txtUser.TabIndex = 3;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(179, 247);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(189, 33);
            this.txtPass.TabIndex = 4;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(26, 292);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(351, 42);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Yu Gothic Light", 10.25F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(33, 337);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(195, 72);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error de Inicio de Sesion:\r\nLas Credenciales no Coinciden\r\nIntentos restantes:\r\n\r" +
    "\n";
            this.lblError.Visible = false;
            // 
            // pnl_TituloLigin
            // 
            this.pnl_TituloLigin.Controls.Add(this.lblTitulo);
            this.pnl_TituloLigin.Controls.Add(this.pbxSalir);
            this.pnl_TituloLigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TituloLigin.Location = new System.Drawing.Point(0, 0);
            this.pnl_TituloLigin.Name = "pnl_TituloLigin";
            this.pnl_TituloLigin.Size = new System.Drawing.Size(417, 42);
            this.pnl_TituloLigin.TabIndex = 8;
            this.pnl_TituloLigin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TituloLigin_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(81, 29);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "CoFruit";
            // 
            // pbxSalir
            // 
            this.pbxSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalir.Image = global::Proyecto.Properties.Resources.cerrar;
            this.pbxSalir.Location = new System.Drawing.Point(371, 0);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(43, 39);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 7;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Proyecto.Properties.Resources.Devnow_Logo;
            this.pcbLogo.Location = new System.Drawing.Point(318, 398);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(99, 85);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 9;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.Click += new System.EventHandler(this.pcbLogo_Click);
            // 
            // lbldevnow
            // 
            this.lbldevnow.AutoSize = true;
            this.lbldevnow.BackColor = System.Drawing.Color.Transparent;
            this.lbldevnow.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F);
            this.lbldevnow.ForeColor = System.Drawing.Color.White;
            this.lbldevnow.Location = new System.Drawing.Point(195, 445);
            this.lbldevnow.Name = "lbldevnow";
            this.lbldevnow.Size = new System.Drawing.Size(117, 29);
            this.lbldevnow.TabIndex = 10;
            this.lbldevnow.Text = "creado por:";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Proyecto.Properties.Resources.LogoCoFruit;
            this.picLogo.Location = new System.Drawing.Point(88, 48);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(231, 74);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // lblErrorVacio
            // 
            this.lblErrorVacio.AutoSize = true;
            this.lblErrorVacio.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorVacio.Font = new System.Drawing.Font("Yu Gothic Light", 10.25F);
            this.lblErrorVacio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorVacio.Location = new System.Drawing.Point(33, 337);
            this.lblErrorVacio.Name = "lblErrorVacio";
            this.lblErrorVacio.Size = new System.Drawing.Size(222, 72);
            this.lblErrorVacio.TabIndex = 12;
            this.lblErrorVacio.Text = "Error de Inicio de Sesion:\r\nNo puede dejar espacios en blanco\r\n\r\n\r\n";
            this.lblErrorVacio.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Proyecto.Properties.Resources.photo_1530878902700_5ad4f9e4c318;
            this.ClientSize = new System.Drawing.Size(417, 477);
            this.Controls.Add(this.lblErrorVacio);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lbldevnow);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pnl_TituloLigin);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnl_TituloLigin.ResumeLayout(false);
            this.pnl_TituloLigin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.Panel pnl_TituloLigin;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lbldevnow;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblErrorVacio;
    }
}