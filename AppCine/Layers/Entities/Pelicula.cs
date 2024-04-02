using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Pelicula
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Sinopsis { get; set; }

        public bool Estado { get; set; }

        public byte []Imagen { get; set; }

        public int IdClasificacion { get; set; }

        public Clasificacion Clasificacion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
