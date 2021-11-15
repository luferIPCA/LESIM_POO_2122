/*
*	<copyright file="Aula_8___Pilaress.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 3:11:40 PM</date>
*	<description></description>
**/
using System;

namespace Aula_8___Pilaress
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 3:11:40 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class ImobilarioAbs : Imobiliario
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ImobilarioAbs()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public abstract Tipo CodIm();
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ImobilarioAbs()
        {
        }
        #endregion

        #endregion
    }
}
