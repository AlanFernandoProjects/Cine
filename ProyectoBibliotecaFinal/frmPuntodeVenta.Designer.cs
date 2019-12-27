namespace ProyectoBibliotecaFinal
{
    partial class frmPuntodeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpBuscarCartelera = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCartelera = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvBuscarCartelera = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdulto = new System.Windows.Forms.RadioButton();
            this.rbNiño = new System.Windows.Forms.RadioButton();
            this.rbTerceraEdad = new System.Windows.Forms.RadioButton();
            this.txtTarjetaSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalaVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTituloVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdiomaVenta = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechayHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.lblCambioVenta = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPagoCliente = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCartelera)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPagoCliente);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCantidadVenta);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtIdiomaVenta);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTituloVenta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSalaVenta);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtFechaVenta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtTarjetaSocio);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtpBuscarCartelera);
            this.tabPage1.Controls.Add(this.btnBuscarCartelera);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.dgvBuscarCartelera);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Punto de Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dtpBuscarCartelera
            // 
            this.dtpBuscarCartelera.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBuscarCartelera.Location = new System.Drawing.Point(210, 35);
            this.dtpBuscarCartelera.Name = "dtpBuscarCartelera";
            this.dtpBuscarCartelera.Size = new System.Drawing.Size(307, 22);
            this.dtpBuscarCartelera.TabIndex = 163;
            this.dtpBuscarCartelera.Value = new System.DateTime(2018, 1, 8, 22, 19, 6, 0);
            // 
            // btnBuscarCartelera
            // 
            this.btnBuscarCartelera.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBuscarCartelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCartelera.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCartelera.Location = new System.Drawing.Point(542, 30);
            this.btnBuscarCartelera.Name = "btnBuscarCartelera";
            this.btnBuscarCartelera.Size = new System.Drawing.Size(130, 34);
            this.btnBuscarCartelera.TabIndex = 162;
            this.btnBuscarCartelera.Text = "Buscar";
            this.btnBuscarCartelera.UseVisualStyleBackColor = false;
            this.btnBuscarCartelera.Click += new System.EventHandler(this.btnBuscarCartelera_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(181, 20);
            this.label24.TabIndex = 161;
            this.label24.Text = "Busqueda por Fecha:";
            // 
            // dgvBuscarCartelera
            // 
            this.dgvBuscarCartelera.AllowUserToOrderColumns = true;
            this.dgvBuscarCartelera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscarCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCartelera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.FechayHora,
            this.Idioma,
            this.Sala});
            this.dgvBuscarCartelera.Location = new System.Drawing.Point(34, 85);
            this.dgvBuscarCartelera.Name = "dgvBuscarCartelera";
            this.dgvBuscarCartelera.Size = new System.Drawing.Size(444, 124);
            this.dgvBuscarCartelera.TabIndex = 160;
            this.dgvBuscarCartelera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObtenerRegistros);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 159;
            this.label4.Text = "Busqueda:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.rbTerceraEdad);
            this.groupBox1.Controls.Add(this.rbNiño);
            this.groupBox1.Controls.Add(this.rbAdulto);
            this.groupBox1.Location = new System.Drawing.Point(33, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 86);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edad";
            // 
            // rbAdulto
            // 
            this.rbAdulto.AutoSize = true;
            this.rbAdulto.Location = new System.Drawing.Point(22, 41);
            this.rbAdulto.Name = "rbAdulto";
            this.rbAdulto.Size = new System.Drawing.Size(64, 20);
            this.rbAdulto.TabIndex = 0;
            this.rbAdulto.TabStop = true;
            this.rbAdulto.Text = "Adulto";
            this.rbAdulto.UseVisualStyleBackColor = true;
            // 
            // rbNiño
            // 
            this.rbNiño.AutoSize = true;
            this.rbNiño.Location = new System.Drawing.Point(116, 41);
            this.rbNiño.Name = "rbNiño";
            this.rbNiño.Size = new System.Drawing.Size(54, 20);
            this.rbNiño.TabIndex = 1;
            this.rbNiño.TabStop = true;
            this.rbNiño.Text = "Niño";
            this.rbNiño.UseVisualStyleBackColor = true;
            // 
            // rbTerceraEdad
            // 
            this.rbTerceraEdad.AutoSize = true;
            this.rbTerceraEdad.Location = new System.Drawing.Point(199, 41);
            this.rbTerceraEdad.Name = "rbTerceraEdad";
            this.rbTerceraEdad.Size = new System.Drawing.Size(110, 20);
            this.rbTerceraEdad.TabIndex = 2;
            this.rbTerceraEdad.TabStop = true;
            this.rbTerceraEdad.Text = "Tercera Edad";
            this.rbTerceraEdad.UseVisualStyleBackColor = true;
            // 
            // txtTarjetaSocio
            // 
            this.txtTarjetaSocio.Location = new System.Drawing.Point(34, 358);
            this.txtTarjetaSocio.MaxLength = 10;
            this.txtTarjetaSocio.Name = "txtTarjetaSocio";
            this.txtTarjetaSocio.Size = new System.Drawing.Size(100, 22);
            this.txtTarjetaSocio.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 166;
            this.label1.Text = "Tarjeta Socio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 168;
            this.label2.Text = "Fecha";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Enabled = false;
            this.txtFechaVenta.Location = new System.Drawing.Point(511, 104);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(100, 22);
            this.txtFechaVenta.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 170;
            this.label3.Text = "Sala";
            // 
            // txtSalaVenta
            // 
            this.txtSalaVenta.Enabled = false;
            this.txtSalaVenta.Location = new System.Drawing.Point(511, 192);
            this.txtSalaVenta.Name = "txtSalaVenta";
            this.txtSalaVenta.Size = new System.Drawing.Size(100, 22);
            this.txtSalaVenta.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 172;
            this.label5.Text = "Titulo";
            // 
            // txtTituloVenta
            // 
            this.txtTituloVenta.Enabled = false;
            this.txtTituloVenta.Location = new System.Drawing.Point(634, 104);
            this.txtTituloVenta.Name = "txtTituloVenta";
            this.txtTituloVenta.Size = new System.Drawing.Size(100, 22);
            this.txtTituloVenta.TabIndex = 171;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 174;
            this.label6.Text = "Idioma";
            // 
            // txtIdiomaVenta
            // 
            this.txtIdiomaVenta.Enabled = false;
            this.txtIdiomaVenta.Location = new System.Drawing.Point(511, 148);
            this.txtIdiomaVenta.Name = "txtIdiomaVenta";
            this.txtIdiomaVenta.Size = new System.Drawing.Size(100, 22);
            this.txtIdiomaVenta.TabIndex = 173;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(634, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 43);
            this.btnCancelar.TabIndex = 175;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // FechayHora
            // 
            this.FechayHora.DataPropertyName = "FechayHora";
            this.FechayHora.HeaderText = "Fecha ";
            this.FechayHora.Name = "FechayHora";
            // 
            // Idioma
            // 
            this.Idioma.DataPropertyName = "Idioma";
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(262, 15);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(115, 66);
            this.btnPagar.TabIndex = 176;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 178;
            this.label7.Text = "Cantidad";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(149, 358);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadVenta.TabIndex = 177;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 31);
            this.label8.TabIndex = 180;
            this.label8.Text = "Total a Pagar:";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(178, 122);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(55, 31);
            this.lblTotalAPagar.TabIndex = 181;
            this.lblTotalAPagar.Text = "0.0";
            // 
            // lblCambioVenta
            // 
            this.lblCambioVenta.AutoSize = true;
            this.lblCambioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioVenta.Location = new System.Drawing.Point(9, 42);
            this.lblCambioVenta.Name = "lblCambioVenta";
            this.lblCambioVenta.Size = new System.Drawing.Size(42, 25);
            this.lblCambioVenta.TabIndex = 183;
            this.lblCambioVenta.Text = "0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 182;
            this.label11.Text = "Cambio:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnRealizarVenta);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblCambioVenta);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTotalAPagar);
            this.groupBox2.Controls.Add(this.btnPagar);
            this.groupBox2.Location = new System.Drawing.Point(382, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 160);
            this.groupBox2.TabIndex = 184;
            this.groupBox2.TabStop = false;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Enabled = false;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.Location = new System.Drawing.Point(262, 88);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(115, 66);
            this.btnRealizarVenta.TabIndex = 185;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 186;
            this.label9.Text = "Pago Cliente:";
            // 
            // txtPagoCliente
            // 
            this.txtPagoCliente.Location = new System.Drawing.Point(266, 358);
            this.txtPagoCliente.Name = "txtPagoCliente";
            this.txtPagoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtPagoCliente.TabIndex = 185;
            // 
            // frmPuntodeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 445);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntodeVenta";
            this.Text = "frmPuntodeVenta";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCartelera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpBuscarCartelera;
        private System.Windows.Forms.Button btnBuscarCartelera;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvBuscarCartelera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdiomaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTituloVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarjetaSocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTerceraEdad;
        private System.Windows.Forms.RadioButton rbNiño;
        private System.Windows.Forms.RadioButton rbAdulto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechayHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCambioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPagoCliente;
    }
}