using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class AsientoLN
    {
        /// <summary>
        /// Guarda el asiento
        /// </summary>
        /// <param name="oAsiento"></param>
        public void Guardar(Asiento oAsiento)
        {
            AsientoDB datos = new AsientoDB();
            if (AsientoDB.SeleccionarPorId(oAsiento.Id, oAsiento.IdSala, oAsiento.IdHorario) == null)
            {
                datos.Insertar(oAsiento);
            }
            else
            {
                datos.Actualizar(oAsiento);
            }
        }

        /// <summary>
        /// Selecciona el asiento segun el id, idsala, idHorario
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="IdSala"></param>
        /// <param name="IdHorario"></param>
        /// <returns></returns>
        public Asiento SeleccionarAsientoPorId(int Id, int IdSala, int IdHorario)
        {
            return AsientoDB.SeleccionarPorId(Id, IdSala, IdHorario);
        }

       
        /// <summary>
        /// Selecciona
        /// </summary>
        /// <param name="IdSala"></param>
        /// <param name="IdHorario"></param>
        /// <returns></returns>
        public List<Asiento> ObtenerAsientos(int IdSala, int IdHorario)
        {
            return AsientoDB.SeleccionarTodas(IdSala, IdHorario);
        }
    }
}

