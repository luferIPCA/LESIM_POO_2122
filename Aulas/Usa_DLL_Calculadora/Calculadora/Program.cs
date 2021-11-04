/*
 * Utilização de DLLs
 * POO - LEIM
 * lufer
 * */

using CalcDLL;  //utiliza DLL externa
using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Calc.Soma(2, 3);
            Console.WriteLine("Soma=" + a.ToString());

            Console.ReadKey();

        }
    }
}
