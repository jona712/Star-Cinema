using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class FacturaLN
    {


        public List<Detalle_Factura> detalle_Facturas = new List<Detalle_Factura>();

        /// <summary>
        /// guarda una factura
        /// </summary>
        /// <param name="factura"></param>
        public void Guardar(Factura factura)
        {
            FacturaDB datos = new FacturaDB();
            datos.Insertar(factura);
        }

        /// <summary>
        /// selecciona una factura para cada detalle
        /// </summary>
        /// <returns></returns>
        public Factura SeleccionarFacturaParaDetalle()
        {
            return FacturaDB.SeleccionarFacturaParaDetalle();
        }
    }
}
