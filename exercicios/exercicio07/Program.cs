using System;

namespace curso;

class Program
{
    static void Main(string[] args)
    {
        int valor1, valor2, valor3, menor;

        valor1 = int.Parse(Console.ReadLine());
        valor2 = int.Parse(Console.ReadLine()); 
        valor3 = int.Parse(Console.ReadLine());

        menor = valor1;

        if (menor > valor2)
        {
            menor = valor2;
        }
        if (menor > valor3 ) {
            menor = valor3;
        }

        Console.WriteLine("MENOR: " + menor);
    }
}