using log4net;
using ServicioProvincia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.Layers.UI.Mantenimientos
{
    public partial class frmCine : Form
    {

        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmCine()
        {
            InitializeComponent();
        }

        private void frmCine_Load(object sender, EventArgs e)
        {
            
            Refrescar();
            LlenarComboProvincias();
            Limpiar();
            txtDescripcion.ReadOnly = true;
            txtDescripcion.AppendText("Por políticas del cine, la descripción debe contenar el nombre de la empresa");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
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

                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    erpErrores.SetError(txtDescripcion, "Dato requerido");
                    return;
                }

                if (cmbProvincias.SelectedItem == null)
                {
                    erpErrores.SetError(cmbProvincias, "Dato requerido");
                    return;
                }

                if (Utilitarios.ValidarValorNumerico(txtId.Text) == false)
                {
                    erpErrores.SetError(txtId, "El valor debe ser numérico");
                    return;
                }

                CineLN logica = new CineLN();

               

                int id = int.Parse(txtId.Text);
                string descripcion = txtDescripcion.Text;
                string provincia = cmbProvincias.SelectedItem.ToString();

                Cine oCine = new Cine();
                oCine.Id = id;
                oCine.Descripcion = descripcion;
                oCine.Provincia = provincia;

                logica.Guardar(oCine);
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
                              
                Close();
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SalaLN logicaSala = new SalaLN();
                CineLN logica = new CineLN();

                if (dgvCines.RowCount == 0)
                {
                    MessageBox.Show("NO existen elementos para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvCines.SelectedRows.Count > 0)
                {
                    Cine oCine = (Cine)dgvCines.SelectedRows[0].DataBoundItem;
                    var r = MessageBox.Show("¿Desea eliminar este elemento?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        foreach (var sala in logicaSala.ObtenerSalas())
                        {
                            if (sala.IdCine == oCine.Id)
                            {
                                MessageBox.Show("Este cine contiene información en sus salas"+
                                    "\n      No se puede eliminar el registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        logica.Eliminar(oCine.Id);
                        Refrescar();
                        MessageBox.Show("Cine eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();                       
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvCines_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCines.SelectedRows.Count > 0)
                {
                    Cine oCine = (Cine)dgvCines.SelectedRows[0].DataBoundItem;
                    txtId.Text = oCine.Id.ToString();
                    txtDescripcion.Text = oCine.Descripcion;
                    cmbProvincias.Text = oCine.Provincia;                 
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
            dgvCines.AutoGenerateColumns = false;
            CineLN logica = new CineLN();
            dgvCines.DataSource = logica.ObtenerCines();
        }

        private void LlenarComboProvincias()
        {
            foreach (var Provincia in ServicioProvincia.ServicioProvincia.GetAllProvince())
            {
                cmbProvincias.Items.Add(Provincia);
                cmbProvincias.DisplayMember = "Nombre";
            }
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "Cine Star";
            cmbProvincias.SelectedItem = null;
            dgvCines.ClearSelection();
            erpErrores.Clear();
        } 
    }
}
