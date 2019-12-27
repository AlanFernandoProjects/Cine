namespace ProyectoBibliotecaFinal
{
    partial class frmPeliculas
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
            this.components = new System.ComponentModel.Container();
            this.tabUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picModPortadaPel = new System.Windows.Forms.PictureBox();
            this.txtModIDBuscarPel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModDuraPelicula = new System.Windows.Forms.ComboBox();
            this.dtpModEstrenoPel = new System.Windows.Forms.DateTimePicker();
            this.txtModActPel = new System.Windows.Forms.RichTextBox();
            this.txtModDesPel = new System.Windows.Forms.RichTextBox();
            this.txtModTituloPel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUsuModLimpiar = new System.Windows.Forms.Button();
            this.btnUsuMod = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEliminarPelicula = new System.Windows.Forms.DataGridView();
            this.peliculaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarPeliculaEliminar = new System.Windows.Forms.Button();
            this.txtBusquedaEliminarPelicula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pagBucarUsuario = new System.Windows.Forms.TabPage();
            this.dgvBuscarPelicula = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarPelicula = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBusquedaPelicula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbAltaDuracion = new System.Windows.Forms.ComboBox();
            this.txtAltaActores = new System.Windows.Forms.RichTextBox();
            this.txtAltaDecripcion = new System.Windows.Forms.RichTextBox();
            this.txtAltaTitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpAltaEstreno = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAltaLimpiar = new System.Windows.Forms.Button();
            this.btnAltaRegistrar = new System.Windows.Forms.Button();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaCine4DataSet1 = new ProyectoBibliotecaFinal.SistemaCine4DataSet1();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.peliculaTableAdapter = new ProyectoBibliotecaFinal.SistemaCine4DataSet1TableAdapters.PeliculaTableAdapter();
            this.tabUsuarios.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModPortadaPel)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPelicula)).BeginInit();
            this.pagBucarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPelicula)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCine4DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.tabPage3);
            this.tabUsuarios.Controls.Add(this.tabPage4);
            this.tabUsuarios.Controls.Add(this.pagBucarUsuario);
            this.tabUsuarios.Controls.Add(this.tabPage5);
            this.tabUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUsuarios.Location = new System.Drawing.Point(0, -1);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.SelectedIndex = 0;
            this.tabUsuarios.Size = new System.Drawing.Size(776, 447);
            this.tabUsuarios.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.txtModIDBuscarPel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cbModDuraPelicula);
            this.tabPage3.Controls.Add(this.dtpModEstrenoPel);
            this.tabPage3.Controls.Add(this.txtModActPel);
            this.tabPage3.Controls.Add(this.txtModDesPel);
            this.tabPage3.Controls.Add(this.txtModTituloPel);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnUsuModLimpiar);
            this.tabPage3.Controls.Add(this.btnUsuMod);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 414);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Modificar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(219, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 191;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.picModPortadaPel);
            this.groupBox1.Location = new System.Drawing.Point(498, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 299);
            this.groupBox1.TabIndex = 190;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Portada Pelicula:";
            // 
            // picModPortadaPel
            // 
            this.picModPortadaPel.Enabled = false;
            this.picModPortadaPel.Location = new System.Drawing.Point(6, 25);
            this.picModPortadaPel.Name = "picModPortadaPel";
            this.picModPortadaPel.Size = new System.Drawing.Size(229, 262);
            this.picModPortadaPel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picModPortadaPel.TabIndex = 185;
            this.picModPortadaPel.TabStop = false;
            this.picModPortadaPel.Click += new System.EventHandler(this.picModPortadaPel_Click);
            // 
            // txtModIDBuscarPel
            // 
            this.txtModIDBuscarPel.Location = new System.Drawing.Point(96, 12);
            this.txtModIDBuscarPel.Name = "txtModIDBuscarPel";
            this.txtModIDBuscarPel.Size = new System.Drawing.Size(100, 26);
            this.txtModIDBuscarPel.TabIndex = 189;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 188;
            this.label1.Text = "ID Pelicula";
            // 
            // cbModDuraPelicula
            // 
            this.cbModDuraPelicula.Enabled = false;
            this.cbModDuraPelicula.FormattingEnabled = true;
            this.cbModDuraPelicula.Items.AddRange(new object[] {
            "1:20",
            "1:25",
            "1:30",
            "1:35",
            "1:40",
            "1:45",
            "1:50",
            "1:55",
            "2:00",
            "2:05",
            "2:10",
            "2:20",
            "2:30",
            "2:40",
            "2:50",
            "3:00",
            "3:30"});
            this.cbModDuraPelicula.Location = new System.Drawing.Point(13, 382);
            this.cbModDuraPelicula.Name = "cbModDuraPelicula";
            this.cbModDuraPelicula.Size = new System.Drawing.Size(121, 28);
            this.cbModDuraPelicula.TabIndex = 187;
            // 
            // dtpModEstrenoPel
            // 
            this.dtpModEstrenoPel.Enabled = false;
            this.dtpModEstrenoPel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModEstrenoPel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModEstrenoPel.Location = new System.Drawing.Point(13, 311);
            this.dtpModEstrenoPel.MinDate = new System.DateTime(2018, 1, 10, 0, 0, 0, 0);
            this.dtpModEstrenoPel.Name = "dtpModEstrenoPel";
            this.dtpModEstrenoPel.Size = new System.Drawing.Size(183, 24);
            this.dtpModEstrenoPel.TabIndex = 165;
            this.dtpModEstrenoPel.Value = new System.DateTime(2018, 1, 10, 14, 59, 2, 0);
            // 
            // txtModActPel
            // 
            this.txtModActPel.Enabled = false;
            this.txtModActPel.Location = new System.Drawing.Point(243, 167);
            this.txtModActPel.Name = "txtModActPel";
            this.txtModActPel.Size = new System.Drawing.Size(223, 118);
            this.txtModActPel.TabIndex = 164;
            this.txtModActPel.Text = "";
            // 
            // txtModDesPel
            // 
            this.txtModDesPel.Enabled = false;
            this.txtModDesPel.Location = new System.Drawing.Point(10, 167);
            this.txtModDesPel.Name = "txtModDesPel";
            this.txtModDesPel.Size = new System.Drawing.Size(223, 118);
            this.txtModDesPel.TabIndex = 163;
            this.txtModDesPel.Text = "";
            // 
            // txtModTituloPel
            // 
            this.txtModTituloPel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtModTituloPel.Enabled = false;
            this.txtModTituloPel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModTituloPel.Location = new System.Drawing.Point(10, 103);
            this.txtModTituloPel.Name = "txtModTituloPel";
            this.txtModTituloPel.Size = new System.Drawing.Size(243, 24);
            this.txtModTituloPel.TabIndex = 160;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 159;
            this.label15.Text = "Titulo:";
            // 
            // btnUsuModLimpiar
            // 
            this.btnUsuModLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUsuModLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuModLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnUsuModLimpiar.Location = new System.Drawing.Point(486, 375);
            this.btnUsuModLimpiar.Name = "btnUsuModLimpiar";
            this.btnUsuModLimpiar.Size = new System.Drawing.Size(130, 35);
            this.btnUsuModLimpiar.TabIndex = 155;
            this.btnUsuModLimpiar.Text = "Limpiar";
            this.btnUsuModLimpiar.UseVisualStyleBackColor = false;
            this.btnUsuModLimpiar.Click += new System.EventHandler(this.btnUsuModLimpiar_Click);
            // 
            // btnUsuMod
            // 
            this.btnUsuMod.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUsuMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuMod.ForeColor = System.Drawing.Color.Black;
            this.btnUsuMod.Location = new System.Drawing.Point(622, 375);
            this.btnUsuMod.Name = "btnUsuMod";
            this.btnUsuMod.Size = new System.Drawing.Size(130, 35);
            this.btnUsuMod.TabIndex = 154;
            this.btnUsuMod.Text = "Modificar";
            this.btnUsuMod.UseVisualStyleBackColor = false;
            this.btnUsuMod.Click += new System.EventHandler(this.btnUsuMod_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 151;
            this.label5.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 149;
            this.label6.Text = "Actores:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 147;
            this.label7.Text = "Duracion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(663, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 20);
            this.label18.TabIndex = 141;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(9, 288);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(69, 20);
            this.label56.TabIndex = 140;
            this.label56.Text = "Estreno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(658, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 104;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dgvEliminarPelicula);
            this.tabPage4.Controls.Add(this.btnBuscarPeliculaEliminar);
            this.tabPage4.Controls.Add(this.txtBusquedaEliminarPelicula);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 414);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 162;
            this.label3.Text = "Busqueda por Titulo:";
            // 
            // dgvEliminarPelicula
            // 
            this.dgvEliminarPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peliculaID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.dgvEliminarPelicula.Location = new System.Drawing.Point(19, 93);
            this.dgvEliminarPelicula.Name = "dgvEliminarPelicula";
            this.dgvEliminarPelicula.Size = new System.Drawing.Size(730, 255);
            this.dgvEliminarPelicula.TabIndex = 161;
            this.dgvEliminarPelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObtenerRegistro);
            // 
            // peliculaID
            // 
            this.peliculaID.DataPropertyName = "peliculaID";
            this.peliculaID.HeaderText = "ID Pelicula";
            this.peliculaID.Name = "peliculaID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Actores";
            this.dataGridViewTextBoxColumn3.HeaderText = "Actores";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estreno";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estreno";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Imagen";
            this.dataGridViewImageColumn1.DividerWidth = 20;
            this.dataGridViewImageColumn1.FillWeight = 500F;
            this.dataGridViewImageColumn1.HeaderText = "Imagen";
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 206;
            // 
            // btnBuscarPeliculaEliminar
            // 
            this.btnBuscarPeliculaEliminar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBuscarPeliculaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPeliculaEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPeliculaEliminar.Location = new System.Drawing.Point(582, 43);
            this.btnBuscarPeliculaEliminar.Name = "btnBuscarPeliculaEliminar";
            this.btnBuscarPeliculaEliminar.Size = new System.Drawing.Size(130, 35);
            this.btnBuscarPeliculaEliminar.TabIndex = 160;
            this.btnBuscarPeliculaEliminar.Text = "Buscar";
            this.btnBuscarPeliculaEliminar.UseVisualStyleBackColor = false;
            this.btnBuscarPeliculaEliminar.Click += new System.EventHandler(this.btnBuscarPeliculaEliminar_Click);
            // 
            // txtBusquedaEliminarPelicula
            // 
            this.txtBusquedaEliminarPelicula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBusquedaEliminarPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaEliminarPelicula.Location = new System.Drawing.Point(178, 49);
            this.txtBusquedaEliminarPelicula.Name = "txtBusquedaEliminarPelicula";
            this.txtBusquedaEliminarPelicula.Size = new System.Drawing.Size(364, 24);
            this.txtBusquedaEliminarPelicula.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 158;
            this.label2.Text = "Busqueda:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(620, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 35);
            this.btnEliminar.TabIndex = 156;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pagBucarUsuario
            // 
            this.pagBucarUsuario.AutoScroll = true;
            this.pagBucarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pagBucarUsuario.Controls.Add(this.dgvBuscarPelicula);
            this.pagBucarUsuario.Controls.Add(this.btnBuscarPelicula);
            this.pagBucarUsuario.Controls.Add(this.label24);
            this.pagBucarUsuario.Controls.Add(this.txtBusquedaPelicula);
            this.pagBucarUsuario.Controls.Add(this.label4);
            this.pagBucarUsuario.Location = new System.Drawing.Point(4, 29);
            this.pagBucarUsuario.Name = "pagBucarUsuario";
            this.pagBucarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.pagBucarUsuario.Size = new System.Drawing.Size(768, 414);
            this.pagBucarUsuario.TabIndex = 3;
            this.pagBucarUsuario.Text = "Buscar";
            // 
            // dgvBuscarPelicula
            // 
            this.dgvBuscarPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Descripcion,
            this.Actores,
            this.Estreno,
            this.Duracion,
            this.Imagen});
            this.dgvBuscarPelicula.Location = new System.Drawing.Point(16, 94);
            this.dgvBuscarPelicula.Name = "dgvBuscarPelicula";
            this.dgvBuscarPelicula.Size = new System.Drawing.Size(730, 282);
            this.dgvBuscarPelicula.TabIndex = 158;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Titulo";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Actores
            // 
            this.Actores.DataPropertyName = "Actores";
            this.Actores.HeaderText = "Actores";
            this.Actores.Name = "Actores";
            // 
            // Estreno
            // 
            this.Estreno.DataPropertyName = "Estreno";
            this.Estreno.HeaderText = "Estreno";
            this.Estreno.Name = "Estreno";
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "Duracion";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.DividerWidth = 20;
            this.Imagen.FillWeight = 500F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.MinimumWidth = 50;
            this.Imagen.Name = "Imagen";
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imagen.Width = 206;
            // 
            // btnBuscarPelicula
            // 
            this.btnBuscarPelicula.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBuscarPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPelicula.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarPelicula.Location = new System.Drawing.Point(616, 33);
            this.btnBuscarPelicula.Name = "btnBuscarPelicula";
            this.btnBuscarPelicula.Size = new System.Drawing.Size(130, 35);
            this.btnBuscarPelicula.TabIndex = 157;
            this.btnBuscarPelicula.Text = "Buscar";
            this.btnBuscarPelicula.UseVisualStyleBackColor = false;
            this.btnBuscarPelicula.Click += new System.EventHandler(this.btnBuscarPelicula_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 20);
            this.label24.TabIndex = 142;
            this.label24.Text = "Busqueda por Titulo:";
            // 
            // txtBusquedaPelicula
            // 
            this.txtBusquedaPelicula.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBusquedaPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaPelicula.Location = new System.Drawing.Point(212, 39);
            this.txtBusquedaPelicula.Name = "txtBusquedaPelicula";
            this.txtBusquedaPelicula.Size = new System.Drawing.Size(364, 24);
            this.txtBusquedaPelicula.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Busqueda:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.cbAltaDuracion);
            this.tabPage5.Controls.Add(this.txtAltaActores);
            this.tabPage5.Controls.Add(this.txtAltaDecripcion);
            this.tabPage5.Controls.Add(this.txtAltaTitulo);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.dtpAltaEstreno);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.btnAltaLimpiar);
            this.tabPage5.Controls.Add(this.btnAltaRegistrar);
            this.tabPage5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 414);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Registrar";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(499, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 299);
            this.groupBox2.TabIndex = 187;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Portada Pelicula:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 185;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbAltaDuracion
            // 
            this.cbAltaDuracion.FormattingEnabled = true;
            this.cbAltaDuracion.Items.AddRange(new object[] {
            "1:20",
            "1:25",
            "1:30",
            "1:35",
            "1:40",
            "1:45",
            "1:50",
            "1:55",
            "2:00",
            "2:05",
            "2:10",
            "2:20",
            "2:30",
            "2:40",
            "2:50",
            "3:00",
            "3:30"});
            this.cbAltaDuracion.Location = new System.Drawing.Point(12, 360);
            this.cbAltaDuracion.Name = "cbAltaDuracion";
            this.cbAltaDuracion.Size = new System.Drawing.Size(121, 28);
            this.cbAltaDuracion.TabIndex = 186;
            // 
            // txtAltaActores
            // 
            this.txtAltaActores.Location = new System.Drawing.Point(257, 133);
            this.txtAltaActores.Name = "txtAltaActores";
            this.txtAltaActores.Size = new System.Drawing.Size(223, 118);
            this.txtAltaActores.TabIndex = 184;
            this.txtAltaActores.Text = "";
            // 
            // txtAltaDecripcion
            // 
            this.txtAltaDecripcion.Location = new System.Drawing.Point(12, 133);
            this.txtAltaDecripcion.Name = "txtAltaDecripcion";
            this.txtAltaDecripcion.Size = new System.Drawing.Size(223, 118);
            this.txtAltaDecripcion.TabIndex = 183;
            this.txtAltaDecripcion.Text = "";
            // 
            // txtAltaTitulo
            // 
            this.txtAltaTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAltaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltaTitulo.Location = new System.Drawing.Point(10, 73);
            this.txtAltaTitulo.Name = "txtAltaTitulo";
            this.txtAltaTitulo.Size = new System.Drawing.Size(243, 24);
            this.txtAltaTitulo.TabIndex = 180;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 179;
            this.label14.Text = "Titulo:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 20);
            this.label20.TabIndex = 178;
            this.label20.Text = "Descripcion:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(253, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 20);
            this.label21.TabIndex = 177;
            this.label21.Text = "Actores:";
            // 
            // dtpAltaEstreno
            // 
            this.dtpAltaEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAltaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAltaEstreno.Location = new System.Drawing.Point(12, 292);
            this.dtpAltaEstreno.MinDate = new System.DateTime(2018, 1, 10, 0, 0, 0, 0);
            this.dtpAltaEstreno.Name = "dtpAltaEstreno";
            this.dtpAltaEstreno.Size = new System.Drawing.Size(183, 24);
            this.dtpAltaEstreno.TabIndex = 174;
            this.dtpAltaEstreno.Value = new System.DateTime(2018, 1, 10, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 171;
            this.label8.Text = "Duracion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(652, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 170;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 169;
            this.label11.Text = "Estreno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(647, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 168;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(214, 20);
            this.label19.TabIndex = 135;
            this.label19.Text = "Ingrese Datos la Pelicula:";
            // 
            // btnAltaLimpiar
            // 
            this.btnAltaLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAltaLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnAltaLimpiar.Location = new System.Drawing.Point(474, 360);
            this.btnAltaLimpiar.Name = "btnAltaLimpiar";
            this.btnAltaLimpiar.Size = new System.Drawing.Size(130, 35);
            this.btnAltaLimpiar.TabIndex = 134;
            this.btnAltaLimpiar.Text = "Limpiar";
            this.btnAltaLimpiar.UseVisualStyleBackColor = false;
            this.btnAltaLimpiar.Click += new System.EventHandler(this.btnAltaLimpiar_Click);
            // 
            // btnAltaRegistrar
            // 
            this.btnAltaRegistrar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAltaRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnAltaRegistrar.Location = new System.Drawing.Point(622, 360);
            this.btnAltaRegistrar.Name = "btnAltaRegistrar";
            this.btnAltaRegistrar.Size = new System.Drawing.Size(130, 35);
            this.btnAltaRegistrar.TabIndex = 103;
            this.btnAltaRegistrar.Text = "Registrar";
            this.btnAltaRegistrar.UseVisualStyleBackColor = false;
            this.btnAltaRegistrar.Click += new System.EventHandler(this.btnAltaRegistrar_Click);
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataMember = "Pelicula";
            this.peliculaBindingSource.DataSource = this.sistemaCine4DataSet1;
            // 
            // sistemaCine4DataSet1
            // 
            this.sistemaCine4DataSet1.DataSetName = "SistemaCine4DataSet1";
            this.sistemaCine4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // peliculaTableAdapter
            // 
            this.peliculaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(776, 445);
            this.Controls.Add(this.tabUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeliculas";
            this.Text = "frmPeliculas";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            this.tabUsuarios.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picModPortadaPel)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPelicula)).EndInit();
            this.pagBucarUsuario.ResumeLayout(false);
            this.pagBucarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarPelicula)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCine4DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUsuarios;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtModTituloPel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUsuModLimpiar;
        private System.Windows.Forms.Button btnUsuMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage pagBucarUsuario;
        private System.Windows.Forms.Button btnBuscarPelicula;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBusquedaPelicula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAltaLimpiar;
        private System.Windows.Forms.Button btnAltaRegistrar;
        private System.Windows.Forms.DateTimePicker dtpModEstrenoPel;
        private System.Windows.Forms.RichTextBox txtModActPel;
        private System.Windows.Forms.RichTextBox txtModDesPel;
        private System.Windows.Forms.RichTextBox txtAltaActores;
        private System.Windows.Forms.RichTextBox txtAltaDecripcion;
        private System.Windows.Forms.TextBox txtAltaTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpAltaEstreno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private SistemaCine4DataSet1 sistemaCine4DataSet1;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private SistemaCine4DataSet1TableAdapters.PeliculaTableAdapter peliculaTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbAltaDuracion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picModPortadaPel;
        private System.Windows.Forms.TextBox txtModIDBuscarPel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModDuraPelicula;
        private System.Windows.Forms.Button btnBuscarPeliculaEliminar;
        private System.Windows.Forms.TextBox txtBusquedaEliminarPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBuscarPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridView dgvEliminarPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn peliculaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
    }
}