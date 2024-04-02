using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.Layers.UI.Reportes.Facturacion
{
    public partial class frmEntradas : Form
    {
        public int IdFactura { get; set; }

        public List<Entrada> ListaEntradas = null;
        public frmEntradas()
        {
            InitializeComponent();
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            foreach (var item in ListaEntradas)
            {
                string rutaImagen = @"c:\temp\qrEntrada.png";

                int IdEntrada = EntradaLN.SeleccionarEntradaParaDetalle(item.IdSala, item.IdPelicula, item.IdHorario, item.IdAsiento).Id;
                if (File.Exists(rutaImagen))
                    File.Delete(rutaImagen);

                // Crear imagen quickresponse
                Image quickResponseImage = QuickResponse.QuickResponseGenerador(IdEntrada.ToString(), 53);

                // Salvarla en c:\temp para luego ser leida
                quickResponseImage.Save(rutaImagen, ImageFormat.Png);

                string ruta = @"file:///" + @"C:/TEMP/qrEntrada.png";
                this.rpvEntradas.LocalReport.EnableExternalImages = true;
                ReportParameter param = new ReportParameter("qrEntrada", ruta);
                this.rpvEntradas.LocalReport.SetParameters(param);    
            }
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturacion.DataTableEntradas_2' Puede moverla o quitarla según sea necesario.
            this.DataTableEntradasAdapter.Fill(this.DataSetFacturacion.DataTableEntradas_2, IdFactura);
            this.rpvEntradas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturacion.DataTableEntradas' Puede moverla o quitarla según sea necesario.
            this.rpvEntradas.RefreshReport();
        }
    }
}
