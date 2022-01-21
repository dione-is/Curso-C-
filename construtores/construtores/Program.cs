using System;
using pedidos;
using System.Globalization;

namespace curso;

class Program {
    static void Main(string[] args) {

        long id;
        string nome;
        double preco;

        id = long.Parse(Console.ReadLine());
        nome = Console.ReadLine();
        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Pedido pedido = new Pedido(id, nome, preco);
        pedido.aplicarCUpomDesconto();



        Console.WriteLine("-------------------------");
        Console.WriteLine(pedido);

    }
}