using System;
using System.Collections.Generic;
using System.IO;

namespace home {
    class Program {
        static void Main(string[] args) {

            
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path)) {

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                while (!sr.EndOfStream) {

                    string[] line = sr.ReadLine().Split(',');
                    string nome = line[0];
                    int votos = int.Parse(line[1]);

                    if (dictionary.ContainsKey(nome)) {
                        dictionary[nome] += votos;
                    }
                    else {
                        dictionary[nome] = votos;
                    }

                }

                foreach (var voto in dictionary) {

                    Console.WriteLine(voto.Key + ": " + voto.Value);
                }

            }
        }
    }
}