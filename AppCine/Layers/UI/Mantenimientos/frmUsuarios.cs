using log4net;
using Microsoft.VisualBasic;
using System;
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
    public partial class frmUsuarios : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public static Usuario oUsuario = null;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarTipoUsuario();
            Refrescar();
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
                    erpErrores.SetError(txtId, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erpErrores.SetError(txtNombre, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    erpErrores.SetError(txtApellidos, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    erpErrores.SetError(txtCorreo, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtContrasena.Text))
                {
                    erpErrores.SetError(txtContrasena, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    erpErrores.SetError(txtTelefono, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(dtpFechaNacimiento.Text))
                {
                    erpErrores.SetError(dtpFechaNacimiento, "Dato requerido");
                    return;
                }

                if (cmbTipoUsuario.SelectedItem == null)
                {
                    erpErrores.SetError(cmbTipoUsuario, "Dato requerido");
                    return;
                }

                if (ptxImagen.Tag == null)
                {
                    erpErrores.SetError(ptxImagen, "Dato requerido");
                    return;
                }

                if (Utilitarios.FormatoCorreo(txtCorreo.Text) == false)
                {
                    erpErrores.SetError(txtCorreo, "Debe contener @ y .");
                    return;
                }

                if (Utilitarios.FormatoContrasena(txtContrasena.Text) == false)
                {
                    erpErrores.SetError(txtContrasena, "Debe contener algún valor numérico.");
                    return;
                }

                if (Utilitarios.LongitudContrasena(txtContrasena.Text) == false)
                {
                    erpErrores.SetError(txtContrasena, "La longitud debe ser mayor a 8 carácteres.");
                    return;
                }

                if (Utilitarios.ValidarValorNumerico(txtId.Text) == false)
                {
                    erpErrores.SetError(txtId, "El valor debe ser númerico");
                    return;
                }

                if (Utilitarios.ValidarValorNumerico(txtTelefono.Text) == false)
                {
                    erpErrores.SetError(txtTelefono, "El valor debe ser númerico");
                    return;
                }

                if (Utilitarios.LongitudTelefono(txtTelefono.Text) == false)
                {
                    erpErrores.SetError(txtTelefono, "Debe contener 8 digítos.");
                    return;
                }

                UsuarioLN logica = new UsuarioLN();

                Usuario oUsuario = new Usuario();
                oUsuario.Id = int.Parse(txtId.Text);
                oUsuario.Nombre = txtNombre.Text;
                oUsuario.Apellidos = txtApellidos.Text;
                oUsuario.Correo = txtCorreo.Text;
                oUsuario.Contrasena = txtContrasena.Text;
                oUsuario.Telefono = int.Parse(txtTelefono.Text);
                oUsuario.FechaNacimiento = (DateTime)dtpFechaNacimiento.Value;
                TipoUsuario Tipo = (TipoUsuario)cmbTipoUsuario.SelectedItem;
                oUsuario.Tipo = Tipo.Id;
                oUsuario.Imagen = (byte[])ptxImagen.Tag;

                if (cmbTipoUsuario.SelectedItem.ToString().Equals("Premium"))
                {
                    oUsuario.NumeroMembresia = oUsuario.Id;
                }

                logica.Guardar(oUsuario);

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
                if (dgvUsuarios.RowCount == 0)
                {
                    MessageBox.Show("NO existen elementos para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    var r = MessageBox.Show("¿Desea eliminar este elemento?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        Usuario Usuario = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;

                        if (Usuario.Tipo == oUsuario.Tipo)
                        {
                            MessageBox.Show("Este Usuario es el administrador conectado" +
                                "\n   No se puede eliminar en este momento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (Usuario != null)
                        {
                            UsuarioLN logica = new UsuarioLN();
                            logica.Eliminar(Usuario.Id);
                        }

                        Refrescar();
                        Limpiar();
                        MessageBox.Show("Usuario eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var oUsuario = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                    txtId.Text = oUsuario.Id.ToString();
                    txtNombre.Text = oUsuario.Nombre;
                    txtApellidos.Text = oUsuario.Apellidos;
                    txtCorreo.Text = oUsuario.Correo;
                    txtContrasena.Text = oUsuario.Contrasena;
                    txtTelefono.Text = oUsuario.Telefono.ToString();
                    dtpFechaNacimiento.Value = oUsuario.FechaNacimiento;
                    cmbTipoUsuario.Text = oUsuario.TipoUsuario.ToString();

                    ptxImagen.Image = Utilitarios.ArrayBytes_Image(oUsuario.Imagen);
                    ptxImagen.Tag = oUsuario.Imagen;
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
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.RowTemplate.Height = 100;
            UsuarioLN logica = new UsuarioLN();
            dgvUsuarios.DataSource = logica.ObtenerUsuarios();
        }

        private void CargarTipoUsuario()
        {
            cmbTipoUsuario.DataSource = TipoUsuarioLN.ObtenerTipoUsuariosAdmin();
            cmbTipoUsuario.DisplayMember = "Descripcion";
            cmbTipoUsuario.ValueMember = "Id";
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Text = "";
            cmbTipoUsuario.SelectedItem = null;
            ptxImagen.Image = AppCine.Properties.Resources.agregarImagen;
            ptxImagen.Tag = null;
            ptxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            dgvUsuarios.ClearSelection();
            erpErrores.Clear();
        }

    }
}
