using System;
using System.Globalization;

namespace Calculadora {
    class Operadores {

        public static int Soma (params int[] valor) {
            
            int soma = 0;
            
            for (int i = 0; i < valor.Length; i++) {
                soma += valor[i];
            }

            return soma;
        }

        public static int Triplicar (ref int valor) {
            return valor *= 3;
        }

    }
}
