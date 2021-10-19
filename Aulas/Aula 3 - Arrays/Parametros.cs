/*
*	<copyright file="Aula3.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 3:17:54 PM</date>
*	<description>
*	Parametros ref, out, valor
*	Arrays
*	</description>
**/
using System;

namespace Aula3
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/4/2021 3:17:54 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Parametros
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Parametros()
        {
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Calcula a soma de dois valores inteiros
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Soma(int a, int b)
        {
            b++;
            return a + b;
        }

        /// <summary>
        /// Calcula a Soma "estranha" de dois valores inteiros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b">Valor sai alterado?</param>
        /// <returns></returns>
        public static int SomaII(int a, ref int b)
        {
            b++;
            return (a + b);
        }

        /// <summary>
        /// Calcula a soma e o produto de dois valores inteiros
        /// </summary>
        /// <param name="a">Valor1</param>
        /// <param name="b">Valor2</param>
        /// <param name="c">Produto</param>
        /// <returns>Soma</returns>
        public static int SomaProduto(int a, int b, out double c)
        {
            c = a*b;
            return (a + b);
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Parametros()
        {
        }
        #endregion

        #endregion
    }
}
