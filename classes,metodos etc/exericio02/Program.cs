using System;
using System.Globalization;
using exercicio02;

namespace program;

class Program {
    static void Main(string[] args) {

        Produto aguaMineral;
        aguaMineral = new Produto();
        int qtd = 0;

        Console.WriteLine("informe o nome do produto: ");
        aguaMineral.nome = Console.ReadLine();
        Console.WriteLine("informe o preço do produto: ");
        aguaMineral.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("informe o estoque: ");
        aguaMineral.quantidade = int.Parse(Console.ReadLine());

        aguaMineral.DadosEstoque();

        Console.WriteLine("adicionar estoque: " );
        qtd = int.Parse(Console.ReadLine());
        aguaMineral.AdicionarEstoque(qtd);

        aguaMineral.DadosEstoque();

        Console.WriteLine("remover estoque: ");
        qtd = int.Parse(Console.ReadLine());
        aguaMineral.RemoverEstoque(qtd);

        aguaMineral.DadosEstoque();

    }
}
