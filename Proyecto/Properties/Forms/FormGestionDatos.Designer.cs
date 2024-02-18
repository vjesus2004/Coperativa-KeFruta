namespace Proyecto
{
    partial class FormGestionDatos
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
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pblCompra = new System.Windows.Forms.Panel();
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.fechahora = new System.Windows.Forms.Timer(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtProduccion = new System.Windows.Forms.TextBox();
            this.txtNPuerta = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblape = new System.Windows.Forms.Label();
            this.txtTipoProd = new System.Windows.Forms.Label();
            this.lblNpuerta = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.pnlNuevoDato = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lbltituloMod = new System.Windows.Forms.Label();
            this.pnlDatosActual = new System.Windows.Forms.Panel();
            this.lbltituloActual = new System.Windows.Forms.Label();
            this.lblnombact = new System.Windows.Forms.Label();
            this.lbltelact = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.lblcalleact = new System.Windows.Forms.Label();
            this.txtTelAct = new System.Windows.Forms.TextBox();
            this.txtCalleAct = new System.Windows.Forms.TextBox();
            this.txtTipoAct = new System.Windows.Forms.TextBox();
            this.txtApeAct = new System.Windows.Forms.TextBox();
            this.txtNpAtc = new System.Windows.Forms.TextBox();
            this.lblnpact = new System.Windows.Forms.Label();
            this.lblapeact = new System.Windows.Forms.Label();
            this.lbltipoact = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlNuevoDato.SuspendLayout();
            this.pnlDatosActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBarraTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 44);
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
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1060, 44);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
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
            // pblCompra
            // 
            this.pblCompra.BackColor = System.Drawing.Color.White;
            this.pblCompra.Location = new System.Drawing.Point(447, 44);
            this.pblCompra.Name = "pblCompra";
            this.pblCompra.Size = new System.Drawing.Size(900, 537);
            this.pblCompra.TabIndex = 4;
            this.pblCompra.Visible = false;
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnSalir.Image = global::Proyecto.Properties.Resources.close_cross_delete_remove_icon_134659;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(858, 518);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(159, 51);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(56, 518);
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
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtNombre.Location = new System.Drawing.Point(318, 43);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 26);
            this.txtNombre.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtTel.Location = new System.Drawing.Point(318, 160);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(158, 26);
            this.txtTel.TabIndex = 15;
            // 
            // txtProduccion
            // 
            this.txtProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtProduccion.Location = new System.Drawing.Point(318, 121);
            this.txtProduccion.MaxLength = 15;
            this.txtProduccion.Name = "txtProduccion";
            this.txtProduccion.Size = new System.Drawing.Size(158, 26);
            this.txtProduccion.TabIndex = 15;
            // 
            // txtNPuerta
            // 
            this.txtNPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtNPuerta.Location = new System.Drawing.Point(318, 199);
            this.txtNPuerta.MaxLength = 4;
            this.txtNPuerta.Name = "txtNPuerta";
            this.txtNPuerta.Size = new System.Drawing.Size(158, 26);
            this.txtNPuerta.TabIndex = 16;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(25, 55);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(190, 20);
            this.lblnombre.TabIndex = 17;
            this.lblnombre.Text = "Ingrese nuevo Nombre";
            // 
            // lblape
            // 
            this.lblape.AutoSize = true;
            this.lblape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblape.ForeColor = System.Drawing.Color.White;
            this.lblape.Location = new System.Drawing.Point(25, 94);
            this.lblape.Name = "lblape";
            this.lblape.Size = new System.Drawing.Size(192, 20);
            this.lblape.TabIndex = 18;
            this.lblape.Text = "Ingrese nuevo Apellido";
            // 
            // txtTipoProd
            // 
            this.txtTipoProd.AutoSize = true;
            this.txtTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProd.ForeColor = System.Drawing.Color.White;
            this.txtTipoProd.Location = new System.Drawing.Point(23, 133);
            this.txtTipoProd.Name = "txtTipoProd";
            this.txtTipoProd.Size = new System.Drawing.Size(279, 20);
            this.txtTipoProd.TabIndex = 19;
            this.txtTipoProd.Text = "ingrese nuevo Tipo de Produccion";
            // 
            // lblNpuerta
            // 
            this.lblNpuerta.AutoSize = true;
            this.lblNpuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNpuerta.ForeColor = System.Drawing.Color.White;
            this.lblNpuerta.Location = new System.Drawing.Point(25, 211);
            this.lblNpuerta.Name = "lblNpuerta";
            this.lblNpuerta.Size = new System.Drawing.Size(198, 20);
            this.lblNpuerta.TabIndex = 20;
            this.lblNpuerta.Text = "Ingrese nuevo N Puerta";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtApellido.Location = new System.Drawing.Point(318, 82);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 26);
            this.txtApellido.TabIndex = 21;
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtCalle.Location = new System.Drawing.Point(318, 238);
            this.txtCalle.MaxLength = 15;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(158, 26);
            this.txtCalle.TabIndex = 22;
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.White;
            this.lblDir.Location = new System.Drawing.Point(25, 241);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(168, 20);
            this.lblDir.TabIndex = 23;
            this.lblDir.Text = "Ingrese nueva Calle";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(23, 172);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(196, 20);
            this.lblTel.TabIndex = 24;
            this.lblTel.Text = "ingrese nuevo Telefono";
            // 
            // pnlNuevoDato
            // 
            this.pnlNuevoDato.BackColor = System.Drawing.Color.Transparent;
            this.pnlNuevoDato.Controls.Add(this.btnConfirmar);
            this.pnlNuevoDato.Controls.Add(this.lbltituloMod);
            this.pnlNuevoDato.Controls.Add(this.lblnombre);
            this.pnlNuevoDato.Controls.Add(this.lblTel);
            this.pnlNuevoDato.Controls.Add(this.txtNombre);
            this.pnlNuevoDato.Controls.Add(this.lblDir);
            this.pnlNuevoDato.Controls.Add(this.txtTel);
            this.pnlNuevoDato.Controls.Add(this.txtCalle);
            this.pnlNuevoDato.Controls.Add(this.txtProduccion);
            this.pnlNuevoDato.Controls.Add(this.txtApellido);
            this.pnlNuevoDato.Controls.Add(this.txtNPuerta);
            this.pnlNuevoDato.Controls.Add(this.lblNpuerta);
            this.pnlNuevoDato.Controls.Add(this.lblape);
            this.pnlNuevoDato.Controls.Add(this.txtTipoProd);
            this.pnlNuevoDato.Location = new System.Drawing.Point(520, 164);
            this.pnlNuevoDato.Name = "pnlNuevoDato";
            this.pnlNuevoDato.Size = new System.Drawing.Size(497, 348);
            this.pnlNuevoDato.TabIndex = 25;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(27, 276);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(449, 51);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.Text = "Actualizar Datos";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // lbltituloMod
            // 
            this.lbltituloMod.AutoSize = true;
            this.lbltituloMod.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloMod.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbltituloMod.Location = new System.Drawing.Point(150, 13);
            this.lbltituloMod.Name = "lbltituloMod";
            this.lbltituloMod.Size = new System.Drawing.Size(159, 25);
            this.lbltituloMod.TabIndex = 28;
            this.lbltituloMod.Text = "Nuevos Datos";
            // 
            // pnlDatosActual
            // 
            this.pnlDatosActual.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosActual.Controls.Add(this.lbltituloActual);
            this.pnlDatosActual.Controls.Add(this.lblnombact);
            this.pnlDatosActual.Controls.Add(this.lbltelact);
            this.pnlDatosActual.Controls.Add(this.txtNombreAct);
            this.pnlDatosActual.Controls.Add(this.lblcalleact);
            this.pnlDatosActual.Controls.Add(this.txtTelAct);
            this.pnlDatosActual.Controls.Add(this.txtCalleAct);
            this.pnlDatosActual.Controls.Add(this.txtTipoAct);
            this.pnlDatosActual.Controls.Add(this.txtApeAct);
            this.pnlDatosActual.Controls.Add(this.txtNpAtc);
            this.pnlDatosActual.Controls.Add(this.lblnpact);
            this.pnlDatosActual.Controls.Add(this.lblapeact);
            this.pnlDatosActual.Controls.Add(this.lbltipoact);
            this.pnlDatosActual.Location = new System.Drawing.Point(56, 164);
            this.pnlDatosActual.Name = "pnlDatosActual";
            this.pnlDatosActual.Size = new System.Drawing.Size(401, 308);
            this.pnlDatosActual.TabIndex = 26;
            // 
            // lbltituloActual
            // 
            this.lbltituloActual.AutoSize = true;
            this.lbltituloActual.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloActual.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbltituloActual.Location = new System.Drawing.Point(124, 13);
            this.lbltituloActual.Name = "lbltituloActual";
            this.lbltituloActual.Size = new System.Drawing.Size(171, 25);
            this.lbltituloActual.TabIndex = 27;
            this.lbltituloActual.Text = "Datos Actuales";
            // 
            // lblnombact
            // 
            this.lblnombact.AutoSize = true;
            this.lblnombact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombact.ForeColor = System.Drawing.Color.White;
            this.lblnombact.Location = new System.Drawing.Point(28, 55);
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
            this.lbltelact.Location = new System.Drawing.Point(26, 172);
            this.lbltelact.Name = "lbltelact";
            this.lbltelact.Size = new System.Drawing.Size(79, 20);
            this.lbltelact.TabIndex = 24;
            this.lbltelact.Text = "Telefono";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtNombreAct.Location = new System.Drawing.Point(226, 43);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.ReadOnly = true;
            this.txtNombreAct.Size = new System.Drawing.Size(158, 26);
            this.txtNombreAct.TabIndex = 14;
            // 
            // lblcalleact
            // 
            this.lblcalleact.AutoSize = true;
            this.lblcalleact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalleact.ForeColor = System.Drawing.Color.White;
            this.lblcalleact.Location = new System.Drawing.Point(28, 241);
            this.lblcalleact.Name = "lblcalleact";
            this.lblcalleact.Size = new System.Drawing.Size(54, 20);
            this.lblcalleact.TabIndex = 23;
            this.lblcalleact.Text = " Calle";
            // 
            // txtTelAct
            // 
            this.txtTelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtTelAct.Location = new System.Drawing.Point(226, 160);
            this.txtTelAct.Name = "txtTelAct";
            this.txtTelAct.ReadOnly = true;
            this.txtTelAct.Size = new System.Drawing.Size(158, 26);
            this.txtTelAct.TabIndex = 15;
            // 
            // txtCalleAct
            // 
            this.txtCalleAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtCalleAct.Location = new System.Drawing.Point(226, 238);
            this.txtCalleAct.Name = "txtCalleAct";
            this.txtCalleAct.ReadOnly = true;
            this.txtCalleAct.Size = new System.Drawing.Size(158, 26);
            this.txtCalleAct.TabIndex = 22;
            // 
            // txtTipoAct
            // 
            this.txtTipoAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtTipoAct.Location = new System.Drawing.Point(226, 121);
            this.txtTipoAct.Name = "txtTipoAct";
            this.txtTipoAct.ReadOnly = true;
            this.txtTipoAct.Size = new System.Drawing.Size(158, 26);
            this.txtTipoAct.TabIndex = 15;
            // 
            // txtApeAct
            // 
            this.txtApeAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtApeAct.Location = new System.Drawing.Point(226, 82);
            this.txtApeAct.Name = "txtApeAct";
            this.txtApeAct.ReadOnly = true;
            this.txtApeAct.Size = new System.Drawing.Size(158, 26);
            this.txtApeAct.TabIndex = 21;
            // 
            // txtNpAtc
            // 
            this.txtNpAtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.txtNpAtc.Location = new System.Drawing.Point(226, 199);
            this.txtNpAtc.Name = "txtNpAtc";
            this.txtNpAtc.ReadOnly = true;
            this.txtNpAtc.Size = new System.Drawing.Size(158, 26);
            this.txtNpAtc.TabIndex = 16;
            // 
            // lblnpact
            // 
            this.lblnpact.AutoSize = true;
            this.lblnpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnpact.ForeColor = System.Drawing.Color.White;
            this.lblnpact.Location = new System.Drawing.Point(28, 211);
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
            this.lblapeact.Location = new System.Drawing.Point(28, 94);
            this.lblapeact.Name = "lblapeact";
            this.lblapeact.Size = new System.Drawing.Size(73, 20);
            this.lblapeact.TabIndex = 18;
            this.lblapeact.Text = "Apellido";
            // 
            // lbltipoact
            // 
            this.lbltipoact.AutoSize = true;
            this.lbltipoact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoact.ForeColor = System.Drawing.Color.White;
            this.lbltipoact.Location = new System.Drawing.Point(26, 133);
            this.lbltipoact.Name = "lbltipoact";
            this.lbltipoact.Size = new System.Drawing.Size(162, 20);
            this.lbltipoact.TabIndex = 19;
            this.lbltipoact.Text = "Tipo de Produccion";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(340, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(366, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Actualizacion de Datos";
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_resize_48;
            this.picRes.Location = new System.Drawing.Point(983, 6);
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
            this.picMin.Location = new System.Drawing.Point(943, 6);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(34, 35);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 30;
            this.picMin.TabStop = false;
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMax.Image = global::Proyecto.Properties.Resources.icons8_maximize_window_48;
            this.picMax.Location = new System.Drawing.Point(983, 6);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(34, 35);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMax.TabIndex = 28;
            this.picMax.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.icons8_close_48;
            this.picCerrar.Location = new System.Drawing.Point(1023, 6);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 35);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 27;
            this.picCerrar.TabStop = false;
            // 
            // FormGestionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._94410;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlDatosActual);
            this.Controls.Add(this.pnlNuevoDato);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDatos";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlNuevoDato.ResumeLayout(false);
            this.pnlNuevoDato.PerformLayout();
            this.pnlDatosActual.ResumeLayout(false);
            this.pnlDatosActual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
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
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtProduccion;
        private System.Windows.Forms.TextBox txtNPuerta;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblape;
        private System.Windows.Forms.Label txtTipoProd;
        private System.Windows.Forms.Label lblNpuerta;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Panel pnlNuevoDato;
        private System.Windows.Forms.Panel pnlDatosActual;
        private System.Windows.Forms.Label lblnombact;
        private System.Windows.Forms.Label lbltelact;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.Label lblcalleact;
        private System.Windows.Forms.TextBox txtTelAct;
        private System.Windows.Forms.TextBox txtCalleAct;
        private System.Windows.Forms.TextBox txtTipoAct;
        private System.Windows.Forms.TextBox txtApeAct;
        private System.Windows.Forms.TextBox txtNpAtc;
        private System.Windows.Forms.Label lblnpact;
        private System.Windows.Forms.Label lblapeact;
        private System.Windows.Forms.Label lbltipoact;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Label lbltituloMod;
        public System.Windows.Forms.Label lbltituloActual;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
    }
}

