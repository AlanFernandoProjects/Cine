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
    public partial class frmCartelera : Form
    {
        int Registro;

        public frmCartelera()
        {
            InitializeComponent();
            
        }

        private void frmCartelera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaCine4DataSet5.Sala' Puede moverla o quitarla según sea necesario.
            this.salaTableAdapter.Fill(this.sistemaCine4DataSet5.Sala);
            // TODO: esta línea de código carga datos en la tabla 'sistemaCine4DataSet3.Pelicula' Puede moverla o quitarla según sea necesario.
            this.peliculaTableAdapter.Fill(this.sistemaCine4DataSet3.Pelicula);
            // TODO: esta línea de código carga datos en la tabla 'sistemaCine4DataSet4.Cartelera' Puede moverla o quitarla según sea necesario.
            //this.carteleraTableAdapter.Fill(this.sistemaCine4DataSet4.Cartelera);

        }

        private void btnRegistrarSala_Click(object sender, EventArgs e)
        {
            if (txtNumSala.Text == string.Empty || txtCapacidadSala.Text == string.Empty)
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
                    string cadenaSQL = @"INSERT INTO Sala(NumSala, Capacidad) VALUES(@NumSala, @Capacidad)";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando


                    SqlParameter parNumSala = new SqlParameter("@NumSala", SqlDbType.Int);
                    parNumSala.Value = txtNumSala.Text;

                    SqlParameter parCapacidad = new SqlParameter("@Capacidad", SqlDbType.Int);
                    parCapacidad.Value = txtCapacidadSala.Text;


                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parNumSala);
                    comandoSQL.Parameters.Add(parCapacidad);


                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        cadenaSQL = "SELECT @@IDENTITY";
                        comandoSQL.CommandText = cadenaSQL;
                        string IDSala = comandoSQL.ExecuteScalar().ToString();
                        MessageBox.Show("SALA REGISTRADA SATISFACTORIAMENTE CON EL NUMERO: " + IDSala);
                        txtNumSala.Clear();
                        txtCapacidadSala.Clear();
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbRegPelicula.Text == string.Empty || cbRegIdioma.Text == string.Empty || cbRegSala.Text == string.Empty)
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
                    string cadenaSQL = @"INSERT INTO Cartelera(Titulo, Idioma, FechayHora, Sala) 
                                    VALUES(@Titulo, @Idioma,@FechayHora, @Sala)";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando


                    SqlParameter parTitulo = new SqlParameter("@Titulo", SqlDbType.VarChar);
                    parTitulo.Value = cbRegPelicula.Text;

                    SqlParameter parIdioma = new SqlParameter("@Idioma", SqlDbType.VarChar);
                    parIdioma.Value = cbRegIdioma.Text;

                    SqlParameter parFechayHora = new SqlParameter("@FechayHora", SqlDbType.DateTime);
                    parFechayHora.Value = dtpRegFechayHora.Value;

                    SqlParameter parSala = new SqlParameter("@Sala", SqlDbType.Int);
                    parSala.Value = cbRegSala.Text;



                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parTitulo);
                    comandoSQL.Parameters.Add(parIdioma);
                    comandoSQL.Parameters.Add(parFechayHora);
                    comandoSQL.Parameters.Add(parSala);



                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        cadenaSQL = "SELECT @@IDENTITY";
                        comandoSQL.CommandText = cadenaSQL;
                        string IDCartelera = comandoSQL.ExecuteScalar().ToString();
                        MessageBox.Show("CARTELERA REGISTRADA SATISFACTORIAMENTE CON EL NUMERO: " + IDCartelera);
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscarCartelera_Click(object sender, EventArgs e)
        {
            try
            {
                // Conecta con base de datos con cadena de conexion del archivo App.config
                string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                // Crea objeto de conexión
                SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                conexionSQL.Open(); // Abre conexión
                // Define cadena SQL a ejecutar
                string cadenaSQL = @"SELECT * FROM Cartelera WHERE FechayHora=@FechayHora";

                // Crea commando SQL
                SqlCommand comandoSQL = conexionSQL.CreateCommand();
                comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                // Crea paramento para fechaEntrega
                SqlParameter parFechayHora = new SqlParameter("@FechayHora", SqlDbType.DateTime);
                parFechayHora.Value = dtpBuscarCartelera.Value;

                comandoSQL.Parameters.Add(parFechayHora);

                // Ejecuta consulta 
                SqlDataReader Datos = comandoSQL.ExecuteReader();
                // Creamos tabla en memoria
                DataTable tabla = new DataTable();
                // Carga los datos a la tabla
                tabla.Load(Datos);

                dgvBuscarCartelera.AutoGenerateColumns = false;
                dgvBuscarCartelera.DataSource = tabla;

                conexionSQL.Close(); // Cierra conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModCartelera_Click(object sender, EventArgs e)
        {
            if (cbModIdiomaCartelera.Text == string.Empty || cbModIdiomaCartelera.Text == string.Empty || cbModSalaCartelera.Text == string.Empty)
            {
                MessageBox.Show("Asegurese de Acompletar Todos los Campos");
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
                    string cadenaSQL = @"UPDATE Cartelera SET
                                    Titulo=@Titulo,
                                    Sala=@Sala, 
                                    Idioma=@Idioma,       
                                    FechayHora=@FechayHora
                                    WHERE carteleraID=@carteleraID";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    SqlParameter parPeliculaNombre = new SqlParameter("@Titulo", SqlDbType.VarChar);
                    parPeliculaNombre.Value = cbModPeliculaCartelera.Text;

                    SqlParameter parPeliculaIdioma = new SqlParameter("@Idioma", SqlDbType.VarChar);
                    parPeliculaIdioma.Value = cbModIdiomaCartelera.Text;

                    SqlParameter parPeliculaSala = new SqlParameter("@Sala", SqlDbType.Int);
                    parPeliculaSala.Value = cbModSalaCartelera.Text;

                    SqlParameter parFechayHora = new SqlParameter("@FechayHora", SqlDbType.DateTime);
                    parFechayHora.Value = dtpModFechayHora.Value;

                    SqlParameter parIDCartelera = new SqlParameter("@carteleraID", SqlDbType.Int);
                    parIDCartelera.Value = txtModIDCartelera.Text;



                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parPeliculaNombre);
                    comandoSQL.Parameters.Add(parPeliculaIdioma);
                    comandoSQL.Parameters.Add(parPeliculaSala);
                    comandoSQL.Parameters.Add(parFechayHora);
                    comandoSQL.Parameters.Add(parIDCartelera);


                    //pediente                comandoSQL.Parameters.Add(parFotografia);

                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        MessageBox.Show("Cartelera modificada satisfactoriamente");
                        txtModIDCartelera.Clear();
                        cbModIdiomaCartelera.Text = string.Empty;
                        cbModPeliculaCartelera.Text = string.Empty;
                        cbModSalaCartelera.Text = string.Empty;
                        dtpModFechayHora.Text = string.Empty;

                        cbModIdiomaCartelera.Enabled = false;
                        cbModPeliculaCartelera.Enabled = false;
                        cbModSalaCartelera.Enabled = false;
                        dtpModFechayHora.Enabled = false;
                        txtModIDCartelera.Enabled = true;
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscarEliminarCartelera_Click(object sender, EventArgs e)
        {
            if (txtModIDCartelera.Text == string.Empty)
            {
                MessageBox.Show("Introduzca el ID para realizar la Busqueda");
            }
            else
            {
                try
                {
                    //Conecta con base de datos
                    string cadenaConexionSQL = System.Configuration.ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                    SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                    conexionSQL.Open(); // Abre la conexion
                                        // Define la consulta parametrizada
                    string cadenaConsultaSQL = @"SELECT * FROM Cartelera WHERE carteleraID=@carteleraID";
                    // Crea el objeto comando y lo enlaza con la conexión abierta
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Define el tipo de comando
                    comandoSQL.CommandText = cadenaConsultaSQL; // Establece la consulta a ejecutar
                                                                // Crea paramento para numCliente
                    SqlParameter parcarteleraId = new SqlParameter("@carteleraID", SqlDbType.Int);
                    parcarteleraId.Value = txtModIDCartelera.Text;
                    // Agrega parámetro comandoSQL
                    comandoSQL.Parameters.Add(parcarteleraId);

                    SqlDataReader datos = comandoSQL.ExecuteReader(); // Ejecuta consulta de SELECCION
                    datos.Read(); // Lee el primer registros
                    if (datos.HasRows) // Tiene registros la consulta?
                    { // Obtiene la informacion de cada campo
                        cbModPeliculaCartelera.Text = datos["Titulo"].ToString();
                        cbModIdiomaCartelera.Text = datos["Idioma"].ToString();
                        cbModSalaCartelera.Text = datos["Sala"].ToString();
                        dtpModFechayHora.Text = datos["FechayHora"].ToString();

                        cbModPeliculaCartelera.Enabled = true;
                        cbModIdiomaCartelera.Enabled = true;
                        cbModSalaCartelera.Enabled = true;
                        dtpModFechayHora.Enabled = true;
                        txtModIDCartelera.Enabled = false;
                    }
                    else
                        MessageBox.Show("Cartelera no existe!!!");
                    conexionSQL.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnModLimpiar_Click(object sender, EventArgs e)
        {
            txtModIDCartelera.Clear();
            cbModIdiomaCartelera.Text = string.Empty;
            cbModPeliculaCartelera.Text = string.Empty;
            cbModSalaCartelera.Text = string.Empty;
            dtpModFechayHora.Text = string.Empty;

            cbModIdiomaCartelera.Enabled = false;
            cbModPeliculaCartelera.Enabled = false;
            cbModSalaCartelera.Enabled = false;
            dtpModFechayHora.Enabled = false;
            txtModIDCartelera.Enabled = true;
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conecta con base de datos con cadena de conexion del archivo App.config
                string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                // Crea objeto de conexión
                SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                conexionSQL.Open(); // Abre conexión
                // Define cadena SQL a ejecutar
                string cadenaSQL = @"SELECT * FROM Cartelera WHERE FechayHora=@FechayHora";

                // Crea commando SQL
                SqlCommand comandoSQL = conexionSQL.CreateCommand();
                comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                // Crea paramento para fechaEntrega
                SqlParameter parFechayHora = new SqlParameter("@FechayHora", SqlDbType.DateTime);
                parFechayHora.Value = dtpBuscarEliminar.Value;

                comandoSQL.Parameters.Add(parFechayHora);

                // Ejecuta consulta 
                SqlDataReader Datos = comandoSQL.ExecuteReader();
                // Creamos tabla en memoria
                DataTable tabla = new DataTable();
                // Carga los datos a la tabla
                tabla.Load(Datos);

                dgvBuscarEliminarCa.AutoGenerateColumns = false;
                dgvBuscarEliminarCa.DataSource = tabla;

                conexionSQL.Close(); // Cierra conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Registro == 0)
            {
                MessageBox.Show("Seleccione el Campo de Titulo de Pelicula Para Eliminar");
            }
            else
            {
                if (MessageBox.Show("¿DESEA ELIMINAR ESTE REGISTRO? Con el ID:" + Registro, "ELIMINAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        // Conecta con base de datos con cadena de conexion del archivo App.config
                        string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                        // Crea objeto de conexión
                        SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                        conexionSQL.Open(); // Abre conexión
                                            // Define cadena SQL a ejecutar
                        string cadenaSQL = @"DELETE FROM Cartelera WHERE carteleraID=@IDCartelera";

                        // Crea commando SQL
                        SqlCommand comandoSQL = conexionSQL.CreateCommand();
                        comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                        comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                        // Crea paramento para fechaEntrega
                        SqlParameter parCarteleraID = new SqlParameter("@IDCartelera", SqlDbType.Int);
                        parCarteleraID.Value = Registro;

                        comandoSQL.Parameters.Add(parCarteleraID);

                        comandoSQL.ExecuteNonQuery();

                        MessageBox.Show("Cartelera Eliminada Correctamente");

                        conexionSQL.Close(); // Cierra conexion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void ObtenerRegistroEliminar(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvBuscarEliminarCa.Rows[e.RowIndex];
            Registro = Convert.ToInt32(dgv.Cells[0].Value.ToString());
            
        }
    }
}
