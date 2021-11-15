
//by lufer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8___Pilaress
{

    public enum Tipo { CASA,PREDIO}
    public class Imobiliario
    {
        int codImob;
        Tipo tipoIm;

        public Imobiliario()
        {

        }

        public Imobiliario(Tipo tp)
        {
            tipoIm = tp;
        }

        public Tipo TipoIm
        {
            get { return tipoIm; }        
            set { tipoIm = value;
            }
        }

        public override string ToString()
        {
            return "Tipo=" + this.tipoIm.ToString();
        }
    }

    




    public class TestaInterface
    {
        public static DateTime GetAnoContsPredio(Predio p)
        {
            return p.AnoConst();
        }

        public static DateTime GetAnoConts(IPredio p)
        {
            if (p is Predio)
            {
                return p.AnoConst().AddDays(3);
            }

            if (p is Bairro)
            {
                return p.AnoConst().AddMonths(3);
            }

            return DateTime.Today;
        }
    }
}
