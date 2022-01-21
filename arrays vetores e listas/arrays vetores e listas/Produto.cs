using System;
using System.Globalization;

namespace arrays_vetores_e_listas {
    class Produto {

        public string nome { get; set; }
        public double preco { get; set; }

        public Produto(string nome, double preco) {
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString() {

            return "descricao: "
                    + nome
                    + " preço: "
                    + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
