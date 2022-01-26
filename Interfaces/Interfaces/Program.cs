using System;
using Locacao.Entity;
using Locacao.Service;
using System.Globalization;

namespace home {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Modelo Carro: ");
            string modelo = Console.ReadLine();
            Carro carro = new Carro(modelo);
            Console.WriteLine("Data de locação: dia/mes/ano hora:minutos");
            DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.WriteLine("Data de devolução: dia/mes/ano hora:ano");
            DateTime dateFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Preço por Hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Preco por Dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguelCarro = new AluguelCarro(dataInicio, dateFim, carro);

            AluguelService aluguelService = new AluguelService(precoHora, precoDia, new BrazilTaxaService());

            aluguelService.ProcessarFatura(aluguelCarro);

            Console.WriteLine("Fatura");
            Console.WriteLine(aluguelCarro.fatura);
        }
    }
}