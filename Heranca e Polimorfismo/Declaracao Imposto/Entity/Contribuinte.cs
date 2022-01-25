using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaracao_Imposto.Entity {
    abstract class Contribuinte {

        public string Nome { get; set; }
        public double Renda { get; set; }

        protected Contribuinte(string nome, double renda) {
            Nome = nome;
            Renda = renda;
        }

        public abstract double CalculoImposto();

    }
}
