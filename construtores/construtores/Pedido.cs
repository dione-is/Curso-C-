using System;
using System.Globalization;

namespace pedidos {
    class Pedido {

        private long _id { get; set; }
        private string _nome { get; set; }
        public double preco { get; private set; }
       

        public Pedido() {
        }

        public Pedido(long id, string nome, double preco) {
            
            this._id = id;
            this._nome = nome;
            this.preco = preco;
        }

        public void aplicarCUpomDesconto() {
            this.preco -= 10.0;
        }

        public override string ToString() {
            return "Pedido "
                + _id
                + ", Descrição: "
                + _nome
                + ", Valor: $ "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
