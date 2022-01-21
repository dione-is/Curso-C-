using System;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        int x = 0, soma = 0, qtd = 0;

        qtd = int.Parse(Console.ReadLine());

        for (int i = 1; i <= qtd; i++)
        {
            x = int.Parse(Console.ReadLine());
            soma += x; 
        }

        Console.WriteLine(soma);
    }
}