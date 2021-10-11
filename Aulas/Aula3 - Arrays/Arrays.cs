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
