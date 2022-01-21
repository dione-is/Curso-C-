using System;
using System.Globalization;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marcos");

            foreach (string s in list) { 
                
                Console.WriteLine(s);
            }

            string buscaPrimeiraLetra = list.Find(x => x[0] == 'B');
            string buscaUltimaLetra = list.FindLast(x => x[0] == 'M');
            int buscaPosicao1 = list.FindIndex(x => x[0] == 'A');
            int buscaPosicao2 = list.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("Buscar nome primeira Letra P " + buscaPrimeiraLetra);
            Console.WriteLine("Buscar nome ultima letra o " + buscaUltimaLetra);
            Console.WriteLine("buscar indice nome primeira letra P " + buscaPosicao1);
            Console.WriteLine("Buscar indice nome ultima letra o " + buscaPosicao2);

            Console.WriteLine( "tamanho da lista: " + list.Count);
            Console.WriteLine("-------------------------------------------------");
            List <string> list2 = list.FindAll(x => x[0] == 'B');

            foreach (string s in list2) {
                Console.WriteLine(s);
            }
            Console.WriteLine( "--------------------------------------------------");

          //  list.RemoveRange(2, 2);
            list.Remove("Maria");
            list.RemoveAll(x => x[0] == 'A');

            foreach (string s in list) {

                Console.WriteLine(s);
            }
            
        }
    }
}