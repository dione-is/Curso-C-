using System;
using System.Globalization;
using Heranca_e_Polimorfismo.Entity;

namespace Home {
    class Program {
        static void Main(string[] args) {

            ContaPJ contaPj = new ContaPJ(0098, "joao", 987.77, 1000.00);
            ContaPoupanca contaPoupanca = new ContaPoupanca(0098, "joao", 1000.00, 10.0);

            contaPj.RealizarEmprestimo(500);

            Console.WriteLine(contaPj.saldo.ToString("F2", CultureInfo.InvariantCulture));
            
            contaPoupanca.atualizarSaldo();

            Console.WriteLine(contaPoupanca.saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            ContaPJ contaTestSaque = new ContaPJ(02, "maria", 500, 200);
            ContaPoupanca contaTest = new ContaPoupanca(003, "pedro", 500, 5.0);

            contaTestSaque.Saque(50.00);
            contaTest.Saque(50.00);

            Console.WriteLine(contaTestSaque.saldo);
            Console.WriteLine(contaTest.saldo);
            

        }
    }
}