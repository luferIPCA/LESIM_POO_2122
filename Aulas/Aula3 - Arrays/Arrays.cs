/*
*	<copyright file="Aula3.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 3:35:10 PM</date>
*	<description>
*	Arrays
*	</description>
**/
using System;

namespace Aula3
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/4/2021 3:35:10 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Arrays
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Arrays()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Mostra Array
        /// </summary>
        /// <param name="nomes"></param>
        public static void ShowArray(string[] nomes)
        {
            //for(int i=0; i < nomes.Length; i++)
            //{
            //    Console.WriteLine("Aluno:{0}", nomes[i]);
            //}

            foreach(string s in nomes)
            {
                Console.WriteLine("Aluno:{0}", s);
            }
        }

        /// <summary>
        /// Encontra o maior valor de um array
        /// </summary>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static double MaxValue(double[] valores)
        {
            double max = valores[0];
            for(int i=1; i<valores.Length;i++)
            {
                if (max < valores[i]) max = valores[i];
            }
            return max;
        }

        /// <summary>
        /// Verifica se se trata de uma matriz quadrada binária
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static bool MatrizDePermutacao(int[,] mat)
        {
            int totUm = 0;
            //total de "1" por linhas
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                totUm = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == 1) totUm++;
                    if (totUm > 1) return false;
                }
            }
            //total de "1" por colunas
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                totUm = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[j, i] == 1) totUm++;
                    if (totUm > 1) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Multiplica duas matrizes
        /// </summary>
        /// <param name="matA"></param>
        /// <param name="matB"></param>
        /// <returns></returns>
        public static int[,] MultiplicaMatrizes(int[,] matA, int[,] matB)
        {
            //Verificar se é possível multiplicar
            //matA(x,y) => matB(y,k)
            //matRes(x,k);
            if (matA.GetLength(1) != matB.GetLength(0)) return null;

            int[,] matRes = new int[matA.GetLength(0), matB.GetLength(1)];

            for (int linha=0; linha < matA.GetLength(0); linha++)
            {
                for (int coluna=0; coluna < matB.GetLength(1); coluna++)
                {
                    //matR[1,1] = matA[1,1]*matB[1,1]+matA[1,2]*matB[2,1]+matA[1,3]*matB[3,1]...matA[1,k]*matB[k,1]
                    //matR[i,j] = Somatorio(matA[linha,k]*matB[k,coluna]
                    int soma = 0;
                    for(int k=0; k<matA.GetLength(1); k++)//ou matB.GetLength(0)
                    { 
                        soma += matA[linha, k] * matB[k, coluna];
                    }
                    matRes[linha, coluna] = soma;
                }
            }
            return matRes;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Arrays()
        {
        }
        #endregion

        #endregion
    }
}
