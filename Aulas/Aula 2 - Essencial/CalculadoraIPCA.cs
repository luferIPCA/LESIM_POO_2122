/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>9/28/2021 11:33:10 AM</date>
*	<description>
*	Estruturação de código C#
*	    Múltiplas Classes:
*	        Class Main dedicada à interação com o utilizador
*	        Outras classes dedicadas às tarefas principais
*	    Input/Output de dados
*	    Métodos static
*	 </description>
**/
using System;

namespace Aula2
{
    /// <summary>
    /// Class que calcula uma Calculadora simples
    /// </summary>
    class CalculadoraIPCA
    {
        static void Main(string[] args)
        {

            string s;
            s = Console.ReadLine();
            double  a = double.Parse(s);

            //a = double.Parse(Console.ReadLine());

            bool aux = double.TryParse(Console.ReadLine(), out a);

            int x = int.Parse(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());
            
            x=Calculadora.Inc(x);

            Console.WriteLine("Valor lido {0}", x.ToString());

            #region Interpolação de Strings >= c#6.0
            string name = "Benfica";
            var date = (DateTime.Now).AddDays(-1);
            Console.WriteLine("Viva, o {0} perdeu ontem, {1}! são neste momento: {2:HH:mm}.", name, date.DayOfWeek, DateTime.Now);
            // String interpolation:
            Console.WriteLine($"Hello, {name}! Yesterday, {date.DayOfWeek}, we loose!  {date:HH:mm} now.");
            #endregion
        }
    }
}
