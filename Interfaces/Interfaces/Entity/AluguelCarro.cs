using System;

namespace Locacao.Entity {
    class AluguelCarro {
        public DateTime Alugado { get; set; }
        public DateTime Devolvido { get; set; }
        public Carro carro { get; private set; }
        public Fatura fatura { get; set; }

        public AluguelCarro(DateTime alugado, DateTime devolvido, Carro carro) {
            Alugado = alugado;
            Devolvido = devolvido;
            this.carro = carro;
        }
    }
}
