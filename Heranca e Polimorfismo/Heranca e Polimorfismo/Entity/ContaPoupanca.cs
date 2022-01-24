using System;


namespace Heranca_e_Polimorfismo.Entity {
    class ContaPoupanca : Conta {

        public double Taxa { get; private set; }

        public ContaPoupanca() {

        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxa) : base(numero,titular,saldo) {
            Taxa = taxa;
        }

        public void  atualizarSaldo () {
            saldo += (Taxa / 100) * saldo;
        }

        public override void Saque(double valor) {
            saldo -= valor;
        }
    }
}
