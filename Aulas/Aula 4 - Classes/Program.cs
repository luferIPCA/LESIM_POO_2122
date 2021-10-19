/*
*	<copyright file="Exercicio_11_10_2021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/18/2021 2:48:52 PM</date>
*	<description>
*	Classese Objetos
*	</description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A_LA_JAVA
            //Pessoa p = new Pessoa();
            //p.SetIdade(12);
            //Console.WriteLine("Idade: " + p.GetIdade().ToString());

            //Pessoa q = new Pessoa();
            //q.SetIdade(14);
            #endregion

            Pessoa p = new Pessoa();    //cria objeto
            Console.WriteLine($"Nome: {p.Nome} - Idade: {p.Idade}");

            p.Idade = 23;               //set Idade
            p.Nome = "lufer";           //set Nome
            Console.WriteLine("Nome:" + p.Nome + " Idade: "+p.Idade);    //get

            Pessoa r = new Pessoa("João", 12);
            Console.WriteLine($"Nome: {r.Nome} - Idade: {r.Idade}");

            //bool aux = r.ExistePremio(230);

            Console.WriteLine("Tot: " + Pessoa.TotObjetos.ToString());

            Console.ReadKey();
        }
    }
}
