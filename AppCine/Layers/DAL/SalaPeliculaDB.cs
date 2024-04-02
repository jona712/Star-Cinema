using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class SalaPeliculaDB
    {
        public void Insertar(SalaPelicula oSalaPelicula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarSalaPelicula";
                comando.Parameters.AddWithValue("@IdPelicula", oSalaPelicula.IdPelicula);
                comando.Parameters.AddWithValue("@IdSala", oSalaPelicula.IdSala);
                comando.Parameters.AddWithValue("@IdHorario", oSalaPelicula.IdHorario);
 
                db.ExecuteNonQuery(comando);
            }
        }

        public void Actualizar(SalaPelicula oSalaPelicula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ActualizarSalaPelicula";
                comando.Parameters.AddWithValue("@IdPelicula", oSalaPelicula.IdPelicula);
                comando.Parameters.AddWithValue("@IdSala", oSalaPelicula.IdSala);
                comando.Parameters.AddWithValue("@IdHorario", oSalaPelicula.IdHorario);

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int IdPelicula, int IdSala, int IdHorario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminarSalaPelicula";
                comando.Parameters.AddWithValue("@IdPelicula", IdPelicula);
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);

                db.ExecuteNonQuery(comando);
            }
        }

        public static SalaPelicula SeleccionarPorId(int IdPelicula, int IdSala, int IdHorario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarSalaPeliculaPorId";
                comando.Parameters.AddWithValue("@IdPelicula", IdPelicula);
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);


                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SalaPelicula oSalaPelicula = new SalaPelicula();
                    oSalaPelicula.IdPelicula = (int)dr["IdPelicula"];
                    oSalaPelicula.IdSala = (int)dr["IdSala"];
                    oSalaPelicula.IdHorario = (int)dr["IdHorario"];
                    oSalaPelicula.Pelicula = PeliculaDB.SeleccionarPorId(IdPelicula);
                    oSalaPelicula.Sala = SalaDB.SeleccionarPorId(IdSala);
                    oSalaPelicula.Horario = HorarioDB.SeleccionarPorId(IdHorario);

                    return oSalaPelicula;
                }
            }
            return null;
        }

        public static SalaPelicula SeleccionarPorIdSala_IdHorario(int IdSala, int IdHorario)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarSalaPeliculaPorIdSala_IdHorario";
                comando.Parameters.AddWithValue("@IdSala", IdSala);
                comando.Parameters.AddWithValue("@IdHorario", IdHorario);


                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SalaPelicula oSalaPelicula = new SalaPelicula();
                    oSalaPelicula.IdPelicula = (int)dr["IdPelicula"];
                    oSalaPelicula.IdSala = (int)dr["IdSala"];
                    oSalaPelicula.IdHorario = (int)dr["IdHorario"];
                    oSalaPelicula.Pelicula = PeliculaDB.SeleccionarPorId(oSalaPelicula.IdPelicula);
                    oSalaPelicula.Sala = SalaDB.SeleccionarPorId(IdSala);
                    oSalaPelicula.Horario = HorarioDB.SeleccionarPorId(IdHorario);

                    return oSalaPelicula;
                }
            }
            return null;
        }

        public static List<SalaPelicula> SeleccionarTodas()
        {
           
            List<SalaPelicula> lista = new List<SalaPelicula>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarSalasPeliculas";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SalaPelicula oSalaPelicula = new SalaPelicula();
                    oSalaPelicula.IdPelicula = (int)dr["IdPelicula"];
                    oSalaPelicula.IdSala = (int)dr["IdSala"];
                    oSalaPelicula.IdHorario = (int)dr["IdHorario"];
                    oSalaPelicula.Pelicula = PeliculaDB.SeleccionarPorId(oSalaPelicula.IdPelicula);
                    oSalaPelicula.Sala = SalaDB.SeleccionarPorId(oSalaPelicula.IdSala);
                    oSalaPelicula.Horario = HorarioDB.SeleccionarPorId(oSalaPelicula.IdHorario);

                    lista.Add(oSalaPelicula);
                }
            }
            return lista;
        }

        public static List<SalaPelicula> SeleccionarTodasParaCartelera()
        {

            List<SalaPelicula> lista = new List<SalaPelicula>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                string sql = @"Select Distinct IdPelicula from SALAPELICULA";

                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SalaPelicula oSalaPelicula = new SalaPelicula();
                    oSalaPelicula.IdPelicula = (int)dr["IdPelicula"];
                    //oSalaPelicula.IdSala = (int)dr["IdSala"];
                    //oSalaPelicula.IdHorario = (int)dr["IdHorario"];
                    oSalaPelicula.Pelicula = PeliculaDB.SeleccionarPorId(oSalaPelicula.IdPelicula);
                    //oSalaPelicula.Sala = SalaDB.SeleccionarPorId(oSalaPelicula.IdSala);
                    //oSalaPelicula.Horario = HorarioDB.SeleccionarPorId(oSalaPelicula.IdHorario);

                    lista.Add(oSalaPelicula);
                }
            }
            return lista;
        }
    }
}
