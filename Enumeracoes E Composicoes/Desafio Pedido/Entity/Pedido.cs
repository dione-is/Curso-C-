using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using Desafio_Pedido.Entity.Enums;

namespace Desafio_Pedido.Entity {         
    class Pedido {

        public DateTime DataPedido { get;  set; }
        public StatusOrdem Status { get;  set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
        public Cliente cliente { get;  set; }

        public Pedido() { 
        
        }

        public Pedido(DateTime dataPedido, StatusOrdem status, Cliente cliente) {
            DataPedido = dataPedido;
            Status = status;
            this.cliente = cliente;
        }

        public void AdicionarItem(ItemPedido itemPedido) {

            Itens.Add(itemPedido);
        }

        public void RemoverItem(ItemPedido itemPedido) {

            Itens.Add(itemPedido);
        }

        public double GetTotal() { 
        
            double total = 0;

            foreach (ItemPedido i in Itens) {
                total += i.SubTotal();
                }

            return total;
        
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Data Pedido: " + DataPedido.ToString("dd/MM/yy HH:mm:ss"));
            sb.AppendLine("Status Pedido: " + Status);
            sb.AppendLine("Cliente: " + cliente);
            
            foreach(ItemPedido i in Itens) {

                sb.AppendLine(i.ToString());
            }
            
            sb.AppendLine("total pedido: " + GetTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
