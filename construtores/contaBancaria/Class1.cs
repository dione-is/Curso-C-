using System;
using System.Globalization;

namespace contaBancaria {
    class ContaBancaria {

        public  int numero { get; private set; }
        public string titular { get; private set; }
        public double saldo { get; private set; }

        public double taxaSaque { get; private set; } = 5;

        public ContaBancaria(int numero, string titular, double saldo) {
            
            this.numero = numero;  
            this.titular = titular;
            this.saldo = saldo;
        }

        public ContaBancaria() { 
        }

        public ContaBancaria(int numero, string titular) {
            this.numero = numero ;
            this.titular = titular;
        }

        public void Deposito (double valor) {
            this.saldo += valor;
        }

        public void Saque (double valor) {
            this.saldo -= valor + taxaSaque;
        }

        public override string ToString() {

            return "Conta: "
                    + numero
                    + " titular: "
                    + titular
                    + " saldo: "
                    + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
