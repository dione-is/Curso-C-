using System;
using System.Globalization;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        int cont = 0, idade = 0;
        double media = 0.0;
        
        idade = int.Parse(Console.ReadLine());
        
        if (idade < 0 )
        {
            Console.WriteLine("Impossivel calcular, idade negativa");
        }else
        {
            while (!(idade < 0)) {
                media += (double) idade;
                cont++;
                idade = int.Parse((Console.ReadLine()));
            }
        }
        media /= (double) cont;
        Console.WriteLine("Media de idade: " + media.ToString("F1", CultureInfo.InvariantCulture));
    }
}