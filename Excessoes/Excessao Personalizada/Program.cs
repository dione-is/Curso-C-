using System;
using Excessao_Personalizada.Entity;
using Excessao_Personalizada.Entity.Exception;
using System.IO;

namespace home {
    class Program {
        static void Main(string[] args) {

            try {
                Console.WriteLine("quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                Console.WriteLine("Entrada: ");
                DateTime entrada = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("saida: ");
                DateTime saida = DateTime.Parse(Console.ReadLine());

                Reservas reserva = new Reservas(quarto, entrada, saida);
                Console.WriteLine("deseja atualizar a data [s/n]");
                char opcao = char.Parse(Console.ReadLine());

                if (opcao == 's') {
                    Console.WriteLine("Entrada: ");
                    entrada = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("saida: ");
                    saida = DateTime.Parse(Console.ReadLine());
                    reserva.AtualizarReserva(entrada, saida);
                }

                Console.WriteLine(reserva);
            }catch (DomainException e) {
                Console.WriteLine(" Erro de Processamento: " + e.Message);
            }


        }
    }
}
