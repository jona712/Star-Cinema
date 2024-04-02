using AppCine.Layers.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class EntradaDB
    {
        public void Insertar(Entrada entrada)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarEntrada";
                //comando.Parameters.AddWithValue("@Id", entrada.Id); ;
                comando.Parameters.AddWithValue("@IdSala", entrada.IdSala);
                comando.Parameters.AddWithValue("@IdPelicula", entrada.IdPelicula);
                comando.Parameters.AddWithValue("@IdHorario", entrada.IdHorario);
                comando.Parameters.AddWithValue("@IdAsiento", entrada.IdAsiento);
                //comando.Parameters.AddWithValue("@Precio", entrada.Precio);              
                db.ExecuteNonQuery(comando);
            }
        }

        public static Entrada SeleccionarPorId(int id)
        {
          
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEntradaPorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Entrada oEntrada = new Entrada();
                    oEntrada.Id = (int)dr["Id"];
                    //oEntrada.IdSala = (int)dr["IdSala"];
                    //oEntrada.IdPelicula = (int)dr["IdPelicula"];
                    //oEntrada.IdHorario = (int)dr["IdHorario"];
                    //oEntrada.IdAsiento = (int)dr["IdAsiento"];
                    //oEntrada.Precio = (double)dr["Precion"];
                    return oEntrada;
                }
            }
            return null;
        }

        public static Entrada SeleccionarEntradaParaDetalle(int IdSala, int IdPelicula, int IdHorario,int IdAsiento)
        {

            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarEntradaParaDetalle";
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdPelicula", IdPelicula);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);
                comando.Parameters.AddWithValue("@IdAsiento", IdAsiento);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Entrada oEntrada = new Entrada();
                    oEntrada.Id = (int)dr["Id"];
                    //oEntrada.IdSala = (int)dr["IdSala"];
                    //oEntrada.IdPelicula = (int)dr["IdPelicula"];
                    //oEntrada.IdHorario = (int)dr["IdHorario"];
                    //oEntrada.IdAsiento = (int)dr["IdAsiento"];
                    //oEntrada.Precio = (double)dr["Precio"];
                    return oEntrada;
                }
            }
            return null;
        }
    }
}
