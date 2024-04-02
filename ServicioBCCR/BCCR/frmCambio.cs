using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioBCCR.BCCR
{
    public partial class frmCambio : Form
    {
        public frmCambio()
        {
            InitializeComponent();
        }

        private void frmCambio_Load(object sender, EventArgs e)
        {
            dtpFechaFinal.Value = DateTime.Now;
            dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            dtpFechaInicial.Value = DateTime.Now;
            dtpFechaFinal.CustomFormat = "dd/MM/yyyy";
            rdbCompra.Checked = false;
            rdbVenta.Checked = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string compraOVenta = "";
            if (rdbCompra.Checked)
            {
                compraOVenta = "c";
            }
            else
            {
                compraOVenta = "v";
            }
            ServiceBCCR services = new ServiceBCCR();
            dataGridView1.DataSource = services.GetDolar(dtpFechaInicial.Value,
            dtpFechaFinal.Value, compraOVenta);
        }
    }
}
