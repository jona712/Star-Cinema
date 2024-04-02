using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class SalaLN
    {
        /// <summary>
        /// Obtiene todas la salas
        /// </summary>
        /// <returns></returns>
        public List<Sala> ObtenerSalas()
        {
            return SalaDB.SeleccionarTodas();
        }
    }
}
