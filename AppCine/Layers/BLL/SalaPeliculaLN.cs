using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class SalaPeliculaLN
    {
        
        /// <summary>
        /// guadar una sala pelicula
        /// </summary>
        /// <param name="oSalaPelicula"></param>
        public void Guardar(SalaPelicula oSalaPelicula)
        {
            SalaPeliculaDB datos = new SalaPeliculaDB();
            if (SalaPeliculaDB.SeleccionarPorId(oSalaPelicula.IdPelicula, oSalaPelicula.IdSala, oSalaPelicula.IdHorario) == null)
            {
                datos.Insertar(oSalaPelicula);
            }
        }

        /// <summary>
        /// elimina una salapelicula
        /// </summary>
        /// <param name="IdPelicula"></param>
        /// <param name="IdSala"></param>
        /// <param name="IdHorario"></param>
        public void Eliminar(int IdPelicula, int IdSala, int IdHorario)
        {
            SalaPeliculaDB datos = new SalaPeliculaDB();

            if (SalaPeliculaDB.SeleccionarPorId(IdPelicula, IdSala, IdHorario) == null)
                throw new ApplicationException("El código no existe");

            datos.Eliminar(IdPelicula, IdSala, IdHorario);
        }

       /// <summary>
       /// Selecciona una sala por sala y horario
       /// </summary>
       /// <param name="IdSala"></param>
       /// <param name="IdHorario"></param>
       /// <returns></returns>
        public SalaPelicula SeleccionarSalaPeliculaPorIdSala_IdHorario(int IdSala, int IdHorario)
        {
            SalaPelicula oSalaPelicula = SalaPeliculaDB.SeleccionarPorIdSala_IdHorario(IdSala, IdHorario);
            return oSalaPelicula;
        }

        /// <summary>
        /// obtiene todas la salaspeliculas
        /// </summary>
        /// <returns></returns>
        public List<SalaPelicula> ObtenerSalasPeliculas()
        {
            return SalaPeliculaDB.SeleccionarTodas();
        }

        /// <summary>
        /// obtiene todas las salapeliculas con el fin de mostrarlas en cartelera
        /// </summary>
        /// <returns></returns>

        public List<SalaPelicula> ObtenerSalasPeliculasParaCartelera()
        {
            return SalaPeliculaDB.SeleccionarTodasParaCartelera();
        }

    }
}

