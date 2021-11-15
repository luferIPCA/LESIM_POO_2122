using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8___Pilaress
{
    public interface IPredio
    {
        string GetMorada();
        DateTime AnoConst();

        DateTime Dados
        {
            get; set;
        }
    }
}
