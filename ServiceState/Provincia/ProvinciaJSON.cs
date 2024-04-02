using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioProvincia
{
    public class ProvinciaJSON
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public int codigo_postal { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
