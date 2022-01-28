using System;
using System.Collections.Generic;
using System.Globalization;
using Predicate.Entity;

namespace home {
    class Program {
        static void Main(string[] args) {

            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto("tv Samsumg 4k", 2899.99));
            produtos.Add(new Produto("nootBook Nitro", 5000.10));
            produtos.Add(new Produto("sanduicheira", 299.99));
            produtos.Add(new Produto("pneu Pirelli", 599.98));

            // produtos.RemoveAll(p => p.Preco < 1000); funcao lambda tambem daria certo;

            produtos.RemoveAll(ProdutoRemove); //Predicate é um delegate, uma referencia para uma função;

            foreach (Produto p in produtos) { 
                
                Console.WriteLine(p);
            }
        }

        public static bool ProdutoRemove(Produto p) {

            return p.Preco <= 1000.00;
        }
    }
}