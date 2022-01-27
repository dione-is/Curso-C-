using System;
using System.Collections.Generic;

namespace home {
    class Program {
        static void Main(string[] args) {

            SortedSet<int> setA = new SortedSet<int>() { 2, 4, 6, 8, 10};
            SortedSet<int> setB = new SortedSet<int>() { 2, 4, 6, 7, 9 };

            // union
            SortedSet<int> setc = new SortedSet<int>(setA);
            setc.UnionWith(setB);
            Console.WriteLine("Union");
            ImprimirSortedSet(setc);

            // intersection
            SortedSet<int> setD = new SortedSet<int>(setA);
            setD.IntersectWith(setB);
            Console.WriteLine();
            Console.WriteLine("Intersection");
            ImprimirSortedSet(setD);

            SortedSet<int> setE = new SortedSet<int>(setA);
            setE.ExceptWith(setB);
            Console.WriteLine();
            Console.WriteLine("Except");
            ImprimirSortedSet(setE);
        }

        static void ImprimirSortedSet<T>(IEnumerable<T> colecao) {

            Console.Write("{ ");
            foreach (T t in colecao) {
                Console.Write(t + ", ");
            }
            Console.Write(" }");
        }

    }
}