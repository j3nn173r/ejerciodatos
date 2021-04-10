using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombres.clases
{
    class clsarreglos
    {
        private int[] arreglotemporal;
        private int[] datos;
        private int i, j, datotemporales;
        private int tamanoarreglo = 0;

        public int Gettamanoarreglos()
        {
            return datos.Length;
        }
        public clsarreglos(int[] arreglosparametros)
        {
            datos = arreglosparametros;
            tamanoarreglo = datos.Length;

        }
        public int[] MetodoBurbuja()
        {
            arreglotemporal = datos;
            for (i = 0; i < tamanoarreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoarreglo; j++)
                {
                    if (arreglotemporal[i] > arreglotemporal[j])
                    {
                        datotemporales = arreglotemporal[i];
                        arreglotemporal[i] = arreglotemporal[j];
                        arreglotemporal[j] = datotemporales;
                    }
                }
            }

            return arreglotemporal;
        }
    }
}
