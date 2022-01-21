using System;
using System.Globalization;

namespace curso;

class program
{
    static void Main(string[] args)
    {
        int valor, hora, min, seg;

        valor = int.Parse(Console.ReadLine());

        hora = valor / 3600;
        min = ( valor %  3600) / 60 ;
        seg = ((valor % 3600) % 60);

        Console.WriteLine(hora + ":" + min + ":" + seg); 

    }

    /* int resto;
     * resto = valor % 3600;
     * hora = valor / 3600;
     * minuto = resto / 60;
     * segunto = resto % 60;
     */
}