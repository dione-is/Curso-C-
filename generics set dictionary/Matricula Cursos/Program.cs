using System;
using System.Collections.Generic;
using Matricula_Cursos.Entity;

namespace home {
    class Program {
        static void Main(string[] args) {

            HashSet<Alunos> alunos = new HashSet<Alunos>();

            Console.WriteLine("Quantidade de estudande no Curso ADS: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.Write("Matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                alunos.Add(new Alunos(matricula, nome));

            }

            Console.WriteLine("Quantidade de estudande no Curso EngSot: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.Write("Matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                alunos.Add(new Alunos(matricula, nome));

            }

            Console.WriteLine("Quantidade de estudande no Curso Redes: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.Write("Matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                alunos.Add(new Alunos(matricula, nome));

            }

            Console.WriteLine("Alunos: " + alunos.Count);
        }
    }
}