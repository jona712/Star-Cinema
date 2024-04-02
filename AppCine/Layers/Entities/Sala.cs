using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine
{
    public class Sala
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int IdCine { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
