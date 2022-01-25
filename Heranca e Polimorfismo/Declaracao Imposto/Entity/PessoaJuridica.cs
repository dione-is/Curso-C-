using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaracao_Imposto.Entity {
    class PessoaJuridica : Contribuinte{

        public int QtdFuncionario { get; set; }

        public PessoaJuridica( string nome, double renda, int qtdFuncionario) : base(nome, renda) {
            QtdFuncionario = qtdFuncionario;
        }

        public override double CalculoImposto() {
            if (QtdFuncionario > 10) {
                return Renda * 0.14;
            }
            else {
                return Renda * 0.16;
            }
        }
    }
}
