using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Pedido.Entity {
    class ItemPedido {

        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido() { 
        
        }

        public ItemPedido(int quantidade, double preco, Produto produto) { 
        
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal() {
            return Preco * Quantidade;
        }

        public override string ToString() {

            return Produto.Nome
                    + ", Preço: "
                    + Preco
                    + ", Quantidade: "
                    + Quantidade
                    + ", SubTotal: "
                    + SubTotal().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
