using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Asiento
    {
        public int Id { get; set; }

        public int IdSala { get; set; }

        public int IdHorario { get; set; }

        public string Descripcion { get; set; }

        public bool Estado { get; set; }
    }
}
