using System;
using System.IO;
using log_Usuario.Entity;

namespace Course {
    class Program {
        static void Main(string[] args) {

            HashSet < RegistroAcesso > set = new HashSet<RegistroAcesso>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {

                        string[] line = sr.ReadLine().Split(' ');
                        string nome = line[0];
                        DateTime horario= DateTime.Parse(line[1]);
                        set.Add(new RegistroAcesso { Nome = nome, Horario = horario });
                    }

                    Console.WriteLine("Total de Usuarios: " + set.Count);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}