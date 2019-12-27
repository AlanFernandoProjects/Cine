using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoBibliotecaFinal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Autentificar();      
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del progeama", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txtClave.Focus();
            }
        }

        public void Autentificar()
        {
            int Cartel = 0;
            try
            {
                // Conecta con base de datos con cadena de conexion del archivo App.config
                string cadenaConexionSQL = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
                // Crea objeto de conexión
                SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL);
                conexionSQL.Open(); // Abre conexión
                // Define cadena SQL a ejecutar
                string cadenaSQL = @"Select Nombre, Clave from Usuarios";


                // Crea commando SQL
                SqlCommand comandoSQL = conexionSQL.CreateCommand();
                comandoSQL.CommandType = CommandType.Text; // Establece tipo de Comando a ejecutar
                comandoSQL.CommandText = cadenaSQL; // Asigna cadena SQL a ejecutar por el comando

                SqlDataReader Lectrodedatos = comandoSQL.ExecuteReader();

                while (Lectrodedatos.Read())
                {
                    if (txtUsuario.Text == Lectrodedatos.GetValue(0).ToString() && txtClave.Text == Lectrodedatos.GetValue(1).ToString())
                    {
                        MessageBox.Show("Bienvenido(a) " + txtUsuario.Text, "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal Principal = new frmPrincipal(); Principal.ShowDialog();
                        this.Hide();
                        Cartel = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (Cartel == 0)
            {
                MessageBox.Show("Usuario o clave incorrectos ", "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
                txtUsuario.Focus();
            }
            

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Autentificar();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txtClave.Focus();
            }
        }

        private void AdaptarPantalla(object sender, EventArgs e)
        {
            /*
            picUsuario.Left = this.Width - 900;
            txtClave.Left = this.Width - 830;
            txtUsuario.Left = this.Width - 830;
            lblUsuario.Left = this.Width - 900;
            lblClave.Left = this.Width - 900;
            btnIngresar.Left = this.Width - 750;
            btnSalir.Left = this.Width - 900;
            dtmFechaLogin.Top = this.Height - 430;
            dtmFechaLogin.Left = this.Width - 700;*/

        }
    }
}
