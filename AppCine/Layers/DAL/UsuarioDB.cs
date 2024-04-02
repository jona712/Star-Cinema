using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class UsuarioDB
    {
        public void Insertar(Usuario oUsuario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarUsuario";

                comando.Parameters.AddWithValue("@Id", oUsuario.Id);
                comando.Parameters.AddWithValue("@Nombre", oUsuario.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", oUsuario.Apellidos);
                comando.Parameters.AddWithValue("@Correo", oUsuario.Correo);
                comando.Parameters.AddWithValue("@Contrasena", oUsuario.Contrasena);
                comando.Parameters.AddWithValue("@Telefono", oUsuario.Telefono);
                comando.Parameters.AddWithValue("@FechaNacimiento", oUsuario.FechaNacimiento);
                comando.Parameters.AddWithValue("@Tipo", oUsuario.Tipo);
                comando.Parameters.AddWithValue("@Imagen", oUsuario.Imagen.ToArray());
                comando.Parameters.AddWithValue("@NumeroMembresia", oUsuario.NumeroMembresia);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Usuario oUsuario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarUsuario";

                comando.Parameters.AddWithValue("@Id", oUsuario.Id);
                comando.Parameters.AddWithValue("@Nombre", oUsuario.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", oUsuario.Apellidos);
                comando.Parameters.AddWithValue("@Correo", oUsuario.Correo);
                comando.Parameters.AddWithValue("@Contrasena", oUsuario.Contrasena);
                comando.Parameters.AddWithValue("@Telefono", oUsuario.Telefono);
                comando.Parameters.AddWithValue("@FechaNacimiento", oUsuario.FechaNacimiento);
                comando.Parameters.AddWithValue("@Tipo", oUsuario.Tipo);
                comando.Parameters.AddWithValue("@Imagen", oUsuario.Imagen.ToArray());
                comando.Parameters.AddWithValue("@NumeroMembresia", oUsuario.NumeroMembresia);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarUsuario";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public Usuario SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarUsuarioPorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = (int)dr["Id"];
                    oUsuario.Nombre = dr["Nombre"].ToString();
                    oUsuario.Apellidos = dr["Apellidos"].ToString();
                    oUsuario.Correo = dr["Correo"].ToString();
                    oUsuario.Contrasena = dr["Contrasena"].ToString();
                    oUsuario.Telefono = (int)dr["Telefono"];
                    oUsuario.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    oUsuario.Tipo = (int)dr["Tipo"];
                    oUsuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(oUsuario.Tipo);
                    oUsuario.Imagen = (byte[])dr["Imagen"];
                    oUsuario.NumeroMembresia = (int)dr["NumeroMembresia"];

                    return oUsuario;
                }
            }
            return null;
        }

        public List<Usuario> SeleccionarTodas()
        {
         
            List<Usuario> lista = new List<Usuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "[PA_SeleccionarUsuarios]";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = (int)dr["Id"];
                    oUsuario.Nombre = dr["Nombre"].ToString();
                    oUsuario.Apellidos = dr["Apellidos"].ToString();
                    oUsuario.Correo = dr["Correo"].ToString();
                    oUsuario.Contrasena = dr["Contrasena"].ToString();
                    oUsuario.Telefono = (int)dr["Telefono"];
                    oUsuario.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    oUsuario.Tipo = (int)dr["Tipo"];
                    oUsuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(oUsuario.Tipo);
                    oUsuario.Imagen = (byte[])dr["Imagen"];
                    oUsuario.NumeroMembresia = (int)dr["NumeroMembresia"];

                    lista.Add(oUsuario);
                }
            }
            return lista;
        }

        public Usuario SeleccionarPorCorreo_Contrasena(string correo, string contrasena)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarUsuarioPorCorreo_Contrasena";
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@contrasena", contrasena);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = (int)dr["Id"];
                    oUsuario.Nombre = dr["Nombre"].ToString();
                    oUsuario.Apellidos = dr["Apellidos"].ToString();
                    oUsuario.Correo = dr["Correo"].ToString();
                    oUsuario.Contrasena = dr["Contrasena"].ToString();
                    oUsuario.Telefono = (int)dr["Telefono"];
                    oUsuario.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    oUsuario.Tipo = (int)dr["Tipo"];
                    oUsuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(oUsuario.Tipo);
                    oUsuario.Imagen = (byte[])dr["Imagen"];
                    oUsuario.NumeroMembresia = (int)dr["NumeroMembresia"];

                    return oUsuario;
                }
            }
            return null;
        }

        public Usuario SeleccionarPorCorreo(string correo)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarUsuarioPorCorreo";
                comando.Parameters.AddWithValue("@correo", correo);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Id = (int)dr["Id"];
                    oUsuario.Nombre = dr["Nombre"].ToString();
                    oUsuario.Apellidos = dr["Apellidos"].ToString();
                    oUsuario.Correo = dr["Correo"].ToString();
                    oUsuario.Contrasena = dr["Contrasena"].ToString();
                    oUsuario.Telefono = (int)dr["Telefono"];
                    oUsuario.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    oUsuario.Tipo = (int)dr["Tipo"];
                    oUsuario.TipoUsuario = TipoUsuarioDB.SeleccionarPorId(oUsuario.Tipo);
                    oUsuario.Imagen = (byte[])dr["Imagen"];
                    oUsuario.NumeroMembresia = (int)dr["NumeroMembresia"];

                    return oUsuario;
                }
            }
            return null;
        }

    }
}
