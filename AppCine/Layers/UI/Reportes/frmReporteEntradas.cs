using Microsoft.Reporting.WinForms;
using ServicioBCCR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.Layers.UI.Reportes
{
    public partial class frmReporteEntradas : Form
    {
        private static bool HayReporte = false;

        private static double TipoCambio = 0;

        public frmReporteEntradas()
        {
            InitializeComponent();
        }

        private void frmReporteEntradas__Load(object sender, EventArgs e)
        {
            ServiceBCCR services = new ServiceBCCR();
            foreach (var cambio in services.GetDolar(DateTime.Now, DateTime.Now, "c"))
            {
                TipoCambio = cambio.Monto;
               
            }
            //si sive
            LlenarUsuario();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Filtra segun el filtro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();

                if (rdbSala.Checked == false && rdbPelicula.Checked == false && rdbHorario.Checked == false)
                {
                    erpErrores.SetError(gpbTipoFiltro, "Debe seleccionar un tipo de filtro");
                    return;
                }

                if (cmbFiltroBy.SelectedItem == null)
                {
                    erpErrores.SetError(cmbFiltroBy, "Dato requerido");
                    return;
                }


                if (rdbSala.Checked)
                {
                    rpvEntradasByPelicula.Visible = false;
                    rpvEntradaByHorario.Visible = false;

                    Sala oSala = cmbFiltroBy.SelectedItem as Sala;
                    this.dataTableEntradaBySalaAdapter.Fill(this.dataSetReportes.DataTableEntradaBySala, oSala.Id);
                    ReportParameter fecha = new ReportParameter("Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                    ReportParameter tipoCambio = new ReportParameter("tipoCambio", TipoCambio.ToString());
                    this.rpvEntradasBySala.LocalReport.SetParameters(fecha);
                    this.rpvEntradasBySala.LocalReport.SetParameters(tipoCambio);
                    this.rpvEntradasBySala.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                    rpvEntradasBySala.RefreshReport();
                    rpvEntradasBySala.Visible = true;
                    HayReporte = true;
                }

                if (rdbPelicula.Checked)
                {
                    rpvEntradasBySala.Visible = false;
                    rpvEntradaByHorario.Visible = false;

                    Pelicula oPelicula = cmbFiltroBy.SelectedItem as Pelicula;
                    this.DataTableEntradaByPeliculaAdapter.Fill(this.dataSetReportes.DataTableEntradaByPelicula, oPelicula.Id);
                    ReportParameter fecha = new ReportParameter("Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                    ReportParameter tipoCambio = new ReportParameter("tipoCambio", TipoCambio.ToString());
                    this.rpvEntradasByPelicula.LocalReport.SetParameters(fecha);
                    this.rpvEntradasByPelicula.LocalReport.SetParameters(tipoCambio);
                    this.rpvEntradasByPelicula.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                    rpvEntradasByPelicula.RefreshReport();
                    rpvEntradasByPelicula.Visible = true;
                    HayReporte = true;
                }

                if (rdbHorario.Checked)
                {
                    rpvEntradasBySala.Visible = false;
                    rpvEntradasByPelicula.Visible = false;

                    Horario oHorario = cmbFiltroBy.SelectedItem as Horario;
                    this.DataTableEntradaByHorarioAdapter.Fill(this.dataSetReportes.DataTableEntradaByHorario, oHorario.Id);
                    ReportParameter fecha = new ReportParameter("Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                    ReportParameter tipoCambio = new ReportParameter("tipoCambio", TipoCambio.ToString());
                    this.rpvEntradaByHorario.LocalReport.SetParameters(fecha);
                    this.rpvEntradaByHorario.LocalReport.SetParameters(tipoCambio);
                    this.rpvEntradaByHorario.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                    this.rpvEntradaByHorario.RefreshReport();
                    rpvEntradaByHorario.Visible = true;
                    HayReporte = true;
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
                throw;
            }
        }

        /// <summary>
        /// Genera el reporte en documento pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayReporte == false)
                {
                    MessageBox.Show("No existen reportes para imprimir", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ruta = @"c:\temp\ReporteFacturacion.pdf";

                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                if (rdbSala.Checked)
                {
                    byte[] Bytes = rpvEntradasBySala.LocalReport.Render(format: "PDF", deviceInfo: "");

                    using (FileStream stream = new FileStream(ruta, FileMode.Create))
                    {
                        stream.Write(Bytes, 0, Bytes.Length);
                    }
                    MessageBox.Show("Impresión realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCompartir.Visible = true;
                    lblcompartir.Visible = true;
                    cmbUsuarios.Visible = true;
                    lblUsuario.Visible = true;
                    Process.Start(ruta);
                }

                if (rdbPelicula.Checked)
                {
                    byte[] Bytes = rpvEntradasByPelicula.LocalReport.Render(format: "PDF", deviceInfo: "");

                    using (FileStream stream = new FileStream(ruta, FileMode.Create))
                    {
                        stream.Write(Bytes, 0, Bytes.Length);
                    }
                    MessageBox.Show("Impresión realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCompartir.Visible = true;
                    lblcompartir.Visible = true;
                    cmbUsuarios.Visible = true;
                    lblUsuario.Visible = true;
                    Process.Start(ruta);
                }

                if (rdbHorario.Checked)
                {
                    byte[] Bytes = rpvEntradaByHorario.LocalReport.Render(format: "PDF", deviceInfo: "");

                    using (FileStream stream = new FileStream(ruta, FileMode.Create))
                    {
                        stream.Write(Bytes, 0, Bytes.Length);
                    }
                    MessageBox.Show("Impresión realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCompartir.Visible = true;
                    lblcompartir.Visible = true;
                    cmbUsuarios.Visible = true;
                    lblUsuario.Visible = true;
                    Process.Start(ruta);
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
                throw;
            }
        }

        /// <summary>
        /// Envia el reporte generado segun el usuario elegido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompartir_Click(object sender, EventArgs e)
        {
            erpErrores.Clear();

            if (HayReporte == false)
            {
                MessageBox.Show("No existen reportes para compartir", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbUsuarios.SelectedItem == null)
            {
                erpErrores.SetError(cmbUsuarios, "Debe seleccionar un destinatario");
                return;
            }
            EnviarCorreo correoReporte = new EnviarCorreo();

            Usuario oUsuario = cmbUsuarios.SelectedItem as Usuario;

            correoReporte.EnviarReporte(oUsuario.Correo);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            erpErrores.Clear();

            HayReporte = false;

            rdbHorario.Checked = false;
            rdbPelicula.Checked = false;
            rdbSala.Checked = false;

            cmbFiltroBy.SelectedItem = null;

            rpvEntradaByHorario.Clear();
            rpvEntradasByPelicula.Clear();
            rpvEntradasBySala.Clear();

            rpvEntradaByHorario.Visible = false;
            rpvEntradasByPelicula.Visible = false;
            rpvEntradasBySala.Visible = false;

            btnCompartir.Visible = false;
            lblcompartir.Visible = false;
            cmbUsuarios.Visible = false;
            lblUsuario.Visible = false;
        }

        private void rdbSala_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltroBy.Items.Clear();
            LlenarPorSala();
            cmbFiltroBy.SelectedItem = null;
        }

        private void rdbPelicula_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltroBy.Items.Clear();
            LlenarPorPelicula();
            cmbFiltroBy.SelectedItem = null;
        }

        private void rdbHorario_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltroBy.Items.Clear();
            LlenarPorHorario();
            cmbFiltroBy.SelectedItem = null;
        }

        private void LlenarPorSala()
        {
            SalaLN logicaSala = new SalaLN();

            foreach (var item in logicaSala.ObtenerSalas())
            {
                cmbFiltroBy.Items.Add(item);
                cmbFiltroBy.DisplayMember = "Descripcion";
                cmbFiltroBy.ValueMember = "Id";
            }
        }

        private void LlenarPorPelicula()
        {
            PeliculaLN logicaPelicula = new PeliculaLN();

            foreach (var item in logicaPelicula.ObtenerPeliculas())
            {

                cmbFiltroBy.Items.Add(item);
                cmbFiltroBy.DisplayMember = "Descripcion";
                cmbFiltroBy.ValueMember = "Id";

            }
        }

        private void LlenarPorHorario()
        {
            HorarioLN logica = new HorarioLN();

            foreach (var item in logica.ObtenerHorarios())
            {
                cmbFiltroBy.Items.Add(item);
                cmbFiltroBy.DisplayMember = item.FechaYHora.ToString();
                cmbFiltroBy.ValueMember = item.Id.ToString();
            }
        }

       
        private void LlenarUsuario()
        {
            UsuarioLN logica = new UsuarioLN();
            cmbUsuarios.DataSource = logica.ObtenerUsuarios();
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.SelectedItem = null;
        }
    }
}
