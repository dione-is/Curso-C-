using System;

namespace curso;

class Program
{
    static void Main(string[] args)
    {
        int opcao;
        String dia;

        Console.WriteLine("informe o dia");
        opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1:
                dia = "Domingo";
                break;
            case 2:
                dia = "Segunda";
                break;
            case 3:
                dia = "Terca";
                break;
            case 4:
                dia = "Quarta";
                break;
            case 5:
                dia = "Quinta";
                break;
            case 6:
                dia = "Sexta";
                break;
            case 7:
                dia = "Sabado";
                break;
            default:
                dia = "numero invalido";
                break;
                
        }
        Console.WriteLine(dia);
    }
}