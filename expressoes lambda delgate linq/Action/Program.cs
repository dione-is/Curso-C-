using System;
using System.Collections.Generic;
using System.Globalization;
using Action.Entity;

namespace home {
    class Program {
        static void Main(string[] args) {
        
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto("tv Samsumg 4k", 2899.99));
            produtos.Add(new Produto("nootBook Nitro", 5000.10));
            produtos.Add(new Produto("sanduicheira", 299.99));
            produtos.Add(new Produto("pneu Pirelli", 599.98));

            Action<Produto> act  = AdionarAumento;
            produtos.ForEach(act);

            foreach (Produto p in produtos) { 
            
                Console.WriteLine(p);
            }

        }

        static void AdionarAumento(Produto produto) { 
            
            produto.Preco += produto.Preco * 0.01;
        }
    }
}