using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteFacturaGrafico : Form
    {
        private static bool HayReporte = false;

        public frmReporteFacturaGrafico()
        {
            InitializeComponent();
        }

        private void frmReporteFacturaGrafico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportes.DataTableFacturaGrafico' Puede moverla o quitarla según sea necesario.
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

                this.DataTableFacturaGraficoAdapter.Fill(this.DataSetReportes.DataTableFacturaGrafico,fechaInicial,fechaFinal);
                ReportParameter fecha = new ReportParameter("Fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                this.rpvFacturaGrafico.LocalReport.SetParameters(fecha);                  
                this.rpvFacturaGrafico.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.rpvFacturaGrafico.RefreshReport();
                this.rpvFacturaGrafico.Visible = true;
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

        /// <summary>
        /// Genera el reporte en documento PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (HayReporte == false)
            {
                MessageBox.Show("No existen reportes para imprimir", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ruta = @"c:\temp\ReporteFacturacion.pdf";

            if (!Directory.Exists(@"c:\temp"))
                Directory.CreateDirectory(@"c:\temp");

            byte[] Bytes = rpvFacturaGrafico.LocalReport.Render(format: "PDF", deviceInfo: "");

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
        
        /// <summary>
        /// Envia el documento por correo
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
            dtpFechaFinal.Value = DateTime.Now;
            dtpFechaInicial.Value = DateTime.Now;
            rpvFacturaGrafico.Visible = false;
            HayReporte = false;
            btnCompartir.Visible = false;
            lblcompartir.Visible = false;
            cmbUsuarios.Visible = false;
            lblUsuario.Visible = false;
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
