namespace Proyecto
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnl_TituloLigin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblErrorVacio = new System.Windows.Forms.Label();
            this.picMostrar = new System.Windows.Forms.PictureBox();
            this.picOcultar = new System.Windows.Forms.PictureBox();
            this.pnl_TituloLigin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(81, 143);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(251, 42);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Inicio de Sesion";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F);
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(56, 221);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(90, 29);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Usuario:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Yu Gothic Light", 16.25F);
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(22, 273);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(124, 29);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Yu Gothic Light", 12F);
            this.txtUser.Location = new System.Drawing.Point(152, 217);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(189, 33);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPass.Location = new System.Drawing.Point(152, 273);
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
            this.btnConfirmar.Location = new System.Drawing.Point(26, 340);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(351, 42);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Iniciar Sesion";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Yu Gothic Light", 10.25F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 385);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(318, 18);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error: Credeciales no coinciden , intentos restantes:";
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
            this.lblErrorVacio.Location = new System.Drawing.Point(47, 403);
            this.lblErrorVacio.Name = "lblErrorVacio";
            this.lblErrorVacio.Size = new System.Drawing.Size(222, 72);
            this.lblErrorVacio.TabIndex = 12;
            this.lblErrorVacio.Text = "Error :\r\nNo puede dejar espacios en blanco\r\n\r\n\r\n";
            this.lblErrorVacio.Visible = false;
            // 
            // picMostrar
            // 
            this.picMostrar.BackColor = System.Drawing.Color.White;
            this.picMostrar.Image = global::Proyecto.Properties.Resources.icons8_eye_48__1_;
            this.picMostrar.Location = new System.Drawing.Point(299, 277);
            this.picMostrar.Name = "picMostrar";
            this.picMostrar.Size = new System.Drawing.Size(33, 25);
            this.picMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrar.TabIndex = 13;
            this.picMostrar.TabStop = false;
            this.picMostrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMostrar_MouseClick);
            // 
            // picOcultar
            // 
            this.picOcultar.BackColor = System.Drawing.Color.White;
            this.picOcultar.Image = global::Proyecto.Properties.Resources.icons8_closed_eye_48__1_;
            this.picOcultar.Location = new System.Drawing.Point(299, 277);
            this.picOcultar.Name = "picOcultar";
            this.picOcultar.Size = new System.Drawing.Size(33, 25);
            this.picOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultar.TabIndex = 14;
            this.picOcultar.TabStop = false;
            this.picOcultar.Visible = false;
            this.picOcultar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOcultar_MouseClick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Proyecto.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(417, 477);
            this.Controls.Add(this.picOcultar);
            this.Controls.Add(this.picMostrar);
            this.Controls.Add(this.lblErrorVacio);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnl_TituloLigin);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnl_TituloLigin.ResumeLayout(false);
            this.pnl_TituloLigin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.Panel pnl_TituloLigin;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblErrorVacio;
        private System.Windows.Forms.PictureBox picMostrar;
        private System.Windows.Forms.PictureBox picOcultar;
    }
}