/*
*	<copyright file="CalcDLL.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/2/2021 11:30:19 AM</date>
*	<description></description>
*	
*	public protected | internal   private
*	
**/
using System;

namespace CalcDLL
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/2/2021 11:30:19 AM
    /// 
    /// Operações de uma calculadora
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Calc
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calc()
        {
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods


        public static int Soma(int x, int y) { 
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calc()
        {
        }
        #endregion

        #endregion
    }

    internal class Auxiliar
    {
        const double PI = 3.14;
    }
}
