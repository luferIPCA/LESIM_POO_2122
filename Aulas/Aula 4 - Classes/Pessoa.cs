/*
*	<copyright file="Exercicio_11_10_2021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/18/2021 2:48:52 PM</date>
*	<description>
*	Classese Objetos
*	</description>
**/
using System;

namespace Aula4_Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/18/2021 2:48:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        const int N = 10;
        string nome;
        int idade;

        public static int totObjetos = 0;   //atributo de classe

        int[] premios;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor
        /// </summary>
        public Pessoa()
        {
            idade = 20;
            nome = "";
            premios = new int[N];
            totObjetos++;
        }

        /// <summary>
        /// Define valores dos atributos
        /// </summary>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        public Pessoa(int idade, string nome)
        {
            this.nome = nome;
            this.idade = idade;
            totObjetos++;
        }

        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
            totObjetos++;
        }
        public Pessoa(int idade, string nome,int totPremios)
        {
            this.nome = nome;
            this.idade = idade;
            premios = new int[totPremios];
            totObjetos++; 
        }

        //ou
        //public Pessoa(int _idade, string _nome)
        //{
        //    nome = _nome;
        //    idade = _idade;
        //}

        #endregion

        #region Properties

        /// <summary>
        /// Property Nome
        /// </summary>
        public string Nome
        {
            get
            {
                return nome;            //.ToUpper();
            }
            set
            {
                if (value.Length > 0)     //Qualquer regra
                    nome = value;
            }
        }

        /// <summary>
        /// Property Idade
        /// </summary>
        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                if(value>0)
                    idade = value;
            }
        }

        /// <summary>
        /// Property de classe
        /// </summary>
        public static int TotObjetos
        {
            get { return totObjetos; }
        }
        #endregion
        
        #region Overrides
        #endregion

        #region OtherMethods

        #region A_LA_JAVA
        public bool SetIdade(int x)
        {
            idade = x;
            return true;
        }

        public int GetIdade()
        {
            return idade;
        }

    #endregion

        /// <summary>
        /// Procura elemento no array dos atributos
        /// </summary>
        /// <param name="valor">Valor a procurar</param>
        /// <returns>Encontrou ou não</returns>
        public bool ExistePremio(int valor)
        {
            foreach(int v in premios)
            {
                if (v == valor) return true;
            }
            return false;

        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
            totObjetos--;
        }
        #endregion

        #endregion
    }
}
