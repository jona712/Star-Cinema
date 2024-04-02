using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Detalle_Factura
    {
        public int Id { get; set; }

        public int IdFactura { get; set; }

        public int IdEntrada { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        public double Subtotal { get; set; }

        public double Impuesto { get; set; }
    }
}
