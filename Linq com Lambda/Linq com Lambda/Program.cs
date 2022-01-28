using System;
using System.Collections.Generic;
using System.Globalization;
using Linq_com_Lambda.Entity;

namespace home {
    class Program {

        static void ImprimirNaTela<T> (string mensagem, IEnumerable<T> colecao) {

            Console.WriteLine(mensagem);
            foreach (T obj in colecao) {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }
        static void Main(string[] args) {

            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Camada = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computadores", Camada = 1 };

            List<Produto> produtos = new List<Produto>() {
            new Produto() { Id = 1, Nome = "Mouse", Preco = 135.80, Categoria = c2 },
            new Produto() { Id = 2, Nome = "nootbok", Preco = 3600.00, Categoria = c2 },
            new Produto() { Id = 3, Nome = "martelo", Preco = 45.90, Categoria = c1 },
            new Produto() { Id = 4, Nome = "trena", Preco = 25.00, Categoria = c1 }
            };

            var r1 = produtos.Where(p => p.Categoria.Camada == 1 );
            ImprimirNaTela("Produtos da Categoria computadores: ", r1);
        }
    }
}