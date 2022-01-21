using System;
using System.Globalization;

namespace curso;

class program
{
    static void Main(string[] args)
    {
        double nota1, nota2, media;

        Console.WriteLine("Primeiro Bimestre");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("segundo Bimestre");
        nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        media = (nota1 + nota2) / 2.0;
        Console.WriteLine();

        if (media > 6.0)
        {
            Console.WriteLine(media.ToString("F1"));
            Console.WriteLine("APROVADO");
        }
        else if (media == 6.0 )
        {
            Console.WriteLine(media.ToString("F1"));
            Console.WriteLine("RECUPERACAO");
        }
        else
        {
            Console.WriteLine(media.ToString("F1"));
            Console.WriteLine("REPROVADO");
        }


    }
}