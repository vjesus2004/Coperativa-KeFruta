namespace Proyecto
{
    partial class FormFechas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pblCompra = new System.Windows.Forms.Panel();
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblProximaCosecha = new System.Windows.Forms.Label();
            this.lblSiembra = new System.Windows.Forms.Label();
            this.txtSiembra = new System.Windows.Forms.TextBox();
            this.txtCosecha = new System.Windows.Forms.TextBox();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.btnNot = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
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
            this.lblBarraTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraTitulo.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblBarraTitulo.Location = new System.Drawing.Point(51, 13);
            this.lblBarraTitulo.Name = "lblBarraTitulo";
            this.lblBarraTitulo.Size = new System.Drawing.Size(71, 24);
            this.lblBarraTitulo.TabIndex = 4;
            this.lblBarraTitulo.Text = "CoFruit";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(328, 94);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(411, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Editar Fechas de Siembra";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.ForeColor = System.Drawing.Color.White;
            this.lblProd.Location = new System.Drawing.Point(33, 26);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(177, 25);
            this.lblProd.TabIndex = 13;
            this.lblProd.Text = "Seleccione Producto";
            // 
            // lblProximaCosecha
            // 
            this.lblProximaCosecha.AutoSize = true;
            this.lblProximaCosecha.BackColor = System.Drawing.Color.Transparent;
            this.lblProximaCosecha.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximaCosecha.ForeColor = System.Drawing.Color.White;
            this.lblProximaCosecha.Location = new System.Drawing.Point(42, 158);
            this.lblProximaCosecha.Name = "lblProximaCosecha";
            this.lblProximaCosecha.Size = new System.Drawing.Size(153, 25);
            this.lblProximaCosecha.TabIndex = 14;
            this.lblProximaCosecha.Text = "Proxima Cosecha";
            // 
            // lblSiembra
            // 
            this.lblSiembra.AutoSize = true;
            this.lblSiembra.BackColor = System.Drawing.Color.Transparent;
            this.lblSiembra.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiembra.ForeColor = System.Drawing.Color.White;
            this.lblSiembra.Location = new System.Drawing.Point(42, 97);
            this.lblSiembra.Name = "lblSiembra";
            this.lblSiembra.Size = new System.Drawing.Size(150, 25);
            this.lblSiembra.TabIndex = 15;
            this.lblSiembra.Text = "Proxima Siembra";
            // 
            // txtSiembra
            // 
            this.txtSiembra.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtSiembra.Location = new System.Drawing.Point(251, 84);
            this.txtSiembra.Name = "txtSiembra";
            this.txtSiembra.Size = new System.Drawing.Size(206, 38);
            this.txtSiembra.TabIndex = 16;
            // 
            // txtCosecha
            // 
            this.txtCosecha.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.txtCosecha.Location = new System.Drawing.Point(251, 145);
            this.txtCosecha.Name = "txtCosecha";
            this.txtCosecha.Size = new System.Drawing.Size(206, 38);
            this.txtCosecha.TabIndex = 17;
            // 
            // cbxProd
            // 
            this.cbxProd.Font = new System.Drawing.Font("Yu Gothic Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Items.AddRange(new object[] {
            "Cebada",
            "Trigo",
            "Naranja",
            "Manzana",
            "Limones",
            "Papa Rosada",
            "Zapallo Criollo"});
            this.cbxProd.Location = new System.Drawing.Point(251, 18);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(203, 33);
            this.cbxProd.TabIndex = 18;
            this.cbxProd.SelectedIndexChanged += new System.EventHandler(this.cbxProd_SelectedIndexChanged);
            // 
            // btnNot
            // 
            this.btnNot.BackColor = System.Drawing.Color.White;
            this.btnNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNot.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnNot.Image = global::Proyecto.Properties.Resources.close_cross_delete_remove_icon_134659;
            this.btnNot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNot.Location = new System.Drawing.Point(38, 224);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(419, 51);
            this.btnNot.TabIndex = 19;
            this.btnNot.Text = "Notificar Productores";
            this.btnNot.UseVisualStyleBackColor = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.btnNot);
            this.pnlContenedor.Controls.Add(this.cbxProd);
            this.pnlContenedor.Controls.Add(this.txtCosecha);
            this.pnlContenedor.Controls.Add(this.txtSiembra);
            this.pnlContenedor.Controls.Add(this.lblSiembra);
            this.pnlContenedor.Controls.Add(this.lblProximaCosecha);
            this.pnlContenedor.Controls.Add(this.lblProd);
            this.pnlContenedor.Location = new System.Drawing.Point(296, 175);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(500, 307);
            this.pnlContenedor.TabIndex = 20;
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_resize_48;
            this.picRes.Location = new System.Drawing.Point(974, 6);
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
            this.picMin.Location = new System.Drawing.Point(934, 6);
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
            this.picMax.Location = new System.Drawing.Point(974, 6);
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
            this.picCerrar.Location = new System.Drawing.Point(1014, 6);
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
            this.btnSalir.Location = new System.Drawing.Point(886, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 50);
            this.btnSalir.TabIndex = 21;
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
            this.btnVolver.Location = new System.Drawing.Point(23, 519);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 50);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // FormFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._94410;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFechas";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
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
        public System.Windows.Forms.Panel pblCompra;
        private System.Windows.Forms.PictureBox pcbLogo;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblProd;
        public System.Windows.Forms.Label lblProximaCosecha;
        public System.Windows.Forms.Label lblSiembra;
        private System.Windows.Forms.TextBox txtSiembra;
        private System.Windows.Forms.TextBox txtCosecha;
        private System.Windows.Forms.ComboBox cbxProd;
        public System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Panel pnlContenedor;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVolver;
    }
}

