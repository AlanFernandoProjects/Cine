using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBibliotecaFinal
{
    public partial class frmPeliculas : Form
    {
        int Registro;

        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void btnUsuMod_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaRegistrar_Click(object sender, EventArgs e)
        {
            if (txtAltaActores.Text==string.Empty||
            txtAltaDecripcion.Text==string.Empty||
            txtAltaTitulo.Text==string.Empty||
            cbAltaDuracion.Text == string.Empty||
            pictureBox1.Image == null)
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
                    string cadenaSQL = @"INSERT INTO Pelicula(Nombre, Descripcion, Actores, Estreno, Duracion, Imagen
                                    ) VALUES(@Nombre,@Descripcion, @Actores, @FechaEstreno, @Duracion, @Imagen)";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando


                    SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    parNombre.Value = txtAltaTitulo.Text;

                    SqlParameter parDescripcion = new SqlParameter("@Descripcion", SqlDbType.VarChar);
                    parDescripcion.Value = txtAltaDecripcion.Text;

                    SqlParameter parActores = new SqlParameter("@Actores", SqlDbType.VarChar);
                    parActores.Value = txtAltaActores.Text;

                    SqlParameter parFechaEstreno = new SqlParameter("@FechaEstreno", SqlDbType.Date);
                    parFechaEstreno.Value = dtpAltaEstreno.Value.Date;

                    SqlParameter parDuracion = new SqlParameter("@Duracion", SqlDbType.VarChar);
                    parDuracion.Value = Convert.ToString(cbAltaDuracion.SelectedItem);

                    SqlParameter parImagen = new SqlParameter("@Imagen", SqlDbType.Image);

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


                    parImagen.Value = ms.GetBuffer();


                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parNombre);
                    comandoSQL.Parameters.Add(parDescripcion);
                    comandoSQL.Parameters.Add(parActores);
                    comandoSQL.Parameters.Add(parFechaEstreno);
                    comandoSQL.Parameters.Add(parDuracion);
                    comandoSQL.Parameters.Add(parImagen);


                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        cadenaSQL = "SELECT @@IDENTITY";
                        comandoSQL.CommandText = cadenaSQL;
                        string IDPelicula = comandoSQL.ExecuteScalar().ToString();
                        MessageBox.Show("PELICULA REGISTRADA SATISFACTORIAMENTE CON EL NUMERO: " + IDPelicula);
                        txtAltaTitulo.Clear();
                        txtAltaDecripcion.Clear();
                        txtAltaActores.Clear();
                        cbAltaDuracion.Text = string.Empty;
                        pictureBox1.Image = null;
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    txtAltaTitulo.Clear();
                    txtAltaDecripcion.Clear();
                    txtAltaActores.Clear();

                }
            }
        }

       

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            DialogResult result = Foto.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(Foto.FileName);
            }
        }

        private void btnBuscarPelicula_Click(object sender, EventArgs e)
        {
            if (txtBusquedaPelicula.Text == string.Empty)
            {
                MessageBox.Show("Introduzca la Informacion de Busqueda");
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
                    string cadenaSQL = @"SELECT * FROM Pelicula WHERE Nombre=@Nombre";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    // Crea paramento para fechaEntrega
                    SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    parNombre.Value = txtBusquedaPelicula.Text;

                    comandoSQL.Parameters.Add(parNombre);

                    // Ejecuta consulta 
                    SqlDataReader Datos = comandoSQL.ExecuteReader();
                    // Creamos tabla en memoria
                    DataTable tabla = new DataTable();
                    // Carga los datos a la tabla
                    tabla.Load(Datos);

                    dgvBuscarPelicula.AutoGenerateColumns = false;
                    dgvBuscarPelicula.DataSource = tabla;

                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscarPeliculaEliminar_Click(object sender, EventArgs e)
        {
            if (txtBusquedaEliminarPelicula.Text == string.Empty)
            {
                MessageBox.Show("Introduzca la Informacion de Busqueda");

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
                    string cadenaSQL = @"SELECT * FROM Pelicula WHERE Nombre=@Nombre";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    // Crea paramento para fechaEntrega
                    SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    parNombre.Value = txtBusquedaEliminarPelicula.Text;

                    comandoSQL.Parameters.Add(parNombre);

                    // Ejecuta consulta 
                    SqlDataReader Datos = comandoSQL.ExecuteReader();
                    // Creamos tabla en memoria
                    DataTable tabla = new DataTable();
                    // Carga los datos a la tabla
                    tabla.Load(Datos);

                    dgvEliminarPelicula.AutoGenerateColumns = false;
                    dgvEliminarPelicula.DataSource = tabla;

                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ObtenerRegistro(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvEliminarPelicula.Rows[e.RowIndex];
            Registro = Convert.ToInt32(dgv.Cells[0].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Registro == 0)
            {
                MessageBox.Show("Seleccione el campo de Titulo para Eliminar");
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
                        string cadenaSQL = @"DELETE FROM Pelicula WHERE peliculaID=@IDPelicula";

                        // Crea commando SQL
                        SqlCommand comandoSQL = conexionSQL.CreateCommand();
                        comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                        comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                        // Crea paramento para fechaEntrega
                        SqlParameter parPeliculaID = new SqlParameter("@IDPelicula", SqlDbType.Int);
                        parPeliculaID.Value = Registro;

                        comandoSQL.Parameters.Add(parPeliculaID);

                        comandoSQL.ExecuteNonQuery();

                        MessageBox.Show("Pelicula Eliminar Correctamente");

                        conexionSQL.Close(); // Cierra conexion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtModIDBuscarPel.Text == string.Empty)
            {
                MessageBox.Show("Introduzca la Informacion de Busqueda");
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
                    string cadenaConsultaSQL = @"SELECT * FROM Pelicula WHERE peliculaID=@peliculaID";
                    // Crea el objeto comando y lo enlaza con la conexión abierta
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Define el tipo de comando
                    comandoSQL.CommandText = cadenaConsultaSQL; // Establece la consulta a ejecutar
                                                                // Crea paramento para numCliente
                    SqlParameter parIDPelicula = new SqlParameter("@peliculaID", SqlDbType.Int);
                    parIDPelicula.Value = txtModIDBuscarPel.Text;
                    // Agrega parámetro comandoSQL
                    comandoSQL.Parameters.Add(parIDPelicula);
                    SqlDataReader datos = comandoSQL.ExecuteReader(); // Ejecuta consulta de SELECCION
                    datos.Read(); // Lee el primer registros
                    if (datos.HasRows) // Tiene registros la consulta?
                    { // Obtiene la informacion de cada campo
                        txtModTituloPel.Text = datos["Nombre"].ToString();
                        txtModDesPel.Text = datos["Descripcion"].ToString();
                        txtModActPel.Text = datos["Actores"].ToString();
                        dtpModEstrenoPel.Text = datos["Estreno"].ToString();
                        cbModDuraPelicula.Text = datos["Duracion"].ToString();

                        //Se obtiene el valor del campo Imagen, primero se almacena en un buffer
                        byte[] foto = (byte[])datos["Imagen"];
                        // Se crea un MemoryStream a partir de ese buffer
                        MemoryStream ms = new MemoryStream(foto);
                        // Se utiliza el MemoryStream para extraer la imagen
                        picModPortadaPel.Image = Image.FromStream(ms);

                        txtModTituloPel.Enabled = true;
                        txtModDesPel.Enabled = true;
                        txtModActPel.Enabled = true;
                        dtpModEstrenoPel.Enabled = true;
                        cbModDuraPelicula.Enabled = true;
                        picModPortadaPel.Enabled = true;
                        txtModIDBuscarPel.Enabled = false;
                    }
                    else
                        MessageBox.Show("Pelicula no existe!!!");
                    conexionSQL.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void picModPortadaPel_Click(object sender, EventArgs e)
        {
            OpenFileDialog Foto = new OpenFileDialog();
            DialogResult result = Foto.ShowDialog();
            if (result == DialogResult.OK)
            {
                picModPortadaPel.Image = Image.FromFile(Foto.FileName);
            }
        }

        private void btnUsuMod_Click_1(object sender, EventArgs e)
        {
            if (txtModTituloPel.Text == string.Empty ||
            txtModDesPel.Text == string.Empty ||
            txtModActPel.Text == string.Empty ||
            cbModDuraPelicula.Text == string.Empty ||
            picModPortadaPel.Image == null
            )
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
                    string cadenaSQL = @"UPDATE Pelicula SET
                                    Nombre=@Nombre,
                                    Descripcion=@Descripcion, 
                                    Actores=@Actores,       
                                    Estreno=@FechaEstreno, 
                                    Duracion=@Duracion, 
                                    Imagen=@Imagen
                                    WHERE peliculaID=@peliculaID";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    SqlParameter parPeliculaID = new SqlParameter("@peliculaID", SqlDbType.Int);
                    parPeliculaID.Value = txtModIDBuscarPel.Text;

                    SqlParameter parNombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    parNombre.Value = txtModTituloPel.Text;

                    SqlParameter parDescripcion = new SqlParameter("@Descripcion", SqlDbType.VarChar);
                    parDescripcion.Value = txtModDesPel.Text;

                    SqlParameter parActores = new SqlParameter("@Actores", SqlDbType.VarChar);
                    parActores.Value = txtModActPel.Text;

                    SqlParameter parFechaEstreno = new SqlParameter("@FechaEstreno", SqlDbType.Date);
                    parFechaEstreno.Value = dtpModEstrenoPel.Value.Date;

                    SqlParameter parDuracion = new SqlParameter("@Duracion", SqlDbType.VarChar);
                    parDuracion.Value = Convert.ToString(cbModDuraPelicula.SelectedItem);


                    // Crea variable para la fotografia
                    MemoryStream foto = new MemoryStream();
                    // Se guarda la imagen en la variable
                    picModPortadaPel.Image.Save(foto, System.Drawing.Imaging.ImageFormat.
                    Jpeg);

                    // Parametro para fotografia
                    SqlParameter parFotografia = new SqlParameter("@Imagen", SqlDbType.Image);
                    parFotografia.Value = foto.GetBuffer();

                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parPeliculaID);
                    comandoSQL.Parameters.Add(parNombre);
                    comandoSQL.Parameters.Add(parDescripcion);
                    comandoSQL.Parameters.Add(parActores);
                    comandoSQL.Parameters.Add(parFechaEstreno);
                    comandoSQL.Parameters.Add(parDuracion);
                    comandoSQL.Parameters.Add(parFotografia);

                    //pediente                comandoSQL.Parameters.Add(parFotografia);

                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        MessageBox.Show("Pelicula modificada satisfactoriamente");
                        txtModTituloPel.Enabled = false;
                        txtModDesPel.Enabled = false;
                        txtModActPel.Enabled = false;
                        dtpModEstrenoPel.Enabled = false;
                        cbModDuraPelicula.Enabled = false;
                        picModPortadaPel.Enabled = false;
                        txtModTituloPel.Clear();
                        txtModDesPel.Clear();
                        txtModActPel.Clear();
                        picModPortadaPel.Image = null;
                        txtModIDBuscarPel.Enabled = true;
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUsuModLimpiar_Click(object sender, EventArgs e)
        {
            txtModTituloPel.Clear();
            txtModDesPel.Clear();
            txtModActPel.Clear();
            picModPortadaPel.Image = null;
            txtModIDBuscarPel.Enabled = true;
        }

        private void btnAltaLimpiar_Click(object sender, EventArgs e)
        {
            txtAltaActores.Clear();
            txtAltaDecripcion.Clear();
            txtAltaTitulo.Clear();
            cbAltaDuracion.Text = string.Empty;
            pictureBox1.Image = null;
        }
    }
}
