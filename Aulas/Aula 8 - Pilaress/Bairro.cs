/*
*	<copyright file="Aula_8___Pilaress.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 3:42:54 PM</date>
*	<description></description>
**/
using System;

namespace Aula_8___Pilaress
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 3:42:54 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bairro : ImobilarioAbs, IPredio
    {
        public DateTime Dados { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime AnoConst()
        {
            throw new NotImplementedException();
        }

        public override Tipo CodIm()
        {
            return this.TipoIm;
        }

        public string GetMorada()
        {
            throw new NotImplementedException();
        }
    }
}
