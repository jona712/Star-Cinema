using AppCine.CapaUI;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.CapaInterfaz
{
    public partial class frmHorarios : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public static frmPrincipal principal = null;

        public SalaPelicula SalaPelicula = null;

        public frmHorarios()
        {
            InitializeComponent();
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            LlenarCamposTexto();
            lstHorarios.SelectedIndex = -1;
            llenarHorarios();          
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmCartelera cartelera = new frmCartelera();
            cartelera.TopLevel = false;
            cartelera.Dock = DockStyle.Fill;
            principal.pnlEscritorio.Controls.Clear();
            principal.pnlEscritorio.Controls.Add(cartelera);
            cartelera.Show();
        }

        /// <summary>
        /// Validada el horario seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstHorarios.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un horario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SalaPelicula SalaPelicula = lstHorarios.SelectedItem as SalaPelicula;

                frmAsientos asientos = new frmAsientos();
                asientos.SalaPelicula = SalaPelicula;
                asientos.TopLevel = false;
                asientos.Dock = DockStyle.Fill;
                asientos.SalaPelicula = SalaPelicula;
                principal.pnlEscritorio.Controls.Clear();
                principal.pnlEscritorio.Controls.Add(asientos);
                asientos.Show();
            }
            catch (Exception ex)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", ex.Message);
                msg.AppendFormat("Source         {0}\n", ex.Source);
                msg.AppendFormat("InnerException {0}\n", ex.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", ex.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", ex.TargetSite);
                //msg.AppendFormat("SQL            {0}\n", command.CommandText);

                //Log4Net
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(System.Reflection.MethodBase.GetCurrentMethod(), ex));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Llena la lista con los horario existentes
        /// </summary>
        private void llenarHorarios()
        {
            SalaPeliculaLN logica = new SalaPeliculaLN();

            foreach (var item in logica.ObtenerSalasPeliculas())
            {
                if (SalaPelicula.IdPelicula == item.IdPelicula)
                {
                    ptxPelicula.Image = Utilitarios.ArrayBytes_Image(item.Pelicula.Imagen);
                    ptxPelicula.SizeMode = PictureBoxSizeMode.StretchImage;
                    lstHorarios.Items.Add(item);
                }
            }
        }


        /// <summary>
        /// Muestra el precio y la categoria de la pelicula
        /// </summary>
        private void LlenarCamposTexto()
        {
            EntradaLN logica = new EntradaLN();
            logica.oPelicula = SalaPelicula.Pelicula;
            lblPrecio.Text = "₡ " + logica.PrecioEntrada().ToString("#,##0.00");
            lblClasificacion.Text = SalaPelicula.Pelicula.Clasificacion.Descripcion;            
        }  
    }
}
