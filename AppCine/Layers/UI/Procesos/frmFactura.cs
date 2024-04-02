using AppCine.CapaInterfaz;
using AppCine.CapaUI;
using AppCine.Layers.UI.Reportes;
using AppCine.Layers.UI.Reportes.Facturacion;
using log4net;
using Microsoft.IdentityModel.Tokens;
using ServicioBCCR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.Layers.UI.Procesos
{
    public partial class frmFactura : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public static frmPrincipal principal = null;

        public static frmFacturacion frmFacturacion { get; set; }

        public SalaPelicula SalaPelicula = null;

        public static Usuario Usuario = null;

        public List<Entrada> ListaEntradas = null;

        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lstEntradas.DataSource = ListaEntradas;
            llenarCampos();
            btnSalir.Visible = false;
            btnPDF.Visible = false;
            lblPDF.Visible = false;          
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmAsientos asientos = new frmAsientos();
            asientos.SalaPelicula = SalaPelicula;
            asientos.ListaEntradas = ListaEntradas;
            asientos.EliminarSeleccion();
            asientos.TopLevel = false;
            asientos.Dock = DockStyle.Fill;
            principal.pnlEscritorio.Controls.Clear();
            principal.pnlEscritorio.Controls.Add(asientos);
            asientos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            principal.mnuPrincipal.Visible = true;
            principal.pnlEscritorio.Controls.Clear();
        }


        /// <summary>
        /// Crea la factura y las entradas y las muestra en los reportviewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Usuario.Tipo == 3)
                {
                    MessageBox.Show("El administrador no puede realizar compras", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rutaImagen = @"c:\temp\qr.png";

                //Crea entradas
                foreach (var item in ListaEntradas)
                {
                    EntradaLN logicaEntrada = new EntradaLN();
                    logicaEntrada.Guardar(item);
                }

                //Crea Factura
                FacturaLN logicaFactura = new FacturaLN();
                Factura oFactura = new Factura();
                oFactura.Fecha = DateTime.Now;
                oFactura.IdUsuario = Usuario.Id;
                oFactura.Total = double.Parse(txtTotal.Text);
                logicaFactura.Guardar(oFactura);

                //Crea DetalleFactura
                Detalle_FacturaLN logicaDetalle = new Detalle_FacturaLN();
                foreach (var item in ListaEntradas)
                {
                    Detalle_Factura oDetalle_Factura = new Detalle_Factura();
                    oDetalle_Factura.IdFactura = logicaFactura.SeleccionarFacturaParaDetalle().Id;
                    oDetalle_Factura.IdEntrada = EntradaLN.SeleccionarEntradaParaDetalle(item.IdSala, item.IdPelicula, item.IdHorario, item.IdAsiento).Id;
                    oDetalle_Factura.Cantidad = int.Parse(txtCantidad.Text);
                    oDetalle_Factura.Precio = double.Parse(txtPrecio.Text);
                    oDetalle_Factura.Subtotal = double.Parse(txtSubtotal.Text);
                    oDetalle_Factura.Impuesto = double.Parse(txtImpuesto.Text);

                    logicaDetalle.Guardar(oDetalle_Factura);
                }

                // Si existe borrelo
                if (File.Exists(rutaImagen))
                    File.Delete(rutaImagen);

                // Crear imagen quickresponse
                Image quickResponseImage = QuickResponse.QuickResponseGenerador(logicaFactura.SeleccionarFacturaParaDetalle().Id.ToString(), 53);

                // Salvarla en c:\temp para luego ser leida
                quickResponseImage.Save(rutaImagen, ImageFormat.Png);

                MessageBox.Show("Compra realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRegresar.Visible = false;
                btnFacturar.Enabled = false;

                //Cargar la formulario que contiene la factura
                frmFacturacion reporteFactura = new frmFacturacion();
                frmFacturacion = reporteFactura;
                reporteFactura.IdFactura = logicaFactura.SeleccionarFacturaParaDetalle().Id;
                reporteFactura.TopLevel = false;
                reporteFactura.Dock = DockStyle.Fill;
                pnlFactura.Controls.Add(reporteFactura);
                reporteFactura.Show();

                //Cargar el formulario que contiende las entradas
                frmEntradas reporteEntradas = new frmEntradas();
                reporteEntradas.ListaEntradas = ListaEntradas;
                reporteEntradas.IdFactura = logicaFactura.SeleccionarFacturaParaDetalle().Id;
                reporteEntradas.TopLevel = false;
                reporteEntradas.Dock = DockStyle.Fill;
                pnlEntradas.Controls.Add(reporteEntradas);
                reporteEntradas.Show();

                btnPDF.Visible = true;
                lblPDF.Visible = true;
                btnSalir.Visible = true;
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

        /// <summary>
        /// Crear el reporte a documento PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPDF_Click(object sender, EventArgs e)
        {
           
            string ruta = @"c:\temp\ReporteFacturacion.pdf";
            try
            {
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = frmFacturacion.rpvFactura.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                MessageBox.Show("Impresión realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
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

                //Log4Net
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(System.Reflection.MethodBase.GetCurrentMethod(), ex));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Llena todos para la factura con logica de negocia detalle
        /// </summary>

        private void llenarCampos()
        {
            EntradaLN logicaEntrada = new EntradaLN();
            logicaEntrada.ListaEntradas = ListaEntradas;
            logicaEntrada.oPelicula = SalaPelicula.Pelicula;
            logicaEntrada.oUsuario = Usuario;
            txtUsuario.Text = Usuario.Nombre + " " + Usuario.Apellidos;
            txtTipoUsuario.Text = Usuario.TipoUsuario.ToString();
            txtPrecio.Text = logicaEntrada.PrecioEntrada().ToString("#,###.00");
            ListaEntradas = logicaEntrada.AsignarPrecio();


            Detalle_FacturaLN logicaDetalle = new Detalle_FacturaLN();
            logicaDetalle.ListaEntradas = ListaEntradas;
            logicaDetalle.oPelicula = SalaPelicula.Pelicula;
            logicaDetalle.oUsuario = Usuario;
            txtCantidad.Text = logicaDetalle.Cantidad().ToString();
            txtSubtotal.Text = logicaDetalle.Subtotal().ToString("#,###.00");
            txtImpuesto.Text = logicaDetalle.Impuesto().ToString("#,###.00");
            txtDescuento.Text = logicaDetalle.Descuento().ToString("#,###.00");
            txtTotal.Text = logicaDetalle.Total().ToString("#,###.00");

            ServiceBCCR services = new ServiceBCCR();
            foreach (var cambio in services.GetDolar(DateTime.Now, DateTime.Now, "c"))
            {
                lblCompra.Text += cambio.Monto.ToString("#,###.00");
            }

            foreach (var cambio in services.GetDolar(DateTime.Now, DateTime.Now, "v"))
            {
                lblVenta.Text += cambio.Monto.ToString("#,###.00");
            }
        }
    }
}
