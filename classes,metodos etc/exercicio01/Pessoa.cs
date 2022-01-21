using System.Globalization;

namespace exercicio01;
class Pessoa {

    public string nome;
    public int idade;
    public double salario;

    public void MaiorIdade(Pessoa pessoa1, Pessoa pessoa2) {

        if (pessoa1.idade > pessoa2.idade) {
            Console.WriteLine("a pessoa mais velha é: " + pessoa1.nome);
        }else {
            Console.WriteLine("a pessoa mais velha é: " + pessoa2.nome);
        }

    }

    public double MediaSalarial(Pessoa pessoa1, Pessoa pessoa2) {

        double media = (pessoa1.salario + pessoa2.salario) / 2;
        return media;
    }

    public void AdicionalSalario(double adicional) {
        
        salario += (adicional / 100) * salario;
        Console.WriteLine("Salario atualizado: " + nome + ", R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}

