/*
*	<copyright file="Aula_8___Pilaress.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 3:26:11 PM</date>
*	<description></description>
**/
using System;

namespace Aula_8___Pilaress
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 3:26:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Predio : Imobiliario, IPredio
    {
        int codPredio;
        string morada;
        DateTime dataConts;

        public Predio()
        {
            base.TipoIm = Tipo.PREDIO;

            dataConts = DateTime.Today;
        }

        public Predio(Tipo tp, DateTime cons)
        {
            base.TipoIm = tp;
            this.dataConts = cons;
        }

        //ou
        public Predio(DateTime cons, Tipo tp) : base(tp)
        {
            dataConts = cons;
        }

        public DateTime Dados
        {
            get { return dataConts; }
            set { dataConts = value; }
        }

        public DateTime AnoConst()
        {
            return dataConts;
        }

        public string GetMorada()
        {
            return "";
        }
    }
}
