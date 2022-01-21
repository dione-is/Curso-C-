using System;
using System.Globalization;

namespace ListaFuncionario {
    class Funcionario {

        public long id { get; set; }
        public string nome { get; set; }
        public double salario { get; set; }

        public Funcionario() { 
        
        }
        public Funcionario(long id, string nome, double salario) {

            this.id = id;   
            this.nome = nome;
            this.salario = salario;
        }

        public void adicionarSalario(double adicional) {
            salario += (adicional / 100) * salario;
        }

        public override string ToString() { 
            
            return id
                + ", "
                + nome
                + ", "
                + salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
