using Excessao_Personalizada.Entity.Exception;

namespace Excessao_Personalizada.Entity {
    class Reservas {

        public int NumeroQuarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reservas() {
        
        }

        public Reservas(int numeroQuarto, DateTime entrada, DateTime saida) {

            if (saida <= entrada) {
                throw new DomainException("data de saida menor ou igual a data de entrada");
            }

            NumeroQuarto = numeroQuarto;
            Entrada = entrada;
            Saida = saida;
        }

        public void AtualizarReserva(DateTime entrada, DateTime saida) {

            DateTime hoje = DateTime.Now;
            if (entrada < hoje || saida < hoje ) {
                throw new DomainException(" data de entrada ou saida menor que a data atual");
            }
            if (saida <= entrada) {
                throw new DomainException("data de saida menor ou igual a data de entrada");
            }

            Entrada = entrada;
            Saida = saida;

        }

        public int DuracaoReserva() {

            TimeSpan duracao = Saida.Subtract(Entrada);
            return (int) duracao.TotalDays;
        }

        public override string ToString() {

            return "Quarto "
                    + NumeroQuarto
                    + ", Entrada: "
                    + Entrada.ToString("dd/MM/yyyy")
                    + ", saida: "
                    + Saida.ToString("dd/MM/yyyy")
                    + ", Quantidade de dias: "
                    + DuracaoReserva().ToString();
        }
    }
}
