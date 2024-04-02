using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class ClasificacionDB
    {
        public static Clasificacion SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClasificacionPorId";
                comando.Parameters.AddWithValue("@Id", id);
          
                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Clasificacion clasificacion = new Clasificacion();
                    clasificacion.Id = (int)reader["Id"];
                    clasificacion.Descripcion = reader["Descripcion"].ToString();
                
                    return clasificacion;
                }
            }
            return null;
        }

        public static List<Clasificacion> SeleccionarTodas()
        {
            List<Clasificacion> lista = new List<Clasificacion>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarClasificaciones";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Clasificacion clasificacion = new Clasificacion();
                    clasificacion.Id = (int)dr["Id"];
                    clasificacion.Descripcion = dr["Descripcion"].ToString();

                    lista.Add(clasificacion);
                }
            }
            return lista;
        }
    }
}
