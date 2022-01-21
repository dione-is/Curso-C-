using System;
using System.Globalization;

namespace cursoAlgoritimoLogica.exercicio;

class Exercicio
{
    static void Main(string[] args)
    {
        double larguraTerreno = 0, comprimentoTerreno = 0, precoMetroQuadrado = 0, areaTotalTerreno = 0,
        precoTotalTerreno = 0;

        Console.WriteLine("Calculando preço de terreno");
        Console.WriteLine();

        Console.WriteLine("Informe a largura do terreno");
        larguraTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Informe o comprimento do terreno");
        comprimentoTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("informe o preco do metro quadrado");
        precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        areaTotalTerreno = larguraTerreno * comprimentoTerreno;
        precoTotalTerreno = areaTotalTerreno * precoMetroQuadrado;

        Console.WriteLine();
        Console.WriteLine("largura: " + larguraTerreno.ToString("F2"));
        Console.WriteLine("comprimento: " + comprimentoTerreno.ToString("F2"));
        Console.WriteLine("preco do metro quadrado: " + precoMetroQuadrado.ToString("F2"));
        Console.WriteLine("Area total do terreno " + areaTotalTerreno.ToString("F2"));
        Console.WriteLine("preco total do terreno : " + precoTotalTerreno.ToString("F2"));

    }
}