using System;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        int x, y;

        String[] vetor = Console.ReadLine().Split(' ');        
        x = int.Parse(vetor[0]);
        y = int.Parse(vetor[1]);

        while(!(x == y))
        {
            if (x < y)
            {
                Console.WriteLine("...::: CRESCENTE :::...");
            }else if (x > y)
            {
                Console.WriteLine("...::: DECRESCENTE :::...");
            }

            vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
        }
    }
}