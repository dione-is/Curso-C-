using System;
using System.Globalization;

namespace curso;

class Program
{
    static void Main(string[] args)
    {
        double valorFatura = 50.0, adicionalFatura = 2.0;
        int minutos;

        Console.WriteLine("informe a quantidade de minutos");
        minutos = int.Parse(Console.ReadLine());

        if (minutos > 100)
        {
            valorFatura +=  (adicionalFatura * (minutos - 100));
        }
        else
        {
            valorFatura = 50.0;
        }

        Console.WriteLine("valor fatura: " + valorFatura.ToString("F2", CultureInfo.InvariantCulture));
    }
}