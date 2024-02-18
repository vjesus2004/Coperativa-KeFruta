namespace Proyecto
{
    partial class FormPredios
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.IdSector = new System.Windows.Forms.Label();
            this.lblHectareas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSector = new System.Windows.Forms.ComboBox();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.TXThECTAREAS = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblgestion = new System.Windows.Forms.Label();
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
            this.lblTitulo.Location = new System.Drawing.Point(121, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Modificar Predios";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(105, 192);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 31);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado";
            // 
            // IdSector
            // 
            this.IdSector.AutoSize = true;
            this.IdSector.BackColor = System.Drawing.Color.Transparent;
            this.IdSector.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSector.ForeColor = System.Drawing.Color.White;
            this.IdSector.Location = new System.Drawing.Point(105, 56);
            this.IdSector.Name = "IdSector";
            this.IdSector.Size = new System.Drawing.Size(78, 31);
            this.IdSector.TabIndex = 14;
            this.IdSector.Text = "Sector";
            // 
            // lblHectareas
            // 
            this.lblHectareas.AutoSize = true;
            this.lblHectareas.BackColor = System.Drawing.Color.Transparent;
            this.lblHectareas.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHectareas.ForeColor = System.Drawing.Color.White;
            this.lblHectareas.Location = new System.Drawing.Point(71, 125);
            this.lblHectareas.Name = "lblHectareas";
            this.lblHectareas.Size = new System.Drawing.Size(118, 31);
            this.lblHectareas.TabIndex = 15;
            this.lblHectareas.Text = "Hectareas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Produccion Actual";
            // 
            // cbxSector
            // 
            this.cbxSector.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.cbxSector.FormattingEnabled = true;
            this.cbxSector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxSector.Location = new System.Drawing.Point(215, 56);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Size = new System.Drawing.Size(189, 29);
            this.cbxSector.TabIndex = 17;
            // 
            // cmbProd
            // 
            this.cmbProd.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Items.AddRange(new object[] {
            "Papa Rosada",
            "Zapallo Criollo",
            "Cebada",
            "Trigo",
            "Manzana",
            "Naranja",
            "Limones",
            "Vacio"});
            this.cmbProd.Location = new System.Drawing.Point(215, 253);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(189, 29);
            this.cmbProd.TabIndex = 18;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(215, 192);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(189, 29);
            this.cbxEstado.TabIndex = 19;
            // 
            // TXThECTAREAS
            // 
            this.TXThECTAREAS.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.TXThECTAREAS.Location = new System.Drawing.Point(215, 125);
            this.TXThECTAREAS.Name = "TXThECTAREAS";
            this.TXThECTAREAS.Size = new System.Drawing.Size(189, 33);
            this.TXThECTAREAS.TabIndex = 20;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.TXThECTAREAS);
            this.pnlContenedor.Controls.Add(this.cbxEstado);
            this.pnlContenedor.Controls.Add(this.cmbProd);
            this.pnlContenedor.Controls.Add(this.cbxSector);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.lblHectareas);
            this.pnlContenedor.Controls.Add(this.IdSector);
            this.pnlContenedor.Controls.Add(this.lblEstado);
            this.pnlContenedor.Location = new System.Drawing.Point(21, 119);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(467, 340);
            this.pnlContenedor.TabIndex = 21;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.White;
            this.btnMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(311, 518);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(467, 51);
            this.btnMod.TabIndex = 22;
            this.btnMod.Text = "Actualizar Datos";
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // lblgestion
            // 
            this.lblgestion.AutoSize = true;
            this.lblgestion.BackColor = System.Drawing.Color.Transparent;
            this.lblgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion.ForeColor = System.Drawing.Color.White;
            this.lblgestion.Location = new System.Drawing.Point(590, 66);
            this.lblgestion.Name = "lblgestion";
            this.lblgestion.Size = new System.Drawing.Size(375, 37);
            this.lblgestion.TabIndex = 23;
            this.lblgestion.Text = "Gestion de Fertilizacion";
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_resize_48;
            this.picRes.Location = new System.Drawing.Point(982, 6);
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
            this.picMin.Location = new System.Drawing.Point(942, 6);
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
            this.picMax.Location = new System.Drawing.Point(982, 6);
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
            this.picCerrar.Location = new System.Drawing.Point(1022, 6);
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
            this.btnSalir.Location = new System.Drawing.Point(884, 518);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 50);
            this.btnSalir.TabIndex = 25;
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
            this.btnVolver.Location = new System.Drawing.Point(21, 518);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 50);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // FormPredios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._94410;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblgestion);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPredios";
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
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.Label IdSector;
        public System.Windows.Forms.Label lblHectareas;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSector;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox TXThECTAREAS;
        private System.Windows.Forms.Panel pnlContenedor;
        public System.Windows.Forms.Button btnMod;
        public System.Windows.Forms.Label lblgestion;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVolver;
    }
}

