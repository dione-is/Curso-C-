using System;
using generics_set_dictionary;

namespace home {
    class Program {
        static void Main(string[] args) {


            PrintService<int> printService = new PrintService<int>();

            Console.WriteLine("quantos numeros ?");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) { 
            
                int numero = int.Parse(Console.ReadLine());
                printService.AdicionarObject(numero);
            }

            printService.Imprimir();
            Console.WriteLine("Primeiro: " + printService.PrimeiroValor());

        }
    }
}
