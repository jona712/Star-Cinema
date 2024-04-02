using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class SalaDB
    {
        public static Sala SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarSalaPorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Sala oSala = new Sala();
                    oSala.Id = (int)dr["Id"];
                    oSala.Descripcion = dr["Descripcion"].ToString();
                    oSala.IdCine = (int)dr["IdCine"];
                             
                    return oSala;
                }
            }
            return null;
        }

        public static List<Sala> SeleccionarTodas()
        {
       
            List<Sala> lista = new List<Sala>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarSalas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Sala oSala = new Sala();
                    oSala.Id = (int)dr["Id"];
                    oSala.Descripcion = dr["Descripcion"].ToString();
                    oSala.IdCine = (int)dr["IdCine"];
            
                   
                    lista.Add(oSala);
                }
            }
            return lista;
        }
    }
}
