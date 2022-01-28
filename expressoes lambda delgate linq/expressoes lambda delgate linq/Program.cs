using System;
using expressoes_lambda_delgate_linq;
using System.Globalization;

namespace home {

    delegate double OperacaoNumericaBinaria(double x , double y);
    //delgate cast
    delegate void OperacaoNumericaBinariaCast(double x, double y);
    class Program {
        static void Main(string[] args) {

            double a = 5.0;
            double b = 7.0;

            OperacaoNumericaBinaria op = CalcularService.Sum;
            OperacaoNumericaBinariaCast opCast = CalcularService.SumCast;
            opCast += CalcularService.Maior;

            Console.WriteLine(op(a,b));
            Console.WriteLine("\n Delgate Cast: ");
            opCast(a,b);

        }
    }
}