using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varios
{
    class Program
    {
        static void Main(string[] args)
        {
            int v=-1;
            try
            {
                v=LeValores();
                Console.WriteLine("Valor lido:" + v.ToString());
            }
            catch (ValoresInvalidosException e)
            {
                Console.WriteLine("ERRO:" + e.Message);
            }
            catch (Exception p)
            {
                Console.WriteLine("ERRO:" + p.Message);
            }


            Valores val = new Valores();
            try
            {
                val.NumUtente = "1o";
                if (val.NumberValid("123456789")){
                    //alerta
                    //corrigir
                    //
                }
                

            }
            catch (ValoresInvalidosException e)
            {

            }
            catch(Exception e)
            {

            }

        }

        public static int LeValores()
        {
            Console.Write("Valor:");
            string v = Console.ReadLine();
            try
            {
                return( int.Parse(v));
            }
            catch(Exception e)
            {
                throw new ValoresInvalidosException();
            }
        }
    }
}
