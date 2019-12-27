using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBibliotecaFinal
{
    public partial class frmPrincipal : Form
    {
   
        frmLogin Login = new frmLogin();
      
       
        

        public frmPrincipal()
        {
            InitializeComponent();
            EstadoTabs();
        }
        
        

        private void EstadoTabs()
        {
            
            
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Desea cerrar sesion", "Cerrar Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();

                Login.Show();
            }
        }

        private void picSocios_Click(object sender, EventArgs e)
        {
            frmSocios Socios = new frmSocios();
            Socios.MdiParent = this.MdiParent;

            Socios.Show();
             Socios.Location = new Point(380, 170);
            
            
        }

        private void picCartelera_Click(object sender, EventArgs e)
        {
            frmCartelera Cartelera = new frmCartelera();
            Cartelera.MdiParent = this.MdiParent;

            Cartelera.Show();
            Cartelera.Location = new Point(380, 170);
      
        }

        private void picPeliculas_Click(object sender, EventArgs e)
        {
            frmPeliculas Peliculas = new frmPeliculas();
            Peliculas.MdiParent = this.MdiParent;

            Peliculas.Show();
           
            Peliculas.Location = new Point(380, 170);
    
        }

        private void picVenta_Click(object sender, EventArgs e)
        {
            frmPuntodeVenta Venta = new frmPuntodeVenta();
            Venta.MdiParent = this.MdiParent;
            Venta.Show();
            Venta.Location = new Point(380, 170);
          
        }
    }
}
