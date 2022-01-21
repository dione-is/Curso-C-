using System;
using System.Globalization;

namespace curso; //calculo de x(1) e x(2) formulada de baskara

class program
{
    static void Main(string[] args)
    {
        double a, b, c,delta, x1,x2;

        Console.WriteLine("informe o valor de a, b e c: ");

        String[] vetor = Console.ReadLine().Split(' ');
        a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
        b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        c = double.Parse(vetor[2], CultureInfo.InvariantCulture);
       
        if(a > 0.0)
        {
            //calculado delta
            delta = Math.Pow(b, 2.0) - (4 * a * c);
            if (delta > 0.0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("RESULTADO");
                Console.WriteLine("x1: " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("x2: " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }else
            {
                Console.WriteLine("Delta nao pode ser negativo");
            }
        }
        else
        {
            Console.WriteLine("o valor de A nao pode ser igual a zero ou negativo");
        }
        

        



    }
}