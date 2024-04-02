using AppCine.CapaUI;
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
using System.Net.Mail;
using System.Net;
using AppCine.Layers.UI.Procesos;
using log4net;

namespace AppCine.CapaInterfaz
{

    public partial class frmLogin : Form
    {

        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        //Login 
        static Usuario oUsuario = null;


        static int contador = 0;

        //Restablecer
        static int codigoEnviado = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        //********************************************************************************************
        //Login

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //LlenarComboProvincias();

            cmbEliger.SelectedIndex = 0;
            //Login
            VerLogin();
            LimpiarLogin();

            //Restablecer
            NoVerRestablecer();

            //Registrarse
            NoVerRegistrarse();

            AcceptButton = btnIngresar1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.mnuBandera.Text = cmbEliger.SelectedItem.ToString();


            frmCartelera.principal = principal;
            frmHorarios.principal = principal;
            frmAsientos.principal = principal;
            frmFactura.principal = principal;



            erpErrores.Clear();

            try
            {
                UsuarioLN logica = new UsuarioLN();

                if (string.IsNullOrEmpty(txtCorreo1.Text))
                {
                    erpErrores.SetError(txtCorreo1, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtContrasena1.Text))
                {
                    erpErrores.SetError(txtContrasena1, "Dato requerido");
                    return;
                }

                string correo = txtCorreo1.Text;
                string contrasena = txtContrasena1.Text;

                if (correo.Equals("admin") && contrasena.Equals("123"))
                {
                    foreach (var oUsuario in logica.ObtenerUsuarios())
                    {
                        if (oUsuario.Tipo == 3)
                        {
                            frmFactura.Usuario = oUsuario;
                            frmUsuarios.oUsuario = oUsuario;
                            principal.MenusAdministrador();
                            MessageBox.Show("Bienvenido(a) haz ingresado como administrador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            principal.ShowDialog();
                            Close();
                        }
                    }
                }
                else
                {
                    oUsuario = logica.SeleccionarUsuarioPorCorreo_Contrasena(correo, contrasena);

                    if (oUsuario != null)
                    {
                        frmFactura.Usuario = oUsuario;
                        principal.MenusUsuario();
                        MessageBox.Show("Bienvenido(a) " + oUsuario.Nombre, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        principal.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados no coinciden con ningún usuario." +
                           "\n                     Verifique la información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contador++;

                        if (contador > 3)
                        {
                            MessageBox.Show("Cantidad de intentos permitidos alcanzado." +
                                "\n               Intentelo más tarde.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                NoVerLogin();
                VerRegistrarse();
                llenarComboTipoUsuario();
                contador = 0;
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

        private void lblOlvideContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                NoVerLogin();
                VerificarCorreo();
                contador = 0;
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

        private void lblVerContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena1.UseSystemPasswordChar == true)
            {
                txtContrasena1.UseSystemPasswordChar = false;
                return;
            }
            else
            {
                txtContrasena1.UseSystemPasswordChar = true;
                return;
            }
        }

        private void LimpiarLogin()
        {
            //login
            txtCorreo1.Text = "";
            txtContrasena1.Text = "";
        }

        public void VerLogin()
        {
            Color color = Color.FromArgb(64, 64, 64);
            cmbEliger.Visible = true;

            btnRegresar1.Visible = true;

            lblCorreo1.Visible = true;
            txtCorreo1.Visible = true;

            LblContrasena1.Visible = true;
            txtContrasena1.Visible = true;

            btnRegistrarse1.Visible = true;
            btnIngresar1.Visible = true;

            lblIngresar1.Visible = true;
            lblRegistrarse1.Visible = true;

            lblVerContrasena1.Visible = true;

            lblOlvideContrasena1.Visible = true;

            pnlEscritorio2.BackgroundImage = null;
            pnlEscritorio2.BackColor = Color.Maroon; ;
            pnlEscritorio1.BackColor = Color.White;
            pnlEscritorio1.BackgroundImage = AppCine.Properties.Resources.Cinestar_1___copia___copia;
            pnlEscritorio1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void NoVerLogin()
        {
            Color color = Color.FromArgb(64, 64, 64);

            //Login
            btnRegresar1.Visible = false;
            cmbEliger.Visible = false;

            lblCorreo1.Visible = false;
            txtCorreo1.Visible = false;

            LblContrasena1.Visible = false;
            txtContrasena1.Visible = false;

            btnRegistrarse1.Visible = false;
            btnIngresar1.Visible = false;

            lblIngresar1.Visible = false;
            lblRegistrarse1.Visible = false;

            lblVerContrasena1.Visible = false;

            lblOlvideContrasena1.Visible = false;

            pnlEscritorio1.BackgroundImage = null;
            pnlEscritorio1.BackColor = Color.Maroon;
            pnlEscritorio2.BackColor = Color.White;
            pnlEscritorio2.BackgroundImage = AppCine.Properties.Resources.Cinestar_1___copia___copia;
            pnlEscritorio2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        //********************************************************************************************
        //Registrarse

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            NoVerRegistrarse();
            VerLogin();
        }

        private void btnRegistrarse2_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();


                //Esta vacio
                if (string.IsNullOrEmpty(txtIdentificacion2.Text))
                {
                    erpErrores.SetError(txtIdentificacion2, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre2.Text))
                {
                    erpErrores.SetError(txtNombre2, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtApellidos2.Text))
                {
                    erpErrores.SetError(txtApellidos2, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtCorreo2.Text))
                {
                    erpErrores.SetError(txtCorreo2, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtContrasena2.Text))
                {
                    erpErrores.SetError(txtContrasena2, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtTelefono2.Text))
                {
                    erpErrores.SetError(txtTelefono2, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(dtpFechaNacimiento2.Text))
                {
                    erpErrores.SetError(dtpFechaNacimiento2, "Dato requerido");
                    return;
                }

                if (cmbTipoUsuario2.SelectedItem == null)
                {
                    erpErrores.SetError(cmbTipoUsuario2, "Dato requerido");
                    return;
                }

                if (ptxImagen2.Tag == null)
                {
                    erpErrores.SetError(ptxImagen2, "Dato requerido");
                    return;
                }

                //Formatos requeridos

                if (Utilitarios.ValidarValorNumerico(txtIdentificacion2.Text) == false)
                {
                    erpErrores.SetError(txtIdentificacion2, "El valor debe ser numérico");
                    return;
                }

                if (Utilitarios.LongitudIdentficacion(txtIdentificacion2.Text) == false)
                {
                    erpErrores.SetError(txtIdentificacion2, "El valor debe ser mayor o igual a 9 digitos");
                    return;
                }

                if (Utilitarios.FormatoCorreo(txtCorreo2.Text) == false)
                {
                    erpErrores.SetError(txtCorreo2, "Debe contener @ y .");
                    return;
                }

                if (Utilitarios.FormatoContrasena(txtContrasena2.Text) == false)
                {
                    erpErrores.SetError(txtContrasena2, "Debe contener algún valor numérico.");
                    return;
                }

                if (Utilitarios.LongitudContrasena(txtContrasena2.Text) == false)
                {
                    erpErrores.SetError(txtContrasena2, "La longitud debe ser mayor a 8 carácteres.");
                    return;
                }

                if (Utilitarios.ValidarValorNumerico(txtTelefono2.Text) == false)
                {
                    erpErrores.SetError(txtTelefono2, "El valor debe ser númerico");
                    return;
                }

                if (Utilitarios.LongitudTelefono(txtTelefono2.Text) == false)
                {
                    erpErrores.SetError(txtTelefono2, "Debe contener 8 digítos.");
                    return;
                }

                EnviarCorreo enviarCorreo = new EnviarCorreo();

                UsuarioLN logica = new UsuarioLN();

                Usuario oUsuario = new Usuario();
                oUsuario.Id = int.Parse(txtIdentificacion2.Text);
                oUsuario.Nombre = txtNombre2.Text;
                oUsuario.Apellidos = txtApellidos2.Text;
                oUsuario.Correo = txtCorreo2.Text;
                oUsuario.Contrasena = txtContrasena2.Text;
                oUsuario.Telefono = int.Parse(txtTelefono2.Text);
                oUsuario.FechaNacimiento = (DateTime)dtpFechaNacimiento2.Value;
                TipoUsuario Tipo = (TipoUsuario)cmbTipoUsuario2.SelectedItem;
                oUsuario.Tipo = Tipo.Id;
                oUsuario.Imagen = (byte[])ptxImagen2.Tag;

                if (logica.SeleccionarUsuarioPorId(oUsuario.Id) != null)
                {
                    if (oUsuario.Id == logica.SeleccionarUsuarioPorId(oUsuario.Id).Id)
                    {
                        MessageBox.Show("El usuario con identifación " + txtIdentificacion2.Text + " ya existe.\n" +
                            "       Verifique los datos ingresados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (cmbTipoUsuario2.SelectedItem.ToString().Equals("Premium"))
                {
                    var r = MessageBox.Show(Utilitarios.TerminosAndCondicionesMembresia(), "Términos y condiciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (r == DialogResult.Yes)
                    {
                        oUsuario.NumeroMembresia = int.Parse(txtIdentificacion2.Text);
                        enviarCorreo.EnviarNumeroMembresia(oUsuario.Correo, oUsuario.Id);
                    }
                    else
                    {
                        return;
                    }
                }

                logica.Guardar(oUsuario);
                LimpiarRegistrarse();
                NoVerRegistrarse();
                VerLogin();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptxImagen2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.InitialDirectory = "C:\\";
                openFile.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ptxImagen2.ImageLocation = openFile.FileName;
                    ptxImagen2.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] cadena = File.ReadAllBytes(openFile.FileName);
                    this.ptxImagen2.Tag = (byte[])cadena;
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

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            LimpiarRegistrarse();
        }

        //private void LlenarComboProvincias()
        //{
        //    foreach (var Provincia in ServicioProvincia.ServicioProvincia.GetAllProvince())
        //    {
        //        cmbEliger.Items.Add(Provincia);
        //        cmbEliger.DisplayMember = "Nombre";
        //    }
        //    cmbEliger.SelectedIndex = 0;
        //}

        private void llenarComboTipoUsuario()
        {
            cmbTipoUsuario2.DataSource = TipoUsuarioLN.ObtenerTipoUsuariosNormal();
            cmbTipoUsuario2.DisplayMember = "Descripcion";
            cmbTipoUsuario2.ValueMember = "Id";
        }

        private void LimpiarRegistrarse()
        {
            //Registrarse
            txtIdentificacion2.Text = "";
            txtNombre2.Text = "";
            txtApellidos2.Text = "";
            txtCorreo2.Text = "";
            txtContrasena2.Text = "";
            txtTelefono2.Text = "";
            dtpFechaNacimiento2.Text = "";
            cmbTipoUsuario2.SelectedItem = null;
            ptxImagen2.Image = AppCine.Properties.Resources.agregarImagen;
            ptxImagen2.Tag = null;
            ptxImagen2.SizeMode = PictureBoxSizeMode.CenterImage;
            erpErrores.Clear();
        }

        private void NoVerRegistrarse()
        {
            lblIdentificacion2.Visible = false;
            txtIdentificacion2.Visible = false;

            lblNombre2.Visible = false;
            txtNombre2.Visible = false;

            lblApellidos2.Visible = false;
            txtApellidos2.Visible = false;

            lblCorreo2.Visible = false;
            txtCorreo2.Visible = false;

            lblContrasena2.Visible = false;
            txtContrasena2.Visible = false;

            lblTelefono2.Visible = false;
            txtTelefono2.Visible = false;

            lblFechaNacimiento.Visible = false;
            dtpFechaNacimiento2.Visible = false;

            lblTipoUsuario2.Visible = false;
            cmbTipoUsuario2.Visible = false;

            lblFotografia2.Visible = false;
            ptxImagen2.Visible = false;

            btnRegistrarse2.Visible = false;

            btnLimpiar2.Visible = false;

            btnRegresar2.Visible = false;
        }

        private void VerRegistrarse()
        {
            lblIdentificacion2.Visible = true;
            txtIdentificacion2.Visible = true;

            lblNombre2.Visible = true;
            txtNombre2.Visible = true;

            lblApellidos2.Visible = true;
            txtApellidos2.Visible = true;

            lblCorreo2.Visible = true;
            txtCorreo2.Visible = true;

            lblContrasena2.Visible = true;
            txtContrasena2.Visible = true;

            lblTelefono2.Visible = true;
            txtTelefono2.Visible = true;

            lblFechaNacimiento.Visible = true;
            dtpFechaNacimiento2.Visible = true;

            lblTipoUsuario2.Visible = true;
            cmbTipoUsuario2.Visible = true;

            lblFotografia2.Visible = true;
            ptxImagen2.Visible = true;

            btnRegistrarse2.Visible = true;

            btnLimpiar2.Visible = true;

            btnRegresar2.Visible = true;
        }

        //********************************************************************************************
        //Restablecer

        private void btnRegresar3_Click(object sender, EventArgs e)
        {
            VerLogin();
            NoVerRestablecer();
        }

        private void btnVerificarCorreo3_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();

                if (string.IsNullOrEmpty(txtCorreo3.Text))
                {
                    erpErrores.SetError(txtCorreo3, "Dato requerido");
                    return;
                }

                UsuarioLN logica = new UsuarioLN();
                var CorreoUsuario = logica.SeleccionarUsuarioPorCorreo(txtCorreo3.Text);

                if (CorreoUsuario != null)
                {
                    Random random = new Random();
                    codigoEnviado = random.Next(10000, 99999);

                    EnviarCorreo nuevoCorreo = new EnviarCorreo();
                    nuevoCorreo.EnviarCodigoVerificacion(txtCorreo3.Text, codigoEnviado);

                    VerificarCodigo();
                }
                else
                {
                    MessageBox.Show("El correo no pertenece a ningún usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnVerificarCodigo3_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();

                if (string.IsNullOrEmpty(txtCodigoVerificacion3.Text))
                {
                    erpErrores.SetError(txtCodigoVerificacion3, "Dato requerido");
                    return;
                }

                if (Utilitarios.ValidarValorNumerico(txtCodigoVerificacion3.Text) == false)
                {
                    erpErrores.SetError(txtCodigoVerificacion3, "El código debe ser valor numérico.");
                    return;
                }

                int codigo = int.Parse(txtCodigoVerificacion3.Text);

                if (codigo == codigoEnviado)
                {
                    RestablecerContrasena();
                }
                else
                {
                    MessageBox.Show("El código ingresado no coincide", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRestablcerContrasena3_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();

                if (string.IsNullOrEmpty(txtNuevaContrasena3.Text))
                {
                    erpErrores.SetError(txtNuevaContrasena3, "Dato requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtConfirmarContrasena3.Text))
                {
                    erpErrores.SetError(txtConfirmarContrasena3, "Dato requerido");
                    return;
                }

                if (Utilitarios.FormatoContrasena(txtNuevaContrasena3.Text) == false)
                {
                    erpErrores.SetError(txtNuevaContrasena3, "Dato requerido");
                    return;
                }

                if (Utilitarios.LongitudContrasena(txtNuevaContrasena3.Text) == false)
                {
                    erpErrores.SetError(txtNuevaContrasena3, "Debe ser mayor a 8 carácteres");
                    return;
                }

                UsuarioLN logica = new UsuarioLN();

                string nuevaContrasena = txtNuevaContrasena3.Text;
                string confirmarContrasena = txtConfirmarContrasena3.Text;

                if (nuevaContrasena.Equals(confirmarContrasena))
                {
                    var Usuario = logica.SeleccionarUsuarioPorCorreo(txtCorreo3.Text);
                    Usuario.Contrasena = confirmarContrasena;

                    logica.Guardar(Usuario);
                    MessageBox.Show("Se restableció la contraseña con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarRestablecer();
                    NoVerRestablecer();
                    VerLogin();
                }
                else
                {
                    MessageBox.Show("Las contraseñas NO coinciden" +
                                    "\n     Verifique los datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void LimpiarRestablecer()
        {
            txtCorreo3.Text = "";
            txtCodigoVerificacion3.Text = "";
            txtNuevaContrasena3.Text = "";
            txtConfirmarContrasena3.Text = "";
            VerificarCorreo();
        }

        private void VerificarCorreo()
        {
            btnRegresar3.Visible = true;


            //Verificar correo
            lblCorreo3.Visible = true;
            txtCorreo3.Visible = true;

            btnVerificarCorreo3.Visible = true;

            //Verificar codigo
            lblCodigoVerificacion3.Visible = false;
            txtCodigoVerificacion3.Visible = false;

            btnVerificarCodigo3.Visible = false;

            //Restablecer 
            lblNuevaContrasena3.Visible = false;
            txtNuevaContrasena3.Visible = false;

            lblConfirmarContrasena3.Visible = false;
            txtConfirmarContrasena3.Visible = false;

            btnRestablcerContrasena3.Visible = false;

        }

        private void VerificarCodigo()
        {
            //Verificar correo
            lblCorreo3.Enabled = false;
            txtCorreo3.Enabled = false;

            btnVerificarCorreo3.Visible = false;

            //Verificar codigo
            lblCodigoVerificacion3.Visible = true;
            txtCodigoVerificacion3.Visible = true;

            btnVerificarCodigo3.Visible = true;

            //Restablecer 
            lblNuevaContrasena3.Visible = false;
            txtNuevaContrasena3.Visible = false;

            lblConfirmarContrasena3.Visible = false;
            txtConfirmarContrasena3.Visible = false;

            btnRestablcerContrasena3.Visible = false;
        }

        private void RestablecerContrasena()
        {


            //Verificar correo
            lblCorreo3.Enabled = false;
            txtCorreo3.Enabled = false;

            btnVerificarCorreo3.Visible = false;

            //Verificar codigo
            lblCodigoVerificacion3.Enabled = false;
            txtCodigoVerificacion3.Enabled = false;

            btnVerificarCodigo3.Visible = false;

            //Restablecer 
            lblNuevaContrasena3.Visible = true;
            txtNuevaContrasena3.Visible = true;

            lblConfirmarContrasena3.Visible = true;
            txtConfirmarContrasena3.Visible = true;

            btnRestablcerContrasena3.Visible = true;
        }

        private void NoVerRestablecer()
        {
            btnRegresar3.Visible = false;


            lblCorreo3.Visible = false;
            txtCorreo3.Visible = false;

            lblCodigoVerificacion3.Visible = false;
            txtCodigoVerificacion3.Visible = false;

            lblNuevaContrasena3.Visible = false;
            txtNuevaContrasena3.Visible = false;



            lblConfirmarContrasena3.Visible = false;
            txtConfirmarContrasena3.Visible = false;

            btnVerificarCorreo3.Visible = false;

            btnVerificarCodigo3.Visible = false;

            btnRestablcerContrasena3.Visible = false;
        }

        private void pnlEscritorio2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



