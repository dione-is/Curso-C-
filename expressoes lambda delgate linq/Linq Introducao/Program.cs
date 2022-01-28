using System;

namespace home {
    class Program {
        static void Main(string[] args) {

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };

            IEnumerable<int> resultado = numeros.Where(numeros => numeros % 2 == 0).Select(numeros => numeros * 10);

            foreach (int x in resultado) {
                Console.WriteLine(x);
            }
        }
    }
}