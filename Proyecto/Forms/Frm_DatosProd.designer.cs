namespace Proyecto
{
    partial class Frm_DatosProd
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.pblCompra = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.fechahora = new System.Windows.Forms.Timer(this.components);
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlDatosActual = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.lblci = new System.Windows.Forms.Label();
            this.lbluser1 = new System.Windows.Forms.Label();
            this.txtActUser = new System.Windows.Forms.TextBox();
            this.txtActPass = new System.Windows.Forms.TextBox();
            this.lblpass1 = new System.Windows.Forms.Label();
            this.lblnombact = new System.Windows.Forms.Label();
            this.lbltelact = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.lblcalleact = new System.Windows.Forms.Label();
            this.txtTelAct = new System.Windows.Forms.TextBox();
            this.txtCalleAct = new System.Windows.Forms.TextBox();
            this.txtApeAct = new System.Windows.Forms.TextBox();
            this.txtNpAtc = new System.Windows.Forms.TextBox();
            this.lblnpact = new System.Windows.Forms.Label();
            this.lblapeact = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.pnlDatosActual.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBarraTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 44);
            this.panel1.TabIndex = 0;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBarraTitulo.Controls.Add(this.picRes);
            this.pnlBarraTitulo.Controls.Add(this.picMin);
            this.pnlBarraTitulo.Controls.Add(this.pcbLogo);
            this.pnlBarraTitulo.Controls.Add(this.picMax);
            this.pnlBarraTitulo.Controls.Add(this.pblCompra);
            this.pnlBarraTitulo.Controls.Add(this.picCerrar);
            this.pnlBarraTitulo.Controls.Add(this.lblBarraTitulo);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(648, 44);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_resize_48;
            this.picRes.Location = new System.Drawing.Point(571, 6);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(34, 35);
            this.picRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRes.TabIndex = 29;
            this.picRes.TabStop = false;
            this.picRes.Visible = false;
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Proyecto.Properties.Resources.icons8_subtract_48;
            this.picMin.Location = new System.Drawing.Point(531, 6);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(34, 35);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 30;
            this.picMin.TabStop = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::Proyecto.Properties.Resources.LogoCoFruit;
            this.pcbLogo.Location = new System.Drawing.Point(0, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(45, 44);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 7;
            this.pcbLogo.TabStop = false;
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMax.Image = global::Proyecto.Properties.Resources.icons8_maximize_window_48;
            this.picMax.Location = new System.Drawing.Point(571, 6);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(34, 35);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMax.TabIndex = 28;
            this.picMax.TabStop = false;
            // 
            // pblCompra
            // 
            this.pblCompra.BackColor = System.Drawing.Color.White;
            this.pblCompra.Location = new System.Drawing.Point(447, 44);
            this.pblCompra.Name = "pblCompra";
            this.pblCompra.Size = new System.Drawing.Size(900, 537);
            this.pblCompra.TabIndex = 4;
            this.pblCompra.Visible = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.icons8_close_48;
            this.picCerrar.Location = new System.Drawing.Point(611, 6);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 35);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 27;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click_1);
            // 
            // lblBarraTitulo
            // 
            this.lblBarraTitulo.AutoSize = true;
            this.lblBarraTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraTitulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblBarraTitulo.Location = new System.Drawing.Point(51, 13);
            this.lblBarraTitulo.Name = "lblBarraTitulo";
            this.lblBarraTitulo.Size = new System.Drawing.Size(71, 24);
            this.lblBarraTitulo.TabIndex = 4;
            this.lblBarraTitulo.Text = "CoFruit";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnVolver.Image = global::Proyecto.Properties.Resources.login_arrow_symbol_entering_back_into_a_square_icon_icons_com_73221;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(30, 563);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 51);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // fechahora
            // 
            this.fechahora.Enabled = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(26, 324);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(361, 51);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.Text = "Actualizar Datos";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlDatosActual
            // 
            this.pnlDatosActual.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosActual.Controls.Add(this.txtCI);
            this.pnlDatosActual.Controls.Add(this.lblci);
            this.pnlDatosActual.Controls.Add(this.lbluser1);
            this.pnlDatosActual.Controls.Add(this.txtActUser);
            this.pnlDatosActual.Controls.Add(this.btnConfirmar);
            this.pnlDatosActual.Controls.Add(this.txtActPass);
            this.pnlDatosActual.Controls.Add(this.lblpass1);
            this.pnlDatosActual.Controls.Add(this.lblnombact);
            this.pnlDatosActual.Controls.Add(this.lbltelact);
            this.pnlDatosActual.Controls.Add(this.txtNombreAct);
            this.pnlDatosActual.Controls.Add(this.lblcalleact);
            this.pnlDatosActual.Controls.Add(this.txtTelAct);
            this.pnlDatosActual.Controls.Add(this.txtCalleAct);
            this.pnlDatosActual.Controls.Add(this.txtApeAct);
            this.pnlDatosActual.Controls.Add(this.txtNpAtc);
            this.pnlDatosActual.Controls.Add(this.lblnpact);
            this.pnlDatosActual.Controls.Add(this.lblapeact);
            this.pnlDatosActual.Location = new System.Drawing.Point(110, 126);
            this.pnlDatosActual.Name = "pnlDatosActual";
            this.pnlDatosActual.Size = new System.Drawing.Size(422, 392);
            this.pnlDatosActual.TabIndex = 26;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(231, 554);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(353, 60);
            this.btnMostrar.TabIndex = 33;
            this.btnMostrar.Text = "Mostrar Datos Actuales";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtCI
            // 
            this.txtCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtCI.Location = new System.Drawing.Point(229, 13);
            this.txtCI.Name = "txtCI";
            this.txtCI.ReadOnly = true;
            this.txtCI.Size = new System.Drawing.Size(158, 26);
            this.txtCI.TabIndex = 33;
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCI_KeyPress);
            // 
            // lblci
            // 
            this.lblci.AutoSize = true;
            this.lblci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblci.ForeColor = System.Drawing.Color.White;
            this.lblci.Location = new System.Drawing.Point(33, 16);
            this.lblci.Name = "lblci";
            this.lblci.Size = new System.Drawing.Size(32, 20);
            this.lblci.TabIndex = 32;
            this.lblci.Text = "CI;";
            // 
            // lbluser1
            // 
            this.lbluser1.AutoSize = true;
            this.lbluser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser1.ForeColor = System.Drawing.Color.White;
            this.lbluser1.Location = new System.Drawing.Point(31, 278);
            this.lbluser1.Name = "lbluser1";
            this.lbluser1.Size = new System.Drawing.Size(71, 20);
            this.lbluser1.TabIndex = 31;
            this.lbluser1.Text = "Usuario";
            // 
            // txtActUser
            // 
            this.txtActUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtActUser.Location = new System.Drawing.Point(228, 274);
            this.txtActUser.MaxLength = 15;
            this.txtActUser.Name = "txtActUser";
            this.txtActUser.Size = new System.Drawing.Size(158, 26);
            this.txtActUser.TabIndex = 30;
            // 
            // txtActPass
            // 
            this.txtActPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtActPass.Location = new System.Drawing.Point(229, 239);
            this.txtActPass.MaxLength = 15;
            this.txtActPass.Name = "txtActPass";
            this.txtActPass.Size = new System.Drawing.Size(158, 26);
            this.txtActPass.TabIndex = 28;
            // 
            // lblpass1
            // 
            this.lblpass1.AutoSize = true;
            this.lblpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass1.ForeColor = System.Drawing.Color.White;
            this.lblpass1.Location = new System.Drawing.Point(31, 242);
            this.lblpass1.Name = "lblpass1";
            this.lblpass1.Size = new System.Drawing.Size(102, 20);
            this.lblpass1.TabIndex = 29;
            this.lblpass1.Text = "Contraseña";
            // 
            // lblnombact
            // 
            this.lblnombact.AutoSize = true;
            this.lblnombact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombact.ForeColor = System.Drawing.Color.White;
            this.lblnombact.Location = new System.Drawing.Point(33, 50);
            this.lblnombact.Name = "lblnombact";
            this.lblnombact.Size = new System.Drawing.Size(76, 20);
            this.lblnombact.TabIndex = 17;
            this.lblnombact.Text = "Nombre ";
            // 
            // lbltelact
            // 
            this.lbltelact.AutoSize = true;
            this.lbltelact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelact.ForeColor = System.Drawing.Color.White;
            this.lbltelact.Location = new System.Drawing.Point(30, 132);
            this.lbltelact.Name = "lbltelact";
            this.lbltelact.Size = new System.Drawing.Size(79, 20);
            this.lbltelact.TabIndex = 24;
            this.lbltelact.Text = "Telefono";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtNombreAct.Location = new System.Drawing.Point(229, 50);
            this.txtNombreAct.MaxLength = 15;
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(158, 26);
            this.txtNombreAct.TabIndex = 14;
            this.txtNombreAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAct_KeyPress);
            // 
            // lblcalleact
            // 
            this.lblcalleact.AutoSize = true;
            this.lblcalleact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalleact.ForeColor = System.Drawing.Color.White;
            this.lblcalleact.Location = new System.Drawing.Point(31, 207);
            this.lblcalleact.Name = "lblcalleact";
            this.lblcalleact.Size = new System.Drawing.Size(54, 20);
            this.lblcalleact.TabIndex = 23;
            this.lblcalleact.Text = " Calle";
            // 
            // txtTelAct
            // 
            this.txtTelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtTelAct.Location = new System.Drawing.Point(229, 126);
            this.txtTelAct.MaxLength = 9;
            this.txtTelAct.Name = "txtTelAct";
            this.txtTelAct.Size = new System.Drawing.Size(158, 26);
            this.txtTelAct.TabIndex = 15;
            this.txtTelAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelAct_KeyPress);
            // 
            // txtCalleAct
            // 
            this.txtCalleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtCalleAct.Location = new System.Drawing.Point(229, 204);
            this.txtCalleAct.MaxLength = 15;
            this.txtCalleAct.Name = "txtCalleAct";
            this.txtCalleAct.Size = new System.Drawing.Size(158, 26);
            this.txtCalleAct.TabIndex = 22;
            this.txtCalleAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAct_KeyPress);
            // 
            // txtApeAct
            // 
            this.txtApeAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtApeAct.Location = new System.Drawing.Point(229, 86);
            this.txtApeAct.MaxLength = 15;
            this.txtApeAct.Name = "txtApeAct";
            this.txtApeAct.Size = new System.Drawing.Size(158, 26);
            this.txtApeAct.TabIndex = 21;
            this.txtApeAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeAct_KeyPress);
            // 
            // txtNpAtc
            // 
            this.txtNpAtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtNpAtc.Location = new System.Drawing.Point(229, 165);
            this.txtNpAtc.MaxLength = 4;
            this.txtNpAtc.Name = "txtNpAtc";
            this.txtNpAtc.Size = new System.Drawing.Size(158, 26);
            this.txtNpAtc.TabIndex = 16;
            this.txtNpAtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNpAtc_KeyPress);
            // 
            // lblnpact
            // 
            this.lblnpact.AutoSize = true;
            this.lblnpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnpact.ForeColor = System.Drawing.Color.White;
            this.lblnpact.Location = new System.Drawing.Point(33, 168);
            this.lblnpact.Name = "lblnpact";
            this.lblnpact.Size = new System.Drawing.Size(79, 20);
            this.lblnpact.TabIndex = 20;
            this.lblnpact.Text = "N Puerta";
            // 
            // lblapeact
            // 
            this.lblapeact.AutoSize = true;
            this.lblapeact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapeact.ForeColor = System.Drawing.Color.White;
            this.lblapeact.Location = new System.Drawing.Point(33, 89);
            this.lblapeact.Name = "lblapeact";
            this.lblapeact.Size = new System.Drawing.Size(73, 20);
            this.lblapeact.TabIndex = 18;
            this.lblapeact.Text = "Apellido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(129, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(366, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Actualizacion de Datos";
            // 
            // Frm_DatosProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 638);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlDatosActual);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_DatosProd";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.pnlDatosActual.ResumeLayout(false);
            this.pnlDatosActual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlBarraTitulo;
        public System.Windows.Forms.Label lblBarraTitulo;
        public System.Windows.Forms.Timer fechahora;
        public System.Windows.Forms.Panel pblCompra;
        private System.Windows.Forms.PictureBox pcbLogo;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlDatosActual;
        private System.Windows.Forms.Label lblnombact;
        private System.Windows.Forms.Label lbltelact;
        private System.Windows.Forms.Label lblcalleact;
        private System.Windows.Forms.Label lblnpact;
        private System.Windows.Forms.Label lblapeact;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lbluser1;
        private System.Windows.Forms.Label lblpass1;
        private System.Windows.Forms.Label lblci;
        public System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.TextBox txtNombreAct;
        public System.Windows.Forms.TextBox txtTelAct;
        public System.Windows.Forms.TextBox txtCalleAct;
        public System.Windows.Forms.TextBox txtApeAct;
        public System.Windows.Forms.TextBox txtNpAtc;
        public System.Windows.Forms.TextBox txtActUser;
        public System.Windows.Forms.TextBox txtActPass;
        public System.Windows.Forms.TextBox txtCI;
    }
}

