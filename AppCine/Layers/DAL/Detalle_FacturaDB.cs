using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Detalle_FacturaDB
    {
        public void Insertar(Detalle_Factura detalle_Factura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_InsertarDetalle_Factura";
                comando.Parameters.AddWithValue("@IdFactura", detalle_Factura.IdFactura);
                comando.Parameters.AddWithValue("@IdEntrada", detalle_Factura.IdEntrada);
                comando.Parameters.AddWithValue("@Cantidad", detalle_Factura.Cantidad);
                comando.Parameters.AddWithValue("@Precio", detalle_Factura.Precio);
                comando.Parameters.AddWithValue("@Subtotal", detalle_Factura.Subtotal);
                comando.Parameters.AddWithValue("@Impuesto", detalle_Factura.Impuesto);

                db.ExecuteNonQuery(comando);
            }
        }
    }
}
