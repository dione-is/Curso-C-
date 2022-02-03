using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace sistemaWeb.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "{0} obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="{0} deve conter no maximo {1} e no minimo {2} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        [EmailAddress(ErrorMessage = "Entre com um {0} valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        [Range(1100.0, 50000.0, ErrorMessage = "{0} deve estar entre {1} até {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
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
