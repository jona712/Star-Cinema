using AppCine.CapaInterfaz;
using AppCine.Layers.UI.Mantenimientos;
using AppCine.Layers.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.CapaUI
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void quéQuieresVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuPrincipal.Visible = false;
            frmCartelera cartelera = new frmCartelera();
            cartelera.TopLevel = false;
            cartelera.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(cartelera);
            cartelera.Show();
        }

        private void mnuPeliculas_Click(object sender, EventArgs e)
        {

            frmPeliculas peliculas = new frmPeliculas();
            peliculas.TopLevel = false;
            peliculas.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(peliculas);
            peliculas.Show();
            peliculas.Limpiar();
        }

        private void mnuCartelera_Click(object sender, EventArgs e)
        {

            frmProgramaccion programaccion = new frmProgramaccion();
            programaccion.TopLevel = false;
            programaccion.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(programaccion);
            programaccion.Show();
            programaccion.Limpiar();
        }

        private void mnuReporteEntradas_Click(object sender, EventArgs e)
        {
            frmReporteEntradas frmReporteEntradas_ = new frmReporteEntradas();
            frmReporteEntradas_.TopLevel = false;
            frmReporteEntradas_.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(frmReporteEntradas_);
            frmReporteEntradas_.Show();
        }

        private void mnuReportesFacturas_Click(object sender, EventArgs e)
        {
            frmReporteFacturas frmReporteFacturas = new frmReporteFacturas();
            frmReporteFacturas.TopLevel = false;
            frmReporteFacturas.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(frmReporteFacturas);
            frmReporteFacturas.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {

            frmUsuarios usuarios = new frmUsuarios();
            usuarios.TopLevel = false;
            usuarios.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(usuarios);
            usuarios.Show();
            usuarios.Limpiar();
        }

        private void mnuGraficos_Click(object sender, EventArgs e)
        {
            frmReporteFacturaGrafico frmReporteFacturaGrafico = new frmReporteFacturaGrafico();
            frmReporteFacturaGrafico.TopLevel = false;
            frmReporteFacturaGrafico.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(frmReporteFacturaGrafico);
            frmReporteFacturaGrafico.Show();
 
        }

        private void mnuCine_Click(object sender, EventArgs e)
        {
            frmCine cine = new frmCine();
            cine.TopLevel = false;
            cine.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Clear();
            pnlEscritorio.Controls.Add(cine);
            cine.Show();

        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();

            MenusInicio();
            pnlEscritorio.Controls.Clear();
            mnuBandera.Text = "";

            Login.ShowDialog();
        }

        private void mnuSalir2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea abandonar el sistema?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void MenusInicio()
        {
            mnuMantenimientos.Visible = false;
            mnuReportes.Visible = false;
            mnuCompras.Visible = false;
        }

        public void MenusAdministrador()
        {
            mnuMantenimientos.Visible = true;
            mnuReportes.Visible = true;
        }

        public void MenusUsuario()
        {
            mnuMantenimientos.Visible = false;
            mnuReportes.Visible = false;
        }

        
    }
}
