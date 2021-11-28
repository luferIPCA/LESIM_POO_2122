
//by lufer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varios
{
    class Valores
    {

        string numUtente;

        public string NumUtente
        {
            get { return numUtente; }
            set { if (NumberValid(value)) numUtente = value; else throw new ValoresInvalidosException(); }
        }



        public bool NumberValid(string v)
        {
            //testar
            return true;
        }

    }
}
