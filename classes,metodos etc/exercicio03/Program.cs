using exercicio03;
using System;
using System.Globalization;

namespace ConversoDeMoeda;

class Program {
    static void Main(string[] args) {

        double valor = 0.0;

        Console.WriteLine("Informe o valor que deseja converter real: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        valor = Conversor.Converter(valor);

        Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
    }


}