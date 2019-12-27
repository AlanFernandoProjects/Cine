using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBibliotecaFinal
{
    public partial class frmSocios : Form
    {
        string Registro;

        public frmSocios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNumeroTarjeta.Text==string.Empty||
                txtApellidoPaterno.Text==string.Empty||
                txtApellidoMaterno.Text==string.Empty||
                txtNombre.Text==string.Empty||
                txtCurp.Text==string.Empty)
            {
                MessageBox.Show("Asegure de Completar Todos los Campos");
            }
            else
            {
                try
                {
                    // Conecta con base de datos con cadena de conexion del archivo App.config
                    string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                    // Crea objeto de conexión
                    SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                    conexionSQL.Open(); // Abre conexión
                                        // Define cadena SQL a ejecutar
                    string cadenaSQL = @"INSERT INTO Socio(NumTarjeta, ApellidoPaterno, ApellidoMaterno, Nombre, FechaNacimiento, FechaDeAlta
                                    ,CURP) VALUES(@NumTarjeta,@ApellidoPaterno, @ApellidoMaterno, @Nombre, @FechaNacimiento,@FechaAlta,@CURP)";


                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parNumTarjeta = new SqlParameter("@NumTarjeta", SqlDbType.VarChar);
                    parNumTarjeta.Value = txtNumeroTarjeta.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parApellidoPaterno = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    parApellidoPaterno.Value = txtApellidoPaterno.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parApellidoMaterno = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    parApellidoMaterno.Value = txtApellidoMaterno.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    parNombre.Value = txtNombre.Text;

                    // Crea parametros y asigna valores para el campo Localidad
                    SqlParameter parFechaNacimiento = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    parFechaNacimiento.Value = dtpFechaNacimiento.Value.Date;

                    // Crea parametros y asigna valores para el campo Localidad
                    SqlParameter parFechaDeAlta = new SqlParameter("@FechaAlta", SqlDbType.Date);
                    parFechaDeAlta.Value = dtpFechaRegistro.Value.Date;

                    // Crea parametros y asigna valores para el campo Localidad
                    SqlParameter parCURP = new SqlParameter("@CURP", SqlDbType.VarChar);
                    parCURP.Value = txtCurp.Text;


                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parNumTarjeta);
                    comandoSQL.Parameters.Add(parApellidoPaterno);
                    comandoSQL.Parameters.Add(parApellidoMaterno);
                    comandoSQL.Parameters.Add(parNombre);
                    comandoSQL.Parameters.Add(parCURP);
                    comandoSQL.Parameters.Add(parFechaNacimiento);
                    comandoSQL.Parameters.Add(parFechaDeAlta);

                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        cadenaSQL = "SELECT @@IDENTITY";
                        comandoSQL.CommandText = cadenaSQL;
                        string IDSocio = comandoSQL.ExecuteScalar().ToString();
                        MessageBox.Show("SOCIO REGISTRADO SATISFACTORIAMENTE CON EL NUMERO: " + IDSocio);

                        this.socioTableAdapter.Fill(this.sistemaCine4DataSet2.Socio); //Actualiza los DataGridView

                        txtNumeroTarjeta.Clear();
                        txtApellidoPaterno.Clear();
                        txtApellidoMaterno.Clear();
                        txtNombre.Clear();
                        txtCurp.Clear();
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    txtNumeroTarjeta.Clear();
                    txtApellidoPaterno.Clear();
                    txtApellidoMaterno.Clear();
                    txtNombre.Clear();
                    txtCurp.Clear();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroTarjeta.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtNombre.Clear();
            txtCurp.Clear();
        }

        

        private void frmSocios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaCine4DataSet2.Socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.sistemaCine4DataSet2.Socio);
        }
        
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == string.Empty)
            {
                MessageBox.Show("Introduzca la Informacion de Busqueda");
            }
            else
            {
                try
                {
                    this.socioTableAdapter.FillBy(this.sistemaCine4DataSet2.Socio, txtBusqueda.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

        }

      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Registro == null)
            {
                MessageBox.Show("Seleccione el Campo Numero Tarjeta para Eliminar");
            }
            else
            {
                if (MessageBox.Show("¿DESEA ELIMINAR ESTE REGISTRO?", "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    try
                    {
                        // Conecta con base de datos con cadena de conexion del archivo App.config
                        string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                        // Crea objeto de conexión
                        SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                        conexionSQL.Open(); // Abre conexión
                                            // Define cadena SQL a ejecutar
                        string cadenaSQL = @"DELETE FROM Socio WHERE socioID=@IDSocio";

                        // Crea commando SQL
                        SqlCommand comandoSQL = conexionSQL.CreateCommand();
                        comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                        comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                        // Crea parametros y asigna valores para el campo Nombre del Cliente
                        SqlParameter parSocioID = new SqlParameter("@IDSocio", SqlDbType.Int);
                        parSocioID.Value = Registro;

                        // Agrega parámetros al comando
                        comandoSQL.Parameters.Add(parSocioID);

                        // Ejecuta la consulta
                        int regInsertados = comandoSQL.ExecuteNonQuery();

                        if (regInsertados > 0) // Verifica si se registro el cliente
                        {
                            cadenaSQL = "SELECT @@IDENTITY";
                            comandoSQL.CommandText = cadenaSQL;
                            string IDSocio = comandoSQL.ExecuteScalar().ToString();
                            MessageBox.Show("SOCIO ELIMINADO SATISFACTORIAMENTE");

                            this.socioTableAdapter.Fill(this.sistemaCine4DataSet2.Socio);
                        }
                        conexionSQL.Close(); // Cierra conexion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnUsuMod_Click(object sender, EventArgs e)
        {
            if (txtIDSocio.Text == string.Empty || txtMNumeroTarjetaM.Text == string.Empty || txtApellidoPM.Text == string.Empty ||
                txtApellidoMM.Text == string.Empty || txtNombreM.Text == string.Empty || txtCurpM.Text == string.Empty)
            {
                MessageBox.Show("Asegurese de Completar Todos los Campos");
            }
            else
            {
                try
                {
                    // Conecta con base de datos con cadena de conexion del archivo App.config
                    string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                    // Crea objeto de conexión
                    SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                    conexionSQL.Open(); // Abre conexión
                                        // Define cadena SQL a ejecutar
                    string cadenaSQL = @"UPDATE Socio SET NumTarjeta=@NumTarjeta, ApellidoPaterno=@ApellidoPaterno, ApellidoMaterno=@ApellidoMaterno
                                    ,Nombre=@Nombre, FechaNacimiento=@FechaNacimiento, CURP=@CURP WHERE socioID=@IDSocio ";


                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parSocioID = new SqlParameter("@IDSocio", SqlDbType.Int);
                    parSocioID.Value = txtIDSocio.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parNumTarjeta = new SqlParameter("@NumTarjeta", SqlDbType.VarChar);
                    parNumTarjeta.Value = txtMNumeroTarjetaM.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parApellidoPaterno = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    parApellidoPaterno.Value = txtApellidoPM.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parApellidoMaterno = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    parApellidoMaterno.Value = txtApellidoMM.Text;

                    // Crea parametros y asigna valores para el campo Nombre del Cliente
                    SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    parNombre.Value = txtNombreM.Text;

                    // Crea parametros y asigna valores para el campo Localidad
                    SqlParameter parFechaNacimiento = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
                    parFechaNacimiento.Value = dtpFechaNacM.Value.Date;

                    // Crea parametros y asigna valores para el campo Localidad
                    SqlParameter parCURP = new SqlParameter("@CURP", SqlDbType.VarChar);
                    parCURP.Value = txtCurpM.Text;


                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parSocioID);
                    comandoSQL.Parameters.Add(parNumTarjeta);
                    comandoSQL.Parameters.Add(parApellidoPaterno);
                    comandoSQL.Parameters.Add(parApellidoMaterno);
                    comandoSQL.Parameters.Add(parNombre);
                    comandoSQL.Parameters.Add(parCURP);
                    comandoSQL.Parameters.Add(parFechaNacimiento);


                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        MessageBox.Show("SOCIO MODIFICADO SATISFACTORIAMENTE");

                        this.socioTableAdapter.Fill(this.sistemaCine4DataSet2.Socio);

                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    txtIDSocio.Clear();
                    txtMNumeroTarjetaM.Clear();
                    txtApellidoMM.Clear();
                    txtApellidoPM.Clear();
                    txtCurpM.Clear();
                }
            }
        }

         

       

        private void ObtenerReg(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView3.Rows[e.RowIndex];
            txtIDSocio.Text = dgv.Cells[8].Value.ToString();
            txtMNumeroTarjetaM.Text = dgv.Cells[0].Value.ToString();
            txtApellidoPM.Text = dgv.Cells[1].Value.ToString();
            txtApellidoMM.Text = dgv.Cells[2].Value.ToString();
            txtNombreM.Text = dgv.Cells[3].Value.ToString();
            txtCurpM.Text = dgv.Cells[4].Value.ToString();
            dtpFechaNacM.Text = dgv.Cells[5].Value.ToString();

            txtMNumeroTarjetaM.Enabled = true;
            txtApellidoPM.Enabled = true;
            txtApellidoMM.Enabled = true;
            txtNombreM.Enabled = true;
            txtCurpM.Enabled = true;
            dtpFechaNacM.Enabled = true;
        }

        private void btnUsuModLimpiar_Click(object sender, EventArgs e)
        {
            txtMNumeroTarjetaM.Enabled = false;
            txtApellidoPM.Enabled = false;
            txtApellidoMM.Enabled = false;
            txtNombreM.Enabled = false;
            txtCurpM.Enabled = false;
            dtpFechaNacM.Enabled = false;

            txtMNumeroTarjetaM.Clear();
            txtApellidoPM.Clear();
            txtApellidoMM.Clear();
            txtNombreM.Clear(); ;
            txtCurpM.Clear();
        }

        private void SeleccionarReg(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView3.Rows[e.RowIndex];
            Registro = dgv.Cells[8].Value.ToString();
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.socioTableAdapter.FillBy(this.sistemaCine4DataSet2.Socio, apellidoPaternoToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }

   
  
}