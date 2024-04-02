using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class FacturaDB
    {
        public void Insertar(Factura Factura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarFactura";
                comando.Parameters.AddWithValue("@Fecha", DateTime.Parse(Factura.Fecha.ToString("dd/MM/yyyy")));
                comando.Parameters.AddWithValue("@IdUsuario", Factura.IdUsuario);
                comando.Parameters.AddWithValue("@Total", Factura.Total);
             
                db.ExecuteNonQuery(comando);
            }
        }

        public static Factura SeleccionarFacturaParaDetalle()
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_SeleccionarFacturaParaDetalle";
               
                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Factura oFactura = new Factura();
                    oFactura.Id = (int)reader["Id"];
                
                    return oFactura;
                }
            }
            return null;
        }
    }
}
