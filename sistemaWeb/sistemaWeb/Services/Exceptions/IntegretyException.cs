using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaWeb.Services.Exceptions
{
    public class IntegretyException : ApplicationException
    {
        public IntegretyException(string mensagem) : base(mensagem)
        {

        }
    }
}
