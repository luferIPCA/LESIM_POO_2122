/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>9/28/2021 11:33:10 AM</date>
*	<description>
*	</description>
**/
using System;

namespace Aula2
{
    /// <summary>
    /// Purpose: Suportar métodos de uma calculadora
    /// Created by: lufer
    /// Created on: 9/28/2021 11:33:10 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Calculadora
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calculadora()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Calcula a Soma de dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Incrementa o valor numa unidade....
        /// </summary>
        /// <param name="k">Valor a incrementar</param>
        /// <returns></returns>
        public static int Inc(int k)
        {
            if (k<9) k++;   //regra de negócio
            return k;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calculadora()
        {
        }
        #endregion

        #endregion
    }
}
