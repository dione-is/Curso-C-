using System;
using Enumeracoes_E_Composicoes.Entity.Enums;

namespace Enumeracoes_E_Composicoes.Entity {
    class Order {
        public long id { get; set; }
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public override string ToString() {

            return "Pedido: "
                    + id
                    + " Data: "
                    + moment.ToString("D")
                    + " Status: "
                    + status;
        
        }


    }
}
