using System;

namespace Locacao.Service {
    class BrazilTaxaService : ITaxaService {

        public double Tax(double valor) {

            if (valor <= 100.00) {

                return valor * 0.20;
            }
            else {
                return valor * 0.15;
            }

        }
    }
}
