/*
*	<copyright file="Exercicio_11_10_2021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/11/2021 2:58:15 PM</date>
*	<description></description>
**/
using System;

namespace Exercicio_11_10_2021
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/11/2021 2:58:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Exercicio
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Exercicio()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Exercicio()
        {
        }
        #endregion

        #endregion

        #region ArraySimples

        public static bool Existe(int[] v, int valor) {
            //h1
            //int size = v.Length;
            //for (int i = 0; i < size; i++)
            //{
            //    if (v[i] == valor) return true;
            //}
            //return false;
            //h2
            foreach(int aux in v)
            {
                if (aux == valor) return true;
            }
            return false;

        }


        public static bool ExisteDoente(Doente[] hospital, string n)
        {
            foreach(Doente d in hospital)
            {
                if (d.nome.CompareTo(n) == 0) return true;
                //if (String.Compare(d.nome, n) == 0) return true;
                //if (d.nome == n) return true;
            }
            return false;
        }

        /// <summary>
        /// Completar : TPC
        /// </summary>
        /// <param name="v"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool RemoveElemento(int[] v, int valor)
        {
            return false;
        }

        #endregion

        #region ArrayMultidimensional

        /// <summary>
        /// Verifica se determinado valor existe num array bidimensional
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool ExisteMulti(int[,] valores, int v)
        {
            //Percorrer todas as linhas
            for(int lin=0; lin < valores.GetLength(0); lin++)
            {
                //Para cada linha, percorro todas as colunas
                for(int col=0; col<valores.GetLength(1);col++)
                {
                    if (valores[lin, col] == v) return true;
                }
            }
            return false;
        }



        #endregion

        #region ArrayJagged

        /// <summary>
        /// Verifica se determinado valore existe num jagged array
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool ExisteJagged(int[][] valores, int v)
        {
            //percorre todas as linhas do array
            for (int l = 0; l < valores.Length; l++)
            {
                //percorre todas as colunas de cada linha
                for (int c = 0; c < valores[l].Length; c++)
                {
                    if (valores[l][c] == v) return true;
                }
            }
            return false;
        }

        #endregion

    }

    #region Doentes
    public enum Estado { ALTA, UCI, INTERNADO };

    public struct Doente
    {
        public string nome;
        //estado
        public Estado estado;
        public int idade;
    }
    #endregion
}
