using System;
using System.Globalization;

namespace expressoes_lambda_delgate_linq {
    class CalcularService {

        public static double Sum (double a , double b) {
            return a + b;
        }

        public static void Maior(double a, double b) {

            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b); 
        }

        public static void SumCast(double a, double b) {

            Console.WriteLine(a+b);
        }
    }
}
