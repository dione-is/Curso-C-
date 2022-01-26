using System;
using Locacao.Entity;

namespace Locacao.Service {
    class AluguelService {

        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }

        private ITaxaService _taxaService;

        public AluguelService(double precoHora, double precoDia, ITaxaService taxaService) {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _taxaService = taxaService;
        }

        public void ProcessarFatura(AluguelCarro aluguelCarro) {

            TimeSpan prazo = aluguelCarro.Devolvido.Subtract(aluguelCarro.Alugado);
            
            double pagamento = 0.0;
            if (prazo.TotalHours <= 12.0) {
                pagamento = PrecoHora * Math.Ceiling(prazo.TotalHours);   
            }else {
                pagamento = PrecoDia * Math.Ceiling(prazo.TotalDays);
            }

            double taxa = _taxaService.Tax(pagamento);
            aluguelCarro.fatura = new Fatura(pagamento, taxa);

        }
    }
}
