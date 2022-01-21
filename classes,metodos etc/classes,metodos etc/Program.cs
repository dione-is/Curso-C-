using classes_metodos_etc;
using System;
using System.Globalization;

namespace curso;

class Program {
    static void Main(string[] args) {

        double areaX, areaY,p;
        Triangulo x,y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("informe as medidas do triangulo x");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        p = (x.A + x.B + x.C) / 2.0;
        areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

        Console.WriteLine("informe as medidas do triangulo y");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        p = (y.A + y.B + y.C) / 2.0;
        areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

        Console.WriteLine("area do triangulo x: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("area do triangulo y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

    }
}
