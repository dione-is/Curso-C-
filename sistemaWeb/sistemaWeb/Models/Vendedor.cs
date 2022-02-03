using System;
using System.Collections.Generic;
using System.Linq;


namespace sistemaWeb.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public double SalarioBase { get; set; }

        public ICollection<RegistroVendas> listaVendas { get; set; } = new List<RegistroVendas>();

        public Departamento Departamento { get; set; }

        public int DepartamentoId { get; set; }

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda( RegistroVendas venda)
        {
            listaVendas.Add(venda);
        }

        public void RemoverVenda(RegistroVendas venda)
        {
            listaVendas.Remove(venda);
        }

        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            /*  esta forma acredito que tambem funcionaria, porem com expressao lambda fica melhor;
            double soma = 0.0;
            foreach (RegistroVendas v in listaVendas)
            {
                if (v.Data >= dataInicio && v.Data <= dataFim)
                {
                    soma += v.Valor;
                }
            } 
            */

            return listaVendas.Where(venda => venda.Data >= dataInicial && venda.Data <= dataFinal).Sum(venda => venda.Valor);
        }
    }
}
