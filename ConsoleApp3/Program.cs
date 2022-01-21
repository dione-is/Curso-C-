using System;
using System.Globalization;

namespace cursoAlgoritimoLogica.trainee01;

class trainee01
{
   static void Main(String[] args)
    {
        int idade = 0;

        Console.Write("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());
        Console.Write("Informe seu Nome e SobreNome: ");
        String[] nomeSobrenome = Console.ReadLine().Split(' ');

        Console.WriteLine("Nome: " + nomeSobrenome[0] + ", idade: " + idade + ", SobreNome: " +
            nomeSobrenome[1]);

    }
}