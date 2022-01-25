

using Calcular_Area.Entity.Enum;

namespace Calcular_Area.Entity {
    class Retangulo : Figuras {

        public int Base { get; set; }
        public int Altura { get; set; }

        public Retangulo(int basee, int altura, Cor cor) : base (cor) {
            Base = basee;
            Altura = altura;
        }

        public override double Area() {
            return Base * Altura;
        }
    }
}
