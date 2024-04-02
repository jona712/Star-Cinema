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
    public partial class frmReporteFacturas : Form
    {
        private static bool HayReporte = false;

        private static double TipoCambio = 0;

        public frmReporteFacturas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                erpErrores.Clear();

                DateTime fechaInicial = DateTime.Parse(dtpFechaInicial.Value.ToString("dd/MM/yyyy"));
                DateTime fechaFinal = DateTime.Parse(dtpFechaFinal.Value.ToString("dd/MM/yyyy"));

                if (fechaInicial.Day > DateTime.Now.Day && fechaFinal.Day > DateTime.Now.Day)
                {
                    erpErrores.SetError(dtpFechaInicial, "La fecha inicial NO puede execeder de " + DateTime.Now.ToString("dd/MM/yyyy") + ".");
                    erpErrores.SetError(dtpFechaFinal, "La fecha final NO puede execeder de " + DateTime.Now.ToString("dd/MM/yyyy") + ".");
                    return;
                }

                if (fechaInicial.Day > DateTime.Now.Day)
                {
                    erpErrores.SetError(dtpFechaInicial, "La fecha inicial NO puede execeder de " + DateTime.Now.ToString("dd/MM/yyyy") + ".");
                    return;
                }

                if (fechaFinal.Day > DateTime.Now.Day)
                {
                    erpErrores.SetError(dtpFechaFinal, "La fecha final NO puede execeder de " + DateTime.Now.ToString("dd/MM/yyyy") + ".");
                    return;
                }


                this.dataTableFacturaByFechaAdapter.Fill(this.dataSetReportes.DataTableFacturaByFecha, fechaInicial, fechaFinal);
                this.rpvReporteFactura.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                ReportParameter fechaInicio = new ReportParameter("fechaInicio", fechaInicial.ToString("dd/MM/yyyy"));
                ReportParameter fechaFin = new ReportParameter("fechaFin", fechaFinal.ToString("dd/MM/yyyy"));
                ReportParameter tipoCambio = new ReportParameter("tipoCambio", TipoCambio.ToString("#,###.00"));
                this.rpvReporteFactura.LocalReport.SetParameters(fechaInicio);
                this.rpvReporteFactura.LocalReport.SetParameters(fechaFin);
                this.rpvReporteFactura.LocalReport.SetParameters(tipoCambio);
                rpvReporteFactura.RefreshReport();
                rpvReporteFactura.Visible = true;
                HayReporte = true;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            HayReporte = false;
            rpvReporteFactura.Visible = false;
            rpvReporteFactura.Clear();
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaFinal.Value = DateTime.Now;
            btnCompartir.Visible = false;
            lblcompartir.Visible = false;
            cmbUsuarios.Visible = false;
            lblUsuario.Visible = false;
        }

        private void frmReporteFacturas_Load(object sender, EventArgs e)
        {
            ServiceBCCR services = new ServiceBCCR();
            foreach (var cambio in services.GetDolar(DateTime.Now, DateTime.Now, "c"))
            {
                TipoCambio = cambio.Monto;
            }

            LlenarUsuario();
            //si sive
        }

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

                byte[] Bytes = rpvReporteFactura.LocalReport.Render(format: "PDF", deviceInfo: "");

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

        private void LlenarUsuario()
        {
            UsuarioLN logica = new UsuarioLN();
            cmbUsuarios.DataSource = logica.ObtenerUsuarios();
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.SelectedItem = null;
        }
    }
}
