namespace Proyecto
{
    partial class FormGestion
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
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.fechahora = new System.Windows.Forms.Timer(this.components);
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlInicio.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
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
            this.pnlBarraTitulo.Controls.Add(this.picMax);
            this.pnlBarraTitulo.Controls.Add(this.picCerrar);
            this.pnlBarraTitulo.Controls.Add(this.pcbLogo);
            this.pnlBarraTitulo.Controls.Add(this.pblCompra);
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
            this.lblBarraTitulo.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraTitulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblBarraTitulo.Location = new System.Drawing.Point(51, 13);
            this.lblBarraTitulo.Name = "lblBarraTitulo";
            this.lblBarraTitulo.Size = new System.Drawing.Size(70, 25);
            this.lblBarraTitulo.TabIndex = 4;
            this.lblBarraTitulo.Text = "CoFruit";
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackColor = System.Drawing.Color.White;
            this.pnlInicio.Controls.Add(this.btnSalir);
            this.pnlInicio.Controls.Add(this.pnlContenedor);
            this.pnlInicio.Controls.Add(this.btnVolver);
            this.pnlInicio.Location = new System.Drawing.Point(0, 47);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(1060, 537);
            this.pnlInicio.TabIndex = 2;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Black;
            this.pnlContenedor.Controls.Add(this.listBox1);
            this.pnlContenedor.Controls.Add(this.lblTitulo);
            this.pnlContenedor.Location = new System.Drawing.Point(34, 15);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1000, 446);
            this.pnlContenedor.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Items.AddRange(new object[] {
            "Ejemplo:",
            "",
            "",
            "IDVenta:13825",
            "Fecha: 20/01/2022",
            "Productos: 500 Semillas de Manzano/50kg Fertilizante",
            "Estado:Pendiente",
            "----------------------------------------------",
            "IDVenta:13824",
            "Fecha: 10/03/2021",
            "Productos: 300 Semillas de Cebada/41.5kg Fungicida",
            "Estado:Terminado"});
            this.listBox1.Location = new System.Drawing.Point(51, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(892, 355);
            this.listBox1.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(336, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(329, 42);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Historial de Compras";
            // 
            // fechahora
            // 
            this.fechahora.Enabled = true;
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
            this.picRes.TabIndex = 10;
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
            this.picMin.TabIndex = 11;
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
            this.picMax.TabIndex = 9;
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
            this.picCerrar.TabIndex = 8;
            this.picCerrar.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::Proyecto.Properties.Resources.icons8_close_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(875, 472);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 50);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LawnGreen;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = global::Proyecto.Properties.Resources.icons8_left_arrow_48;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 50);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._94410;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestion";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlInicio;
        public System.Windows.Forms.Panel pnlBarraTitulo;
        public System.Windows.Forms.Label lblBarraTitulo;
        public System.Windows.Forms.Timer fechahora;
        public System.Windows.Forms.Panel pblCompra;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVolver;
    }
}

