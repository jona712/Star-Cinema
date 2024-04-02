using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class HorarioDB
    {
        public static Horario SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarHorarioPorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Horario oHorario = new Horario();
                    oHorario.Id = (int)dr["Id"];
                    oHorario.FechaYHora = (TimeSpan)dr["FechaYHora"];
                    oHorario.Estado = (bool)dr["Estado"];


                    return oHorario;
                }
            }
            return null;
        }

        public static List<Horario> SeleccionarTodas()
        {

            List<Horario> lista = new List<Horario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarHorarios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Horario oHorario = new Horario();
                    oHorario.Id = (int)dr["Id"];
                    oHorario.FechaYHora = (TimeSpan)dr["FechaYHora"];
                    oHorario.Estado = (bool)dr["Estado"];

                    lista.Add(oHorario);
                }
            }
            return lista;
        }
    }
}
