using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTC.RH.Dominio.Exception
{
    public class SalvarFuncionarioException : System.Exception
    {
        public SalvarFuncionarioException(string mensagem) : base (mensagem)
        { }
    }
}
