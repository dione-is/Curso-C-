using System;

namespace Servico_de_Pagamento.Service {
    class PaypayService : IPagamentoOnlineService {

        private const double TaxaPagar = 0.02;
        private const double JurosMensais = 0.01;

        public double TaxaPagamento(double valor) {

            return  valor * TaxaPagar;
        }

        public double Interesse(double valor, int mes) {

           
            return valor * JurosMensais * mes;
        }
    }
}
