/*
*	<copyright file="Aula3.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 3:17:54 PM</date>
*	<description>
*	Parametros ref, out, valor
*	Arrays simples!
*	</description>
**/

using System;

namespace Aula3
{
    class Program
    {
        #region Enums
        enum Notas { Passou = 10, Reprovou = 9 };
        public enum WeekDays
        {
            Monday,     //0
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday      //6
        }
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

        #endregion

        public int GetEnum(WeekDays w)
        {

            if (w == WeekDays.Friday) return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            #region Parametros

            int x = 8, y = 12;
            x = Parametros.Soma(x, y);

            //ref
            x = Parametros.SomaII(x, ref y);


            //out
            double prod;   //fica com o resultado produto
            int soma;   //fica com o resultado soma

            soma = Parametros.SomaProduto(x, y, out prod);

            #endregion

            #region Arrays Simples
            //h1
            const int N = 20;
            int[] valores = new int[N];
            valores[0] = 12;
            valores[3] = valores[0] * 2;

            //h2

            string[] alunos = { "Ana", "João", "Pedro" };

            //h3

            double[] notas = new double[] { 12.3, 17, 18, 10 };

            //mostrar alunos com ciclo for
            for(int i=0; i < alunos.Length; i++)
            {
                //Console.WriteLine($"Aluno:{alunos[i]}"); //C#6.0
                Console.WriteLine("Aluno: {0}", alunos[i]);
            }

            //mostrar alunos com ciclo foreach
            foreach(string s in alunos)
            {
                Console.WriteLine("Aluno: {0}", s);
            }

            Arrays.ShowArray(alunos);

            double max = Arrays.MaxValue(notas);

            Carro[] garagem = new Carro[10];
            garagem[0] = new Carro() { ano = DateTime.Now, marca = "", matricula = "" };
            Console.ReadKey();
            #endregion

            #region Matrizes

            int[,] matA = { { 1, 4 }, { 2, 5 }, { 3, 6 } };
            int[,] matB = { { 1, 2,3 }, { 4,5,6 } };
            int[,] matRes = Arrays.MultiplicaMatrizes(matA, matB);

            #endregion

        }
    }
}
