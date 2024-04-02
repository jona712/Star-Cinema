using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class TipoUsuarioDB
    {
        public static List<TipoUsuario> SeleccionarTodosNormales()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoUsuariosNormales";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoUsuario oTipo = new TipoUsuario();
                    oTipo.Id = (int)dr["Id"];
                    oTipo.Descripcion = dr["Descripcion"].ToString();

                    lista.Add(oTipo);
                }
            }
            return lista;
        }
       
        public static List<TipoUsuario> SeleccionarTodosAdmin()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoUsuarios";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoUsuario oTipo = new TipoUsuario();
                    oTipo.Id = (int)dr["Id"];
                    oTipo.Descripcion = dr["Descripcion"].ToString();

                    lista.Add(oTipo);
                }
            }
            return lista;
        }

        public static TipoUsuario SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarTipoUsuarioPorId";
                comando.Parameters.AddWithValue("@id", id);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoUsuario oTipo = new TipoUsuario();
                    oTipo.Id = (int)dr["Id"];
                    oTipo.Descripcion = dr["Descripcion"].ToString();
                    return oTipo;
                }
            }
            return null;
        }
    }
}
