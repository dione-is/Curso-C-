using System;
using System.Globalization;

namespace Locacao.Entity {
    class Fatura {
        public double Pagamento { get; set; }
        public double Taxa { get; set; }

        public Fatura(double pagamento, double taxa) { 
            
            Pagamento = pagamento;
            Taxa = taxa;
        }

        public double TotalPagamento {
            get { return Pagamento + Taxa; }
        }

        public override string ToString() {

            return "Pagamento Basixo: "
                    + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nTaxa: "
                    + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                    + "\nTotal Pagamento: "
                    + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }

       
    }
}
