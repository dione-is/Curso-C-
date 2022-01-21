using System;
using System.Globalization;

namespace cursoAlgoritmoLogica.trainee02;

class Program
{
    static void Main(string[] args)
    {
        double x = 3.0;
        double y = 4.0;
        double z = -5.0;
        double a,b, c;

        // a recebe raiz quadrada de x            -> a = Math.Sqrt(x);
        // a recebe  o resultado de x elevado a y -> Math.Pow(x,y)
        // a ecebe o valor absoluto de x          -> Math.ABS(x)

        a = Math.Sqrt(x);
        b = Math.Pow(x, y);
        c = Math.Abs(z);

        Console.WriteLine("Raiz quadrada de " + x + " e igual a: " + a);
        Console.WriteLine("Resultado de "+ x + " elevado a "+ y + " e igual a: " + b);
        Console.WriteLine("O valor absoluto de " + z + " e igual a " + c);
    }
}
