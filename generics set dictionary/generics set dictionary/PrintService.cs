using System;

namespace generics_set_dictionary {
    class PrintService<T> {

        private T[] _values = new T[10];

        private int contador = 0;


        public void AdicionarObject(T value) { 
            
            if (contador == 10 ) {
                throw new Exception(" vetor ja esta cheio");
            }else {
                _values[contador] = value;
                contador++;
            }
        }

        public T PrimeiroValor() {

            if (contador == 0) {

                throw new Exception("Vetor esta vazio");
            }
            else {
                return _values[0];
            }
        }

        public void Imprimir() {

            Console.Write("[");
            for (int i = 0; i < contador -1; i++) {

                Console.Write(_values[i] + ", ");
            }

            if(contador > 0) {

                Console.Write(_values[contador-1]);
            }
            Console.WriteLine("]");

        }
    }
}
