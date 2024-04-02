using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Cine
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Provincia { get; set; }

        public override string ToString()
        {
            return Id +" "+  Descripcion +" "+ Provincia;
        }
    }
}
