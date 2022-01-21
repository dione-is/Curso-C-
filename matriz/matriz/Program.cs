using System;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz;
        int tam = 0, qtdNegativo = 0;
        int[] vetorDiagonal;
        
        Console.WriteLine("informe o tamanho da matriz: ");
        tam = int.Parse(Console.ReadLine());

        matriz = new int[tam,tam];
        vetorDiagonal = new int[tam];

        for (int i = 0; i < tam; i++)
        {
            string[] vet = Console.ReadLine().Split(' ');

            for (int j = 0; j < tam; j++)
            {
                matriz[i,j] = int.Parse(vet[j]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("matriz :");
        for (int i = 0;i < tam; i++)
        {
            for (int j = 0;j < tam; j++)
            {
                if ( matriz[i,j] < 0 )
                {
                    qtdNegativo++;
                }
                if (i == j )
                {
                    vetorDiagonal[i] = matriz[i,j];
                }
                Console.Write(matriz[i,j] + " ");
                if (j == 2)
                {
                    Console.WriteLine();
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Quantidade Negativos: " + qtdNegativo);
        Console.WriteLine("diagonais: ");
        for ( int i = 0; i < vetorDiagonal.Length ; i++)
        {
            Console.Write(vetorDiagonal[i] + " ") ;
        } 
    }
}