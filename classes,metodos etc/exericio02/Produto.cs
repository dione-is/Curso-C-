using System.Globalization;

namespace exercicio02;
     class Produto {

        public string nome;
        public double preco;
        public int quantidade;

        public void AdicionarEstoque( int quantidade) {
            this.quantidade += quantidade;
        }

        public void RemoverEstoque( int quantidade) {
              this.quantidade -= quantidade;
        }

        public void DadosEstoque() {

        Console.WriteLine("dados atualizados: " + nome + ", Preço: "
            + preco.ToString("F2", CultureInfo.InvariantCulture) + ", QTD: " + quantidade
            + " valor total estoque: R$" + (preco * quantidade).ToString("F2", CultureInfo.InvariantCulture));
    }
    }

