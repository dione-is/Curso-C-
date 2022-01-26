using System;
using Servico_de_Pagamento.Entity;

namespace Servico_de_Pagamento.Service {
    class ContratoService {

        private IPagamentoOnlineService onlineService;

        public ContratoService(IPagamentoOnlineService onlineService) {
            this.onlineService = onlineService;
        }

        public void ProcessarContrato(Contrato contrato, int mes) {
            
            double parcela =  contrato.ValorTotal/ mes;
            for (int i = 1; i <= mes; i++) {
                
                DateTime data = contrato.Data.AddMonths(i);
                double atualizarParcela = parcela + onlineService.Interesse(parcela,i);
                double parcelaTotal = atualizarParcela + onlineService.TaxaPagamento(atualizarParcela);
                contrato.AdicionarParcelas(new Parcela(data, parcelaTotal));
            }
        }
    }
}
