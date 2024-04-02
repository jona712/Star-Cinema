using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class TipoUsuarioLN
    {
        /// <summary>
        /// Selecciona todos los tipos de usarios
        /// </summary>
        /// <returns></returns>
        public static List<TipoUsuario> ObtenerTipoUsuariosAdmin()
        {
            return TipoUsuarioDB.SeleccionarTodosAdmin();
        }

        /// <summary>
        /// obtiene todos los tipos de usuarios sin el admin
        /// </summary>
        /// <returns></returns>

        public static List<TipoUsuario> ObtenerTipoUsuariosNormal()
        {
            return TipoUsuarioDB.SeleccionarTodosNormales();
        }
    }
}
