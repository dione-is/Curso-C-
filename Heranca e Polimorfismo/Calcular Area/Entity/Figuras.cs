using System;
using Calcular_Area.Entity.Enum;

namespace Calcular_Area.Entity {
    abstract class Figuras {

        public Cor Cor { get; set; }

        public Figuras(Cor cor) {
            Cor = cor;
        }

        public abstract double Area();

        
    }
}
