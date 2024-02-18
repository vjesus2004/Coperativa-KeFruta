namespace Proyecto
{
    partial class Ke_Fruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ke_Fruta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pblCompra = new System.Windows.Forms.Panel();
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnPredios = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCosechas = new System.Windows.Forms.Button();
            this.btn_GestionDatos = new System.Windows.Forms.Button();
            this.btnSectores = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFunciones = new System.Windows.Forms.Button();
            this.btnFechas = new System.Windows.Forms.Button();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblKeFruta = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechahora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.pnlSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlInicio.SuspendLayout();
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
            this.pnlBarraTitulo.Controls.Add(this.pblCompra);
            this.pnlBarraTitulo.Controls.Add(this.lblBarraTitulo);
            this.pnlBarraTitulo.Controls.Add(this.picRes);
            this.pnlBarraTitulo.Controls.Add(this.picMin);
            this.pnlBarraTitulo.Controls.Add(this.picMax);
            this.pnlBarraTitulo.Controls.Add(this.picCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1060, 44);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
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
            this.lblBarraTitulo.Location = new System.Drawing.Point(8, 6);
            this.lblBarraTitulo.Name = "lblBarraTitulo";
            this.lblBarraTitulo.Size = new System.Drawing.Size(71, 24);
            this.lblBarraTitulo.TabIndex = 4;
            this.lblBarraTitulo.Text = "CoFruit";
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
            this.picRes.TabIndex = 2;
            this.picRes.TabStop = false;
            this.picRes.Visible = false;
            this.picRes.Click += new System.EventHandler(this.picRes_Click);
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
            this.picMin.TabIndex = 3;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
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
            this.picMax.TabIndex = 1;
            this.picMax.TabStop = false;
            this.picMax.Click += new System.EventHandler(this.picMax_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.icons8_close_48;
            this.picCerrar.Location = new System.Drawing.Point(1023, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 35);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 0;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.BackColor = System.Drawing.Color.Black;
            this.pnlSubmenu.Controls.Add(this.btnHistorial);
            this.pnlSubmenu.Controls.Add(this.btnPredios);
            this.pnlSubmenu.Controls.Add(this.pcbLogo);
            this.pnlSubmenu.Controls.Add(this.btnCompras);
            this.pnlSubmenu.Controls.Add(this.btnProductos);
            this.pnlSubmenu.Controls.Add(this.btnCosechas);
            this.pnlSubmenu.Controls.Add(this.btn_GestionDatos);
            this.pnlSubmenu.Controls.Add(this.btnSectores);
            this.pnlSubmenu.Controls.Add(this.btnVentas);
            this.pnlSubmenu.Controls.Add(this.btnLogout);
            this.pnlSubmenu.Controls.Add(this.btnFunciones);
            this.pnlSubmenu.Controls.Add(this.btnFechas);
            this.pnlSubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubmenu.Location = new System.Drawing.Point(0, 44);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(171, 545);
            this.pnlSubmenu.TabIndex = 1;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Black;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Image = global::Proyecto.Properties.Resources.icons8_flax_seeds_48;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(-3, 357);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(171, 45);
            this.btnHistorial.TabIndex = 16;
            this.btnHistorial.Text = " Pendientes";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Visible = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnPredios
            // 
            this.btnPredios.BackColor = System.Drawing.Color.Black;
            this.btnPredios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPredios.FlatAppearance.BorderSize = 0;
            this.btnPredios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPredios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPredios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPredios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredios.ForeColor = System.Drawing.Color.White;
            this.btnPredios.Image = global::Proyecto.Properties.Resources.icons8_where_48;
            this.btnPredios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredios.Location = new System.Drawing.Point(0, 212);
            this.btnPredios.Name = "btnPredios";
            this.btnPredios.Size = new System.Drawing.Size(171, 42);
            this.btnPredios.TabIndex = 10;
            this.btnPredios.Text = "Predios";
            this.btnPredios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPredios.UseVisualStyleBackColor = false;
            this.btnPredios.Visible = false;
            this.btnPredios.Click += new System.EventHandler(this.btnPredios_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::Proyecto.Properties.Resources.LogoCoFruit;
            this.pcbLogo.Location = new System.Drawing.Point(12, 19);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(136, 128);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 7;
            this.pcbLogo.TabStop = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Black;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = global::Proyecto.Properties.Resources.icons8_buy_48;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(-3, 309);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(174, 42);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "   Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Visible = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Black;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::Proyecto.Properties.Resources.icons8_flax_seeds_48;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 309);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(171, 42);
            this.btnProductos.TabIndex = 14;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Visible = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCosechas
            // 
            this.btnCosechas.BackColor = System.Drawing.Color.Black;
            this.btnCosechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCosechas.FlatAppearance.BorderSize = 0;
            this.btnCosechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCosechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCosechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosechas.ForeColor = System.Drawing.Color.White;
            this.btnCosechas.Image = global::Proyecto.Properties.Resources.icons8_flax_seeds_48;
            this.btnCosechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCosechas.Location = new System.Drawing.Point(0, 258);
            this.btnCosechas.Name = "btnCosechas";
            this.btnCosechas.Size = new System.Drawing.Size(171, 45);
            this.btnCosechas.TabIndex = 9;
            this.btnCosechas.Text = "    Cosechas";
            this.btnCosechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCosechas.UseVisualStyleBackColor = false;
            this.btnCosechas.Visible = false;
            this.btnCosechas.Click += new System.EventHandler(this.btnCosechas_Click);
            // 
            // btn_GestionDatos
            // 
            this.btn_GestionDatos.BackColor = System.Drawing.Color.Black;
            this.btn_GestionDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GestionDatos.FlatAppearance.BorderSize = 0;
            this.btn_GestionDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_GestionDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_GestionDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionDatos.ForeColor = System.Drawing.Color.White;
            this.btn_GestionDatos.Image = global::Proyecto.Properties.Resources.icons8_user_48;
            this.btn_GestionDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GestionDatos.Location = new System.Drawing.Point(0, 161);
            this.btn_GestionDatos.Name = "btn_GestionDatos";
            this.btn_GestionDatos.Size = new System.Drawing.Size(171, 45);
            this.btn_GestionDatos.TabIndex = 8;
            this.btn_GestionDatos.Text = "Datos";
            this.btn_GestionDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GestionDatos.UseVisualStyleBackColor = false;
            this.btn_GestionDatos.Visible = false;
            this.btn_GestionDatos.Click += new System.EventHandler(this.btn_GestionDatos_Click);
            // 
            // btnSectores
            // 
            this.btnSectores.BackColor = System.Drawing.Color.Black;
            this.btnSectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSectores.FlatAppearance.BorderSize = 0;
            this.btnSectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectores.ForeColor = System.Drawing.Color.White;
            this.btnSectores.Image = global::Proyecto.Properties.Resources.icons8_healthy_food_48;
            this.btnSectores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSectores.Location = new System.Drawing.Point(0, 258);
            this.btnSectores.Name = "btnSectores";
            this.btnSectores.Size = new System.Drawing.Size(171, 45);
            this.btnSectores.TabIndex = 15;
            this.btnSectores.Text = "Sectores";
            this.btnSectores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSectores.UseVisualStyleBackColor = false;
            this.btnSectores.Visible = false;
            this.btnSectores.Click += new System.EventHandler(this.btnSectores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Black;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::Proyecto.Properties.Resources.icons8_checkout_48;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 408);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(168, 42);
            this.btnVentas.TabIndex = 13;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Visible = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Proyecto.Properties.Resources.icons8_logout_rounded_left_48;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 497);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "      CerrarSesion";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnFunciones
            // 
            this.btnFunciones.BackColor = System.Drawing.Color.Black;
            this.btnFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunciones.FlatAppearance.BorderSize = 0;
            this.btnFunciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunciones.ForeColor = System.Drawing.Color.White;
            this.btnFunciones.Image = global::Proyecto.Properties.Resources.icons8_users_settings_48;
            this.btnFunciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunciones.Location = new System.Drawing.Point(0, 162);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(171, 42);
            this.btnFunciones.TabIndex = 0;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFunciones.UseVisualStyleBackColor = false;
            this.btnFunciones.Visible = false;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnFechas
            // 
            this.btnFechas.BackColor = System.Drawing.Color.Black;
            this.btnFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechas.FlatAppearance.BorderSize = 0;
            this.btnFechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechas.ForeColor = System.Drawing.Color.White;
            this.btnFechas.Image = global::Proyecto.Properties.Resources.icons8_calendar_48;
            this.btnFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechas.Location = new System.Drawing.Point(0, 210);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(171, 42);
            this.btnFechas.TabIndex = 12;
            this.btnFechas.Text = "Fechas";
            this.btnFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechas.UseVisualStyleBackColor = false;
            this.btnFechas.Visible = false;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackColor = System.Drawing.Color.Transparent;
            this.pnlInicio.Controls.Add(this.lblHora);
            this.pnlInicio.Controls.Add(this.lblKeFruta);
            this.pnlInicio.Controls.Add(this.lblFecha);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicio.Location = new System.Drawing.Point(0, 0);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(1060, 589);
            this.pnlInicio.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Yu Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblHora.Location = new System.Drawing.Point(406, 288);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(391, 82);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "00:00:00 p.m";
            // 
            // lblKeFruta
            // 
            this.lblKeFruta.AutoSize = true;
            this.lblKeFruta.Font = new System.Drawing.Font("Yu Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeFruta.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblKeFruta.Location = new System.Drawing.Point(490, 206);
            this.lblKeFruta.Name = "lblKeFruta";
            this.lblKeFruta.Size = new System.Drawing.Size(231, 82);
            this.lblKeFruta.TabIndex = 5;
            this.lblKeFruta.Text = "CoFruit";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblFecha.Location = new System.Drawing.Point(418, 370);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(365, 82);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "00/00/0000";
            // 
            // fechahora
            // 
            this.fechahora.Enabled = true;
            this.fechahora.Tick += new System.EventHandler(this.fechahora_Tick);
            // 
            // Ke_Fruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(1060, 589);
            this.Controls.Add(this.pnlSubmenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ke_Fruta";
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.pnlSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlInicio;
        public System.Windows.Forms.Panel pnlBarraTitulo;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Label lblBarraTitulo;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Timer fechahora;
        public System.Windows.Forms.Button btnCompras;
        public System.Windows.Forms.Panel pblCompra;
        public System.Windows.Forms.Label lblKeFruta;
        public System.Windows.Forms.Button btnPredios;
        public System.Windows.Forms.Button btnCosechas;
        public System.Windows.Forms.Button btn_GestionDatos;
        public System.Windows.Forms.Button btnFunciones;
        public System.Windows.Forms.Panel pnlSubmenu;
        private System.Windows.Forms.PictureBox pcbLogo;
        public System.Windows.Forms.Button btnFechas;
        public System.Windows.Forms.Button btnVentas;
        public System.Windows.Forms.Button btnProductos;
        public System.Windows.Forms.Button btnSectores;
        public System.Windows.Forms.Button btnHistorial;
    }
}

