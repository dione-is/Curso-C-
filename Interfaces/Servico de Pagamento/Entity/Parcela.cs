using System;
using System.Globalization;

namespace Servico_de_Pagamento.Entity {
    class Parcela {
        public DateTime DataVencimento { get; private set; }
        public double Valor { get; private set; }

        public Parcela(DateTime dataVencimento, double valor) {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string ToString() {

            return "Data Vencimento: "
                    + DataVencimento.ToString("dd/MM/yyyy")
                    + " - Valores: "
                    + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
