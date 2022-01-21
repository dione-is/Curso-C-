using System;
using System.Globalization;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor;
        int n = 4;

        vetor = new int[4];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i;
            Console.WriteLine(vetor[i]);
        }
        
    }
}