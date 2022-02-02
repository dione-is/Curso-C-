using System;
using System.Linq;
using System.Collections.Generic;

namespace sistemaWeb.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Vendedor> listaVendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            listaVendedores.Add(vendedor);
        }

        public double TotalVendaDepartamento(DateTime dataInicial, DateTime dataFinal)
        {
            return listaVendedores.Sum(vendedores => vendedores.TotalVendas(dataInicial, dataFinal));
        }
    }
}
