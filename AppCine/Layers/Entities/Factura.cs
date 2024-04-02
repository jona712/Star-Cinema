using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Factura
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        public double Total { get; set; }
    }
}
