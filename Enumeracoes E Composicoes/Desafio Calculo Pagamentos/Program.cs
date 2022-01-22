using System;
using System.Globalization;
using Desafio_Calculo_Pagamentos.Entity;
using Desafio_Calculo_Pagamentos.Entity.Enums;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("nome: ");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine("nivel do Funcionario(Junior/Pleno/Senior)");
            NivelFuncionario nivel = Enum.Parse<NivelFuncionario>(Console.ReadLine());
            Console.WriteLine("Informe o salario base");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o deparmento");
            string dep = Console.ReadLine();
            Departamento departamento = new Departamento(dep);

            funcionario1 = new Funcionario(nomeFuncionario, nivel, salario, departamento);

            ContratoHoras contratoHoras = new ContratoHoras();

            char opcao;
            do
            {
                Console.WriteLine("Deseja adicionar um contrato ? [S/N");
                opcao = char.Parse(Console.ReadLine());

                if (opcao == 's')
                {
                    Console.WriteLine("Informe a data do contrato: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("informe o valor por horas");
                    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("informe quantidade de horas");
                    int QtdHoras = int.Parse(Console.ReadLine());

                    contratoHoras = new ContratoHoras(data, valorHora, QtdHoras);

                    funcionario1.AdicionarContrato(contratoHoras);
                }

            } while (opcao != 'n');

            do
            {
                Console.WriteLine("deseja remover algum contrato? [s/n]");
                opcao = char.Parse(Console.ReadLine());

                if (opcao == 's')
                {
                    funcionario1.RemoverContrato(contratoHoras);
                }

            }while (opcao != 'n');

            Console.WriteLine("Informe o mes/ano para que seja calculado a renda no periodo ");
            Console.WriteLine("mes");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("ano");
            int ano = int.Parse(Console.ReadLine());
            double renda = funcionario1.renda(mes, ano);

            Console.WriteLine(funcionario1 + " " + renda.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
