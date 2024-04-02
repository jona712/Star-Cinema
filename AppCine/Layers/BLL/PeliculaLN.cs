using ServicioBCCR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppCine
{
    public class PeliculaLN
    {
        public List<Entrada> ListaEntradas = null;
        

        /// <summary>
        /// guarda una pelicula
        /// </summary>
        /// <param name="oPelicula"></param>
        public void Guardar(Pelicula oPelicula)
        {
            PeliculaDB datos = new PeliculaDB();
            if (PeliculaDB.SeleccionarPorId(oPelicula.Id) == null)
            {
                datos.Insertar(oPelicula);
            }
            else
            {
                datos.Actualizar(oPelicula);
            }
        }

        /// <summary>
        /// Elimina una pelicula
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            PeliculaDB datos = new PeliculaDB();

            if (PeliculaDB.SeleccionarPorId(id) == null)
                throw new ApplicationException("El código no existe");

            datos.Eliminar(id);
        }

        /// <summary>
        /// Obtiene todas la peliculas
        /// </summary>
        /// <returns></returns>
        public List<Pelicula> ObtenerPeliculas()
        {
            return PeliculaDB.SeleccionarTodas();
        }
    }
}
