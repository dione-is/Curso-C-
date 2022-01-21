using System;

namespace Curso;

class Program
{
    static void Main(string[] args)
    {
        //verificar a soma dos numeros impares entre dois valores
        int n1, n2, maior, menor, soma;

        n1 = 0;
        n2 = 0;
        maior = 0;
        menor = 0;
        soma = 0;
          

        Console.WriteLine("Informe um valor: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe outro valor: ");
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            maior = n1;
            menor = n2;
        }
        else
        {
            menor = n1;
            maior = n2;
        }

        Console.WriteLine("valores entre " + menor + " e " + maior);

        for(int i = menor; maior > i; i++)
        {
            if (i % 2 != 0 && i != menor)
            {
                Console.WriteLine(i);
                soma += i;
            }
        }

        Console.WriteLine("total: " + soma);
    }
}