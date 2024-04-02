using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class CineDB
    {
        public void Insertar(Cine oCine)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarCine";
                comando.Parameters.AddWithValue("@Id", oCine.Id);
                comando.Parameters.AddWithValue("@Descripcion", oCine.Descripcion);
                comando.Parameters.AddWithValue("@Provincia", oCine.Provincia);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Cine oCine)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarCine";
                comando.Parameters.AddWithValue("@Id", oCine.Id);
                comando.Parameters.AddWithValue("@Descripcion", oCine.Descripcion);
                comando.Parameters.AddWithValue("@Provincia", oCine.Provincia);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarCine";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Cine SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCinePorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cine oCine = new Cine();
                    oCine.Id = (int)dr["Id"];
                    oCine.Descripcion = dr["Descripcion"].ToString();
                    oCine.Provincia = dr["Provincia"].ToString();
                  
                    return oCine;
                }
            }
            return null;
        }


        public static List<Cine> SeleccionarTodas()
        {
           
            List<Cine> lista = new List<Cine>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarCines";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cine oCine = new Cine();
                    oCine.Id = (int)dr["Id"];
                    oCine.Descripcion = dr["Descripcion"].ToString();
                    oCine.Provincia = dr["Provincia"].ToString();
                  
                    lista.Add(oCine);
                }
            }
            return lista;
        }
    }
}
