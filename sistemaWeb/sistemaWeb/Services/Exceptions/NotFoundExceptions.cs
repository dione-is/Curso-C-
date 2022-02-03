using System;

namespace sistemaWeb.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string mensagem) : base (mensagem)
        {

        }
    }
}
