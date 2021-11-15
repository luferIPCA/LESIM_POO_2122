using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8___Pilaress
{
    class Program
    {
        static void Main(string[] args)
        {
            Imobiliario i1 = new Imobiliario();
            i1.TipoIm = Tipo.CASA;

            Console.WriteLine(i1.ToString());

            Predio p = new Predio(Tipo.PREDIO, DateTime.Now);

            Bairro b = new Bairro();
            b.TipoIm = Tipo.CASA;


            TestaInterface t = new TestaInterface();

            TestaInterface.GetAnoContsPredio(p);
            TestaInterface.GetAnoConts(p);
            TestaInterface.GetAnoConts(b);


            Console.ReadKey();
        }
    }
}
