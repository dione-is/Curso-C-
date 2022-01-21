using System;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TABUADA");

        Console.WriteLine("Informe um numero: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " * " + i + " = " + n*i);
        }
    }
}