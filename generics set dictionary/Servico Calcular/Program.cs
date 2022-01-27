using System;
using System.Globalization;
using System.Collections.Generic;
using Servico_Calcular.Entity;
using Servico_Calcular.Service;

namespace home {
    class Program {

        static void Main(string[] args) {

            List<Produto> produtos = new List<Produto>();

            Console.WriteLine( "Informe a quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) { 
                
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos.Add(new Produto(nome, preco));
            }

            CalcularService calcularService = new CalcularService();

            Produto max = calcularService.Max(produtos);

            Console.WriteLine("Maior Preço: ");
            Console.WriteLine( max);
        }

    }
}