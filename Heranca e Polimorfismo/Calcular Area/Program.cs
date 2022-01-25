using System;
using System.Globalization;
using Calcular_Area.Entity;
using Calcular_Area.Entity.Enum;

namespace home {
    class Program {
        static void Main(string[] args) {

            List<Figuras> figuras = new List<Figuras>();

            Console.WriteLine("entre com o numero de figuras");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.WriteLine("figura " + i + ": ");
                Console.WriteLine("Tipo de figura : [r]retangulo / [c]circulo");
                char cr = char.Parse(Console.ReadLine());
                Console.WriteLine("Cor da figura: ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (cr == 'r') {

                    Console.WriteLine("Informe a base do retangulo: ");
                    int basee = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura do retangulo");
                    int altura = int.Parse(Console.ReadLine());
                    figuras.Add( new Retangulo(basee,altura,cor));
                
                }else if(cr == 'c') {

                    Console.WriteLine("Informe o raio do circulo: ");
                    double raio = double.Parse(Console.ReadLine());
                    figuras.Add( new Circo(raio, cor));
                }
            }

            foreach (Figuras f in figuras) {

                Console.WriteLine(f.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
