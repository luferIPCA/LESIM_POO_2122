/*
 * LP2
 * Excecoes
 * Lidar com novas exceções
 * lufer
 * */
using System;

namespace Exceptions_II
{
    public class EsseClubeNaoExisteHaDuvidasException : ApplicationException
        {
            public EsseClubeNaoExisteHaDuvidasException() : base("Isso é clube?") { }


            public EsseClubeNaoExisteHaDuvidasException(string s) : base(s) { }


            public EsseClubeNaoExisteHaDuvidasException(string s, Exception e)
            {
                throw new EsseClubeNaoExisteHaDuvidasException(e.Message + " - " + s);
            }
        }
}
