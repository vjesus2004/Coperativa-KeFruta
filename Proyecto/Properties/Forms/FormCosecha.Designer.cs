namespace Proyecto
{
    partial class FormCosecha
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
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblcosecha = new System.Windows.Forms.Label();
            this.lblproxCosecha = new System.Windows.Forms.Label();
            this.lblproxSiembra = new System.Windows.Forms.Label();
            this.lblfcosecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFechas = new System.Windows.Forms.Panel();
            this.cbxTipoProd = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
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
            this.pnlBarraTitulo.Controls.Add(this.lblBarraTitulo);
            this.pnlBarraTitulo.Controls.Add(this.picMax);
            this.pnlBarraTitulo.Controls.Add(this.picCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1060, 44);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
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
            this.lblTitulo.Location = new System.Drawing.Point(415, 96);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Cosecha";
            // 
            // lblcosecha
            // 
            this.lblcosecha.AutoSize = true;
            this.lblcosecha.BackColor = System.Drawing.Color.Transparent;
            this.lblcosecha.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosecha.ForeColor = System.Drawing.Color.White;
            this.lblcosecha.Location = new System.Drawing.Point(235, 207);
            this.lblcosecha.Name = "lblcosecha";
            this.lblcosecha.Size = new System.Drawing.Size(226, 27);
            this.lblcosecha.TabIndex = 13;
            this.lblcosecha.Text = "Inserte tipo de Producto";
            // 
            // lblproxCosecha
            // 
            this.lblproxCosecha.AutoSize = true;
            this.lblproxCosecha.BackColor = System.Drawing.Color.Transparent;
            this.lblproxCosecha.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproxCosecha.ForeColor = System.Drawing.Color.White;
            this.lblproxCosecha.Location = new System.Drawing.Point(116, 28);
            this.lblproxCosecha.Name = "lblproxCosecha";
            this.lblproxCosecha.Size = new System.Drawing.Size(165, 27);
            this.lblproxCosecha.TabIndex = 14;
            this.lblproxCosecha.Text = "Proxima cosecha";
            // 
            // lblproxSiembra
            // 
            this.lblproxSiembra.AutoSize = true;
            this.lblproxSiembra.BackColor = System.Drawing.Color.Transparent;
            this.lblproxSiembra.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproxSiembra.ForeColor = System.Drawing.Color.White;
            this.lblproxSiembra.Location = new System.Drawing.Point(116, 101);
            this.lblproxSiembra.Name = "lblproxSiembra";
            this.lblproxSiembra.Size = new System.Drawing.Size(166, 27);
            this.lblproxSiembra.TabIndex = 15;
            this.lblproxSiembra.Text = "Proxima Siembra";
            // 
            // lblfcosecha
            // 
            this.lblfcosecha.AutoSize = true;
            this.lblfcosecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfcosecha.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfcosecha.ForeColor = System.Drawing.Color.White;
            this.lblfcosecha.Location = new System.Drawing.Point(321, 28);
            this.lblfcosecha.Name = "lblfcosecha";
            this.lblfcosecha.Size = new System.Drawing.Size(98, 27);
            this.lblfcosecha.TabIndex = 16;
            this.lblfcosecha.Text = "00/00/00";
            this.lblfcosecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(321, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "00/00/00";
            // 
            // pnlFechas
            // 
            this.pnlFechas.BackColor = System.Drawing.Color.Transparent;
            this.pnlFechas.Controls.Add(this.lblproxCosecha);
            this.pnlFechas.Controls.Add(this.label2);
            this.pnlFechas.Controls.Add(this.lblproxSiembra);
            this.pnlFechas.Controls.Add(this.lblfcosecha);
            this.pnlFechas.Location = new System.Drawing.Point(230, 315);
            this.pnlFechas.Name = "pnlFechas";
            this.pnlFechas.Size = new System.Drawing.Size(576, 162);
            this.pnlFechas.TabIndex = 18;
            this.pnlFechas.Visible = false;
            // 
            // cbxTipoProd
            // 
            this.cbxTipoProd.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic);
            this.cbxTipoProd.FormattingEnabled = true;
            this.cbxTipoProd.Items.AddRange(new object[] {
            "Manzana",
            "Naranja",
            "Limones",
            "Papa Rosada",
            "Zapallo Criollo",
            "Cebada",
            "Trigo"});
            this.cbxTipoProd.Location = new System.Drawing.Point(490, 204);
            this.cbxTipoProd.Name = "cbxTipoProd";
            this.cbxTipoProd.Size = new System.Drawing.Size(316, 35);
            this.cbxTipoProd.TabIndex = 19;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(230, 249);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(576, 51);
            this.btnMostrar.TabIndex = 20;
            this.btnMostrar.Text = "Mostrar Proximas Fechas de Siembra y Cultivo";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
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
            this.picMin.TabIndex = 24;
            this.picMin.TabStop = false;
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMax.Image = global::Proyecto.Properties.Resources.icons8_maximize_window_48;
            this.picMax.Location = new System.Drawing.Point(983, 3);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(34, 35);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMax.TabIndex = 22;
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
            this.picCerrar.TabIndex = 21;
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
            this.btnSalir.Location = new System.Drawing.Point(867, 497);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 50);
            this.btnSalir.TabIndex = 22;
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
            this.btnVolver.Location = new System.Drawing.Point(30, 509);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 50);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_maximize_window_48;
            this.picRes.Location = new System.Drawing.Point(983, 3);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(34, 35);
            this.picRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRes.TabIndex = 25;
            this.picRes.TabStop = false;
            // 
            // FormCosecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._94410;
            this.ClientSize = new System.Drawing.Size(1060, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cbxTipoProd);
            this.Controls.Add(this.pnlFechas);
            this.Controls.Add(this.lblcosecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCosecha";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.pnlFechas.ResumeLayout(false);
            this.pnlFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlBarraTitulo;
        public System.Windows.Forms.Label lblBarraTitulo;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblcosecha;
        public System.Windows.Forms.Label lblproxCosecha;
        public System.Windows.Forms.Label lblproxSiembra;
        public System.Windows.Forms.Label lblfcosecha;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFechas;
        private System.Windows.Forms.ComboBox cbxTipoProd;
        public System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.PictureBox picRes;
    }
}

