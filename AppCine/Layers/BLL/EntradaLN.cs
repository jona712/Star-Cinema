using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class EntradaLN
    {
        public List<Entrada> ListaEntradas = null;

        public Pelicula oPelicula = null;

        public Usuario oUsuario = null;

        /// <summary>
        /// Retorna el precio de la entrada
        /// </summary>
        /// <returns></returns>
        public double PrecioEntrada()
        {
            double precio = 0;

            if (oPelicula.IdClasificacion == 1)
            {
                precio = 2900;
            }

            if (oPelicula.IdClasificacion == 2 || oPelicula.IdClasificacion == 3)
            {
                precio = 3200;
            }

            if (oPelicula.IdClasificacion == 4)
            {
                precio = 3500;
            }
            return precio;
        }

        public List<Entrada> AsignarPrecio()
        {
            List<Entrada> Lista = new List<Entrada>();

            foreach (var Entrada in ListaEntradas)
            {
                Entrada.Precio = PrecioEntrada();
                Lista.Add(Entrada);
            }
            return Lista;
        }

        /// <summary>
        /// Guarda la entrada
        /// </summary>
        /// <param name="entrada"></param>

        public void Guardar(Entrada entrada)
        {
            EntradaDB datos = new EntradaDB();

            datos.Insertar(entrada);
        }

        /// <summary>
        /// Selecciona la entrada segun sala,pelicula,horario y asiento
        /// </summary>
        /// <param name="IdSala"></param>
        /// <param name="IdPelicula"></param>
        /// <param name="IdHorario"></param>
        /// <param name="IdAsiento"></param>
        /// <returns></returns>

        public static Entrada SeleccionarEntradaParaDetalle(int IdSala, int IdPelicula, int IdHorario, int IdAsiento)
        {
            return EntradaDB.SeleccionarEntradaParaDetalle(IdSala, IdPelicula, IdHorario, IdAsiento);
        }
    }
}

