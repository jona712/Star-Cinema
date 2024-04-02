using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Entrada
    {
        public int Id { get; set; }

        public int IdSala { get; set; }

        public int IdPelicula { get; set; }

        public int IdHorario { get; set; }

        public int IdAsiento { get; set; }

        public double Precio { get; set; }

        public Sala Sala { get; set; }

        public Pelicula Pelicula { get; set; }

        public Horario Horario { get; set; }

        public Asiento Asiento { get; set; }

        public override string ToString()
        {
            return "Ubicación: " +Sala.Descripcion + " / Película: " +Pelicula.Descripcion + " / Hora: " +Horario.FechaYHora + " / Asiento: " + Asiento.Descripcion;
        }
    }
}
