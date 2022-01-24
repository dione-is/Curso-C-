using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Entity {
    class Conta {

        public int Numero { get; private set; }
        public string Titula { get; private set; }
        public double saldo { get; protected set; }

        public Conta() { 
        
        }

        public Conta(int numero, string titula, double saldo) {
            Numero = numero;
            Titula = titula;
            this.saldo = saldo;
        }

        public void Saque (double valor) {
            saldo -= valor;
        }

        public void Deposito(double valor) { 
            saldo += valor;
        }
    }
}
