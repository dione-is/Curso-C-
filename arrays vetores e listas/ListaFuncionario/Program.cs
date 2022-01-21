using System;
using System.Globalization;
using ListaFuncionario;

namespace Desafio {
    class Program {
        static void Main(string[] args) {

            List<Funcionario> listaFuncionario = new List<Funcionario>();

            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("quantos funcionario deseja adicionar ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.WriteLine("informe id, nome e salario do funcionario");
                long id = long.Parse(Console.ReadLine());
                string nome = Console.ReadLine();
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


                funcionario1 = new Funcionario(id, nome, salario);
                
                listaFuncionario.Add(funcionario1);
            }

            Console.WriteLine("qual funcionario deseja inserir aumento ?");
            long idBusca = long.Parse(Console.ReadLine());

            Funcionario funcionarioEncontrado = listaFuncionario.Find(x => x.id == idBusca);

            if (funcionarioEncontrado == null) {
                Console.WriteLine("nao existe ");
            }
            else {
                funcionarioEncontrado.adicionarSalario(10);

                foreach (Funcionario obj in listaFuncionario) {

                    Console.WriteLine(obj);
                }
            }


        }
    }
}