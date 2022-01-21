using System;
using System.Globalization;

namespace Topicos {
    class Program {
        static void Main(string[] args) {

            DateTime dateAtual = DateTime.Now;

            Console.WriteLine(dateAtual);

            DateTime thisDay = DateTime.Now;
            // Display the date in the default (general) format.
            Console.WriteLine(thisDay.ToString());
            Console.WriteLine();
            // Display the date in a variety of formats.
            Console.WriteLine(thisDay.ToString("d"));
            Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine(thisDay.ToString("g"));
        }
    }
}