

namespace Declaracao_Imposto.Entity {
    class PessoaFisica : Contribuinte {

        public double GastoPlanoSaudo { get; set; }

        
        public PessoaFisica( string nome, double renda, double gastoPlano) : base (nome,renda) {
            GastoPlanoSaudo = gastoPlano;
        }

        public override double CalculoImposto() {
            
            if (Renda < 20000.00) {
                return (Renda * 0.15) - (GastoPlanoSaudo * 0.5);
            }else {
                return (Renda * 0.25) - (GastoPlanoSaudo * 0.5);
            }
        }
    }
}
