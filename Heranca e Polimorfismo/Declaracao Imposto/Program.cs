using System;
using System.Globalization;
using Declaracao_Imposto.Entity;


namespace home {

    class Program {
        static void Main(string[] args) {

            List<Contribuinte> contribuintes = new List<Contribuinte>();

            Console.WriteLine("informe a quantidade de contribuintes: ");
            int qtdContribuinte = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdContribuinte; i++) {
                Console.WriteLine("informe o tipo de contribuinte [f]Fisica / [J]Juridica: ");
                char tipoContribuinte = char.Parse(Console.ReadLine());
                Console.WriteLine("nome : ");
                string nome = Console.ReadLine();
                Console.WriteLine("Renda: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipoContribuinte == 'f') {

                    Console.WriteLine("Gasto com plano de saude");
                    double gastoSaude = double.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaFisica(nome, renda, gastoSaude));

                }
                else if (tipoContribuinte == 'j') {

                    Console.WriteLine("informe a quantidade de funcionario: ");
                    int qtdFuncioario = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(nome, renda, qtdFuncioario));
                }
            }

            double totalImposto = 0.0;

            foreach (Contribuinte c in contribuintes) {

                Console.WriteLine(c.Nome + ", " + c.CalculoImposto().ToString("F2", CultureInfo.InvariantCulture));
                totalImposto += c.CalculoImposto();

            }

            Console.WriteLine("Total imposto recolhido: ");
            Console.WriteLine(totalImposto.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}