using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Net.Mail;
//using System.Net;

namespace AppCine
{
    public class EnviarCorreo
    {
        /// <summary>
        /// Envia el codigo de verificacion para recuperar la contraseña segun el correo
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="codigo"></param>
        public void EnviarCodigoVerificacion(string correo, int codigo)
        {
            try
            {
                String CuentaCorreoElectronico = "starcinema.cr@gmail.com";
                String ContrasenaGeneradaGmail = "jmcaolqmpzwlogph";
                MailMessage mensaje = new MailMessage();
                mensaje.IsBodyHtml = true;
                mensaje.Subject = "Restablecer contraseña";
                mensaje.Body = "No comparta el código de verificación con nadie que no tenga una razón válida para recibirlo, ya que esto podría comprometer su seguridad." +
                               "Su código es: " + codigo.ToString();

                mensaje.From = new MailAddress(CuentaCorreoElectronico);
                mensaje.To.Add(correo); //Correo del destinatario
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico,
                ContrasenaGeneradaGmail);
                smtp.EnableSsl = true;
                //Attachment attachment = new Attachment(@"c:\temp\archivo.txt");
                //mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
                MessageBox.Show("El código de verificación fue enviado a " + correo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// envia el numero de membresia para los usuario premium
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="codigo"></param>
        public void EnviarNumeroMembresia(string correo, int codigo)
        {
            try
            {
                String CuentaCorreoElectronico = "starcinema.cr@gmail.com";
                String ContrasenaGeneradaGmail = "jmcaolqmpzwlogph";
                MailMessage mensaje = new MailMessage();
                mensaje.IsBodyHtml = true;
                mensaje.Subject = "Bienveido a zona Plus";
                mensaje.Body = "Su número de ingreso a la zona es: " + codigo.ToString(); ;

                mensaje.From = new MailAddress(CuentaCorreoElectronico);
                mensaje.To.Add(correo); //Correo del destinatario
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico,
                ContrasenaGeneradaGmail);
                smtp.EnableSsl = true;
                //Attachment attachment = new Attachment(@"c:\temp\archivo.txt");
                //mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
                MessageBox.Show("       Bienvenido a la zona PREMIUM de Star Cinema Plus.\n" +
            "Su número de membresía fue enviado a su correo personal.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// Enviar el reporte adjunto en el correo
        /// </summary>
        /// <param name="correo"></param>

        public void EnviarReporte(string correo)
        {
            try
            {
                String CuentaCorreoElectronico = "starcinema.cr@gmail.com";
                String ContrasenaGeneradaGmail = "jmcaolqmpzwlogph";
                MailMessage mensaje = new MailMessage();
                mensaje.IsBodyHtml = true;
                mensaje.Subject = "Reporte";
                mensaje.Body = "";

                mensaje.From = new MailAddress(CuentaCorreoElectronico);
                mensaje.To.Add(correo); //Correo del destinatario
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico,
                ContrasenaGeneradaGmail);
                smtp.EnableSsl = true;
                Attachment attachment = new Attachment(@"c:\temp\ReporteFacturacion.pdf");
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
                MessageBox.Show("El reporte fue compartido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}


