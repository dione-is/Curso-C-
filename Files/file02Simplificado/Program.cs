using System.IO;
using System;

namespace home {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Dione\Documents\CursoAlgoritmoELogicaC#";

            try {
                using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(path)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }catch (IOException e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}