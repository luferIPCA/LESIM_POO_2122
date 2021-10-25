/*
*	<copyright file="Aula5_Operadores.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/25/2021 3:06:57 PM</date>
*	<description>
*       Manipular Operadores
*       Reescrever Equals
*   </description>
**/

using System;

namespace Aula5_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro c1 = new Carro(2021, "00-00-00");
            Carro c2 = new Carro(2021, "00-00-00");

            //usa ToString
            Console.WriteLine(c1.ToString());
            //usa operador ==
            Console.WriteLine("C1 == C2: " + (c1 == c2).ToString());
            //Usa Equals
            Console.WriteLine("C1 Equals C2: " + (c1.Equals(c2)).ToString());

            Console.ReadKey();

        }
    }
}
