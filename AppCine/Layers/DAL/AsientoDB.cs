
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class AsientoDB
    {
        public void Insertar(Asiento oAsiento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarAsiento";
                comando.Parameters.AddWithValue("@Id", oAsiento.Id);;
                comando.Parameters.AddWithValue("@IdSala", oAsiento.IdSala);
                comando.Parameters.AddWithValue("@IdHorario", oAsiento.IdHorario);
                comando.Parameters.AddWithValue("@Descripcion", oAsiento.Descripcion);
                comando.Parameters.AddWithValue("@Estado", oAsiento.Estado);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(Asiento oAsiento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarAsiento";
                comando.Parameters.AddWithValue("@Id", oAsiento.Id);
                comando.Parameters.AddWithValue("@IdSala", oAsiento.IdSala);
                comando.Parameters.AddWithValue("@IdHorario", oAsiento.IdHorario);
                comando.Parameters.AddWithValue("@Estado", oAsiento.Estado);

                db.ExecuteNonQuery(comando);
            }
        }

        public void ActualizarSinSalaPelicula(int IdSala, int IdHorario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarAsientosSinSalaPelicula";            
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);
                db.ExecuteNonQuery(comando);
            }
        }


        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarAsiento";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        public static Asiento SeleccionarPorId(int id, int IdSala, int IdHorario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarAsientoPorId";
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Asiento oAsiento = new Asiento();
                    oAsiento.Id = (int)reader["Id"];
                    oAsiento.IdSala = (int)reader["IdSala"];
                    oAsiento.IdHorario = (int)reader["IdHorario"];
                    oAsiento.Descripcion = reader["Descripcion"].ToString();
                    oAsiento.Estado = (bool)reader["Estado"];

                    return oAsiento;
                }
            }
            return null;
        }

        public static List<Asiento> SeleccionarTodas(int IdSala, int IdHorario)
        {
            List<Asiento> lista = new List<Asiento>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarAsientos";
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    
                    Asiento oAsiento = new Asiento();
                    oAsiento.Id = (int)dr["Id"];
                    oAsiento.IdSala = (int)dr["IdSala"];
                    oAsiento.IdHorario = (int)dr["IdHorario"];
                    oAsiento.Descripcion = dr["Descripcion"].ToString();
                    oAsiento.Estado = (bool)dr["Estado"];

                    lista.Add(oAsiento);
                }
            }
            return lista;
        }    
    }
}
