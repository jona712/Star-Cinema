using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class HorarioLN
    {
        /// <summary>
        /// Obtiene todos los horario
        /// </summary>
        /// <returns></returns>
        public List<Horario> ObtenerHorarios()
        {
            return HorarioDB.SeleccionarTodas();
        }
    }
}
