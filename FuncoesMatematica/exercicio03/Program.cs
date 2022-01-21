using System;
using System.Globalization;

namespace curso;

class program
{
    static void Main(string[] args)
    {

        String nome1, nome2;
        int idade1, idade2;
        double media;
        String[] vetor;

        vetor = Console.ReadLine().Split(" ");
        nome1 = vetor[0];
        idade1= int.Parse(vetor[1]);

        vetor = Console.ReadLine().Split(" "); 
        nome2 = vetor[0];
        idade2 = int.Parse(vetor[1]);

        media = (double)(idade1 + idade2) / 2.0;

        Console.WriteLine(nome1 + " e " + nome2 + " tem a media de idade: "
            + media.ToString("F1", CultureInfo.InvariantCulture));


    }
}