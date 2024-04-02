using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class SalaPelicula
    {
        public int IdPelicula { get; set; }

        public int IdSala { get; set; }

        public int IdHorario { get; set; }

        public Pelicula Pelicula { get; set; }

        public Sala Sala { get; set; }

        public Horario Horario { get; set; }

        public override string ToString()
        {
            return Sala.Descripcion + " --> " + Pelicula.Descripcion + " --> " + Horario.FechaYHora +" p.m.";
        }
    }
}
