using System;
using System.Globalization;
using Heranca_e_Polimorfismo.Entity;

namespace Home {
    class Program {
        static void Main(string[] args) {

            ContaPJ contaPj = new ContaPJ(0098, "joao", 987.77, 1000.00);

            contaPj.RealizarEmprestimo(500);

            Console.WriteLine(contaPj.saldo.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}