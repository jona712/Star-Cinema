using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine
{
    public class UsuarioLN
    {
        /// <summary>
        /// guarda un usuario
        /// </summary>
        /// <param name="oUsuario"></param>
        public void Guardar(Usuario oUsuario)
        {
            //if (oAsiento == null)
            //    throw new ApplicationException("No existe una Categoría");
            if (oUsuario.Id <= 0)
                throw new ApplicationException("El Id debe ser entero positivo");
            if (oUsuario.Nombre.Length == 0)
                throw new ApplicationException("El nombre es requerido");

            UsuarioDB datos = new UsuarioDB();
            if (datos.SeleccionarPorId(oUsuario.Id) == null)
            {
                datos.Insertar(oUsuario);
            }
            else
            {
                datos.Actualizar(oUsuario);
            }
        }

        /// <summary>
        /// Elimina un ususario
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            UsuarioDB datos = new UsuarioDB();

            if (datos.SeleccionarPorId(id) == null)
                throw new ApplicationException("El código no existe");

            datos.Eliminar(id);
        }

        /// <summary>
        /// obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerUsuarios()
        {
            UsuarioDB datos = new UsuarioDB();
            return datos.SeleccionarTodas();
        }

        /// <summary>
        /// seleciona un usario segun el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public Usuario SeleccionarUsuarioPorId(int id)
        {
            UsuarioDB datos = new UsuarioDB();

            Usuario oUsuario = datos.SeleccionarPorId(id);

            return oUsuario;
        }

        /// <summary>
        /// selecciona un usuario segun el correo o la contraseña
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contrasena"></param>
        /// <returns></returns>

        public Usuario SeleccionarUsuarioPorCorreo_Contrasena(string correo, string contrasena)
        {
            UsuarioDB datos = new UsuarioDB();

            Usuario oUsuario = datos.SeleccionarPorCorreo_Contrasena(correo, contrasena);

            return oUsuario;
        }

        /// <summary>
        /// selecciona un usuario según su correo
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>

        public Usuario SeleccionarUsuarioPorCorreo(string correo)
        {
            UsuarioDB datos = new UsuarioDB();

            Usuario oUsuario = datos.SeleccionarPorCorreo(correo);

            return oUsuario;
        }
    }
}
