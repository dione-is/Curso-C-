using System;
using System.Globalization;
using Pensionato;

namespace Desafio;

class Program {
    static void Main(string[] args) {

        int n, quarto;
        string nome, email;


        Console.WriteLine("quantos quartos deseja ocupar? ");
        n = int.Parse(Console.ReadLine());

        Cliente[] vetor = new Cliente[10];

        for (int i = 0; i < n; i++) {

            do {

                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("email: ");
                email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                if (vetor[quarto] == null) {

                    vetor[quarto] = new Cliente(nome, email, quarto);

                }
                else {
                    Console.WriteLine("Quarto ja esta ocupado");
                }

            } while (vetor[quarto].nome != nome);

        }

        Console.WriteLine("Apresentar quartos ocupados: ");

        for (int i = 0; i < vetor.Length; i++) {

            if (vetor[i] != null) {
                Console.WriteLine(vetor[i]);
            }

        }

    }
}