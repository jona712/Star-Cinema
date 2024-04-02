using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Horario
    {
        public int Id { get; set; }

        public TimeSpan FechaYHora { get; set; }

        public bool Estado { get; set; }

        public override string ToString()
        {
            return ""+FechaYHora;
        }
    }
}
