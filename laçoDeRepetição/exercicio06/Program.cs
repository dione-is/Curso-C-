using System;
using System.Globalization;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        char opcao = 's';
        double celsus, farenait;
        
        celsus = 0.0;
        farenait = 0.0;

        do
        {
            Console.WriteLine("informe a temperatura em Celsus");
            celsus = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            farenait = (9 * celsus) / 5 + 32.0;
            Console.WriteLine("Equivalente em Farenaith: " + farenait.ToString("F1", CultureInfo.InvariantCulture));

            Console.WriteLine("deseja continuar ? [s/n]");
            opcao = char.Parse(Console.ReadLine());

        }while (opcao == 's');
    }
}