using System;
using System.Globalization;

namespace Desafio_Calculo_Pagamentos.Entity {
    class ContratoHoras {

        public DateTime Date { get;  set; }
        public double ValorPorHora { get; set; }
        public int Horas { get;  set; }

        public ContratoHoras()
        {

        }

        public ContratoHoras (DateTime date, double valorPorHora, int horas) {
            
            Date = date;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public double TotalValor()
        {
            return ValorPorHora * Horas;
        }
    }
}
