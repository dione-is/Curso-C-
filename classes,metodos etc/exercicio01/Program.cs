using exercicio01;
using System;
using System.Globalization;

namespace Curso;

class Program {
    static void Main(string[] args) {

        Pessoa arthur, rafaela;
        double media = 0.0, adicionalSalario = 0.0;
        
        arthur = new Pessoa();
        rafaela = new Pessoa();

        arthur.nome = "Arthur navaski";
        arthur.idade = 18;
        arthur.salario = 1500.00;

        rafaela.nome = "Rafaela Moreira";
        rafaela.idade = 27;
        rafaela.salario = 3800.00;

        arthur.MaiorIdade(arthur,rafaela);
        
        Console.WriteLine("MEdia salarial de " + arthur.MediaSalarial(arthur,rafaela));

        Console.WriteLine("Informe o adicional de salario: ");
        adicionalSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        arthur.AdicionalSalario(adicionalSalario);

        Console.WriteLine("informe o adicinal de salario: ");
        adicionalSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        rafaela.AdicionalSalario(adicionalSalario);

    }

}
