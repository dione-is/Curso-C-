using System;
using System.Globalization;
using Servico_de_Pagamento.Entity;
using Servico_de_Pagamento.Service;

namespace home {

    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Numero Contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de contrato: ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contrato contrato  = new(numeroContrato, dataContrato, valor);
         

            Console.WriteLine("informe a quantidade de parcelar: ");
            int qtdParcelas = int.Parse(Console.ReadLine());

            ContratoService contratoService = new ContratoService(new PaypayService());

            contratoService.ProcessarContrato(contrato,qtdParcelas);
            
            Console.WriteLine("Parcelas: ");
            foreach (Parcela p in contrato.Parcelas) {

                Console.WriteLine(p);
            }

        }
    }
}