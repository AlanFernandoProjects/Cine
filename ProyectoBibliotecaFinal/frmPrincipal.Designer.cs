namespace ProyectoBibliotecaFinal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.picCartelera = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.picPuntodeVenta = new System.Windows.Forms.PictureBox();
            this.lblCleitnes = new System.Windows.Forms.Label();
            this.picSocios = new System.Windows.Forms.PictureBox();
            this.lblLibros = new System.Windows.Forms.Label();
            this.picPeliculas = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartelera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuntodeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(767, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 27);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.picCartelera);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.picPuntodeVenta);
            this.groupBox1.Controls.Add(this.lblCleitnes);
            this.groupBox1.Controls.Add(this.picSocios);
            this.groupBox1.Controls.Add(this.lblLibros);
            this.groupBox1.Controls.Add(this.picPeliculas);
            this.groupBox1.Location = new System.Drawing.Point(10, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 438);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(23, 282);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(63, 16);
            this.label51.TabIndex = 10;
            this.label51.Text = "Cartelera";
            // 
            // picCartelera
            // 
            this.picCartelera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCartelera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCartelera.BackgroundImage")));
            this.picCartelera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCartelera.Location = new System.Drawing.Point(20, 211);
            this.picCartelera.Name = "picCartelera";
            this.picCartelera.Size = new System.Drawing.Size(65, 67);
            this.picCartelera.TabIndex = 9;
            this.picCartelera.TabStop = false;
            this.picCartelera.Click += new System.EventHandler(this.picCartelera_Click);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 92);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 16);
            this.label26.TabIndex = 8;
            this.label26.Text = "Punto de Venta";
            // 
            // picPuntodeVenta
            // 
            this.picPuntodeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPuntodeVenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPuntodeVenta.BackgroundImage")));
            this.picPuntodeVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPuntodeVenta.Location = new System.Drawing.Point(20, 22);
            this.picPuntodeVenta.Name = "picPuntodeVenta";
            this.picPuntodeVenta.Size = new System.Drawing.Size(65, 67);
            this.picPuntodeVenta.TabIndex = 7;
            this.picPuntodeVenta.TabStop = false;
            this.picPuntodeVenta.Click += new System.EventHandler(this.picVenta_Click);
            // 
            // lblCleitnes
            // 
            this.lblCleitnes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCleitnes.AutoSize = true;
            this.lblCleitnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleitnes.Location = new System.Drawing.Point(23, 383);
            this.lblCleitnes.Name = "lblCleitnes";
            this.lblCleitnes.Size = new System.Drawing.Size(50, 16);
            this.lblCleitnes.TabIndex = 6;
            this.lblCleitnes.Text = "Socios";
            // 
            // picSocios
            // 
            this.picSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSocios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSocios.BackgroundImage")));
            this.picSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSocios.Location = new System.Drawing.Point(20, 312);
            this.picSocios.Name = "picSocios";
            this.picSocios.Size = new System.Drawing.Size(65, 68);
            this.picSocios.TabIndex = 5;
            this.picSocios.TabStop = false;
            this.picSocios.Click += new System.EventHandler(this.picSocios_Click);
            // 
            // lblLibros
            // 
            this.lblLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibros.AutoSize = true;
            this.lblLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(22, 188);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(63, 16);
            this.lblLibros.TabIndex = 3;
            this.lblLibros.Text = "Peliculas";
            // 
            // picPeliculas
            // 
            this.picPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPeliculas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPeliculas.BackgroundImage")));
            this.picPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPeliculas.Location = new System.Drawing.Point(20, 124);
            this.picPeliculas.Name = "picPeliculas";
            this.picPeliculas.Size = new System.Drawing.Size(65, 61);
            this.picPeliculas.TabIndex = 0;
            this.picPeliculas.TabStop = false;
            this.picPeliculas.Click += new System.EventHandler(this.picPeliculas_Click);
            // 
            // frmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Bibliotecario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCartelera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPuntodeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox picPuntodeVenta;
        private System.Windows.Forms.Label lblCleitnes;
        private System.Windows.Forms.PictureBox picSocios;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.PictureBox picPeliculas;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.PictureBox picCartelera;
    }
}

