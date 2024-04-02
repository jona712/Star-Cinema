using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.Layers.UI.Reportes.Facturacion
{
    public partial class frmFacturacion : Form
    {
        public int IdFactura { get; set; }

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturacion.DataTableFacturacion' Puede moverla o quitarla según sea necesario.
            this.DataTableFacturacionAdapter.Fill(this.DataSetFacturacion.DataTableFacturacion, IdFactura);
            string ruta = @"file:///" + @"C:/TEMP/qr.png";
            this.rpvFactura.LocalReport.EnableExternalImages = true;
            this.rpvFactura.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            ReportParameter param = new ReportParameter("quickresponse", ruta);
            this.rpvFactura.LocalReport.SetParameters(param);
            this.rpvFactura.RefreshReport();
        }
    }
}
