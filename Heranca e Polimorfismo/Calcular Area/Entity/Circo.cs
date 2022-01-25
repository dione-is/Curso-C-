using Calcular_Area.Entity.Enum;
using System.Globalization;
using System;

namespace Calcular_Area.Entity {
    class Circo : Figuras {

        public double Raio { get; set; }
       

        public Circo(double raio, Cor cor) : base(cor){
            Raio = raio;
        }

        public override double Area() {
            return Math.PI * Math.Pow(Raio,2);
        }
    }
}
