using System;
using System.Globalization;

namespace curso;
class program
{
    static void Main(string[] args)
    {
        double area, perimetro, largura, comprimento, diagonal;

        Console.Write("largura: ");
        largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("comprimento: ");
        comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        area = largura * comprimento;
        perimetro = largura * 2 + comprimento * 2;

        diagonal = Math.Sqrt((Math.Pow(largura,2)) + (Math.Pow(comprimento,2)));

        Console.WriteLine("largura: " + largura.ToString("F4"));
        Console.WriteLine("Comprimento: " + comprimento.ToString("F4"));
        Console.WriteLine("area: " +area.ToString("F4"));
        Console.WriteLine("perimetro: " + perimetro.ToString("F4"));
        Console.WriteLine("diagonal: " + diagonal.ToString("F4"));


    }
}