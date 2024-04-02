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
    public partial class frmProgramaccion : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmProgramaccion()
        {
            InitializeComponent();
        }

        private void frmProgramaccion_Load(object sender, EventArgs e)
        {
            LlenarComboHorarios();
            LlenarComboPeliculas();
            LlenarComboSalas();
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

                if (cmbSalas.SelectedItem == null)
                {
                    erpErrores.SetError(cmbSalas, "Dato requerido");
                    return;
                }

                if (cmbPeliculas.SelectedItem == null)
                {
                    erpErrores.SetError(cmbPeliculas, "Dato requerido");
                    return;
                }

                if (cmbHorarios.SelectedItem == null)
                {
                    erpErrores.SetError(cmbHorarios, "Dato requerido");
                    return;
                }

                SalaPeliculaLN logica = new SalaPeliculaLN();

                //Crea sala
                Sala oSala = (Sala)cmbSalas.SelectedItem;

                //Crea pelicula
                Pelicula oPelicula = (Pelicula)cmbPeliculas.SelectedItem;

                //Crea horario
                Horario oHorario = (Horario)cmbHorarios.SelectedItem;

                //Crea la salaPelicula
                SalaPelicula oSalaPelicula;

                oSalaPelicula = new SalaPelicula()
                {
                    IdPelicula = oPelicula.Id,
                    IdSala = oSala.Id,
                    IdHorario = oHorario.Id
                };

                if (logica.SeleccionarSalaPeliculaPorIdSala_IdHorario(oSala.Id, oHorario.Id) == null)
                {
                    logica.Guardar(oSalaPelicula);
                    Refrescar();
                    Limpiar();
                }
                else
                {
                    oPelicula = logica.SeleccionarSalaPeliculaPorIdSala_IdHorario(oSala.Id, oHorario.Id).Pelicula;
                    MessageBox.Show("La " + oSala.Descripcion + " contiene " + oPelicula.Descripcion + " en el horario de las " + oHorario.FechaYHora + " p.m.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalaPelicula.RowCount == 0)
                {
                    MessageBox.Show("NO existen elementos para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvSalaPelicula.SelectedRows.Count > 0)
                {
                    var r = MessageBox.Show("¿Desea eliminar este elemento?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        var SalaPelicula = (SalaPelicula)dgvSalaPelicula.SelectedRows[0].DataBoundItem;

                        if (SalaPelicula != null)
                        {
                            SalaPeliculaLN logica = new SalaPeliculaLN();
                            AsientoDB datos = new AsientoDB();

                            logica.Eliminar(SalaPelicula.IdPelicula, SalaPelicula.IdSala, SalaPelicula.IdHorario);
                            datos.ActualizarSinSalaPelicula(SalaPelicula.IdSala, SalaPelicula.IdHorario);
                        }

                        Refrescar();
                        Limpiar();
                        MessageBox.Show("Programacción eliminada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LlenarComboSalas()
        {
            SalaLN logicaSala = new SalaLN();
            cmbSalas.DataSource = logicaSala.ObtenerSalas();
            cmbSalas.DisplayMember = "Descripcion";
            cmbSalas.ValueMember = "Id";
        }

        private void LlenarComboPeliculas()
        {
            PeliculaLN logicaPelicula = new PeliculaLN();

            foreach (var item in logicaPelicula.ObtenerPeliculas())
            {
                if (item.Estado == true)
                {
                    cmbPeliculas.Items.Add(item);
                    cmbPeliculas.DisplayMember = "Descripcion";
                    cmbPeliculas.ValueMember = "Id";
                }
            }
        }

        private void LlenarComboHorarios()
        {
            HorarioLN logica = new HorarioLN();

            foreach (var item in logica.ObtenerHorarios())
            {
                cmbHorarios.Items.Add(item);

                cmbHorarios.DisplayMember = item.FechaYHora.ToString();
                cmbHorarios.ValueMember = item.Id.ToString();
            }
        }

        private void Refrescar()
        {
            dgvSalaPelicula.AutoGenerateColumns = false;

            SalaPeliculaLN logica = new SalaPeliculaLN();
            dgvSalaPelicula.DataSource = logica.ObtenerSalasPeliculas();
        }

        public void Limpiar()
        {
            dgvSalaPelicula.ClearSelection();
            cmbSalas.SelectedItem = null;
            cmbPeliculas.SelectedItem = null;
            cmbHorarios.SelectedItem = null;
        }

    }
}
