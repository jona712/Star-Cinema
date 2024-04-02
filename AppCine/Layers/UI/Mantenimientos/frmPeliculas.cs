using AppCine;
using AppCine.Layers.BLL;
using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.CapaInterfaz
{
    public partial class frmPeliculas : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            Refrescar();
            llenarComboClasificacion();
            Limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    erpErrores.SetError(txtId, "Dato requerido.");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erpErrores.SetError(txtNombre, "Dato requerido.");
                    return;
                }

                if (string.IsNullOrEmpty(txtSinopsis.Text))
                {
                    erpErrores.SetError(txtSinopsis, "Dato requerido");
                    return;
                }

                if (cmbClasificacion.SelectedItem == null)
                {
                    erpErrores.SetError(cmbClasificacion, "Dato requerido.");
                    return;
                }

                if (rdbSi.Checked == false && rdbNo.Checked == false)
                {
                    erpErrores.SetError(gpbEnCartelera, "Dato requerido.");
                    return;
                }

                if (ptxImagen.Tag == null)
                {
                    erpErrores.SetError(ptxImagen, "Dato requerido.");
                    return;
                }

                if (Utilitarios.ValidarValorNumerico(txtId.Text) == false)
                {
                    erpErrores.SetError(txtId, "Debe ser valor numérico.");
                    return;
                }

                Pelicula oPelicula = new Pelicula();

                oPelicula.Id = int.Parse(txtId.Text);
                oPelicula.Descripcion = txtNombre.Text.ToString();
                oPelicula.Sinopsis = txtSinopsis.Text;
                oPelicula.Clasificacion = (Clasificacion)cmbClasificacion.SelectedItem;
                oPelicula.IdClasificacion = oPelicula.Clasificacion.Id;
               
                if (rdbSi.Checked)
                {
                    oPelicula.Estado = true;
                }
                if (rdbNo.Checked)
                {
                    oPelicula.Estado = false;
                }

                oPelicula.Imagen = (byte[])this.ptxImagen.Tag;

                PeliculaLN logica = new PeliculaLN();
                logica.Guardar(oPelicula);

                Refrescar();
                Limpiar();

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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SalaPeliculaLN logicaSalaPelicula = new SalaPeliculaLN();

                if (dgvPeliculas.RowCount == 0)
                {
                    MessageBox.Show("NO existen elementos para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvPeliculas.SelectedRows.Count > 0)
                {
                    var r = MessageBox.Show("¿Desea eliminar este elemento?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        var oPelicula = (Pelicula)dgvPeliculas.SelectedRows[0].DataBoundItem;

                        foreach (var item in logicaSalaPelicula.ObtenerSalasPeliculas())
                        {
                            if (item.IdPelicula == oPelicula.Id)
                            {
                                MessageBox.Show("No se puede eliminar la pelicula " + oPelicula.Descripcion + " por que se encuentra en cartelera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }


                        if (oPelicula != null)
                        {
                            PeliculaLN logica = new PeliculaLN();
                            logica.Eliminar(oPelicula.Id);
                        }

                        Refrescar();
                        Limpiar();
                        MessageBox.Show("Película eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

        private void ptxImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.InitialDirectory = "C:\\";
                openFile.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ptxImagen.ImageLocation = openFile.FileName;
                    ptxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] cadena = File.ReadAllBytes(openFile.FileName);
                    this.ptxImagen.Tag = (byte[])cadena;
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

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPeliculas.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var oPelicula = (Pelicula)dgvPeliculas.SelectedRows[0].DataBoundItem;
                    txtId.Text = oPelicula.Id.ToString();
                    txtNombre.Text = oPelicula.Descripcion;
                    txtSinopsis.Text = oPelicula.Sinopsis;
                    cmbClasificacion.Text = oPelicula.Clasificacion.ToString() ;

                    if (oPelicula.Estado == true)
                    {
                        rdbSi.Checked = true;
                    }
                    if (oPelicula.Estado == false)
                    {
                        rdbNo.Checked = true;
                    }

                    ptxImagen.Image = Utilitarios.ArrayBytes_Image(oPelicula.Imagen);
                    ptxImagen.Tag = oPelicula.Imagen;
                    ptxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void Refrescar()
        {
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.RowTemplate.Height = 100;
            PeliculaLN logica = new PeliculaLN();
            dgvPeliculas.DataSource = logica.ObtenerPeliculas();
        }

        private void llenarComboClasificacion()
        {
            cmbClasificacion.DataSource = ClasificacionLN.ObtenerClasificaciones();
            cmbClasificacion.DisplayMember = "Descripcion";
            cmbClasificacion.ValueMember = "Id";
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtSinopsis.Text = "";
            ptxImagen.Image = AppCine.Properties.Resources.agregarImagen;
            ptxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            ptxImagen.Tag = null;
            dgvPeliculas.ClearSelection();
            rdbNo.Checked = false;
            rdbSi.Checked = false;
            cmbClasificacion.SelectedItem = null;
            erpErrores.Clear();
        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {

        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void lblEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

