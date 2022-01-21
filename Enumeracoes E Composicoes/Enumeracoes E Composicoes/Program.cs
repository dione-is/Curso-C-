using Enumeracoes_E_Composicoes.Entity;
using Enumeracoes_E_Composicoes.Entity.Enums;
using System;
using System.Globalization;

namespace Curso {
    class program {
        static void Main(string[] args) { 
            
            Order order = new Order {
                id = 1,
                moment = DateTime.Now,
                status = OrderStatus.Processando
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Entregue.ToString();

            Console.WriteLine(txt);
        } 
    }
}