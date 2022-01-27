using System;
using System.Globalization;
using Servico_Calcular;

namespace Servico_Calcular.Entity {
    class Produto : IComparable{
        public string Nome { get; set; }
        public double Preco { get; set; }
       
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        
        public override string ToString() {

            return Nome
                    + ", "
                    + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            
            if (!(obj is Produto)) {
                throw new ArgumentException("Tipos de objetos diferente");
            }

            Produto novo = obj as Produto;

            return Preco.CompareTo(novo.Preco);
        }
    }
}
