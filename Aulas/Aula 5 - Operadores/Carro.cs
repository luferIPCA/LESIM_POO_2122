/*
*	<copyright file="Aula5_Operadores.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/25/2021 3:06:57 PM</date>
*	<description>
*   Operadores
*   Equals
*   </description>
**/
using System;

namespace Aula5_Operadores
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/25/2021 3:06:57 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro
    {
        #region Attributes
        string matricula;
        int ano;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            matricula = "";
            ano = 2021;
        }

        public Carro(int ano, string matricula)
        {
            this.matricula = matricula;
            this.ano = ano;
        }

        #endregion

        #region Properties
        public string Matricula
        {
            get { return matricula; }
            set { if (value.Length > 0) matricula = value; }
        }


        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return "Matricula: " + matricula + " Ano: " + ano.ToString();
        }

        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            //Carro aux = obj as Carro;
            Carro aux = (Carro)obj;

            if (aux.Ano == this.Ano && aux.Matricula == this.Matricula)
                return true;
            return false;
        }
        #endregion

        #region OtherMethods

        #region Operadores

        public static bool operator ==(Carro a, Carro b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Carro a, Carro b)
        {
            return !(a==b);
        }

        #endregion


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
        }
        #endregion

        #endregion
    }
}
