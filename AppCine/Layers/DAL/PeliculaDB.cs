using AppCine.Layers.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class PeliculaDB
    {
        public void Insertar(Pelicula oPelicula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarPelicula";
                comando.Parameters.AddWithValue("@Id", oPelicula.Id);
                comando.Parameters.AddWithValue("@Descripcion", oPelicula.Descripcion);
                comando.Parameters.AddWithValue("@Sinopsis", oPelicula.Sinopsis);
                comando.Parameters.AddWithValue("@Estado", oPelicula.Estado);
                comando.Parameters.AddWithValue("@Imagen", oPelicula.Imagen.ToArray());
                comando.Parameters.AddWithValue("@Clasificacion", oPelicula.IdClasificacion);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Pelicula oPelicula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarPelicula";
                comando.Parameters.AddWithValue("@Id", oPelicula.Id);
                comando.Parameters.AddWithValue("@Descripcion", oPelicula.Descripcion);
                comando.Parameters.AddWithValue("@Sinopsis", oPelicula.Sinopsis );
                comando.Parameters.AddWithValue("@Estado", oPelicula.Estado);
                comando.Parameters.AddWithValue("@Imagen", oPelicula.Imagen.ToArray());
                comando.Parameters.AddWithValue("@Clasificacion", oPelicula.IdClasificacion);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarPelicula";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Pelicula SeleccionarPorId(int id)
        {
            

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPeliculaPorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pelicula oPelicula = new Pelicula();
                    oPelicula.Id = (int)dr["Id"];
                    oPelicula.Descripcion = dr["Descripcion"].ToString();
                    oPelicula.Sinopsis = dr["Sinopsis"].ToString();
                    oPelicula.Estado = (bool)dr["Estado"];
                    oPelicula.Imagen = (byte[])dr["Imagen"];
                    oPelicula.IdClasificacion = (int)dr["Clasificacion"];
                    oPelicula.Clasificacion = ClasificacionLN.SeleccionarClasificacionPorId(oPelicula.IdClasificacion);

                    return oPelicula;
                }
            }
            return null;
        }

        public static List<Pelicula> SeleccionarTodas()
        {
            byte[] ObtenerImagen = new byte[0];

            List<Pelicula> lista = new List<Pelicula>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarPeliculas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Pelicula oPelicula = new Pelicula();
                    oPelicula.Id = (int)dr["Id"];
                    oPelicula.Descripcion = dr["Descripcion"].ToString();
                    oPelicula.Sinopsis = dr["Sinopsis"].ToString();
                    oPelicula.Estado = (bool)dr["Estado"];
                    oPelicula.Imagen = (byte[])dr["Imagen"];
                    oPelicula.IdClasificacion = (int)dr["Clasificacion"];
                    oPelicula.Clasificacion = ClasificacionLN.SeleccionarClasificacionPorId(oPelicula.IdClasificacion);

                    lista.Add(oPelicula);
                }
            }
            return lista;
        }
    }
}
