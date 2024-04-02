using AppCine.CapaUI;
using AppCine.Layers.UI.Procesos;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine.CapaInterfaz
{
    public partial class frmAsientos : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public static frmPrincipal principal = null;

        public SalaPelicula SalaPelicula;

        public List<Entrada> ListaEntradas = null;

        public frmAsientos()
        {
            InitializeComponent();
        }

        private void frmAsientos_Load(object sender, EventArgs e)
        {
            LlenarAsientos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmHorarios horarios = new frmHorarios();
            horarios.SalaPelicula = SalaPelicula;
            horarios.TopLevel = false;
            horarios.Dock = DockStyle.Fill;
            principal.pnlEscritorio.Controls.Clear();
            principal.pnlEscritorio.Controls.Add(horarios);
            horarios.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                AsientoLN logica = new AsientoLN();

                Entrada oEntrada = null;

                StringBuilder hilera = new StringBuilder();

                ListaEntradas = new List<Entrada>();

                if (ValidarSeleccion() == false)
                {
                    MessageBox.Show("No se han seleccionado asientos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var item in ListaAsientos())
                {
                    foreach (var item2 in logica.ObtenerAsientos(SalaPelicula.IdSala, SalaPelicula.IdHorario))
                    {
                        if (item.Checked)
                        {
                            if (item.Tag.Equals(item2.Id))
                            {
                                item2.Estado = false;
                                logica.Guardar(item2);

                                //Entrada
                                EntradaLN logicaEntrada = new EntradaLN();
                                logicaEntrada.oPelicula = SalaPelicula.Pelicula;

                                oEntrada = new Entrada();
                                oEntrada.IdSala = SalaPelicula.IdSala;
                                oEntrada.IdPelicula = SalaPelicula.IdPelicula;
                                oEntrada.IdHorario = SalaPelicula.IdHorario;
                                oEntrada.IdAsiento = item2.Id;
                                oEntrada.Precio = logicaEntrada.PrecioEntrada();
                                Limpiar();

                                //Adicional
                                oEntrada.Sala = SalaPelicula.Sala;
                                oEntrada.Pelicula = SalaPelicula.Pelicula;
                                oEntrada.Horario = SalaPelicula.Horario;
                                oEntrada.Asiento = item2;

                                ListaEntradas.Add(oEntrada);
                            }
                        }
                    }
                }

                frmFactura factura = new frmFactura();
                factura.ListaEntradas = ListaEntradas;
                factura.SalaPelicula = SalaPelicula;
                factura.TopLevel = false;
                factura.Dock = DockStyle.Fill;
                principal.pnlEscritorio.Controls.Clear();
                principal.pnlEscritorio.Controls.Add(factura);
                factura.Show();
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

        private void LlenarAsientos()
        {
            try
            {
                AsientoLN logica = new AsientoLN();
                int i = 0;
                foreach (var item in logica.ObtenerAsientos(SalaPelicula.IdSala, SalaPelicula.IdHorario))
                {
                    var asiento = ListaAsientos()[i];

                    if (item.Estado == false)
                    {
                        asiento.Text = item.Descripcion;
                        asiento.Tag = item.Id;
                        asiento.BackColor = Color.Maroon;
                        asiento.Enabled = false;
                        i++;
                    }
                    else
                    {
                        asiento.Text = item.Descripcion;
                        asiento.Tag = item.Id;
                        i++;
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

        private void Limpiar()
        {
            foreach (var item in ListaAsientos())
            {
                if (item.Checked)
                {
                    item.BackColor = Color.Black;
                    item.Enabled = false;
                }
            }
        }

        private bool ValidarSeleccion()
        {
            bool selecciono = false;
            foreach (var item in ListaAsientos())
            {
                if (item.Checked == true)
                {
                    selecciono = true;
                    break;
                }
            }
            return selecciono;
        }

        public void EliminarSeleccion()
        {
            AsientoLN logica = new AsientoLN();

            foreach (var item in ListaEntradas)
            {
                var oAsiento = logica.SeleccionarAsientoPorId(item.IdAsiento, item.IdSala, item.IdHorario);
                oAsiento.Estado = true;
                logica.Guardar(oAsiento);
            }
        }

        private List<CheckBox> ListaAsientos()
        {
            List<CheckBox> lista = new List<CheckBox>();

            lista.Add(chk1_1);
            lista.Add(chk1_2);
            lista.Add(chk1_3);
            lista.Add(chk1_4);
            lista.Add(chk1_5);
            lista.Add(chk1_6);
            lista.Add(chk1_7);
            lista.Add(chk1_8);
            lista.Add(chk1_9);
            lista.Add(chk1_10);

            lista.Add(chk2_1);
            lista.Add(chk2_2);
            lista.Add(chk2_3);
            lista.Add(chk2_4);
            lista.Add(chk2_5);
            lista.Add(chk2_6);
            lista.Add(chk2_7);
            lista.Add(chk2_8);
            lista.Add(chk2_9);
            lista.Add(chk2_10);

            lista.Add(chk3_1);
            lista.Add(chk3_2);
            lista.Add(chk3_3);
            lista.Add(chk3_4);
            lista.Add(chk3_5);
            lista.Add(chk3_6);
            lista.Add(chk3_7);
            lista.Add(chk3_8);
            lista.Add(chk3_9);
            lista.Add(chk3_10);

            lista.Add(chk4_1);
            lista.Add(chk4_2);
            lista.Add(chk4_3);
            lista.Add(chk4_4);
            lista.Add(chk4_5);
            lista.Add(chk4_6);
            lista.Add(chk4_7);
            lista.Add(chk4_8);
            lista.Add(chk4_9);
            lista.Add(chk4_10);

            lista.Add(chk5_1);
            lista.Add(chk5_2);
            lista.Add(chk5_3);
            lista.Add(chk5_4);
            lista.Add(chk5_5);
            lista.Add(chk5_6);
            lista.Add(chk5_7);
            lista.Add(chk5_8);
            lista.Add(chk5_9);
            lista.Add(chk5_10);

            lista.Add(chk6_1);
            lista.Add(chk6_2);
            lista.Add(chk6_3);
            lista.Add(chk6_4);
            lista.Add(chk6_5);
            lista.Add(chk6_6);
            lista.Add(chk6_7);
            lista.Add(chk6_8);
            lista.Add(chk6_9);
            lista.Add(chk6_10);

            lista.Add(chk7_1);
            lista.Add(chk7_2);
            lista.Add(chk7_3);
            lista.Add(chk7_4);
            lista.Add(chk7_5);
            lista.Add(chk7_6);
            lista.Add(chk7_7);
            lista.Add(chk7_8);
            lista.Add(chk7_9);
            lista.Add(chk7_10);

            lista.Add(chk8_1);
            lista.Add(chk8_2);
            lista.Add(chk8_3);
            lista.Add(chk8_4);
            lista.Add(chk8_5);
            lista.Add(chk8_6);
            lista.Add(chk8_7);
            lista.Add(chk8_8);
            lista.Add(chk8_9);
            lista.Add(chk8_10);

            return lista;
        }

        private void chk1_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_1.Checked)
            {
                chk1_1.BackColor = Color.Lime;
            }
            else
            {
                chk1_1.BackColor = Color.Gray;
            }
        }

        private void chk1_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_2.Checked)
            {
                chk1_2.BackColor = Color.Lime;
            }
            else
            {
                chk1_2.BackColor = Color.Gray;
            }
        }

        private void chk1_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_3.Checked)
            {
                chk1_3.BackColor = Color.Lime;
            }
            else
            {
                chk1_3.BackColor = Color.Gray;
            }
        }

        private void chk1_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_4.Checked)
            {
                chk1_4.BackColor = Color.Lime;
            }
            else
            {
                chk1_4.BackColor = Color.Gray;
            }
        }

        private void chk1_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_5.Checked)
            {
                chk1_5.BackColor = Color.Lime;
            }
            else
            {
                chk1_5.BackColor = Color.Gray;
            }
        }

        private void chk1_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_6.Checked)
            {
                chk1_6.BackColor = Color.Lime;
            }
            else
            {
                chk1_6.BackColor = Color.Gray;
            }
        }

        private void chk1_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_7.Checked)
            {
                chk1_7.BackColor = Color.Lime;
            }
            else
            {
                chk1_7.BackColor = Color.Gray;
            }
        }

        private void chk1_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_8.Checked)
            {
                chk1_8.BackColor = Color.Lime;
            }
            else
            {
                chk1_8.BackColor = Color.Gray;
            }
        }

        private void chk1_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_9.Checked)
            {
                chk1_9.BackColor = Color.Lime;
            }
            else
            {
                chk1_9.BackColor = Color.Gray;
            }
        }

        private void chk1_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1_10.Checked)
            {
                chk1_10.BackColor = Color.Lime;
            }
            else
            {
                chk1_10.BackColor = Color.Gray;
            }
        }

        private void chk2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_1.Checked)
            {
                chk2_1.BackColor = Color.Lime;
            }
            else
            {
                chk2_1.BackColor = Color.Gray;
            }
        }

        private void chk2_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_2.Checked)
            {
                chk2_2.BackColor = Color.Lime;
            }
            else
            {
                chk2_2.BackColor = Color.Gray;
            }
        }

        private void chk2_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_3.Checked)
            {
                chk2_3.BackColor = Color.Lime;
            }
            else
            {
                chk2_3.BackColor = Color.Gray;
            }
        }

        private void chk2_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_4.Checked)
            {
                chk2_4.BackColor = Color.Lime;
            }
            else
            {
                chk2_4.BackColor = Color.Gray;
            }
        }

        private void chk2_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_5.Checked)
            {
                chk2_5.BackColor = Color.Lime;
            }
            else
            {
                chk2_5.BackColor = Color.Gray;
            }
        }

        private void chk2_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_6.Checked)
            {
                chk2_6.BackColor = Color.Lime;
            }
            else
            {
                chk2_6.BackColor = Color.Gray;
            }
        }

        private void chk2_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_7.Checked)
            {
                chk2_7.BackColor = Color.Lime;
            }
            else
            {
                chk2_7.BackColor = Color.Gray;
            }
        }

        private void chk2_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_8.Checked)
            {
                chk2_8.BackColor = Color.Lime;
            }
            else
            {
                chk2_8.BackColor = Color.Gray;
            }
        }

        private void chk2_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_9.Checked)
            {
                chk2_9.BackColor = Color.Lime;
            }
            else
            {
                chk2_9.BackColor = Color.Gray;
            }
        }

        private void chk2_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2_10.Checked)
            {
                chk2_10.BackColor = Color.Lime;
            }
            else
            {
                chk2_10.BackColor = Color.Gray;
            }
        }

        private void chk3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_1.Checked)
            {
                chk3_1.BackColor = Color.Lime;
            }
            else
            {
                chk3_1.BackColor = Color.Gray;
            }
        }

        private void chk3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_2.Checked)
            {
                chk3_2.BackColor = Color.Lime;
            }
            else
            {
                chk3_2.BackColor = Color.Gray;
            }
        }

        private void chk3_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_3.Checked)
            {
                chk3_3.BackColor = Color.Lime;
            }
            else
            {
                chk3_3.BackColor = Color.Gray;
            }
        }

        private void chk3_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_4.Checked)
            {
                chk3_4.BackColor = Color.Lime;
            }
            else
            {
                chk3_4.BackColor = Color.Gray;
            }
        }

        private void chk3_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_5.Checked)
            {
                chk3_5.BackColor = Color.Lime;
            }
            else
            {
                chk3_5.BackColor = Color.Gray;
            }
        }

        private void chk3_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_6.Checked)
            {
                chk3_6.BackColor = Color.Lime;
            }
            else
            {
                chk3_6.BackColor = Color.Gray;
            }
        }

        private void chk3_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_7.Checked)
            {
                chk3_7.BackColor = Color.Lime;
            }
            else
            {
                chk3_7.BackColor = Color.Gray;
            }
        }

        private void chk3_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_8.Checked)
            {
                chk3_8.BackColor = Color.Lime;
            }
            else
            {
                chk3_8.BackColor = Color.Gray;
            }
        }

        private void chk3_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_9.Checked)
            {
                chk3_9.BackColor = Color.Lime;
            }
            else
            {
                chk3_9.BackColor = Color.Gray;
            }
        }

        private void chk3_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3_10.Checked)
            {
                chk3_10.BackColor = Color.Lime;
            }
            else
            {
                chk3_10.BackColor = Color.Gray;
            }
        }

        private void chk4_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_1.Checked)
            {
                chk4_1.BackColor = Color.Lime;
            }
            else
            {
                chk4_1.BackColor = Color.Gray;
            }
        }

        private void chk4_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_2.Checked)
            {
                chk4_2.BackColor = Color.Lime;
            }
            else
            {
                chk4_2.BackColor = Color.Gray;
            }
        }

        private void chk4_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_3.Checked)
            {
                chk4_3.BackColor = Color.Lime;
            }
            else
            {
                chk4_3.BackColor = Color.Gray;
            }
        }

        private void chk4_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_4.Checked)
            {
                chk4_4.BackColor = Color.Lime;
            }
            else
            {
                chk4_4.BackColor = Color.Gray;
            }
        }

        private void chk4_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_5.Checked)
            {
                chk4_5.BackColor = Color.Lime;
            }
            else
            {
                chk4_5.BackColor = Color.Gray;
            }
        }

        private void chk4_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_6.Checked)
            {
                chk4_6.BackColor = Color.Lime;
            }
            else
            {
                chk4_6.BackColor = Color.Gray;
            }
        }

        private void chk4_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_7.Checked)
            {
                chk4_7.BackColor = Color.Lime;
            }
            else
            {
                chk4_7.BackColor = Color.Gray;
            }
        }

        private void chk4_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_8.Checked)
            {
                chk4_8.BackColor = Color.Lime;
            }
            else
            {
                chk4_8.BackColor = Color.Gray;
            }
        }

        private void chk4_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_9.Checked)
            {
                chk4_9.BackColor = Color.Lime;
            }
            else
            {
                chk4_9.BackColor = Color.Gray;
            }
        }

        private void chk4_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4_10.Checked)
            {
                chk4_10.BackColor = Color.Lime;
            }
            else
            {
                chk4_10.BackColor = Color.Gray;
            }
        }

        private void chk5_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_1.Checked)
            {
                chk5_1.BackColor = Color.Lime;
            }
            else
            {
                chk5_1.BackColor = Color.Gray;
            }
        }

        private void chk5_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_2.Checked)
            {
                chk5_2.BackColor = Color.Lime;
            }
            else
            {
                chk5_2.BackColor = Color.Gray;
            }
        }

        private void chk5_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_3.Checked)
            {
                chk5_3.BackColor = Color.Lime;
            }
            else
            {
                chk5_3.BackColor = Color.Gray;
            }
        }

        private void chk5_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_4.Checked)
            {
                chk5_4.BackColor = Color.Lime;
            }
            else
            {
                chk5_4.BackColor = Color.Gray;
            }
        }

        private void chk5_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_5.Checked)
            {
                chk5_5.BackColor = Color.Lime;
            }
            else
            {
                chk5_5.BackColor = Color.Gray;
            }
        }

        private void chk5_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_6.Checked)
            {
                chk5_6.BackColor = Color.Lime;
            }
            else
            {
                chk5_6.BackColor = Color.Gray;
            }
        }

        private void chk5_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_7.Checked)
            {
                chk5_7.BackColor = Color.Lime;
            }
            else
            {
                chk5_7.BackColor = Color.Gray;
            }
        }

        private void chk5_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_8.Checked)
            {
                chk5_8.BackColor = Color.Lime;
            }
            else
            {
                chk5_8.BackColor = Color.Gray;
            }
        }

        private void chk5_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_9.Checked)
            {
                chk5_9.BackColor = Color.Lime;
            }
            else
            {
                chk5_9.BackColor = Color.Gray;
            }
        }

        private void chk5_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5_10.Checked)
            {
                chk5_10.BackColor = Color.Lime;
            }
            else
            {
                chk5_10.BackColor = Color.Gray;
            }
        }

        private void chk6_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_1.Checked)
            {
                chk6_1.BackColor = Color.Lime;
            }
            else
            {
                chk6_1.BackColor = Color.Gray;
            }
        }

        private void chk6_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_2.Checked)
            {
                chk6_2.BackColor = Color.Lime;
            }
            else
            {
                chk6_2.BackColor = Color.Gray;
            }
        }

        private void chk6_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_3.Checked)
            {
                chk6_3.BackColor = Color.Lime;
            }
            else
            {
                chk6_3.BackColor = Color.Gray;
            }
        }

        private void chk6_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_4.Checked)
            {
                chk6_4.BackColor = Color.Lime;
            }
            else
            {
                chk6_4.BackColor = Color.Gray;
            }
        }

        private void chk6_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_5.Checked)
            {
                chk6_5.BackColor = Color.Lime;
            }
            else
            {
                chk6_5.BackColor = Color.Gray;
            }
        }

        private void chk6_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_6.Checked)
            {
                chk6_6.BackColor = Color.Lime;
            }
            else
            {
                chk6_6.BackColor = Color.Gray;
            }
        }

        private void chk6_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_7.Checked)
            {
                chk6_7.BackColor = Color.Lime;
            }
            else
            {
                chk6_7.BackColor = Color.Gray;
            }
        }

        private void chk6_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_8.Checked)
            {
                chk6_8.BackColor = Color.Lime;
            }
            else
            {
                chk6_8.BackColor = Color.Gray;
            }
        }

        private void chk6_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_9.Checked)
            {
                chk6_9.BackColor = Color.Lime;
            }
            else
            {
                chk6_9.BackColor = Color.Gray;
            }
        }

        private void chk6_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk6_10.Checked)
            {
                chk6_10.BackColor = Color.Lime;
            }
            else
            {
                chk6_10.BackColor = Color.Gray;
            }
        }

        private void chk7_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_1.Checked)
            {
                chk7_1.BackColor = Color.Lime;
            }
            else
            {
                chk7_1.BackColor = Color.Gray;
            }
        }

        private void chk7_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_2.Checked)
            {
                chk7_2.BackColor = Color.Lime;
            }
            else
            {
                chk7_2.BackColor = Color.Gray;
            }
        }

        private void chk7_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_3.Checked)
            {
                chk7_3.BackColor = Color.Lime;
            }
            else
            {
                chk7_3.BackColor = Color.Gray;
            }
        }

        private void chk7_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_4.Checked)
            {
                chk7_4.BackColor = Color.Lime;
            }
            else
            {
                chk7_4.BackColor = Color.Gray;
            }
        }

        private void chk7_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_5.Checked)
            {
                chk7_5.BackColor = Color.Lime;
            }
            else
            {
                chk7_5.BackColor = Color.Gray;
            }
        }

        private void chk7_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_6.Checked)
            {
                chk7_6.BackColor = Color.Lime;
            }
            else
            {
                chk7_6.BackColor = Color.Gray;
            }
        }

        private void chk7_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_7.Checked)
            {
                chk7_7.BackColor = Color.Lime;
            }
            else
            {
                chk7_7.BackColor = Color.Gray;
            }
        }

        private void chk7_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_8.Checked)
            {
                chk7_8.BackColor = Color.Lime;
            }
            else
            {
                chk7_8.BackColor = Color.Gray;
            }
        }

        private void chk7_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_9.Checked)
            {
                chk7_9.BackColor = Color.Lime;
            }
            else
            {
                chk7_9.BackColor = Color.Gray;
            }
        }

        private void chk7_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk7_10.Checked)
            {
                chk7_10.BackColor = Color.Lime;
            }
            else
            {
                chk7_10.BackColor = Color.Gray;
            }
        }

        private void chk8_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_1.Checked)
            {
                chk8_1.BackColor = Color.Lime;
            }
            else
            {
                chk8_1.BackColor = Color.Gray;
            }
        }

        private void chk8_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_2.Checked)
            {
                chk8_2.BackColor = Color.Lime;
            }
            else
            {
                chk8_2.BackColor = Color.Gray;
            }
        }

        private void chk8_3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_3.Checked)
            {
                chk8_3.BackColor = Color.Lime;
            }
            else
            {
                chk8_3.BackColor = Color.Gray;
            }
        }

        private void chk8_4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_4.Checked)
            {
                chk8_4.BackColor = Color.Lime;
            }
            else
            {
                chk8_4.BackColor = Color.Gray;
            }
        }

        private void chk8_5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_5.Checked)
            {
                chk8_5.BackColor = Color.Lime;
            }
            else
            {
                chk8_5.BackColor = Color.Gray;
            }
        }

        private void chk8_6_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_6.Checked)
            {
                chk8_6.BackColor = Color.Lime;
            }
            else
            {
                chk8_6.BackColor = Color.Gray;
            }
        }

        private void chk8_7_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_7.Checked)
            {
                chk8_7.BackColor = Color.Lime;
            }
            else
            {
                chk8_7.BackColor = Color.Gray;
            }
        }

        private void chk8_8_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_8.Checked)
            {
                chk8_8.BackColor = Color.Lime;
            }
            else
            {
                chk8_8.BackColor = Color.Gray;
            }
        }

        private void chk8_9_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_9.Checked)
            {
                chk8_9.BackColor = Color.Lime;
            }
            else
            {
                chk8_9.BackColor = Color.Gray;
            }
        }

        private void chk8_10_CheckedChanged(object sender, EventArgs e)
        {
            if (chk8_10.Checked)
            {
                chk8_10.BackColor = Color.Lime;
            }
            else
            {
                chk8_10.BackColor = Color.Gray;
            }
        }


    }
}
