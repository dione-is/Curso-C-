using System;
using System.Collections.Generic;
using System.Globalization;

namespace Servico_Calcular.Service {
    class CalcularService {

        public T Max<T>(List<T> list) where T : IComparable { 
        
            if (list.Count == 0) {
                throw new ArgumentException("Lista esta vazia");
            }

            T max = list[0];

            for (int i = 1; i < list.Count; i++) {

                if (list[i].CompareTo(max) > 0) { 
                    max = list[i];
                }
            }

            return max;

        }
    }
}
