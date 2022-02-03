using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaWeb.Services.Exceptions
{
    public class DbConcurrencyExceptions : ApplicationException
    {
        public DbConcurrencyExceptions(string mensagem) : base(mensagem)
        {

        }
    }
}
