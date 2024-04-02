using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCine
{
    public class Detalle_FacturaLN
    {
        public List<Entrada> ListaEntradas = null;

        public Pelicula oPelicula = null;

        public Usuario oUsuario = null;

        private double IVA = 0.13;

        private double DESCUENTO_1 = 0.05, DESCUENTO_2 = 0.08, DESCUENTO_3 = 0.11, DESCUENTO_4 = 0.15, DESCUENTO_5 = 0.20;


        /// <summary>
        /// Guardar el datalle factura
        /// </summary>
        /// <param name="Detalle_Factura"></param>
        public void Guardar(Detalle_Factura Detalle_Factura)
        {
            Detalle_FacturaDB datos = new Detalle_FacturaDB();
            datos.Insertar(Detalle_Factura);
        }

       
        /// <summary>
        /// Retorna la cantidad de entradas
        /// </summary>
        /// <returns></returns>
        public int Cantidad()
        {
            return ListaEntradas.Count;
        }

        /// <summary>
        /// Retorna el subtotal de cada linea
        /// </summary>
        /// <returns></returns>
        public double Subtotal()
        {
            return ListaEntradas.Sum(E => E.Precio);
        }

        /// <summary>
        /// retorna el descuento segun el tipo usuario
        /// </summary>
        /// <returns></returns>

        public double Descuento()
        {
            int cantEntradas = ListaEntradas.Count;
            double descuento = 0;

            if (oUsuario.Tipo == 1)
            {
                descuento = 0;
            }
            else
            {
                if (cantEntradas <= 2)
                {
                    descuento = Subtotal() * DESCUENTO_1;
                }
                else
                {
                    if (cantEntradas > 2 && cantEntradas <= 4)
                    {
                        descuento = Subtotal() * DESCUENTO_2;
                    }
                    else
                    {
                        if (cantEntradas > 4 && cantEntradas <= 6)
                        {
                            descuento = Subtotal() * DESCUENTO_3;
                        }
                        else
                        {
                            if (cantEntradas > 6 && cantEntradas <= 8)
                            {
                                descuento = Subtotal() * DESCUENTO_4;
                            }
                            else
                            {
                                if (cantEntradas > 8)
                                {
                                    descuento = Subtotal() * DESCUENTO_5;
                                }
                            }
                        }
                    }
                }
            }
            return descuento;
        }

        /// <summary>
        /// Retorna el impuesto
        /// </summary>
        /// <returns></returns>
        public double Impuesto()
        {
            return Subtotal() * IVA;
        }

        /// <summary>
        /// Retorna el total
        /// </summary>
        /// <returns></returns>

        public double Total()
        {
            return Subtotal() + Impuesto() - Descuento();
        }
    }
}
