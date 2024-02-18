namespace Proyecto
{
    partial class FormVentas

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
            this.lblCompra = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblprodprecio = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1053, 44);
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
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1053, 44);
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
            this.lblTitulo.Location = new System.Drawing.Point(412, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 37);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Administrar Ventas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCompra.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.ForeColor = System.Drawing.Color.White;
            this.lblCompra.Location = new System.Drawing.Point(29, 45);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(78, 31);
            this.lblCompra.TabIndex = 14;
            this.lblCompra.Text = "Sector";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.lblprodprecio);
            this.pnlContenedor.Controls.Add(this.btnRechazar);
            this.pnlContenedor.Controls.Add(this.btnConfirmar);
            this.pnlContenedor.Controls.Add(this.lblCompra);
            this.pnlContenedor.Location = new System.Drawing.Point(79, 161);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(898, 105);
            this.pnlContenedor.TabIndex = 21;
            // 
            // lblprodprecio
            // 
            this.lblprodprecio.AutoSize = true;
            this.lblprodprecio.BackColor = System.Drawing.Color.Transparent;
            this.lblprodprecio.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodprecio.ForeColor = System.Drawing.Color.White;
            this.lblprodprecio.Location = new System.Drawing.Point(219, 45);
            this.lblprodprecio.Name = "lblprodprecio";
            this.lblprodprecio.Size = new System.Drawing.Size(75, 31);
            this.lblprodprecio.TabIndex = 24;
            this.lblprodprecio.Text = "precio";
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.White;
            this.btnRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnRechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechazar.Location = new System.Drawing.Point(739, 36);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(156, 51);
            this.btnRechazar.TabIndex = 23;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(574, 36);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(159, 51);
            this.btnConfirmar.TabIndex = 22;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_resize_48;
            this.picRes.Location = new System.Drawing.Point(972, 6);
            this.picRes.Name = "picRes";
            this.picRes.Size = new System.Drawing.Size(34, 35);
            this.picRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRes.TabIndex = 24;
            this.picRes.TabStop = false;
            this.picRes.Visible = false;
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = global::Proyecto.Properties.Resources.icons8_subtract_48;
            this.picMin.Location = new System.Drawing.Point(932, 6);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(34, 35);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 25;
            this.picMin.TabStop = false;
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMax.Image = global::Proyecto.Properties.Resources.icons8_maximize_window_48;
            this.picMax.Location = new System.Drawing.Point(972, 6);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(34, 35);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMax.TabIndex = 23;
            this.picMax.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::Proyecto.Properties.Resources.icons8_close_48;
            this.picCerrar.Location = new System.Drawing.Point(1012, 6);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 35);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 22;
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
            this.btnSalir.Location = new System.Drawing.Point(875, 519);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 50);
            this.btnSalir.TabIndex = 27;
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
            this.btnVolver.Location = new System.Drawing.Point(12, 519);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 50);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._94410;
            this.ClientSize = new System.Drawing.Size(1053, 581);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
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
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Panel pnlContenedor;
        public System.Windows.Forms.Button btnRechazar;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Label lblprodprecio;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnVolver;
    }
}

