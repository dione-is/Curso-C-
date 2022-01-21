using System;
using System.Globalization;
using arrays_vetores_e_listas;

namespace curso;

class Program {
    static void Main(string[] args) {

        double preco, soma;
        int n;
        string nome;

        soma = 0;

        Console.WriteLine("informe a quantidade de produtos");
        n = int.Parse(Console.ReadLine());

        Produto[] Vetor = new Produto[n];

        for (int i = 0; i < Vetor.Length; i++) {
            Console.WriteLine("nome");
            nome = Console.ReadLine();
            Console.WriteLine("preço");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Vetor[i] = new Produto (nome,preco);

            soma += preco;
        }

        Console.WriteLine("========================================");

        for (int i = 0; i < Vetor.Length; i++) {

            Console.WriteLine(Vetor[i]);
        }

        Console.WriteLine(" ticket medio: " + (soma / n).ToString("F2", CultureInfo.InvariantCulture));
    }
}