using System;
using System.Collections.Generic;

namespace Heranca_e_Polimorfismo.Entity {
    class ContaPJ : Conta {

        public double Limite { get; private set; }

        public ContaPJ() { 
        
        } 

        public ContaPJ(int numero, string titular, double saldo, double limite) : base (numero, titular,saldo){
            Limite = limite;
        }

        public void RealizarEmprestimo(double valor) {
            if (valor <= Limite) {
                saldo += valor;
            }
        }
    }
}
