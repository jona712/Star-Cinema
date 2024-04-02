using AppCine.CapaUI;
using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.CapaInterfaz
{
    public partial class frmCartelera : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public static frmPrincipal principal;

        public frmCartelera()
        {
            InitializeComponent();
        }

        private void frmCartelera_Load(object sender, EventArgs e)
        {
            llenarCartelera();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            principal.mnuPrincipal.Visible = true;
            Dispose();
        }

        private void ptxCampo1_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo1.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo1.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;                      
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);                           
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo2_Click(object sender, EventArgs e)
        {
            try
            {

                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo2.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo2.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo3_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo3.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo3.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo4_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo4.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo4.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo5_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo5.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo5.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo6_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo6.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo6.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo7_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo7.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo7.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo8_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo8.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo8.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo9_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo9.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo9.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        private void ptxCampo10_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logica = new SalaPeliculaLN();

                if (ptxCampo10.Tag != null)
                {
                    foreach (var item in logica.ObtenerSalasPeliculasParaCartelera())
                    {
                        if (ptxCampo10.Tag.Equals(item.IdPelicula))
                        {
                            var r = MessageBox.Show(item.Pelicula.Sinopsis, item.Pelicula.Descripcion, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (r == DialogResult.OK)
                            {
                                frmHorarios horarios = new frmHorarios();
                                horarios.SalaPelicula = item;
                                horarios.TopLevel = false;
                                horarios.Dock = DockStyle.Fill;
                                principal.pnlEscritorio.Controls.Clear();
                                principal.pnlEscritorio.Controls.Add(horarios);
                                horarios.Show();
                            }
                        }
                    }
                }
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

        public List<PictureBox> ListaCampos()
        {
            List<PictureBox> Lista = new List<PictureBox>();

            ptxCampo1.Name = "Campo 1";
            ptxCampo1.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo2.Name = "Campo 2";
            ptxCampo2.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo3.Name = "Campo 3";
            ptxCampo3.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo4.Name = "Campo 4";
            ptxCampo4.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo5.Name = "Campo 5";
            ptxCampo5.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo6.Name = "Campo 6";
            ptxCampo6.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo7.Name = "Campo 7";
            ptxCampo7.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo8.Name = "Campo 8";
            ptxCampo8.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo9.Name = "Campo 9";
            ptxCampo9.SizeMode = PictureBoxSizeMode.StretchImage;

            ptxCampo10.Name = "Campo 10";
            ptxCampo10.SizeMode = PictureBoxSizeMode.StretchImage;

            Lista.Add(ptxCampo1);
            Lista.Add(ptxCampo2);
            Lista.Add(ptxCampo3);
            Lista.Add(ptxCampo4);
            Lista.Add(ptxCampo5);
            Lista.Add(ptxCampo6);
            Lista.Add(ptxCampo7);
            Lista.Add(ptxCampo8);
            Lista.Add(ptxCampo9);
            Lista.Add(ptxCampo10);

            return Lista;
        }

        public void llenarCartelera()
        {
            SalaPeliculaLN logica = new SalaPeliculaLN();
      
            int contador = 0;

            for (int i = 0; i < ListaCampos().Count; i++)
            {
                if (contador < logica.ObtenerSalasPeliculasParaCartelera().Count)
                {
                    var SalaPelicula = logica.ObtenerSalasPeliculasParaCartelera()[contador];
         
                    if (SalaPelicula.Pelicula.Estado == true)
                    {
                        ListaCampos()[i].Image = Utilitarios.ArrayBytes_Image(SalaPelicula.Pelicula.Imagen);
                        ListaCampos()[i].Tag = SalaPelicula.Pelicula.Id;
                        contador++;
                    }
                    else
                    {
                        i--;
                        contador++;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
