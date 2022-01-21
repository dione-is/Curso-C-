using Calculadora;
using System;
using System.Globalization;

namespace Curso;

class Program {
    static void Main(string[] args) {

        int m1 = 10;

        int s1 = Operadores.Soma(4,5,11,3);

        int resultado = Operadores.Triplicar(ref m1);

        Console.WriteLine(s1);
        Console.WriteLine(m1);
        Console.WriteLine(resultado);
    }
}