using System;
using System.Globalization;
using contaBancaria;

namespace conta;

class Program {

    static void Main(string[] args) {

        int numero;
        double saldo, valor;
        string titular;
        char opcaoDeposito;

        Console.WriteLine("Informe o numero da conta e titular: ");
        numero = int.Parse(Console.ReadLine());
        titular = Console.ReadLine();

        ContaBancaria conta = new (numero, titular);

        Console.WriteLine("deseja fazer primeiro deposito ?");
        opcaoDeposito = char.Parse(Console.ReadLine());

        if (opcaoDeposito == 's' || opcaoDeposito == 'S') {
            Console.WriteLine("informe o valor para deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaBancaria(numero, titular, valor);
        }

        conta.Deposito(1000.00);
        conta.Saque(350.50);

        Console.WriteLine(conta);
    }
}