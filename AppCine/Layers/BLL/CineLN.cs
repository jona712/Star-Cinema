using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class CineLN
    {
        /// <summary>
        /// Guarda cine
        /// </summary>
        /// <param name="oCine"></param>
        public void Guardar(Cine oCine)
        {
            CineDB datos = new CineDB();
            if (CineDB.SeleccionarPorId(oCine.Id) == null)
            {
                datos.Insertar(oCine);
            }
            else
            {
                datos.Actualizar(oCine);
            }
        }

        /// <summary>
        /// Elimina el cine
        /// </summary>
        /// <param name="id"></param>

        public void Eliminar(int id)
        {
            CineDB datos = new CineDB();

            if (CineDB.SeleccionarPorId(id) == null)
                throw new ApplicationException("El código no existe");

            datos.Eliminar(id);
        }

        /// <summary>
        /// Obtiene todos los cines
        /// </summary>
        /// <returns></returns>

        public List<Cine> ObtenerCines()
        {
            return CineDB.SeleccionarTodas();
        }
    }
}
