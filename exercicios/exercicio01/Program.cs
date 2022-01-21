using System;
using System.Globalization;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        int n = 0, contador16Anos = 0;
        double media = 0.0, soma = 0.0, qtd16Anos = 0.0;
        string[] nomes = null;
        int[] idade = null;
        double[] altura = null;


        Console.WriteLine("Informe a quantidade de pessoas");
        n =int.Parse(Console.ReadLine());

        nomes = new string[n];
        idade = new int[n];
        altura = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write((i+1) + ": ");
            string[] vetor = Console.ReadLine().Split(' ');
            nomes[i] = vetor[0];
            idade[i] = int.Parse(vetor[1]);
            altura[i] = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            soma += altura[i];
            
            if (idade[i] < 16)
            {
                contador16Anos++;
            }
            
        }

        foreach (double x in altura)
        {
            Console.WriteLine(x);
        }

        media = (double)soma / n;
        qtd16Anos =(double) contador16Anos / n * 100 ;

        Console.WriteLine();
        
        Console.WriteLine("pessoa com menos de 16 anos: " + qtd16Anos + "%");
        Console.WriteLine("altura media: " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}