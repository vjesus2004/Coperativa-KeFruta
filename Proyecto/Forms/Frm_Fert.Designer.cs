namespace Proyecto
{
    partial class Frm_Fert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.picRes = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pblCompra = new System.Windows.Forms.Panel();
            this.lblBarraTitulo = new System.Windows.Forms.Label();
            this.lblgestion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlcereales = new System.Windows.Forms.Panel();
            this.NupFosforo = new System.Windows.Forms.NumericUpDown();
            this.NupNitrogenoSuelo = new System.Windows.Forms.NumericUpDown();
            this.NupNitrogenoPlanta = new System.Windows.Forms.NumericUpDown();
            this.Fosforo = new System.Windows.Forms.Label();
            this.lblPlanta = new System.Windows.Forms.Label();
            this.lbldato1 = new System.Windows.Forms.Label();
            this.cbxFert = new System.Windows.Forms.ComboBox();
            this.lblFert = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.cbxsectorf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlfert = new System.Windows.Forms.Panel();
            this.LVLFERT = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlcereales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupFosforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupNitrogenoSuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupNitrogenoPlanta)).BeginInit();
            this.pnlfert.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBarraTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 44);
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
            this.pnlBarraTitulo.Size = new System.Drawing.Size(983, 44);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // picRes
            // 
            this.picRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRes.Image = global::Proyecto.Properties.Resources.icons8_resize_48;
            this.picRes.Location = new System.Drawing.Point(905, 6);
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
            this.picMin.Location = new System.Drawing.Point(865, 6);
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
            this.picMax.Location = new System.Drawing.Point(905, 6);
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
            this.picCerrar.Location = new System.Drawing.Point(945, 6);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 35);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 8;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click_1);
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
            // lblgestion
            // 
            this.lblgestion.AutoSize = true;
            this.lblgestion.BackColor = System.Drawing.Color.Transparent;
            this.lblgestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion.ForeColor = System.Drawing.Color.White;
            this.lblgestion.Location = new System.Drawing.Point(267, 17);
            this.lblgestion.Name = "lblgestion";
            this.lblgestion.Size = new System.Drawing.Size(375, 37);
            this.lblgestion.TabIndex = 23;
            this.lblgestion.Text = "Gestion de Fertilizacion";
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
            this.btnVolver.Location = new System.Drawing.Point(55, 515);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(882, 47);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // pnlcereales
            // 
            this.pnlcereales.BackColor = System.Drawing.Color.Transparent;
            this.pnlcereales.Controls.Add(this.NupFosforo);
            this.pnlcereales.Controls.Add(this.NupNitrogenoSuelo);
            this.pnlcereales.Controls.Add(this.NupNitrogenoPlanta);
            this.pnlcereales.Controls.Add(this.Fosforo);
            this.pnlcereales.Controls.Add(this.lblPlanta);
            this.pnlcereales.Controls.Add(this.lbldato1);
            this.pnlcereales.Controls.Add(this.cbxFert);
            this.pnlcereales.Controls.Add(this.lblFert);
            this.pnlcereales.Controls.Add(this.btncalcular);
            this.pnlcereales.Controls.Add(this.cbxsectorf);
            this.pnlcereales.Controls.Add(this.label2);
            this.pnlcereales.Controls.Add(this.lblgestion);
            this.pnlcereales.Location = new System.Drawing.Point(55, 76);
            this.pnlcereales.Name = "pnlcereales";
            this.pnlcereales.Size = new System.Drawing.Size(882, 336);
            this.pnlcereales.TabIndex = 22;
            // 
            // NupFosforo
            // 
            this.NupFosforo.Enabled = false;
            this.NupFosforo.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.NupFosforo.Location = new System.Drawing.Point(222, 195);
            this.NupFosforo.Name = "NupFosforo";
            this.NupFosforo.Size = new System.Drawing.Size(189, 33);
            this.NupFosforo.TabIndex = 36;
            // 
            // NupNitrogenoSuelo
            // 
            this.NupNitrogenoSuelo.Enabled = false;
            this.NupNitrogenoSuelo.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.NupNitrogenoSuelo.Location = new System.Drawing.Point(222, 139);
            this.NupNitrogenoSuelo.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.NupNitrogenoSuelo.Name = "NupNitrogenoSuelo";
            this.NupNitrogenoSuelo.Size = new System.Drawing.Size(189, 33);
            this.NupNitrogenoSuelo.TabIndex = 35;
            // 
            // NupNitrogenoPlanta
            // 
            this.NupNitrogenoPlanta.Enabled = false;
            this.NupNitrogenoPlanta.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.NupNitrogenoPlanta.Location = new System.Drawing.Point(661, 142);
            this.NupNitrogenoPlanta.Name = "NupNitrogenoPlanta";
            this.NupNitrogenoPlanta.Size = new System.Drawing.Size(189, 33);
            this.NupNitrogenoPlanta.TabIndex = 34;
            // 
            // Fosforo
            // 
            this.Fosforo.AutoSize = true;
            this.Fosforo.BackColor = System.Drawing.Color.Transparent;
            this.Fosforo.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fosforo.ForeColor = System.Drawing.Color.White;
            this.Fosforo.Location = new System.Drawing.Point(22, 195);
            this.Fosforo.Name = "Fosforo";
            this.Fosforo.Size = new System.Drawing.Size(184, 31);
            this.Fosforo.TabIndex = 33;
            this.Fosforo.Text = "Fosforo en Suelo";
            // 
            // lblPlanta
            // 
            this.lblPlanta.AutoSize = true;
            this.lblPlanta.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanta.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanta.ForeColor = System.Drawing.Color.White;
            this.lblPlanta.Location = new System.Drawing.Point(425, 142);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(217, 31);
            this.lblPlanta.TabIndex = 31;
            this.lblPlanta.Text = "Nitrogeno en Planta";
            // 
            // lbldato1
            // 
            this.lbldato1.AutoSize = true;
            this.lbldato1.BackColor = System.Drawing.Color.Transparent;
            this.lbldato1.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldato1.ForeColor = System.Drawing.Color.White;
            this.lbldato1.Location = new System.Drawing.Point(9, 142);
            this.lbldato1.Name = "lbldato1";
            this.lbldato1.Size = new System.Drawing.Size(207, 31);
            this.lbldato1.TabIndex = 29;
            this.lbldato1.Text = "Nitrogeno en Suelo";
            // 
            // cbxFert
            // 
            this.cbxFert.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.cbxFert.FormattingEnabled = true;
            this.cbxFert.Location = new System.Drawing.Point(660, 90);
            this.cbxFert.Name = "cbxFert";
            this.cbxFert.Size = new System.Drawing.Size(189, 29);
            this.cbxFert.TabIndex = 28;
            this.cbxFert.SelectedIndexChanged += new System.EventHandler(this.cbxFert_SelectedIndexChanged);
            // 
            // lblFert
            // 
            this.lblFert.AutoSize = true;
            this.lblFert.BackColor = System.Drawing.Color.Transparent;
            this.lblFert.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFert.ForeColor = System.Drawing.Color.White;
            this.lblFert.Location = new System.Drawing.Point(509, 85);
            this.lblFert.Name = "lblFert";
            this.lblFert.Size = new System.Drawing.Size(133, 31);
            this.lblFert.TabIndex = 27;
            this.lblFert.Text = "Fertilizacion";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.LawnGreen;
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.Color.Black;
            this.btncalcular.Image = global::Proyecto.Properties.Resources.icons8_checkmark_48;
            this.btncalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncalcular.Location = new System.Drawing.Point(28, 266);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(822, 53);
            this.btncalcular.TabIndex = 26;
            this.btncalcular.Text = "Aplicar Fertilizacion";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cbxsectorf
            // 
            this.cbxsectorf.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.cbxsectorf.FormattingEnabled = true;
            this.cbxsectorf.Location = new System.Drawing.Point(222, 90);
            this.cbxsectorf.Name = "cbxsectorf";
            this.cbxsectorf.Size = new System.Drawing.Size(189, 29);
            this.cbxsectorf.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sector";
            // 
            // pnlfert
            // 
            this.pnlfert.BackColor = System.Drawing.Color.Transparent;
            this.pnlfert.Controls.Add(this.LVLFERT);
            this.pnlfert.Controls.Add(this.btnIniciar);
            this.pnlfert.Controls.Add(this.txtTotal);
            this.pnlfert.Location = new System.Drawing.Point(55, 418);
            this.pnlfert.Name = "pnlfert";
            this.pnlfert.Size = new System.Drawing.Size(882, 73);
            this.pnlfert.TabIndex = 28;
            // 
            // LVLFERT
            // 
            this.LVLFERT.AutoSize = true;
            this.LVLFERT.BackColor = System.Drawing.Color.Transparent;
            this.LVLFERT.Font = new System.Drawing.Font("Yu Gothic Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVLFERT.ForeColor = System.Drawing.Color.White;
            this.LVLFERT.Location = new System.Drawing.Point(22, 27);
            this.LVLFERT.Name = "LVLFERT";
            this.LVLFERT.Size = new System.Drawing.Size(232, 31);
            this.LVLFERT.TabIndex = 21;
            this.LVLFERT.Text = "Fertilizante Necesario";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Yu Gothic Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Image = global::Proyecto.Properties.Resources.icons8_checkmark_48;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(648, 17);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(201, 41);
            this.btnIniciar.TabIndex = 27;
            this.btnIniciar.Text = "Aplicar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic);
            this.txtTotal.Location = new System.Drawing.Point(274, 22);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(355, 33);
            this.txtTotal.TabIndex = 22;
            // 
            // Frm_Fert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 598);
            this.Controls.Add(this.pnlfert);
            this.Controls.Add(this.pnlcereales);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Fert";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlcereales.ResumeLayout(false);
            this.pnlcereales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NupFosforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupNitrogenoSuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupNitrogenoPlanta)).EndInit();
            this.pnlfert.ResumeLayout(false);
            this.pnlfert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnlBarraTitulo;
        public System.Windows.Forms.Label lblBarraTitulo;
        public System.Windows.Forms.Panel pblCompra;
        private System.Windows.Forms.PictureBox pcbLogo;
        public System.Windows.Forms.Label lblgestion;
        public System.Windows.Forms.PictureBox picRes;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picMax;
        public System.Windows.Forms.PictureBox picCerrar;
        public System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlcereales;
        private System.Windows.Forms.Panel pnlfert;
        public System.Windows.Forms.Label LVLFERT;
        public System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cbxsectorf;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NupFosforo;
        private System.Windows.Forms.NumericUpDown NupNitrogenoSuelo;
        private System.Windows.Forms.NumericUpDown NupNitrogenoPlanta;
        public System.Windows.Forms.Label Fosforo;
        public System.Windows.Forms.Label lblPlanta;
        public System.Windows.Forms.Label lbldato1;
        private System.Windows.Forms.ComboBox cbxFert;
        public System.Windows.Forms.Label lblFert;
    }
}

