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
    public partial class frmPuntodeVenta : Form
    {

        double TotalVenta;
       

        public frmPuntodeVenta()
        {
            InitializeComponent();
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
                parFechayHora.Value = dtpBuscarCartelera.Value.Date;

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

        private void ObtenerRegistros(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvBuscarCartelera.Rows[e.RowIndex];
            txtTituloVenta.Text = dgv.Cells[0].Value.ToString();
            txtFechaVenta.Text = dgv.Cells[1].Value.ToString();
            txtIdiomaVenta.Text = dgv.Cells[2].Value.ToString();
            txtSalaVenta.Text = dgv.Cells[3].Value.ToString();
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTituloVenta.Text = string.Empty;
            txtFechaVenta.Text = string.Empty;
            txtIdiomaVenta.Text = string.Empty;
            txtSalaVenta.Text = string.Empty;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtTituloVenta.Text == string.Empty || txtFechaVenta.Text == string.Empty || txtIdiomaVenta.Text == string.Empty ||
                txtSalaVenta.Text == string.Empty || txtCantidadVenta.Text == string.Empty)
            {
                MessageBox.Show("Asegurese de Acompletar todos los campos");
            }
            else if (rbAdulto.Checked == true)
            {
                //60
                TotalVenta = 60 * Convert.ToInt32(txtCantidadVenta.Text);
                lblTotalAPagar.Text = Convert.ToString(TotalVenta);
                lblCambioVenta.Text = Convert.ToString(Convert.ToInt32(txtPagoCliente.Text) - TotalVenta);
                if (Convert.ToInt32(txtPagoCliente.Text) < TotalVenta)
                {
                    MessageBox.Show("La cantidad de pago cliente no puede ser menor a la Venta Total");
                    lblCambioVenta.Text = "0.0";
                    txtPagoCliente.Text = string.Empty;

                }
                else
                {
                    btnRealizarVenta.Enabled = true;
                }

            }

            else if (rbNiño.Checked == true)
            {
                //30
                //60
                TotalVenta = 30 * Convert.ToInt32(txtCantidadVenta.Text);
                lblTotalAPagar.Text = Convert.ToString(TotalVenta);
                lblCambioVenta.Text = Convert.ToString(Convert.ToInt32(txtPagoCliente.Text) - TotalVenta);
                btnRealizarVenta.Enabled = true;
                if (Convert.ToInt32(txtPagoCliente.Text) < TotalVenta)
                {
                    MessageBox.Show("La cantidad de pago cliente no puede ser menor a la Venta Total");
                    lblCambioVenta.Text = "0.0";
                    txtPagoCliente.Text = string.Empty;

                }
                else
                {
                    btnRealizarVenta.Enabled = true;
                }
            }

            else if (rbTerceraEdad.Checked == true)
            {
                //45
                TotalVenta = 45 * Convert.ToInt32(txtCantidadVenta.Text);
                lblTotalAPagar.Text = Convert.ToString(TotalVenta);
                lblCambioVenta.Text = Convert.ToString(Convert.ToInt32(txtPagoCliente.Text) - TotalVenta);
                if (Convert.ToInt32(txtPagoCliente.Text) < TotalVenta)
                {
                    MessageBox.Show("La cantidad de pago cliente no puede ser menor a la Venta Total");
                    lblCambioVenta.Text = "0.0";
                    txtPagoCliente.Text = string.Empty;
                }
                else
                {
                    btnRealizarVenta.Enabled = true;
                }
            }

            if (txtTarjetaSocio.Text != null)
            {
                try
                {
                    //Conecta con base de datos
                    string cadenaConexionSQL = System.Configuration.ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                    SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                    conexionSQL.Open(); // Abre la conexion
                                        // Define la consulta parametrizada
                    string cadenaConsultaSQL = @"SELECT * FROM Socio WHERE NumTarjeta=@NumTarjeta";
                    // Crea el objeto comando y lo enlaza con la conexión abierta
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Define el tipo de comando
                    comandoSQL.CommandText = cadenaConsultaSQL; // Establece la consulta a ejecutar
                                                                // Crea paramento para numCliente
                    SqlParameter parIDNumTarjeta = new SqlParameter("@NumTarjeta", SqlDbType.Int);
                    parIDNumTarjeta.Value = txtTarjetaSocio.Text;
                    // Agrega parámetro comandoSQL
                    comandoSQL.Parameters.Add(parIDNumTarjeta);
                    SqlDataReader datos = comandoSQL.ExecuteReader(); // Ejecuta consulta de SELECCION
                    datos.Read(); // Lee el primer registros
                    if (datos.HasRows) // Tiene registros la consulta?
                    { // Obtiene la informacion de cada campo
                        txtTarjetaSocio.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Socio no existe!!!");
                        txtTarjetaSocio.Clear();
                    }
                    conexionSQL.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {

            }
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (txtTituloVenta.Text == string.Empty || txtFechaVenta.Text == string.Empty || txtIdiomaVenta.Text == string.Empty ||
                txtSalaVenta.Text == string.Empty || txtCantidadVenta.Text == string.Empty)
            {
                MessageBox.Show("Asegurese de Acompletar todos los campos");
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
                    string cadenaSQL = @"INSERT INTO Ventas(Fecha, Titulo, Idioma, Sala, Edad, TarjetaSocio, Cantidad, PagoCliente, Cambio, TotalPagar
                                    ) VALUES(@Fecha,@Titulo, @Idioma, @Sala, @Edad, @TarjetaSocio, @Cantidad, @PagoCliente,@Cambio,@TotalPagar)";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando


                    SqlParameter parFecha = new SqlParameter("@Fecha", SqlDbType.DateTime);
                    parFecha.Value = txtFechaVenta.Text;

                    SqlParameter parTitulo = new SqlParameter("@Titulo", SqlDbType.VarChar);
                    parTitulo.Value = txtTituloVenta.Text;

                    SqlParameter parIdioma = new SqlParameter("@Idioma", SqlDbType.VarChar);
                    parIdioma.Value = txtIdiomaVenta.Text;

                    SqlParameter parSala = new SqlParameter("@Sala", SqlDbType.Int);
                    parSala.Value = txtSalaVenta.Text;

                    SqlParameter parEdad = new SqlParameter("@Edad", SqlDbType.VarChar);
                    if (rbAdulto.Checked == true)
                    {
                        parEdad.Value = rbAdulto.Text;
                    }
                    else if (rbNiño.Checked == true)
                    {
                        parEdad.Value = rbNiño.Text;
                    }
                    else if (rbTerceraEdad.Checked == true)
                    {
                        parEdad.Value = rbTerceraEdad.Text;
                    }

                    SqlParameter parTarjetaSocio = new SqlParameter("@TarjetaSocio", SqlDbType.Int);
                    parTarjetaSocio.Value = txtTarjetaSocio.Text;

                    SqlParameter parCantidad = new SqlParameter("@Cantidad", SqlDbType.Int);
                    parCantidad.Value = txtCantidadVenta.Text;

                    SqlParameter parPagoCliente = new SqlParameter("@PagoCliente", SqlDbType.Int);
                    parPagoCliente.Value = txtPagoCliente.Text;

                    SqlParameter parCambio = new SqlParameter("@Cambio", SqlDbType.Int);
                    parCambio.Value = lblCambioVenta.Text;

                    SqlParameter parTotalPagar = new SqlParameter("@TotalPagar", SqlDbType.Int);
                    parTotalPagar.Value = lblTotalAPagar.Text;


                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parFecha);
                    comandoSQL.Parameters.Add(parTitulo);
                    comandoSQL.Parameters.Add(parIdioma);
                    comandoSQL.Parameters.Add(parSala);
                    comandoSQL.Parameters.Add(parEdad);
                    comandoSQL.Parameters.Add(parTarjetaSocio);
                    comandoSQL.Parameters.Add(parCantidad);
                    comandoSQL.Parameters.Add(parPagoCliente);
                    comandoSQL.Parameters.Add(parCambio);
                    comandoSQL.Parameters.Add(parTotalPagar);


                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        cadenaSQL = "SELECT @@IDENTITY";
                        comandoSQL.CommandText = cadenaSQL;
                        string IDPelicula = comandoSQL.ExecuteScalar().ToString();
                        MessageBox.Show("VENTA REGISTRADA SATISFACTORIAMENTE CON EL FOLIO: " + IDPelicula);
                        txtFechaVenta.Clear();
                        txtIdiomaVenta.Clear();
                        txtPagoCliente.Clear();
                        txtSalaVenta.Clear();
                       
                        txtTituloVenta.Clear();
                        txtCantidadVenta.Clear();
                        lblCambioVenta.Text = "0.0";
                        lblTotalAPagar.Text = "0.0";
                        btnRealizarVenta.Enabled = false;
                    }
                    conexionSQL.Close(); // Cierra conexion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (txtTarjetaSocio.Text!=null)
            {
                try
                {
                    // Conecta con base de datos con cadena de conexion del archivo App.config
                    string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                    // Crea objeto de conexión
                    SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                    conexionSQL.Open(); // Abre conexión
                                        // Define cadena SQL a ejecutar
                    string cadenaSQL = @"UPDATE Socio SET
                                         Puntos=@Puntos
                                         WHERE NumTarjeta=@NumTarjeta";

                    // Crea commando SQL
                    SqlCommand comandoSQL = conexionSQL.CreateCommand();
                    comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                    comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                    SqlParameter parTarjetaSocio = new SqlParameter("@NumTarjeta", SqlDbType.Int);
                    parTarjetaSocio.Value = Convert.ToInt32(txtTarjetaSocio.Text);

                    SqlParameter parPuntos = new SqlParameter("@Puntos", SqlDbType.Int);
                    parPuntos.Value = Convert.ToInt32(TotalVenta*0.10);


                    // Agrega parámetros al comando
                    comandoSQL.Parameters.Add(parTarjetaSocio);
                    comandoSQL.Parameters.Add(parPuntos);

                    // Ejecuta la consulta
                    int regInsertados = comandoSQL.ExecuteNonQuery();


                    if (regInsertados > 0) // Verifica si se registro el cliente
                    {
                        MessageBox.Show("Puntos asignados satisfactoriamente");
                        txtTarjetaSocio.Clear();
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
}
