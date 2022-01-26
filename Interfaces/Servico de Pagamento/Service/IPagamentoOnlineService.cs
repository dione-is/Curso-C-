using System;

namespace Servico_de_Pagamento.Service {
    interface IPagamentoOnlineService {

        double TaxaPagamento(double valor);

        double Interesse(double valor, int mes);
    }
}
