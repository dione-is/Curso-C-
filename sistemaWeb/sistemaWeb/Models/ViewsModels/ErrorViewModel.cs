using System;

namespace sistemaWeb.Models.ViewsModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Mensagem { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}