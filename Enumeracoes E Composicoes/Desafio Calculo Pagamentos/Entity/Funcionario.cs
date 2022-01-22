
using System.Collections.Generic;
using Desafio_Calculo_Pagamentos.Entity.Enums;


namespace Desafio_Calculo_Pagamentos.Entity {
    class Funcionario {
        
        public string Nome { get; set; }
        public NivelFuncionario Nivel { get; set; }
        public double Salario { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHoras> contratoHoras { get; private set; } = new List<ContratoHoras>();
        
        public Funcionario() {
        
        }

        public Funcionario (string nome, NivelFuncionario nivel, double salario, Departamento departamento ) { 
            
            Nome = nome;
            Nivel = nivel;
            Salario = salario;
            Departamento = departamento;
        }



        public void AdicionarContrato( ContratoHoras contrato )
        {
            contratoHoras.Add( contrato );

        }

        public void RemoverContrato ( ContratoHoras contrato )
        {
            contratoHoras.Remove(contrato );
        }

        public double renda (int mes, int ano)
        {
            double soma = Salario;
            foreach (ContratoHoras contrato in contratoHoras)
            {
                if (contrato.Date.Year == ano && contrato.Date.Month == mes)
                {
                    soma += contrato.TotalValor();
                }
            }
            return soma;
        }

        public override string ToString()
        {
            return Nome
                    + ", "
                    + Nivel.ToString()
                    + ", "
                    + Departamento.Nome
                    + ", ";
        }

    }
}
