using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine.Layers.BLL
{
    public class ClasificacionLN
    {
        /// <summary>
        /// obtiene todas la clasificaciones
        /// </summary>
        /// <returns></returns>
        public static List<Clasificacion> ObtenerClasificaciones()
        {
            return ClasificacionDB.SeleccionarTodas();
        }

        /// <summary>
        /// Seleccionada la clasificacion por id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Clasificacion SeleccionarClasificacionPorId(int Id)
        {
            return ClasificacionDB.SeleccionarPorId(Id);
        }
    }
}
